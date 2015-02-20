using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R440O.Parameters
{
    class N15InsideParameters
    {
        /// <summary>
        /// Тумблер принимает значение ЧТ1 или ОФТ1
        /// </summary>
        public static string N15InsideТумблерПУЛ480ЧтОфт1 = "ЧТ1";

        /// <summary>
        /// Тумблер принимает значение ЧТ2 или ОФТ2
        /// </summary>
        public static string N15InsideТумблерПУЛ480ЧтОфт2 = "ЧТ2";

        /// <summary>
        /// Тумблер принимает значение ЧТ1 или ОФТ1
        /// </summary>
        public static string N15InsideТумблерПУЛ48ПРДЧтОфт1 = "ОФТ1";

        /// <summary>
        /// Тумблер принимает значение ЧТ2 или ОФТ2
        /// </summary>
        public static string N15InsideТумблерПУЛ48ПРДЧтОфт2 = "ОФТ2";

        #region Переключатель ПУЛ480_1
        /// <summary>
        /// Положение переключателя ПУЛ480_1
        /// </summary>
        private static int _N15InsideПереключательПУЛ480_1 = 1;

        public static int N15InsideПереключательПУЛ480_1
        {
            get
            {
                return _N15InsideПереключательПУЛ480_1;
            }

            set
            {
                if (value > 0 && value < 10)
                {
                    _N15InsideПереключательПУЛ480_1 = value;
                }
            }
        }

        /// <summary>
        /// Названия положений переключателя ПУЛ480_1
        /// </summary>
        private static string[] N15InsideПоложенияПереключательПУЛ480_1 = {
            "1.2",
            "2.4",
            "4.8",
            "5.2",
            "48",
            "96",
            "144",
            "240",
            "480"
        };
        #endregion

        #region Переключатель ПУЛ480_2
        /// <summary>
        /// Положение переключателя ПУЛ480_2
        /// </summary>
        private static int _N15InsideПереключательПУЛ480_2 = 1;

        public static int N15InsideПереключательПУЛ480_2
        {
            get
            {
                return _N15InsideПереключательПУЛ480_2;
            }

            set
            {
                if (value > 0 && value < 10)
                {
                    _N15InsideПереключательПУЛ480_2 = value;
                }
            }
        }

        /// <summary>
        /// Названия положений переключателя ПУЛ480_2
        /// </summary>
        private static string[] N15InsideПоложенияПереключательПУЛ480_2 = {
            "1.2",
            "2.4",
            "4.8",
            "5.2",
            "48",
            "96",
            "144",
            "240",
            "480"
        };
        #endregion

        #region Переключатель ПУЛ48ПРД_1
        /// <summary>
        /// Положение переключателя ПУЛ48ПРД_1
        /// </summary>
        private static int _N15InsideПереключательПУЛ48ПРД_1 = 1;

        public static int N15InsideПереключательПУЛ48ПРД_1
        {
            get
            {
                return _N15InsideПереключательПУЛ48ПРД_1;
            }

            set
            {
                if (value > 0 && value < 6)
                {
                    _N15InsideПереключательПУЛ48ПРД_1 = value;
                }
            }
        }

        /// <summary>
        /// Названия положений переключателя ПУЛ48ПРД_1
        /// </summary>
        private static string[] N15InsideПоложенияПереключательПУЛ48ПРД_1 = {
            "1.2",
            "2.4",
            "4.8",
            "5.2",
            "48"
        };


        #endregion

        #region Переключатель ПУЛ48ПРД_2
        /// <summary>
        /// Положение переключателя ПУЛ480_2
        /// </summary>
        private static int _N15InsideПереключательПУЛ48ПРД_2 = 1;

        public static int N15InsideПереключательПУЛ48ПРД_2
        {
            get
            {
                return _N15InsideПереключательПУЛ48ПРД_2;
            }

            set
            {
                if (value > 0 && value < 6)
                {
                    _N15InsideПереключательПУЛ48ПРД_2 = value;
                }
            }
        }

        /// <summary>
        /// Названия положений переключателя ПУЛ48ПРД_2
        /// </summary>
        private static string[] N15InsideПоложенияПереключательПУЛ48ПРД_2 = {
            "1.2",
            "2.4",
            "4.8",
            "5.2",
            "48"
        };
        #endregion
    }
}
