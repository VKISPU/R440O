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
    }
}
