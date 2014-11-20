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
        public static string N18_MПереключательВходБ22 { get; set; }
        public static string N18_MПереключательВыход1РН { get; set; }
        public static string N18_MПереключательВыход2РН { get; set; }
        public static string N18_MПереключатель48ПРМЩВ { get; set; }
        public static string N18_MПереключательПРМСС1 { get; set; }
        public static string N18_MПереключательПРМСС2 { get; set; }
        public static string N18_MПереключательВходК1_2_1 { get; set; }
        public static string N18_MПереключательПРД { get; set; }
        public static string N18_MПереключательПРДБМА12 { get; set; }

        #region ПереключательПРМ1
        /// <summary>
        /// Положение переключателя ПРМ1
        /// </summary>
        private static int _N18_MПереключательПРМ1 = 1;

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
        private static int _N18_MПереключательПРМ2 = 1;

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
