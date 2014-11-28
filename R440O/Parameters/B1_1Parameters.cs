using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R440O.Parameters
{
    class B1_1Parameters
    {
        #region Лампочки
        public static string B1_1ЛампочкаБОЧ { get; set; }
        public static string B1_1ЛампочкаПУЛ_1 { get; set; }
        public static string B1_1ЛампочкаПУЛ_2 { get; set; }
        public static string B1_1ЛампочкаПРСС { get; set; }
        public static string B1_1ЛампочкаТКБтк1_1 { get; set; }
        public static string B1_1ЛампочкаТКБтк1_2 { get; set; }
        public static string B1_1ЛампочкаТКБтк2_1 { get; set; }
        public static string B1_1ЛампочкаТКБтк2_2 { get; set; }
        public static string B1_1ЛампочкаТКБтк3_1 { get; set; }
        public static string B1_1ЛампочкаТКБтк3_2 { get; set; }
        public static string B1_1ЛампочкаТКБАвар { get; set; }
        public static string B1_1ЛампочкаДФАПЧ1 { get; set; }
        public static string B1_1ЛампочкаДФАПЧ2 { get; set; }
        public static string B1_1ЛампочкаДФАПЧ3 { get; set; }
        public static string B1_1ЛампочкаТЛГпр1 { get; set; }
        public static string B1_1ЛампочкаТЛГпр2 { get; set; }
        public static string B1_1ЛампочкаТКСПР1 { get; set; }
        public static string B1_1ЛампочкаВУП_1 { get; set; }
        public static string B1_1ЛампочкаВУПНеиспр { get; set; }
        #endregion

        //Тумблер
        /// <summary>
        /// Возможные состояния: Му - местное управление, Ду - дистанционное управление
        /// </summary>
        public static string B1_1ТумблерМуДу { get; set; }


        //Кнопки
        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static string B1_1КнопкаСкоростьГР { get; set; }

        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static string B1_1КнопкаСкоростьАБ_1ТЛФ_К { get; set; }
    }
}
