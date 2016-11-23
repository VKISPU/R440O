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

        /// <summary>
        /// Канал 1
        /// </summary>
        public Chanel FirstChanel { get; set; }

        /// <summary>
        /// Канал 2
        /// </summary>
        public Chanel SecondChanel { get; set; }

        public KulonSignal(int frequency)
        {
            Frequency = frequency;
        }
    }
}
