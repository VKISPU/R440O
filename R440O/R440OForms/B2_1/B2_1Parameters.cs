using R440O.R440OForms.B3_1;

namespace R440O.R440OForms.B2_1
{
    using N15;
    using BaseClasses;

    static class B2_1Parameters
    {
        #region Работа блока
        public static bool Включен
        {
            get
            {
                return (N15Parameters.ЛампочкаП220272 || N15Parameters.ЛампочкаП220273) &&
                       (ТумблерМуДу || !ТумблерМуДу && N15Parameters.ТумблерБ2_1);
            }
        }

        public static Signal ВходнойСигнал
        {
            get
            {
                if (Включен && B3_1Parameters.ВыходнойСигнал1 != null)
                    return B3_1Parameters.ВыходнойСигнал1;
                return null;
            }
        }

        public static Signal ВыходнойСигнал1
        {
            get
            {
                if (ВходнойСигнал == null) return null;
                var signal = ВходнойСигнал;
                signal.SelectGroup(КнопкаБК1);
                return signal;
            }
        }

        public static Signal ВыходнойСигнал2
        {
            get
            {
                if (ВходнойСигнал == null) return null;
                var signal = ВходнойСигнал;
                signal.SelectGroup(КнопкаБК2);
                return signal;
            }
        }

        #endregion

        #region Лампочки

        public static bool ЛампочкаБОЧ { get; set; }

        public static bool ЛампочкаПУЛ_1 { get { return Включен && ВходнойСигнал == null; } }
        public static bool ЛампочкаПУЛ_2 { get { return Включен && !ЛампочкаПУЛ_1; } }

        public static bool ЛампочкаПрРПрС_1
        {
            get
            {
                return Включен && !ЛампочкаПрРПрС_2;
            }
        }

        public static bool ЛампочкаПрРПрС_2
        {
            get
            {
                if (Включен && ВходнойСигнал != null)
                    return (ВходнойСигнал.Synchronization && B3_1Parameters.КолодкаОКпр1Син) ||
                           (!ВходнойСигнал.Synchronization && B3_1Parameters.КолодкаОКпр1Ас);
                return false;
            }
        }

        public static bool ЛампочкаПрРПрС_Авар
        {
            get { return Включен && ЛампочкаПрРПрС_1; }
        }

        public static bool ЛампочкаТЛГпр { get; set; }
        public static bool ЛампочкаТКСпр2 { get; set; }
        public static bool ЛампочкаДФАПЧ21
        {
            get { return Включен && ЛампочкаПрРПрС_1; }
        }
        public static bool ЛампочкаПрТС1_1
        {
            get { return Включен && ЛампочкаПрРПрС_1; }
        }
        public static bool ЛампочкаПрТС1_2
        {
            get { return Включен && (ЛампочкаПрРПрС_1 || ВыходнойСигнал1.SelectedGroupElements.Count == 0); }
        }
        public static bool ЛампочкаДФАПЧ22
        {
            get { return Включен && ЛампочкаПрРПрС_1; }
        }
        public static bool ЛампочкаПрТС2_1
        {
            get { return Включен && ЛампочкаПрРПрС_1; }
        }
        public static bool ЛампочкаПрТС2_2
        {
            get { return Включен && (ЛампочкаПрРПрС_1 || ВыходнойСигнал2.SelectedGroupElements.Count == 0); }
        }
        public static bool ЛампочкаВУП_1
        {
            get { return Включен; }
        }
        public static bool ЛампочкаВУП_Неиспр { get; set; }
        #endregion

        #region Кнопки

        private static int _кнопкаБК1;
        private static int _кнопкаБК2;
        private static bool _тумблерМуДу;
        
        public static int КнопкаБК1
        {
            get { return _кнопкаБК1; }
            set
            {
                _кнопкаБК1 = _кнопкаБК1 == value ? 0 : value;
                OnParameterChanged();
            }
        }

        public static int КнопкаБК2
        {
            get { return _кнопкаБК2; }
            set
            {
                _кнопкаБК2 = _кнопкаБК2 == value ? 0 : value;
                OnParameterChanged();
            }
        }

        /// <summary>
        /// Возможные состояния: Му - true, Ду - false
        /// </summary>
        public static bool ТумблерМуДу
        {
            get { return _тумблерМуДу; }
            set
            {
                _тумблерМуДу = value;
                N15Parameters.ResetParameters();
            }
        }
        #endregion

        #region Колодки

        private static bool _колодкаТлГпр1;
        private static bool _колодкаТлГпр2;
        private static bool _колодкаТкСпр21;
        private static bool _колодкаТкСпр22;

        public static bool КолодкаТЛГпр1
        {
            get { return _колодкаТлГпр1; }
            set
            {
                _колодкаТлГпр1 = value; 
                OnParameterChanged();
            }
        }

        public static bool КолодкаТЛГпр2
        {
            get { return _колодкаТлГпр2; }
            set
            {
                _колодкаТлГпр2 = value;
                OnParameterChanged();
            }
        }

        public static bool КолодкаТКСпр21
        {
            get { return _колодкаТкСпр21; }
            set
            {
                _колодкаТкСпр21 = value;
                OnParameterChanged();
            }
        }

        public static bool КолодкаТКСпр22
        {
            get { return _колодкаТкСпр22; }
            set
            {
                _колодкаТкСпр22 = value;
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
