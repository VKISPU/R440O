namespace R440O.Parameters
{
    internal class K04M_01Parameters
    {
        /// <summary>
        /// Положение переключателя контроля
        /// </summary>
        private static int _k04M_01ПереключательПрдМгц;
        private static int _k04M_01ПереключательПрдКгц100;
        private static int _k04M_01ПереключательПрдКгц10;
        private static int _k04M_01ПереключательПрдКгц1;
        private static int _k04M_01ПереключательПрмМгц;
        private static int _k04M_01ПереключательПрмКгц100;

        public static int K04M_01ПереключательПрдМгц
        {
            get
            {
                return _k04M_01ПереключательПрдМгц;
            }

            set
            {
                if (value >= 0 && value <= 9)
                {
                    _k04M_01ПереключательПрдМгц = value;
                }
            }
        }
        public static int K04M_01ПереключательПрдКгц100
        {
            get
            {
                return _k04M_01ПереключательПрдКгц100;
            }

            set
            {
                if (value >= 0 && value <= 9)
                {
                    _k04M_01ПереключательПрдКгц100 = value;
                }
            }
        }

        public static int K04M_01ПереключательПрдКгц10
        {
            get
            {
                return _k04M_01ПереключательПрдКгц10;
            }

            set
            {
                if (value >= 0 && value <= 9)
                {
                    _k04M_01ПереключательПрдКгц10 = value;
                }
            }
        }

        public static int K04M_01ПереключательПрдКгц1
        {
            get
            {
                return _k04M_01ПереключательПрдКгц1;
            }

            set
            {
                if (value >= 0 && value <= 9)
                {
                    _k04M_01ПереключательПрдКгц1 = value;
                }
            }
        }

        public static int K04M_01ПереключательПрмМгц
        {
            get
            {
                return _k04M_01ПереключательПрмМгц;
            }

            set
            {
                if (value >= 0 && value <= 9)
                {
                    _k04M_01ПереключательПрмМгц = value;
                }
            }
        }
        public static int K04M_01ПереключательПрмКгц100
        {
            get
            {
                return _k04M_01ПереключательПрмКгц100;
            }

            set
            {
                if (value >= 0 && value <= 9)
                {
                    _k04M_01ПереключательПрмКгц100 = value;
                }
            }
        }

    }
}
