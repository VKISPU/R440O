namespace R440O.Parameters
{
    internal class K03M_01InsideParameters
    {
        public static KulonIndexerClass K03M_01InsideПереключатель = new KulonIndexerClass();
        public static bool K03M_01InsideТумблерИП;
        public static bool K03M_01InsideТумблерВклОткл;
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
            }
        }
    }
}
