using R440O.R440OForms.C300PM_3;
using R440O.R440OForms.N502B;
using R440O.R440OForms.N15;

namespace R440O.R440OForms.A304
{
    public class A304Parameters
    {
        #region Лампочки
        /// <summary>
        /// Параметр для лампочки. Возможные состояния: true, false
        /// </summary>
        public static bool Лампочка1К
        {
            get
            {
                return _лампочка1К;
            }
            set
            {
                _лампочка1К = value;
                if (RefreshForm != null) RefreshForm();

                C300PM_3Parameters.ResetParameters();
                N15Parameters.ResetParameters();
            }
        }

        private static bool _лампочка1К = false;

        /// <summary>
        /// Параметр для лампочки. Возможные состояния: true, false
        /// </summary>
        public static bool Лампочка2К
        {
            get
            {
                return _лампочка2К;
            }

            set
            {
                _лампочка2К = value;
                if (RefreshForm != null) RefreshForm();

                C300PM_3Parameters.ResetParameters();
                N15Parameters.ResetParameters();
            }
        }

        private static bool _лампочка2К = false;
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

                if (RefreshForm != null) RefreshForm();


                ResetParameters();

                N15Parameters.ResetParameters();
                if (!value) Кнопка1К = true;


            }
        }
        private static bool _тумблерУправление1 = false;

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
                if (RefreshForm != null) RefreshForm();

                ResetParameters();
                N15Parameters.ResetParameters();

                if (!value) Кнопка2К = true;
            }
        }
        private static bool _тумблерУправление2 = false;

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
                if (RefreshForm != null) RefreshForm();
            }
        }
        private static bool _тумблерКомплект = true;
        #endregion

        #region Переключатели
        /// <summary>
        /// Положение переключателя выбора ствола
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
                    if (RefreshForm != null) RefreshForm();
                }
            }
        }
        private static int _переключательВыборСтвола = 0;
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
                    if (RefreshForm != null) RefreshForm();
                }
            }
        }
        private static int _переключательКонтроль = 0;
        #endregion

        #region Кнопки
        #region 1 комплект
        public static bool Кнопка1К
        {
            get
            {
                return _кнопка1К;
            }

            set
            {
                if (!ТумблерУправление1 && N502BParameters.ЛампочкаСфазировано && N502BParameters.ТумблерЭлектрооборудование
                && N502BParameters.ТумблерВыпрямитель27В && N502BParameters.ТумблерН15) _кнопка1К = value;
                ResetParameters();
            }
        }

        private static bool _кнопка1К = false;
        #endregion

        #region 2 Комплект
        public static bool Кнопка2К
        {
            get
            {
                return _кнопка2К;
            }

            set
            {
                if (!ТумблерУправление2 && N502BParameters.ЛампочкаСфазировано && N502BParameters.ТумблерЭлектрооборудование
                && N502BParameters.ТумблерВыпрямитель27В && N502BParameters.ТумблерН15) _кнопка2К = value;
                ResetParameters();
            }
        }

        private static bool _кнопка2К = false;
        #endregion
        #endregion

        public static int ИндикаторНапряжение
        {
            get
            {
                if ((N502BParameters.ЛампочкаСфазировано
                     && N502BParameters.ТумблерЭлектрооборудование
                     && N502BParameters.ТумблерВыпрямитель27В))
                {
                    if (N502BParameters.ТумблерН15)
                    {
                        if (ТумблерКомплект)
                        {
                            if (Лампочка1К)
                            {
                                switch (ПереключательКонтроль)
                                {
                                    case 0: return -35;
                                    case 1: return 30;
                                    case 2: return 30;
                                    case 3: return -35;
                                    case 4: return 30;
                                    case 5: return 30;
                                    case 6: return 30;
                                    case 7: return -35;
                                    case 8: return -35;
                                }
                            }
                            else
                            {
                                switch (ПереключательКонтроль)
                                {
                                    case 0: return -35;
                                    case 6: return 27;
                                    default: return 0;
                                }
                            }
                            return 0;
                        }
                        else
                        {
                            if (Лампочка2К)
                            {
                                switch (ПереключательКонтроль)
                                {
                                    case 0: return -35;
                                    case 1: return 30;
                                    case 2: return 30;
                                    case 3: return -35;
                                    case 4: return 30;
                                    case 5: return 30;
                                    case 6: return 30;
                                    case 7: return -35;
                                    case 8: return -35;
                                }
                            }
                            else
                            {
                                switch (ПереключательКонтроль)
                                {
                                    case 0: return -35;
                                    case 6: return 27;
                                    default: return 0;
                                }
                            }
                            return 0;
                        }
                    }
                    return 0;
                }
                return 0;
            }
        }

        public static void ResetParameters()
        {
            Лампочка1К = N502BParameters.ЛампочкаСфазировано && N502BParameters.ТумблерЭлектрооборудование
                && N502BParameters.ТумблерВыпрямитель27В && N502BParameters.ТумблерН15
                && ((!ТумблерУправление1 && Кнопка1К)
                || (ТумблерУправление1 && N15Parameters.ЛампочкаМШУ && N15LocalParameters.локТумблерА30412));

            Лампочка2К = N502BParameters.ЛампочкаСфазировано && N502BParameters.ТумблерЭлектрооборудование
                && N502BParameters.ТумблерВыпрямитель27В && N502BParameters.ТумблерН15
                && ((!ТумблерУправление2 && Кнопка2К)
                || (ТумблерУправление2 && N15Parameters.ЛампочкаМШУ && !N15LocalParameters.локТумблерА30412));
        }

        public delegate void VoidVoidSignature();
        public static event VoidVoidSignature RefreshForm;
    }
}
