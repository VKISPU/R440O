﻿using System;
using R440O.R440OForms.A306;
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
    using R440OForms.OrderScheme;
    using СостоянияЭлементов.Контур_П;
    using R440OForms.N15Inside;
    using R440OForms.N18_M;
    using ShareTypes.SignalTypes;

    public static class ParametersConfig
    {
        /// <summary>
        /// Устанавливает определённый набор параметров станции в заданное положение
        /// </summary>
        public static void SetParameters(bool setDeveloperState = true)
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

            #region Сборы2016

            // Привет, Будущие работники
            // Энтузиазм выполнения данного проекта совсем пропал после ухода Янбекова, но работа вроде как должна продолжаться.
            // За сборы было сделано очень мало, так как нашей рабочей станции тут нет и собственно проверять и тестировать не с чего.
            // Да и я валялся некоторое время в госпитале, а мой напарник смотрел фильмы.
            // Всё же, мне удалось взять у Герасева хорошую методичку из которой можно почерпнуть устройство каждого блока и его работу. (Постараюсь не забыть скинуть)

            // Что сделано:
            // На данный момент полностью прописана проверка станции НА СЕБЯ по малому шлейфу. Всё прописано с упором на часот.
            // Единственный рабочий блок Ц300 - под номером 2. Я постарался сделать всё что могло быть в нем заложено.
            // Думаю дальше в логике его работы никто не сможет разобраться, хоть я и оставил кучу комментариев, Поэтому перекопируйте всё на остальные 3 блока.
            // Для корректной работы только измените в переменной ВходящийСигнал номер сигнала с A306 и удалите логи с левой стороны в форме.
            //
            // На всякий случай приведу порядок прохождения сигнала при проверке станции на себя, чтобы если что могли проверить по отладке.
            // 1) Н15Inside - Не уверен, но по схемам и словам Герасева на ПУЛах передачи должна быть выставлена обязательно одинаковая частота и скорость иначе сигнала нет.
            // 2) A205M - Только один может быть включен поэтому поступает только на рабочий. Тут выставляется номер волны и тип сигнала ЧТ/ОФТ. Выходной сигнал - 5725...6225 МГц
            // 3) В реальности на Н16 -> Н13-1(Н13-2) -> Н16 - но это мы опускаем здесь меняется только мощность, чтобы сигнал добрался до реального спутника. Нам это не надо, да и при проверке они не включаются.
            // 4) Поэтому сигнал идёт на А503Б - блок сдвига несущей, сдвигается частота на 2325 Мгц и волна на 1500, дальше передается на Антенное устройство, которого нет и не нужно:). Выходной сигнал - 3400...3900 МГц
            // 5) МШУ - Сюда поступает сигнал с Антенного устройства и из частоты этого сигнала вычитается значение получаемое с блока А304. Выходной сигнал - 320...370 МГц
            // 6) A306 - Здесь сигнал поступает на один из фильтров-выходов. Если частота входящего сигнала в диапазоне 320...325 Мгц то на 1, 325...330 Мгц на 2 и т.д. на выход КВ сигнал поступает в любом случае.
            // 7) Ц300 - Здесь в соответствии с номером волны вычисляется значение частоты в диапазоне 390...440 Мгц. Разница между этой частотой и частотой входящего сигнала должна быть 70 МГц, тогда он будет пойман. 
            //    Тумблером +-300/60 регулируется диапазон поиска на индикаторе. Если разница в 300/60 кГц то сигнал всё равно будет пойман, но с небольшим отклонением.
            //
            // Кулон вроде работает более менее нормально, даже в какой-то версии я подвязал его к передатчику и приемнику (или создал параметры для этого). 
            // Но по хорошему надо почитать в методичке и посмотреть по схеме в каком именно месте(блоке) он влияет, и там при некоторых условиях проходящий сигнал изменить в соответствии со значением с блока Кулона.
            // Советую завести параметр выходящей частоты прописать в нем ряд условий, при которых он 100% будет влиять.
            //
            // Собственно в самой станции осталось лишь довести до ума некоторые блоки, и грамотно разобраться и прописать прохождение сигналов. 
            //
            // Пожелания:
            //      - Старайтесь опираться на путь прохождения сигнала прописанный мной, посмотрите, как используются параметры и т.д., и используйте в таком же стиле на других блоках.
            //      - Придерживайтесь общей структуры. (Обязательные параметры "Включен", ResetParametrs и т.д.).
            //      - Ну и как говорил подполковник Герасев: "Забитый х.. залог успеха", но в данном случае это не очень) Поэтому продолжайте разрабатывать проект,
            //      чтобы все будущие участники раб. команды могли просто так получать экзамен и ничерта не делать на военке.
            //
            // Кареев Влад.     
            #endregion
             

            // Задать начальное состояние разных кнопок и тумблеров чтобы не включать все каждый раз руками.
            if (setDeveloperState)
            {
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
                A304Parameters.ТумблерКомплект = false;
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
                N15InsideParameters.ПереключательПУЛ48ПРД_2 = 3;
                N15InsideParameters.ТумблерПУЛ48ПРД_2 = Модуляция.ОФТ;

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

            // Установка Схемы-Приказа. Пытаемся получить с сервера. Если не получется, генерируем локально
            OrderSchemeParameters.SetOrderScheme();            
        }
    }
}
