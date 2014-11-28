using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R440O.Parameters
{
    class A403_1Parameters
    {
        #region Лампочки
        //Лампочки
        public static string A403_1ЛампочкаНеисправностьАПН { get; set; }
        public static string A403_1ЛампочкаНеисправностьФС { get; set; }
        public static string A403_1ЛампочкаНеисправностьРИ { get; set; }
        public static string A403_1ЛампочкаКомплект1 { get; set; }
        public static string A403_1ЛампочкаКомплект2 { get; set; }
        #endregion

        #region Тумблеры
        //Тумблеры
        public static string A403_1ТумблерСеть = "откл";
        public static string A403_1ТумблерГотов = "откл";
        public static string A403_1ТумблерГруппа = "2группа";
        public static string A403_1ТумблерКомплект = "1";
        public static string A403_1ТумблерАвтКоррекция = "откл";
        #endregion

        #region Переключатели
        //Переключатели

        #region Переключатель проверка
        /// <summary>
        /// Положение переключателя режима работы
        /// </summary>
        private static int _A403_1ПереключательПроверка = 1;

        public static int A403_1ПереключательПроверка
        {
            get { return _A403_1ПереключательПроверка; }
            set
            {
                if (value > 0 && value < 10) _A403_1ПереключательПроверка = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя режима работы
        /// </summary>
        private static string[] A403_1ПоложенияПереключательПроверка = {
            "0",
            "t",
            "альфар",
            "бетар",
            "дельтаF",
            "альфаФи",
            "бетаФи",
            "Д",
            "Ш",
            "К"
        };
        #endregion

        #region ПереключательРежимРаботы
        /// <summary>
        /// Положение переключателя режима работы
        /// </summary>
        private static int _A403_1ПереключательРежимРаботы = 1;

        public static int A403_1ПереключательРежимРаботы
        {
            get { return _A403_1ПереключательРежимРаботы; }
            set
            {
                if (value > 0 && value < 9) _A403_1ПереключательРежимРаботы = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя режима работы
        /// </summary>
        private static string[] A403_1ПоложенияПереключательРежимРаботы = {
            "0",
            "раб1",
            "раб2",
            "прогн",
            "рн",
            "пу",
            "увв",
            "бпр"
        };
        #endregion

        #endregion

        #region Кнопки
        //Кнопки
        public static string A403_1КнопкаУстВремени { get; set; }
        public static string A403_1Кнопка0 { get; set; }
        public static string A403_1Кнопка1 { get; set; }
        public static string A403_1Кнопка2 { get; set; }
        public static string A403_1Кнопка3 { get; set; }
        public static string A403_1Кнопка4 { get; set; }
        public static string A403_1Кнопка5 { get; set; }
        public static string A403_1Кнопка6 { get; set; }
        public static string A403_1Кнопка7 { get; set; }
        public static string A403_1Кнопка8 { get; set; }
        public static string A403_1Кнопка9 { get; set; }
        public static string A403_1КнопкаМинус { get; set; }
        public static string A403_1КнопкаСброс { get; set; }

        public static string A403_1КнопкаАlpha_Lambda { get; set; }
        public static string A403_1КнопкаEpsilon_Phi { get; set; }
        public static string A403_1КнопкаI_H { get; set; }
        public static string A403_1КнопкаOmega_N { get; set; }
        public static string A403_1КнопкаLambda0_f { get; set; }
        public static string A403_1Кнопкаt0_K { get; set; }
        public static string A403_1КнопкаT_Kbeta { get; set; }
        public static string A403_1Кнопкаtсв_Yalpha { get; set; }
        public static string A403_1Кнопкаtуст_Ybeta { get; set; }
        #endregion

        #region Табло
        public static string A403_1ТаблоПоле0 { get; set; }
        public static string A403_1ТаблоПолe1 { get; set; }
        public static string A403_1ТаблоПоле2 { get; set; }
        public static string A403_1ТаблоПоле3 { get; set; }
        public static string A403_1ТаблоПоле4 { get; set; }
        public static string A403_1ТаблоПоле5 { get; set; }
        public static string A403_1ТаблоПоле6 { get; set; }

        #endregion
    }
}
