using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace R440O.Parameters
{
    public class A306Parameters
    {
        ////Лампочки
        public static bool A306ЛампочкаСетьВкл = false;
        public static bool A306ЛампочкаНО1Вкл = false;
        public static bool A306ЛампочкаНО2Вкл = false;

        ////Тумблеры
        /// <summary>
        /// Положение переключателя A306 определяющее тип питания блока. true - дистанционное, false - местное
        /// </summary>
        public static bool A306ТумблерДистанцМестн = true;
        /// <summary>
        /// Положение переключателя A306 определяющее включен блок или нет. true - вкл, false - выкл
        /// </summary>
        public static bool A306ТумблерВклВыкл = true;

        /// <summary>
        /// Содержит информацию о выходах: 1, 2, 3, 4, НО-1:11, HO-2:12
        /// </summary>
        public static int[] A306ВыходыNO = { 0, 0, 0, 0, 0, 0, 0, 0 };

        public static bool A306ВходNO_1 = false;
        public static bool A306ВходNO_2 = false;

        /// <summary>
        /// Содержит информацию о выходах: 1, 2, 3, 4, НО-1:11, HO-2:12
        /// </summary>
        public static int[] A306ВыходыКаналов = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static bool[] A306Выходы = { false, false, false, false };
    }
}
