using R440O.R440OForms.B2_1;

namespace R440O.R440OForms.B3_1
{
    using BaseClasses;
    using N15;
    using N15Inside;
    using N18_M;

    class B3_1Parameters
    {
        #region Работа блока
        public static bool Включен
        {
            get
            {
                return (N15Parameters.ЛампочкаП220272 || N15Parameters.ЛампочкаП220273) &&
                       (ТумблерМуДу || !ТумблерМуДу && N15Parameters.ТумблерБ3_1);
            }
        }

        public static Signal ВходнойСигнал
        {
            get
            {
                if (Включен &&
                    N15InsideParameters.ВыходПриемногоТракта != null &&
                    N18_MParameters.ПереключательПРМ1 == 1 &&
                    ПравильнаяКолодка(N15InsideParameters.ВыходПриемногоТракта.GroupSpeed))
                    return N15InsideParameters.ВыходПриемногоТракта;
                return null;
            }
        }

        public static Signal ВыходнойСигнал1
        {
            get
            {
                if (ВходнойСигнал == null) return null;
                var signal = ВходнойСигнал;
                signal.Select(КолодкаУКК1);
                return signal;
            }
        }

        public static Signal ВыходнойСигнал2
        {
            get
            {
                if (ВходнойСигнал == null) return null;
                var signal = ВходнойСигнал;
                signal.Select(КолодкаУКК2);
                return signal;
            }
        }

        private static bool ПравильнаяКолодка(double groupSpeed)
        {
            switch (КолодкаКРПР)
            {
                case 1:
                    return groupSpeed == 480;
                case 2:
                    return groupSpeed == 240;
                case 3:
                    return groupSpeed == 144;
                case 4:
                    return groupSpeed == 96;
                case 5:
                    return groupSpeed == 48;
            }
            return false;
        }

        #endregion

        #region Лампочки

        public static bool ЛампочкаПУЛГ_1
        {
            get { return Включен && !ЛампочкаПУЛГ_2; }
        }

        public static bool ЛампочкаПУЛГ_2
        {
            get { return Включен && N15InsideParameters.Включен && N18_MParameters.ПереключательПРМ1 == 1
                && КолодкаКРПР != 5; }
        }

        public static bool ЛампочкаПРИавар
        {
            get
            {
                return Включен &&
                    КолодкаУКК1 == 0 &&
                    КолодкаУКК2 == 0 &&
                    !КолодкаОКпр1Ас && !КолодкаОКпр2Ас &&
                    !КолодкаОКпр1Син && !КолодкаОКпр2Син &&
                    !КолодкаТлГпр11 && !КолодкаТлГпр12 &&
                    !КолодкаТлГпр21 && !КолодкаТлГпр22 &&
                    !КолодкаТлГпр31 && !КолодкаТлГпр32;
            }
        }

        public static bool ЛампочкаРС_1
        {
            get { return Включен && !ЛампочкаРС_синхр; }
        }

        public static bool ЛампочкаРС_синхр
        {
            get { return Включен && ВходнойСигнал != null; }
        }

        public static bool ЛампочкаТЛГпр1 { get; set; }
        public static bool ЛампочкаТЛГпр2 { get; set; }
        public static bool ЛампочкаТЛГпр3 { get; set; }

        public static bool ЛампочкаОКпр1
        {
            get { return ЛампочкаРС_синхр && ВыходнойСигнал1.SelectedElement == null; }
        }

        public static bool ЛампочкаПФТК1_1 { get { return ЛампочкаРС_1; } }
        public static bool ЛампочкаПФТК1_2 { get { return ЛампочкаПУЛГ_2 && !ЛампочкаОКпр1; } }

        public static bool ЛампочкаОКпр2
        {
            get { return ЛампочкаРС_синхр && ВыходнойСигнал2.SelectedElement == null; }
        }
        public static bool ЛампочкаПФТК2_1 { get { return ЛампочкаРС_1; } }
        public static bool ЛампочкаПФТК2_2 { get { return ЛампочкаПУЛГ_2 && !ЛампочкаОКпр2; } }
        public static bool ЛампочкаВУПнеиспр { get; set; }

        public static bool ЛампочкаВУП1
        {
            get
            {
                return Включен;
            }
        }

        #endregion

        #region Колодки

        private static int _колодкаКРПР;
        public static int КолодкаКРПР
        {
            get { return _колодкаКРПР; }
            set
            {
                if (value >= 0 && value <= 5) _колодкаКРПР = value;
                B2_1Parameters.ResetParameters();
                OnParameterChanged();
            }
        }

        private static int _колодкаУКК1;
        public static int КолодкаУКК1
        {
            get { return _колодкаУКК1; }
            set
            {
                if (value >= 0 && value <= 9) _колодкаУКК1 = value;
                B2_1Parameters.ResetParameters();
                OnParameterChanged();
            }
        }

        private static int _колодкаУКК2;
        public static int КолодкаУКК2
        {
            get { return _колодкаУКК2; }
            set
            {
                if (value >= 0 && value <= 9) _колодкаУКК2 = value;
                OnParameterChanged();
            }
        }

        public static bool КолодкаОКпр1Син
        {
            get { return _колодкаОКпр1Син; }
            set
            {
                _колодкаОКпр1Син = value;
                B2_1Parameters.ResetParameters();
                OnParameterChanged();
            }
        }

        public static bool КолодкаОКпр1Ас
        {
            get { return _колодкаОКпр1Ас; }
            set
            {
                _колодкаОКпр1Ас = value;
                B2_1Parameters.ResetParameters();
                OnParameterChanged();
            }
        }

        public static bool КолодкаОКпр2Син
        {
            get { return _колодкаОКпр2Син; }
            set
            {
                _колодкаОКпр2Син = value;
                B2_1Parameters.ResetParameters();
                OnParameterChanged();
            }
        }

        public static bool КолодкаОКпр2Ас
        {
            get { return _колодкаОКпр2Ас; }
            set
            {
                _колодкаОКпр2Ас = value;
                B2_1Parameters.ResetParameters();
                OnParameterChanged();
            }
        }

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

        private static bool _тумблерМуДу;
        private static bool _колодкаОКпр1Син;
        private static bool _колодкаОКпр1Ас;
        private static bool _колодкаОКпр2Син;
        private static bool _колодкаОКпр2Ас;
        private static bool _колодкаТлГпр11;
        private static bool _колодкаТлГпр12;
        private static bool _колодкаТлГпр21;
        private static bool _колодкаТлГпр22;
        private static bool _колодкаТлГпр31;
        private static bool _колодкаТлГпр32;

        #endregion

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
