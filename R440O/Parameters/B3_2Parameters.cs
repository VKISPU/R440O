
namespace R440O.Parameters
{
    class B3_2Parameters
    {
        #region Лампочки

        public static string B3_2ЛампочкаПУЛГ_1 { get; set; }
        public static string B3_2ЛампочкаПУЛГ_2 { get; set; }
        public static string B3_2ЛампочкаПРИавар { get; set; }
        public static string B3_2ЛампочкаРС_1 { get; set; }
        public static string B3_2ЛампочкаРС_синхр { get; set; }
        public static string B3_2ЛампочкаТЛГпр1 { get; set; }
        public static string B3_2ЛампочкаТЛГпр2 { get; set; }
        public static string B3_2ЛампочкаТЛГпр3 { get; set; }
        public static string B3_2ЛампочкаОКпр1 { get; set; }
        public static string B3_2ЛампочкаПФТК1_1 { get; set; }
        public static string B3_2ЛампочкаПФТК1_2 { get; set; }
        public static string B3_2ЛампочкаОКпр2 { get; set; }
        public static string B3_2ЛампочкаПФТК2_1 { get; set; }
        public static string B3_2ЛампочкаПФТК2_2 { get; set; }
        public static string B3_2ЛампочкаВУПнеиспр { get; set; }
        public static string B3_2ЛампочкаВУП_1 { get; set; }

        #endregion

        #region Колодки

        private static int _B3_2КолодкаУКК1 = 0;
        public static int B3_2КолодкаУКК1
        {
            get { return _B3_2КолодкаУКК1; }
            set
            {
                if (value >= 0 && value <= 9) _B3_2КолодкаУКК1 = value;
            }
        }

        private static int _B3_2КолодкаУКК2 = 0;
        public static int B3_2КолодкаУКК2
        {
            get { return _B3_2КолодкаУКК2; }
            set
            {
                if (value >= 0 && value <= 9) _B3_2КолодкаУКК2 = value;
            }
        }

        public static bool B3_2КолодкаОКпр1_син = false;
        public static bool B3_2КолодкаОКпр1_ас = false;

        public static bool B3_2КолодкаОКпр2_син = false;
        public static bool B3_2КолодкаОКпр2_ас = false;

        private static int _B3_2КолодкаКРПР = 0;
        public static int B3_2КолодкаКРПР
        {
            get { return _B3_2КолодкаКРПР; }
            set
            {
                if (value >= 0 && value <= 5) _B3_2КолодкаКРПР = value;
            }
        }

        public static bool B3_2КолодкаТЛГпр1_1 = false;
        public static bool B3_2КолодкаТЛГпр1_2 = false;

        public static bool B3_2КолодкаТЛГпр2_1 = false;
        public static bool B3_2КолодкаТЛГпр2_2 = false;

        public static bool B3_2КолодкаТЛГпр3_1 = false;
        public static bool B3_2КолодкаТЛГпр3_2 = false;
        #endregion

        //Тумблеры 
        /// <summary>
        /// Возможные состояния: Му - местное управление, Ду - дистанционное управление
        /// </summary>
        public static string B3_2ТумблерМуДу = "Ду";

    }
}
