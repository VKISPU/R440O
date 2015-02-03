namespace R440O.Parameters
{
    internal class K05M_01Parameters
    {
        /// <summary>
        /// Положение переключателя контроля
        /// </summary>
        private static int _k05M_01ПереключательПередачаКонтроль;
        private static int _k05M_01ПереключательОслабление;
        private static int _k05M_01ПереключательРодРаботы;
        private static int _k05M_01ПереключательКанал1;
        private static int _k05M_01ПереключательКанал2;

        public static int K05M_01ПереключательПередачаКонтроль
        {
            get
            {
                return _k05M_01ПереключательПередачаКонтроль;
            }

            set
            {
                if (value >= 0 && value <= 3)
                {
                    _k05M_01ПереключательПередачаКонтроль = value;
                }
            }
        }
        public static int K05M_01ПереключательОслабление
        {
            get
            {
                return _k05M_01ПереключательОслабление;
            }

            set
            {
                if (value >= 0 && value <= 2)
                {
                    _k05M_01ПереключательОслабление = value;
                }
            }
        }
        public static int K05M_01ПереключательРодРаботы
        {
            get
            {
                return _k05M_01ПереключательРодРаботы;
            }

            set
            {
                if (value >= 0 && value <= 2)
                {
                    _k05M_01ПереключательРодРаботы = value;
                }
            }
        }
        public static int K05M_01ПереключательКанал1
        {
            get
            {
                return _k05M_01ПереключательКанал1;
            }

            set
            {
                if (value >= 0 && value <= 3)
                {
                    _k05M_01ПереключательКанал1 = value;
                }
            }
        }
        public static int K05M_01ПереключательКанал2
        {
            get
            {
                return _k05M_01ПереключательКанал2;
            }

            set
            {
                if (value >= 0 && value <= 2)
                {
                    _k05M_01ПереключательКанал2 = value;
                }
            }
        }
    }
}
