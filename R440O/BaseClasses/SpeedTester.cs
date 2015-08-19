namespace R440O.BaseClasses
{
    using System;
    public static class SpeedTester
    {
        /// <summary>
        /// Проверка, правильно ли заданы скорости входного и выходного сигнала.
        /// </summary>
        /// <param name="inputSpeed">Скорость сигнала, подаваемого на ВХОД блока.</param>
        /// <param name="outputSpeed">Скорость сигнала, подаваемого на ВЫХОД блока.</param>
        /// <returns>Возвращает true, если скорости соответствуют</returns>
        public static bool IsEquivalent(double inputSpeed, double outputSpeed)
        {
            return Math.Abs(inputSpeed - outputSpeed) <= 0.5;
        }
    }
}