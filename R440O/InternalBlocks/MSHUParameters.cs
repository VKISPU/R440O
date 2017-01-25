﻿namespace R440O.InternalBlocks
{
    using SignalTypes;
    using R440OForms.A304;
    using R440OForms.N15;
    using R440OForms.OrderScheme;
    using R440OForms.A306;

    using System.Collections.Generic;

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
        public static List<Signal> ВыходнойСигнал
        {
            get
            {
                if (!Включен) return new List<Signal>();

                var inputSignal = N15Parameters.ТумблерАнтЭкв ? Antenna.ВыходнойСигнал
                    : A503BParameters.ВыходнойСигнал;

                if (inputSignal == null) return new List<Signal>();

                //Входной СВЧ сигнал в диапазоне 3400...3900 МГц усиливается в МШУ и преобразуется в сигнал первой ПЧ - 320...370 МГц, 
                //Частота выходного сигнала = Частота входного сигнала - 8*(частота с A304)

                if (A304Parameters.ВыходнаяЧастота == null) return null;

                var outputSignals = new List<Signal>();
                foreach (var signal in inputSignal)
                {
                    signal.Frequency = signal.Frequency - 8 * (int)A304Parameters.ВыходнаяЧастота;
                    //outputSignal.Wave = outputSignal.Frequency/10 - 571000;

                    //На блок А306
                    //С проверкой попадания в диапазон 320...370 МГц
                    if (signal.Frequency >= 320000 && signal.Frequency <= 370000)
                        outputSignals.Add(signal);
                }
                return outputSignals;
                
            }
        }

        public static void ResetParameters()
        {
            A306Parameters.ResetParameters();
        }

    }
}