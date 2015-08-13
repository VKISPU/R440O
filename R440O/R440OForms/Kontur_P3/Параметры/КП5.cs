using R440O.СостоянияЭлементов.Контур_П;

namespace R440O.R440OForms.Kontur_P3.Параметры
{
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
            set
            {
                _ТумблерМткПУ = value;
                if (RefreshForm != null) RefreshForm();
            }
        }
        #endregion

        #region Кнопки
        private static bool _кнопкаПодпись1;
        private static bool _кнопкаПодпись2;
        private static bool _кнопкаПодпись3;
        private static bool _кнопкаАдресК;

        public static bool КнопкаАдресК
        {
            get { return _кнопкаАдресК; }
            set
            {
                _кнопкаАдресК = value;
                if (RefreshForm != null) RefreshForm();
            }
        }

        public static bool КнопкаПодпись1
        {
            get { return _кнопкаПодпись1; }
            set
            {
                _кнопкаПодпись1 = value;
                if (RefreshForm != null) RefreshForm();
            }
        }

        public static bool КнопкаПодпись2
        {
            get { return _кнопкаПодпись2; }
            set
            {
                _кнопкаПодпись2 = value;
                if (RefreshForm != null) RefreshForm();
            }
        }

        public static bool КнопкаПодпись3
        {
            get { return _кнопкаПодпись3; }
            set
            {
                _кнопкаПодпись3 = value;
                if (RefreshForm != null) RefreshForm();
            }
        }

        #endregion

        #region Табло

        public static string ТаблоАдрес1 { get { return ""; } }
        public static string ТаблоАдрес2 { get { return ""; } }

        public static string ТаблоГруппа
        {
            get
            {
                return ЛампочкаСеть ? "0" : "";
                
            }
        }

        public static string ТаблоИнформация { get { return ""; } }
        #endregion
    }
}
