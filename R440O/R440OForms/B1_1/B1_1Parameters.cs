using System;
using R440O.ThirdParty;

namespace R440O.R440OForms.B1_1
{
    using N15Inside;
    using N18_M;
    using BaseClasses;
    using N15;

    public static class B1_1Parameters
    {
        #region Работа блока

        public static bool Включен
        {
            get
            {
                return (N15Parameters.ЛампочкаП220272 || N15Parameters.ЛампочкаП220273) &&
                       (ТумблерМуДу || !ТумблерМуДу && N15Parameters.ТумблерБ1_1);
            }
        }

        public static SignalArgs ВыходнойСигнал
        {
            get
            {
                if (Включен &&
                    N15InsideParameters.ВыходПриемногоТракта != null &&
                    N18_MParameters.ПереключательПРМ1 == 4)
                    return N15InsideParameters.ВыходПриемногоТракта;
                return null;
            }
        }

        private static SignalArgs НеобходимыйСигнал
        {
            get
            {
                if (!КнопкаСкоростьГР)
                    if (КнопкаСкоростьАб1ТлфК)
                        return new SignalArgs
                        {
                            GroupSpeed = 4.8,
                            ChanelSpeed = new[] {-1, 2.4, 1.2, 0, 0.1, 0.1, 0.05, 0.025},
                            Level = 50
                        };
                    else
                        return new SignalArgs
                        {
                            GroupSpeed = 4.8,
                            ChanelSpeed = new[] {-1, 1.2, 1.2, 1.2, 0.1, 0.1, 0.05, 0.025},
                            Level = 50
                        };

                return new SignalArgs
                {
                    GroupSpeed = 2.4,
                    ChanelSpeed = new[] {-1, 0, 1.2, 0, 0.1, 0.1, 0.05, 0.025},
                    Level = 50
                };
            }
        }



        #endregion

        private static bool _тумблерМуДу;
        private static bool _кнопкаСкоростьГР;
        private static bool _кнопкаСкоростьАб1Тлфк;
        private static bool _колодкаТлГпр11;
        private static bool _колодкаТлГпр12;
        private static bool _колодкаТлГпр21;
        private static bool _колодкаТлГпр22;
        private static bool _колодкаТлГпр31;
        private static bool _колодкаТлГпр32;

        #region Лампочки

        #region Левые
        public static bool ЛампочкаБОЧ { get; set; }

        public static bool ЛампочкаПУЛ_1
        {
            get { return Включен && ВыходнойСигнал == null; }
        }

        public static bool ЛампочкаПУЛ_2
        {
            get { return Включен && ВыходнойСигнал != null; }
        }

        public static bool ЛампочкаПРСС { get; set; } 
        #endregion

        #region Каналы

        public static bool ЛампочкаТКБтк1_1
        {
            get
            {
                if (ЛампочкаТКБтк1_2 &&
                    !SpeedTester.IsEquivalent(ВыходнойСигнал.ChanelSpeed[1], НеобходимыйСигнал.ChanelSpeed[1]))
                    return true;
                return false;
            }
        }
        public static bool ЛампочкаТКБтк1_2
        {
            get
            {
                if (ВыходнойСигнал != null && НеобходимыйСигнал.ChanelSpeed[1] != 0)
                    return true;
                return false;
            }
        }
        public static bool ЛампочкаТКБтк2_1
        {
            get
            {
                if (ЛампочкаТКБтк2_2 &&
                    !SpeedTester.IsEquivalent(ВыходнойСигнал.ChanelSpeed[2], НеобходимыйСигнал.ChanelSpeed[2]))
                    return true;
                return false;
            }
        }

        public static bool ЛампочкаТКБтк2_2
        {
            get
            {
                if (ВыходнойСигнал != null && НеобходимыйСигнал.ChanelSpeed[2] != 0)
                    return true;
                return false;
            }
        }

