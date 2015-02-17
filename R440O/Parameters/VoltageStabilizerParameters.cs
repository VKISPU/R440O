namespace R440O.Parameters
{
    public class VoltageStabilizerParameters
    {
        ////Лампочки
        /// <summary>
        /// Параметр для лампочки. Возможные состояния: true, false
        /// </summary>
        private static bool _VoltageStabilizerЛампочкаСетьВкл = false;
        public static bool VoltageStabilizerЛампочкаСетьВкл
        {
            get
            {
                return _VoltageStabilizerЛампочкаСетьВкл;
            }
            set
            {
                _VoltageStabilizerЛампочкаСетьВкл = value;
            }
        }

        /// <summary>
        /// Параметр для лампочки. Возможные состояния: true, false
        /// </summary>
        private static bool _VoltageStabilizerЛампочкаАвария = true;
        public static bool VoltageStabilizerЛампочкаАвария
        {
            get
            {
                return _VoltageStabilizerЛампочкаАвария;
            }

            set
            {
                _VoltageStabilizerЛампочкаАвария = value;
            }
        }

        #region Переключатель КонтрольНапряжения
        /// <summary>
        /// Положение переключателя Контроль напряжения
        /// </summary>
        private static int _VoltageStabilizerПереключательКонтрольНапр = 1;

        public static int VoltageStabilizerПереключательКонтрольНапр
        {
            get
            {
                return _VoltageStabilizerПереключательКонтрольНапр;
            }

            set
            {
                if (value > 0 && value < 13) _VoltageStabilizerПереключательКонтрольНапр = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя Контроля напряжения
        /// </summary>
        private static string[] VoltageStabilizerПоложенияПереключательКонтрольНапр = {
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
        public static string VoltageStabilizerКабельВход = "0";
    }
}
