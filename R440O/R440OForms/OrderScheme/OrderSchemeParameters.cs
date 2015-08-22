﻿namespace R440O.R440OForms.OrderScheme
{
    using System;
    using System.Collections.Generic;
    using BaseClasses;
    using ОбщиеТипыДанных;

    public static class OrderSchemeParameters
    {
        static OrderSchemeParameters()
        {
            GenerateParameters();
            DefaultCorrespondent();
        }

        /// <summary>
        /// Закрепленные настройки корреспондента. Для тестирования в процессе разработки.
        /// </summary>
        private static void DefaultCorrespondent()
        {
            ПриемУсловныйНомерВолны1 = 5100;
            ПриемУсловныйНомерСтвола1 = 2;
            ПриемВидМодуляцииСкорость1 = 240;
            ПриемНомерПотока1 = 9;
            ПриемНомерГруппы1 = 1;
        }

        public static int ПередачаУсловныйНомерВолны1;
        public static int ПередачаУсловныйНомерВолны2;
        public static int ПередачаУсловныйНомерВолны3;

        public static int ПередачаПроверкаНаСебяУсловныйНомерВолныА5031;
        public static int ПередачаПроверкаНаСебяУсловныйНомерСтволаА5031;

        public static int ПередачаПроверкаНаСебяУсловныйНомерВолныА5032;
        public static int ПередачаПроверкаНаСебяУсловныйНомерСтволаА5032;

        public static int ПередачаПроверкаНаСебяУсловныйНомерВолныА5033;
        public static int ПередачаПроверкаНаСебяУсловныйНомерСтволаА5033;

        private static readonly double[] Скорость = { 480, 240, 144, 96, 48, 4,8, 2,4, 1,2 };
        public static double ПриемВидМодуляцииСкорость1;

        public static int ПриемНомерПотока1;
        public static int ПриемНомерПотока2;

        public static int ПриемНомерГруппы1;
        public static int ПриемНомерГруппы2;

        public static int ПриемНомерКанала1ТЛФ;
        public static int ПриемНомерКанала1ТЛГ;

        public static int ПриемУсловныйНомерВолны1;
        public static int ПриемУсловныйНомерСтвола1;

        private static bool _generate = false;

        public static Signal СигналКорреспондента
        {
            get
            {
                var signal = new Signal
                {
                    Elements = new List<SignalElement>
                    {
                        new SignalElement(ПриемНомерПотока1, ПриемНомерГруппы1, new []{-1, 1.2, 1.2, 1.2, 0.05, 0.05, 0.025})
                    },
                    GroupSpeed = ПриемВидМодуляцииСкорость1,
                    Level = 50,
                    Modulation = Модуляция.ОФТ,
                    Wave = ПриемУсловныйНомерВолны1
                };
                return signal;
            } 
        }

        private static void GenerateParameters()
        {
            if (_generate) return;
            _generate = true;

            var rand = new Random();

            ПередачаУсловныйНомерВолны1 = 1500 + rand.Next(50000);
            ПередачаУсловныйНомерВолны3 = 1500 + rand.Next(50000);

            var tmp = ПередачаУсловныйНомерВолны1 - 1500;
            var tmp2 = tmp/5000;
            ПередачаПроверкаНаСебяУсловныйНомерСтволаА5031 = tmp2 + 1;
            ПередачаПроверкаНаСебяУсловныйНомерВолныА5031 = tmp - (tmp2*5000);

            tmp = ПередачаУсловныйНомерВолны3 - 1500;
            tmp2 = tmp/5000;
            ПередачаПроверкаНаСебяУсловныйНомерСтволаА5033 = tmp2 + 1;
            ПередачаПроверкаНаСебяУсловныйНомерВолныА5033 = tmp - (tmp2*5000);

            ПриемУсловныйНомерВолны1 = 1500 + rand.Next(50000);
            while (Math.Abs(ПриемУсловныйНомерВолны1 - ПередачаУсловныйНомерВолны1) < 100)
                ПриемУсловныйНомерВолны1 = 1500 + rand.Next(50000);

            ПриемУсловныйНомерСтвола1 = ПередачаПроверкаНаСебяУсловныйНомерСтволаА5031;

            ПриемВидМодуляцииСкорость1 = Скорость[rand.Next(Скорость.Length)];
            if (ПриемВидМодуляцииСкорость1 == 480) ПриемНомерПотока1 = rand.Next(9);
            if (ПриемВидМодуляцииСкорость1 == 240) ПриемНомерПотока1 = 6 + rand.Next(3);
            if (ПриемВидМодуляцииСкорость1 == 144) ПриемНомерПотока1 = 8 + rand.Next(1);
            if (ПриемВидМодуляцииСкорость1 == 96) ПриемНомерПотока1 = 9;
            if (ПриемВидМодуляцииСкорость1 == 48) ПриемНомерПотока1 = 0;
            if (ПриемВидМодуляцииСкорость1 == 4.8) ПриемНомерПотока1 = rand.Next(9);
            if (ПриемВидМодуляцииСкорость1 == 2.4) ПриемНомерПотока1 = rand.Next(9);
            if (ПриемВидМодуляцииСкорость1 == 1.2) ПриемНомерПотока1 = rand.Next(9);

            ПриемНомерГруппы1 = rand.Next(9);
        }
    }
}
