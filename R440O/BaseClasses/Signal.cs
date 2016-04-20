namespace R440O.BaseClasses
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using ОбщиеТипыДанных;

    /// <summary>
    /// Параметры передаваемого сигнала.
    /// </summary>
    public class Signal
    {
        public Signal()
        {
            SelectedFlow = 9;
            SelectedGroup = 9;
        }

        /// <summary>
        /// Частота сигнала
        /// </summary>
        public int Frequency = -1;

        /// <summary> 
        /// Номинальная частота волны, КГц.
        /// </summary>
        public int Wave = -1;

        /// <summary>
        /// Тип модуляции. ОФТ, ЧТ.
        /// </summary>
        public Модуляция Modulation;

        /// <summary>
        /// Групповая скорость передачи сигнала.
        /// </summary>
        public double GroupSpeed = -1;

        /// <summary>
        /// Уровень мощности передачи сигнала.
        /// </summary>
        public double Level = -1;

        /// <summary>
        /// Тип режима работы.
        /// True - синхронный режим работы, false - асинхронный режим работы.
        /// </summary>
        public bool Synchronization;

        /// <summary>
        /// Список всех элементов информационного сигнала.
        /// </summary>
        public List<SignalElement> Elements;

        /// <summary>
        /// Элементы информационного сигнала, содержащиеся в потоке, выбранном по заданным аппаратурой условиям. Уровень Б3.
        /// </summary>
        public List<SignalElement> SelectedFlowElements
        {
            get
            {
                var selectedElements = Elements.Where(elem => elem.Flow == SelectedFlow).ToList();
                return selectedElements;
            }
        }

        /// <summary>
        /// Элементы информационного сигнала, содержащиеся в потоке и группе, выбранных по заданным аппаратурой условиям. Уровень Б2.
        /// </summary>
        public List<SignalElement> SelectedGroupElements
        {
            get
            {
                var selectedElements = Elements.Where(elem => (elem.Flow == SelectedFlow && elem.Group == SelectedGroup)).ToList();
                return selectedElements;
            }
        }

        /// <summary>
        /// Текущий выбранный поток.
        /// </summary>
        public int SelectedFlow { get; private set; }

        /// <summary>
        /// Текущая выбранная группа.
        /// </summary>
        public int SelectedGroup { get; private set; }

        /// <summary>
        /// Выбрать информационный поток, если его номер соответствует настройкам аппаратуры. Уровень Б3.
        /// </summary>
        /// <param name="flow">Номер потока.</param>
        public void SelectFlow(int flow)
        {
            SelectedFlow = flow;
        }

        /// <summary>
        /// Выбрать информационную группу, если её номер соответствует настройкам аппаратуры. Уровень Б2.
        /// </summary>
        /// <param name="group">Номер группы.</param>
        public void SelectGroup(int group)
        {
            SelectedGroup = group;
        }

        /// <summary>
        /// Скорость передачи в определённом информационном канале. Уровень Б1.
        /// </summary>
        /// <param name="chanelNumber">Номер канала.</param>
        public double SpeedOfChanel(int chanelNumber)
        {
            if (Elements != null)
            {
                var element = Elements.FirstOrDefault(elem => elem.Flow == SelectedFlow &&
                                                              elem.Group == SelectedGroup);
                return element.Chanels[chanelNumber].Speed;
            }

            // Мы не уверены что в этом случае должен быть 0.
            return 0;
        }

        /// <summary>
        /// Наличие информации в определённом информационном канале. Уровень Б1.
        /// </summary>
        /// <param name="chanelNumber">Номер канала.</param>
        public bool InformationOfChanel(int chanelNumber)
        {
            if (Elements != null)
            {
                var element = Elements.FirstOrDefault(elem => elem.Flow == SelectedFlow &&
                                                          elem.Group == SelectedGroup);
                return element.Chanels[chanelNumber].Information;
            }

            // МЫ не уверены что в этом случае должен быть false.
            return false;
        }

        /// <summary>
        /// Проверка, соответствуют ли друг другу скорости передачи информации.
        /// Условия выбраны таким образом, чтобы 4.8 и 5.2 соответствовали другу другу.
        /// </summary>
        /// <returns>Возвращает true, если скорости соответствуют</returns>
        public static bool IsEquivalentSpeed(double inputSpeed, double outputSpeed)
        {
            return Math.Abs(inputSpeed - outputSpeed) <= 0.5;
        }
    }
}