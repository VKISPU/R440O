using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareTypes.OrderScheme;

namespace Retranslator
{
    public class OrderSchemePair
    {
        public int RandomWave1;
        public int RandomWave2;

        public Stantion Station1;
        public Stantion Station2;

        public OrderSchemePair(int wave1, int wave2)
        {
            this.RandomWave1 = wave1;
            this.RandomWave2 = wave2;
        }

        public bool IsEmpty
        {
            get
            {
                return Station1 == null && Station2 == null;
            }
        }

        public bool IsFree
        {
            get
            {
                return Station1 == null || Station2 == null;
            }
        }

        public void AddStation(Stantion station)
        {
            if (Station1 == null)
            {
                Station1 = station;
            }
            else
            {
                Station2 = station;
            }
        }

        public OrderSchemeClass GetOrderSchemeByStation(Stantion station)
        {
            if (this.Station1.Id == station.Id)
            {
                return OrderSchemeFactory.GenerateOrderSchemeByWave(RandomWave1, RandomWave2, this.Station1.Id);
            }
            if (this.Station2.Id == station.Id)
            {
                return OrderSchemeFactory.GenerateOrderSchemeByWave(RandomWave2, RandomWave1, this.Station2.Id);
            }
            throw new Exception("No this station in this pair!");
        }
    }
}
