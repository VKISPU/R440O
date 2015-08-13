namespace R440O.Parameters
{
    using СостоянияЭлементов.Контур_П;
    using R440O.R440OForms;
    using R440O.R440OForms.N15;
    using R440O.ThirdParty;

    partial class Kontur_P3Parameters
    {
        #region Лампочки
        public static bool ЛампочкаКП2Прием = false;
        #endregion

        #region Тумблеры
        private static EТумблерКонтроль _ТумблерКонтроль = EТумблерКонтроль.КОНТРОЛЬ_1;
        public static EТумблерКонтроль ТумблерКонтроль
        {
            get { return _ТумблерКонтроль; }
            set { _ТумблерКонтроль = value; }
        }
        #endregion
    }
}
