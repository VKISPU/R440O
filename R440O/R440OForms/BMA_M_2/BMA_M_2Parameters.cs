using R440O.R440OForms.BMB;

namespace R440O.R440OForms.BMA_M_2
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
        #region Кнопки
        private static bool _кнопкаПитаниеВКЛ;
        private static bool _кнопкаШлейфТЧ;
        private static bool _кнопкаШлейфДК;
        public static bool КнопкаПитаниеВЫКЛ;

        public static bool КнопкаПитаниеВкл
        {
            get { return _кнопкаПитаниеВКЛ; }
            set
            {
                _кнопкаПитаниеВКЛ = value;
                BMBParameters.ResetParameters();
            }
        }

        public static bool КнопкаШлейфДК
        {
            get { return _кнопкаШлейфДК; }
            set
            {
                _кнопкаШлейфДК = value;
                BMBParameters.ResetParameters();
            }
        }

        public static bool КнопкаШлейфТЧ
        {
            get { return _кнопкаШлейфТЧ; }
            set
            {
                _кнопкаШлейфТЧ = value;
                BMBParameters.ResetParameters();
            }
        }
        #endregion
        #endregion

        #region Лампочки
        public static bool BMA_M_2ЛампочкаТЧБ = false;
        public static bool BMA_M_2ЛампочкаФЗ = false;
        public static bool BMA_M_2ЛампочкаДК = false;
        public static bool BMA_M_2ЛампочкаСинхрТЧ = false;
        public static bool BMA_M_2ЛампочкаСинхрДК = false;
        public static bool BMA_M_2ЛампочкаПрдТЧ = false;
        public static bool BMA_M_2ЛампочкаПрдДК = false;
        public static bool BMA_M_2ЛампочкаПрмТЧ = false;
        public static bool BMA_M_2ЛампочкаПрмФР = false;
        public static bool BMA_M_2ЛампочкаПрмДК1 = false;
        public static bool BMA_M_2ЛампочкаПрмДК2 = false;

        public static bool BMA_M_2ЛампочкаПитание_5В = false;
        public static bool BMA_M_2ЛампочкаПитание_10В = false;
        public static bool BMA_M_2ЛампочкаПитание_12В = false;
        public static bool BMA_M_2ЛампочкаПитание_15В = false;
        public static bool BMA_M_2ЛампочкаПитание_15Вplus = false;

        public static bool BMA_M_2ЛампочкаКонтрольНенорм = false;
        public static bool BMA_M_2ЛампочкаКонтрольНорм = false;
        public static bool BMA_M_2ЛампочкаКонтрольТест = false;
        public static bool BMA_M_2ЛампочкаКонтрольДК = false;
        public static bool BMA_M_2ЛампочкаКонтрольТЧ = false;
        public static bool BMA_M_2ЛампочкаКонтрольКомпл = false;

        public static bool BMA_M_2ЛампочкаРекурента15 = false;
        public static bool BMA_M_2ЛампочкаРекурента31 = false;
        public static bool BMA_M_2ЛампочкаРекурента511 = false;
        public static bool BMA_M_2ЛампочкаРекурента1023 = false;

        public static bool BMA_M_2ЛампочкаАвтомКоманда1 = false;
        public static bool BMA_M_2ЛампочкаАвтомКоманда2 = false;

        public static bool BMA_M_2ЛампочкаИсправно = false;
        public static bool BMA_M_2ЛампочкаНеисправно = false;

        public static bool BMA_M_2ЛампочкаРРР = false;
        public static bool BMA_M_2ЛампочкаДист = false;

        #endregion
    }
}
