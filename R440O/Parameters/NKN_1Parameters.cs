namespace R440O.Parameters
{
    /// <summary>
    /// Параметры блока НКН-1
    /// </summary>
    public class NKN_1Parameters
    {
        /// <summary>
        /// Лампочка показывающая включено ли питание
        /// </summary>
        public static bool NKN_1ЛампочкаМУ = false;

        /// <summary>
        /// Лампочки показывающие есть ли питание на данной фазе
        /// </summary>
        public static bool[] NKN_1ЛампочкиФаз = { false, false, false };
    }
}
