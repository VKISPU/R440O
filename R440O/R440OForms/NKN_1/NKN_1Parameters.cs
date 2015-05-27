using R440O.R440OForms.A205M_1;
using R440O.R440OForms.N15;
using R440O.R440OForms.N502B;

namespace R440O.R440OForms.NKN_1
{
    /// <summary>
    /// Параметры блока НКН-1
    /// </summary>
    public static class NKN_1Parameters
    {
        #region Питание блока
        private static bool _питание220Включено;
        public static bool Питание220Включено
        {
            get { return _питание220Включено; }
            set
            {
                _питание220Включено = value;
                ResetParameters();
                if (RefreshForm != null) RefreshForm();

                //N15Parameters.A205Distanse1 = false;
                N15Parameters.ResetParameters();
            }
        }

        private static bool _лампочкаМУ;
        /// <summary>
        /// Лампочка показывающая включено ли питание
        /// </summary>
        public static bool ЛампочкаМУ
        {
            get { return _лампочкаМУ; }
            set
            {
                _лампочкаМУ = value;
                if (RefreshForm != null) RefreshForm();
            }
        }
        #endregion

        #region Лампочки Фаз
        /// <summary>
        /// Лампочки показывающие есть ли питание на данной фазе
        /// </summary>
        public static bool[] ЛампочкиФаз = { false, false, false };

        /// <summary>
        /// Переключение всех лампочек фаз в одно из состояний
        /// </summary>
        /// <param name="isEnable">Новое состояние лампочек</param>
        private static void ChangeLampsStateTo(bool isEnable)
        {
            for (var i = 0; i < ЛампочкиФаз.Length; i++)
            {
                ЛампочкиФаз[i] = isEnable;
            }
            A205M_1Parameters.ResetParameters();
            if (RefreshForm != null) RefreshForm();
        }
        #endregion

        public delegate void VoidVoidSignature();
        public static event VoidVoidSignature RefreshForm;

        public static void ResetParameters()
        {
            ЛампочкаМУ = (N502BParameters.ЛампочкаСфазировано
                          && N502BParameters.ТумблерЭлектрооборудование
                          && N502BParameters.ТумблерВыпрямитель27В);

            ChangeLampsStateTo(_лампочкаМУ && _питание220Включено && N502BParameters.ТумблерН15);
        }
    }
}
