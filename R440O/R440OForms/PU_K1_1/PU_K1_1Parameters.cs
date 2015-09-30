namespace R440O.Parameters
{
    internal class PU_K1_1Parameters
    {
        #region событие

        public delegate void ParameterChangedHandler();
        public static event ParameterChangedHandler ParameterChanged;

        private static void OnParameterChanged()
        {
            var handler = ParameterChanged;
            if (handler != null) handler();
        }

        public static void ResetParameters()
        {
            OnParameterChanged();
        }

        #endregion

        #region Лампочка
        ////Лампочки
        private static bool _ЛампочкаCеть;

        public static bool ЛампочкаCеть
        {
            get { return _ЛампочкаCеть; }
        }

        #endregion
        
        #region Тумблеры
        ////Тумблеры 
        /// <summary>
        /// Возможные состояния: 0. Дист - дистанционное управление, 1. Откл - отключено, 2. Мест - местное управление.
        /// </summary>
        private static int _ТумблерПитание = 1;
        public static int ТумблерПитание
        {
            get { return _ТумблерПитание; }

            set
            {
                if (value >= 0 && value <= 2)
                {
                    _ТумблерПитание = value;
                   // _ЛампочкаCеть = _ТумблерПитание == 0;
                     ResetParameters();
                }
            }
        }

        private static bool _ТумблерВентВкл = false;

        public static bool ТумблерВентВкл
        {
            get { return _ТумблерВентВкл; }
            set
            {
                _ТумблерВентВкл = value;
                ResetParameters();
            }
        }
        #endregion

        #region Переключатели
        /// <summary>
        /// Положение переключателя контроля
        /// </summary>
        private static int _ПереключательКаналы = 1;

        public static int ПереключательКаналы
        {
            get
            {
                return _ПереключательКаналы;
            }

            set
            {
                if (value > 0 && value < 5)
                {
                    _ПереключательКаналы = value;
                    ResetParameters();
                }
            }
        }

        /// <summary>
        /// Положение переключателя контроля
        /// </summary>
        private static int _ПереключательНапряжение = 1;

        public static int ПереключательНапряжение
        {
            get
            {
                return _ПереключательНапряжение;
            }

            set
            {
                if (value > 0 && value < 13)
                {
                    _ПереключательНапряжение = value;
                    ResetParameters();
                }
            }
        }

        // Какой-то трэш
        /*
        /// <summary>
        /// Названия положений переключателя контроля. Второй столбец - комплект включён. Третий - комплект выключен.
        /// </summary>
        public static string[,] _ЗначенияПереключательНапряжение = { 
            { "-27", "0" },
            { "-12,6", "0" },
            { "-5", "0" },
            { "+5", "0" },
            { "+6", "0" },
            { "+12,6 I", "0" },
            { "+12,6 III", "0" },
            { "+23 I", "0" },
            { "+23 II", "0" },
            { "+60 I", "0" },
            { "+60 II", "0" },
            { "+120", "0" }
        };
        /// <summary>
        /// Названия положений переключателя контроля. Второй столбец - комплект включён. Третий - комплект выключен.
        /// </summary>
           public static string[,] _ЗначенияПереключательКаналы = { 
                { "ПРМ 1", "0" },
                { "ПРМ 2", "0" },
                { "ПРД 1", "0" },
                { "ПРД 2", "0" }
            };
         */
        #endregion
    }
}
