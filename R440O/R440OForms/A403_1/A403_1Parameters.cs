namespace R440O.R440OForms.A403_1
{
    public class A403_1Parameters
    {
        #region Лампочки
        ////Лампочки
        public static bool ЛампочкаНеисправностьАПН { get; set; }
        public static bool ЛампочкаНеисправностьФС { get; set; }
        public static bool ЛампочкаНеисправностьРИ { get; set; }
        public static bool ЛампочкаКомплект1 { get; set; }
        public static bool ЛампочкаКомплект2 { get; set; }
        #endregion

        #region Тумблеры
        ////Тумблеры
        public static bool ТумблерСеть = false;
        public static bool ТумблерГотов = false;
        public static bool ТумблерАвтКоррекция = false;
        /// <summary>
        /// Возможные состояния: true - 1 Группа, false - 2 Группа
        /// </summary>
        public static bool ТумблерГруппа = false;

        /// <summary>
        /// Возможные состояния: true - 1 комплект, false - 2 комплект
        /// </summary>
        public static bool ТумблерКомплект = true;
        #endregion

        #region Переключатели
        ////Переключатели

        #region Переключатель проверка
        /// <summary>
        /// Положение переключателя проверки
        /// </summary>
        private static int _переключательПроверка = 1;

        /// <summary>
        /// Названия положений:
        /// 1 - 0,
        /// 2 - t,
        /// 3 - alpha P,
        /// 4 - beta P,
        /// 5 - delta F,
        /// 6 - alpha phi,
        /// 7 - beta phi,
        /// 8 - Д,
        /// 9 - Ш,
        /// 10 - К
        /// </summary>
        public static int ПереключательПроверка
        {
            get { return _переключательПроверка; }
            set
            {
                if (value > 0 && value < 11) _переключательПроверка = value;
            }
        }
        #endregion

        #region ПереключательРежимРаботы
        /// <summary>
        /// Положение переключателя режима работы
        /// </summary>
        private static int _переключательРежимРаботы = 1;

        /// <summary>
        /// Названия положений:
        /// 1 - 0,
        /// 2 - РАБ1,
        /// 3 - РАБ2,
        /// 4 - ПРОГН,
        /// 5 - РН,
        /// 6 - ПУ,
        /// 7 - УВВ,
        /// 8 - БПР,
        /// </summary>
        public static int ПереключательРежимРаботы
        {
            get { return _переключательРежимРаботы; }
            set
            {
                if (value > 0 && value < 9) _переключательРежимРаботы = value;
            }
        }
        #endregion

        #endregion

        #region Кнопки
        ////Кнопки
        /// <summary>
        /// Названия кнопок:
        /// 0 - Аlpha/Lambda,
        /// 1 - Epsilon/Phi,
        /// 2 - I/H,
        /// 3 - Omega/N,
        /// 4 - Lambda0/f,
        /// 5 - t0/K,
        /// 6 - T/Kbeta,
        /// 7 - tсв/Yalpha,
        /// 8 - tуст/Ybeta,
        /// </summary>
        public static bool[] КнопкиПараметры = { false, false, false, false, false, false, false, false, false };

        #endregion

        #region Табло
        private static int _значение = 0;
        public static int Значение { get { return _значение; } set { _значение = value; } }

        /// <summary>
        /// Матрица для хранения введённых значений на дисплее, 1 строка соответствует значениям 1 группы переменных, а 2 для 2 группы.
        /// </summary>
        public static int[,] ДисплейЗначения = {  { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                                  { 0, 0, 0, 0, 0, 0, 0, 0, 0}    };
        #endregion
    }
}
