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
        public static bool ЛампочкаНеиспр { get; set; }
        public static bool ЛампочкаКонтроль = false;
        public static bool ЛампочкаСбойПодписи { get; set; }
        public static bool ЛампочкаПередача = false;
        public static bool ЛампочкаОтбой = false;
        public static bool ЛампочкаИнформПринята = false;
        #endregion

        #region Тумблеры
        private static EТумблерМткПУ _ТумблерМткПУ = EТумблерМткПУ.ПУ;
        public static EТумблерМткПУ ТумблерМткПУ
        {
            get { return _ТумблерМткПУ; }
            set
            {
                _ТумблерМткПУ = value;
                Refresh();
            }
        }
        #endregion

        #region Кнопки
        private static bool _КнопкаАдресУСС;
        public static bool КнопкаАдресУСС
        {
            get { return _КнопкаАдресУСС; }
            set
            {
                _КнопкаАдресУСС = value;
                Refresh();
            }
        }

        private static bool _КнопкаАдресК;
        public static bool КнопкаАдресК
        {
            get { return _КнопкаАдресК; }
            set
            {
                _КнопкаАдресК = value;
                Refresh();
            }
        }

        private static bool _КнопкаПодпись1;
        public static bool КнопкаПодпись1
        {
            get { return _КнопкаПодпись1; }
            set
            {
                _КнопкаПодпись1 = value;
                Refresh();
            }
        }

        private static bool _КнопкаПодпись2;
        public static bool КнопкаПодпись2
        {
            get { return _КнопкаПодпись2; }
            set
            {
                _КнопкаПодпись2 = value;
                Refresh();
            }
        }

        private static bool _КнопкаПодпись3;
        public static bool КнопкаПодпись3
        {
            get { return _КнопкаПодпись3; }
            set
            {
                _КнопкаПодпись3 = value;
                Refresh();
            }
        }

        private static EПереключательПриоритет НомерКанала;
        private static bool _КнопкаВызов;
        public static bool КнопкаВызов {
            get { return _КнопкаВызов; }
            set
            {
                _КнопкаВызов = value;
                НомерКанала = ПереключательПриоритет;
                Refresh();
            }
        }

        public static bool КнопкаОтбой { get; set; }
        public static bool КнопкаИнформ { get; set; }
        public static bool КнопкаНаборКК { get; set; }
        public static bool КнопкаКонтрольЗанятости { get; set; }
        public static bool КнопкаИнформКОН { get; set; }
        public static bool КнопкаИнформС { get; set; }
        #endregion

        #region Значения групп, адресов, информации
        private static string ЗначениеАдресК = "000";
        private static string ЗначениеПодпись1 = "000";
        private static string ЗначениеПодпись2 = "000";
        private static string ЗначениеПодпись3 = "000";

        private static int ИндексГруппы = -1;
        private static string ЗначениеИндексГруппы = "0";
        private static string[] ЗначениеГруппа = { "000", "000", "000", "000", "000", "000", "000", "000", "^00" };

        private static string ЗначениеИнформация = "";
        #endregion

        #region Табло
        private static string _ТаблоАдрес1 = "";
        public static string ТаблоАдрес1
        {
            get
            {
                return _ТаблоАдрес1;
            }
        }

        private static string _ТаблоАдрес2 = "";
        public static string ТаблоАдрес2
        {
            get
            {
                return _ТаблоАдрес2;
            }
        }

        private static string _ТаблоГруппа = "";
        public static string ТаблоГруппа
        {
            get
            {
                return _ТаблоГруппа;
            }
        }

        private static string _ТаблоИнформация = "";
        public static string ТаблоИнформация
        {
            get
            {
                return _ТаблоИнформация;
            }
        }
        #endregion

        public static void НажатаКнопка(int number)
        {
            if (ЛампочкаСеть)
            {
                if (_КнопкаАдресК || _КнопкаПодпись1 || _КнопкаПодпись2 || _КнопкаПодпись3)
                {
                    if (_КнопкаАдресК)
                    {
                        ДобавитьЧислоВПоследнийРегистр(number, ref ЗначениеАдресК);
                        _ТаблоАдрес2 = ЗначениеАдресК;
                    }
                    if (_КнопкаПодпись1)
                    {
                        ДобавитьЧислоВПоследнийРегистр(number, ref ЗначениеПодпись1);
                        _ТаблоАдрес2 = ЗначениеПодпись1;
                    }
                    if (_КнопкаПодпись2)
                    {
                        ДобавитьЧислоВПоследнийРегистр(number, ref ЗначениеПодпись2);
                        _ТаблоАдрес2 = ЗначениеПодпись2;
                    }
                    if (_КнопкаПодпись3)
                    {
                        ДобавитьЧислоВПоследнийРегистр(number, ref ЗначениеПодпись3);
                        _ТаблоАдрес2 = ЗначениеПодпись3;
                    }
                }
                else
                {
                    if (ИндексГруппы > -1 && ИндексГруппы < 8 && ЗначениеГруппа[ИндексГруппы] != "^00")
                    {
                        ДобавитьЧислоВПоследнийРегистр(number, ref ЗначениеГруппа[ИндексГруппы]);
                        ЗначениеИнформация = ЗначениеГруппа[ИндексГруппы];
                        _ТаблоИнформация = ЗначениеИнформация;
                    }
                }
            }
            Refresh();
        }

        public static void НажатаКнопкаКонец()
        {
            if (ЛампочкаСеть)
            {
                if (!(_КнопкаАдресК || _КнопкаПодпись1 || _КнопкаПодпись2 || _КнопкаПодпись3))
                {
                    ЗначениеГруппа[ИндексГруппы] = "^00";
                    ЗначениеИнформация = ЗначениеГруппа[ИндексГруппы];
                    ИндексГруппы = -1;
                    Refresh();
                }
            }
        }

        public static void ПоменятьГруппу()
        {
            if (ЛампочкаСеть)
            {
                if (!(_КнопкаАдресК || _КнопкаПодпись1 || _КнопкаПодпись2 || _КнопкаПодпись3))
                {
                    ИндексГруппы++;
                    if (ИндексГруппы > 0)
                    {
                        if(ЗначениеГруппа[ИндексГруппы - 1] == "^00")
                            ИндексГруппы = 0;
                        else
                            if (ИндексГруппы > 8)
                                ИндексГруппы = 0;
                    }                    
                    ЗначениеИндексГруппы = Convert.ToString(ИндексГруппы + 1);
                    ЗначениеИнформация = ЗначениеГруппа[ИндексГруппы];
                    Refresh();
                }
            }
        }

      
        private static void ДобавитьЧислоВПоследнийРегистр(int number, ref string str)
        {
            str = Convert.ToString(str[1]) + Convert.ToString(str[2]) + Convert.ToString(number);
        }

        public static void СбросОбщий()
        {
            ЗначениеАдресК = "000";
            ЗначениеПодпись1 = "000";
            ЗначениеПодпись2 = "000";
            ЗначениеПодпись3 = "000";

            ЗначениеИндексГруппы = "0";
            ИндексГруппы = -1;

            ЗначениеИнформация = "";
            ЗначениеГруппа = new string[] { "000", "000", "000", "000", "000", "000", "000", "000", "^00" };

            КнопкаКП4Контроль = false;
            КнопкаВызов = false;
            КнопкаКП4Контроль = false; 
            Refresh();
        }
    }
}
