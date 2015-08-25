﻿namespace R440O.R440OForms.VoltageStabilizer
{
    using System;
    using N502B;

    public static class VoltageStabilizerParameters
    {
        static VoltageStabilizerParameters()
        {
            СлучайноеНапряжение();
        }

        #region Лампочки
        private static bool _лампочкаСетьВкл;
        public static bool ЛампочкаСетьВкл
        {
            get { return _лампочкаСетьВкл; }

            set
            {
                _лампочкаСетьВкл = value;
                if (RefreshForm != null) RefreshForm();
            }
        }

        private static bool _лампочкаАвария;
        public static bool ЛампочкаАвария
        {
            get { return _лампочкаАвария; }

            set
            {
                _лампочкаАвария = value;
                if (RefreshForm != null) RefreshForm();
            }
        }
        #endregion

        #region Контроль Напряжения

        /// <summary>
        /// Положение переключателя Контроль напряжения
        /// </summary>
        private static int _переключательКонтрольНапр = 1;

        public static int ПереключательКонтрольНапр
        {
            get { return _переключательКонтрольНапр; }

            set
            {
                if (value > 0 && value < 13) _переключательКонтрольНапр = value;
                if (RefreshForm != null) RefreshForm();
            }
        }

        /// <summary>
        /// Названия положений:
        /// 1 - линейное_ca,
        /// 2 - линейное_bc,
        /// 3 - линейное_ab,
        /// 4 - вход220_AB,
        /// 5 - вход220_BC,
        /// 6 - вход220_CA,
        /// 7 - вход380_AB,
        /// 8 - вход380_BC,
        /// 9 - вход380_CA,
        /// 10 - фазное_0с,
        /// 11 - фазное_0b,
        /// 12 - фазное_0a
        /// </summary>
        public static int ИндикаторНапряжение
        {
            get
            {
                if (!ЛампочкаСетьВкл) return 0;
                switch (_переключательКонтрольНапр)
                {
                    case 1:
                    case 2:
                    case 3:
                        return 220;
                    case 4:
                    case 5:
                    case 6:
                        return 220;
                    case 7:
                    case 8:
                    case 9:
                        return КабельВход == 220 ? 0 : 380;
                    case 10:
                    case 11:
                    case 12:
                        return 127;
                }
                return 0;
            }
        }

        #endregion

        #region Текущее напряжение

        ////Кабель
        /// <summary>
        /// Возможные состояния: 220, 380, 0
        /// </summary>
        private static int _кабельВход;

        /// <summary>
        /// Значение, которому должен соответствовать КабельВход.
        /// </summary>
        public static int ПравильныйВход { get; set; }

        public static int КабельВход
        {
            get { return _кабельВход; }

            set
            {
                _кабельВход = value;
                if (RefreshForm != null) RefreshForm();
                ResetParameters();
                N502BParameters.Нагрузка = false;

                if (N502BParameters.ЛампочкаСеть && N502BParameters.ПереключательСеть
                    && ОператорСтанцииПоражёнТоком != null)
                {
                    ОператорСтанцииПоражёнТоком();
                }
            }
        }

        /// <summary>
        /// Задание случайной фазировки.
        /// </summary>
        private static void СлучайноеНапряжение()
        {
            var generator = new Random();
            var zeroToOne = generator.NextDouble();
            ПравильныйВход = zeroToOne > 0.5F ? 380 : 220;
        }

        /// <summary>
        /// Условие определяющее, подключён ли кабель питания к нужному входу.
        /// </summary>
        public static bool КабельПодключенПравильно
        {
            get { return _кабельВход == ПравильныйВход; }
        }

        #endregion

        #region Обновление переменных и формы

        public static void ResetParameters()
        {
            ЛампочкаСетьВкл = N502BParameters.ПереключательСеть &&
                             N502BParameters.ЛампочкаСеть
                               && КабельПодключенПравильно;

            ЛампочкаАвария = N502BParameters.ПереключательСеть &&
                             N502BParameters.ЛампочкаСеть
                               && !КабельПодключенПравильно;
        }

        public delegate void ParameterChangedHandler();
        public static event ParameterChangedHandler RefreshForm;

        /// <summary>
        /// Вызывается, если пользователь совершил неправильные действия по обесточиванию станции.
        /// </summary>
        public static event ParameterChangedHandler ОператорСтанцииПоражёнТоком;
        #endregion
    }
}
