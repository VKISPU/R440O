﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShareTypes.OrderScheme
{
    public static class OrderSchemeFactory
    {
        private static readonly double[] Скорость = { 480, 240, 144, 96, 48, 4, 8, 2, 4, 1, 2 };

        public static OrderSchemeClass CreateOrderScheme(bool isTesting)
        {
            return isTesting ? DefaultCorrespondent() : GenerateParameters();
        }

        /// <summary>
        /// Закрепленные настройки корреспондента. Для тестирования в процессе разработки.
        /// </summary>
        private static OrderSchemeClass DefaultCorrespondent()
        {
            return new OrderSchemeClass
            {
                УникальныйИдентификаторСтанции = string.Empty,
                ПриемУсловныйНомерВолны1 = 5100,
                ПриемУсловныйНомерСтвола1 = 2,
                ПриемВидМодуляцииСкорость1 = 240,
                ПриемНомерПотока1 = 9,
                ПриемНомерГруппы1 = 9,
                ПриемНомерКаналаТЛФ = 2,
                ПриемНомерКаналаТЛГ = 4,
                ЦиркулярныйПозывной = 111,
                ЦиркулярноИндивидуальныйПозывной = 222,
                ИндивидуальныйПозывной = 001
            };
        }

        /// <summary>
        /// Генериует случайным образом параметры настройки на корреспондента.
        /// </summary>
        private static OrderSchemeClass GenerateParameters()
        {
            var rand = new Random();
            var схема = new OrderSchemeClass();
            схема.УникальныйИдентификаторСтанции = string.Empty;

            схема.ПередачаУсловныйНомерВолны1 = 1500 + rand.Next(50000);
            схема.ПередачаУсловныйНомерВолны3 = 1500 + rand.Next(50000);

            var tmp = схема.ПередачаУсловныйНомерВолны1 - 1500;
            var tmp2 = tmp / 5000;
            схема.ПередачаПроверкаНаСебяУсловныйНомерСтволаА5031 = tmp2 + 1;
            схема.ПередачаПроверкаНаСебяУсловныйНомерВолныА5031 = tmp - (tmp2 * 5000);

            tmp = схема.ПередачаУсловныйНомерВолны3 - 1500;
            tmp2 = tmp / 5000;
            схема.ПередачаПроверкаНаСебяУсловныйНомерСтволаА5033 = tmp2 + 1;
            схема.ПередачаПроверкаНаСебяУсловныйНомерВолныА5033 = tmp - (tmp2 * 5000);

            схема.ПриемУсловныйНомерВолны1 = 1500 + rand.Next(50000);
            while (Math.Abs(схема.ПриемУсловныйНомерВолны1 - схема.ПередачаУсловныйНомерВолны1) < 100)
                схема.ПриемУсловныйНомерВолны1 = 1500 + rand.Next(50000);

            схема.ПриемУсловныйНомерСтвола1 = схема.ПередачаПроверкаНаСебяУсловныйНомерСтволаА5031;

            схема.ПриемВидМодуляцииСкорость1 = Скорость[rand.Next(Скорость.Length)];

            if (схема.ПриемВидМодуляцииСкорость1 == 480) схема.ПриемНомерПотока1 = rand.Next(9);
            if (схема.ПриемВидМодуляцииСкорость1 == 240) схема.ПриемНомерПотока1 = 6 + rand.Next(3);
            if (схема.ПриемВидМодуляцииСкорость1 == 144) схема.ПриемНомерПотока1 = 8 + rand.Next(1);
            if (схема.ПриемВидМодуляцииСкорость1 == 96) схема.ПриемНомерПотока1 = 9;
            if (схема.ПриемВидМодуляцииСкорость1 == 48) схема.ПриемНомерПотока1 = 0;
            if (схема.ПриемВидМодуляцииСкорость1 == 4.8) схема.ПриемНомерПотока1 = rand.Next(9);
            if (схема.ПриемВидМодуляцииСкорость1 == 2.4) схема.ПриемНомерПотока1 = rand.Next(9);
            if (схема.ПриемВидМодуляцииСкорость1 == 1.2) схема.ПриемНомерПотока1 = rand.Next(9);

            схема.ПриемНомерГруппы1 = rand.Next(9);
            схема.ПриемНомерКаналаТЛФ = rand.Next(3);
            схема.ПриемНомерКаналаТЛГ = rand.Next(4, 5);

            схема.ЦиркулярныйПозывной = rand.Next(100, 999);
            схема.ЦиркулярноИндивидуальныйПозывной = rand.Next(100, 999);
            схема.ИндивидуальныйПозывной = rand.Next(100, 999);

            return схема;
        }

        public static OrderSchemeClass GenerateOrderSchemeByWave(
            int номерВолныНаПередачу,
            int номерВолныНаПередачуДругойСхемыПриказа,
            int циркулярныйПозывной,
            int циркулярноИндивидуальныйПозывной,
            int индивидуальныйПозывной)
        {
            var схема = new OrderSchemeClass();

            схема.ПередачаУсловныйНомерВолны1 = номерВолныНаПередачу;
            var tmp = схема.ПередачаУсловныйНомерВолны1 - 1500;
            var tmp2 = tmp / 5000;
            схема.ПередачаПроверкаНаСебяУсловныйНомерСтволаА5031 = tmp2 + 1;
            схема.ПередачаПроверкаНаСебяУсловныйНомерВолныА5031 = tmp - (tmp2 * 5000);

            var tmp3 = номерВолныНаПередачуДругойСхемыПриказа - 1500;
            var tmp4 = tmp3 / 5000;
            схема.ПриемУсловныйНомерСтвола1 = tmp4 + 1;
            схема.ПриемУсловныйНомерВолны1 = tmp3 - (tmp4 * 5000);

            схема.ЦиркулярныйПозывной = циркулярныйПозывной;
            схема.ЦиркулярноИндивидуальныйПозывной = циркулярноИндивидуальныйПозывной;
            схема.ИндивидуальныйПозывной = индивидуальныйПозывной;

            return схема;
        }
    }
}
