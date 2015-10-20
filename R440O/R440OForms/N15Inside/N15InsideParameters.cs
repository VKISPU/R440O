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

        /// <summary>
        /// Выходной сигнал передающего тракта, проходит если выбрана необходимая скорость. Задаёт тип модуляции сигнала.
        /// ПУЛ на Н15 должен быть включен.
        /// </summary>
        public static Signal ВыходПередающегоТракта
        {
            get
            {
                if (Включен &&
                    N15Parameters.ТумблерТлфТлгПрд && A1Parameters.ВыходнойСигнал != null && N18_MParameters.ПереключательПРД == 2 &&
                    Signal.IsEquivalentSpeed(СкоростьПередачи, A1Parameters.ВыходнойСигнал.GroupSpeed))
                {
                    var transition = A1Parameters.ВыходнойСигнал;
                    transition.Modulation = ТумблерПУЛ48ПРД_1;
                    transition.GroupSpeed = СкоростьПередачи;
                    return transition;
                }
                return null;
            }
        }

        /// <summary>
        /// Выходной сигнал передающего тракта, проходит если выбраны необходимая скорость и модуляция. 
        /// ПУЛ на Н15 должен быть включен.
        /// </summary>
        public static Signal ВыходПриемногоТракта
        {
            get
            {
                if (Включен &&
                    N15Parameters.ТумблерТлфТлгПрм && C300M_1Parameters.ВыходнойСигнал != null &&
                    Signal.IsEquivalentSpeed(C300M_1Parameters.ВыходнойСигнал.GroupSpeed, СкоростьПриема) &&
                    C300M_1Parameters.ВыходнойСигнал.Modulation == ТумблерПУЛ480ПРМ_1)
                    return C300M_1Parameters.ВыходнойСигнал;
                return null;
            }
        }

        #endregion

        #region Тумблеры
        private static Модуляция _тумблерПУЛ480ПРМ_1 = Модуляция.ЧТ;
        private static Модуляция _тумблерПУЛ480ПРМ_2 = Модуляция.ЧТ;
        private static Модуляция _тумблерПУЛ48ПРД_1 = Модуляция.ОФТ;
        private static Модуляция _тумблерПУЛ48ПРД_2 = Модуляция.ОФТ;

        public static Модуляция ТумблерПУЛ480ПРМ_1
        {
            get { return _тумблерПУЛ480ПРМ_1; }
            set
            {
                _тумблерПУЛ480ПРМ_1 = value;
                OnParameterChanged();
                N15Parameters.ResetDiscret();
            }
        }

        public static Модуляция ТумблерПУЛ480ПРМ_2
        {
            get { return _тумблерПУЛ480ПРМ_2; }
            set
            {
                _тумблерПУЛ480ПРМ_2 = value;
                OnParameterChanged();
            }
        }

        public static Модуляция ТумблерПУЛ48ПРД_1
        {
            get { return _тумблерПУЛ48ПРД_1; }
            set
            {
                _тумблерПУЛ48ПРД_1 = value;
                OnParameterChanged();
                N15Parameters.ResetDiscret();
            }
        }

        public static Модуляция ТумблерПУЛ48ПРД_2
        {
            get { return _тумблерПУЛ48ПРД_2; }
            set
            {
                _тумблерПУЛ48ПРД_2 = value;
                OnParameterChanged();
            }
        }
        #endregion

        #region Переключатели

        private static double СкоростьПриема
        {
            get
            {
                switch (_переключательПУЛ480ПРМ_1)
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

        private static int _переключательПУЛ480ПРМ_1 = 1;

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
        public static int ПереключательПУЛ480ПРМ_1
        {
            get { return _переключательПУЛ480ПРМ_1; }

            set
            {
                if (value > 0 && value < 10)
                {
                    _переключательПУЛ480ПРМ_1 = value;
                    OnParameterChanged();
                    N15Parameters.ResetDiscret();
                }
            }
        }

        private static int _переключательПУЛ480ПРМ_2 = 1;

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
        public static int ПереключательПУЛ480ПРМ_2
        {
            get
            {
                return _переключательПУЛ480ПРМ_2;
            }

            set
            {
                if (value > 0 && value < 10)
                {
                    _переключательПУЛ480ПРМ_2 = value;
                    OnParameterChanged();
                }
            }
        }

        private static double СкоростьПередачи
        {
            get
            {
                switch (_переключательПУЛ48ПРД_1)
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

        private static int _переключательПУЛ48ПРД_1 = 1;

        /// <summary>
        /// 1 - 1.2,
        /// 2 - 2.4,
        /// 3 - 4.8,
        /// 4 - 5.2,
        /// 5 - 48
        /// </summary>
        public static int ПереключательПУЛ48ПРД_1
        {
            get { return _переключательПУЛ48ПРД_1; }

            set
            {
                if (value > 0 && value < 6)
                {
                    _переключательПУЛ48ПРД_1 = value;
                    OnParameterChanged();
                    N15Parameters.ResetDiscret();
                }
            }
        }

        private static int _переключательПУЛ48ПРД_2 = 1;

        /// <summary>
        /// 1 - 1.2,
        /// 2 - 2.4,
        /// 3 - 4.8,
        /// 4 - 5.2,
        /// 5 - 48
        /// </summary>
        public static int ПереключательПУЛ48ПРД_2
        {
            get { return _переключательПУЛ48ПРД_2; }

            set
            {
                if (value > 0 && value < 6)
                {
                    _переключательПУЛ48ПРД_2 = value;
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
