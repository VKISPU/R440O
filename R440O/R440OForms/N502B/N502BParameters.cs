using System;
using System.Windows.Forms;
using R440O.Parameters;
using R440O.R440OForms.A205M_1;
using R440O.R440OForms.NKN_1;
using R440O.R440OForms.NKN_2;
using R440O.R440OForms.PowerCabel;
using R440O.R440OForms.VoltageStabilizer;
using R440O.R440OForms.C300M_1;
using R440O.R440OForms.C300M_2;
using R440O.R440OForms.C300M_3;
using R440O.R440OForms.C300M_4;
using R440O.R440OForms.A304;
using R440O.R440OForms.N15;

namespace R440O.R440OForms.N502B
{
    public class N502BParameters
    {
        #region Лампочки
        private static bool _лампочкаСеть;

        public static bool ЛампочкаСеть
        {
            get { return _лампочкаСеть; }
            set
            {
                _лампочкаСеть = value;
                VoltageStabilizerParameters.ResetParameters();
                if (RefreshForm != null) RefreshForm();
            }
        }

        private static bool _лампочкаСфазировано;
        public static bool ЛампочкаСфазировано
        {
            get
            {
                return _лампочкаСфазировано;
            }
            set
            {
                _лампочкаСфазировано = value;
                NKN_1Parameters.ResetParameters();
                NKN_2Parameters.ResetParameters();
                BMBParameters.ResetParameters();
                A205M_1Parameters.RefreshIndicators();
                C300M_1Parameters.ResetParameters();
                C300M_2Parameters.ResetParameters();
                C300M_3Parameters.ResetParameters();
                C300M_4Parameters.ResetParameters();
                C300M_2Parameters.RefreshIndicators();
                C300M_3Parameters.RefreshIndicators();
                C300M_4Parameters.RefreshIndicators();
                N15Parameters.ResetParameters();

                A304Parameters.ResetParameters();
                if (RefreshForm != null) RefreshForm();
            }
        }

        public static bool ЛампочкаРбпПроверка;
        public static bool ЛампочкаРбпПредохранитель;

        #endregion

        #region Тумблеры

        private static bool _тумблерЭлектрооборудование;

        public static bool ТумблерЭлектрооборудование
        {
            get { return _тумблерЭлектрооборудование; }
            set
            {
                _тумблерЭлектрооборудование = value;

                if (!value) NKN_1Parameters.Питание220Включено = false;
                if (!value) NKN_2Parameters.Питание220Включено = false;

                NKN_1Parameters.ResetParameters();
                NKN_2Parameters.ResetParameters();
                N15Parameters.ResetParameters();
                C300M_1Parameters.ResetParameters();
                C300M_2Parameters.ResetParameters();
                C300M_3Parameters.ResetParameters();
                C300M_4Parameters.ResetParameters();
                C300M_2Parameters.RefreshIndicators();
                C300M_3Parameters.RefreshIndicators();
                C300M_4Parameters.RefreshIndicators();

                A304Parameters.ResetParameters();
                if (RefreshForm != null)
                    RefreshForm();
            }
        }


        private static bool _тумблерВыпрямитель27В;

        public static bool ТумблерВыпрямитель27В
        {
            get { return _тумблерВыпрямитель27В; }
            set
            {
                _тумблерВыпрямитель27В = value;

                if (!value) NKN_1Parameters.Питание220Включено = false;
                if (!value) NKN_2Parameters.Питание220Включено = false;

                NKN_1Parameters.ResetParameters();
                NKN_2Parameters.ResetParameters();
                N15Parameters.ResetParameters();
                BMBParameters.ResetParameters();
                C300M_1Parameters.ResetParameters();
                C300M_2Parameters.ResetParameters();
                C300M_3Parameters.ResetParameters();
                C300M_4Parameters.ResetParameters();

                A304Parameters.ResetParameters();
            }
        }

        private static bool _тумблерН15;
        public static bool ТумблерН15 
        {
            get { return _тумблерН15; }
            set
            {
                _тумблерН15 = value;

                if (!value) NKN_1Parameters.Питание220Включено = false;
                if (!value) NKN_2Parameters.Питание220Включено = false;

                NKN_1Parameters.ResetParameters();
                NKN_2Parameters.ResetParameters();
                N15Parameters.ResetParameters();
                C300M_1Parameters.ResetParameters();
                C300M_2Parameters.ResetParameters();
                C300M_3Parameters.ResetParameters();
                C300M_4Parameters.ResetParameters();

                A304Parameters.ResetParameters();
            }
        }

        public static bool ТумблерОсвещение = false;
        public static bool ТумблерН131 = false;
        public static bool ТумблерН132 = false;
        

        /// <summary>
        /// Тип: string
        /// Возможные состояния: 1 - Полное, 2 - Откл, 3- Дежурное
        /// </summary>
        public static int ТумблерОсвещение1 = 2;

