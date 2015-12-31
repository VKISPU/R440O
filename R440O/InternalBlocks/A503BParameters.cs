﻿
using System.CodeDom;

namespace R440O.InternalBlocks
{

    using BaseClasses;
    using R440OForms.A205M_1;
    using R440OForms.A205M_2;
    using R440OForms.NKN_1;
    using R440OForms.NKN_2;
    using R440OForms.N15;

    public static class A503BParameters
    {
        /// <summary>
        /// Величина сдвига несущей частоты.
        /// </summary>
        private const int WaveShift = 1500;

        /// <summary>
        /// Частота сдвига
        /// </summary>
        private const int FrequencyShift = 2325000;

        /// <summary>
        /// Условие, при котором на данный блок подано питание.
        /// </summary>
        public static bool Включен
        {
            get { return N15Parameters.НеполноеВключение && N15Parameters.ТумблерА503Б; }
        }

        /// <summary>
        /// Значение сигнала после прохождения данного блока.
        /// В данном блоке происходит преобразование частоты волны, при проверке на себя.
        /// Также добавляется уровень мощности сигнала, в соответствии с регулятором на Н15.
        /// </summary>
        public static Signal ВыходнойСигнал
        {
            get
            {
                if (Включен)
                {
                    if (NKN_1Parameters.ДистанционноеВключение && A205M_1Parameters.ВыходнойСигнал != null)
                    {
                        var signal = A205M_1Parameters.ВыходнойСигнал;
                        signal.Wave -= WaveShift;
                        signal.Frequency -= FrequencyShift;
                        signal.Level = (50 * (N15Parameters.РегуляторУровень + 120) / 240);
                        return signal;
                    }

                    if (NKN_2Parameters.ДистанционноеВключение && A205M_2Parameters.ВыходнойСигнал != null)
                    {
                        var signal = A205M_2Parameters.ВыходнойСигнал;
                        signal.Wave -= WaveShift;
                        signal.Frequency -= FrequencyShift;
                        signal.Level = (50 * (N15Parameters.РегуляторУровень + 120) / 240);
                        return signal;
                    }
                }
                return null;
            }
        }
    }
}
