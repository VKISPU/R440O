namespace R440O.BaseClasses
{
    /// <summary>
    /// Единичный информационный канал.
    /// </summary>
    public class Chanel
    {
        public Chanel(double speed)
        {
            Speed = speed;
            Information = false;
        }

        public Chanel(double speed, bool information)
        {
            Speed = speed;
            Information = information;
        }

        /// <summary>
        /// Скорость передачи информации в канале.
        /// </summary>
        public double Speed { get; private set; }

        /// <summary>
        /// true - информация присутствует, false - отсутствует.
        /// </summary>
        public bool Information { get; private set; }
    }
}