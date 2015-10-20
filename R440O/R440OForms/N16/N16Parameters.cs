using System.Collections;
using System.Windows.Forms;
using R440O.R440OForms.N15;
using R440O.R440OForms.N502B;

namespace R440O.R440OForms.N16
{
    public static class N16Parameters
    {

        public static bool Включен
        {
            get { return N15Parameters.НеполноеВключение; }
        }

        #region Тумблеры
        private static int _тумблерУровень1 = 0;
        private static int _тумблерФаза = 0;
        private static int _тумблерУровень2 = 0;

        public static int ТумблерУровень1
        {
            get { return _тумблерУровень1; }
            set
            {
                _тумблерУровень1 = value;
                OnParameterChanged();
            }
        }

        public static int ТумблерФаза
        {
            get { return _тумблерФаза; }
            set
            {
                _тумблерФаза = value;
                OnParameterChanged();
            }
        }

        public static int ТумблерУровень2
        {
            get { return _тумблерУровень2; }
            set
            {
                _тумблерУровень2 = value;
                OnParameterChanged();
            }
        }
        #endregion

        #region Лампочки
        public static bool ЛампочкаН13_12 { get { return Включен && ЩелевойМостН13 == 3; } }
        public static bool ЛампочкаН13_1 { get { return Включен && ЩелевойМостН13 == 1; } }
        public static bool ЛампочкаН13_2 { get { return Включен && ЩелевойМостН13 == 2; } }
        public static bool ЛампочкаАнтенна { get { return Включен && КоаксиальныйПереключатель; } }
        public static bool ЛампочкаЭквивалент { get { return Включен && !КоаксиальныйПереключатель; } }
        #endregion

        #region Внутренние элементы блока
        private static int _щелевойМостН13;
        private static bool _коаксиальныйПереключатель;

        /// <summary>
        /// 1 - Н13-1 включён
        /// 2 - Н13-2 включён
        /// 3 - Н13-12 включены
        /// </summary>
        public static int ЩелевойМостН13
        {
            get { return _щелевойМостН13; }
            set
            {
                switch (ЩелевойМостН13)
                {
                    case 1:
                        switch (value)
                        {
                            case 2:
                                _щелевойМостН13 = (КнопкаН13_1)
                                    ? 1
                                    : 2;
                                break;
                            case 3:
                                _щелевойМостН13 = (КнопкаН13_1)
                                    ? 1
                                    : (КнопкаН13_2) ? 2 : 3;
                                break;
                        }
                        break;
                    case 2:
                        switch (value)
                        {
                            case 1:
                                _щелевойМостН13 = (КнопкаН13_2)
                                    ? 2
                                    : (КнопкаН13_12) ? 3 : 1;
                                break;
                            case 3:
                                _щелевойМостН13 = (КнопкаН13_2)
                                    ? 2
                                    : 3;
                                break;
                        }
                        break;
                    case 3:
                        switch (value)
                        {
                            case 1:
                                _щелевойМостН13 = (КнопкаН13_12)
                                    ? 3
                                    : 1;
                                break;
                            case 2:
                                _щелевойМостН13 = (КнопкаН13_12)
                                    ? 3
                                    : (КнопкаН13_1) ? 1 : 2;
                                break;
                        }
                        break;
                    default:
                        _щелевойМостН13 = value;
                        break;
                }
                OnParameterChanged();
                N15Parameters.ResetParametersAlternative();
            }
        }

        /// <summary>
        /// true - Антенна
        /// false - Эквивалент
        /// </summary>
        public static bool КоаксиальныйПереключатель
        {
            get { return _коаксиальныйПереключатель; }
            set
            {
                if (КоаксиальныйПереключатель != value)
                {
                    _коаксиальныйПереключатель = (КоаксиальныйПереключатель)
                        ? КнопкаАнтенна
                        : !КнопкаЭквивалент;
                }
                OnParameterChanged();
                N15Parameters.ResetParametersAlternative();
            }
        }
        #endregion

        #region Кнопки
        private static bool _кнопкаВкл;
        private static bool _кнопкаН13_12;
        private static bool _кнопкаН13_1;
        private static bool _кнопкаН13_2;
        private static bool _кнопкаАнтенна;
        private static bool _кнопкаЭквивалент;

        public static bool КнопкаВкл
        {
            get { return _кнопкаВкл; }
            set
            {
                _кнопкаВкл = value;
                OnParameterChanged();
            }
        }

        public static bool КнопкаН13_12
        {
            get { return _кнопкаН13_12; }
            set
            {
                _кнопкаН13_12 = value;
                ЩелевойМостН13 = N15Parameters.КнопкаН13;
            }
        }

        public static bool КнопкаН13_1
        {
            get { return _кнопкаН13_1; }
            set
            {
                _кнопкаН13_1 = value;
                ЩелевойМостН13 = N15Parameters.КнопкаН13;
            }
        }

        public static bool КнопкаН13_2
        {
            get { return _кнопкаН13_2; }
            set
            {
                _кнопкаН13_2 = value;
                ЩелевойМостН13 = N15Parameters.КнопкаН13;
            }
        }

        public static bool КнопкаАнтенна
        {
            get { return _кнопкаАнтенна; }
            set
            {
                _кнопкаАнтенна = value;
                КоаксиальныйПереключатель = N15Parameters.ТумблерАнтЭкв;
            }
        }

        public static bool КнопкаЭквивалент
        {
            get { return _кнопкаЭквивалент; }
            set
            {
                _кнопкаЭквивалент = value;
                КоаксиальныйПереключатель = N15Parameters.ТумблерАнтЭкв;
            }
        }
        #endregion

        #region Индикаторы

        private static int _индикаторМощностьНагрузки = 20;
        private static int _индикаторМощностьВыхода = 80;

        public static int ИндикаторМощностьНагрузки
        {
            get { return КнопкаВкл ? _индикаторМощностьНагрузки : 0; }
            set { _индикаторМощностьНагрузки = value; }
        }
        public static int ИндикаторМощностьВыхода
        {
            get { return КнопкаВкл ? _индикаторМощностьВыхода : 0; }
            set { _индикаторМощностьВыхода = value; }
        }
        #endregion

        public delegate void ParameterChangedHandler();
        public static event ParameterChangedHandler ParameterChanged;

        public static void ResetParameters()
        {
            OnParameterChanged();
        }

        private static void OnParameterChanged()
        {
            var handler = ParameterChanged;
            if (handler != null) handler();
        }
    }
}
