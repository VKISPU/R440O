namespace R440O.R440OForms.N15
{
    public static class N15Parameters
    {
        #region Кнопки

        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static bool КнопкаСтанцияВкл { get; set; }

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
                if (RefreshForm != null) RefreshForm();
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
                if (RefreshForm != null) RefreshForm();
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
                if (RefreshForm != null) RefreshForm();
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
                if (RefreshForm != null) RefreshForm();
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
                if (RefreshForm != null) RefreshForm();
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
                if (RefreshForm != null) RefreshForm();
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
                if (RefreshForm != null) RefreshForm();
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
                if (RefreshForm != null) RefreshForm();
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
                if (RefreshForm != null) RefreshForm();
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
                if (RefreshForm != null) RefreshForm();
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
                if (RefreshForm != null) RefreshForm();
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
        private static bool _тумблерА205;
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
                if (RefreshForm != null) RefreshForm();
            }
        }
        
        public static bool ТумблерЦ300М2
        {
            get { return _тумблерЦ300М2; }
            set
            {
                _тумблерЦ300М2 = value;
                if (RefreshForm != null) RefreshForm();
            }
        }
        
        public static bool ТумблерЦ300М3
        {
            get { return _тумблерЦ300М3; }
            set
            {
                _тумблерЦ300М3 = value;
                if (RefreshForm != null) RefreshForm();
            }
        }
        
        public static bool ТумблерЦ300М4
        {
            get { return _тумблерЦ300М4; }
            set
            {
                _тумблерЦ300М4 = value;
                if (RefreshForm != null) RefreshForm();
            }
        }
        
        public static bool ТумблерН12С
        {
            get { return _тумблерН12С; }
            set
            {
                _тумблерН12С = value;
                if (RefreshForm != null) RefreshForm();
            }
        }
        
        public static bool ТумблерМШУ
        {
            get { return _тумблерМшу; }
            set
            {
                _тумблерМшу = value;
                if (RefreshForm != null) RefreshForm();
            }
        }
        
        public static bool ТумблерБМА_1
        {
            get { return _тумблерБма1; }
            set
            {
                _тумблерБма1 = value;
                if (RefreshForm != null) RefreshForm();
            }
        }

        public static bool ТумблерБМА_2
        {
            get { return _тумблерБма2; }
            set { _тумблерБма2 = value; if (RefreshForm != null) RefreshForm(); }
        }
        
        public static bool ТумблерА205
        {
            get { return _тумблерА205; }
            set { _тумблерА205 = value; if (RefreshForm != null) RefreshForm(); }
        }
        
        public static bool ТумблерА20512
        {
            get { return _тумблерА20512; }
            set { _тумблерА20512 = value; if (RefreshForm != null) RefreshForm(); }
        }
        
        public static bool ТумблерА30412
        {
            get { return _тумблерА30412; }
            set
            {
                _тумблерА30412 = value;
                if (RefreshForm != null) RefreshForm();
            }
        }
        
        public static bool ТумблерАФСС
        {
            get { return _тумблерАфсс; }
            set { _тумблерАфсс = value; if (RefreshForm != null) RefreshForm(); }
        }
        
        public static bool ТумблерА1
        {
            get { return _тумблерА1; }
            set { _тумблерА1 = value; if (RefreshForm != null) RefreshForm(); }
        }

        public static bool ТумблерА403
        {
            get { return _тумблерА403; }
            set { _тумблерА403 = value; if (RefreshForm != null) RefreshForm(); }
        }

        public static bool ТумблерК1_1
        {
            get { return _тумблерК11; }
            set { _тумблерК11 = value; if (RefreshForm != null) RefreshForm(); }
        }

        public static bool ТумблерК1_2
        {
            get { return _тумблерК12; }
            set { _тумблерК12 = value; if (RefreshForm != null) RefreshForm(); }
        }
        
        public static bool ТумблерБ1_1
        {
            get { return _тумблерБ11; }
            set { _тумблерБ11 = value; if (RefreshForm != null) RefreshForm(); }
        }
        
        public static bool ТумблерБ1_2
        {
            get { return _тумблерБ12; }
            set { _тумблерБ12 = value; if (RefreshForm != null) RefreshForm(); }
        }
        
        public static bool ТумблерБ2_1
        {
            get { return _тумблерБ21; }
            set { _тумблерБ21 = value; if (RefreshForm != null) RefreshForm(); }
        }
        
        public static bool ТумблерБ2_2
        {
            get { return _тумблерБ22; }
            set { _тумблерБ22 = value; if (RefreshForm != null) RefreshForm(); }
        }
        
        public static bool ТумблерБ3_1
        {
            get { return _тумблерБ31; }
            set { _тумблерБ31 = value; if (RefreshForm != null) RefreshForm(); }
        }
        
        public static bool ТумблерБ3_2
        {
            get { return _тумблерБ32; }
            set { _тумблерБ32 = value; if (RefreshForm != null) RefreshForm(); }
        }
        
        public static bool ТумблерДАБ_5
        {
            get { return _тумблерДаб5; }
            set { _тумблерДаб5 = value; if (RefreshForm != null) RefreshForm(); }
        }
        
        public static bool ТумблерР_Н
        {
            get { return _тумблерРН; }
            set { _тумблерРН = value; if (RefreshForm != null) RefreshForm(); }
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
            set { _тумблерА503Б = value; if (RefreshForm != null) RefreshForm(); }
        }

        public static bool ТумблерФаза
        {
            get { return _тумблерФаза; }
            set { _тумблерФаза = value; if (RefreshForm != null) RefreshForm(); }
        }

        public static bool ТумблерУров1
        {
            get { return _тумблерУров1; }
            set { _тумблерУров1 = value; if (RefreshForm != null) RefreshForm(); }
        }

        public static bool ТумблерУров2
        {
            get { return _тумблерУров2; }
            set { _тумблерУров2 = value; if (RefreshForm != null) RefreshForm(); }
        }

        public static bool ТумблерАнтЭкв
        {
            get { return _тумблерАнтЭкв; }
            set { _тумблерАнтЭкв = value; if (RefreshForm != null) RefreshForm(); }
        }
        
        public static bool ТумблерТлфТлгПрм
        {
            get { return _тумблерТлфТлгПрм; }
            set { _тумблерТлфТлгПрм = value; if (RefreshForm != null) RefreshForm(); }
        }
        
        public static bool ТумблерТлфТлгПрд
        {
            get { return _тумблерТлфТлгПрд; }
            set { _тумблерТлфТлгПрд = value; if (RefreshForm != null) RefreshForm(); }
        }

        public static bool Тумблер5мГц25мГц3
        {
            get { return _тумблер5МГц25МГц3; }
            set { _тумблер5МГц25МГц3 = value; if (RefreshForm != null) RefreshForm(); }
        }

        #endregion

        #region Лампочки верхняя часть

        public static bool ЛампочкаЦ300МВкл1
        {
            get { return _лампочкаЦ300МВкл1; }
            set { _лампочкаЦ300МВкл1 = value; }
        }

        public static bool ЛампочкаЦ300МВкл2 { get; set; }
        public static bool ЛампочкаЦ300МВкл3 { get; set; }
        public static bool ЛампочкаЦ300МВкл4 { get; set; }
        public static bool ЛампочкаЦ300МСигнал1 { get; set; }
        public static bool ЛампочкаЦ300МСигнал2 { get; set; }
        public static bool ЛампочкаЦ300МСигнал3 { get; set; }
        public static bool ЛампочкаЦ300МСигнал4 { get; set; }
        public static bool ЛампочкаЦ300МНеиспр1 { get; set; }
        public static bool ЛампочкаЦ300МНеиспр2 { get; set; }
        public static bool ЛампочкаЦ300МНеиспр3 { get; set; }
        public static bool ЛампочкаЦ300МНеиспр4 { get; set; }
        public static bool ЛампочкаППВВкл1 { get; set; }
        public static bool ЛампочкаППВВкл2 { get; set; }
        public static bool ЛампочкаППВРабота1 { get; set; }
        public static bool ЛампочкаППВРабота2 { get; set; }
        public static bool ЛампочкаА205Неиспр1 { get; set; }
        public static bool ЛампочкаА205Неиспр2 { get; set; }
        public static bool ЛампочкаУМ1Работа1 { get; set; }
        public static bool ЛампочкаУМ1Работа2 { get; set; }


        private static bool _лампочкаЦ300МВкл1;

        #endregion

        #region Лампочки левая часть
        public static bool ЛампочкаН12С
        {
            get { return _лампочкаН12С; }
            set { _лампочкаН12С = value; }
        }

        public static bool ЛампочкаМШУ
        {
            get { return _лампочкаМШУ; }
            set { _лампочкаМШУ = value; }
        }

        public static bool ЛампочкаБМА_1 { get; set; }
        public static bool ЛампочкаБМА_2 { get; set; }
        public static bool Лампочка27В { get; set; }
        public static bool ЛампочкаБП { get; set; }
        public static bool ЛампочкаАФСС { get; set; }
        public static bool ЛампочкаА1 { get; set; }
        public static bool ЛампочкаА403Вкл { get; set; }
        public static bool ЛампочкаА403Неиспр { get; set; }
        public static bool ЛампочкаП220272 { get; set; }
        public static bool ЛампочкаП220273 { get; set; }
        public static bool ЛампочкаА306 { get; set; }
        public static bool ЛампочкаА3041 { get; set; }
        public static bool ЛампочкаА3042 { get; set; }
        public static bool ЛампочкаБ1_1 { get; set; }
        public static bool ЛампочкаБ1_2 { get; set; }
        public static bool ЛампочкаБ2_1 { get; set; }
        public static bool ЛампочкаБ2_2 { get; set; }
        public static bool ЛампочкаБ3_1 { get; set; }
        public static bool ЛампочкаБ3_2 { get; set; }
        public static bool ЛампочкаДАБ_5 { get; set; }
        public static bool ЛампочкаР_Н { get; set; }

        #endregion

        #region Лампочки правая часть

        public static bool ЛампочкаН16Н13_1
        {
            get { return _лампочкаН16Н131; }
            set { _лампочкаН16Н131 = value;}
        }

        public static bool ЛампочкаН16Н13_2
        {
            get { return _лампочкаН16Н132; }
            set { _лампочкаН16Н132 = value; }
        }

        public static bool ЛампочкаН16Н13_12
        {
            get { return _лампочкаН16Н1312; }
            set { _лампочкаН16Н1312 = value; }
        }

        public static bool ЛампочкаН13_11Ступень { get; set; }
        public static bool ЛампочкаН13_21Ступень { get; set; }
        public static bool ЛампочкаН13_1ПолноеВкл { get; set; }
        public static bool ЛампочкаН13_2ПолноеВкл { get; set; }
        public static bool ЛампочкаН13_1Неисправность { get; set; }
        public static bool ЛампочкаН13_2Неисправность { get; set; }
        public static bool Лампочка5мГц2 { get; set; }
        public static bool Лампочка5мГц3 { get; set; }
        public static bool ЛампочкаА503Б { get; set; }
        public static bool ЛампочкаАнт { get; set; }
        public static bool ЛампочкаЭкв { get; set; }

        private static bool _лампочкаН12С;
        private static bool _лампочкаМШУ;
        private static bool _лампочкаН16Н131;
        private static bool _лампочкаН16Н132;
        private static bool _лампочкаН16Н1312;

        #endregion

        public static void ResetParameters()
        {
        }

        public delegate void VoidVoidSignature();

        public static event VoidVoidSignature RefreshForm;
    }
}
