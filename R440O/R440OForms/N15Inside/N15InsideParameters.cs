namespace R440O.R440OForms.N15Inside
{
    using A1;
    using C300M_1;
    using N15;
    using N18_M;
    using BaseClasses;
    using ОбщиеТипыДанных;

    class N15InsideParameters
    {
        #region Работа блока
        public static bool Включен
        {
            get
            {
                return N15Parameters.Включен;
            }
        }

        public static Signal ВыходПередающегоТракта
        {
            get
            {
                if (Включен &&
                    N15Parameters.ТумблерТлфТлгПрд && A1Parameters.ВыходнойСигнал != null && N18_MParameters.ПереключательПРД == 2 &&
                    Signal.IsEquivalentSpeed(СкоростьПередачиПРД1, A1Parameters.ВыходнойСигнал.GroupSpeed))
                {
                    var transition = A1Parameters.ВыходнойСигнал;
                    transition.Modulation = ТумблерПул48ПРДЧтОфт1;
                    transition.GroupSpeed = СкоростьПередачиПРД1;
                    return transition;
                }
                return null;
            }

        }

        public static Signal ВыходПриемногоТракта
        {
            get
            {
                if (Включен &&
                    N15Parameters.ТумблерТлфТлгПрм && C300M_1Parameters.ВыходнойСигнал != null &&
                    Signal.IsEquivalentSpeed(C300M_1Parameters.ВыходнойСигнал.GroupSpeed, СкоростьПриемаПРМ1) &&
                    C300M_1Parameters.ВыходнойСигнал.Modulation == ТумблерПул480ЧтОфт1)
                    return C300M_1Parameters.ВыходнойСигнал;
                return null;
            }

        } 

        #endregion

        #region Тумблеры
        private static Модуляция _тумблерПул480ЧтОфт1 = Модуляция.ЧТ;
        private static Модуляция _тумблерПУЛ480ЧтОфт2 = Модуляция.ЧТ;
        private static Модуляция _тумблерПУЛ48ПРДЧтОфт1 = Модуляция.ОФТ;
        private static Модуляция _тумблерПУЛ48ПРДЧтОфт2 = Модуляция.ОФТ;

        public static Модуляция ТумблерПул480ЧтОфт1
        {
            get { return _тумблерПул480ЧтОфт1; }
            set
            {
                _тумблерПул480ЧтОфт1 = value;
                OnParameterChanged();
                N15Parameters.ResetDiscret();
            }
        }

        public static Модуляция ТумблерПул480ЧтОфт2
        {
            get { return _тумблерПУЛ480ЧтОфт2; }
            set
            {
                _тумблерПУЛ480ЧтОфт2 = value;
                OnParameterChanged();
            }
        }

        public static Модуляция ТумблерПул48ПРДЧтОфт1
        {
            get { return _тумблерПУЛ48ПРДЧтОфт1; }
            set
            {
                _тумблерПУЛ48ПРДЧтОфт1 = value;
                OnParameterChanged();
                N15Parameters.ResetDiscret();
            }
        }

        public static Модуляция ТумблерПул48ПРДЧтОфт2
        {
            get { return _тумблерПУЛ48ПРДЧтОфт2; }
            set
            {
                _тумблерПУЛ48ПРДЧтОфт2 = value;
                OnParameterChanged();
            }
        } 
        #endregion

        #region Переключатели

        private static double СкоростьПриемаПРМ1
        {
            get
            {
                switch (_переключательПУЛ4801)
                {
                    case 1:
                        return 1.2;
                    case 2:
                        return 2.4;
                    case 3:
                        return 4.8;
                    case 4:
                        return 5.2;
                    case 5:
                        return 48;
                    case 6:
                        return 96;
                    case 7:
                        return 144;
                    case 8:
                        return 240;
                    case 9:
                        return 480;
                }
                return 0;
            }
        }

        private static int _переключательПУЛ4801 = 1;

        /// <summary>
        /// 1 - 1.2,
        /// 2 - 2.4,
        /// 3 - 4.8,
        /// 4 - 5.2,
        /// 5 - 48,
        /// 6 - 96,
        /// 7 - 144,
        /// 8 - 240,
        /// 9 - 480
        /// </summary>
        public static int ПереключательПУЛ4801
        {
            get { return _переключательПУЛ4801; }

            set
            {
                if (value > 0 && value < 10)
                {
                    _переключательПУЛ4801 = value;
                    OnParameterChanged();
                    N15Parameters.ResetDiscret();
                }
            }
        }

        private static int _переключательПУЛ4802 = 1;

        /// <summary>
        /// 1 - 1.2,
        /// 2 - 2.4,
        /// 3 - 4.8,
        /// 4 - 5.2,
        /// 5 - 48,
        /// 6 - 96,
        /// 7 - 144,
        /// 8 - 240,
        /// 9 - 480
        /// </summary>
        public static int ПереключательПУЛ4802
        {
            get
            {
                return _переключательПУЛ4802;
            }

            set
            {
                if (value > 0 && value < 10)
                {
                    _переключательПУЛ4802 = value;
                    OnParameterChanged();
                }
            }
        }

        private static double СкоростьПередачиПРД1
        {
            get
            {
                switch (_переключательПУЛ48ПРД1)
                {
                    case 1:
                        return 1.2;
                    case 2:
                        return 2.4;
                    case 3:
                        return 4.8;
                    case 4:
                        return 5.2;
                    case 5:
                        return 48;
                }
                return 0;
            }
        }

        private static int _переключательПУЛ48ПРД1 = 1;

        /// <summary>
        /// 1 - 1.2,
        /// 2 - 2.4,
        /// 3 - 4.8,
        /// 4 - 5.2,
        /// 5 - 48
        /// </summary>
        public static int ПереключательПУЛ48ПРД1
        {
            get { return _переключательПУЛ48ПРД1; }

            set
            {
                if (value > 0 && value < 6)
                {
                    _переключательПУЛ48ПРД1 = value;
                    OnParameterChanged();
                    N15Parameters.ResetDiscret();
                }
            }
        }

        private static int _переключательПУЛ48ПРД2 = 1;

        /// <summary>
        /// 1 - 1.2,
        /// 2 - 2.4,
        /// 3 - 4.8,
        /// 4 - 5.2,
        /// 5 - 48
        /// </summary>
        public static int ПереключательПУЛ48ПРД2
        {
            get { return _переключательПУЛ48ПРД2; }

            set
            {
                if (value > 0 && value < 6)
                {
                    _переключательПУЛ48ПРД2 = value;
                    OnParameterChanged();
                }
            }
        }
        #endregion

        public delegate void ParameterChangedHandler();
        public static event ParameterChangedHandler ParameterChanged;


        private static void OnParameterChanged()
        {
            var handler = ParameterChanged;
            if (handler != null) handler();
        }
    }
}
