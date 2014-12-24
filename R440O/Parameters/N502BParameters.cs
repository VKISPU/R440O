namespace R440O.Parameters
{
    public class N502BParameters
    {
        ////Лампочки
        /// <summary>
        /// Параметр для лампочки. Возможные состояния: true, false
        /// </summary>
        private static bool _N502BЛампочкаСеть = true;
        public static bool N502BЛампочкаСеть
        {
            get
            {
                return _N502BЛампочкаСеть;
            }

            set
            {
                _N502BЛампочкаСеть = value;
            }
        }

        /// <summary>
        /// Параметр для лампочки. Возможные состояния: true, false
        /// </summary>
        private static bool _N502BЛампочкаСфазировано = false;
        public static bool N502BЛампочкаСфазировано
        {
            get
            {
                return _N502BЛампочкаСфазировано;
            }

            set
            {
                _N502BЛампочкаСфазировано = value;
            }
        }

        public static string N502BЛампочкаРБППроверка { get; set; }

        ////public static string N502BЛампочкаРБППредохранитель { get; set; }

        #region Тумблеры
        /// <summary>
        /// true - вкл, false - выкл
        /// </summary>
        public static bool N502BТумблерЭлектрооборуд = false;

        /// <summary>
        /// true - вкл, false - выкл
        /// </summary>
        public static bool N502BТумблерВыпрямитель27В = false;

        public static string N502BТумблерОсвещение = "false";
        public static string N502BТумблерН13_1 = "false";
        public static string N502BТумблерН13_2 = "false";
        public static string N502BТумблерН15 = "false";
        public static string N502BТумблерОсвещение1 = "откл";
        public static string N502BТумблерОсвещение2 = "откл";
        #endregion

        #region Переключатели

        public static string N502BПереключательСеть = "false";

        #region ПереключательНапряжение
        /// <summary>
        /// Положение переключателя напряжения
        /// </summary>
        private static int _N502BПереключательНапряжение = 1;

        public static int N502BПереключательНапряжение
        {
            get { return _N502BПереключательНапряжение; }
            set
            {
                if (value > 0 && value < 7) _N502BПереключательНапряжение = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя напряжения
        /// </summary>
        private static string[] N502BПоложенияПереключательНапряжение = {
            "сеть1-2",
            "сеть1-3",
            "сеть2-3",
            "нагрузка1-2",
            "нагрузка1-3",
            "нагрузка2-3"
        };
        #endregion

        #region ПереключательФазировка
        /// <summary>
        /// Положение переключателя Фазировка
        /// </summary>
        private static int _N502BПереключательФазировка = 1;

        public static int N502BПереключательФазировка
        {
            get { return _N502BПереключательФазировка; }
            set
            {
                if (value >= 0 && value <= 5) _N502BПереключательФазировка = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя фазировка
        /// </summary>
        private static string[] N502BПоложенияПереключательФазировка = {
            "откл",
            "1-2-3",
            "откл",
            "2-1-3"
        };
        #endregion

        #region ПереключательКонтрольНапряжения
        /// <summary>
        /// Положение переключателя контроль напряжения
        /// </summary>
        private static int _N502BПереключательКонтрольНапряжения = 2;

        public static int N502BПереключательКонтрольНапряжения
        {
            get { return _N502BПереключательКонтрольНапряжения; }
            set
            {
                if (value > 0 && value < 4) _N502BПереключательКонтрольНапряжения = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя  контроля напряжения
        /// </summary>
        private static string[] N502BПоложенияКонтрольНапряжения = {
            "+27B",
            "откл",
            "+12B"     
        };
        #endregion

        #region ПереключательТокНагрузкиИЗаряда
        /// <summary>
        /// Положение переключателя тока нагрузки и заряда
        /// </summary>
        private static int _N502BПереключательТокНагрузкиИЗаряда = 1;

        public static int N502BПереключательТокНагрузкиИЗаряда
        {
            get { return _N502BПереключательТокНагрузкиИЗаряда; }
            set
            {
                if (value > 0 && value < 9) _N502BПереключательТокНагрузкиИЗаряда = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя тока нагрузки и заряда
        /// </summary>
        private static string[] N502BПоложенияПереключательТокНагрузкиИЗаряда = {
            "откл",
            "отопительФВУА",
            "зарядкаБатареи",
            "+Ток1", 
            "+Ток2", 
            "+Ток3", 
            "+Ток4", 
            "+Ток5"
        };
        #endregion

        #endregion
    }
}
