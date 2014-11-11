using System.Runtime.InteropServices;

namespace R440O.Parameters
{
    class A304Parameters
    {
        //Комплекты блока
        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static string A304Комплект1 = "false";

        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static string A304Комплект2 = "false";

        
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
        /// Выбор комплекта обородувания. Возможные состояния: 1K, 2K
        /// </summary>
        public static string A304Тумблер1К2К = "1К"; 

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
        /// Названия положений переключателя контроля
        /// </summary>
        private static string[] A304ПоложенияПереключательКонтроль = {
            "ОГ",
            "СЧЗ",
            "ГН2",
            "-27В",
            "+5В",
            "+12.6",
            "+27В",
            "-5В",
            "-12.6"
        };
    }
}
