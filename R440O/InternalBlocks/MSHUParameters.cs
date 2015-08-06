using R440O.BaseClasses;
using R440O.R440OForms.A304;
using R440O.R440OForms.N15;

namespace R440O.InternalBlocks
{
    public static class MSHUParameters
    {
        public static bool Включен
        {
            get { return N15Parameters.ЛампочкаМШУ; }
        }

        /// <summary>
        /// Волна равна номинальной волне на приём. 
        /// Проходит, если правильно выбран ствол.
        /// </summary>
        public static SignalArgs ВыходнойСигнал
        {
            get
            {
                if (A503BParameters.ВыходнойСигнал != null && Включен &&
                    (A503BParameters.ВыходнойСигнал.Wave / 5000) == A304Parameters.ПереключательВыборСтвола)
                {
                    var newSignal = A503BParameters.ВыходнойСигнал;
                    newSignal.Wave = newSignal.Wave % 5000;
                    return newSignal;
                }
                return null;
            }
        }

    }
}