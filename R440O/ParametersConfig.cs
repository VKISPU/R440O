using R440O.Parameters;
using R440O.R440OForms.A205M_1;
using R440O.R440OForms.A304;
using R440O.R440OForms.C300M_1;
using R440O.R440OForms.Kontur_P3;
using R440O.R440OForms.Kontur_P3.Параметры;
using R440O.R440OForms.N15;
using R440O.R440OForms.N502B;
using R440O.R440OForms.PowerCabel;
using R440O.R440OForms.VoltageStabilizer;
using R440O.СостоянияЭлементов.Контур_П;

namespace R440O
{
    public static class ParametersConfig
    {
        /// <summary>
        /// Устанавливает определённый набор параметров станции в заданное положение
        /// </summary>
        public static void SetParameters()
        {
            //// Фазировка и Напряжение
            N502BParameters.Фазировка = 4;
            VoltageStabilizerParameters.ПравильныйВход = 380;

            //// Подключение питания
            //Подключаем кабели
            PowerCabelParameters.КабельСеть = true;
            VoltageStabilizerParameters.КабельВход = 380;

            //Включаем Н502Б и Нагрузку
            N502BParameters.ПереключательСеть = true;
            N502BParameters.ПереключательФазировка = 4;
            N502BParameters.Нагрузка = true;

            //Устанавливаем переключатели
            N502BParameters.ТумблерЭлектрооборудование = true;
            N502BParameters.ТумблерВыпрямитель27В = true;
            N502BParameters.ТумблерН15 = true;

            //A304
            A304Parameters.ТумблерУправление1 = true;
            A304Parameters.ТумблерУправление2 = true;

            //// Настройка по малому шлейфу
            // Подготовка Н-15
            N15LocalParameters._локТумблерЦ300М1 = true;
            N15LocalParameters._локТумблерМШУ = true;
            N15LocalParameters._локТумблерА20512 = true;
            N15LocalParameters._локТумблерА205Base = true;
            N15Parameters.ТумблерА503Б = true;
            N15Parameters.РегуляторУровень = 100;

            // Настройка А-205
            A205M_1Parameters.ПереключательВидРаботы = 3;
            A205M_1Parameters.ПереключательВолнаX1000 = 6;
            A205M_1Parameters.ПереключательВолнаX100 = 6;
            A205M_1Parameters.ПереключательВолнаX10 = 0;
            A205M_1Parameters.ПереключательВолнаX1 = 0;

            // Настройка А-304
            A304Parameters.ПереключательВыборСтвола = 1;

            // Настройка А-306

            A306Parameters.ТумблерДистанцМестн = true;
            A306Parameters.АктивныйВход = 0;
            A306Parameters.ЦелевойВыход = 0;

            // Настройка Ц300М-1

            C300M_1Parameters.ТумблерУправление = true;
            C300M_1Parameters.КнопкаВидРаботы = 5;
            C300M_1Parameters.ПереключательВолна1000 = 0;
            C300M_1Parameters.ПереключательВолна100 = 1;
            C300M_1Parameters.ПереключательВолна10 = 0;
            C300M_1Parameters.ПереключательВолна1 = 0;


            //// Проверка БМАБ и БМБ
            //БМА
            N15LocalParameters._локТумблерБМА_1 = true;
            BMA_M_1Parameters.КнопкаПитаниеВКЛ = true;


            //// Поключение АФСС
            N15LocalParameters.локТумблерАФСС = true;
            Kontur_P3Parameters.ТумблерСеть = EТумблерСеть.ВКЛ;

        }
    }
}
