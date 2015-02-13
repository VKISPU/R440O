namespace R440O.Parameters
{
    public class Kontur_P3Parameters
    {
        //Лампочки
        public static string Kontur_P3ЛампочкаКонтрольПодписи { get; set; }
        public static string Kontur_P3ЛампочкаКП1Канал10 { get; set; }
        public static string Kontur_P3ЛампочкаКП1Канал11 { get; set; }
        public static string Kontur_P3ЛампочкаКП2Прием { get; set; }
        public static string Kontur_P3ЛампочкаКП3Канал10 { get; set; }
        public static string Kontur_P3ЛампочкаКП3Канал11 { get; set; }
        public static string Kontur_P3ЛампочкаКП3Канал12 { get; set; }

        public static string Kontur_P3ЛампочкаКП4Канал1 { get; set; }
        public static string Kontur_P3ЛампочкаКП4Канал2 { get; set; }
        public static string Kontur_P3ЛампочкаКП4Канал3 { get; set; }
        public static string Kontur_P3ЛампочкаКП4Канал4 { get; set; }
        public static string Kontur_P3ЛампочкаКП4Канал5 { get; set; }
        public static string Kontur_P3ЛампочкаКП4Канал6 { get; set; }
        public static string Kontur_P3ЛампочкаКП4Канал7 { get; set; }
        public static string Kontur_P3ЛампочкаКП4Канал8 { get; set; }
        public static string Kontur_P3ЛампочкаКП4Канал9 { get; set; }

        public static string Kontur_P3ЛампочкаКП5Прием { get; set; }

        public static string Kontur_P3ЛампочкаНеиспр { get; set; }
        public static string Kontur_P3ЛампочкаКонтроль { get; set; }
        public static string Kontur_P3ЛампочкаСбойПодписи { get; set; }

        public static string Kontur_P3ЛампочкаПередача { get; set; }

        public static string Kontur_P3ЛампочкаОтбой { get; set; }
        public static string Kontur_P3ЛампочкаИнформПринята { get; set; }

        public static string Kontur_P3ЛампочкаКП6Передача { get; set; }
        public static string Kontur_P3ЛампочкаКП6Сбой { get; set; }
        public static string Kontur_P3ЛампочкаКП6Режим3 { get; set; }

        public static string Kontur_P3ЛампочкаПР1_ЗА { get; set; }
        public static string Kontur_P3ЛампочкаПР2_ЗА { get; set; }
        public static string Kontur_P3ЛампочкаСеть { get; set; }

        //Тумблеры

        public static string Kontur_P3ТумблерКонтроль = "Контроль1";

        public static string Kontur_P3ТумблерМткПУ = "МТК";

        public static string Kontur_P3ТумблерДокументирование = "Вкл";

        public static string Kontur_P3ТумблерАсинхрСинхр = "Синхр";

        public static string Kontur_P3ТумблерРежим = "Режим1";

        public static string Kontur_P3ТумблерСеть = "Вкл";

        //Переключатели
        #region Kontur_P3ПереключательПриоритет
        /// <summary>
        /// Положение переключателя Приоритет
        /// </summary>
        private static int _Kontur_P3ПереключательПриоритет = 0;

        public static int Kontur_P3ПереключательПриоритет
        {
            get { return _Kontur_P3ПереключательПриоритет; }

            set
            {
                if (value > -1 && value < 10)
                {
                    _Kontur_P3ПереключательПриоритет = value;
                }
            }
        }
        #endregion

        #region Kontur_P3ПереключательКонтроль
        /// <summary>
        /// Положение переключателя Приоритет
        /// </summary>
        private static int _Kontur_P3ПереключательКонтроль = 1;

        public static int Kontur_P3ПереключательКонтроль
        {
            get { return _Kontur_P3ПереключательКонтроль; }

            set
            {
                if (value > 0 && value < 11)
                {
                    _Kontur_P3ПереключательКонтроль = value;
                }
            }
        }

        /// <summary>
        /// Названия положений переключателя Контроль
        /// </summary>
        private static string[] Kontur_P3ПоложенияПереключательКонтроль = {
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
