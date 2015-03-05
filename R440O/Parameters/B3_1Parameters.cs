
namespace R440O.Parameters
{
    class B3_1Parameters
    {
        #region Лампочки

        public static string B3_1ЛампочкаПУЛГ_1 { get; set; }
        public static string B3_1ЛампочкаПУЛГ_2 { get; set; }
        public static string B3_1ЛампочкаПРИавар { get; set; }
        public static string B3_1ЛампочкаРС_1 { get; set; }
        public static string B3_1ЛампочкаРС_синхр { get; set; }
        public static string B3_1ЛампочкаТЛГпр1 { get; set; }
        public static string B3_1ЛампочкаТЛГпр2 { get; set; }
        public static string B3_1ЛампочкаТЛГпр3 { get; set; }
        public static string B3_1ЛампочкаОКпр1 { get; set; }
        public static string B3_1ЛампочкаПФТК1_1 { get; set; }
        public static string B3_1ЛампочкаПФТК1_2 { get; set; }
        public static string B3_1ЛампочкаОКпр2 { get; set; }
        public static string B3_1ЛампочкаПФТК2_1 { get; set; }
        public static string B3_1ЛампочкаПФТК2_2 { get; set; }
        public static string B3_1ЛампочкаВУПнеиспр { get; set; }
        public static string B3_1ЛампочкаВУП_1 {get; set; }

        #endregion

        #region Колодки

        private static int _B3_1КолодкаУКК1 = 0;
        public static int B3_1КолодкаУКК1
        {
            get { return _B3_1КолодкаУКК1; }
            set
            {
                if (value >= 0 && value <= 9) _B3_1КолодкаУКК1 = value;
            }
        }

        private static int _B3_1КолодкаУКК2 = 0;
        public static int B3_1КолодкаУКК2
        {
            get { return _B3_1КолодкаУКК2; }
            set
            {
                if (value >= 0 && value <= 9) _B3_1КолодкаУКК2 = value;
            }
        }

        public static bool B3_1КолодкаОКпр1_син = false;
        public static bool B3_1КолодкаОКпр1_ас = false;

        public static bool B3_1КолодкаОКпр2_син = false;
        public static bool B3_1КолодкаОКпр2_ас = false;

        private static int _B3_1КолодкаКРПР = 0;
        public static int B3_1КолодкаКРПР
        {
            get { return _B3_1КолодкаКРПР; }
            set
            {
                if (value >= 0 && value <= 5) _B3_1КолодкаКРПР = value;
            }
        }

        public static bool B3_1КолодкаТЛГпр1_1 = false;
        public static bool B3_1КолодкаТЛГпр1_2 = false;

        public static bool B3_1КолодкаТЛГпр2_1 = false;
        public static bool B3_1КолодкаТЛГпр2_2 = false;

        public static bool B3_1КолодкаТЛГпр3_1 = false;
        public static bool B3_1КолодкаТЛГпр3_2 = false;
        #endregion

        //Тумблеры 
        /// <summary>
        /// Возможные состояния: Му - местное управление, Ду - дистанционное управление
        /// </summary>
        public static string B3_1ТумблерМуДу = "Ду";

    }
}
