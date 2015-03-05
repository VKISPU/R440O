using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R440O.Parameters
{
    class BMA_M_1Parameters
    {
        #region Переключатели
        #region ПереключательКонтроль
        /// <summary>
        /// Положение переключателя напряжения
        /// </summary>
        private static int _BMA_M_1ПереключательКонтроль = 1;

        public static int BMA_M_1ПереключательКонтроль
        {
            get { return _BMA_M_1ПереключательКонтроль; }
            set
            {
                if (value > 0 && value < 7) _BMA_M_1ПереключательКонтроль = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя напряжения
        /// </summary>
        private static string[] BMA_M_1ПоложенияПереключательКонтроль = {
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
        private static int _BMA_M_1ПереключательРекурента = 1;

        public static int BMA_M_1ПереключательРекурента
        {
            get { return _BMA_M_1ПереключательРекурента; }
            set
            {
                if (value > 0 && value < 5) _BMA_M_1ПереключательРекурента = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя напряжения
        /// </summary>
        private static string[] BMA_M_1ПоложенияПереключательРекурента = {
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
        private static int _BMA_M_1ПереключательРежимРаботы = 1;

        public static int BMA_M_1ПереключательРежимРаботы
        {
            get { return _BMA_M_1ПереключательРежимРаботы; }
            set
            {
                if (value > 0 && value < 5) _BMA_M_1ПереключательРежимРаботы = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя напряжения
        /// </summary>
        private static string[] BMA_M_1ПоложенияПереключательРежимРаботы = {
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
        private static int _BMA_M_1ПереключательКоррАЧХ = 1;

        public static int BMA_M_1ПереключательКоррАЧХ
        {
            get { return _BMA_M_1ПереключательКоррАЧХ; }
            set
            {
                if (value > 0 && value < 7) _BMA_M_1ПереключательКоррАЧХ = value;
            }
        }
        #endregion

        #region ПереключательЧастотаВызова
        /// <summary>
        /// Положение переключателя напряжения
        /// </summary>
        private static int _BMA_M_1ПереключательЧастотаВызова = 1;

        public static int BMA_M_1ПереключательЧастотаВызова
        {
            get { return _BMA_M_1ПереключательЧастотаВызова; }
            set
            {
                if (value > 0 && value < 5) _BMA_M_1ПереключательЧастотаВызова = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя напряжения
        /// </summary>
        private static string[] BMA_M_1ПоложенияПереключательЧастотаВызова = {
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
        private static int _BMA_M_1ПереключательУровниСигналаПрдПрм = 1;

        public static int BMA_M_1ПереключательУровниСигналаПрдПрм
        {
            get { return _BMA_M_1ПереключательУровниСигналаПрдПрм; }
            set
            {
                if (value > 0 && value < 5) _BMA_M_1ПереключательУровниСигналаПрдПрм = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя напряжения
        /// </summary>
        private static string[] BMA_M_1ПоложенияПереключательУровниСигналаПрдПрм = {
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
        private static int _BMA_M_1ПереключательРежимы = 1;

        public static int BMA_M_1ПереключательРежимы
        {
            get { return _BMA_M_1ПереключательРежимы; }
            set
            {
                if (value > 0 && value < 5) _BMA_M_1ПереключательРежимы = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя напряжения
        /// </summary>
        private static string[] BMA_M_1ПоложенияПереключательРежимы = {
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
        private static int _BMA_M_1ПереключательЗапретЗапроса = 1;

        public static int BMA_M_1ПереключательЗапретЗапроса
        {
            get { return _BMA_M_1ПереключательЗапретЗапроса; }
            set
            {
                if (value > 0 && value < 3) _BMA_M_1ПереключательЗапретЗапроса = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя напряжения
        /// </summary>
        private static string[] BMA_M_1ПоложенияПереключательЗапретЗапроса = {
            "Вкл",
            "Выкл"
        };
        #endregion

        #region ПереключательКоррКанала
        /// <summary>
        /// Положение переключателя напряжения
        /// </summary>
        private static int _BMA_M_1ПереключательКоррКанала = 1;

        public static int BMA_M_1ПереключательКоррКанала
        {
            get { return _BMA_M_1ПереключательКоррКанала; }
            set
            {
                if (value > 0 && value < 3) _BMA_M_1ПереключательКоррКанала = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя напряжения
        /// </summary>
        private static string[] BMA_M_1ПоложенияПереключательКоррКанала = {
            "Вкл",
            "Выкл"
        };
        #endregion
        #endregion

        #region Кнопки
        public static bool BMA_M_1КнопкаШлейфТЧ = false;
        public static bool BMA_M_1КнопкаШлейфДК = false;
        public static bool BMA_M_1КнопкаПитаниеВКЛ = false;
        public static bool BMA_M_1КнопкаПитаниеВЫКЛ = true;
        #endregion

        #region Лампочки
        public static bool BMA_M_1ЛампочкаТЧБ = false;
        public static bool BMA_M_1ЛампочкаФЗ = false;
        public static bool BMA_M_1ЛампочкаДК = false;
        public static bool BMA_M_1ЛампочкаСинхрТЧ = false;
        public static bool BMA_M_1ЛампочкаСинхрДК = false;
        public static bool BMA_M_1ЛампочкаПрдТЧ = false;
        public static bool BMA_M_1ЛампочкаПрдДК = false;
        public static bool BMA_M_1ЛампочкаПрмТЧ = false;
        public static bool BMA_M_1ЛампочкаПрмФР = false;
        public static bool BMA_M_1ЛампочкаПрмДК1 = false;
        public static bool BMA_M_1ЛампочкаПрмДК2 = false;

        public static bool BMA_M_1ЛампочкаПитание_5В = false;
        public static bool BMA_M_1ЛампочкаПитание_10В = false;
        public static bool BMA_M_1ЛампочкаПитание_12В = false;
        public static bool BMA_M_1ЛампочкаПитание_15В = false;
        public static bool BMA_M_1ЛампочкаПитание_15Вplus = false;

        public static bool BMA_M_1ЛампочкаКонтрольНенорм = false;
        public static bool BMA_M_1ЛампочкаКонтрольНорм = false;
        public static bool BMA_M_1ЛампочкаКонтрольТест = false;
        public static bool BMA_M_1ЛампочкаКонтрольДК = false;
        public static bool BMA_M_1ЛампочкаКонтрольТЧ = false;
        public static bool BMA_M_1ЛампочкаКонтрольКомпл = false;

        public static bool BMA_M_1ЛампочкаРекурента15 = false;
        public static bool BMA_M_1ЛампочкаРекурента31 = false;
        public static bool BMA_M_1ЛампочкаРекурента511 = false; 
        public static bool BMA_M_1ЛампочкаРекурента1023 = false;

        public static bool BMA_M_1ЛампочкаАвтомКоманда1 = false;
        public static bool BMA_M_1ЛампочкаАвтомКоманда2 = false;

        public static bool BMA_M_1ЛампочкаИсправно = false;
        public static bool BMA_M_1ЛампочкаНеисправно = false;

        public static bool BMA_M_1ЛампочкаРРР = false;
        public static bool BMA_M_1ЛампочкаДист = false;

        #endregion
    }
}
