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


    }
}
