using System;
using R440O.Parameters;
using R440O.R440OForms.BMA_M_2;
using R440O.R440OForms.N15;

namespace R440O.R440OForms.BMB
{
    using N502B;
    using СостоянияЭлементов.БМБ;

    internal static class BMBParameters
    {
        #region ПереключательРаботаКонтроль

        public static int ПереключательРаботаКонтроль
        {
            get { return _переключательРаботаКонтроль; }
            set
            {
                if (value > 0 && value < 3)
                    _переключательРаботаКонтроль = value;
                ResetParameters();
            }
        }

        private static int _переключательРаботаКонтроль = 1;

        #endregion

        #region ПереключательПодключениеРезерва

        /// <summary>
        /// Положение переключателя подключение резерва
        /// </summary>
        private static int _BMBПереключательПодключениеРезерва = 1;

        public static int BMBПереключательПодключениеРезерва
        {
            get { return _BMBПереключательПодключениеРезерва; }
            set
            {
                if (value > 0 && value < 4) _BMBПереключательПодключениеРезерва = value;
                if (RefreshForm != null)
                {
                    RefreshForm();
                }
            }
        }

        /// <summary>
        /// Названия положений переключателя подключение резерва
        /// </summary>
        private static int[] BMBПоложенияПереключательПодключениеРезерва =
        {
            1,
            2,
            3
        };

        #endregion

        #region ПереключательНаправление

        /// <summary>
        /// Положение переключателя направления
        /// </summary>
        private static int _переключательНаправление = 1;

        public static int ПереключательНаправление
        {
            get { return _переключательНаправление; }
            set
            {
                if (value > 0 && value < 5) _переключательНаправление = value;
                if (RefreshForm != null)
                {
                    RefreshForm();
                }
            }
        }

        /// <summary>
        /// Названия положений переключателя направления
        /// </summary>
        private static int[] BMBПоложенияПереключательНаправление =
        {
            1,
            2,
            3,
            4
        };

        #endregion

        #region Кнопки

        public static Кнопка КнопкаПередачаВызоваТч
        {
            get
            {
                return КнопкаПитание == Кнопка.Горит
                       && _кнопкаПередачаВызоваТч == Кнопка.Нажата
                    ? Кнопка.Горит
                    : _кнопкаПередачаВызоваТч;
            }
            set
            {
                _кнопкаПередачаВызоваТч = value;
                if (RefreshForm != null) RefreshForm();
            }
        }

        private static Кнопка _кнопкаПередачаВызоваТч;

        public static Кнопка КнопкаПередачаВызоваДк
        {
            get
            {
                return КнопкаПитание == Кнопка.Горит
                       && _кнопкаПередачаВызоваДк == Кнопка.Нажата
                    ? Кнопка.Горит
                    : _кнопкаПередачаВызоваДк;
            }
            set
            {
                _кнопкаПередачаВызоваДк = value;
                if (RefreshForm != null) RefreshForm();
            }
        }

        private static Кнопка _кнопкаПередачаВызоваДк;

        public static Кнопка КнопкаСлСвязь
        {
            get
            {
                return КнопкаПитание == Кнопка.Горит
                       && _кнопкаСлСвязь == Кнопка.Нажата
                    ? Кнопка.Горит
                    : _кнопкаСлСвязь;
            }
            set
            {
                _кнопкаСлСвязь = value;
                if (RefreshForm != null) RefreshForm();
            }
        }

        private static Кнопка _кнопкаСлСвязь;

        public static Кнопка КнопкаПитание
        {
            get
            {
                return N502BParameters.ТумблерВыпрямитель27В
                       && N502BParameters.ТумблерЭлектрооборудование
                       && N502BParameters.ЛампочкаСфазировано
                       && _кнопкаПитание == Кнопка.Нажата
                    ? Кнопка.Горит
                    : _кнопкаПитание;
            }
            set
            {
                _кнопкаПитание = value;
                if (RefreshForm != null) RefreshForm();
            }
        }

