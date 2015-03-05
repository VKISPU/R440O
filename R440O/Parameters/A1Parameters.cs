namespace R440O.Parameters
{
    /// <summary>
    /// Параметры для блока А1
    /// </summary>
    public class A1Parameters
    {
        ////Лампочки
        public static bool A1ЛампочкаБОЧ = false;
        public static bool A1ЛампочкаФСПК;
        public static bool A1ЛампочкаТКААвария;
        public static bool A1ЛампочкаЭП1;
        public static bool A1ЛампочкаПУЛ1_1;
        public static bool A1ЛампочкаПУЛ1_2;
        public static bool A1ЛампочкаЭП2;
        public static bool A1ЛампочкаПУЛ2_1;
        public static bool A1ЛампочкаПУЛ2_2;
        public static bool A1ЛампочкаЭП3;
        public static bool A1ЛампочкаПУЛ3_1;
        public static bool A1ЛампочкаПУЛ3_2;
        public static bool A1ЛампочкаНеиспр;
        public static bool A1BЛампочкаПитание;

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
