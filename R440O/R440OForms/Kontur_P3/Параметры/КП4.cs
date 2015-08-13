﻿using R440O.СостоянияЭлементов.Контур_П;

namespace R440O.R440OForms.Kontur_P3.Параметры
{
    partial class Kontur_P3Parameters
    {
        #region Лампочки
        public static bool ЛампочкаКП4Канал1 = false;
        public static bool ЛампочкаКП4Канал2 = false;
        public static bool ЛампочкаКП4Канал3 = false;
        public static bool ЛампочкаКП4Канал4 = false;
        public static bool ЛампочкаКП4Канал5 = false;
        public static bool ЛампочкаКП4Канал6 = false;
        public static bool ЛампочкаКП4Канал7 = false;
        public static bool ЛампочкаКП4Канал8 = false;
        public static bool ЛампочкаКП4Канал9 = false;
        #endregion

        #region Переключатели
        private static EПереключательПриоритет _ПереключательПриоритет = EПереключательПриоритет._0;
        public static EПереключательПриоритет ПереключательПриоритет
        {
            get { return _ПереключательПриоритет; }
            set
            {
                if (value >= EПереключательПриоритет._0 && value <= EПереключательПриоритет._9)
                {
                    _ПереключательПриоритет = value;
                }
                if (RefreshForm != null) RefreshForm();
            }
        }
        #endregion
    }
}
