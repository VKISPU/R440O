
namespace R440O.Parameters
{
    using СостоянияЭлементов.Контур_П;
    using R440O.R440OForms;
    using R440O.R440OForms.N15;
    using R440O.ThirdParty;
    partial class Kontur_P3Parameters
    {
        #region Лампочки
        public static bool ЛампочкаКП5Прием = false;
        public static bool ЛампочкаНеиспр = false;
        public static bool ЛампочкаКонтроль = false;
        public static bool ЛампочкаСбойПодписи = false;
        public static bool ЛампочкаПередача = false;
        public static bool ЛампочкаОтбой = false;
        public static bool ЛампочкаИнформПринята = false;
        #endregion

        #region Тумблеры
        private static EТумблерМткПУ _ТумблерМткПУ = EТумблерМткПУ.МТК;
        public static EТумблерМткПУ ТумблерМткПУ
        {
            get { return _ТумблерМткПУ; }
            set { _ТумблерМткПУ = value; }
        }
        #endregion

    }
}
