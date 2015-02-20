namespace R440O.Parameters
{
    class N12SParameters
    {
        #region Тумблеры
        public static bool N12SТумблерСеть = false; 
        #endregion

        #region Лампочки
        public static bool N12SЛампочкаУпорА;
        public static bool N12SЛампочкаУпорБ;
        public static bool N12SЛампочкаГотовность;
        #endregion

        //кнопка
        public static bool N12SКнопкаУскор = false;

        //индикаторы
        #region N12SIndicatorAlphaCenter
        private static float _N12SIndicatorAlphaCenter = 1;

        public static float N12SIndicatorAlphaCenter
        {
            get { return _N12SIndicatorAlphaCenter; }
            set
            {
                if (value > -1 && value < 10.5) _N12SIndicatorAlphaCenter = value;
            }
        }
        #endregion

        #region N12SIndicatorAlpha
        private static int _N12SIndicatorAlpha = 1;

        public static int N12SIndicatorAlpha
        {
            get { return _N12SIndicatorAlpha; }
            set
            {
                if (value >= -10 && value <= 370) _N12SIndicatorAlpha = value;
            }
        }
        #endregion

        #region N12SIndicatorBetaCenter
        private static float _N12SIndicatorBetaCenter = 1;

        public static float N12SIndicatorBetaCenter
        {
            get { return _N12SIndicatorBetaCenter; }
            set
            {
                if (value > -1 && value < 10.5) _N12SIndicatorBetaCenter = value;
            }
        }
        #endregion

        #region N12SIndicatorBeta
        private static int _N12SIndicatorBeta = 1;

        public static int N12SIndicatorBeta
        {
            get { return _N12SIndicatorBeta; }
            set
            {
                if (value >= 0 && value <= 90) _N12SIndicatorBeta = value;
            }
        }
        #endregion


    }
}
