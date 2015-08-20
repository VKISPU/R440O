using R440O.BaseClasses;
using R440O.R440OForms.A304;
using R440O.R440OForms.N15;
using R440O.R440OForms.OrderScheme;

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
                var inputSignal = A503BParameters.ВыходнойСигнал ?? OrderSchemeParameters.СигналКорреспондента;

                if (Включен && (inputSignal.Wave/5000) == A304Parameters.ПереключательВыборСтвола)
                {
                    var outputSignal = inputSignal;
                    outputSignal.Wave = outputSignal.Wave%5000;
                    return outputSignal;
                }

                return null;
            }
        }

    }
}