namespace R440O.Parameters
{
    public class A403_1Parameters
    {
        #region Лампочки
        ////Лампочки
        public static string A403_1ЛампочкаНеисправностьАПН { get; set; }
        public static string A403_1ЛампочкаНеисправностьФС { get; set; }
        public static string A403_1ЛампочкаНеисправностьРИ { get; set; }
        public static string A403_1ЛампочкаКомплект1 { get; set; }
        public static string A403_1ЛампочкаКомплект2 { get; set; }
        #endregion

        #region Тумблеры
        ////Тумблеры
        public static string A403_1ТумблерСеть = "откл";
        public static string A403_1ТумблерГотов = "откл";
        public static string A403_1ТумблерГруппа = "2группа";
        public static string A403_1ТумблерКомплект = "1";
        public static string A403_1ТумблерАвтКоррекция = "откл";
        #endregion

        #region Переключатели
        ////Переключатели

        #region Переключатель проверка
        /// <summary>
        /// Положение переключателя режима работы
        /// </summary>
        private static int _A403_1ПереключательПроверка = 1;

        public static int A403_1ПереключательПроверка
        {
            get { return _A403_1ПереключательПроверка; }
            set
            {
                if (value > 0 && value < 11) _A403_1ПереключательПроверка = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя режима работы
        /// </summary>
        private static string[] A403_1ПоложенияПереключательПроверка = {
            "0",
            "t",
            "альфар",
            "бетар",
            "дельтаF",
            "альфаФи",
            "бетаФи",
            "Д",
            "Ш",
            "К"
        };
        #endregion

        #region ПереключательРежимРаботы
        /// <summary>
        /// Положение переключателя режима работы
        /// </summary>
        private static int _A403_1ПереключательРежимРаботы = 1;

        public static int A403_1ПереключательРежимРаботы
        {
            get { return _A403_1ПереключательРежимРаботы; }
            set
            {
                if (value > 0 && value < 9) _A403_1ПереключательРежимРаботы = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя режима работы
        /// </summary>
        private static string[] A403_1ПоложенияПереключательРежимРаботы = {
            "0",
            "раб1",
            "раб2",
            "прогн",
            "рн",
            "пу",
            "увв",
            "бпр"
        };
        #endregion

        #endregion

        //Матрица для хранения введённых значений, 1 строка соответствует значениям 1 группы переменных, а 2 для 2 группы.
        public static float[,] A403_1Значения = {  { 0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F},
                                                   { 0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F}    };

        #region Кнопки
        ////Кнопки
        public static bool A403_1КнопкаАlpha_Lambda { get { return _A403_1КнопкаАlpha_Lambda; } set { _A403_1КнопкаАlpha_Lambda = value; } }
        private static bool _A403_1КнопкаАlpha_Lambda;

        public static bool A403_1КнопкаEpsilon_Phi { get { return _A403_1КнопкаEpsilon_Phi; } set { _A403_1КнопкаEpsilon_Phi = value; } }
        private static bool _A403_1КнопкаEpsilon_Phi;

        public static bool A403_1КнопкаI_H { get { return _A403_1КнопкаI_H; } set { _A403_1КнопкаI_H = value; } }
        private static bool _A403_1КнопкаI_H;

        public static bool A403_1КнопкаOmega_N { get { return _A403_1КнопкаOmega_N; } set { _A403_1КнопкаOmega_N = value; } }
        private static bool _A403_1КнопкаOmega_N;

        public static bool A403_1КнопкаLambda0_f { get { return _A403_1КнопкаLambda0_f; } set { _A403_1КнопкаLambda0_f = value; } }
        private static bool _A403_1КнопкаLambda0_f;

        public static bool A403_1Кнопкаt0_K { get { return _A403_1Кнопкаt0_K; } set { _A403_1Кнопкаt0_K = value; } }
        private static bool _A403_1Кнопкаt0_K;

        public static bool A403_1КнопкаT_Kbeta { get { return _A403_1КнопкаT_Kbeta; } set { _A403_1КнопкаT_Kbeta = value; } }
        private static bool _A403_1КнопкаT_Kbeta;

        public static bool A403_1Кнопкаtсв_Yalpha { get { return _A403_1Кнопкаtсв_Yalpha; } set { _A403_1Кнопкаtсв_Yalpha = value; } }
        private static bool _A403_1Кнопкаtсв_Yalpha;

        public static bool A403_1Кнопкаtуст_Ybeta { get { return _A403_1Кнопкаtуст_Ybeta; } set { _A403_1Кнопкаtуст_Ybeta = value; } }
        private static bool _A403_1Кнопкаtуст_Ybeta;
        #endregion

        #region Табло
        public static string A403_1TextParameter { get; set; }

        public static string A403_1ТаблоПоле0 { get; set; }
        public static string A403_1ТаблоПолe1 { get; set; }
        public static string A403_1ТаблоПоле2 { get; set; }
        public static string A403_1ТаблоПоле3 { get; set; }
        public static string A403_1ТаблоПоле4 { get; set; }
        public static string A403_1ТаблоПоле5 { get; set; }
        public static string A403_1ТаблоПоле6 { get; set; }
        #endregion
    }
}
