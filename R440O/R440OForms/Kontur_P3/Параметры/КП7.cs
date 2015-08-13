﻿using R440O.СостоянияЭлементов.Контур_П;

namespace R440O.R440OForms.Kontur_P3.Параметры
{
    partial class Kontur_P3Parameters
    {
        #region Лампочки
        public static bool ЛампочкаПР1_ЗА = false;
        public static bool ЛампочкаПР2_ЗА = false;
        public static bool ЛампочкаСеть = false;
        #endregion

        #region Тумблеры
        private static EТумблерСеть _ТумблерСеть = EТумблерСеть.ОТКЛ;
        public static EТумблерСеть ТумблерСеть
        {
            get { return _ТумблерСеть; }
            set
            {
                _ТумблерСеть = value;
                if (RefreshForm != null) RefreshForm();
            }
        }
        #endregion

        #region ПереключательКонтроль
        /// <summary>
        /// Положение переключателя Приоритет
        /// </summary>
        private static EПереключательКонтроль _ПереключательКонтроль = EПереключательКонтроль.ОТКЛ;
        public static EПереключательКонтроль ПереключательКонтроль
        {
            get { return _ПереключательКонтроль; }
            set
            {
                if (value >= EПереключательКонтроль.ОТКЛ
                    && value <= EПереключательКонтроль._p9B_резерв)
                {
                    _ПереключательКонтроль = value;
                }
                if (RefreshForm != null) RefreshForm();
            }
        }
        #endregion
    }
}
