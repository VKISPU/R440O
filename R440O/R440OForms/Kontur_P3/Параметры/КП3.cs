﻿namespace R440O.R440OForms.Kontur_P3.Параметры
{
    using System;
    using СостоянияЭлементов.Контур_П;
    partial class Kontur_P3Parameters
    {
        private static bool КП3;
        #region Ламппочки
        public static bool ЛампочкаКП3Сбой = false;
        public static bool ЛампочкаКП3Канал10
        {
            get
            {
                return КнопкаКП3Канал10 && ЛампочкаСеть && ТумблерМткПУ == EТумблерМткПУ.ПУ
                    && (ЗначениеАдресК == ЗначениеПодпись1
                        || ЗначениеАдресК == ЗначениеПодпись2
                        || ЗначениеАдресК == ЗначениеПодпись3) && КП3;
            }
        }
        public static bool ЛампочкаКП3Канал11
        {
            get
            {
                return КнопкаКП3Канал11 && ЛампочкаСеть && ТумблерМткПУ == EТумблерМткПУ.ПУ
                    && (ЗначениеАдресК == ЗначениеПодпись1
                        || ЗначениеАдресК == ЗначениеПодпись2
                        || ЗначениеАдресК == ЗначениеПодпись3) && КП3;
            }
        }
        public static bool ЛампочкаКП3Канал12
        {
            get
            {
                return КнопкаКП3Канал12 && ЛампочкаСеть && ТумблерМткПУ == EТумблерМткПУ.ПУ
                    && (ЗначениеАдресК == ЗначениеПодпись1
                        || ЗначениеАдресК == ЗначениеПодпись2
                        || ЗначениеАдресК == ЗначениеПодпись3) && КП3;
            }
        }
        #endregion

        private static bool _КнопкаКП3Канал10;
        public static bool КнопкаКП3Канал10 { get { return _КнопкаКП3Канал10; } set { _КнопкаКП3Канал10 = value; Refresh(); } }
        private static bool _КнопкаКП3Канал11;
        public static bool КнопкаКП3Канал11 { get { return _КнопкаКП3Канал11; } set { _КнопкаКП3Канал11 = value; Refresh(); } }
        private static bool _КнопкаКП3Канал12;
        public static bool КнопкаКП3Канал12 { get { return _КнопкаКП3Канал12; } set { _КнопкаКП3Канал12 = value; Refresh(); } }

        public static void НажатаКнопкаКанал10()
        {
            if (ЛампочкаСеть)
            {
                if (ТумблерМткПУ == EТумблерМткПУ.ПУ)
                {
                    if ((ЗначениеАдресК == ЗначениеПодпись1
                        || ЗначениеАдресК == ЗначениеПодпись2
                        || ЗначениеАдресК == ЗначениеПодпись3)
                         && timer_Мигание == null && timer_МиганиеКП1 == null)
                    {
                        ИнформацияПринята = true;
                        ЛампочкаИнформПринята = true;
                        КП3 = true;
                        ОчищениеТаблоНаКП2();
                        Refresh();
                    }
                }
            }
        }

        public static void НажатаКнопкаКанал11()
        {
            if (ЛампочкаСеть)
            {
                if (ТумблерМткПУ == EТумблерМткПУ.ПУ)
                {
                    if ((ЗначениеАдресК == ЗначениеПодпись1
                        || ЗначениеАдресК == ЗначениеПодпись2
                        || ЗначениеАдресК == ЗначениеПодпись3)
                        && timer_Мигание == null && timer_МиганиеКП1 == null)
                    {
                        ИнформацияПринята = true;
                        ЛампочкаИнформПринята = true;
                        КП3 = true;
                        ОчищениеТаблоНаКП2();
                        Refresh();
                    }
                }
            }
        }

       

        private static void ЗаполнениеТаблоНаКП2()
        {
            ЗначениеГруппыКП2 = ЗначениеГруппа;
            ИндексГруппыКП2 = 0;
            if (ЗначениеГруппыКП2[ИндексГруппыКП2] != "^00")
            {
                ТекущееЗначение1КП2 = ЗначениеГруппыКП2[ИндексГруппыКП2];
                ИндексГруппыКП2++;
                if (ЗначениеГруппыКП2[ИндексГруппыКП2] != "^00")
                {
                    ТекущееЗначение2КП2 = ЗначениеГруппыКП2[ИндексГруппыКП2];
                    ИндексГруппыКП2++;
                }
                else
                {
                    ТекущееЗначение2КП2 = "";
                    ИндексГруппыКП2 = 0;
                }
                ТекущееЗначениеГрупыКП2 = "001";
            }
            else
            {
                ТекущееЗначение1КП2 = "";
                ТекущееЗначениеГрупыКП2 = "000";
                ИндексГруппыКП2 = 0;
            }
            
        }
        private static void ОчищениеТаблоНаКП2()
        {
            ЗначениеГруппыКП2 = new string[] { "", "", "", "", "", "", "", "", ""};
            ИндексГруппыКП2 = 0;
            ТекущееЗначение1КП2 = "";
            ТекущееЗначение2КП2 = "";
            ТекущееЗначениеГрупыКП2 = "";
        }
            
        public static void НажатаКнопкаКанал12()
        {
            if (ЛампочкаСеть)
            {
                if (ТумблерМткПУ == EТумблерМткПУ.ПУ)
                {
                    if ((ЗначениеАдресК == ЗначениеПодпись1
                        || ЗначениеАдресК == ЗначениеПодпись2
                        || ЗначениеАдресК == ЗначениеПодпись3)
                        && timer_Мигание == null && timer_МиганиеКП1 == null)
                    {
                        ИнформацияПринята = true;
                        ЛампочкаКП2Прием = true;
                        КП3 = true;
                        ЗаполнениеТаблоНаКП2();
                        Refresh();
                    }
                }
            }
        }
    }
}
