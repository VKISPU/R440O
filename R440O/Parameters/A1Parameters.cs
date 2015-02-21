namespace R440O.Parameters
{
    /// <summary>
    /// Параметры для блока А1
    /// </summary>
    public class A1Parameters
    {
        ////Лампочки
        public static string A1ЛампочкаБОЧ { get; set; }
        public static string A1ЛампочкаФСПК { get; set; }
        public static string A1ЛампочкаТКААвария { get; set; }
        public static string A1ЛампочкаЭП1 { get; set; }
        public static string A1ЛампочкаПУЛ1_1 { get; set; }
        public static string A1ЛампочкаПУЛ1_2 { get; set; }
        public static string A1ЛампочкаЭП2 { get; set; }
        public static string A1ЛампочкаПУЛ2_1 { get; set; }
        public static string A1ЛампочкаПУЛ2_2 { get; set; }
        public static string A1ЛампочкаЭП3 { get; set; }
        public static string A1ЛампочкаПУЛ3_1 { get; set; }
        public static string A1ЛампочкаПУЛ3_2 { get; set; }
        public static string A1ЛампочкаНеиспр { get; set; }
        public static string A1BЛампочкаПитание { get; set; }

        ////Тумблер
        /// <summary>
        /// Получает или задает возможные состояния: Му - местное управление, Ду - дистанционное управление
        /// </summary>
        public static string A1ТумблерМуДу = "Ду";

        ////Кнопки
        /// <summary>
        /// Получает или задает возможные состояния: true, false
        /// </summary>
        public static bool A1КнопкаСкоростьГР = false;
        
        /// <summary>
        /// Получает или задает возможные состояния: true, false
        /// </summary>
        public static bool A1КнопкаСкоростьАБ_1ТЛФ_К = false;
    }
}
