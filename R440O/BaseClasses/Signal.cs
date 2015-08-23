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
        /// Уровень передачи сигнала.
        /// </summary>
        public double Level = -1;

        /// <summary>
        /// True - синхронный режим работы, false - асинхронный режим работы.
        /// </summary>
        public bool Synchronization;

        /// <summary>
        /// Элементы информационного канала
        /// </summary>
        public List<SignalElement> Elements;

        /// <summary>
        /// Выбранный элемент информационного сигнала.
        /// </summary>
        public List<SignalElement> SelectedElements
        {
            get
            {
                var selectedElements = Elements.Where(elem => elem.Flow == SelectedFlow).ToList();
                return selectedElements;
            }
        }

        public int SelectedFlow { get; private set; }

        public int SelectedGroup { get; private set; }

        public void SelectFlow(int flow)
        {
            SelectedFlow = flow;
        }

        public void SelectGroup(int group)
        {
            SelectedGroup = group;
        }

        public double SpeedOfChanel(int chanelNumber)
        {
            var element = Elements.FirstOrDefault(elem => elem.Flow == SelectedFlow &&
                                                          elem.Group == SelectedGroup);
            return element.Chanels[chanelNumber].Speed;
        }

        /// <summary>
        /// Проверка, правильно ли заданы скорости.
        /// </summary>
        /// <param name="inputSpeed">Номер канала, с чьей скоростью производится сравнение.</param>
        /// <param name="outputSpeed">Скорость для сравнения.</param>
        /// <returns>Возвращает true, если скорости соответствуют</returns>
        public static bool IsEquivalentSpeed(double inputSpeed, double outputSpeed)
        {
            return Math.Abs(inputSpeed - outputSpeed) <= 0.5;
        }
    }
}