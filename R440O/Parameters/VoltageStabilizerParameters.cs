using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R440O.Parameters
{
    class VoltageStabilizerParameters
    {
        //Лампочки
        public static string VoltageStabilizerЛампочкаСетьВкл { get; set; }
        public static string VoltageStabilizerЛампочкаАвария { get; set; }        

        //Переключатели
        public static string VoltageStabilizerПереключательКонтрольНапр { get; set; }
 
        //Кабель
        public static string VoltageStabilizerКабельВход { get; set; } 
        
        //Индикаторы
    }
}
