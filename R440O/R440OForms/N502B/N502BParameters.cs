﻿namespace R440O.R440OForms.N502B
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using Properties;
    using NKN_1;
    using NKN_2;
    using PowerCabel;
    using VoltageStabilizer;
    using C300M_1;
    using C300M_2;
    using C300M_3;
    using C300M_4;
    using A304;
    using A306;
    using N13_1;
    using N13_2;
    using BMB;
    using N15;
    using N16;

    public static class N502BParameters
    {
        static N502BParameters()
        {
            СлучайнаяФазировка();
            StationTimer = new Timer();
        }

        #region Время работы станции
        public static Timer StationTimer;

        /// <summary>
        /// Таймер используемый, для определения времени, которое станция проработала.
        /// </summary>
        public static TimeSpan ВремяРаботыСтанции;

        /// <summary>
        /// Проверка условий, при выполнении которых ведётся учёт времени работы на станции.
        /// </summary>
        public static void СледитьЗаВременем()
        {
            ВремяРаботыСтанции = Settings.Default.TimeofWork;
            StationTimer = new Timer
            {
                Enabled = false,
                Interval = 60 * 1000
            };
            StationTimer.Tick += StationTimer_Tick;
            if (ЛампочкаСеть && ПереключательСеть) StationTimer.Start();
            else StationTimer.Stop();
        }

        private static void StationTimer_Tick(object sender, EventArgs e)
        {
            ВремяРаботыСтанции += new TimeSpan(0, 0, 1, 0);
            Settings.Default.TimeofWork = ВремяРаботыСтанции;
            Settings.Default.Save();
            OnParameterChanged();
        }
        #endregion

        #region Лампочки

        public static bool ЛампочкаСеть
        {
            get { return PowerCabelParameters.КабельСеть; }
        }

        public static bool ЛампочкаСфазировано
        {
            get
            {
                return ПереключательФазировка == Фазировка && ЛампочкаСеть &&
                                  ПереключательСеть && VoltageStabilizerParameters.КабельПодключенПравильно && Нагрузка;
            }
        }

        //public static bool ЛампочкаРбпПроверка;
        //public static bool ЛампочкаРбпПредохранитель;

        #endregion

        #region Тумблеры
        #region private
        private static bool _тумблерЭлектрооборудование;
        private static bool _тумблерВыпрямитель27В;
        private static bool _тумблерН15;
        private static bool _тумблерОсвещение;
        private static bool _тумблерН13_1;
        private static bool _тумблерН13_2;
        private static int _тумблерОсвещение1 = 2;
        private static int _тумблерОсвещение2 = 2;
        #endregion

        #region public
        public static bool ТумблерЭлектрооборудование
        {
            get { return _тумблерЭлектрооборудование; }
            set
            {
                _тумблерЭлектрооборудование = value;
                NKN_1Parameters.ResetParameters();
                NKN_2Parameters.ResetParameters();
                N15Parameters.ResetParameters();
                C300M_1Parameters.ResetParameters();
                C300M_2Parameters.ResetParameters();
                C300M_3Parameters.ResetParameters();
                C300M_4Parameters.ResetParameters();
                C300M_1Parameters.RefreshIndicators();
                C300M_2Parameters.RefreshIndicators();
                C300M_3Parameters.RefreshIndicators();
                C300M_4Parameters.RefreshIndicators();
                A304Parameters.ResetParameters();
                A306Parameters.ResetParameters();
                N16Parameters.ResetParameters();
                OnParameterChanged();
            }
        }

        public static bool ТумблерВыпрямитель27В
        {
            get { return _тумблерВыпрямитель27В; }
            set
            {
                _тумблерВыпрямитель27В = value;
                NKN_1Parameters.ResetParameters();
                NKN_2Parameters.ResetParameters();
                N15Parameters.ResetParameters();
                BMBParameters.ResetParameters();
                C300M_1Parameters.ResetParameters();
                C300M_2Parameters.ResetParameters();
                C300M_3Parameters.ResetParameters();
                C300M_4Parameters.ResetParameters();
                A304Parameters.ResetParameters();
                A306Parameters.ResetParameters();
                N16Parameters.ResetParameters();
                OnParameterChanged();
            }
        }
        public static bool ТумблерН15
        {
            get { return _тумблерН15; }
            set
            {
                _тумблерН15 = value;
                NKN_1Parameters.ResetParameters();
                NKN_2Parameters.ResetParameters();
                N15Parameters.ResetParameters();
                C300M_1Parameters.ResetParameters();
                C300M_2Parameters.ResetParameters();
                C300M_3Parameters.ResetParameters();
                C300M_4Parameters.ResetParameters();
                A304Parameters.ResetParameters();
                OnParameterChanged();
            }
        }

        public static bool ТумблерОсвещение
        {
            get { return _тумблерОсвещение; }
            set
            {
                _тумблерОсвещение = value;
                OnParameterChanged();
            }
        }

        public static bool ТумблерН13_1
        {
            get { return _тумблерН13_1; }
            set
            {
                _тумблерН13_1 = value;
                N13_1Parameters.ResetParameters();
                N15Parameters.Н13_1 = false;
                OnParameterChanged();
            }
        }

        public static bool ТумблерН13_2
        {
            get { return _тумблерН13_2; }
            set
            {
                _тумблерН13_2 = value;
                N13_2Parameters.ResetParameters();
                N15Parameters.Н13_2 = false;
                OnParameterChanged();
            }
        }

        /// <summary>
        /// Возможные состояния: 1 - Полное, 2 - Откл, 3- Дежурное
        /// </summary>
        public static int ТумблерОсвещение1
        {
            get { return _тумблерОсвещение1; }
            set
            {
                _тумблерОсвещение1 = value;
                OnParameterChanged();
            }
        }

        /// <summary>
        /// Возможные состояния: 1- Полное, 2- Откл, 3- Частичное
        /// </summary>
        public static int ТумблерОсвещение2
        {
            get { return _тумблерОсвещение2; }
            set
            {
                _тумблерОсвещение2 = value;
                OnParameterChanged();
            }
        }
        #endregion
        #endregion

        #region Переключатели

        private static bool _переключательСеть;
        private static int _переключательНапряжение = 1;
        private static int _переключательФазировка = 1;
        private static int _переключательКонтрольНапряжения = 2;
        private static int _переключательТокНагрузкиИЗаряда = 1;

        public static bool ПереключательСеть
        {
            get { return _переключательСеть; }
            set
            {
                if (!VoltageStabilizerParameters.КабельПодключенПравильно
                    && VoltageStabilizerParameters.КабельВход != 0
                    && !_переключательСеть
                    && ЛампочкаСеть
                    && СтанцияСгорела != null)
                {
                    СтанцияСгорела();
                }
                else
                {
                    _переключательСеть = value;
                    Нагрузка = false;
                }
                VoltageStabilizerParameters.ResetParameters();
                OnParameterChanged();


            }
        }


        /// <summary>
        /// 1,2,3 - сеть. 4 - нейтральное. 5,6,7 - нагрузка. 
        /// </summary>
        public static int ПереключательНапряжение
        {
            get { return _переключательНапряжение; }
            set
            {
                if (value > 0 && value < 8)
                    _переключательНапряжение = value;
                OnParameterChanged();
            }
        }


        public static int ПереключательФазировка
        {
            get { return _переключательФазировка; }
            set
            {
                if (value >= 0 && value <= 5)
                    if (ЛампочкаСфазировано && ПереключательСеть
                        && НекорректноеДействие != null)
                    {
                        НекорректноеДействие();
                    }
                    else
                    {
                        _переключательФазировка = value;
                        Нагрузка = false;
                    }
                OnParameterChanged();
            }
        }


        public static int ПереключательКонтрольНапряжения
        {
            get { return _переключательКонтрольНапряжения; }
            set
            {
                if (value > 0 && value < 4) _переключательКонтрольНапряжения = value;
                OnParameterChanged();

            }
        }

        public static int ПереключательТокНагрузкиИЗаряда
        {
            get { return _переключательТокНагрузкиИЗаряда; }
            set
            {
                if (value > 0 && value < 9) _переключательТокНагрузкиИЗаряда = value;
                OnParameterChanged();

            }
        }
        #endregion

        #region Нагрузка
        private static bool _нагрузка = false;

        /// <summary>
        /// Переменная определяющая наличие нагрузки.
        /// </summary>
        public static bool Нагрузка
        {
            get { return _нагрузка; }
            set
            {
                if (value != _нагрузка) N15Parameters.ResetParameters();
                _нагрузка = value;
            }
        }
        #endregion

        #region Фазировка
        /// <summary>
        /// Текущее требуемое для фазировки положение.
        /// </summary>
        public static int Фазировка;

        /// <summary>
        /// Задание случайной фазировки.
        /// </summary>
        private static void СлучайнаяФазировка()
        {
            var generator = new Random();
            var zeroToOne = generator.NextDouble();
            Фазировка = zeroToOne > 0.5F ? 4 : 2;
        }

        private static bool _кнопкаВклНагрузки;
        public static bool КнопкаВклНагрузки
        {
            get { return _кнопкаВклНагрузки; }
            set
            {
                _кнопкаВклНагрузки = value;
                if (value) Нагрузка = true;
                OnParameterChanged();
            }
        }

        #endregion

        #region Индикаторы
        public static int ИндикаторНапряжение
        {
            get
            {
                if (ЛампочкаСеть && ПереключательСеть && (ПереключательФазировка == 2 || ПереключательФазировка == 4))
                {
                    switch (ПереключательНапряжение)
                    {
                        case 1:
                        case 2:
                        case 3:
                            return PowerCabelParameters.Напряжение;
                        case 5:
                        case 6:
                        case 7:
                            if ((Нагрузка && VoltageStabilizerParameters.КабельПодключенПравильно) &&
                                (ЛампочкаСфазировано || (КнопкаВклНагрузки && !ЛампочкаСфазировано))) return 220;
                            else return 0;
                        default:
                            return 0;

                    }
                }
                return 0;
            }
        }

        /// <summary>
        /// Вычисление величины тока, используемой на станции.
        /// </summary>
        public static int ИндикаторТокНагрузки
        {
            get
            {
                return ((КнопкаВклНагрузки && !ЛампочкаСфазировано) || ЛампочкаСфазировано) ? ВключенныеБлоки() * 5 : 0;
            }
        }

        /// <summary>
        /// Определяет количество включенных на данный момент блоков.
        /// </summary>
        /// <returns></returns>
        private static int ВключенныеБлоки()
        {
            var propertyList = typeof(N15Parameters).GetProperties().ToArray();
            var quantity = 0;
            foreach (var property in propertyList)
            {
                if (property.Name.Contains("Лампочка"))
                {
                    if ((bool)property.GetValue(null))
                    {
                        quantity++;
                    }
                }
            }

            return quantity;
        }

        public static int ИндикаторКонтрольНапряжения
        {
            get
            {
                if (ЛампочкаСфазировано && ПереключательКонтрольНапряжения == 1 && ТумблерЭлектрооборудование)
                    return 30;
                if (ЛампочкаСфазировано && ПереключательКонтрольНапряжения == 3 && ТумблерЭлектрооборудование)
                {
                    if (ПереключательТокНагрузкиИЗаряда == 2)
                    {
                        return 30;
                    }
                    if (ПереключательТокНагрузкиИЗаряда == 3)
                    {
                        return 20;
                    }
                    return ПереключательТокНагрузкиИЗаряда * 10 - 10;
                }

                return 0;
            }
        }

        public static int ИндикаторТокНагрузкиИЗаряда
        {
            get
            {
                if (ЛампочкаСфазировано && ТумблерЭлектрооборудование)
                {
                    return ПереключательТокНагрузкиИЗаряда * 5;
                }

                return 5;
            }
        }
        #endregion


        public delegate void ParameterChangedHandler();
        public static event ParameterChangedHandler ParameterChanged;

        /// <summary>
        /// Событие возникающее, если пользователь осуществил неправильные действия, которые привели к выходу станции из строя.
        /// </summary>
        public static event ParameterChangedHandler СтанцияСгорела;
        public static event ParameterChangedHandler НекорректноеДействие;

        private static void OnParameterChanged()
        {
            var handler = ParameterChanged;
            if (handler != null) handler();
        }

        public static void ResetParameters()
        {
            OnParameterChanged();
            VoltageStabilizerParameters.ResetParameters();
            NKN_1Parameters.ResetParameters();
            NKN_2Parameters.ResetParameters();
            N15Parameters.ResetParameters();
            C300M_1Parameters.ResetParameters();
            C300M_2Parameters.ResetParameters();
            C300M_3Parameters.ResetParameters();
            C300M_4Parameters.ResetParameters();
            C300M_1Parameters.RefreshIndicators();
            C300M_2Parameters.RefreshIndicators();
            C300M_3Parameters.RefreshIndicators();
            C300M_4Parameters.RefreshIndicators();
            A306Parameters.ResetParameters();
        }

        #region Вспомогательные переменные, для обращения к блоку
        /// <summary>
        /// Определение, включено ли Электрообуродование
        /// </summary>
        public static bool ЭлектрообуродованиеВключено
        {
            get { return ЛампочкаСфазировано && ТумблерЭлектрооборудование; }
        }

        /// <summary>
        /// Определение, включён ли Выпрямитель
        /// </summary>
        public static bool ВыпрямительВключен
        {
            get { return ЛампочкаСфазировано && ТумблерВыпрямитель27В; }
        }

        /// <summary>
        /// Определение, включён ли Н15
        /// </summary>
        public static bool Н15Включен
        {
            get { return ЛампочкаСфазировано && ТумблерН15; }
        }
        #endregion

    }
}
