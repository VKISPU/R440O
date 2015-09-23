namespace R440O.R440OForms.K03M_01
{
    internal class K03M_01Parameters
    {
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

        ////Лампочки
        public static bool K03M_01Лампочка0;
        public static bool K03M_01Лампочка1;
        public static bool K03M_01Лампочка2;
        public static bool K03M_01Лампочка4;
        public static bool K03M_01Лампочка8;
        public static bool K03M_01Лампочка16;
        public static bool K03M_01Лампочка32;

        
        #region Переключатели
        private static bool _K03M_01Переключатель0;
        private static bool _K03M_01Переключатель1;
        private static bool _K03M_01Переключатель2;
        private static bool _K03M_01Переключатель4;
        private static bool _K03M_01Переключатель8;
        private static bool _K03M_01Переключатель16;
        private static bool _K03M_01Переключатель32;
        private static bool _K03M_01ПереключательНепрОднокр;
        private static bool _K03M_01ПереключательАвтРучн;


        /// <summary>
        /// Положение переключателя контроля
        /// </summary>
        private static int _k03M_01ПереключательНапряжение = 1;

        public static bool K03M_01Переключатель0
        {
            get
            {
                return _K03M_01Переключатель0;
            }
            set
            {
                _K03M_01Переключатель0 = value;
                ResetParameters();
            }
        }
        public static bool K03M_01Переключатель1
        {
            get
            {
                return _K03M_01Переключатель1;
            }
            set
            {
                _K03M_01Переключатель1 = value;
                ResetParameters();
            }
        }
        public static bool K03M_01Переключатель2
        {
            get
            {
                return _K03M_01Переключатель2;
            }
            set
            {
                _K03M_01Переключатель2 = value;
                ResetParameters();
            }
        }
        public static bool K03M_01Переключатель4
        {
            get
            {
                return _K03M_01Переключатель4;
            }
            set
            {
                _K03M_01Переключатель4 = value;
                ResetParameters();
            }
        }
        public static bool K03M_01Переключатель8
        {
            get
            {
                return _K03M_01Переключатель8;
            }
            set
            {
                _K03M_01Переключатель8 = value;
                ResetParameters();
            }
        }
        public static bool K03M_01Переключатель16
        {
            get
            {
                return _K03M_01Переключатель16;
            }
            set
            {
                _K03M_01Переключатель16 = value;
                ResetParameters();
            }
        }
        public static bool K03M_01Переключатель32
        {
            get
            {
                return _K03M_01Переключатель32;
            }
            set
            {
                _K03M_01Переключатель32 = value;
                ResetParameters();
            }
        }
        public static bool K03M_01ПереключательНепрОднокр
        {
            get
            {
                return _K03M_01ПереключательНепрОднокр;
            }
            set
            {
                _K03M_01ПереключательНепрОднокр = value;
                ResetParameters();
            }
        }
        public static bool K03M_01ПереключательАвтРучн
        {
            get
            {
                return _K03M_01ПереключательАвтРучн;
            }
            set
            {
                _K03M_01ПереключательАвтРучн = value;
                ResetParameters();
            }
        }

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
                    ResetParameters();
                }
            }
        }
        #endregion        
    }
}
