using System.Linq;

namespace R440O.R440OForms.N502B
{
    using System;
    using System.Windows.Forms;
    using Parameters;
    using Properties;
    using A205M_1;
    using NKN_1;
    using NKN_2;
    using PowerCabel;
    using VoltageStabilizer;
    using C300M_1;
    using C300M_2;
    using C300M_3;
    using C300M_4;
    using A304;
    using BMB;
    using N15;

    public static class N502BParameters
    {

        static N502BParameters()
        {
            СлучайнаяФазировка();
        }

        #region Время работы станции
        public static Timer StationTimer;

        public static TimeSpan ВремяРаботыСтанции;

        public static void СледитьЗаВременем()
        {
            ВремяРаботыСтанции = Settings.Default.TimeofWork;
            StationTimer = new Timer { Enabled = false, Interval = 60 * 1000 };
            StationTimer.Tick += StationTimer_Tick;
            if (ЛампочкаСеть && ПереключательСеть) StationTimer.Start();
            else StationTimer.Stop();
        }

        private static void StationTimer_Tick(object sender, EventArgs e)
        {
            ВремяРаботыСтанции += new TimeSpan(0, 0, 1, 0);
            Settings.Default.TimeofWork = ВремяРаботыСтанции;
            Settings.Default.Save();
            ResetParameters();
        }
        #endregion

        #region Лампочки

        public static bool ЛампочкаСеть
        {
            get { return PowerCabelParameters.КабельСеть; }
        }

        private static bool _лампочкаСфазировано;
        public static bool ЛампочкаСфазировано
        {
            get
            {
                return _лампочкаСфазировано;
            }
            set
            {
                _лампочкаСфазировано = value;
                NKN_1Parameters.ResetParameters();
                NKN_2Parameters.ResetParameters();
                BMBParameters.ResetParameters();
                A205M_1Parameters.RefreshIndicators();
                C300M_1Parameters.ResetParameters();
                C300M_2Parameters.ResetParameters();
                C300M_3Parameters.ResetParameters();
                C300M_4Parameters.ResetParameters();
                C300M_1Parameters.RefreshIndicators();
                C300M_2Parameters.RefreshIndicators();
                C300M_3Parameters.RefreshIndicators();
                C300M_4Parameters.RefreshIndicators();
                N15Parameters.ResetParameters();
                A304Parameters.ResetParameters();
                A306Parameters.ResetParameters();
                if (RefreshForm != null) RefreshForm();
            }
        }

        public static bool ЛампочкаРбпПроверка;
        public static bool ЛампочкаРбпПредохранитель;

        #endregion

        #region Тумблеры

        private static bool _тумблерЭлектрооборудование;

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
                if (RefreshForm != null)
                    RefreshForm();
            }
        }


        private static bool _тумблерВыпрямитель27В;

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

                if (RefreshForm != null)
                    RefreshForm();
            }
        }

        private static bool _тумблерН15;
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

                if (RefreshForm != null)
                    RefreshForm();
            }
        }

        private static bool _тумблерОсвещение = false;
        private static bool _тумблерН131 = false;
        private static bool _тумблерН132 = false;
        private static int _тумблерОсвещение1 = 2;
        private static int _тумблерОсвещение2 = 2;

        public static bool ТумблерОсвещение
        {
            get { return _тумблерОсвещение; }
            set
            {
                _тумблерОсвещение = value;
                if (RefreshForm != null)
                    RefreshForm();
            }
        }

        public static bool ТумблерН131
        {
            get { return _тумблерН131; }
            set
            {
                _тумблерН131 = value;
                if (RefreshForm != null)
                    RefreshForm();
            }
        }

        public static bool ТумблерН132
        {
            get { return _тумблерН132; }
            set
            {
                _тумблерН132 = value;
                if (RefreshForm != null)
                    RefreshForm();
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
                if (RefreshForm != null)
                    RefreshForm();
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
                if (RefreshForm != null)
                    RefreshForm();
            }
        }
        #endregion

        #region Переключатели

        private static bool _переключательСеть;
        public static bool ПереключательСеть
        {
            get { return _переключательСеть; }
            set
            {
                _переключательСеть = value;
                Нагрузка = false;
                VoltageStabilizerParameters.ResetParameters();
                if (RefreshForm != null)
                    RefreshForm();
            }
        }

        private static int _переключательНапряжение = 1;
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
                if (RefreshForm != null)
                    RefreshForm();
            }
        }

        private static int _переключательФазировка = 1;
        public static int ПереключательФазировка
        {
            get { return _переключательФазировка; }
            set
            {
                if (value >= 0 && value <= 5) _переключательФазировка = value;
                Нагрузка = false;
                if (RefreshForm != null)
                    RefreshForm();
            }
        }

        private static int _переключательКонтрольНапряжения = 2;
        public static int ПереключательКонтрольНапряжения
        {
            get { return _переключательКонтрольНапряжения; }
            set
            {
                if (value > 0 && value < 4) _переключательКонтрольНапряжения = value;
                if (RefreshForm != null)
                    RefreshForm();

            }
        }

        private static int _переключательТокНагрузкиИЗаряда = 1;
        public static int ПереключательТокНагрузкиИЗаряда
        {
            get { return _переключательТокНагрузкиИЗаряда; }
            set
            {
                if (value > 0 && value < 9) _переключательТокНагрузкиИЗаряда = value;
                if (RefreshForm != null)
                    RefreshForm();

            }
        }
        #endregion

        #region Нагрузка
        private static bool _нагрузка;

        public static bool Нагрузка
        {
            get { return _нагрузка; }
            set
            {
                _нагрузка = value;
                ResetParameters();
            }
        }

        #endregion

        #region Индикаторы
        public static int ИндикаторНапряжение
        {
            get
            {
                if (!(ФазировкаГорит || ЛампочкаСфазировано)) return 0;
                switch (ПереключательНапряжение)
                {
                    case 1:
                    case 2:
                    case 3:
                        return VoltageStabilizerParameters.КабельВход;
                    case 4:
                        return 0;
                    case 5:
                    case 6:
                    case 7:
                        return 220;
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
                return (ФазировкаГорит || ЛампочкаСфазировано) ? ВключенныеБлоки() * 5 : 0;
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
                    if ((bool) property.GetValue(null))
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

                return 0;
            }
        } 
        #endregion

        public delegate void VoidVoidSignature();
        public static event VoidVoidSignature RefreshForm;

        public static void ResetParameters()
        {
            ЛампочкаСфазировано = ПереключательФазировка == Фазировка && ЛампочкаСеть &&
                                  ПереключательСеть && VoltageStabilizerParameters.КабельВход == 380 && Нагрузка;
        }

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

        /// <summary>
        /// Определение, горит ли лампочка сфазировано при нажатии на кнопку включения нагрузки.
        /// </summary>
        public static bool ФазировкаГорит {
            get
            {
                return (ПереключательФазировка == 2 || ПереключательФазировка == 4) && ЛампочкаСеть &&
                       ПереключательСеть && VoltageStabilizerParameters.КабельВход == 380 && КнопкаНагрузка;
            }
        }

        public static bool КнопкаНагрузка { private get; set; }

        #endregion
        
    }
}
