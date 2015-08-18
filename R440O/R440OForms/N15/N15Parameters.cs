using R440O.Parameters;
using R440O.R440OForms.A1;
using R440O.R440OForms.A205M_1;
using R440O.R440OForms.A205M_2;
using R440O.R440OForms.N18_M;
using R440O.R440OForms.N502B;
using R440O.R440OForms.NKN_1;
using R440O.R440OForms.NKN_2;
using R440O.R440OForms.C300M_1;
using R440O.R440OForms.C300M_2;
using R440O.R440OForms.C300M_3;
using R440O.R440OForms.C300M_4;
using R440O.R440OForms.A304;
using R440O.R440OForms.BMB;
using R440O.R440OForms.Kontur_P3.Параметры;
using R440O.R440OForms.P220_27G_2;
using R440O.R440OForms.P220_27G_3;
using R440O.СостоянияЭлементов.Контур_П;

namespace R440O.R440OForms.N15
{
    public static class N15Parameters
    {
        public static bool Включен
        {
            get
            {
                return N502BParameters.ЛампочкаСфазировано
                       && N502BParameters.ТумблерЭлектрооборудование
                       && N502BParameters.ТумблерВыпрямитель27В
                       && N502BParameters.ТумблерН15;
            }
        }

        #region Кнопки
        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static bool КнопкаСтанцияВкл
        {
            get
            {
                return _станцияВкл;
            }
            set
            {
                _станцияВкл = value;
                OnParameterChanged();
            }
        }
        public static bool _станцияВкл;

        public static bool КнопкаСтанцияВыкл { get; set; }

        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static bool КнопкаПРМНаведениеЦ300М1
        {
            get { return _кнопкаПрмНаведениеЦ300М1; }
            set
            {
                _кнопкаПрмНаведениеЦ300М1 = value;
                OnParameterChanged();
            }
        }

        private static bool _кнопкаПрмНаведениеЦ300М1;

        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static bool КнопкаПРМНаведениеЦ300М2
        {
            get { return _кнопкаПрмНаведениеЦ300М2; }
            set
            {
                _кнопкаПрмНаведениеЦ300М2 = value;
                OnParameterChanged();
            }
        }

        private static bool _кнопкаПрмНаведениеЦ300М2;

        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static bool КнопкаПРМНаведениеЦ300М3
        {
            get { return _кнопкаПрмНаведениеЦ300М3; }
            set
            {
                _кнопкаПрмНаведениеЦ300М3 = value;
                OnParameterChanged();
            }
        }

        private static bool _кнопкаПрмНаведениеЦ300М3;

        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static bool КнопкаПРМНаведениеЦ300М4
        {
            get { return _кнопкаПрмНаведениеЦ300М4; }
            set
            {
                _кнопкаПрмНаведениеЦ300М4 = value;
                OnParameterChanged();
            }
        }

        private static bool _кнопкаПрмНаведениеЦ300М4;

        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static bool КнопкаМощностьН16
        {
            get { return _кнопкаМощностьН16; }
            set
            {
                _кнопкаМощностьН16 = value;
                OnParameterChanged();
            }
        }

        private static bool _кнопкаМощностьН16;

        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static bool КнопкаМощностьАнт
        {
            get { return _кнопкаМощностьАнт; }
            set
            {
                _кнопкаМощностьАнт = value;
                OnParameterChanged();
            }
        }

        private static bool _кнопкаМощностьАнт;

        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static bool КнопкаМощностьСброс
        {
            get { return _кнопкаМощностьСброс; }
            set
            {
                _кнопкаМощностьСброс = value;
                OnParameterChanged();
            }
        }

        private static bool _кнопкаМощностьСброс;

        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static bool КнопкаН13_1
        {
            get { return _кнопкаН131; }
            set
            {
                _кнопкаН131 = value;
                OnParameterChanged();
            }
        }

        private static bool _кнопкаН131;

        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static bool КнопкаН13_2
        {
            get { return _кнопкаН132; }
            set
            {
                _кнопкаН132 = value;
                OnParameterChanged();
            }
        }

        private static bool _кнопкаН132;

        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static bool КнопкаН13_12
        {
            get { return _кнопкаН1312; }
            set
            {
                _кнопкаН1312 = value;
                OnParameterChanged();
            }
        }

        private static bool _кнопкаН1312;

        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static bool КнопкаСброс
        {
            get { return _кнопкаСброс; }
            set
            {
                _кнопкаСброс = value;
                OnParameterChanged();
            }
        }

        private static bool _кнопкаСброс;

        #endregion

