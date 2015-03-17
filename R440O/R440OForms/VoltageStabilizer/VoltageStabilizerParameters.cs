namespace R440O.R440OForms.VoltageStabilizer
{
    public static class VoltageStabilizerParameters
    {
        ////Лампочки
        public static bool ЛампочкаСетьВкл;
        public static bool ЛампочкаАвария;

        #region Переключатель КонтрольНапряжения
        /// <summary>
        /// Положение переключателя Контроль напряжения
        /// </summary>
        private static int _переключательКонтрольНапр = 1;

        public static int ПереключательКонтрольНапр
        {
            get
            {
                return _переключательКонтрольНапр;
            }

            set
            {
                if (value > 0 && value < 13) _переключательКонтрольНапр = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя Контроля напряжения
        /// </summary>
        private static string[] _положенияПереключательКонтрольНапр = {
            "линейное_ca",
            "линейное_bc",
            "линейное_ab",
            "вход220_AB",
            "вход220_BC",
            "вход220_CA",
            "вход380_AB",
            "вход380_BC",
            "вход380_CA",
            "фазное_0с",
            "фазное_0b",
            "фазное_0a"
        };
        #endregion

        ////Кабель
        /// <summary>
        /// Возможные состояния: 220, 380, 0
        /// </summary>
        public static int КабельВход;

        public static int ИндикаторНапряжение;
    }
}
