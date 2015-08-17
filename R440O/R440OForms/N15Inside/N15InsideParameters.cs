using R440O.R440OForms.A1;
using R440O.R440OForms.N18_M;

namespace R440O.R440OForms.N15Inside
{
    using BaseClasses;
    using N502B;
    using ОбщиеТипыДанных;

    class N15InsideParameters
    {
        public static bool Включен
        {
            get
            {
                return N502BParameters.ЛампочкаСфазировано && N502BParameters.ТумблерЭлектрооборудование &&
                       N502BParameters.ТумблерВыпрямитель27В && N502BParameters.ТумблерН15;
            }
        }

        public static SignalArgs ВыходПередающегоТракта
        {
            get
            {
                if (!Включен) return null;
                if (A1Parameters.ВыходнойСигнал != null && N18_MParameters.ПереключательПРД == 2)
                {
                    var transition = A1Parameters.ВыходнойСигнал;
                    transition.Modulation = ТумблерПул48ПРДЧтОфт1;
                    transition.GroupSpeed = ПереключательПУЛ4801;
                    return transition;
                }
                    return null;
            }
            
        }

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
