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

        #region Лампочки
        public static bool Лампочка0
        {
            get { return false; }
        }
        public static bool Лампочка1
        {
            get { return false; }
        }
        public static bool Лампочка2
        {
            get { return false; }
        }
        public static bool Лампочка4
        {
            get { return false; }
        }
        public static bool Лампочка8
        {
            get { return false; }
        }
        public static bool Лампочка16
        {
            get { return false; }
        }
        public static bool Лампочка32
        {
            get { return false; }
        }
        #endregion

        #region Переключатели
        private static bool _переключатель0;
        private static bool _переключатель1;
        private static bool _переключатель2;
        private static bool _переключатель4;
        private static bool _переключатель8;
        private static bool _переключатель16;
        private static bool _переключатель32;
        private static bool _переключательНепрОднокр;
        private static bool _переключательАвтРучн;


        /// <summary>
        /// Положение переключателя контроля
        /// </summary>
        private static int _переключательНапряжение = 1;

        public static bool Переключатель0
        {
            get
            {
                return _переключатель0;
            }
            set
            {
                _переключатель0 = value;
                ResetParameters();
            }
        }
        public static bool Переключатель1
        {
            get
            {
                return _переключатель1;
            }
            set
            {
                _переключатель1 = value;
                ResetParameters();
            }
        }
        public static bool Переключатель2
        {
            get
            {
                return _переключатель2;
            }
            set
            {
                _переключатель2 = value;
                ResetParameters();
            }
        }
        public static bool Переключатель4
        {
            get
            {
                return _переключатель4;
            }
            set
            {
                _переключатель4 = value;
                ResetParameters();
            }
        }
        public static bool Переключатель8
        {
            get
            {
                return _переключатель8;
            }
            set
            {
                _переключатель8 = value;
                ResetParameters();
            }
        }
        public static bool Переключатель16
        {
            get
            {
                return _переключатель16;
            }
            set
            {
                _переключатель16 = value;
                ResetParameters();
            }
        }
        public static bool Переключатель32
        {
            get
            {
                return _переключатель32;
            }
            set
            {
                _переключатель32 = value;
                ResetParameters();
            }
        }
        public static bool ПереключательНепрОднокр
        {
            get
            {
                return _переключательНепрОднокр;
            }
            set
            {
                _переключательНепрОднокр = value;
                ResetParameters();
            }
        }
        public static bool ПереключательАвтРучн
        {
            get
            {
                return _переключательАвтРучн;
            }
            set
            {
                _переключательАвтРучн = value;
                ResetParameters();
            }
        }

        public static int ПереключательНапряжение
        {
            get
            {
                return _переключательНапряжение;
            }

            set
            {
                if (value > 0 && value < 5)
                {
                    _переключательНапряжение = value;
                    ResetParameters();
                }
            }
        }
        #endregion        
    }
}
