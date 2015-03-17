namespace R440O.R440OForms.N502B
{
    public class N502BParameters
    {
        #region Лампочки

        public static bool ЛампочкаСеть = false;
        public static bool ЛампочкаСфазировано = false;
        public static bool ЛампочкаРбпПроверка = false;
        public static bool ЛампочкаРбпПредохранитель = false;

        #endregion

        #region Тумблеры

        public static bool ТумблерЭлектрооборудование = false;
        public static bool ТумблерВыпрямитель27В = false;
        public static bool ТумблерОсвещение = false;
        public static bool ТумблерН131 = false;
        public static bool ТумблерН132 = false;
        public static bool ТумблерН15 = false;

        /// <summary>
        /// Тип: string
        /// Возможные состояния: 1 - Полное, 2 - Откл, 3- Дежурное
        /// </summary>
        public static int ТумблерОсвещение1 = 2;

        /// <summary>
        /// Тип: string
        /// Возможные состояния: 1- Полное, 2- Откл, 3- Частичное
        /// </summary>
        public static int ТумблерОсвещение2 = 2;

        #endregion

        #region Переключатели

        public static bool ПереключательСеть = false;

        private static int _переключательНапряжение = 1;
        public static int ПереключательНапряжение
        {
            get { return _переключательНапряжение; }
            set { if (value > 0 && value < 7) _переключательНапряжение = value; }
        }

        private static int _переключательФазировка = 1;
        public static int ПереключательФазировка
        {
            get { return _переключательФазировка; }
            set { if (value >= 0 && value <= 5) _переключательФазировка = value; }
        }

        private static int _переключательКонтрольНапряжения = 2;
        public static int ПереключательКонтрольНапряжения
        {
            get { return _переключательКонтрольНапряжения; }
            set { if (value > 0 && value < 4) _переключательКонтрольНапряжения = value; }
        }

        private static int _переключательТокНагрузкиИЗаряда = 1;
        public static int ПереключательТокНагрузкиИЗаряда
        {
            get { return _переключательТокНагрузкиИЗаряда; }
            set { if (value > 0 && value < 9) _переключательТокНагрузкиИЗаряда = value; }
        }
        #endregion
    }
}
