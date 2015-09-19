using R440O.R440OForms.N15;
using R440O.R440OForms.N502B;

namespace R440O.R440OForms.N16
{
    public static class N16Parameters
    {

        public static bool Включен
        {
            get { return (N15Parameters.НеполноеВключение); }
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
        public static bool ЛампочкаН13_12 { get { return N15Parameters.НеполноеВключение && КнопкаН13_12; }}
        public static bool ЛампочкаН13_1 { get { return N15Parameters.НеполноеВключение && КнопкаН13_1; } }
        public static bool ЛампочкаН13_2 { get { return N15Parameters.НеполноеВключение && КнопкаН13_2; } }
        public static bool ЛампочкаАнтенна { get { return N15Parameters.НеполноеВключение && КнопкаАнтенна; } }
        public static bool ЛампочкаЭквивалент { get { return N15Parameters.НеполноеВключение && КнопкаЭквивалент; } }
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
                OnParameterChanged();
            }
        }

        public static bool КнопкаН13_1
        {
            get { return _кнопкаН13_1; }
            set
            {
                _кнопкаН13_1 = value;
                OnParameterChanged();
            }
        }

        public static bool КнопкаН13_2
        {
            get { return _кнопкаН13_2; }
            set
            {
                _кнопкаН13_2 = value;
                OnParameterChanged();
            }
        }

        public static bool КнопкаАнтенна
        {
            get { return _кнопкаАнтенна; }
            set
            {
                _кнопкаАнтенна = value;
                OnParameterChanged();
            }
        }

        public static bool КнопкаЭквивалент
        {
            get { return _кнопкаЭквивалент; }
            set
            {
                _кнопкаЭквивалент = value;
                OnParameterChanged();
            }
        }
        #endregion

        #region Индикаторы
        public static int ИндикаторМощностьНагрузки { get; set; }
        public static int ИндикаторМощностьВыхода { get; set; }
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
