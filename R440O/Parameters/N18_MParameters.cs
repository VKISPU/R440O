using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R440O.Parameters
{
    class N18_MParameters
    {
        #region Лампочки
        //Лампочки
        public static string N18_MЛампочкаСПСТест { get; set; }
        public static string N18_MЛампочкаСПСИнформ { get; set; }
        public static string N18_MЛампочкаПилотК1_1 { get; set; }
        public static string N18_MЛампочкаПилотК1_2 { get; set; }
        public static string N18_MЛампочкаИнформК1_1 { get; set; }
        public static string N18_MЛампочкаИнформК1_2 { get; set; }
        #endregion

        #region Переключатели
        //Переключатели

        #region N18_MПереключательВходБ22
        /// <summary>
        /// Положение переключателя Выход1РН
        /// </summary>
        private static int _N18_MПереключательВходБ22 = 1;

        public static int N18_MПереключательВходБ22
        {
            get { return _N18_MПереключательВходБ22; }
            set
            {
                if (value > 0 && value < 3) _N18_MПереключательВходБ22 = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя Выход1РН
        /// </summary>
        private static string[] N18_MПоложенияПереключательВходБ22 = {
            "б1-1",
            "даб-5"
        };
        #endregion

        #region N18_MПереключательВыход1РН
        /// <summary>
        /// Положение переключателя Выход1РН
        /// </summary>
        private static int _N18_MПереключательВыход1РН = 1;

        public static int N18_MПереключательВыход1РН
        {
            get { return _N18_MПереключательВыход1РН; }
            set
            {
                if (value > 0 && value < 3) _N18_MПереключательВыход1РН = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя Выход1РН
        /// </summary>
        private static string[] N18_MПоложенияПереключательВыход1РН = {
            "б1-1",
            "даб-5"
        };
        #endregion

        #region N18_MПереключательВыход2РН
        /// <summary>
        /// Положение переключателя Выход2РН
        /// </summary>
        private static int _N18_MПереключательВыход2РН = 1;

        public static int N18_MПереключательВыход2РН
        {
            get { return _N18_MПереключательВыход2РН; }
            set
            {
                if (value > 0 && value < 3) _N18_MПереключательВыход2РН = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя Выход2РН
        /// </summary>
        private static string[] N18_MПоложенияПереключательВыход2РН = {
            "б1-2",
            "даб-5"
        };
        #endregion

        #region N18_MПереключатель48ПРМЩВ
        /// <summary>
        /// Положение переключателя 48ПРМЩВ
        /// </summary>
        private static int _N18_MПереключатель48ПРМЩВ = 1;

        public static int N18_MПереключатель48ПРМЩВ
        {
            get { return _N18_MПереключатель48ПРМЩВ; }
            set
            {
                if (value > 0 && value < 3) _N18_MПереключатель48ПРМЩВ = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя 48ПРМЩВ
        /// </summary>
        private static string[] N18_MПоложенияПереключатель48ПРМЩВ = {
            "б2",
            "даб-5"
        };
        #endregion

        #region N18_MПереключательПРМСС2
        /// <summary>
        /// Положение переключателя ПРМСС2
        /// </summary>
        private static int _N18_MПереключательПРМСС2 = 3;

        public static int N18_MПереключательПРМСС2
        {
            get { return _N18_MПереключательПРМСС2; }
            set
            {
                if (value > 0 && value < 6) _N18_MПереключательПРМСС2 = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя ПРМСС2
        /// </summary>
        private static string[] N18_MПоложенияПереключательПРМСС2 = {
            "прм-2",
            "б3-2",
            "б2-2",
            "б1-2",
            "даб-5"
        };
        #endregion

        #region N18_MПереключательПРМСС1
        /// <summary>
        /// Положение переключателя ПРМСС1
        /// </summary>
        private static int _N18_MПереключательПРМСС1 = 3;

        public static int N18_MПереключательПРМСС1
        {
            get { return _N18_MПереключательПРМСС1; }
            set
            {
                if (value > 0 && value < 6) _N18_MПереключательПРМСС1 = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя ПРМСС1
        /// </summary>
        private static string[] N18_MПоложенияПереключательПРМСС1 = {
            "прм-1",
            "б3-1",
            "б2-1",
            "б1-1",
            "даб-5"
        };
        #endregion

        #region N18_MПереключательПРДБМА12
        /// <summary>
        /// Положение переключателя ПРДБМА12
        /// </summary>
        private static int _N18_MПереключательПРДБМА12 = 6;

        public static int N18_MПереключательПРДБМА12
        {
            get { return _N18_MПереключательПРДБМА12; }
            set
            {
                if (value > 0 && value < 10) _N18_MПереключательПРДБМА12 = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя ПРДБМА12
        /// </summary>
        private static string[] N18_MПоложенияПереключательПРДБМА12 = {
            "тлф-1/2",
            "тлф-2/3",
            "тлф-3/1",
            "тлф-1/3",
            "тлф-2/1",
            "тлф-3/2",
            "мод1",
            "мод2",
            "к1_2_1"
        };
        #endregion

        #region N18_MПереключательПРД
        /// <summary>
        /// Положение переключателя ПРД
        /// </summary>
        private static int _N18_MПереключательПРД = 3;

        public static int N18_MПереключательПРД
        {
            get { return _N18_MПереключательПРД; }
            set
            {
                if (value > 0 && value < 6) _N18_MПереключательПРД = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя ВходК1-2-1
        /// </summary>
        private static string[] N18_MПоложенияПереключательПРД = {
            "даб-5",
            "а1",
            "бма",
            "тлг",
            "сс"
        };
        #endregion

        #region N18_MПереключательВходК1_2_1
        /// <summary>
        /// Положение переключателя ВходК1-2-1
        /// </summary>
        private static int _N18_MПереключательВходК1_2_1 = 3;

        public static int N18_MПереключательВходК1_2_1
        {
            get { return _N18_MПереключательВходК1_2_1; }
            set
            {
                if (value > 0 && value < 5) _N18_MПереключательВходК1_2_1 = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя ВходК1-2-1
        /// </summary>
        private static string[] N18_MПоложенияПереключательВходК1_2_1 = {
            "откл",
            "бма-1",
            "бма-2",
            "щв"
        };
        #endregion

        #region ПереключательПРМ1
        /// <summary>
        /// Положение переключателя ПРМ1
        /// </summary>
        private static int _N18_MПереключательПРМ1 = 3;

        public static int N18_MПереключательПРМ1
        {
            get { return _N18_MПереключательПРМ1; }
            set
            {
                if (value > 0 && value < 6) _N18_MПереключательПРМ1 = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя ПРМ1
        /// </summary>
        private static string[] N18_MПоложенияПереключательПРМ1 = {
            "б3-1",
            "б2-1",
            "даб-5",
            "б1-1",
            "р-н"
        };
        #endregion

        #region ПереключательПРМ2
        /// <summary>
        /// Положение переключателя ПРМ2
        /// </summary>
        private static int _N18_MПереключательПРМ2 = 3;

        public static int N18_MПереключательПРМ2
        {
            get { return _N18_MПереключательПРМ2; }
            set
            {
                if (value > 0 && value < 6) _N18_MПереключательПРМ2 = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя ПРМ1
        /// </summary>
        private static string[] N18_MПоложенияПереключательПРМ2 = {
            "б3-2",
            "б2-2",
            "даб-5",
            "б1-2",
            "р-н"
        };
        #endregion
        #endregion

        #region Тумблеры
        //Тумблер
        public static string N18_MТумблерДАБ5 = "прм-1";
        public static string N18_MТумблерКАУ_ПРМ = "б1-1";
        public static string N18_MТумблерПРД_СС = "контур-П";
        public static string N18_MТумблерТЛФ_ПРМ = "осн";
        #endregion

    }
}
