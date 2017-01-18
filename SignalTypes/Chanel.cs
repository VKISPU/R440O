namespace SignalTypes
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

        public Chanel(double speed, string infString)
        {
            Speed = speed;
            Information = true;
            InformationString = infString;
        }

        /// <summary>
        /// Скорость передачи информации в канале.
        /// </summary>
        public double Speed { get; private set; }

        /// <summary>
        /// Наличие информационной составляющей в потоке.
        /// true - информация присутствует, false - отсутствует.
        /// </summary>
        public bool Information { get; private set; }

        public string InformationString { get; private set; }
    }
}