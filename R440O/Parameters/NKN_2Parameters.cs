namespace R440O.Parameters
{
    /// <summary>
    /// Параметры блока НКН-1
    /// </summary>
    class NKN_2Parameters
    {
        /// <summary>
        /// Лампочка показывающая включено ли питание
        /// </summary>
        public static bool NKN_2ЛампочкаМУ = false;

        /// <summary>
        /// Лампочки показывающие есть ли питание на данной фазе
        /// </summary>
        public static bool[] NKN_2ЛампочкиФаз = {false, false, false};
    }
}
