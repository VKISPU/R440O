using System.Windows.Forms;
using R440O.BaseClasses;
using R440O.R440OForms.N15;
using R440O.R440OForms.N502B;

namespace R440O.R440OForms.A1
{
    public static class A1Parameters
    {
        public static bool Включен
        {
            get
            {
                return N502BParameters.ЛампочкаСфазировано && N502BParameters.ТумблерЭлектрооборудование &&
                       N502BParameters.ТумблерВыпрямитель27В &&
                       (ТумблерМуДу || !ТумблерМуДу && N15Parameters.ЛампочкаА1);
            }
        }

        public static SignalArgs ВыходнойСигнал
        {
            get
            {
                if (!Включен) return null;
                if (!КнопкаСкоростьГр)
                    if (КнопкаСкоростьАб_1ТЛФК)
                    return new SignalArgs
                    {
                        GroupSpeed = 4.8,
                        ChanelSpeed = new[] {-1, 2.4, 1.2, 0, 0.1, 0.1, 0, 0, 0, 0}
                    };
                    else return new SignalArgs
                    {
                        GroupSpeed = 4.8,
                        ChanelSpeed = new[] { -1, 1.2, 1.2, 1.2, 0.1, 0.1, 0, 0, 0, 0 }
                    };

                if (КнопкаСкоростьГр)
                    return new SignalArgs
                    {
                        GroupSpeed = 2.4,
                        ChanelSpeed = new[] { -1, 0, 1.2, 0, 0.1, 0.1, 0, 0, 0, 0 }
                    };
                return null;
            }
        }


        #region Элементы блока
        ////Лампочки
        public static bool ЛампочкаБОЧ;
        public static bool ЛампочкаФСПК;
        public static bool ЛампочкаТКААвария;
        public static bool ЛампочкаЭП1;
        public static bool ЛампочкаПУЛ1_1;
        public static bool ЛампочкаПУЛ1_2;
        public static bool ЛампочкаЭП2;
        public static bool ЛампочкаПУЛ2_1;
        public static bool ЛампочкаПУЛ2_2;
        public static bool ЛампочкаЭП3;
        public static bool ЛампочкаПУЛ3_1;
        public static bool ЛампочкаПУЛ3_2;
        public static bool ЛампочкаНеиспр;
        public static bool ЛампочкаПитание;

        // Управляющие элементы
        private static bool _тумблерМуДу;
        private static bool _кнопкаСкоростьГР;
        private static bool _кнопкаСкоростьАб_1ТЛФК;


        /// <summary>
        /// Получает или задает возможные состояния: true - местное управление, false - дистанционное управление
        /// </summary>
        public static bool ТумблерМуДу
        {
            get { return _тумблерМуДу; }
            set
            {
                _тумблерМуДу = value;
                OnParameterChanged();
            }
        }

        public static bool КнопкаСкоростьГр
        {
            get { return _кнопкаСкоростьГР; }
            set
            {
                _кнопкаСкоростьГР = value;
                OnParameterChanged();
            }
        }

        public static bool КнопкаСкоростьАб_1ТЛФК
        {
            get { return _кнопкаСкоростьАб_1ТЛФК; }
            set
            {
                _кнопкаСкоростьАб_1ТЛФК = value;
                OnParameterChanged();
            }
        } 
        #endregion

        public delegate void ParameterChangedHandler();
        public static event ParameterChangedHandler ParameterChanged;
        

        private static void OnParameterChanged()
        {
            var handler = ParameterChanged;
            if (handler != null) handler();
        }
    }
}