        public static bool ЛампочкаТКБтк3_1
        {
            get
            {
                if (ЛампочкаТКБтк3_2 &&
                    !SpeedTester.IsEquivalent(ВыходнойСигнал.ChanelSpeed[3], НеобходимыйСигнал.ChanelSpeed[3]))
                    return true;
                return false;
            }
        }
        public static bool ЛампочкаТКБтк3_2
        {
            get
            {
                if (ВыходнойСигнал != null && НеобходимыйСигнал.ChanelSpeed[3] != 0)
                    return true;
                return false;
            }
        }
        public static bool ЛампочкаТКБАвар { get; set; } 
        #endregion

        #region Эластичная память
        public static bool ЛампочкаДФАПЧ1
        {
            get
            {
                return ВыходнойСигнал != null && (!SpeedTester.IsEquivalent
                    (ВыходнойСигнал.ChanelSpeed[1], НеобходимыйСигнал.ChanelSpeed[1])
                    || ВыходнойСигнал.ChanelSpeed[1] == 0);
            }
        }

        public static bool ЛампочкаДФАПЧ2
        {
            get
            {
                return ВыходнойСигнал != null && (!SpeedTester.IsEquivalent
                    (ВыходнойСигнал.ChanelSpeed[2], НеобходимыйСигнал.ChanelSpeed[2])
                    || ВыходнойСигнал.ChanelSpeed[2] == 0);
            }
        }

        public static bool ЛампочкаДФАПЧ3
        {
            get
            {
                return ВыходнойСигнал != null && (!SpeedTester.IsEquivalent
                    (ВыходнойСигнал.ChanelSpeed[3], НеобходимыйСигнал.ChanelSpeed[3])
                                                  || ВыходнойСигнал.ChanelSpeed[3] == 0);
            }
        } 
        #endregion

        public static bool ЛампочкаТЛГпр1 { get; set; }
        public static bool ЛампочкаТЛГпр2 { get; set; }
        public static bool ЛампочкаТЛГпр3 { get; set; }
        public static bool ЛампочкаВУП_1 { get { return Включен; } }
        public static bool ЛампочкаВУПНеиспр { get; set; }

        #endregion

        #region Колодки

        public static bool КолодкаТлГпр11
        {
            get { return _колодкаТлГпр11; }
            set
            {
                _колодкаТлГпр11 = value; 
                OnParameterChanged();
            }
        }

        public static bool КолодкаТлГпр12
        {
            get { return _колодкаТлГпр12; }
            set
            {
                _колодкаТлГпр12 = value;
                OnParameterChanged();
            }
        }

        public static bool КолодкаТлГпр21
        {
            get { return _колодкаТлГпр21; }
            set
            {
                _колодкаТлГпр21 = value;
                OnParameterChanged();
            }
        }

        public static bool КолодкаТлГпр22
        {
            get { return _колодкаТлГпр22; }
            set
            {
                _колодкаТлГпр22 = value;
                OnParameterChanged();
            }
        }

        public static bool КолодкаТлГпр31
        {
            get { return _колодкаТлГпр31; }
            set
            {
                _колодкаТлГпр31 = value;
                OnParameterChanged();
            }
        }

        public static bool КолодкаТлГпр32
        {
            get { return _колодкаТлГпр32; }
            set
            {
                _колодкаТлГпр32 = value;
                OnParameterChanged();
            }
        }

        #endregion

        #region Тумблеры и Кнопки
        /// <summary>
        /// Возможные состояния: Му - true, Ду - false
        /// </summary>
        public static bool ТумблерМуДу
        {
            get { return _тумблерМуДу; }
            set
            {
                _тумблерМуДу = value;
                CheckTimer();
                OnParameterChanged();
            }
        }

        public static bool КнопкаСкоростьГР
        {
            get { return _кнопкаСкоростьГР; }
            set
            {
                _кнопкаСкоростьГР = value;
                CheckTimer();
                OnParameterChanged();
            }
        }

        public static bool КнопкаСкоростьАб1ТлфК
        {
            get { return _кнопкаСкоростьАб1Тлфк; }
            set
            {
                _кнопкаСкоростьАб1Тлфк = value;
                CheckTimer();
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

        public static void ResetParameters()
        {
            OnParameterChanged();
        }
    }
}
