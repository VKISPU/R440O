using R440O.R440OForms.N18_M;

namespace R440O
{
    using Parameters;
    using R440OForms.A205M_1;
    using R440OForms.A304;
    using R440OForms.C300M_1;
    using R440OForms.Kontur_P3.Параметры;
    using R440OForms.N15;
    using R440OForms.N502B;
    using R440OForms.P220_27G_2;
    using R440OForms.P220_27G_3;
    using R440OForms.PowerCabel;
    using R440OForms.VoltageStabilizer;
    using СостоянияЭлементов.Контур_П;

    public static class ParametersConfig
    {
        /// <summary>
        /// Устанавливает определённый набор параметров станции в заданное положение
        /// </summary>
        public static void SetParameters()
        {
            //// Сброс случайных значений Фазировка и Напряжение
            N502BParameters.Фазировка = 4;
            VoltageStabilizerParameters.ПравильныйВход = 380;

            #region Подключение питания
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
            #endregion

            #region Настройка по малому шлейфу
            // Подготовка Н-15
            N15LocalParameters.локТумблерЦ300М1 = true;
            N15LocalParameters.локТумблерМШУ = true;
            N15LocalParameters.локТумблерА20512 = true;
            N15LocalParameters.локТумблерА205Base = true;
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
            #endregion


            //// Проверка БМАБ и БМБ
            //БМА
            N15LocalParameters.локТумблерБМА_1 = true;
            BMA_M_1Parameters.КнопкаПитаниеВКЛ = true;


            //// Поключение АФСС
            N15LocalParameters.локТумблерАФСС = true;
            Kontur_P3Parameters.ТумблерСеть = EТумблерСеть.ВКЛ;

            #region Дискрет и ПУЛы

            N18_MParameters.ПереключательПРД = 2;
            N15Parameters.Тумблер5МГц25МГц3 = true;
            N15LocalParameters.локТумблерА1 = true;
            N15Parameters.ТумблерТлфТлгПрд = true;
            N15Parameters.ТумблерТлфТлгПрм = true;
            P220_27G_2Parameters.ТумблерСеть = true;
            P220_27G_2Parameters.ТумблерМуДу = true;
            P220_27G_3Parameters.ТумблерСеть = true;
            P220_27G_3Parameters.ТумблерМуДу = true;

            #endregion

        }
    }
}
