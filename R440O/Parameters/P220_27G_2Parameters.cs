namespace R440O.Parameters
{
    public class P220_27G_2Parameters
    {
        ////Лампочки
        public static string P220_27G_2ЛампочкаНеиспр { get; set; }
        public static string P220_27G_2ЛампочкаПерегр { get; set; }
        public static string P220_27G_2ЛампочкаСеть { get; set; }
        public static string P220_27G_2Лампочка27В { get; set; }

        /// <summary>
        /// Определяет тип управления, выбранный на блоке.
        /// </summary>
        public static string P220_27G_2ТумблерМуДу = "Ду";

        /// <summary>
        /// true - вкл, false - выкл
        /// </summary>
        public static bool P220_27G_2ТумблерСеть = false;
    }
}