        #region Тумблеры левая часть

        private static bool _тумблерЦ300М1;
        private static bool _тумблерЦ300М2;
        private static bool _тумблерЦ300М3;
        private static bool _тумблерЦ300М4;
        private static bool _тумблерН12С;
        private static bool _тумблерМшу;
        private static bool _тумблерБма1;
        private static bool _тумблерБма2;
        private static bool _тумблерА205Base;
        private static bool _тумблерА20512;
        private static bool _тумблерА30412;
        private static bool _тумблерАфсс;
        private static bool _тумблерА1;
        private static bool _тумблерА403;
        private static bool _тумблерК11;
        private static bool _тумблерК12;
        private static bool _тумблерБ11;
        private static bool _тумблерБ12;
        private static bool _тумблерБ21;
        private static bool _тумблерБ22;
        private static bool _тумблерБ31;
        private static bool _тумблерБ32;
        private static bool _тумблерДаб5;
        private static bool _тумблерРН;

        public static bool ТумблерЦ300М1
        {
            get { return _тумблерЦ300М1; }
            set
            {
                _тумблерЦ300М1 = value;
                if (ParameterChanged != null) ParameterChanged();
                C300M_1Parameters.ResetParameters();
            }
        }

        public static bool ТумблерЦ300М2
        {
            get { return _тумблерЦ300М2; }
            set
            {
                _тумблерЦ300М2 = value;
                if (ParameterChanged != null) ParameterChanged();
                C300M_2Parameters.ResetParameters();
            }
        }

        public static bool ТумблерЦ300М3
        {
            get { return _тумблерЦ300М3; }
            set
            {
                _тумблерЦ300М3 = value;
                if (ParameterChanged != null) ParameterChanged();
                C300M_3Parameters.ResetParameters();
            }
        }

        public static bool ТумблерЦ300М4
        {
            get { return _тумблерЦ300М4; }
            set
            {
                _тумблерЦ300М4 = value;
                if (ParameterChanged != null) ParameterChanged();
                C300M_4Parameters.ResetParameters();
            }
        }

        public static bool ТумблерН12С
        {
            get { return _тумблерН12С; }
            set
            {
                _тумблерН12С = value;
                if (ParameterChanged != null) ParameterChanged();
            }
        }

        public static bool ТумблерМШУ
        {
            get { return _тумблерМшу; }
            set
            {
                _тумблерМшу = value;
                if (ParameterChanged != null) ParameterChanged();

                ResetParameters();
                A304Parameters.ResetParameters();
            }
        }

        public static bool ТумблерБМА_1
        {
            get { return _тумблерБма1; }
            set
            {
                _тумблерБма1 = value;
                if (ParameterChanged != null) ParameterChanged();
            }
        }

        public static bool ТумблерБМА_2
        {
            get { return _тумблерБма2; }
            set { _тумблерБма2 = value; if (ParameterChanged != null) ParameterChanged(); }
        }

        public static bool ТумблерА205Base
        {
            get { return _тумблерА205Base; }
            set
            {
                _тумблерА205Base = value;
                NKN_1Parameters.ResetParameters();
                NKN_2Parameters.ResetParameters();
                if (ParameterChanged != null) ParameterChanged();
            }
        }

        public static bool ТумблерА20512
        {
            get { return _тумблерА20512; }
            set
            {
                _тумблерА20512 = value;
                NKN_1Parameters.ResetParameters();
                NKN_2Parameters.ResetParameters();
                if (ParameterChanged != null) ParameterChanged();
            }
        }

        public static bool ТумблерА30412
        {
            get { return _тумблерА30412; }
            set
            {
                _тумблерА30412 = value;
                if (ParameterChanged != null) ParameterChanged();
                A304Parameters.ResetParameters();
            }
        }

        public static bool ТумблерАФСС
        {
            get { return _тумблерАфсс; }
            set { _тумблерАфсс = value; if (ParameterChanged != null) ParameterChanged(); }
        }

        public static bool ТумблерА1
        {
            get { return _тумблерА1; }
            set { _тумблерА1 = value; if (ParameterChanged != null) ParameterChanged(); }
        }

        public static bool ТумблерА403
        {
            get { return _тумблерА403; }
            set { _тумблерА403 = value; if (ParameterChanged != null) ParameterChanged(); }
        }

        public static bool ТумблерК1_1
        {
            get { return _тумблерК11; }
            set { _тумблерК11 = value; if (ParameterChanged != null) ParameterChanged(); }
        }

