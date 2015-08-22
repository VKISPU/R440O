using R440O.BaseClasses;
using R440O.R440OForms.A205M_1;
using R440O.R440OForms.N15;

namespace R440O.InternalBlocks
{
    public static class A503BParameters
    {
        private const int WaveShift = 1500;

        public static bool Включен
        {
            get { return N15Parameters.ЛампочкаА503Б; }
        }

        public static Signal ВыходнойСигнал
        {
            get
            {
                if (A205M_1Parameters.ВыходнойСигнал != null && Включен)
                {
                    var signal = A205M_1Parameters.ВыходнойСигнал;
                    signal.Wave -= WaveShift;
                    signal.Level = (50*(N15Parameters.РегуляторУровень + 120)/240);
                    return signal;

                }
                return null;
            }
        }
    }
}
