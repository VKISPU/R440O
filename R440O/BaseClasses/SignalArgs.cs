namespace R440O.BaseClasses
{
    /// <summary>
    /// Параметры передаваемого сигнала.
    /// </summary>
    public class SignalArgs
    {
        /// <summary>
        /// Номинальная частота волны, КГц.
        /// </summary>
        public int Wave;

        /// <summary>
        /// Тип модуляции. ОФТ, ЧТ.
        /// </summary>
        public string Modulation;

        /// <summary>
        /// Скорость передачи сигнала.
        /// </summary>
        public double Speed;

    }
}