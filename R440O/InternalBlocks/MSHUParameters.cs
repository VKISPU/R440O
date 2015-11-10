namespace R440O.InternalBlocks
{
    using BaseClasses;
    using R440OForms.A304;
    using R440OForms.N15;
    using R440OForms.OrderScheme;

    public static class MSHUParameters
    {
        public static bool Включен
        {
            get { return N15Parameters.ТумблерМШУ; }
        }

        /// <summary>
        /// Волна приводится в соответствие номинальной волне на приём. 
        /// Значение выходного сигнала, как после блока А304, т.к. его включение зависит от включения МШУ.
        /// </summary>
        public static Signal ВыходнойСигнал
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