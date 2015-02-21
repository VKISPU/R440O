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
        #region N12SIndicatorAlpha
        private static float _N12SIndicatorAlpha = 0;

        public static float N12SIndicatorAlpha
        {
            get { return _N12SIndicatorAlpha; }
            set
            {
                if (value >= 0 && value <= 340) _N12SIndicatorAlpha = value;
            }
        }
        #endregion


        #region N12SIndicatorBeta
        private static float _N12SIndicatorBeta = 0;

        public static float N12SIndicatorBeta
        {
            get { return _N12SIndicatorBeta; }
            set
            {
                if (value >= 0 && value <= 90) _N12SIndicatorBeta = value;
            }
        }
        #endregion

        #region N12SIndicatorBetaИ
        private static float _N12SIndicatorBetaИ = 0;

        public static float N12SIndicatorBetaИ
        {
            get { return _N12SIndicatorBetaИ; }
            set
            {
                if (value >= 0 && value <= 90) _N12SIndicatorBetaИ = value;
            }
        }
        #endregion

        #region N12SIndicatorBetaV
        private static float _N12SIndicatorBetaV = 0;

        public static float N12SIndicatorBetaV
        {
            get { return _N12SIndicatorBetaV; }
            set
            {
                if (value >= -30 && value <= 30) _N12SIndicatorBetaV = value;
            }
        }
        #endregion

        #region N12SIndicatorAlphaИ
        private static float _N12SIndicatorAlphaИ = 0;

        public static float N12SIndicatorAlphaИ
        {
            get { return _N12SIndicatorAlphaИ; }
            set
            {
                if (value >= -270 && value <= 270) _N12SIndicatorAlphaИ = value;
            }
        }
        #endregion

        #region N12SIndicatorAlphaV
        private static float _N12SIndicatorAlphaV = 0;

        public static float N12SIndicatorAlphaV
        {
            get { return _N12SIndicatorAlphaV; }
            set
            {
                if (value >= -30 && value <= 30) _N12SIndicatorAlphaV = value;
            }
        }
        #endregion

    }
}