        /// <summary>
        /// Тип: string
        /// Возможные состояния: 1- Полное, 2- Откл, 3- Частичное
        /// </summary>
        public static int ТумблерОсвещение2 = 2;

        #endregion

        #region Переключатели

        private static bool _переключательСеть;
        public static bool ПереключательСеть
        {
            get { return _переключательСеть; }
            set
            {
                _переключательСеть = value;
                ResetParameters();
                VoltageStabilizerParameters.ResetParameters();
            }
        }

        private static int _переключательНапряжение = 1;
        public static int ПереключательНапряжение
        {
            get { return _переключательНапряжение; }
            set
            {
                if (value > 0 && value < 7) 
                    _переключательНапряжение = value;
                if (RefreshForm != null)
                    RefreshForm();
            }
        }

        private static int _переключательФазировка = 1;
        public static int ПереключательФазировка
        {
            get { return _переключательФазировка; }
            set
            {
                if (value >= 0 && value <= 5) _переключательФазировка = value;
                ResetParameters();
            }
        }

        private static int _переключательКонтрольНапряжения = 2;
        public static int ПереключательКонтрольНапряжения
        {
            get { return _переключательКонтрольНапряжения; }
            set
            {
                if (value > 0 && value < 4) _переключательКонтрольНапряжения = value;
                if (RefreshForm != null)
                    RefreshForm();
            }
        }

        private static int _переключательТокНагрузкиИЗаряда = 1;
        public static int ПереключательТокНагрузкиИЗаряда
        {
            get { return _переключательТокНагрузкиИЗаряда; }
            set
            {
                if (value > 0 && value < 9) _переключательТокНагрузкиИЗаряда = value;
                if (RefreshForm != null)
                    RefreshForm();

            }
        }
        #endregion

        private static bool _кнопкаВклНагрузки;

        public static bool КнопкаВклНагрузки
        {
            get { return _кнопкаВклНагрузки; }
            set
            {
                _кнопкаВклНагрузки = value;
                if (value)
                {
                    ResetParameters();
                }
                if (RefreshForm != null)
                    RefreshForm();
            }

        }

        public static int ИндикаторНапряжение
        {
            get
            {
                if (VoltageStabilizerParameters.КабельВход != 0 && ЛампочкаСеть && ПереключательСеть &&
                    КнопкаВклНагрузки && ПереключательФазировка == 2)
                {
                    switch (ПереключательНапряжение)
                    {
                        case 1:
                        case 2:
                        case 3:
                            return VoltageStabilizerParameters.КабельВход;
                        case 4:
                        case 5:
                        case 6:
                            return 220;
                    }
                }
                if (VoltageStabilizerParameters.КабельВход != 0 && ЛампочкаСеть && ПереключательСеть &&
                    ЛампочкаСфазировано)
                {
                    switch (ПереключательНапряжение)
                    {
                        case 1:
                        case 2:
                        case 3:
                            return VoltageStabilizerParameters.КабельВход;
                        case 4:
                        case 5:
                        case 6:
                            return 220;
                    }
                }
                if (ЛампочкаСеть && ПереключательСеть &&
                    (ПереключательФазировка == 2 || ПереключательФазировка == 4))
                {
                    switch (ПереключательНапряжение)
                    {
                        case 1:
                        case 2:
                        case 3:
                            return 380;
                        case 4:
                        case 5:
                        case 6:
                            return 0;
                    }
                }
                return 0;
            }
        }

        public static int ИндикаторКонтрольНапряжения
        {
            get
            {
                if (ЛампочкаСфазировано && ПереключательКонтрольНапряжения == 1 && ТумблерЭлектрооборудование)
                    return 30;
                if (ЛампочкаСфазировано && ПереключательКонтрольНапряжения == 3 && ТумблерЭлектрооборудование)
                {
                    if (ПереключательТокНагрузкиИЗаряда == 2)
                    {
                        return 30;
                    }
                    if (ПереключательТокНагрузкиИЗаряда == 3)
                    {
                        return 20;
                    }
                    return ПереключательТокНагрузкиИЗаряда * 10 - 10;
                }
                    
                return 0;
            }
        }

        public static int ИндикаторТокНагрузкиИЗаряда
        {
            get
            {
                if (ЛампочкаСфазировано && ТумблерЭлектрооборудование)
                {
                    return ПереключательТокНагрузкиИЗаряда * 5;
                }
                    
                return 0;
            }
        }

        public delegate void VoidVoidSignature();
        public static event VoidVoidSignature RefreshForm;

        public static void ResetParameters()
        {
            ЛампочкаСеть = PowerCabelParameters.КабельСеть;
            ЛампочкаСфазировано = ПереключательФазировка == 4 && ЛампочкаСеть &&
                                  ПереключательСеть && VoltageStabilizerParameters.КабельВход == 380 && КнопкаВклНагрузки;
        }
    }
}
