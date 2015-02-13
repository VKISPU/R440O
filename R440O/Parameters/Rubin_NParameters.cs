using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R440O.Parameters
{
    class Rubin_NParameters
    {
        #region Переключатели
        #region Rubin_NПереключательГрупСкор
        /// <summary>
        /// Положение переключателя Rubin_NПереключательГрупСкор
        /// </summary>
        private static int _Rubin_NПереключательГрупСкор = 1;

        public static int Rubin_NПереключательГрупСкор
        {
            get { return _Rubin_NПереключательГрупСкор; }
            set
            {
                if (value > 0 && value < 5) _Rubin_NПереключательГрупСкор = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя Rubin_NПереключательГрупСкор
        /// </summary>
        private static string[] Rubin_NПоложенияПереключательГрупСкор = {
            "96",
            "144",
            "240",
            "480"
        };
        #endregion

        #region Rubin_NПереключательКонтроль
        /// <summary>
        /// Положение переключателя Rubin_NПереключательКонтроль
        /// </summary>
        private static int _Rubin_NПереключательКонтроль = 1;

        public static int Rubin_NПереключательКонтроль
        {
            get { return _Rubin_NПереключательКонтроль; }
            set
            {
                if (value > 0 && value < 5) _Rubin_NПереключательКонтроль = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя Rubin_NПереключательКонтроль
        /// </summary>
        private static string[] Rubin_NПоложенияПереключательКонтроль = {
            "откл",
            "1",
            "2",
            "3"
        };
        #endregion

        #region Rubin_NПереключательN5063_2кБод
        /// <summary>
        /// Положение переключателя Rubin_NПереключательN5063_2кБод
        /// </summary>
        private static int _Rubin_NПереключательN5063_2кБод = 1;

        public static int Rubin_NПереключательN5063_2кБод
        {
            get { return _Rubin_NПереключательN5063_2кБод; }
            set
            {
                if (value > 0 && value < 5) _Rubin_NПереключательN5063_2кБод = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя Rubin_NПереключательN5063_2кБод
        /// </summary>
        private static string[] Rubin_NПоложенияПереключательN5063_2кБод = {
            "0",
            "1",
            "2",
            "3"
        };
        #endregion

        #region Rubin_NПереключательN5063_6812кБод
        /// <summary>
        /// Положение переключателя Rubin_NПереключательN5063_6812кБод
        /// </summary>
        private static int _Rubin_NПереключательN5063_6812кБод = 1;

        public static int Rubin_NПереключательN5063_6812кБод
        {
            get { return _Rubin_NПереключательN5063_6812кБод; }
            set
            {
                if (value > 0 && value < 19) _Rubin_NПереключательN5063_6812кБод = value;
            }
        }


        #endregion

        #region Rubin_NПереключательN5063_48кБод
        /// <summary>
        /// Положение переключателя Rubin_NПереключательN5063_48кБод
        /// </summary>
        private static int _Rubin_NПереключательN5063_48кБод = 1;

        public static int Rubin_NПереключательN5063_48кБод
        {
            get { return _Rubin_NПереключательN5063_48кБод; }
            set
            {
                if (value > 0 && value < 11) _Rubin_NПереключательN5063_48кБод = value;
            }
        }
        #endregion

        #region Rubin_NПереключательN4923_2кБод
        /// <summary>
        /// Положение переключателя Rubin_NПереключательN4923_2кБод
        /// </summary>
        private static int _Rubin_NПереключательN4923_2кБод = 1;

        public static int Rubin_NПереключательN4923_2кБод
        {
            get { return _Rubin_NПереключательN4923_2кБод; }
            set
            {
                if (value > 0 && value < 5) _Rubin_NПереключательN4923_2кБод = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя Rubin_NПереключательN4923_2кБод
        /// </summary>
        private static string[] Rubin_NПоложенияПереключательN4923_2кБод = {
            "0",
            "1",
            "2",
            "3"
        };
        #endregion

        #region Rubin_NПереключательN4923_6812кБод
        /// <summary>
        /// Положение переключателя Rubin_NПереключательN4923_6812кБод
        /// </summary>
        private static int _Rubin_NПереключательN4923_6812кБод = 1;

        public static int Rubin_NПереключательN4923_6812кБод
        {
            get { return _Rubin_NПереключательN4923_6812кБод; }
            set
            {
                if (value > 0 && value < 19) _Rubin_NПереключательN4923_6812кБод = value;
            }
        }


        #endregion

        #region Rubin_NПереключательN4923_48кБод
        /// <summary>
        /// Положение переключателя Rubin_NПереключательN4923_48кБод
        /// </summary>
        private static int _Rubin_NПереключательN4923_48кБод = 1;

        public static int Rubin_NПереключательN4923_48кБод
        {
            get { return _Rubin_NПереключательN4923_48кБод; }
            set
            {
                if (value > 0 && value < 11) _Rubin_NПереключательN4923_48кБод = value;
            }
        }
        #endregion

        #region Rubin_NПереключательN4963_2кБод
        /// <summary>
        /// Положение переключателя Rubin_NПереключательN4963_2кБод
        /// </summary>
        private static int _Rubin_NПереключательN4963_2кБод = 1;

        public static int Rubin_NПереключательN4963_2кБод
        {
            get { return _Rubin_NПереключательN4963_2кБод; }
            set
            {
                if (value > 0 && value < 5) _Rubin_NПереключательN4963_2кБод = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя Rubin_NПереключательN4963_2кБод
        /// </summary>
        private static string[] Rubin_NПоложенияПереключательN4963_2кБод = {
            "0",
            "1",
            "2",
            "3"
        };
        #endregion

        #region Rubin_NПереключательN4963_6812кБод
        /// <summary>
        /// Положение переключателя Rubin_NПереключательN4963_6812кБод
        /// </summary>
        private static int _Rubin_NПереключательN4963_6812кБод = 1;

        public static int Rubin_NПереключательN4963_6812кБод
        {
            get { return _Rubin_NПереключательN4963_6812кБод; }
            set
            {
                if (value > 0 && value < 19) _Rubin_NПереключательN4963_6812кБод = value;
            }
        }


        #endregion

        #region Rubin_NПереключательN4963_48кБод
        /// <summary>
        /// Положение переключателя Rubin_NПереключательN4963_48кБод
        /// </summary>
        private static int _Rubin_NПереключательN4963_48кБод = 1;

        public static int Rubin_NПереключательN4963_48кБод
        {
            get { return _Rubin_NПереключательN4963_48кБод; }
            set
            {
                if (value > 0 && value < 11) _Rubin_NПереключательN4963_48кБод = value;
            }
        }
        #endregion
        #endregion

        #region Тумблеры
        /// <summary>
        /// Возможные состояния: +, -
        /// </summary>
        public static string Rubin_NТумблерПолярность { get { return _Rubin_NТумблерПолярность; } set { _Rubin_NТумблерПолярность = value; } }
        private static string _Rubin_NТумблерПолярность = "+";

        /// <summary>
        /// Возможные состояния: 4.8, 5.2
        /// </summary>
        public static string Rubin_NТумблерБлок5063 { get { return _Rubin_NТумблерБлок5063; } set { _Rubin_NТумблерБлок5063 = value; } }
        private static string _Rubin_NТумблерБлок5063 = "4.8";

        /// <summary>
        /// Возможные состояния: 4.8, 5.2
        /// </summary>
        public static string Rubin_NТумблерБлок4923 { get { return _Rubin_NТумблерБлок4923; } set { _Rubin_NТумблерБлок4923 = value; } }
        private static string _Rubin_NТумблерБлок4923 = "4.8";

        /// <summary>
        /// Возможные состояния: 4.8, 5.2
        /// </summary>
        public static string Rubin_NТумблерБлок4963 { get { return _Rubin_NТумблерБлок4963; } set { _Rubin_NТумблерБлок4963 = value; } }
        private static string _Rubin_NТумблерБлок4963 = "4.8";
        #endregion

        public static bool Rubin_NКнопкаОткл = false;
        public static bool Rubin_NКнопкаВкл = false;

    }
}
