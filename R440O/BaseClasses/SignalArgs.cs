using R440O.ОбщиеТипыДанных;

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
        public Модуляция Modulation;

        /// <summary>
        /// Групповая скорость передачи сигнала.
        /// </summary>
        public double GroupSpeed;
        
        /// <summary>
        /// Скорость передачи в определённом канале.
        /// </summary>
        public double[] ChanelSpeed = new double[10];

        /// <summary>
        /// Уровень передачи сигнала.
        /// </summary>
        public double Level;
    }
}