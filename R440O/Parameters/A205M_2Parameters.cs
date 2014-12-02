namespace R440O.Parameters
{
    public class A205M_2Parameters
    {

        #region Private fields
        private static int _а205M_2ПереключательВолнаX10000 = 0;
        private static int _а205M_2ПереключательВолнаХ1000 = 0;
        private static int _а205M_2ПереключательВолнаХ100 = 0;
        private static int _а205M_2ПереключательВолнаХ10 = 0;
        private static int _а205M_2ПереключательВолнаХ1 = 0;
        private static int _а205M_2ПереключательКонтроль = 1;
        private static int _а205M_2ПереключательВидРаботы = 1;
        private static int _а205M_2ПереключательВходЧТ = 1;
        #endregion

        ////Лампочки
        public static string A205M_2ЛампочкаНормРаб { get; set; }
        public static string A205M_2ЛампочкаПерегрев { get; set; }

        ////Тумблеры
        /// <summary>
        /// Получает или задает положение тумблера КЭД
        /// </summary>
        public static bool A205M_2ТумблерКЭД { get; set; }

        ////Переключатели

        #region Переключатели волны
        public static int A205M_2ПереключательВолнаX10000
        {
            get { return _а205M_2ПереключательВолнаX10000; }

            set
            {
                if (value > -1 && value < 6)
                {
                    _а205M_2ПереключательВолнаX10000 = value;
                }
            }
        }

        public static int A205M_2ПереключательВолнаX1000
        {
            get { return _а205M_2ПереключательВолнаХ1000; }

            set
            {
                if (value > -1 && value < 10)
                {
                    _а205M_2ПереключательВолнаХ1000 = value;
                }
            }
        }

        public static int A205M_2ПереключательВолнаX100
        {
            get { return _а205M_2ПереключательВолнаХ100; }

            set
            {
                if (value > -1 && value < 10)
                {
                    _а205M_2ПереключательВолнаХ100 = value;
                }
            }
        }

        public static int A205M_2ПереключательВолнаX10
        {
            get { return _а205M_2ПереключательВолнаХ10; }

            set
            {
                if (value > -1 && value < 10)
                {
                    _а205M_2ПереключательВолнаХ10 = value;
                }
            }
        }

        public static int A205M_2ПереключательВолнаX1
        {
            get { return _а205M_2ПереключательВолнаХ1; }

            set
            {
                if (value > -1 && value < 10)
                {
                    _а205M_2ПереключательВолнаХ1 = value;
                }
            }
        }
        #endregion

        public static int A205M_2ПереключательКонтроль
        {
            get { return _а205M_2ПереключательКонтроль; }

            set
            {
                if (value > 0 && value < 11)
                {
                    _а205M_2ПереключательКонтроль = value;
                }
            }
        }

        public static string[,] A205M_2ЗначенияПереключательКонтроль = { { "ППВ", "0" },
            { "ГИ", "0" },
            { "Д", "0" },
            { "ОГ", "0" },
            { "СЧ1", "0" },
            { "СЧ2", "0" },
            { "НП", "0" },
            { "ВЫХ-85", "0" },
            { "ЧТ-ВТ", "0" },
            { "ВБВ", "0" }
        };

        public static int A205M_2ПереключательВидРаботы
        {
            get { return _а205M_2ПереключательВидРаботы; }

            set
            {
                if (value > 0 && value < 5)
                {
                    _а205M_2ПереключательВидРаботы = value;
                }
            }
        }

        public static string[] A205M_2ЗначенияПереключательВидРаботы =
        {
            "ЧТ-200", 
            "ЧТ-20", 
            "ОФТ2,4-5,2", 
            "ОФТ48"
        };

        public static int A205M_2ПереключательВходЧТ
        {
            get { return _а205M_2ПереключательВходЧТ; }

            set
            {
                if (value > 0 && value < 4)
                {
                    _а205M_2ПереключательВходЧТ = value;
                }
            }
        }
    }
}
