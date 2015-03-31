using R440O.Parameters;
using R440O.R440OForms.N502B;

namespace R440O.R440OForms.NKN_1
{
    /// <summary>
    /// Параметры блока НКН-1
    /// </summary>
    public static class NKN_1Parameters
    {
        private static bool _лампочкаМУ;

        /// <summary>
        /// Лампочка показывающая включено ли питание
        /// </summary>
        public static bool ЛампочкаМУ
        {
            get { return _лампочкаМУ;}
            set
            {
                _лампочкаМУ = value;
                if (RefreshForm != null) RefreshForm();
            }
        }


        private static bool[] _лампочкиФаз = {false, false, false};

        /// <summary>
        /// Лампочки показывающие есть ли питание на данной фазе
        /// </summary>
        public static bool[] ЛампочкиФаз
        {
            get { return _лампочкиФаз; }
            set
            {
                _лампочкиФаз = value;
                if (RefreshForm != null) RefreshForm();
            }
        }

        public delegate void VoidVoidSignature();
        public static event VoidVoidSignature RefreshForm;

        public static void ResetParameters()
        {
            ЛампочкаМУ = (N502BParameters.ЛампочкаСфазировано
                          && N502BParameters.ТумблерЭлектрооборудование
                          && N502BParameters.ТумблерВыпрямитель27В);
        }

        public static void ChangeLampsStateTo(bool isEnable)
        {
            if (ЛампочкаМУ && (N15Parameters.Н15ЛампочкаППВВкл1 != "true") && (N15Parameters.Н15ЛампочкаППВРабота1 != "true"))
            {
                for (var i = 0; i < ЛампочкиФаз.Length; i++)
                {
                    ЛампочкиФаз[i] = isEnable;
                }
            }
        }
    }
}
