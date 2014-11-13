using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R440O.Parameters
{
    class N502BParameters
    {
        //Лампочки
        public static string N502BЛампочкаСеть { get; set; }
        public static string N502BЛампочкаСфазировано { get; set; }
        public static string N502BЛампочкаРБППроверка { get; set; }

        //public static string N502BЛампочкаРБППредохранитель { get; set; }

        //Кнопки
        public static string N502BКнопкаВклНагрузки { get; set; }
        public static string N502BКнопкаРБППроверка { get; set; }
        public static string N502BКнопкаРБПСброс { get; set; }

        //Тумблеры
        public static string N502BТумблерЭлектрооборуд { get; set; }
        public static string N502BТумблерВыпрямитель27В { get; set; }
        public static string N502BТумблерОсвещение { get; set; }
        public static string N502BТумблерН13_1 { get; set; }
        public static string N502BТумблерН13_2 { get; set; }
        public static string N502BТумблерН15 { get; set; }
        public static string N502BТумблерОсвещение1 { get; set; }
        public static string N502BТумблерОсвещение2 { get; set; }

        //Переключатели
        public static string N502BПереключательСеть = "false";


        /// <summary>
        /// Положение переключателя напряжения
        /// </summary>
        private static int _N502BПереключательНапряжение = 1;

        public static int N502BПереключательНапряжение
        {
            get { return _N502BПереключательНапряжение; }
            set
            {
                if (value > 0 && value < 7) _N502BПереключательНапряжение = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя напряжения
        /// </summary>
        private static string[] N502BПоложенияПереключательНапряжение = {
            "сеть1-2",
            "сеть1-3",
            "сеть2-3",
            "нагрузка1-2",
            "нагрузка1-3",
            "нагрузка2-3"
        };


        /// <summary>
        /// Положение переключателя Фазировка
        /// </summary>
        private static int _N502BПереключательФазировка = 1;

        public static int N502BПереключательФазировка
        {
            get { return _N502BПереключательФазировка; }
            set
            {
                if (value >= 0 && value <= 5) _N502BПереключательФазировка = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя напряжения
        /// </summary>
        private static string[] N502BПоложенияПереключательФазировка = {
            "откл",
            "1-2-3",
            "откл",
            "2-1-3"
        };

        private static int _N502BПереключательКонтрольНапряжения = 2;

        public static int N502BПереключательКонтрольНапряжения
        {
            get { return _N502BПереключательКонтрольНапряжения; }
            set
            {
                if (value > 0 && value < 4) _N502BПереключательКонтрольНапряжения = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя напряжения
        /// </summary>
        private static string[] N502BПоложенияКонтрольНапряжения = {
            "+27B",
            "откл",
            "+12B"     
        };

        private static int _N502BПереключательТокНагрузкиИЗаряда = 1;

        public static int N502BПереключательТокНагрузкиИЗаряда
        {
            get { return _N502BПереключательТокНагрузкиИЗаряда; }
            set
            {
                if (value > 0 && value < 9) _N502BПереключательТокНагрузкиИЗаряда = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя напряжения
        /// </summary>
        private static string[] N502BПоложенияПереключательТокНагрузкиИЗаряда = {
            "откл",
            "отопительФВУА",
            "зарядкаБатареи",
            "+Ток1", 
            "+Ток2", 
            "+Ток3", 
            "+Ток4", 
            "+Ток5"
        };

        //Индикаторы
    }
}
