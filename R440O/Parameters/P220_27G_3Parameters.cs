namespace R440O.Parameters
{
    public class P220_27G_3Parameters
    {
        ////Лампочки
        public static string P220_27G_3ЛампочкаНеиспр { get; set; }
        public static string P220_27G_3ЛампочкаПерегр { get; set; }
        public static string P220_27G_3ЛампочкаСеть { get; set; }
        public static string P220_27G_3Лампочка27В { get; set; }

        /// <summary>
        /// Определяет тип управления, выбранный на блоке.
        /// </summary>
        public static string P220_27G_3ТумблерМуДу = "Ду";

        /// <summary>
        /// true - вкл, false - выкл
        /// </summary>
        public static bool P220_27G_3ТумблерСеть = false;
    }
}
