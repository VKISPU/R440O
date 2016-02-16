﻿using R440O.R440OForms.A306;
using R440O.R440OForms.C300M_2;
using R440O.R440OForms.N16;

namespace R440O
{
    using Parameters;
    using R440OForms.A205M_1;
    using R440OForms.A304;
    using R440OForms.Kontur_P3.Параметры;
    using R440OForms.N15;
    using R440OForms.N502B;
    using R440OForms.P220_27G_2;
    using R440OForms.P220_27G_3;
    using R440OForms.PowerCabel;
    using R440OForms.VoltageStabilizer;
    using СостоянияЭлементов.Контур_П;
    using R440OForms.N15Inside;
    using R440OForms.N18_M;
    using ОбщиеТипыДанных;

    public static class ParametersConfig
    {
        /// <summary>
        /// Устанавливает определённый набор параметров станции в заданное положение
        /// </summary>
        public static void SetParameters()
        {
            #region Сборы2015

            // Привет, ребята!
            // Проведя много времени за разработкой станции на сборах, а именно: около 20 дней по 8 часов,
            // было обнаружено, что база для разработки и стиль разработки были выбраны не верно.
            //
            // Однако применяя следующие штуки вы можете облегчить себе жизнь:
            //      - Обязательно используйте ReSharper.
            //      - Не ставьте больше в начале имени переменной название блока - это избыточная хурма.
            //      - Отделяйте модель от представления. Модель - классы параметров. Представление - классы форм.
            //      - Представление должно изменять лишь единичные параметры, все зависимости должны быть учтены только в классах параметров.
            //      - Используйте дополнительные свойства блока (например: Включен), и уже на основе их определяйте загорание лампочек.
            //      - Старайтесь писать Лампочки, как свойства имеющие только GET, в котором описаны условия загорания.
            //          Таким образом у вас все условия будут учитываться, когда обновляется форма.
            //      - Используйте штуки а ля: BaseClasses, ОбщиеТипыДанных, СостоянияЭлементов.
            //
            // Что сейчас работает крайне плохо:
            //      - Логика в блоке Ц300, которую необходимо оптимизировать.
            //      - Таймеры, поскольку сейчас они привязаны непосредственно к значениям.
            //          В результате смешивается модель и представление - и сложно управлять.
            //          Необходимо придумать, как это зарешать.
            //      - Распространение зависимостей от изменений в других блоках. Сейчас все изменения проводятся через блок Н-15, что не есть хорошо.
            //          Один из вариантов - использовать свойства блока (а ля Включён), на основе которых вычисляются изменения.
            //          Или же при изменении параметров в блоке вызывать в OnParameterChanged перепроверку параметров, для все зависимых блоков.
            //
            // Пожелания:
            //      - Удачи!
            //      - Переработайте запитывание станции от Н502Б до Н15 в соответствии с примерами кода блоков Дискрет(разделение модели и представления, лампочки - только лишь индикаторы).
            //          Т.к. все блоки, которые мы делали зависят от Н15-го, а не от Н502Б.
            //      - Иногда перечитывайте этот текст и не затирайте его.    
            //
            // Голополосов Игорь.

            #endregion

            #region Подключение питания
            //Подключаем кабели
            PowerCabelParameters.КабельСеть = true;
            VoltageStabilizerParameters.КабельВход = PowerCabelParameters.Напряжение;

            // Сброс случайных значений Фазировка и Напряжение, Включаем Н502Б и Нагрузку
            N502BParameters.ПереключательСеть = true;
            N502BParameters.ПереключательФазировка = N502BParameters.Фазировка;
            N502BParameters.КнопкаВклНагрузки = true;
            N502BParameters.КнопкаВклНагрузки = false;
            N502BParameters.ТумблерН13_1 = true;
            N502BParameters.ТумблерН13_2 = true;

            //Устанавливаем переключатели
            N502BParameters.ТумблерЭлектрооборудование = true;
            N502BParameters.ТумблерВыпрямитель27В = true;
            N502BParameters.ТумблерН15 = true;

            //Установка некоторых значений в память Н15
            N15LocalParameters.локТумблер5Мгц = false;
            N16Parameters.ЩелевойМостН13 = 2;
            N15Parameters.ТумблерАнтЭкв = false;

            //A304
            A304Parameters.ТумблерУправление1 = true;
            A304Parameters.ТумблерУправление2 = true;
            #endregion

            #region Настройка по малому шлейфу
            // Подготовка Н-15
            N15LocalParameters.локТумблерЦ300М2 = true;
            N15LocalParameters.локТумблерМШУ = true;
            N15LocalParameters.локТумблерА20512 = true;
            N15LocalParameters.локТумблерА205Base = true;
            N15Parameters.ТумблерА503Б = true;


            // Настройка А205М
            A205M_1Parameters.ПереключательВидРаботы = 3;
            A205M_1Parameters.ПереключательВолнаX1 = 8;
            A205M_1Parameters.ПереключательВолнаX10 = 0;
            A205M_1Parameters.ПереключательВолнаX100 = 0;
            A205M_1Parameters.ПереключательВолнаX1000 = 2;
            A205M_1Parameters.ПереключательВолнаX10000 = 2;
            // Настройка А-304
            A304Parameters.ПереключательВыборСтвола = 5;
            // Настройка А-306

            A306Parameters.ТумблерДистанцМестн = true;
            A306Parameters.Выходы[1] = 1;
            #endregion

            #region Настройка аппаратуры служебной связи
            //// Проверка БМАБ и БМБ
            //БМА
            N15LocalParameters.локТумблерБМА_1 = true;
            BMA_M_1Parameters.КнопкаПитаниеВКЛ = true;


            //// Поключение АФСС
            N15LocalParameters.локТумблерАФСС = true;
            Kontur_P3Parameters.ТумблерСеть = EТумблерСеть.ВКЛ;

            //// Подключение ДАБ-5
            N15LocalParameters.локТумблерАФСС = true;

            #endregion

            #region Дискрет и ПУЛы

            // Н18
            N18_MParameters.ПереключательПРД = 2;
            N18_MParameters.ПереключательПРМ1 = 4;

            // Генераторы
            N15Parameters.Тумблер5Мгц = 0;
            P220_27G_2Parameters.ТумблерСеть = true;
            P220_27G_2Parameters.ТумблерУправление = true;
            P220_27G_3Parameters.ТумблерСеть = true;
            P220_27G_3Parameters.ТумблерУправление = true;

            N15LocalParameters.локТумблерА1 = true;

            //ПУЛы
            N15Parameters.ТумблерТлфТлгПрд = true;
            N15Parameters.ТумблерТлфТлгПрм = true;
            N15InsideParameters.ПереключательПУЛ48ПРД_1 = 3;
            N15InsideParameters.ТумблерПУЛ48ПРД_1 = Модуляция.ОФТ;

            N15InsideParameters.ПереключательПУЛ480ПРМ_1 = 3;
            N15InsideParameters.ТумблерПУЛ480ПРМ_1 = Модуляция.ОФТ;

            // Приемная часть
            N15LocalParameters.локТумблерБ1_1 = true;
            N15LocalParameters.локТумблерБ2_1 = true;
            N15LocalParameters.локТумблерБ3_1 = true;
            N15LocalParameters.локТумблерБ1_2 = true;
            N15LocalParameters.локТумблерБ2_2 = true;
            N15LocalParameters.локТумблерБ3_2 = true;

            //С300М_2
            C300M_2Parameters.КнопкиВидРаботы[5] = true;
            C300M_2Parameters.КнопкиКонтрольРежима[3] = true;
            C300M_2Parameters.ПереключательВолна1 = 8;
            C300M_2Parameters.ПереключательВолна10 = 0;
            C300M_2Parameters.ПереключательВолна100 = 5;
            C300M_2Parameters.ПереключательВолна1000 = 0;
            C300M_2Parameters.ТумблерУправление = true;

            #endregion

        }
    }
}
