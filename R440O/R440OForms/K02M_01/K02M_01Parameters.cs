namespace R440O.R440OForms.K02M_01
{
    public static class K02M_01Parameters
    {
        #region Лампочки
        public static bool ЛампочкаКаналыОбнаруженияЛ
        {
            get { return false; }
        }

        public static bool ЛампочкаКаналыОбнаруженияЦ
        {
            get { return false; }
        }

        public static bool ЛампочкаКаналыОбнаруженияП
        {
            get { return false; }
        }

        public static bool ЛампочкаПоискСигналов
        {
            get { return false; }
        }

        public static bool ЛампочкаПилот
        {
            get { return false; }
        }

        public static bool ЛампочкаИнформ
        {
            get { return false; }
        }

        #endregion

        #region Переключатели

        private static int _переключательСкорость = 1;
        private static int _переключательВклОткл = 1;
        private static int _переключательНапряжение1К = 1;
        private static int _переключательНапряжение2К = 1;

        public static int ПереключательСкорость
        {
            get { return _переключательСкорость; }

            set
            {
                if (value > 0 && value < 4)
                {
                    _переключательСкорость = value;
                    OnParameterChanged();
                }
            }
        }

        public static int ПереключательВклОткл
        {
            get { return _переключательВклОткл; }

            set
            {
                if (value > 0 && value < 3)
                {
                    _переключательВклОткл = value;
                    OnParameterChanged();
                }
            }
        }

        public static int ПереключательНапряжение1К
        {
            get { return _переключательНапряжение1К; }

            set
            {
                if (value > 0 && value < 5)
                {
                    _переключательНапряжение1К = value;
                    OnParameterChanged();
                }
            }
        }

        public static int ПереключательНапряжение2К
        {
            get { return _переключательНапряжение2К; }

            set
            {
                if (value > 0 && value < 4)
                {
                    _переключательНапряжение2К = value;
                    OnParameterChanged();
                }
            }
        }

        #endregion

        #region событие

        public delegate void ParameterChangedHandler();
        public static event ParameterChangedHandler ParameterChanged;

        private static void OnParameterChanged()
        {
            var handler = ParameterChanged;
            if (handler != null) handler();
        }

        public static void ResetParameters()
        {
            OnParameterChanged();
        }

        #endregion
    }
}
