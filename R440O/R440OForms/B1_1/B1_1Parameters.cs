﻿namespace R440O.R440OForms.B1_1
{
    using System.Collections.Generic;
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

        public static Signal ВыходнойСигнал
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

        private static Signal НеобходимыйСигнал
        {
            get
            {
                if (!КнопкаСкоростьГР)
                    if (КнопкаСкоростьАб1ТлфК)
                        return new Signal
                        {
                            GroupSpeed = 4.8,
                            Elements = new List<SignalElement>
                            {
                                new SignalElement(new[] {-1, 2.4, 1.2, 0, 0.1, 0.1, 0.05, 0.025})
                            },
                            Level = 50
                        };
                    else
                        return new Signal
                        {
                            GroupSpeed = 4.8,
                            Elements = new List<SignalElement>
                            {
                                new SignalElement(new[] {-1, 1.2, 1.2, 1.2, 0.1, 0.1, 0.05, 0.025})
                            },
                            Level = 50
                        };

                return new Signal
                {
                    GroupSpeed = 2.4,
                    Elements = new List<SignalElement>
                            {
                                new SignalElement(new[] {-1, 0, 1.2, 0, 0.1, 0.1, 0.05, 0.025})
                            },
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
            get { return Включен && N15InsideParameters.Включен && N18_MParameters.ПереключательПРМ1 != 4; }
        }

        public static bool ЛампочкаПУЛ_2
        {
            get { return Включен && N15InsideParameters.Включен && N18_MParameters.ПереключательПРМ1 == 4; }
        }

        public static bool ЛампочкаПРСС { get; set; } 
        #endregion

        #region Каналы

        public static bool ЛампочкаТКБтк1_1
        {
            get
            {
                if (ЛампочкаТКБтк1_2 && !Signal.IsEquivalentSpeed(ВыходнойСигнал.SelectedElement.SpeedOfChanel(1),
                    НеобходимыйСигнал.SelectedElement.SpeedOfChanel(1)))
                    return true;
                return false;
            }
        }
        public static bool ЛампочкаТКБтк1_2
        {
            get
            {
                if (ВыходнойСигнал != null && НеобходимыйСигнал.SelectedElement.SpeedOfChanel(1) != 0)
                    return true;
                return false;
            }
        }
        public static bool ЛампочкаТКБтк2_1
        {
            get
            {
                if (ЛампочкаТКБтк2_2 &&
                    !Signal.IsEquivalentSpeed(ВыходнойСигнал.SelectedElement.SpeedOfChanel(2),
                    НеобходимыйСигнал.SelectedElement.SpeedOfChanel(2)))
                    return true;
                return false;
            }
        }

        public static bool ЛампочкаТКБтк2_2
        {
            get
            {
                if (ВыходнойСигнал != null && НеобходимыйСигнал.SelectedElement.SpeedOfChanel(1) != 0)
                    return true;
                return false;
            }
        }

        public static bool ЛампочкаТКБтк3_1
        {
            get
            {
                if (ЛампочкаТКБтк3_2 && 
                    !Signal.IsEquivalentSpeed(ВыходнойСигнал.SelectedElement.SpeedOfChanel(3),
                    НеобходимыйСигнал.SelectedElement.SpeedOfChanel(3)))
                    return true;
                return false;
            }
        }
        public static bool ЛампочкаТКБтк3_2
        {
            get
            {
                if (ВыходнойСигнал != null && НеобходимыйСигнал.SelectedElement.SpeedOfChanel(1) != 0)
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
                return ВыходнойСигнал != null && (!Signal.IsEquivalentSpeed
                    (ВыходнойСигнал.SelectedElement.SpeedOfChanel(1), НеобходимыйСигнал.SelectedElement.SpeedOfChanel(1))
                    || ВыходнойСигнал.SelectedElement.SpeedOfChanel(1) == 0);
            }
        }

        public static bool ЛампочкаДФАПЧ2
        {
            get
            {
                return ВыходнойСигнал != null && (!Signal.IsEquivalentSpeed
                    (ВыходнойСигнал.SelectedElement.SpeedOfChanel(2), НеобходимыйСигнал.SelectedElement.SpeedOfChanel(2))
                    || ВыходнойСигнал.SelectedElement.SpeedOfChanel(2) == 0);
            }
        }

        public static bool ЛампочкаДФАПЧ3
        {
            get
            {
                return ВыходнойСигнал != null && (!Signal.IsEquivalentSpeed
                    (ВыходнойСигнал.SelectedElement.SpeedOfChanel(3), НеобходимыйСигнал.SelectedElement.SpeedOfChanel(3))
                    || ВыходнойСигнал.SelectedElement.SpeedOfChanel(3) == 0);
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
                OnParameterChanged();
            }
        }

        public static bool КнопкаСкоростьГР
        {
            get { return _кнопкаСкоростьГР; }
            set
            {
                _кнопкаСкоростьГР = value;
                OnParameterChanged();
            }
        }

        public static bool КнопкаСкоростьАб1ТлфК
        {
            get { return _кнопкаСкоростьАб1Тлфк; }
            set
            {
                _кнопкаСкоростьАб1Тлфк = value;
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
