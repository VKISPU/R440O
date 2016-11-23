using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace R440O.BaseClasses
{
    public class KulonSignal
    {
        /// <summary>
        /// Частота сигнала
        /// </summary>
        public int Frequency { get; private set; }

        // <summary>
        /// Уровень мощности передачи сигнала.
        /// </summary>
        public double Level { get; private set; }

        /// <summary>
        /// Скорость передачи информации в канале.
        /// </summary>
        public double Speed { get; private set; }

        public KulonSignal(int frequency)
        {
            Frequency = frequency;
        }
    }
}
