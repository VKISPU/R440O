namespace R440O.Parameters
{
    internal class K03M_01Parameters
    {
        ////Лампочки
        public static bool K03M_01Лампочка0;
        public static bool K03M_01Лампочка1;
        public static bool K03M_01Лампочка2;
        public static bool K03M_01Лампочка4;
        public static bool K03M_01Лампочка8;
        public static bool K03M_01Лампочка16;
        public static bool K03M_01Лампочка32;

        ////Переключатели
        public static bool K03M_01Переключатель0;
        public static bool K03M_01Переключатель1;
        public static bool K03M_01Переключатель2;
        public static bool K03M_01Переключатель4;
        public static bool K03M_01Переключатель8;
        public static bool K03M_01Переключатель16;
        public static bool K03M_01Переключатель32;
        public static bool K03M_01ПереключательНепрОднокр;
        public static bool K03M_01ПереключательАвтРучн;

        /// <summary>
        /// Положение переключателя контроля
        /// </summary>
        private static int _k03M_01ПереключательНапряжение = 1;

        public static int K03M_01ПереключательНапряжение
        {
            get
            {
                return _k03M_01ПереключательНапряжение;
            }

            set
            {
                if (value > 0 && value < 5)
                {
                    _k03M_01ПереключательНапряжение = value;
                }
            }
        }
    }
}
