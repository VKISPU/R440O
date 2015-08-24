namespace R440O.R440OForms.A1
{
    using System.Collections.Generic;
    using BaseClasses;
    using N15;

    public static class A1Parameters
    {
        #region Работа блока
        public static bool Включен
        {
            get
            {
                return (N15Parameters.ЛампочкаП220272 || N15Parameters.ЛампочкаП220273) &&
                       (ТумблерМуДу || !ТумблерМуДу && N15Parameters.ТумблерА1);
            }
        }

        public static Signal ВыходнойСигнал
        {
            get
            {
                if (!Включен) return null;
                if (!КнопкаСкоростьГр)
                    if (КнопкаСкоростьАб_1ТЛФК)
                        return new Signal
                        {
                            GroupSpeed = 4.8,
                            Elements = new List<SignalElement>()
                            {
                                new SignalElement(new [] { -1, 2.4, 1.2, 0, 0.1, 0.1, 0.05, 0.025 })
                            },
                            Level = 50
                        };
                    else return new Signal
                    {
                        GroupSpeed = 4.8,
                        Elements = new List<SignalElement>()
                            {
                                new SignalElement(new [] { -1, 1.2, 1.2, 1.2, 0.1, 0.1, 0.05, 0.025 })
                            },
                        Level = 50
                    };

                return new Signal
                    {
                        GroupSpeed = 2.4,
                        Elements = new List<SignalElement>()
                            {
                                new SignalElement(new [] { -1, 0, 1.2, 0, 0.1, 0.1, 0.05, 0.025 })
                            },
                        Level = 50
                    };
            }
        }
        
        #endregion

        #region Элементы блока
        ////Лампочки
        public static bool ЛампочкаБОЧ;

        public static bool ЛампочкаФСПК
        {
            get
            {
                return Включен;
            }
        }

        public static bool ЛампочкаТКААвария;

        #region ТЛФ1
        public static bool НаличиеТЛФ1
        {
            get
            {
                return false;
            }
        }

        public static bool ЛампочкаЭП1;

        public static bool ЛампочкаПУЛ1_1
        {
            get
            {
                return Включен && !НаличиеТЛФ1;
            }
        }

        public static bool ЛампочкаПУЛ1_2
        {
            get
            {
                return Включен && НаличиеТЛФ1;
            }
        } 
        #endregion

        #region ТЛФ2
        public static bool НаличиеТЛФ2
        {
            get
            {
                return false;
            }
        }

        public static bool ЛампочкаЭП2;

        public static bool ЛампочкаПУЛ2_1
        {
            get
            {
                return Включен && !НаличиеТЛФ2;
            }
        }

        public static bool ЛампочкаПУЛ2_2
        {
            get
            {
                return Включен && НаличиеТЛФ2;
            }
        }
        #endregion

        #region ТЛФ1
        public static bool НаличиеТЛФ3
        {
            get
            {
                return false;
            }
        }

        public static bool ЛампочкаЭП3;

        public static bool ЛампочкаПУЛ3_1
        {
            get
            {
                return Включен && !НаличиеТЛФ3;
            }
        }

        public static bool ЛампочкаПУЛ3_2
        {
            get
            {
                return Включен && НаличиеТЛФ3;
            }
        }
        #endregion

        public static bool ЛампочкаНеиспр;
        public static bool _лампочкаПитание;

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
                N15Parameters.ResetDiscret();
                OnParameterChanged();
            }
        }

        public static bool КнопкаСкоростьАб_1ТЛФК
        {
            get { return _кнопкаСкоростьАб_1ТЛФК; }
            set
            {
                _кнопкаСкоростьАб_1ТЛФК = value;
                N15Parameters.ResetDiscret();
                OnParameterChanged();
            }
        }

        public static bool ЛампочкаПитание
        {
            get { return Включен; }
        }

        #endregion

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
    }
}
