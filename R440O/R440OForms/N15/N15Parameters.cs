using System.Linq;
using System.Windows.Forms;
using R440O.R440OForms.A306;
using R440O.R440OForms.A403_1;
using R440O.R440OForms.C300PM_3;

namespace R440O.R440OForms.N15
{
    using System;
    using Parameters;
    using A1;
    using A205M_1;
    using A205M_2;
    using N18_M;
    using N502B;
    using NKN_1;
    using NKN_2;
    using C300M_1;
    using C300M_2;
    using C300M_3;
    using C300M_4;
    using A304;
    using B1_1;
    using B2_1;
    using B3_1;
    using B1_2;
    using B2_2;
    using B3_2;
    using BMB;
    using Kontur_P3.Параметры;
    using P220_27G_2;
    using P220_27G_3;
    using СостоянияЭлементов.Контур_П;

    public static class N15Parameters
    {
        public static bool Включен
        {
            get { return N502BParameters.Н15Включен && НеполноеВключение; }
        }

        public static bool НеполноеВключение
        {
            get
            {
                return N502BParameters.ВыпрямительВключен && N502BParameters.ЭлектрообуродованиеВключено;
            }
        }

        private static double _регуляторУровень = -120;
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

        #region Кнопки
        private static bool _кнопкаСтанцияВкл;
        private static bool _кнопкаСтанцияВыкл;

        private static bool _кнопкаПрмНаведениеЦ300М1;
        private static bool _кнопкаПрмНаведениеЦ300М2;
        private static bool _кнопкаПрмНаведениеЦ300М3;
        private static bool _кнопкаПрмНаведениеЦ300М4;
        private static bool _кнопкаМощностьН16;
        private static bool _кнопкаМощностьАнт;
        private static bool _кнопкаМощностьСброс;

        private static bool _кнопкаН131;
        private static bool _кнопкаН132;
        private static bool _кнопкаН1312;
        private static bool _кнопкаСброс;

        public static bool КнопкаСтанцияВкл
        {
            get
            {
                return _кнопкаСтанцияВкл;
            }
            set
            {
                _кнопкаСтанцияВкл = value;
                OnParameterChanged();
            }
        }

        public static bool КнопкаСтанцияВыкл
        {
            get
            {
                return _кнопкаСтанцияВыкл;
            }
            set
            {
                _кнопкаСтанцияВыкл = value;
                if (value)
                {
                    A304Parameters.ResetParameters();
                    N12SParameters.ResetParameters();
                    A403_1Parameters.ResetParameters();
                }

                OnParameterChanged();
            }
        }

        public static bool КнопкаПРМНаведениеЦ300М1
        {
            get { return _кнопкаПрмНаведениеЦ300М1; }
            set
            {
                _кнопкаПрмНаведениеЦ300М1 = value;
            }
        }


        public static bool КнопкаПРМНаведениеЦ300М2
        {
            get { return _кнопкаПрмНаведениеЦ300М2; }
            set
            {
                _кнопкаПрмНаведениеЦ300М2 = value;
            }
        }

        public static bool КнопкаПРМНаведениеЦ300М3
        {
            get { return _кнопкаПрмНаведениеЦ300М3; }
            set
            {
                _кнопкаПрмНаведениеЦ300М3 = value;
            }
        }

        public static bool КнопкаПРМНаведениеЦ300М4
        {
            get { return _кнопкаПрмНаведениеЦ300М4; }
            set
            {
                _кнопкаПрмНаведениеЦ300М4 = value;
            }
        }

        public static bool КнопкаМощностьН16
        {
            get { return _кнопкаМощностьН16; }
            set
            {
                _кнопкаМощностьН16 = value;
            }
        }

        public static bool КнопкаМощностьАнт
        {
            get { return _кнопкаМощностьАнт; }
            set
            {
                _кнопкаМощностьАнт = value;
                OnParameterChanged();
            }
        }

        public static bool КнопкаМощностьСброс
        {
            get { return _кнопкаМощностьСброс; }
            set
            {
                _кнопкаМощностьСброс = value;
                OnParameterChanged();
            }
        }

        public static bool КнопкаН13_1
        {
            get { return _кнопкаН131; }
            set
            {
                _кнопкаН131 = value;
                if (value) N15LocalParameters.локКнопкаН13 = 1;
            }
        }

        public static bool КнопкаН13_2
        {
            get { return _кнопкаН132; }
            set
            {
                _кнопкаН132 = value;
                if (value) N15LocalParameters.локКнопкаН13 = 2;
            }
        }

