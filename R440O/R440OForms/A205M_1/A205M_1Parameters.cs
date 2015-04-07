using R440O.R440OForms.N18_M;
using R440O.R440OForms.N502B;
using R440O.R440OForms.NKN_1;

namespace R440O.R440OForms.A205M_1
{
    public class A205M_1Parameters
    {

        #region Private fields
        private static int _переключательВолнаX10000 = 0;
        private static int _переключательВолнаХ1000 = 0;
        private static int _переключательВолнаХ100 = 0;
        private static int _переключательВолнаХ10 = 0;
        private static int _переключательВолнаХ1 = 0;
        private static int _переключательКонтроль = 1;
        private static int _переключательВидРаботы = 1;
        private static int _переключательВходЧТ = 1;
        #endregion

        #region Работа блока
        ////Лампочки
        private static bool _лампочкаНормРаб;
        public static bool ЛампочкаНормРаб
        {
            get { return _лампочкаНормРаб; }
            set
            {
                _лампочкаНормРаб = value;
                if (RefreshForm != null) RefreshForm();
            }
        }

        public static bool ЛампочкаПерегрев;

        private static bool _тумблерКЭД;
        ////Тумблеры
        /// <summary>
        /// Получает или задает положение тумблера КЭД
        /// </summary>
        public static bool ТумблерКЭД
        {
            get { return _тумблерКЭД; }
            set
            {
                _тумблерКЭД = value;
                if (RefreshForm != null) RefreshForm();
            }
        } 
        #endregion

        #region Переключатели волны
        public static int ПереключательВолнаX10000
        {
            get { return _переключательВолнаX10000; }

            set
            {
                if (value > -1 && value < 6)
                {
                    _переключательВолнаX10000 = value;
                    if (RefreshForm != null) RefreshForm();
                }
            }
        }

        public static int ПереключательВолнаX1000
        {
            get { return _переключательВолнаХ1000; }

            set
            {
                if (value > -1 && value < 10)
                {
                    _переключательВолнаХ1000 = value;
                    if (RefreshForm != null) RefreshForm();
                }
            }
        }

        public static int ПереключательВолнаX100
        {
            get { return _переключательВолнаХ100; }

            set
            {
                if (value > -1 && value < 10)
                {
                    _переключательВолнаХ100 = value;
                    if (RefreshForm != null) RefreshForm();
                }
            }
        }

        public static int ПереключательВолнаX10
        {
            get { return _переключательВолнаХ10; }

            set
            {
                if (value > -1 && value < 10)
                {
                    _переключательВолнаХ10 = value;
                    if (RefreshForm != null) RefreshForm();
                }
            }
        }

        public static int ПереключательВолнаX1
        {
            get { return _переключательВолнаХ1; }

            set
            {
                if (value > -1 && value < 10)
                {
                    _переключательВолнаХ1 = value;
                    if (RefreshForm != null) RefreshForm();
                }
            }
        } 
        #endregion

        #region Контроль блока
        public static int ПереключательКонтроль
        {
            get { return _переключательКонтроль; }

            set
            {
                if (value > 0 && value < 11)
                {
                    _переключательКонтроль = value;
                    if (RefreshForm != null) RefreshForm();
                }
            }
        }

        /// <summary>
        /// 1 - ППВ,
        /// 2 - ГИ1,
        /// 3 - Д,
        /// 4 - ОГ,
        /// 5 - СЧ1,
        /// 6 - СЧ2,
        /// 7 - НП,
        /// 8 - ВЫХ-85,
        /// 9 - ЧТ-ВТ,
        /// 10 - ВБВ
        /// </summary>
        public static int ИндикаторКонтроль
        {
            get
            {
                if ((N502BParameters.ЛампочкаСфазировано
                     && N502BParameters.ТумблерЭлектрооборудование
                     && N502BParameters.ТумблерВыпрямитель27В))
                {
                    switch (_переключательКонтроль)
                    {
                        case 4:
                        case 7:
                            return 27;
                        case 1:
                        case 2:
                        case 3:
                        case 5:
                        case 6:
                        case 8:
                        case 9:
                        case 10:
                            return ЛампочкаНормРаб ? 27 : 0;
                    }
                }
                return 0;
            }
        }
        #endregion

        #region ПереключательВидРаботы
        /// <summary>
        /// 1 - ЧТ-200,
        /// 2 - ЧТ-20,
        /// 3 - ОФТ2,4-5,2,
        /// 4 - ОФТ48
        /// </summary>
        public static int ПереключательВидРаботы
        {
            get { return _переключательВидРаботы; }

            set
            {
                if (value > 0 && value < 5)
                {
                    _переключательВидРаботы = value;
                    if (RefreshForm != null) RefreshForm();
                }
            }
        }
        #endregion

        #region ПереключательВходЧТ
        public static int ПереключательВходЧТ
        {
            get { return _переключательВходЧТ; }

            set
            {
                if (value > 0 && value < 4)
                {
                    _переключательВходЧТ = value;
                    if (RefreshForm != null) RefreshForm();
                }
            }
        }
        #endregion

        #region Обновление переменных и формы

        public static void ResetParameters()
        {
            ЛампочкаНормРаб = NKN_1Parameters.ЛампочкиФаз[0] && (N18_MParameters.N18MПереключательВходК121 == 1);
        }

        /// <summary>
        /// Обновление показателей индикаторов
        /// </summary>
        public static void RefreshIndicators()
        {
            if (RefreshForm != null) RefreshForm();
        }

        public delegate void VoidVoidSignature();
        public static event VoidVoidSignature RefreshForm;
        #endregion
    }
}
