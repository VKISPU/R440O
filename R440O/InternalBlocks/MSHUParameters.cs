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
        /// Начало приемного тракта
        /// </summary>
        public static Signal ВыходнойСигнал
        {
            get
            {
                if (!Включен || A503BParameters.ВыходнойСигнал == null) return null;

                var inputSignal = A503BParameters.ВыходнойСигнал;

                //Входной СВЧ сигнал в диапазоне 3400...3900 МГц усиливается в МШУ и преобразуется в сигнал первой ПЧ - 320...370 МГц, 
                //Частота выходного сигнала = Частота входного сигнала - 8*(частота с A304)

                if (A304Parameters.ВыходнаяЧастота == null) return null;

                var outputSignal = inputSignal;
                outputSignal.Frequency = inputSignal.Frequency - 8*(int)A304Parameters.ВыходнаяЧастота;
                //outputSignal.Wave = outputSignal.Frequency/10 - 571000;


                //На блок А306
                //С проверкой попадания в диапазон 320...370 МГц
                return (outputSignal.Frequency >= 320000 && outputSignal.Frequency <= 370000 ) ? outputSignal : null;
            }
        }

    }
}