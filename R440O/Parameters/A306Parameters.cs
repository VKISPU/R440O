using System.Collections.Generic;

namespace R440O.Parameters
{
    public class A306Parameters
    {
        ////Лампочки
        public static string A306ЛампочкаСетьВкл { get; set; }
        public static string A306ЛампочкаНО1Вкл { get; set; }
        public static string A306ЛампочкаНО2Вкл { get; set; }

        ////Тумблеры
        /// <summary>
        /// Положение переключателя A306 определяющее тип питания блока. true - дистанционное, false - местное
        /// </summary>
        public static bool A306ТумблерДистанцМестн = true;

        /// <summary>
        /// Положение переключателя A306 определяющее включен блок или нет. true - вкл, false - выкл
        /// </summary>
        public static bool A306ТумблерВклВыкл = true;

        public static int[] A306Входы = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
        public static int[] A306ВыходыКаналов = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
        /// <summary>
        /// Выходы НО-1: 0-3, НО-1: 4, НО-2: 5, Выходы НО-2: 6-9
        /// </summary>
        public static int[] A306Выходы = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    }
}
