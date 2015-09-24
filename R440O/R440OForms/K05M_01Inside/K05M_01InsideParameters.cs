namespace R440O.R440OForms.K05M_01Inside
{
    internal class K05M_01InsideParameters
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

        public static KulonIndexerClass Переключатель = new KulonIndexerClass();
        public static bool ТумблерВ4;
        public static bool ТумблерВ7;

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
                K05M_01InsideParameters.ResetParameters();
            }
        }
    }

}
