﻿using System;
using R440O.R440OForms.N15;
using R440O.R440OForms.N16;
using R440O.R440OForms.N502B;

namespace R440O.R440OForms.N13_2
{
    class N13_2Parameters
    {
        #region Лампочки
        public static bool Включен
        {
            get
            {
                return N15Parameters.Н13_2 && N502BParameters.ТумблерН13_2 && (N16Parameters.ЩелевойМостН13 == 2 || N16Parameters.ЩелевойМостН13 == 3);
            }
        }

        public static bool Неисправен
        {
            get { return N15Parameters.Н13_2 && !N502BParameters.ТумблерН13_2; }
        }
        public static bool ЛампочкаПерегрузкаИстКоллектора
        {
            get { return Неисправен; }
        }
        public static bool ЛампочкаАнодВключен
        {
            get { return Включен; }
        }


        #endregion

        #region Индикаторы

        public static float ИндикаторТокЗамедлСистемы
        {
            get { return ЛампочкаАнодВключен ? 2.5F : 0; }
        }
        public static int ИндикаторТокКоллектора
        {
            get { return ЛампочкаАнодВключен ? 170 : 0; }
        }
        #endregion

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