        public static bool ТумблерК1_2
        {
            get { return _тумблерК12; }
            set { _тумблерК12 = value; if (ParameterChanged != null) ParameterChanged(); }
        }

        public static bool ТумблерБ1_1
        {
            get { return _тумблерБ11; }
            set { _тумблерБ11 = value; if (ParameterChanged != null) ParameterChanged(); }
        }

        public static bool ТумблерБ1_2
        {
            get { return _тумблерБ12; }
            set { _тумблерБ12 = value; if (ParameterChanged != null) ParameterChanged(); }
        }

        public static bool ТумблерБ2_1
        {
            get { return _тумблерБ21; }
            set { _тумблерБ21 = value; if (ParameterChanged != null) ParameterChanged(); }
        }

        public static bool ТумблерБ2_2
        {
            get { return _тумблерБ22; }
            set { _тумблерБ22 = value; if (ParameterChanged != null) ParameterChanged(); }
        }

        public static bool ТумблерБ3_1
        {
            get { return _тумблерБ31; }
            set { _тумблерБ31 = value; if (ParameterChanged != null) ParameterChanged(); }
        }

        public static bool ТумблерБ3_2
        {
            get { return _тумблерБ32; }
            set { _тумблерБ32 = value; if (ParameterChanged != null) ParameterChanged(); }
        }

        public static bool ТумблерДАБ_5
        {
            get { return _тумблерДаб5; }
            set { _тумблерДаб5 = value; if (ParameterChanged != null) ParameterChanged(); }
        }

        public static bool ТумблерР_Н
        {
            get { return _тумблерРН; }
            set { _тумблерРН = value; if (ParameterChanged != null) ParameterChanged(); }
        }

        #endregion

        #region Тумблеры правая часть

        private static bool _тумблерА503Б;
        private static bool _тумблерФаза;
        private static bool _тумблерУров1;
        private static bool _тумблерУров2;
        private static bool _тумблерАнтЭкв;
        private static bool _тумблерТлфТлгПрм;
        private static bool _тумблерТлфТлгПрд;
        private static bool _тумблер5МГц25МГц3;

        public static bool ТумблерА503Б
        {
            get { return _тумблерА503Б; }
            set
            {
                _тумблерА503Б = value;
                ResetParameters();
                OnParameterChanged();
            }
        }

        public static bool ТумблерФаза
        {
            get { return _тумблерФаза; }
            set { _тумблерФаза = value; OnParameterChanged(); }
        }

        public static bool ТумблерУров1
        {
            get { return _тумблерУров1; }
            set { _тумблерУров1 = value; OnParameterChanged(); }
        }

        public static bool ТумблерУров2
        {
            get { return _тумблерУров2; }
            set { _тумблерУров2 = value; OnParameterChanged(); }
        }

        public static bool ТумблерАнтЭкв
        {
            get { return _тумблерАнтЭкв; }
            set { _тумблерАнтЭкв = value; OnParameterChanged(); }
        }

        public static bool ТумблерТлфТлгПрм
        {
            get { return _тумблерТлфТлгПрм; }
            set { _тумблерТлфТлгПрм = value; OnParameterChanged(); }
        }

        public static bool ТумблерТлфТлгПрд
        {
            get { return _тумблерТлфТлгПрд; }
            set { _тумблерТлфТлгПрд = value; OnParameterChanged(); }
        }

        /// <summary>
        /// true - 2, false - 3
        /// </summary>
        public static bool Тумблер5МГц25МГц3
        {
            get { return _тумблер5МГц25МГц3; }
            set
            {
                _тумблер5МГц25МГц3 = value;
                OnParameterChanged();
            }
        }

        #endregion

        #region Лампочки верхняя часть

        public static bool ЛампочкаЦ300МВкл1
        {
            get
            {
                return Лампочка27В && ЛампочкаН15БП && ТумблерЦ300М1
                       && C300M_1Parameters.ЛампочкаПитание;
            }
        }

