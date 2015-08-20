namespace R440O.BaseClasses
{
    using ОбщиеТипыДанных;

    /// <summary>
    /// Параметры передаваемого сигнала.
    /// </summary>
    public class SignalArgs
    {
        /// <summary>
        /// Номинальная частота волны, КГц.
        /// </summary>
        public int Wave = -1;

        /// <summary>
        /// Тип модуляции. ОФТ, ЧТ.
        /// </summary>
        public Модуляция Modulation;

        /// <summary>
        /// Групповая скорость передачи сигнала.
        /// </summary>
        public double GroupSpeed = -1;
        
        /// <summary>
        /// Скорость передачи в определённом канале. Количество каналов = 10.
        /// </summary>
        public double[] ChanelSpeed = new double[10];

        /// <summary>
        /// Уровень передачи сигнала.
        /// </summary>
        public double Level = -1;

        /// <summary>
        /// True - синхронный режим работы, false - асинхронный режим работы.
        /// </summary>
        public bool Synchronization;
    }
}