        private static Кнопка _кнопкаПитание;

        public static Кнопка КнопкаЗвСигнал
        {
            get { return _кнопкаЗвСигнал; }
            set
            {
                _кнопкаЗвСигнал = value;
                if (RefreshForm != null) RefreshForm();
            }
        }

        private static Кнопка _кнопкаЗвСигнал;

        #endregion

        #region Лампочки

        public static bool ЛампочкаДк
        {
            get
            {
                return КнопкаПитание == Кнопка.Горит && КнопкаПередачаВызоваДк == Кнопка.Горит &&
                       ПереключательРаботаКонтроль == 2;
            }
        }

        private static bool _лампочкаДк;

        public static bool ЛампочкаТч
        {
            get
            {
                return КнопкаПитание == Кнопка.Горит && КнопкаПередачаВызоваТч == Кнопка.Горит &&
                       ПереключательРаботаКонтроль == 2;
            }
        }

        private static bool _лампочкаТч;



        public static bool ЛампочкаПриемВызова
        {
            get
            {
                return КнопкаПитание == Кнопка.Горит &&
                       (КнопкаПередачаВызоваТч == Кнопка.Горит || КнопкаПередачаВызоваДк == Кнопка.Горит) &&
                       ПереключательРаботаКонтроль == 2;
            }
        }

        public static bool ЛампочкаРезервВкл = false;
        public static bool ЛампочкаНаправление1 = false;
        public static bool ЛампочкаНаправление2 = false;
        public static bool ЛампочкаНаправление3 = false;
        public static bool ЛампочкаНаправление4 = false;

        #endregion

        #region НаборКоманды

        private static int[] Команда = {-1, -1};

        private static bool ПодсветкаНабора()
        {
            return КнопкаСлСвязь == Кнопка.Горит &&
                   (ПереключательРаботаКонтроль == 2 ||
                    (ПереключательРаботаКонтроль == 1 && BMA_M_1Parameters.КнопкаШлейфДк)
                    || (ПереключательРаботаКонтроль == 1 && BMA_M_2Parameters.КнопкаШлейфДк)) &&
                   ((N15Parameters.ЛампочкаБМА_1 && BMA_M_1Parameters.КнопкаПитаниеВкл && ПереключательНаправление == 1)
                    ||
                    (N15Parameters.ЛампочкаБМА_2 && BMA_M_2Parameters.КнопкаПитаниеВкл && ПереключательНаправление == 2));
        }

        public static void ДобавитьЧисло(int value)
        {
            if (ПодсветкаНабора())
            {
                if (Команда[0] != -1 && Команда[1] != -1)
                {
                    Команда = new[] {-1, -1};
                }

                if ((value < 3 && Команда[1] == -1) || Команда[0] == -1 && Команда[1] != -1)
                {
                    Команда[0] = Команда[1];
                    Команда[1] = value;
                    if (RefreshForm != null) RefreshForm();
                }
                ;
            }
        }

        public static string НаборКоманды
        {
            get
            {
                if (ПодсветкаНабора())
                {
                    var symbol1 = Команда[0] != -1 ? string.Empty + Команда[0] : "-";
                    var symbol2 = Команда[1] != -1 ? string.Empty + Команда[1] : "-";
                    return symbol1 + symbol2;
                }
                return string.Empty;
            }
        }

        #endregion

        #region ПриемКоманды

        public static string ПриемКоманды
        {
            get
            {
                return (КнопкаПередачаВызоваДк == Кнопка.Горит && ПереключательРаботаКонтроль == 2)
                    ? string.Empty + "0"
                    : string.Empty;
            }
        }

        #endregion

        public static void ResetParameters()
        {
            if (RefreshForm != null) RefreshForm();
        }

        public delegate void VoidVoidSignature();

        public static event VoidVoidSignature RefreshForm;

    }
}