        public static bool ЛампочкаЦ300МВкл2 { get { return Лампочка27В && ЛампочкаН15БП && ТумблерЦ300М2; } }
        public static bool ЛампочкаЦ300МВкл3 { get { return Лампочка27В && ЛампочкаН15БП && ТумблерЦ300М3; } }
        public static bool ЛампочкаЦ300МВкл4 { get { return Лампочка27В && ЛампочкаН15БП && ТумблерЦ300М4; } }
        public static bool ЛампочкаЦ300МСигнал1 { get; set; }
        public static bool ЛампочкаЦ300МСигнал2 { get; set; }
        public static bool ЛампочкаЦ300МСигнал3 { get; set; }
        public static bool ЛампочкаЦ300МСигнал4 { get; set; }
        public static bool ЛампочкаЦ300МНеиспр1 { get; set; }
        public static bool ЛампочкаЦ300МНеиспр2 { get; set; }
        public static bool ЛампочкаЦ300МНеиспр3 { get; set; }
        public static bool ЛампочкаЦ300МНеиспр4 { get; set; }
        public static bool ЛампочкаППВВкл1 { get {return NKN_1Parameters.ЛампочкиФаз[0];} }
        public static bool ЛампочкаППВВкл2 { get { return NKN_2Parameters.ЛампочкиФаз[0]; } }
        public static bool ЛампочкаППВРабота1 { get { return A205M_1Parameters.ЛампочкаНормРаб; } }
        public static bool ЛампочкаППВРабота2 { get { return A205M_2Parameters.ЛампочкаНормРаб; } }

        public static bool ЛампочкаА205Неиспр1
        {
            get
            {
                return
                (N18_MParameters.ПереключательВходК121 != 1) &&
                ((NKN_1Parameters.ЛампочкаМУ && NKN_1Parameters.Питание220Включено && N502BParameters.ТумблерН15)
                || (NKN_1Parameters.ЛампочкаМУ && ТумблерА205Base && ТумблерА20512));
            }
        }

        public static bool ЛампочкаА205Неиспр2 { get
        {
            return (N18_MParameters.ПереключательВходК121 != 1) &&
                   ((NKN_2Parameters.ЛампочкаМУ && NKN_2Parameters.Питание220Включено && N502BParameters.ТумблерН15)
                    || (NKN_2Parameters.ЛампочкаМУ && ТумблерА205Base && !ТумблерА20512));
        } }

        public static bool ЛампочкаУМ1Работа1
        {
            get { return ТумблерА205Base && ТумблерА20512 && !ЛампочкаА205Неиспр1 && ЛампочкаППВВкл1; }
        }

        public static bool ЛампочкаУМ1Работа2
        {
            get { return ТумблерА205Base && !ТумблерА20512 && !ЛампочкаА205Неиспр2 && ЛампочкаППВВкл2; }
        }

        #endregion

        #region Лампочки левая часть

        private static bool _лампочкаН12С;
        private static bool _лампочкаМШУ;
        private static bool _лампочкаБма1;
        private static bool _лампочкаБма2;
        private static bool _лампочка27В;
        private static bool _лампочкаН15Бп;
        private static bool _лампочкаАфсс;
        private static bool _лампочкаА1;
        private static bool _лампочкаА403Вкл;
        private static bool _лампочкаА403Неиспр;
        private static bool _лампочкаП220272;
        private static bool _лампочкаП220273;
        private static bool _лампочкаА306;
        private static bool _лампочкаА3041;
        private static bool _лампочкаА3042;
        private static bool _лампочкаБ11;
        private static bool _лампочкаБ12;
        private static bool _лампочкаБ21;
        private static bool _лампочкаБ22;
        private static bool _лампочкаБ31;
        private static bool _лампочкаБ32;
        private static bool _лампочкаДаб5;
        private static bool _лампочкаРН;
        private static bool _лампочкаА503Б;
        private static double _регуляторУровень = -120;


        public static bool ЛампочкаН12С
        {
            get { return _лампочкаН12С; }
            set { _лампочкаН12С = value; }
        }

        public static bool ЛампочкаМШУ
        {
            get { return Лампочка27В && ТумблерМШУ; }
        }

        public static bool ЛампочкаБМА_1
        {
            get { return Лампочка27В && ЛампочкаН15БП && ТумблерБМА_1; }
        }

        public static bool ЛампочкаБМА_2
        {
            get { return Лампочка27В && ЛампочкаН15БП && ТумблерБМА_2; }
        }

        public static bool Лампочка27В
        {
            get
            {
                return N502BParameters.ЛампочкаСфазировано
                        && N502BParameters.ТумблерЭлектрооборудование
                        && N502BParameters.ТумблерВыпрямитель27В;
            }
        }

        public static bool ЛампочкаН15БП
        {
            get { return Включен; }
        }

        public static bool ЛампочкаАФСС
        {
            get { return Лампочка27В && ЛампочкаН15БП && ТумблерАФСС && Kontur_P3Parameters.ТумблерСеть == EТумблерСеть.ВКЛ; }
        }

        public static bool ЛампочкаА1
        {
            get { return _лампочкаА1; }
            set { _лампочкаА1 = value; }
        }

