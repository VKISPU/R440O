using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R440O.Parameters
{
    class BMBParameters
    {
        #region ПереключательРаботаКонтроль
        /// <summary>
        /// Положение переключателя работаКонтроль
        /// </summary>
        private static int _BMBПереключательРаботаКонтроль = 1;

        public static int BMBПереключательРаботаКонтроль
        {
            get { return _BMBПереключательРаботаКонтроль; }
            set
            {
                if (value > 0 && value < 3) _BMBПереключательРаботаКонтроль = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя работаКонтроль
        /// </summary>
        private static string[] BMBПоложенияПереключательРаботаКонтроль = {
            "РАБОТА",
            "КОНТРОЛЬ"
        };
        #endregion

        #region ПереключательПодключениеРезерва
        /// <summary>
        /// Положение переключателя подключение резерва
        /// </summary>
        private static int _BMBПереключательПодключениеРезерва = 1;

        public static int BMBПереключательПодключениеРезерва
        {
            get { return _BMBПереключательПодключениеРезерва; }
            set
            {
                if (value > 0 && value < 4) _BMBПереключательПодключениеРезерва = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя подключение резерва
        /// </summary>
        private static string[] BMBПоложенияПереключательПодключениеРезерва = {
            "1",
            "2",
            "3"
        };
        #endregion

        #region ПереключательНаправление
        /// <summary>
        /// Положение переключателя направления
        /// </summary>
        private static int _BMBПереключательНаправление = 1;

        public static int BMBПереключательНаправление
        {
            get { return _BMBПереключательНаправление; }
            set
            {
                if (value > 0 && value < 5) _BMBПереключательНаправление = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя направления
        /// </summary>
        private static string[] BMBПоложенияПереключательНаправление = {
            "1",
            "2",
            "3",
            "4"
        };
        #endregion

        #region Кнопки
        public static bool BMBКнопкаПередачаВызоваТЧ = false;
        public static bool BMBКнопкаПередачаВызоваДК = false;

        public static bool BMBКнопкаСлСвязь = false;
        public static bool BMBКнопкаПитание = false;
        public static bool BMBКнопкаЗвСигнал = false;
        #endregion

        #region Лампочки

        public static bool BMBЛампочкаДК = false;
        public static bool BMBЛампочкаТЧ = false;
        public static bool BMBЛампочкаРезервВкл = false;
        public static bool BMBЛампочкаПриемВызова = false;
        public static bool BMBЛампочкаНаправление1 = false;
        public static bool BMBЛампочкаНаправление2 = false;
        public static bool BMBЛампочкаНаправление3 = false;
        public static bool BMBЛампочкаНаправление4 = false;

        #endregion

        public static string BMBИндикаторНаборКоманды = "  ";
        public static string BMBИндикаторПриемКоманды = "  ";

    }
}
