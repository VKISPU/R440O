using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R440O.Parameters
{
    class OrderSchemeParameters
    {
        public static int ПередачаУсловныйНомерВолны1;
        public static int ПередачаУсловныйНомерВолны2;
        public static int ПередачаУсловныйНомерВолны3;

        public static int ПередачаПроверкаНаСебяУсловныйНомерВолныА503_1;
        public static int ПередачаПроверкаНаСебяУсловныйНомерСтволаА503_1;

        public static int ПередачаПроверкаНаСебяУсловныйНомерВолныА503_2;
        public static int ПередачаПроверкаНаСебяУсловныйНомерСтволаА503_2;

        public static int ПередачаПроверкаНаСебяУсловныйНомерВолныА503_3;
        public static int ПередачаПроверкаНаСебяУсловныйНомерСтволаА503_3;

        private static string[] Скорость = { "480", "240", "144", "96", "48", "4,8", "2,4", "1,2" };
        public static string ПриемВидМодуляцииСкорость1;

        public static int ПриемНомерПотока1;
        public static int ПриемНомерПотока2;

        public static int ПриемНомерГруппы1;
        public static int ПриемНомерГруппы2;

        public static int ПриемНомерКанала1_ТЛФ;
        public static int ПриемНомерКанала1_ТЛГ;

        public static int ПриемУсловныйНомерВолны1;

        private static bool Generate = false;
        public static void GenerateParameters()
        {
            if (!Generate)
            {
                //Generate = true;

                Random rand = new Random();

                ПередачаУсловныйНомерВолны1 = 1500 + rand.Next(50000);
                ПередачаУсловныйНомерВолны3 = 1500 + rand.Next(50000);

                int tmp = 0;
                int tmp2 = 0;

                tmp = ПередачаУсловныйНомерВолны1 - 1500;
                tmp2 = tmp / 5000;
                ПередачаПроверкаНаСебяУсловныйНомерСтволаА503_1 = tmp2 + 1;
                ПередачаПроверкаНаСебяУсловныйНомерВолныА503_1 = tmp - (tmp2 * 5000);

                tmp = ПередачаУсловныйНомерВолны3 - 1500;
                tmp2 = tmp / 5000;
                ПередачаПроверкаНаСебяУсловныйНомерСтволаА503_3 = tmp2 + 1;
                ПередачаПроверкаНаСебяУсловныйНомерВолныА503_3 = tmp - (tmp2 * 5000);

                ПриемУсловныйНомерВолны1 = 1500 + rand.Next(50000);
                while (Math.Abs(ПриемУсловныйНомерВолны1 - ПередачаУсловныйНомерВолны1) < 100)
                    ПриемУсловныйНомерВолны1 = 1500 + rand.Next(50000);

                ПриемВидМодуляцииСкорость1 = Скорость[rand.Next(Скорость.Length)];
                switch (ПриемВидМодуляцииСкорость1)
                {
                    case "480":
                        ПриемНомерПотока1 = rand.Next(9); break;
                    case "240":
                        ПриемНомерПотока1 = 6 + rand.Next(3); break;
                    case "144":
                        ПриемНомерПотока1 = 8 + rand.Next(1); break;
                    case "96":
                        ПриемНомерПотока1 = 9; break;
                    case "48":
                        ПриемНомерПотока1 = 0; break;
                    case "4,8":
                        ПриемНомерПотока1 = rand.Next(9); break;
                    case "2,4":
                        ПриемНомерПотока1 = rand.Next(9); break;
                    case "1,2":
                        ПриемНомерПотока1 = rand.Next(9); break;
                }
                ПриемНомерГруппы1 = rand.Next(9);

            }
        }
    }
}
