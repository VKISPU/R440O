namespace R440O.R440OForms.N18_M_AngleSwitch
{
    public static class N18_M_AngleSwitchParameters
    {
        public static int ГнездоПРМ1 { get; set; }
        public static int ГнездоПРМ2 { get; set; }
        public static int ГнездоПРМ3 { get; set; }
        public static int ГнездоПРМ4 { get; set; }
        public static int ГнездоК11 { get; set; }
        public static int ГнездоК12 { get; set; }

        #region Cобытие

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

        #endregion
    }
}
