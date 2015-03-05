namespace R440O.Parameters
{
    public class B1_2Parameters
    {
        #region Лампочки
        public static string B1_2ЛампочкаБОЧ { get; set; }
        public static string B1_2ЛампочкаПУЛ_1 { get; set; }
        public static string B1_2ЛампочкаПУЛ_2 { get; set; }
        public static string B1_2ЛампочкаПРСС { get; set; }
        public static string B1_2ЛампочкаТКБтк1_1 { get; set; }
        public static string B1_2ЛампочкаТКБтк1_2 { get; set; }
        public static string B1_2ЛампочкаТКБтк2_1 { get; set; }
        public static string B1_2ЛампочкаТКБтк2_2 { get; set; }
        public static string B1_2ЛампочкаТКБтк3_1 { get; set; }
        public static string B1_2ЛампочкаТКБтк3_2 { get; set; }
        public static string B1_2ЛампочкаТКБАвар { get; set; }
        public static string B1_2ЛампочкаДФАПЧ1 { get; set; }
        public static string B1_2ЛампочкаДФАПЧ2 { get; set; }
        public static string B1_2ЛампочкаДФАПЧ3 { get; set; }
        public static string B1_2ЛампочкаТЛГпр1 { get; set; }
        public static string B1_2ЛампочкаТЛГпр2 { get; set; }
        public static string B1_2ЛампочкаТКСПР1 { get; set; }
        public static string B1_2ЛампочкаВУП_1 { get; set; }
        public static string B1_2ЛампочкаВУПНеиспр { get; set; }
        #endregion

        #region Колодки
        public static bool B1_2КолодкаТЛГпр1_1 = false;
        public static bool B1_2КолодкаТЛГпр1_2 = false;

        public static bool B1_2КолодкаТЛГпр2_1 = false;
        public static bool B1_2КолодкаТЛГпр2_2 = false;

        public static bool B1_2КолодкаТЛГпр3_1 = false;
        public static bool B1_2КолодкаТЛГпр3_2 = false;
        #endregion

        ////Тумблер
        /// <summary>
        /// Возможные состояния: Му - местное управление, Ду - дистанционное управление
        /// </summary>
        public static string B1_2ТумблерМуДу = "Ду";

        ////Кнопки
        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static bool B1_2КнопкаСкоростьГР = false;

        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static bool B1_2КнопкаСкоростьАБ_1ТЛФ_К = false;
    }
}
