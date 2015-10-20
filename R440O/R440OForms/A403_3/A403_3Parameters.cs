using R440O.R440OForms.A403_1;
using R440O.R440OForms.N15;

namespace R440O.R440OForms.A403_3
{
    class A403_3Parameters
    {
        private static bool _тумблерКомплект;

        public static bool Включен
        {
            get { return N15Parameters.НеполноеВключение; }
        }

        ////Лампочки
        public static bool Лампочка1Комплект_1 { get { return false; } }
        public static bool Лампочка1Комплект_2 { get { return false; } }
        public static bool Лампочка1Комплект_3 { get { return false; } }
        public static bool Лампочка1Комплект_4 { get { return false; } }
        public static bool Лампочка2Комплект_1 { get { return false; } }
        public static bool Лампочка2Комплект_2 { get { return false; } }
        public static bool Лампочка2Комплект_3 { get { return false; } }
        public static bool Лампочка2Комплект_4 { get { return false; } }

        ////Тумблеры
        /// <summary>
        /// Определяет номер комплекта, выбранный на блоке.
        /// true - 1 комплект; false - 2 комплект
        /// </summary>
        public static bool ТублерКомплект
        {
            get { return _тумблерКомплект; }
            set
            {
                if (Включен)
                    A403_1Parameters.Комплект = !A403_1Parameters.Комплект;
                _тумблерКомплект = value;

                OnParameterChanged();
                A403_1Parameters.ResetParameters();
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
