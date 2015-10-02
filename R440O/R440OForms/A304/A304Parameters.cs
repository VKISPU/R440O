using System.Security.Policy;

namespace R440O.R440OForms.A304
{
    using InternalBlocks;
    using C300PM_3;
    using N502B;
    using N15;

    public static class A304Parameters
    {
        public static bool Включен
        {
            get { return N15Parameters.Включен; }
        }

        #region Лампочки
        /// <summary>
        /// Параметр для лампочки. Возможные состояния: true, false
        /// </summary>
        public static bool Лампочка1К
        {
            get
            {
                return Включен &&
                    ((!ТумблерУправление1 && Кнопка1К) ||
                     (ТумблерУправление1 && N15Parameters.ЛампочкаМШУ && N15Parameters.ТумблерА30412));
            }
        }

        /// <summary>
        /// Параметр для лампочки. Возможные состояния: true, false
        /// </summary>
        public static bool Лампочка2К
        {
            get
            {
                return Включен &&
                    ((!ТумблерУправление2 && Кнопка2К) ||
                     (ТумблерУправление2 && N15Parameters.ЛампочкаМШУ && !N15Parameters.ТумблерА30412));
            }
        }
        #endregion

        #region Тумблеры

        /// <summary>
        /// Выбор способа включения. Возможные состояния: true - Дистанционное; false - Местное;
        /// </summary>
        public static bool ТумблерУправление1
        {
            get
            {
                return _тумблерУправление1;
            }

            set
            {
                _тумблерУправление1 = value;
                Кнопка1К = (MSHUParameters.Включен && Включен && !value && N15Parameters.ТумблерА30412);
                N15Parameters.ResetParametersAlternative();
            }
        }
        private static bool _тумблерУправление1;

        /// <summary>
        /// Выбор способа включения. Возможные состояния: true - Дистанционное; false - Местное;
        /// </summary>
        public static bool ТумблерУправление2
        {
            get
            {
                return _тумблерУправление2;
            }

            set
            {
                _тумблерУправление2 = value;
                Кнопка2К = (MSHUParameters.Включен && Включен && !value && !N15Parameters.ТумблерА30412);
                N15Parameters.ResetParametersAlternative();
            }
        }
        private static bool _тумблерУправление2;

        /// <summary>
        /// Выбор комплекта оборудования. Возможные состояния: true - 1; false - 2;
        /// </summary>
        /// 
        public static bool ТумблерКомплект
        {
            get
            {
                return _тумблерКомплект;
            }

            set
            {
                _тумблерКомплект = value;
                OnParameterChanged();
            }
        }
        private static bool _тумблерКомплект = true;
        #endregion

        #region Переключатели
        /// <summary>
        /// Положение переключателя выбора ствола. 0 = 1, 1 = 2 и т.д.
        /// </summary>
        public static int ПереключательВыборСтвола
        {
            get
            {
                return _переключательВыборСтвола;
            }

            set
            {
                if (value >= 0 && value < 10)
                {
                    _переключательВыборСтвола = value;
                    OnParameterChanged();
                }
            }
        }
        private static int _переключательВыборСтвола;
        /// <summary>
        /// Положение переключателя контроля
        /// 0 - ОГ,
        /// 1 - СЧ3,
        /// 2 - ГН2,
        /// 3 - -27В,
        /// 4 - +5В,
        /// 5 - +12.6В,
        /// 6 - +27В,
        /// 7 - -5В,
        /// 8 - -12.6В.
        /// </summary>
        public static int ПереключательКонтроль
        {
            get
            {
                return _переключательКонтроль;
            }

            set
            {
                if (value >= 0 && value < 9)
                {
                    _переключательКонтроль = value;
                    OnParameterChanged();
                }
            }
        }
        private static int _переключательКонтроль;
        #endregion

        #region Кнопки

        public static bool Кнопка1К
        {
            get
            {
                return _кнопка1К;
            }

            set
            {
                if (!ТумблерУправление1 && Включен) _кнопка1К = value;
                //OnParameterChanged();
                //C300PM_3Parameters.ResetParameters();
                ResetParameters();

                N15Parameters.ResetParametersAlternative();
            }
        }

        private static bool _кнопка1К;

        public static bool Кнопка2К
        {
            get
            {
                return _кнопка2К;
            }

            set
            {
                if (!ТумблерУправление2 && Включен) _кнопка2К = value;
                //OnParameterChanged();
                //C300PM_3Parameters.ResetParameters();
                ResetParameters();

                N15Parameters.ResetParametersAlternative();
            }
        }

        private static bool _кнопка2К;

        #endregion

        public static int ИндикаторНапряжение
        {
            get
            {
                if (MSHUParameters.Включен && (Лампочка1К && ТумблерКомплект || Лампочка2К && !ТумблерКомплект))
                    switch (ПереключательКонтроль)
                    {
                        case 0:
                            return -35;
                        case 1:
                            return 30;
                        case 2:
                            return 30;
                        case 3:
                            return -35;
                        case 4:
                            return 30;
                        case 5:
                            return 30;
                        case 6:
                            return 30;
                        case 7:
                            return -35;
                        case 8:
                            return -35;
                    }
                else
                {
                    switch (ПереключательКонтроль)
                    {
                        case 0:
                            return -35;
                        case 6:
                            return 27;
                        default:
                            return 0;
                    }
                }
                return 0;
            }
        }

        public static void ResetParameters()
        {
            C300PM_3Parameters.ResetParameters();
            OnParameterChanged();
        }

        public delegate void ParameterChangedHandler();
        public static event ParameterChangedHandler ParameterChanged;

        private static void OnParameterChanged()
        {
            var handler = ParameterChanged;
            if (handler != null) handler();
        }
    }
}
