using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R440O.R440OForms.TLF_TCH
{
    class TLF_TCHParametrs
    {
        public static List<int> НомераСоединений = new List<int>();

        public static void Соеденить(int номер)
        {
            int n = НомераСоединений.FindIndex(x => x == номер);
            if (n != НомераСоединений.Count)
                НомераСоединений.Add(номер);
            else
                НомераСоединений.Remove(n);
           

        }
    }
}
