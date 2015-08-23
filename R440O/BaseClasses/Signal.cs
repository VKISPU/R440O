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
        public SignalElement SelectedElement { get; set; }

        /// <summary>
        /// Выбирает определённый элемент
        /// </summary>
        /// <param name="flow"></param>
        public void Select(int flow)
        {
            SelectedElement = null;
            foreach (var elem in Elements.Where(elem => elem.Flow == flow))
            {
                SelectedElement = elem;
                return;
            }
        }

        /// <summary>
        /// Выбор первого элемента в последавательности, используется для эталонных сигналов.
        /// </summary>
        public void Select()
        {
            SelectedElement = Elements.FirstOrDefault();
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