        public static bool ЛампочкаА403Вкл
        {
            get { return _лампочкаА403Вкл; }
            set { _лампочкаА403Вкл = value; }
        }

        public static bool ЛампочкаА403Неиспр
        {
            get { return _лампочкаА403Неиспр; }
            set { _лампочкаА403Неиспр = value; }
        }

        public static bool ЛампочкаП220272
        {
            get { return P220_27G_2Parameters.ЛампочкаСеть; }
        }

        public static bool ЛампочкаП220273
        {
            get { return P220_27G_3Parameters.ЛампочкаСеть; }
        }

        public static bool ЛампочкаА306
        {
            get { return ЛампочкаМШУ; }
        }

        public static bool ЛампочкаА3041
        {
            get
            {
                return ЛампочкаМШУ && A304Parameters.Лампочка1К; 
            }
        }

        public static bool ЛампочкаА3042
        {
            get { return ЛампочкаМШУ && A304Parameters.Лампочка2К; }
        }

        public static bool ЛампочкаБ1_1
        {
            get { return _лампочкаБ11; }
            set { _лампочкаБ11 = value; }
        }

        public static bool ЛампочкаБ1_2
        {
            get { return _лампочкаБ12; }
            set { _лампочкаБ12 = value; }
        }

        public static bool ЛампочкаБ2_1
        {
            get { return _лампочкаБ21; }
            set { _лампочкаБ21 = value; }
        }

        public static bool ЛампочкаБ2_2
        {
            get { return _лампочкаБ22; }
            set { _лампочкаБ22 = value; }
        }

        public static bool ЛампочкаБ3_1
        {
            get { return _лампочкаБ31; }
            set { _лампочкаБ31 = value; }
        }

        public static bool ЛампочкаБ3_2
        {
            get { return _лампочкаБ32; }
            set { _лампочкаБ32 = value; }
        }

        public static bool ЛампочкаДАБ_5
        {
            get { return _лампочкаДаб5; }
            set { _лампочкаДаб5 = value; }
        }

        public static bool ЛампочкаР_Н
        {
            get { return _лампочкаРН; }
            set { _лампочкаРН = value; }
        }

        #endregion

        #region Лампочки правая часть

        public static bool ЛампочкаН16Н13_1 { get; set; }
        public static bool ЛампочкаН16Н13_2 { get; set; }
        public static bool ЛампочкаН16Н13_12 { get; set; }
        public static bool ЛампочкаН13_11Ступень { get; set; }
        public static bool ЛампочкаН13_21Ступень { get; set; }
        public static bool ЛампочкаН13_1ПолноеВкл { get; set; }
        public static bool ЛампочкаН13_2ПолноеВкл { get; set; }
        public static bool ЛампочкаН13_1Неисправность { get; set; }
        public static bool ЛампочкаН13_2Неисправность { get; set; }
        public static bool Лампочка5мГц2 { get; set; }
        public static bool Лампочка5мГц3 { get; set; }

        public static bool ЛампочкаА503Б
        {
            get { return Лампочка27В && ТумблерА503Б; }
        }

        public static bool ЛампочкаАнт { get; set; }
        public static bool ЛампочкаЭкв { get; set; }

        #endregion

        /// <summary>
        /// Угол от -120 до 120
        /// </summary>
        public static double РегуляторУровень
        {
            get { return _регуляторУровень; }
            set
            {
                if (value > -120 && value < 120) _регуляторУровень = value;
                C300M_1Parameters.ResetParameters();
            }
        }

        public static void ResetParameters()
        {
            C300M_1Parameters.Search();

            #region БМА
            BMBParameters.ResetParameters();
            BMA_M_1Parameters.DisposeAllTimers();
            BMA_M_1Parameters.ResetLampsValue();
            BMA_M_1Parameters.Refresh();
            BMA_M_2Parameters.DisposeAllTimers();
            BMA_M_2Parameters.ResetLampsValue();
            BMA_M_2Parameters.Refresh();
            #endregion

            #region МШУ и АФСС
            A306Parameters.ResetParameters();
            Kontur_P3Parameters.ResetToDefaultsWhenTurnOnOff();
            Kontur_P3Parameters.Refresh();
            #endregion

            #region Дискрет и Генераторы
            P220_27G_2Parameters.ResetParameters();
            P220_27G_3Parameters.ResetParameters();
            #endregion

            OnParameterChanged();
        }

        public delegate void ParameterChangedHandler();

        public static event ParameterChangedHandler ParameterChanged;

        public static void OnParameterChanged()
        {
            if (ParameterChanged != null) ParameterChanged();
        }
    }
}
