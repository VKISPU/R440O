namespace R440O.Parameters
{
    class A1Parameters
    {
        //Лампочки
        public static string A1ЛампочкаБОЧ { get; set; }
        public static string A1ЛампочкаФСПК { get; set; }
        public static string A1ЛампочкаТКААвария { get; set; }
        public static string A1ЛампочкаЭП1 { get; set; }
        public static string A1ЛампочкаПУЛ1_1 { get; set; }
        public static string A1ЛампочкаПУЛ1_2 { get; set; }
        public static string A1ЛампочкаЭП2 { get; set; }
        public static string A1ЛампочкаПУЛ2_1 { get; set; }
        public static string A1ЛампочкаПУЛ2_2 { get; set; }
        public static string A1ЛампочкаЭП3 { get; set; }
        public static string A1ЛампочкаПУЛ3_1 { get; set; }
        public static string A1ЛампочкаПУЛ3_2 { get; set; }
        public static string A1ЛампочкаНеиспр { get; set; }
        public static string A1BЛампочкаПитание { get; set; }

        //Тумблер
        /// <summary>
        /// Возможные состояния: Му - местное управление, Ду - дистанционное управление
        /// </summary>
        public static string A1ТумблерМуДу { get; set; }

        //Кнопки
        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static string A1КнопкаСкоростьГР { get; set; }

        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static string A1КнопкаСкоростьАБ_1ТЛФ_К { get; set; }

    }
}
