namespace R440O.Parameters
{
    class VoltageStabilizerParameters
    {
        //Лампочки
        public static string VoltageStabilizerЛампочкаСетьВкл { get; set; }
        public static string VoltageStabilizerЛампочкаАвария { get; set; }        

        //Переключатели
        /// <summary>
        /// Возможные состояния: 15 +- 30 градусов
        /// </summary>
        public static string VoltageStabilizerПереключательКонтрольНапр { get; set; }
 
        //Кабель
        /// <summary>
        /// Возможные состояния: 220, 380
        /// </summary>
        public static string VoltageStabilizerКабельВход { get; set; } 
        
        //Индикаторы
    }
}
