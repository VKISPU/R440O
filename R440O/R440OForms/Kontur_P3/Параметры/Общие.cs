﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R440O.R440OForms.Kontur_P3.Параметры
{
    partial class Kontur_P3Parameters
    {

        public static void ResetToDefaultsWhenTurnOnOff()
        {
            _ТаблоГруппа = ЛампочкаСеть ? "0" : "";
            СбросОбщий();
            if (ЛампочкаСеть)
            {
                ОбновлениеТаблоАдрес2();
            }
            else
            {
                _ТаблоАдрес1 = "";
                _ТаблоАдрес2 = "";
                _ТаблоИнформация = "";
            }
        }

        public delegate void ParameterChangedHandler();
        public static event ParameterChangedHandler RefreshForm;

        public static void Refresh()
        {
            if (ЛампочкаСеть)
            {
                ОбновлениеТаблоАдрес2();
                ОбновлениеТаблоГруппа();
                ОбновлениеТаблоИнформация();
            }
            if (RefreshForm != null)
            {
                RefreshForm();
            }
        }

        private static void ОбновлениеТаблоАдрес2()
        {
            if (_КнопкаАдресК || _КнопкаПодпись1 || _КнопкаПодпись2 || _КнопкаПодпись3)
            {
                if (_КнопкаАдресК)
                {
                    _ТаблоАдрес2 = ЗначениеАдресК;
                }
                if (_КнопкаПодпись1)
                {
                    _ТаблоАдрес2 = ЗначениеПодпись1;
                }
                if (_КнопкаПодпись2)
                {
                    _ТаблоАдрес2 = ЗначениеПодпись2;
                }
                if (_КнопкаПодпись3)
                {
                    _ТаблоАдрес2 = ЗначениеПодпись3;
                }
            }
            else
            {
                _ТаблоАдрес2 = "";
            }
        }

        private static void ОбновлениеТаблоГруппа()
        {
            if (_КнопкаАдресК || _КнопкаПодпись1 || _КнопкаПодпись2 || _КнопкаПодпись3)
            {
                ИндексГруппы = -1;
                ЗначениеИндексГруппы = "0";
            }
            _ТаблоГруппа = ЗначениеИндексГруппы;
        }

        private static void ОбновлениеТаблоИнформация()
        {
            if (_КнопкаАдресК || _КнопкаПодпись1 || _КнопкаПодпись2 || _КнопкаПодпись3)
            {
                ЗначениеИнформация = "";               
            }
            _ТаблоИнформация = ЗначениеИнформация;
        }
    }
}
