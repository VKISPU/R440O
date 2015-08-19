using System;
using System.Linq;
using System.Windows.Forms;
using R440O.СостоянияЭлементов.Контур_П;
using R440O.ThirdParty;

namespace R440O.R440OForms.Kontur_P3.Параметры
{
    partial class Kontur_P3Parameters
    {
        public static bool ЗвуковаяСигнализация { get; set; }

        #region Лампочки
        public static bool ЛампочкаКП5Прием = false;

        public static bool ЛампочкаСбойПодписи
        {
            get
            {
                return ЛампочкаСеть && (КнопкаПодпись1 || КнопкаПодпись2 || КнопкаПодпись3);
            }
        }

        public static bool ЛампочкаНеиспр
        {
            get
            {
                return ЛампочкаСеть && (КнопкаПодпись1 || КнопкаПодпись2 || КнопкаПодпись3);
            }
        }
        public static bool ЛампочкаКонтроль = false;

        private static bool _ЛампочкаПередача;
        public static bool ЛампочкаПередача
        {
            get { return ЛампочкаСеть && _ЛампочкаПередача; }
        }
        public static bool ЛампочкаОтбой = false;

        private static bool ИнформацияПринята = false;
        public static bool ЛампочкаИнформПринята
        {
            get
            {
                return ЛампочкаСеть && ИнформацияПринята && КнопкаНаборКК;
            }
        }
        #endregion

        #region Тумблеры
        private static EТумблерМткПУ _ТумблерМткПУ = EТумблерМткПУ.ПУ;
        public static EТумблерМткПУ ТумблерМткПУ
        {
            get { return _ТумблерМткПУ; }
            set
            {
                _ТумблерМткПУ = value;
                КнопкаКП4Контроль = false;
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

        private static IDisposable timer_Мигание = null;
        private static IDisposable timer_ЛампочкаПередача = null;
        private static bool Мигание;
        private static EПереключательПриоритет НомерКанала;
        private static bool ЗначениеКнопкиКП4Контроль;
        public static bool КнопкаВызов
        {
            set
            {
               

                if (timer_Мигание != null)
                    timer_Мигание.Dispose();
                timer_Мигание = EasyTimer.SetInterval(() =>
                {
                    Мигание = !Мигание;
                    Refresh();
                }, 300);
                if (timer_ЛампочкаПередача != null)
                    timer_ЛампочкаПередача.Dispose();
                timer_ЛампочкаПередача = EasyTimer.SetTimeout(() =>
                {
                    if ((ЗначениеАдресК == ЗначениеПодпись1
                        || ЗначениеАдресК == ЗначениеПодпись2
                        || ЗначениеАдресК == ЗначениеПодпись3) && ТумблерМткПУ == EТумблерМткПУ.МТК)
                    {
                        НомерКанала = ПереключательПриоритет;
                        ЗначениеКнопкиКП4Контроль = (КнопкаКП4Контроль) ? true : false;
                        ИнформацияПринята = true;
                        КнопкаНаборКК = false;
                    }
                    else
                        ЗначениеКнопкиКП4Контроль = false;
                    _ЛампочкаПередача = false;
                    Refresh();
                }, 6000);
                if(КнопкаКП4Контроль)
                    _ЛампочкаПередача = true;
                ЗначениеАдресК = "000";
                ЗначениеПодпись1 = "000";
                ЗначениеПодпись2 = "000";
                ЗначениеПодпись3 = "000";

                ЗначениеИндексГруппы = "0";
                ИндексГруппы = -1;

                ЗначениеИнформация = "";
                ЗначениеГруппа = new string[] { "000", "000", "000", "000", "000", "000", "000", "000", "^00" };
                Refresh();
            }
        }

        public static bool КнопкаОтбой { get; set; }
        public static bool КнопкаИнформ
        {
            set
            {
                НомерКанала = ПереключательПриоритет;
                if (timer_Мигание != null)
                    timer_Мигание.Dispose();
                if (timer_ЛампочкаПередача != null)
                    timer_ЛампочкаПередача.Dispose();
                timer_ЛампочкаПередача = EasyTimer.SetTimeout(() =>
                {
                    if ((ЗначениеАдресК == ЗначениеПодпись1
                        || ЗначениеАдресК == ЗначениеПодпись2
                        || ЗначениеАдресК == ЗначениеПодпись3) && ТумблерМткПУ == EТумблерМткПУ.МТК)
                    { 
                        ЗначениеКнопкиКП4Контроль = (КнопкаКП4Контроль) ? true : false;
                        ИнформацияПринята = true;
                        КнопкаНаборКК = false;
                    }
                    else
                        ЗначениеКнопкиКП4Контроль = false;
                    _ЛампочкаПередача = false;
                    Refresh();
                }, 6000);
                if (КнопкаКП4Контроль)
                    _ЛампочкаПередача = true;
                timer_Мигание = EasyTimer.SetInterval(() =>
                {
                    Мигание = !Мигание;
                    Refresh();
                }, 300);
                Refresh();
            }
        }

        private static bool _КнопкаНаборКК;
        public static bool КнопкаНаборКК
        {
            get { return _КнопкаНаборКК; }
            set
            {
                КнопкаНаборККНажата = true;
                КнопкаНаборККОтжата = true;
                _КнопкаНаборКК = value;
                Refresh();
            }
        }
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
                if (!(_КнопкаАдресК || _КнопкаПодпись1 || _КнопкаПодпись2 || _КнопкаПодпись3) && ИндексГруппы != -1)
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
                        if (ЗначениеГруппа[ИндексГруппы - 1] == "^00")
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

            ЗначениеКнопкиКП4Контроль = false;
            КнопкаКП4Контроль = false;
            Мигание = false;
            if (timer_Мигание != null)
                timer_Мигание.Dispose();
            if (timer_ЛампочкаПередача != null)
                timer_ЛампочкаПередача.Dispose();
            _ЛампочкаПередача = false;
            ИнформацияПринята = false;
            КнопкаНаборКК = false;
            Refresh();
        }
    }
}
