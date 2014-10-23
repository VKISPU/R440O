using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R440O.Parameters
{
    internal class AstraParameters
    {
        //Переключатели 
        public static string AstraПереключательВнешнегоПитания { get; set; } // 115,+12,220,ВЫКЛ
        public static string AstraПереключательТлгТлф { get; set; }
        public static string AstraПереключательКонтроль { get; set; }
        public static string AstraПереключательДиапазоны { get; set; }
        public static string AstraПереключательВыходаРеле { get; set; }

        //Тумблеры
        public static string AstraТумблерШпУп { get; set; }

        //Кнопки
        public static string AstraКнопка150_270 { get; set; }
        public static string AstraКнопка270_480 { get; set; }
        public static string AstraКнопка480_860 { get; set; }
        public static string AstraКнопка860_1500 { get; set; }
        public static string AstraКнопкаЧастота { get; set; }

        //Индикаторы
    }
}
