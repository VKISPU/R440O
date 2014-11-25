﻿namespace R440O.Parameters
{
    class A304Parameters
    {
        //Комплекты блока
        /// <summary>
        /// Параметр для лампочки. Возможные состояния: true, false
        /// </summary>
        private static bool _a304Комплект1 = false;

        /// <summary>
        /// Параметр для лампочки. Возможные состояния: true, false
        /// </summary>
        private static bool _a304Комплект2 = false;

        /// <summary>
        /// Параметр для лампочки. Возможные состояния: true, false
        /// </summary>
        public static bool A304Комплект1
        {
            get { return _a304Комплект1; }
            set
            {
                _a304Комплект1 = value;
            }
        }

        /// <summary>
        /// Параметр для лампочки. Возможные состояния: true, false
        /// </summary>
        public static bool A304Комплект2
        {
            get { return _a304Комплект2; }
            set
            {
                _a304Комплект2 = value;
            }
        }
        //Лампочки
        public static string A304ЛампочкаПерегрев1К { get; set; }
        public static string A304ЛампочкаПерегрев2К { get; set; }

        //Тумблеры
        /// <summary>
        /// Возможные состояния: местное, дистанц
        /// </summary>
        public static string A304ТумблерМестноеДистанц_1 = "местное";

        /// <summary>
        /// Возможные состояния: местное, дистанц
        /// </summary>
        public static string A304ТумблерМестноеДистанц_2 = "местное";

        /// <summary>
        /// Выбор комплекта обородувания. Возможные состояния: 1, 2
        /// </summary>
        public static int A304Тумблер1К2К = 1; 

        //Переключатели

        /// <summary>
        /// Положение переключателя ствола
        /// </summary>
        private static int _a304ПереключательВыборСтвола = 1;
        public static int A304ПереключательВыборСтвола
        {
            get { return _a304ПереключательВыборСтвола; }
            set
            {
                if (value > 0 && value < 11) _a304ПереключательВыборСтвола = value;
            }
        }

        /// <summary>
        /// Положение переключателя контроля
        /// </summary>
        private static int _a304ПереключательКонтроль = 1;

        public static int A304ПереключательКонтроль
        {
            get { return _a304ПереключательКонтроль; }
            set
            {
                if (value > 0 && value < 10) _a304ПереключательКонтроль = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя контроля. Второй столбец - комплект включён. Третий - комплект выключен.
        /// </summary>
        public static string[,] A304ЗначенияПереключательКонтроль = {
            {"ОГ", "-1", "-1"},
            {"СЧЗ", "1", "0"},
            {"ГН2", "1", "0"},
            {"-27В", "-1","0"},
            {"+5В", "1", "0"},
            {"+12.6", "1", "0"},
            {"+27В", "1", "1"},
            {"-5В", "-1", "0"},
            {"-12.6", "-1", "0"}
        };
    }
}