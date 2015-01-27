namespace R440O.Parameters
{
    internal class K02M_01Parameters
    {
        ////Лампочки
        public static bool K02M_01ЛампочкаКаналыОбнаруженияЛ;
        public static bool K02M_01ЛампочкаКаналыОбнаруженияЦ;
        public static bool K02M_01ЛампочкаКаналыОбнаруженияП;
        public static bool K02M_01ЛампочкаПоискСигналов;
        public static bool K02M_01ЛампочкаПилот;
        public static bool K02M_01ЛампочкаИнформ;
        
        #region Переключатели
        /// <summary>
        /// Положение переключателя контроля
        /// </summary>
        private static int _k02M_01ПереключательСкорость = 1;

        public static int K02M_01ПереключательСкорость
        {
            get
            {
                return _k02M_01ПереключательСкорость;
            }

            set
            {
                if (value > 0 && value < 4)
                {
                    _k02M_01ПереключательСкорость = value;
                }
            }
        }

        /// <summary>
        /// Положение переключателя контроля
        /// </summary>
        private static int _k02M_01ПереключательВклОткл = 1;

        public static int K02M_01ПереключательВклОткл
        {
            get
            {
                return _k02M_01ПереключательВклОткл;
            }

            set
            {
                if (value > 0 && value < 3)
                {
                    _k02M_01ПереключательВклОткл = value;
                }
            }
        }

        /// <summary>
        /// Положение переключателя контроля
        /// </summary>
        private static int _k02M_01ПереключательНапряжение1К = 1;

        public static int K02M_01ПереключательНапряжение1К
        {
            get
            {
                return _k02M_01ПереключательНапряжение1К;
            }

            set
            {
                if (value > 0 && value < 5)
                {
                    _k02M_01ПереключательНапряжение1К = value;
                }
            }
        }

        /// <summary>
        /// Положение переключателя контроля
        /// </summary>
        private static int _k02M_01ПереключательНапряжение2К = 1;

        public static int K02M_01ПереключательНапряжение2К
        {
            get
            {
                return _k02M_01ПереключательНапряжение2К;
            }

            set
            {
                if (value > 0 && value < 4)
                {
                    _k02M_01ПереключательНапряжение2К = value;
                }
            }
        }  
        #endregion
    }
}
