using System;
using System.Linq;
using System.Windows.Forms;
using R440O.СостоянияЭлементов.Контур_П;

namespace R440O.R440OForms.Kontur_P3.Параметры
{
    partial class Kontur_P3Parameters
    {
        public static bool ЗвуковаяСигнализация { get; set; }

        #region Лампочки
        public static bool ЛампочкаКП5Прием = false;

        public static bool ЛампочкаНеиспр
        {
            get { return (КнопкаПодпись1 || КнопкаПодпись2 || КнопкаПодпись3) && ЛампочкаСеть && ЗвуковаяСигнализация; }
        }
        public static bool ЛампочкаКонтроль = false;
        public static bool ЛампочкаСбойПодписи
        {
            get { return (КнопкаПодпись1 || КнопкаПодпись2 || КнопкаПодпись3) && ЛампочкаСеть && ЗвуковаяСигнализация; }
        }
        public static bool ЛампочкаПередача = false;
        public static bool ЛампочкаОтбой = false;
        public static bool ЛампочкаИнформПринята = false;
        #endregion

        #region Тумблеры
        private static EТумблерМткПУ _ТумблерМткПУ = EТумблерМткПУ.МТК;
        public static EТумблерМткПУ ТумблерМткПУ
        {
            get { return _ТумблерМткПУ; }
            set
            {
                _ТумблерМткПУ = value;
                if (RefreshForm != null) RefreshForm();
            }
        }
        #endregion

        #region Кнопки
        private static bool _кнопкаПодпись1;
        private static bool _кнопкаПодпись2;
        private static bool _кнопкаПодпись3;
        private static bool _кнопкаАдресК;

        public static bool КнопкаАдресК
        {
            get { return _кнопкаАдресК; }
            set
            {
                _кнопкаАдресК = value;
                if (RefreshForm != null) RefreshForm();
            }
        }

        public static bool КнопкаПодпись1
        {
            get { return _кнопкаПодпись1; }
            set
            {
                _кнопкаПодпись1 = value;
                ЗвуковаяСигнализация = true;
                if (RefreshForm != null) RefreshForm();
            }
        }

        public static bool КнопкаПодпись2
        {
            get { return _кнопкаПодпись2; }
            set
            {
                _кнопкаПодпись2 = value;
                ЗвуковаяСигнализация = true;
                if (RefreshForm != null) RefreshForm();
            }
        }

        public static bool КнопкаПодпись3
        {
            get { return _кнопкаПодпись3; }
            set
            {
                _кнопкаПодпись3 = value;
                ЗвуковаяСигнализация = true;
                if (RefreshForm != null) RefreshForm();
            }
        }

        #endregion

        #region Активные действия кнопок

        public static void ОтключитьЗвуковуюСигнализацию()
        {
            ЗвуковаяСигнализация = false;
            if (RefreshForm != null) RefreshForm();
        }

        /// <summary>
        /// Нажатие клавиши с номером
        /// </summary>
        /// <param name="number"></param>
        public static void НажатьКнопку(int number)
        {
            if (number != -1)
            {
                if (КнопкаПодпись1)
                {
                    if (_подпись1[0] == 0) _подпись1[0] = number;
                    else if (_подпись1[1] == 0) _подпись1[1] = number;
                    else if (_подпись1[2] == 0) _подпись1[2] = number;
                }
                if (КнопкаПодпись2)
                {
                    if (_подпись2[0] == 0) _подпись2[0] = number;
                    else if (_подпись2[1] == 0) _подпись2[1] = number;
                    else if (_подпись2[2] == 0) _подпись2[2] = number;
                }
                if (КнопкаПодпись3)
                {
                    if (_подпись3[0] == 0) _подпись3[0] = number;
                    else if (_подпись3[1] == 0) _подпись3[1] = number;
                    else if (_подпись3[2] == 0) _подпись3[2] = number;
                }

                if (КнопкаАдресК)
                {
                    if (_адрес[0] == 0) _адрес[0] = number;
                    else if (_адрес[1] == 0) _адрес[1] = number;
                    else if (_адрес[2] == 0) _адрес[2] = number;
                }
            }

            if (!КнопкаПодпись1 && !КнопкаПодпись2 && !КнопкаПодпись3 && !КнопкаАдресК)
            {
                if (_группа[ТекущаяГруппа][0] == 0) _группа[ТекущаяГруппа][0] = number;
                else if (_группа[ТекущаяГруппа][1] == 0) _группа[ТекущаяГруппа][1] = number;
                else if (_группа[ТекущаяГруппа][2] == 0) _группа[ТекущаяГруппа][2] = number;
            }
            
            if (RefreshForm != null) RefreshForm();
        }
        #endregion

        #region Подписи и Адреса

        private static int[] _подпись1 = {0, 0, 0};
        private static int[] _подпись2 = { 0, 0, 0 };
        private static int[] _подпись3 = { 0, 0, 0 };
        private static int[] _адрес = { 0, 0, 0 };

        public static string Подпись1
        {
            get { return _подпись1[2] + " " + _подпись1[1] + " " + _подпись1[0]; }
        }
        public static string Подпись2
        {
            get { return _подпись2[2] + " " + _подпись2[1] + " " + _подпись2[0]; }
        }
        public static string Подпись3
        {
            get { return _подпись3[2] + " " + _подпись3[1] + " " + _подпись3[0]; }
        }
        public static string Адрес
        {
            get { return _адрес[2] + " " + _адрес[1] + " " + _адрес[0]; }
        }

        #endregion

        #region Группа

        public static int ТекущаяГруппа
        {
            get { return _текущаяГруппа; }
            set
            {
                if (value < 10 && ЛампочкаСеть)
                _текущаяГруппа = value;
                if (RefreshForm != null) RefreshForm();

            }
        }

        private static int _текущаяГруппа;

        private static int[][] _группа =
        {
            new int[] {},
            new [] { 0, 0, 0 }, //1
            new [] { 0, 0, 0 }, //2
            new [] { 0, 0, 0 }, //3
            new [] { 0, 0, 0 }, //4
            new [] { 0, 0, 0 }, //5
            new [] { 0, 0, 0 }, //6
            new [] { 0, 0, 0 }, //7
            new [] { 0, 0, 0 }, //8
            new [] { 0, 0, -1} //9
        };
        
        private static string Группа
        {
            get
            {
                if (_группа[ТекущаяГруппа].Contains(-1))
                {
                    return "^ 0 0 "; }
                return _группа[ТекущаяГруппа][2] + " " + _группа[ТекущаяГруппа][1] + " " + _группа[ТекущаяГруппа][0];
            }
        }

        #endregion

        #region Табло

        public static string ТаблоАдрес1 { get { return ""; } }

        public static string ТаблоАдрес2
        {
            get
            {
                if (ЛампочкаСеть)
                {
                    if (КнопкаПодпись1) return Подпись1;
                    if (КнопкаПодпись2) return Подпись2;
                    if (КнопкаПодпись3) return Подпись3;
                    if (КнопкаАдресК) return Адрес;
                }
                return "";
                
            }
        }

        public static string ТаблоГруппа
        {
            get
            {
                if (!ЛампочкаСеть) return "";
                return ТекущаяГруппа + string.Empty;
            }
        }

        public static string ТаблоИнформация
        {
            get
            {
                if (!ЛампочкаСеть) return "";
                return ТекущаяГруппа == 0 ? "" : Группа + string.Empty;
            }
        }

        #endregion
    }
}
