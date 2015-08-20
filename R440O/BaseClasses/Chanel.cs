namespace R440O.BaseClasses
{
    /// <summary>
    /// Единичный информационный канал.
    /// </summary>
    public struct Chanel
    {
        /// <summary>
        /// Скорость передачи информации в канале.
        /// </summary>
        public int Speed;

        /// <summary>
        /// true - информация присутствует, false - отсутствует.
        /// </summary>
        public bool Information;
    }
}