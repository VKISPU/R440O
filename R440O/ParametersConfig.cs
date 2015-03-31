using R440O.R440OForms.N502B;
using R440O.R440OForms.PowerCabel;
using R440O.R440OForms.VoltageStabilizer;

namespace R440O
{
    public static class ParametersConfig
    {
        /// <summary>
        /// Устанавливает определённый набор параметров станции в заданное положение
        /// </summary>
        public static void SetParameters()
        {
            //Подключаем кабели
            PowerCabelParameters.КабельСеть = true;
            VoltageStabilizerParameters.КабельВход = 380;

            //Включаем Н502Б и Нагрузку
            N502BParameters.ПереключательСеть = true;
            N502BParameters.ПереключательФазировка = 4;
            N502BParameters.КнопкаВклНагрузки = true;
            N502BParameters.КнопкаВклНагрузки = false;

            //Устанавливаем переключатели
            N502BParameters.ТумблерЭлектрооборудование = true;
            N502BParameters.ТумблерВыпрямитель27В = true;
        }
    }
}
