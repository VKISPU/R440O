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
                BMA_M_1Parameters.Refresh();
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
                if (value == Кнопка.Нажата)
                {
                    ОбнулитьНабор();
                    ПереданнаяКоманда = string.Empty;
                }
                _кнопкаПередачаВызоваТч = value;
                BMA_M_1Parameters.Refresh();
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
                if (value == Кнопка.Нажата)
                {
                    ОбнулитьНабор();
                    ПереданнаяКоманда = string.Empty;
                }
                _кнопкаПередачаВызоваДк = value;
                BMA_M_1Parameters.Refresh();
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
                BMA_M_1Parameters.Refresh();
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
                if (value == Кнопка.Нажата)
                {
                    ОбнулитьНабор();
                    ПереданнаяКоманда = string.Empty;
                }
                _кнопкаПитание = value;
                BMA_M_1Parameters.Refresh();
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
                return КнопкаПитание == Кнопка.Горит && КнопкаПередачаВызоваДк == Кнопка.Горит
                       && (ПереключательРаботаКонтроль == 2 ||
                           (КнопкаСлСвязь == Кнопка.Горит && БМАПодключенВерно() &&
                            (BMA_M_1Parameters.КнопкаШлейфДК || BMA_M_2Parameters.КнопкаШлейфДК)));
            }
        }

        private static bool _лампочкаДк;

        public static bool ЛампочкаТч
        {
            get
            {
                return КнопкаПитание == Кнопка.Горит && КнопкаПередачаВызоваТч == Кнопка.Горит
                       && (ПереключательРаботаКонтроль == 2 ||
                           (КнопкаСлСвязь == Кнопка.Горит && БМАПодключенВерно() &&
                            (BMA_M_1Parameters.КнопкаШлейфТЧ || BMA_M_2Parameters.КнопкаШлейфТЧ)));
            }
        }

        private static bool _лампочкаТч;



        public static bool ЛампочкаПриемВызова
        {
            get
            {
                return ЛампочкаТч || ЛампочкаДк;
            }
        }

        private static bool _лампочкаРезервВкл;

        public static bool ЛампочкаНаправление1
        {
            get { return ЛампочкаПриемВызова && ПереключательРаботаКонтроль == 1 && ПереключательНаправление == 1; }
        }

        public static bool ЛампочкаНаправление2
        {
            get { return ЛампочкаПриемВызова && ПереключательРаботаКонтроль == 1 && ПереключательНаправление == 2; }
        }

        public static bool ЛампочкаНаправление3
        {
            get { return ЛампочкаПриемВызова && ПереключательРаботаКонтроль == 1 && ПереключательНаправление == 3; }
        }

        public static bool ЛампочкаНаправление4
        {
            get { return ЛампочкаПриемВызова && ПереключательРаботаКонтроль == 1 && ПереключательНаправление == 4; }
        }

        public static bool ЛампочкаРезервВкл
        {
            get { return _лампочкаРезервВкл; }
            set { _лампочкаРезервВкл = value; }
        }

        #endregion

        #region НаборКоманды

        /// <summary>
        /// 0 - первый регистр; 1 - второй регистр;
        /// </summary>
        private static int[] Команда = {-1, -1};

        /// <summary>
        /// Правило отображения введённой команды на табло "Набор Команды"
        /// </summary>
        private static bool ПодсветкаНабора()
        {
            return КнопкаПитание == Кнопка.Горит && БМАПодключенВерно() && (ПереключательРаботаКонтроль == 2 || 
                        (КнопкаСлСвязь == Кнопка.Горит &&
                        (BMA_M_1Parameters.КнопкаШлейфДК || BMA_M_2Parameters.КнопкаШлейфДК) && БМАПодключенВерно()));
        }

        /// <summary>
        /// Проверка правильности подключения одного из блоков БМА к БМБ.
        /// </summary>
        /// <returns></returns>
        private static bool БМАПодключенВерно()
        {
            return ((N15Parameters.ЛампочкаБМА_1 && BMA_M_1Parameters.КнопкаПитаниеВКЛ && ПереключательНаправление == 1)
                    ||
                    (N15Parameters.ЛампочкаБМА_2 && BMA_M_2Parameters.КнопкаПитаниеВкл && ПереключательНаправление == 2));
        }

        /// <summary>
        /// Обнуление значени, используемых для вывода информации на табло.
        /// </summary>
        private static void ОбнулитьНабор()
        {
            Команда = new[]{-1, -1};
        }

        /// <summary>
        /// Добавление числа в команду. Число добавляется при определённых условиях.
        /// </summary>
        public static void ДобавитьЧисло(int value)
        {
            if (ПодсветкаНабора())
            {
                if (Команда[0] != -1 && Команда[1] == -1)
                    Команда[1] = value;
                else if (value < 3 && Команда[0] == -1)
                {
                    Команда[0] = value;
                } else
                if (Команда[0] != -1 && Команда[1] != -1 && value < 3)
                {
                    ПереданнаяКоманда = string.Empty;
                    Команда[0] = value;
                    Команда[1] = -1;
                }
            }
            if (RefreshForm != null) RefreshForm();
        }

        /// <summary>
        /// Обработка вывода информации на табло "Набор Команды" в соответствии с текущими значениями.
        /// </summary>
        public static string НаборКоманды
        {
            get
            {
                if (!ПодсветкаНабора() || (Команда[0] == -1 && Команда[1] == -1)) return string.Empty;
                var symbol1 = Команда[0] != -1 ? string.Empty + Команда[0] : "-";
                var symbol2 = Команда[1] != -1 ? string.Empty + Команда[1] : "-";
                return symbol1 + symbol2;
            }
        }

        #endregion

        #region ПриемКоманды

        private static string ПереданнаяКоманда;

        /// <summary>
        /// Обработка нажатия на клавишу передать команду, с правильным заннулением.
        /// </summary>
        public static void ПередатьКоманду()
        {
            if (Команда[0] == 0 && Команда[1] == 0) return;
            ПереданнаяКоманда = НаборКоманды;
            if (RefreshForm != null) RefreshForm();
        }
        
        /// <summary>
        /// Вывод информации на тамбло "Прием информации". При передаче по ДК высвечивает 0.
        /// </summary>
        public static string ПриемКоманды
        {
            get
            {
                return (КнопкаПередачаВызоваДк == Кнопка.Горит)
                    ? string.Empty + "0"
                    : ПереданнаяКоманда;
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
