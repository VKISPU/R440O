namespace R440O.Parameters
{
    internal class AstraParameters
    {
        #region Переключатели
        #region ПереключательТлгТлф

        private static int _AstraПереключательТлгТлф = 1;

        public static int AstraПереключательТлгТлф
        {
            get { return _AstraПереключательТлгТлф; }
            set
            {
                if (value > 0 && value < 5) _AstraПереключательТлгТлф = value;
            }
        }

        private static string[] AstraПоложенияПереключательТлгТлф = {
            "флг_рру",
            "флг_ару",
            "тлг_ару",
            "тлг_рру",
        };
        #endregion

        #region ПереключательВнешнегоПитания

        private static int _AstraПереключательВнешнегоПитания = 1;

        public static int AstraПереключательВнешнегоПитания
        {
            get { return _AstraПереключательВнешнегоПитания; }
            set
            {
                if (value > 0 && value < 5) _AstraПереключательВнешнегоПитания = value;
            }
        }

        private static string[] AstraПоложенияПереключательВнешнегоПитания = {
            "115",
            "+12",
            "220",
            "выкл",
        };
        #endregion

        #region ПереключательКонтроль

        private static int _AstraПереключательКонтроль = 1;

        public static int AstraПереключательКонтроль
        {
            get { return _AstraПереключательКонтроль; }
            set
            {
                if (value > 0 && value < 4) _AstraПереключательКонтроль = value;
            }
        }

        private static string[] AstraПоложенияПереключательКонтроль = {
            "настройка",
            "гетер",
            "+12в"
        };
        #endregion

        #region ПереключательДиапазоны

        private static int _AstraПереключательДиапазоны = 1;

        public static int AstraПереключательДиапазоны
        {
            get { return _AstraПереключательДиапазоны; }
            set
            {
                if (value > 0 && value < 10) _AstraПереключательДиапазоны = value;
            }
        }

        private static string[] AstraПоложенияПереключательДиапазоны = {
            "выкл",
            "12-150кгц",
            "1.15мгц",
            "2.5мгц",
            "5мгц",
            "10мгц",
            "15мгц",
            "20мгц",
            "25мгц"
        };
        #endregion

        #region ПереключательВыходаРеле

        private static int _AstraПереключательВыходаРеле = 1;

        public static int AstraПереключательВыходаРеле
        {
            get { return _AstraПереключательВыходаРеле; }
            set
            {
                if (value > 0 && value < 4) _AstraПереключательВыходаРеле = value;
            }
        }

        private static string[] AstraПоложенияПереключательВыходаРеле = {
            "пч",
            "реле",
            "выкл",
        };
        #endregion
        #endregion

        ////Тумблеры
        /// <summary>
        /// Положение переключателя ШпУп. true - шп, false - уп
        /// </summary>
        public static bool AstraТумблерШпУп = true;

        ////Кнопки
        public static bool AstraКнопка150_270 { get; set; }
        public static bool AstraКнопка270_480 { get; set; }
        public static bool AstraКнопка480_860 { get; set; }
        public static bool AstraКнопка860_1500 { get; set; }
        public static bool AstraКнопкаЧастота { get; set; }

        ////Вращатели
        private static int _astraВращательУсиление;
        private static int _astraВращательУсилениеПЧ;

        public static int AstraВращательЧастота { get; set; }

        public static int AstraВращательУсиление
        {
            get { return _astraВращательУсиление; }
            set { if (value < 120 && value > -120) _astraВращательУсиление = value; }
        }
        public static int AstraВращательУсилениеПЧ
        {
            get { return _astraВращательУсилениеПЧ; }
            set { if (value < 120 && value > -120) _astraВращательУсилениеПЧ = value; }
        }

        static AstraParameters()
        {
            AstraВращательЧастота = 0;
        }
    }
}
