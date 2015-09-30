﻿namespace R440O.R440OForms.K02M_01Inside
{
    internal class K02M_01InsideParameters
    {
        #region Событие

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

        #region Тумблер единственный на блоке

        private static bool _тумблерБ5;
        public static bool ТумблерБ5
        {
            get
            {
                return _тумблерБ5;
            }
            set
            {
                _тумблерБ5 = value;
                ResetParameters();
            }
        }

        #endregion
           
    }
}
