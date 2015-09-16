namespace R440O.Parameters
{
    internal class K02M_01InsideParameters
    {
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
        ////Лампочки
        private static bool _K02M_01InsideТумблерБ5;
        public static bool K02M_01InsideТумблерБ5
        {
            get
            {
                return _K02M_01InsideТумблерБ5;
            }
            set
            {
                _K02M_01InsideТумблерБ5 = value;
                ResetParameters();
            }
        }
           
    }
}
