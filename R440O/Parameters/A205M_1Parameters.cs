using System.Drawing;

namespace R440O.Parameters
{
    public class A205M_1Parameters
    {

        #region Private fields
        private static int _а205M_1ПереключательВолнаX10000 = 0;
        private static int _а205M_1ПереключательВолнаХ1000 = 0;
        private static int _а205M_1ПереключательВолнаХ100 = 0;
        private static int _а205M_1ПереключательВолнаХ10 = 0;
        private static int _а205M_1ПереключательВолнаХ1 = 0;
        private static int _а205M_1ПереключательКонтроль = 1;
        private static int _а205M_1ПереключательВидРаботы = 1;
        private static int _а205M_1ПереключательВходЧТ = 1;
        #endregion
        
        ////Лампочки
        public static bool A205M_1ЛампочкаНормРаб;
        public static bool A205M_1ЛампочкаПерегрев;

        ////Тумблеры
        /// <summary>
        /// Получает или задает положение тумблера КЭД
        /// </summary>
        public static bool A205M_1ТумблерКЭД = false;

        //Переключатели
        #region Переключатели волны
        public static int A205M_1ПереключательВолнаX10000
        {
            get { return _а205M_1ПереключательВолнаX10000; }

            set
            {
                if (value > -1 && value < 6)
                {
                    _а205M_1ПереключательВолнаX10000 = value;
                }
            }
        }

        public static int A205M_1ПереключательВолнаX1000
        {
            get { return _а205M_1ПереключательВолнаХ1000; }

            set
            {
                if (value > -1 && value < 10)
                {
                    _а205M_1ПереключательВолнаХ1000 = value;
                }
            }
        }

        public static int A205M_1ПереключательВолнаX100
        {
            get { return _а205M_1ПереключательВолнаХ100; }

            set
            {
                if (value > -1 && value < 10)
                {
                    _а205M_1ПереключательВолнаХ100 = value;
                }
            }
        }

        public static int A205M_1ПереключательВолнаX10
        {
            get { return _а205M_1ПереключательВолнаХ10; }

            set
            {
                if (value > -1 && value < 10)
                {
                    _а205M_1ПереключательВолнаХ10 = value;
                }
            }
        }

        public static int A205M_1ПереключательВолнаX1
        {
            get { return _а205M_1ПереключательВолнаХ1; }

            set
            {
                if (value > -1 && value < 10)
                {
                    _а205M_1ПереключательВолнаХ1 = value;
                }
            }
        } 
        #endregion

        #region ПереключательКонтроль
        public static int A205M_1ПереключательКонтроль
        {
            get { return _а205M_1ПереключательКонтроль; }

            set
            {
                if (value > 0 && value < 11)
                {
                    _а205M_1ПереключательКонтроль = value;
                }
            }
        }

        public static string[,] A205M_1ЗначенияПереключательКонтроль = { { "ППВ", "0" },
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
        #endregion

        #region ПереключательВидРаботы
        public static int A205M_1ПереключательВидРаботы
        {
            get { return _а205M_1ПереключательВидРаботы; }

            set
            {
                if (value > 0 && value < 5)
                {
                    _а205M_1ПереключательВидРаботы = value;
                }
            }
        }

        public static string[] A205M_1ЗначенияПереключательВидРаботы =
        {
            "ЧТ-200", 
            "ЧТ-20", 
            "ОФТ2,4-5,2", 
            "ОФТ48"
        };
        #endregion

        #region ПереключательВходЧТ
        public static int A205M_1ПереключательВходЧТ
        {
            get { return _а205M_1ПереключательВходЧТ; }

            set
            {
                if (value > 0 && value < 4)
                {
                    _а205M_1ПереключательВходЧТ = value;
                }
            }
        }
        #endregion

        //Индикатор
        private static int A205M_1ИндикаторКонтроль;
    }
}
