namespace R440O.Parameters
{
    internal class K03M_01InsideParameters
    {
        public static KulonIndexerClass K03M_01InsideПереключатель = new KulonIndexerClass();
        private static bool _K03M_01InsideТумблерИП;
        private static bool _K03M_01InsideТумблерВклОткл;

        public static bool K03M_01InsideТумблерИП
        {
            get
            {
                return _K03M_01InsideТумблерИП;
            }
            set
            {
                _K03M_01InsideТумблерИП = value;
                OnParameterChanged();
            }

        }
        public static bool K03M_01InsideТумблерВклОткл
        {
            get
            {
                return _K03M_01InsideТумблерВклОткл;
            }
            set
            {
                _K03M_01InsideТумблерВклОткл = value;
                OnParameterChanged();
            }

        }

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
    }

    class KulonIndexerClass
    {
        private int[] myArray = new int[31];
        public int this[int index]
        {
            get
            {
                return myArray[index];
            }
            set
            {
                if ((index >= 1 && index <= 3) || (index >= 5 && index <= 9))
                {
                    if (value >= 0 && value <= 7) myArray[index] = value;
                }
                else
                {
                    if (value >= 0 && value <= 1) myArray[index] = value;
                }
                K03M_01InsideParameters.ResetParameters();
            }            
        }
    }
}
