namespace R440O.Parameters
{
    public class Kontur_P3Parameters
    {
        //Лампочки
        public static bool Kontur_P3ЛампочкаКонтрольПодписи = false;
        public static bool Kontur_P3ЛампочкаКП1Канал10 = false;
        public static bool Kontur_P3ЛампочкаКП1Канал11 = false;
        public static bool Kontur_P3ЛампочкаКП2Прием = false;
        public static bool Kontur_P3ЛампочкаКП3Сбой = false;
        public static bool Kontur_P3ЛампочкаКП3Канал10 = false;
        public static bool Kontur_P3ЛампочкаКП3Канал11 = false;
        public static bool Kontur_P3ЛампочкаКП3Канал12 = false;

        public static bool Kontur_P3ЛампочкаКП4Канал1 = false;
        public static bool Kontur_P3ЛампочкаКП4Канал2 = false;
        public static bool Kontur_P3ЛампочкаКП4Канал3 = false;
        public static bool Kontur_P3ЛампочкаКП4Канал4 = false;
        public static bool Kontur_P3ЛампочкаКП4Канал5 = false;
        public static bool Kontur_P3ЛампочкаКП4Канал6 = false;
        public static bool Kontur_P3ЛампочкаКП4Канал7 = false;
        public static bool Kontur_P3ЛампочкаКП4Канал8 = false;
        public static bool Kontur_P3ЛампочкаКП4Канал9 = false;

        public static bool Kontur_P3ЛампочкаКП5Прием = false;

        public static bool Kontur_P3ЛампочкаНеиспр = false;
        public static bool Kontur_P3ЛампочкаКонтроль = false;
        public static bool Kontur_P3ЛампочкаСбойПодписи = false;

        public static bool Kontur_P3ЛампочкаПередача = false;

        public static bool Kontur_P3ЛампочкаОтбой = false;
        public static bool Kontur_P3ЛампочкаИнформПринята = false;

        public static bool Kontur_P3ЛампочкаКП6Передача = false;
        public static bool Kontur_P3ЛампочкаКП6Сбой = false;
        public static bool Kontur_P3ЛампочкаКП6Режим3 = false;

        public static bool Kontur_P3ЛампочкаПР1_ЗА = false;
        public static bool Kontur_P3ЛампочкаПР2_ЗА = false;
        public static bool Kontur_P3ЛампочкаСеть = false;

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
