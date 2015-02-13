using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R440O.Parameters
{
    class C1_67Parameters
    {
        #region ПереключательУсиление
        /// <summary>
        /// Положение переключателя усиление
        /// </summary>
        private static int _C1_67ПереключательУсиление = 1;

        public static int C1_67ПереключательУсиление
        {
            get { return _C1_67ПереключательУсиление; }
            set
            {
                if (value > -1 && value < 14) _C1_67ПереключательУсиление = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя усиление
        /// </summary>
        private static string[] C1_67ПоложенияПереключательУсиление = {
            "20",
            "10",
            "5",
            "2",
            "1",
            "0.5",
            "0.2",
            "0.1",
            "0.05",
            "0.02",
            "0.01",
            "0.005"
        };
        #endregion

        #region ПереключательДлительность
        /// <summary>
        /// Положение переключателя длительность
        /// </summary>
        private static int _C1_67ПереключательДлительность = 1;

        public static int C1_67ПереключательДлительность
        {
            get { return _C1_67ПереключательДлительность; }
            set
            {
                if (value > 0 && value < 19) _C1_67ПереключательДлительность = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя длительность
        /// </summary>
        private static string[] C1_67ПоложенияПереключательДлительность = {
            "50",
            "20",
            "10",
            "5",
            "2",
            "1",
            "0.5",
            "0.2",
            "0.1",
            "50",
            "20",
            "10",
            "5",
            "2",
            "1",
            "0.5",
            "0.2",
            "0.1",
        };
        #endregion

        #region ПереключательВыборПриемника
        private static int _C1_67_N19ПереключательВыборПриемника = 1;

        public static int C1_67_N19ПереключательВыборПриемника
        {
            get { return _C1_67_N19ПереключательВыборПриемника; }
            set
            {
                if (value > 0 && value < 6) _C1_67_N19ПереключательВыборПриемника = value;
            }
        }
        #endregion

        public static bool C1_67ПереключательУсилительУ1=true;
        public static bool C1_67ПереключательУсилительУ2=false;
        public static bool C1_67ПереключательУсилительУ3=false;

        public static int C1_67ПереключательСинхронизация;

        public static int C1_67РегуляторЯркость;
        public static int C1_67РегуляторФокус;
        public static int C1_67РегуляторШкала;
        public static int C1_67РегуляторГрубо;
        public static int C1_67РегуляторПлавно;
        public static int C1_67РегуляторСтаб;
        public static int C1_67РегуляторБалансир;
        public static int C1_67РегуляторУровень;

        public static bool C1_67_N19ТумблерВклВыкл=false;
        public static string C1_67_N19Тумблер200_20="20";
        public static string C1_67ТумблерX1X02="X02";
        public static bool C1_67ТумблерСеть=false;
        public static bool C1_67Тумблер2kHz=false;

    }
}
