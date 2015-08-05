using R440O.R440OForms.N15;

namespace R440O.InternalBlocks
{
    public static class A503BParameters
    {
        public static bool Включен = false;

        public static void ResetParameters()
        {
            Включен = N15Parameters.Лампочка27В && N15Parameters.ТумблерА503Б;
        }
    }
}