        public static bool КнопкаН13_12
        {
            get { return _кнопкаН1312; }
            set
            {
                _кнопкаН1312 = value;
                if (value) N15LocalParameters.локКнопкаН13 = 3;
                OnParameterChanged();
            }
        }

        public static bool КнопкаСброс
        {
            get { return _кнопкаСброс; }
            set
            {
                _кнопкаСброс = value;
                OnParameterChanged();
            }
        }
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
                C300M_1Parameters.ResetParameters();
            }
        }

        public static bool ТумблерЦ300М2
        {
            get { return _тумблерЦ300М2; }
            set
            {
                _тумблерЦ300М2 = value;
                C300M_2Parameters.ResetParameters();
            }
        }

        public static bool ТумблерЦ300М3
        {
            get { return _тумблерЦ300М3; }
            set
            {
                _тумблерЦ300М3 = value;
                C300M_3Parameters.ResetParameters();
            }
        }

        public static bool ТумблерЦ300М4
        {
            get { return _тумблерЦ300М4; }
            set
            {
                _тумблерЦ300М4 = value;
                C300M_4Parameters.ResetParameters();
            }
        }

        public static bool ТумблерН12С
        {
            get { return _тумблерН12С; }
            set
            {
                _тумблерН12С = value;
                N12SParameters.ResetParameters();
            }
        }

        public static bool ТумблерМШУ
        {
            get { return _тумблерМшу; }
            set
            {
                _тумблерМшу = value;
                A304Parameters.ResetParameters();
            }
        }

        public static bool ТумблерБМА_1
        {
            get { return _тумблерБма1; }
            set
            {
                _тумблерБма1 = value;
            }
        }

        public static bool ТумблерБМА_2
        {
            get { return _тумблерБма2; }
            set
            {
                _тумблерБма2 = value;
            }
        }

        public static bool ТумблерА205Base
        {
            get { return _тумблерА205Base; }
            set
            {
                _тумблерА205Base = value;
                NKN_1Parameters.ResetParameters();
                NKN_2Parameters.ResetParameters();
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
            }
        }

        public static bool ТумблерА30412
        {
            get { return _тумблерА30412; }
            set
            {
                _тумблерА30412 = value;
                OnParameterChanged();
                A304Parameters.ResetParameters();
            }
        }

        public static bool ТумблерАФСС
        {
            get { return _тумблерАфсс; }
            set
            {
                _тумблерАфсс = value;
            }
        }

        public static bool ТумблерА1
        {
            get { return _тумблерА1; }
            set
            {
                _тумблерА1 = value;
            }
        }

        public static bool ТумблерА403
        {
            get { return _тумблерА403; }
            set
            {
                _тумблерА403 = value;
                A403_1Parameters.ResetParameters();
            }
        }

        public static bool ТумблерК1_1
        {
            get { return _тумблерК11; }
            set
            {
                _тумблерК11 = value;
            }
        }

        public static bool ТумблерК1_2
        {
            get { return _тумблерК12; }
            set
            {
                _тумблерК12 = value;
            }
        }

        public static bool ТумблерБ1_1
        {
            get { return _тумблерБ11; }
            set
            {
                _тумблерБ11 = value;
            }
        }

        public static bool ТумблерБ1_2
        {
            get { return _тумблерБ12; }
            set
            {
                _тумблерБ12 = value;
            }
        }

        public static bool ТумблерБ2_1
        {
            get { return _тумблерБ21; }
            set
            {
                _тумблерБ21 = value;
            }
        }

        public static bool ТумблерБ2_2
        {
            get { return _тумблерБ22; }
            set
            {
                _тумблерБ22 = value;
            }
        }

        public static bool ТумблерБ3_1
        {
            get { return _тумблерБ31; }
            set
            {
                _тумблерБ31 = value;
            }
        }

        public static bool ТумблерБ3_2
        {
            get { return _тумблерБ32; }
            set
            {
                _тумблерБ32 = value;
            }
        }

        public static bool ТумблерДАБ_5
        {
            get { return _тумблерДаб5; }
            set
            {
                _тумблерДаб5 = value;
            }
        }

        public static bool ТумблерР_Н
        {
            get { return _тумблерРН; }
            set
            {
                _тумблерРН = value;
            }
        }

        #endregion

        #region Тумблеры правая часть

        private static bool _тумблерА503Б;
        private static int _тумблерФаза = 0;
        private static int _тумблерУров1 = 0;
        private static int _тумблерУров2 = 0;
        private static int _тумблер5Мгц = 0;
        private static bool _тумблерАнтЭкв;
        private static bool _тумблерТлфТлгПрм;
        private static bool _тумблерТлфТлгПрд;


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

        /// <summary>
        /// Тумблер Фаза
        /// -1 - Верхнее положение
        /// 0 - Среднее положение
        /// 1 - Нижнее положение
        /// </summary>
        public static int ТумблерФаза
        {
            get { return _тумблерФаза; }
            set
            {
                _тумблерФаза = value;
            }
        }

        /// <summary>
        /// Тумблер уровень 1
        /// -1 - Верхнее положение
        /// 0 - Среднее положение
        /// 1 - Нижнее положение
        /// </summary>
        public static int ТумблерУров1
        {
            get { return _тумблерУров1; }
            set
            {
                _тумблерУров1 = value;
            }
        }

        /// <summary>
        /// Тумблер уровень 2
        /// -1 - Верхнее положение
        /// 0 - Среднее положение
        /// 1 - Нижнее положение
        /// </summary>
        public static int ТумблерУров2
        {
            get { return _тумблерУров2; }
            set
            {
                _тумблерУров2 = value;
            }
        }

        /// <summary>
        /// Тумблер 5МГЦ
        /// -1 - Верхнее положение
        /// 0 - Среднее положение
        /// 1 - Нижнее положение
        /// </summary>
        public static int Тумблер5Мгц
        {
            get { return _тумблер5Мгц; }
            set
            {
                _тумблер5Мгц = value;
                if (НеполноеВключение)
                    switch (value)
                    {
                        case -1:
                            N15LocalParameters.локТумблер5Мгц = true;
                            break;
                        case 1:
                            N15LocalParameters.локТумблер5Мгц = false;
                            break;
                    }
                OnParameterChanged();
            }
        }

        public static bool ТумблерАнтЭкв
        {
            get { return _тумблерАнтЭкв; }
            set
            {
                _тумблерАнтЭкв = value;
                N15LocalParameters.локТумблерАнтЭкв = value;
                OnParameterChanged();
            }
        }

        public static bool ТумблерТлфТлгПрм
        {
            get { return _тумблерТлфТлгПрм; }
            set
            {
                _тумблерТлфТлгПрм = value;
                OnParameterChanged();
            }
        }

        public static bool ТумблерТлфТлгПрд
        {
            get { return _тумблерТлфТлгПрд; }
            set
            {
                _тумблерТлфТлгПрд = value;
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
        public static bool ЛампочкаППВВкл1 { get { return NKN_1Parameters.ЛампочкиФаз[0]; } }
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

        public static bool ЛампочкаА205Неиспр2
        {
            get
            {
                return (N18_MParameters.ПереключательВходК121 != 1) &&
                       ((NKN_2Parameters.ЛампочкаМУ && NKN_2Parameters.Питание220Включено && N502BParameters.ТумблерН15)
                        || (NKN_2Parameters.ЛампочкаМУ && ТумблерА205Base && !ТумблерА20512));
            }
        }

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


        public static bool ЛампочкаН12С
        {
            get { return Включен && ТумблерН12С; }
        }

        public static bool ЛампочкаМШУ
        {
            get { return Включен && ТумблерМШУ; }
        }

        public static bool ЛампочкаБМА_1
        {
            get { return Включен && ЛампочкаН15БП && ТумблерБМА_1; }
        }

        public static bool ЛампочкаБМА_2
        {
            get { return Включен && ЛампочкаН15БП && ТумблерБМА_2; }
        }

        public static bool Лампочка27В
        {
            get { return НеполноеВключение; }
        }

        public static bool ЛампочкаН15БП
        {
            get { return НеполноеВключение; }
        }

        public static bool ЛампочкаАФСС
        {
            get { return Включен && ЛампочкаН15БП && ТумблерАФСС && Kontur_P3Parameters.ТумблерСеть == EТумблерСеть.ВКЛ; }
        }

        public static bool ЛампочкаА1
        {
            get { return A1Parameters.Включен; }
        }

        public static bool ЛампочкаА403Вкл
        {
            get { return Включен && A403_1Parameters.Включен; }
        }

        public static bool ЛампочкаА403Неиспр
        {
            get { return false; }
        }

        public static bool ЛампочкаП220272
        {
            get { return Включен && P220_27G_2Parameters.ЛампочкаСеть; }
        }

        public static bool ЛампочкаП220273
        {
            get { return Лампочка27В; }
        }

        public static bool ЛампочкаА306
        {
            get { return ЛампочкаМШУ; }
        }

        public static bool ЛампочкаА3041
        {
            get { return A304Parameters.Лампочка1К; }
        }

        public static bool ЛампочкаА3042
        {
            get { return A304Parameters.Лампочка2К; }
        }

        public static bool ЛампочкаБ1_1
        {
            get { return B1_1Parameters.Включен; }
        }

        public static bool ЛампочкаБ1_2
        {
            get { return B1_2Parameters.Включен; }
        }

        public static bool ЛампочкаБ2_1
        {
            get { return B2_1Parameters.Включен; }
        }

        public static bool ЛампочкаБ2_2
        {
            get { return B2_2Parameters.Включен; }
        }

        public static bool ЛампочкаБ3_1
        {
            get { return B3_1Parameters.Включен; }
        }

        public static bool ЛампочкаБ3_2
        {
            get { return B3_2Parameters.Включен; }
        }

        public static bool ЛампочкаДАБ_5
        {
            get { return Лампочка27В && ЛампочкаН15БП && ТумблерДАБ_5 && DAB_5Parameters.ТумблерПитание == СостоянияЭлементов.ДАБ5.EТумблерПитание.ВКЛ; }
        }

        public static bool ЛампочкаР_Н
        {
            get { return false; }
        }

        #endregion

        #region Лампочки правая часть

        public static bool ЛампочкаН16Н13_1
        {
            get { return N502BParameters.ВыпрямительВключен && (N15LocalParameters.локКнопкаН13 == 1); }
        }

        public static bool ЛампочкаН16Н13_2
        {
            get { return Лампочка27В && (N15LocalParameters.локКнопкаН13 == 2); }
        }

        public static bool ЛампочкаН16Н13_12
        {
            get { return Лампочка27В && (N15LocalParameters.локКнопкаН13 == 3); }
        }
        public static bool ЛампочкаН13_11Ступень { get; set; }
        public static bool ЛампочкаН13_21Ступень { get; set; }
        public static bool ЛампочкаН13_1ПолноеВкл { get; set; }
        public static bool ЛампочкаН13_2ПолноеВкл { get; set; }
        public static bool ЛампочкаН13_1Неисправность { get; set; }
        public static bool ЛампочкаН13_2Неисправность { get; set; }
        public static bool Лампочка5мГц2 { get { return НеполноеВключение && N15LocalParameters.локТумблер5Мгц; } }
        public static bool Лампочка5мГц3 { get { return НеполноеВключение && !N15LocalParameters.локТумблер5Мгц; } }

        public static bool ЛампочкаА503Б
        {
            get { return Лампочка27В && ТумблерА503Б; }
        }

        public static bool ЛампочкаАнт { get { return Лампочка27В && N15LocalParameters.локТумблерАнтЭкв; } }
        public static bool ЛампочкаЭкв { get { return Лампочка27В && !N15LocalParameters.локТумблерАнтЭкв; } }

        #endregion

        #region Обновление формы

        /// <summary>
        /// Сброс параметров для блоков без дублирующих лампочек
        /// </summary>
        public static void ResetParameters()
        {
            OnParameterChanged();
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

            ResetDiscret();
            P220_27G_2Parameters.ResetParameters();
            P220_27G_3Parameters.ResetParameters();

            #endregion

            #region ДАБ_5
            DAB_5Parameters.Refresh();
            #endregion

            N12SParameters.ResetParameters();
            A304Parameters.ResetParameters();
        }

        /// <summary>
        /// Сброс параметров для блоков с дублирующими лампочками
        /// </summary>
        public static void ResetParametersAlternative()
        {
            OnParameterChanged();
        }

        /// <summary>
        /// Отдельная перезагрузка аппаратуры Дискрет.
        /// </summary>
        public static void ResetDiscret()
        {
            A1Parameters.ResetParameters();
            B1_1Parameters.ResetParameters();
            B1_2Parameters.ResetParameters();
            B2_1Parameters.ResetParameters();
            B2_2Parameters.ResetParameters();
            B3_1Parameters.ResetParameters();
            B3_2Parameters.ResetParameters();
        }

        public delegate void ParameterChangedHandler();
        public static event ParameterChangedHandler ParameterChanged;

        private static void OnParameterChanged()
        {
            var handler = ParameterChanged;
            if (handler != null) handler();
        }
        #endregion
    }
}
