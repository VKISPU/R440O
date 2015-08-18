using R440O.R440OForms.N15;

namespace R440O.R440OForms.P220_27G_2
{
    public static class P220_27G_2Parameters
    {
        ////Лампочки
        public static bool ЛампочкаНеиспр { get; set; }
        public static bool ЛампочкаПерегр { get; set; }

        public static bool ЛампочкаСеть
        {
            get { return N15Parameters.Включен && ТумблерСеть && ((ТумблерМуДу && N15Parameters.Тумблер5МГц25МГц3) || !ТумблерМуДу); }
        }

        public static bool Лампочка27В { get; set; }

        /// <summary>
        /// Определяет тип управления, выбранный на блоке. true - ДУ, false - МУ
        /// </summary>
        public static bool ТумблерМуДу
        {
            get { return _тумблерМуДу; }
            set
            {
                _тумблерМуДу = value;
                OnParameterChanged();
                N15Parameters.ResetParameters();
            }
        }

        /// <summary>
        /// true - вкл, false - выкл
        /// </summary>
        public static bool ТумблерСеть
        {
            get { return _тумблерСеть; }
            set
            {
                _тумблерСеть = value;
                OnParameterChanged();
                N15Parameters.ResetParameters();
            }
        }

        private static bool _тумблерМуДу;
        private static bool _тумблерСеть;

        public delegate void ParameterChangedHandler();
        public static event ParameterChangedHandler ParameterChanged;

        public static void ResetParameters()
        {
            OnParameterChanged();
        }

        private static void OnParameterChanged()
        {
            var handler = ParameterChanged;
            if (handler != null) handler();
        }
    }
}
