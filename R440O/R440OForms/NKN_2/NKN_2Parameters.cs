using R440O.R440OForms.A205M_2;
using R440O.R440OForms.N15;
using R440O.R440OForms.N502B;

namespace R440O.R440OForms.NKN_2
{
    /// <summary>
    /// Параметры блока НКН-1
    /// </summary>
    public static class NKN_2Parameters
    {
        private static bool _дистанционноеВключение;

        public static bool ДистанционноеВключение
        {
            get { return _дистанционноеВключение; }
            set
            {
                _питание220Включено = value;
                _дистанционноеВключение = value;
            }
        }

        private static bool _неполноеВключение;

        public static bool НеполноеВключение
        {
            get { return _неполноеВключение && N502BParameters.ВыпрямительВключен && N502BParameters.ЭлектрообуродованиеВключено; }
            set { _неполноеВключение = value; }
        }

        public static bool Включен
        {
            get { return (ЛампочкаМУ && N15Parameters.Включен && Питание220Включено); }
        }

        public static bool ЛампочкаМУ
        {
            get { return N502BParameters.ВыпрямительВключен; }
        }

        public static bool ЛампочкаФаза1
        {
            get { return Включен; }
        }

        public static bool ЛампочкаФаза2
        {
            get { return Включен; }
        }

        public static bool ЛампочкаФаза3
        {
            get { return Включен; }
        }

        private static bool _питание220Включено;

        public static bool Питание220Включено
        {
            get { return _питание220Включено; }
            set
            {
                _питание220Включено = value;
                НеполноеВключение = N15Parameters.НеполноеВключение && Питание220Включено;
                OnParameterChanged();
                N15Parameters.ResetParametersAlternative();
                A205M_2Parameters.ResetParameters();
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
