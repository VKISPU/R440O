using R440O.СостоянияЭлементов.Контур_П;

namespace R440O.R440OForms.Kontur_P3.Параметры
{
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
            set
            {
                _ТумблерКонтроль = value;
                if (RefreshForm != null) RefreshForm();
            }
        }
        #endregion
    }
}
