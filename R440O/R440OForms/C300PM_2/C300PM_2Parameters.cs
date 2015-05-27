using R440O.R440OForms.C300M_3;
using R440O.R440OForms.C300M_4;

namespace R440O.R440OForms.C300PM_2
{
    class C300PM_2Parameters
    {
        /// <summary>
        /// Параметр для лампочки 1 комплекта. Возможные состояния: true, false
        /// </summary>

        private static bool _лампочкаКомплект1 = false;
        public static bool ЛампочкаКомплект1
        {
            get { return _лампочкаКомплект1; }
            set
            {
                _лампочкаКомплект1 = value;
                if (RefreshForm != null) RefreshForm();
            }
        }

        /// <summary>
        /// Параметр для лампочки 2 комплекта. Возможные состояния: true, false
        /// </summary>
        private static bool _лампочкаКомплект2 = false;
        public static bool ЛампочкаКомплект2
        {
            get { return _лампочкаКомплект2; }
            set
            {
                _лампочкаКомплект2 = value;
                if (RefreshForm != null) RefreshForm();
            }
        }

        public static void ResetParameters()
        {
            ЛампочкаКомплект1 = C300M_3Parameters.ЛампочкаПитание;
            ЛампочкаКомплект2 = C300M_4Parameters.ЛампочкаПитание; 
        }


        public delegate void VoidVoidSignature();
        public static event VoidVoidSignature RefreshForm;
    }
}
