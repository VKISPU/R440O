using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareTypes.OrderScheme;

namespace Retranslator
{
    class OderSchemeShell
    {
        public OrderSchemeClass orderScheme { get; set; }
        private Station fisrtStation;
        private Station secondStation;

        public bool IsFree
        {
            get
            {
                return secondStation == null;
            }
        }

        public void AddStation(Station station)
        {
            if (fisrtStation == null)
            {
                fisrtStation = station;
            }
            else
            {
                secondStation = station;
            }
        }
    }
}
