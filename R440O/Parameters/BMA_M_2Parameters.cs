using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R440O.Parameters
{
    class BMA_M_2Parameters
    {
        #region Переключатели
        #region ПереключательКонтроль
        /// <summary>
        /// Положение переключателя напряжения
        /// </summary>
        private static int _BMA_M_2ПереключательКонтроль = 1;

        public static int BMA_M_2ПереключательКонтроль
        {
            get { return _BMA_M_2ПереключательКонтроль; }
            set
            {
                if (value > 0 && value < 7) _BMA_M_2ПереключательКонтроль = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя напряжения
        /// </summary>
        private static string[] BMA_M_2ПоложенияПереключательКонтроль = {
            "работа1",
            "ТЕСТ",
            "ДК",
            "ТЧ",
            "КОМПЛ",
            "работа2"
        };
        #endregion

        #region ПереключательРекурента
        /// <summary>
        /// Положение переключателя напряжения
        /// </summary>
        private static int _BMA_M_2ПереключательРекурента = 1;

        public static int BMA_M_2ПереключательРекурента
        {
            get { return _BMA_M_2ПереключательРекурента; }
            set
            {
                if (value > 0 && value < 5) _BMA_M_2ПереключательРекурента = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя напряжения
        /// </summary>
        private static string[] BMA_M_2ПоложенияПереключательРекурента = {
            "15",
            "31",
            "511",
            "1023"
        };
        #endregion

        #region ПереключательРежимРаботы
        /// <summary>
        /// Положение переключателя напряжения
        /// </summary>
        private static int _BMA_M_2ПереключательРежимРаботы = 1;

        public static int BMA_M_2ПереключательРежимРаботы
        {
            get { return _BMA_M_2ПереключательРежимРаботы; }
            set
            {
                if (value > 0 && value < 5) _BMA_M_2ПереключательРежимРаботы = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя напряжения
        /// </summary>
        private static string[] BMA_M_2ПоложенияПереключательРежимРаботы = {
            "МУавт",
            "МУручн",
            "ДОручн",
            "ДОавт"
        };
        #endregion

        #region ПереключательКоррАЧХ
        /// <summary>
        /// Положение переключателя напряжения
        /// </summary>
        private static int _BMA_M_2ПереключательКоррАЧХ = 1;

        public static int BMA_M_2ПереключательКоррАЧХ
        {
            get { return _BMA_M_2ПереключательКоррАЧХ; }
            set
            {
                if (value > 0 && value < 7) _BMA_M_2ПереключательКоррАЧХ = value;
            }
        }
        #endregion

        #region ПереключательЧастотаВызова
        /// <summary>
        /// Положение переключателя напряжения
        /// </summary>
        private static int _BMA_M_2ПереключательЧастотаВызова = 1;

        public static int BMA_M_2ПереключательЧастотаВызова
        {
            get { return _BMA_M_2ПереключательЧастотаВызова; }
            set
            {
                if (value > 0 && value < 5) _BMA_M_2ПереключательЧастотаВызова = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя напряжения
        /// </summary>
        private static string[] BMA_M_2ПоложенияПереключательЧастотаВызова = {
            "2,1",
            "1,8",
            "2,6",
            "3,2"
        };
        #endregion

        #region ПереключательУровниСигналаПрдПрм
        /// <summary>
        /// Положение переключателя напряжения
        /// </summary>
        private static int _BMA_M_2ПереключательУровниСигналаПрдПрм = 1;

        public static int BMA_M_2ПереключательУровниСигналаПрдПрм
        {
            get { return _BMA_M_2ПереключательУровниСигналаПрдПрм; }
            set
            {
                if (value > 0 && value < 5) _BMA_M_2ПереключательУровниСигналаПрдПрм = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя напряжения
        /// </summary>
        private static string[] BMA_M_2ПоложенияПереключательУровниСигналаПрдПрм = {
            "-13/-13",
            "-23/-5,7",
            "-10,5/-28",
            "-28/-10,5"
        };
        #endregion

        #region ПереключательРежимы
        /// <summary>
        /// Положение переключателя напряжения
        /// </summary>
        private static int _BMA_M_2ПереключательРежимы = 1;

        public static int BMA_M_2ПереключательРежимы
        {
            get { return _BMA_M_2ПереключательРежимы; }
            set
            {
                if (value > 0 && value < 5) _BMA_M_2ПереключательРежимы = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя напряжения
        /// </summary>
        private static string[] BMA_M_2ПоложенияПереключательРежимы = {
            "ДОФТ",
            "ОФТ",
            "2x1200",
            "ЧТ"
        };
        #endregion

        #region ПереключательЗапретЗапроса
        /// <summary>
        /// Положение переключателя напряжения
        /// </summary>
        private static int _BMA_M_2ПереключательЗапретЗапроса = 1;

        public static int BMA_M_2ПереключательЗапретЗапроса
        {
            get { return _BMA_M_2ПереключательЗапретЗапроса; }
            set
            {
                if (value > 0 && value < 3) _BMA_M_2ПереключательЗапретЗапроса = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя напряжения
        /// </summary>
        private static string[] BMA_M_2ПоложенияПереключательЗапретЗапроса = {
            "Вкл",
            "Выкл"
        };
        #endregion

        #region ПереключательКоррКанала
        /// <summary>
        /// Положение переключателя напряжения
        /// </summary>
        private static int _BMA_M_2ПереключательКоррКанала = 1;

        public static int BMA_M_2ПереключательКоррКанала
        {
            get { return _BMA_M_2ПереключательКоррКанала; }
            set
            {
                if (value > 0 && value < 3) _BMA_M_2ПереключательКоррКанала = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя напряжения
        /// </summary>
        private static string[] BMA_M_2ПоложенияПереключательКоррКанала = {
            "Вкл",
            "Выкл"
        };
        #endregion
        #endregion

        #region Кнопки
        public static bool BMA_M_2КнопкаШлейфТЧ = false;
        public static bool BMA_M_2КнопкаШлейфДК = false;
        public static bool BMA_M_2КнопкаПитаниеВКЛ = false;
        public static bool BMA_M_2КнопкаПитаниеВЫКЛ = false;
        #endregion

        #region Лампочки
        public static string BMA_M_2ЛампочкаТЧБ { get; set; }
        public static string BMA_M_2ЛампочкаФЗ { get; set; }
        public static string BMA_M_2ЛампочкаДК { get; set; }
        public static string BMA_M_2ЛампочкаСинхрТЧ { get; set; }
        public static string BMA_M_2ЛампочкаСинхрДК { get; set; }
        public static string BMA_M_2ЛампочкаПрдТЧ { get; set; }
        public static string BMA_M_2ЛампочкаПрдДК { get; set; }
        public static string BMA_M_2ЛампочкаПрмТЧ { get; set; }
        public static string BMA_M_2ЛампочкаПрмФР { get; set; }
        public static string BMA_M_2ЛампочкаПрмДК1 { get; set; }
        public static string BMA_M_2ЛампочкаПрмДК2 { get; set; }

        public static string BMA_M_2ЛампочкаПитание_5В { get; set; }
        public static string BMA_M_2ЛампочкаПитание_10В { get; set; }
        public static string BMA_M_2ЛампочкаПитание_12В { get; set; }
        public static string BMA_M_2ЛампочкаПитание_15В { get; set; }
        public static string BMA_M_2ЛампочкаПитание_15Вplus { get; set; }

        public static string BMA_M_2ЛампочкаКонтрольНенорм { get; set; }
        public static string BMA_M_2ЛампочкаКонтрольНорм { get; set; }
        public static string BMA_M_2ЛампочкаКонтрольТест { get; set; }
        public static string BMA_M_2ЛампочкаКонтрольДК { get; set; }
        public static string BMA_M_2ЛампочкаКонтрольТЧ { get; set; }
        public static string BMA_M_2ЛампочкаКонтрольКомпл { get; set; }

        public static string BMA_M_2ЛампочкаРекурента15 { get; set; }
        public static string BMA_M_2ЛампочкаРекурента31 { get; set; }
        public static string BMA_M_2ЛампочкаРекурента511 { get; set; }
        public static string BMA_M_2ЛампочкаРекурента1023 { get; set; }

        public static string BMA_M_2ЛампочкаАвтомКоманда1 { get; set; }
        public static string BMA_M_2ЛампочкаАвтомКоманда2 { get; set; }


        #endregion
    }
}
