namespace R440O.Parameters
{
    using СостоянияЭлементов.Контур_П;
    using R440O.R440OForms;
    using R440O.R440OForms.N15;
    using R440O.ThirdParty;

    partial class Kontur_P3Parameters
    {
        #region Лампочки
        public static bool ЛампочкаПР1_ЗА = false;
        public static bool ЛампочкаПР2_ЗА = false;
        public static bool ЛампочкаСеть = false;
        #endregion

        #region Тумблеры
        private static EТумблерСеть _ТумблерСеть = EТумблерСеть.ОТКЛ;
        public static EТумблерСеть ТумблерСеть
        {
            get { return _ТумблерСеть; }
            set { _ТумблерСеть = value; }
        }
        #endregion

        #region ПереключательКонтроль
        /// <summary>
        /// Положение переключателя Приоритет
        /// </summary>
        private static EПереключательКонтроль _ПереключательКонтроль = EПереключательКонтроль.ОТКЛ;
        public static EПереключательКонтроль ПереключательКонтроль
        {
            get { return _ПереключательКонтроль; }
            set
            {
                if (value >= EПереключательКонтроль.ОТКЛ
                    && value <= EПереключательКонтроль._p9B_резерв)
                {
                    _ПереключательКонтроль = value;
                }
            }
        }

        /// <summary>
        /// Названия положений переключателя Контроль
        /// </summary>
        private static string[] ПоложенияПереключательКонтроль = {
            "откл",
            "+9В",
            "+5Вст",
            "+12В",
            "сеть",
            "+20В",
            "-20В",
            "+15В",
            "-15В",
            "+9Врезерв"
        };
        #endregion
    }
}
