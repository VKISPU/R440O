namespace R440O.R440OForms.N15
{
    public static class N15LocalParameters
    {
        #region Тумблеры левая часть
        private static bool _локТумблерЦ300М1;
        private static bool _локТумблерЦ300М2;
        private static bool _локТумблерЦ300М3;
        private static bool _локТумблерЦ300М4;
        private static bool _локТумблерН12С;
        private static bool _локТумблерМшу;
        private static bool _локТумблерБМА1;
        private static bool _локТумблерБМА2;
        private static bool _локТумблерА205Base; //чтобы при записи локальных параметров в него не записывалось значение _локТумблерА20512
        private static bool _локТумблерА20512;
        private static bool _локТумблерАФСС;
        private static bool _локТумблерА1;
        private static bool _локТумблерА403;
        private static bool _локТумблерК1_1;
        private static bool _локТумблерК1_2;
        private static bool _локТумблерА30412;
        private static bool _локТумблерБ1_1;
        private static bool _локТумблерБ1_2;
        private static bool _локТумблерБ2_1;
        private static bool _локТумблерБ2_2;
        private static bool _локТумблерБ3_1;
        private static bool _локТумблерБ3_2;
        private static bool _локТумблерДАБ_5;
        private static bool _локТумблерР_Н;

        public static bool локТумблерЦ300М1
        {
            get { return _локТумблерЦ300М1; }
            set { _локТумблерЦ300М1 = value; }
        }

        public static bool локТумблерЦ300М2
        {
            get { return _локТумблерЦ300М2; }
            set { _локТумблерЦ300М2 = value; }
        }

        public static bool локТумблерЦ300М3
        {
            get { return _локТумблерЦ300М3; }
            set { _локТумблерЦ300М3 = value; }
        }

        public static bool локТумблерЦ300М4
        {
            get { return _локТумблерЦ300М4; }
            set { _локТумблерЦ300М4 = value; }
        }

        public static bool локТумблерН12С
        {
            get { return _локТумблерН12С; }
            set { _локТумблерН12С = value; }
        }

        public static bool локТумблерМШУ
        {
            get { return _локТумблерМшу; }
            set { _локТумблерМшу = value; }
        }

        public static bool локТумблерБМА_1
        {
            get { return _локТумблерБМА1; }
            set { _локТумблерБМА1 = value; }
        }

        public static bool локТумблерБМА_2
        {
            get { return _локТумблерБМА2; }
            set { _локТумблерБМА2 = value; }
        }

        public static bool локТумблерА205Base
        {
            get { return _локТумблерА205Base; }
            set { _локТумблерА205Base = value; }
        }

        public static bool локТумблерА20512
        {
            get { return _локТумблерА20512; }
            set { _локТумблерА20512 = value; }
        }

        public static bool локТумблерАФСС
        {
            get { return _локТумблерАФСС; }
            set { _локТумблерАФСС = value; }
        }

        public static bool локТумблерА1
        {
            get { return _локТумблерА1; }
            set { _локТумблерА1 = value; }
        }

        public static bool локТумблерА403
        {
            get { return _локТумблерА403; }
            set { _локТумблерА403 = value; }
        }

        public static bool локТумблерК1_1
        {
            get { return _локТумблерК1_1; }
            set { _локТумблерК1_1 = value; }
        }

        public static bool локТумблерК1_2
        {
            get { return _локТумблерК1_2; }
            set { _локТумблерК1_2 = value; }
        }

        public static bool локТумблерА30412
        {
            get { return _локТумблерА30412; }
            set
            {
                _локТумблерА30412 = value;
                N15Parameters.ResetParameters();
                A304.A304Parameters.ResetParameters();
            }
        }

        public static bool локТумблерБ1_1
        {
            get { return _локТумблерБ1_1; }
            set { _локТумблерБ1_1 = value; }
        }

        public static bool локТумблерБ1_2
        {
            get { return _локТумблерБ1_2; }
            set { _локТумблерБ1_2 = value; }
        }

        public static bool локТумблерБ2_1
        {
            get { return _локТумблерБ2_1; }
            set { _локТумблерБ2_1 = value; }
        }

        public static bool локТумблерБ2_2
        {
            get { return _локТумблерБ2_2; }
            set { _локТумблерБ2_2 = value; }
        }

        public static bool локТумблерБ3_1
        {
            get { return _локТумблерБ3_1; }
            set { _локТумблерБ3_1 = value; }
        }

        public static bool локТумблерБ3_2
        {
            get { return _локТумблерБ3_2; }
            set { _локТумблерБ3_2 = value; }
        }

        public static bool локТумблерДАБ_5
        {
            get { return _локТумблерДАБ_5; }
            set { _локТумблерДАБ_5 = value; }
        }

        public static bool локТумблерР_Н
        {
            get { return _локТумблерР_Н; }
            set { _локТумблерР_Н = value; }
        }
        #endregion

        #region Тумблеры правая часть
        private static bool _локТумблерА503Б;
        private static int _локТумблерФаза = 0;
        private static int _локТумблерУров1 = 0;
        private static int _локТумблерУров2 = 0;
        private static int _локТумблер5Мгц = 0;
        private static bool _локТумблерАнтЭкв;
        private static bool _локТумблерТлфТлгПрм;
        private static bool _локТумблерТлфТлгПрд;

        public static bool локТумблерА503Б
        {
            get { return _локТумблерА503Б; }
            set { _локТумблерА503Б = value; }
        }

        public static int локТумблерФаза
        {
            get { return _локТумблерФаза; }
            set { _локТумблерФаза = value; }
        }

        public static int локТумблерУров1
        {
            get { return _локТумблерУров1; }
            set { _локТумблерУров1 = value; }
        }

        public static int локТумблерУров2
        {
            get { return _локТумблерУров2; }
            set { _локТумблерУров2 = value; }
        }

        public static int локТумблер5Мгц
        {
            get { return _локТумблер5Мгц; }
            set { _локТумблер5Мгц = value; }
        }

        public static bool локТумблерАнтЭкв
        {
            get { return _локТумблерАнтЭкв; }
            set { _локТумблерАнтЭкв = value; }
        }

        public static bool локТумблерТлфТлгПрм
        {
            get { return _локТумблерТлфТлгПрм; }
            set { _локТумблерТлфТлгПрм = value; }
        }

        public static bool локТумблерТлфТлгПрд
        {
            get { return _локТумблерТлфТлгПрд; }
            set { _локТумблерТлфТлгПрд = value; }
        }

        #endregion

        #region Кнопки
        private static bool _локКнопкаПрмНаведениеЦ300М1;
        private static bool _локКнопкаПрмНаведениеЦ300М2;
        private static bool _локКнопкаПрмНаведениеЦ300М3;
        private static bool _локКнопкаПрмНаведениеЦ300М4;
        private static bool _локКнопкаМощностьН16;
        private static bool _локКнопкаМощностьАнт;

        private static bool _локКнопкаН131;
        private static bool _локКнопкаН132;
        private static bool _локКнопкаН1312;


        public static bool локКнопкаПРМНаведениеЦ300М1
        {
            get { return _локКнопкаПрмНаведениеЦ300М1; }
            set { _локКнопкаПрмНаведениеЦ300М1 = value; }
        }


        public static bool локКнопкаПРМНаведениеЦ300М2
        {
            get { return _локКнопкаПрмНаведениеЦ300М2; }
            set { _локКнопкаПрмНаведениеЦ300М2 = value; }
        }

        public static bool локКнопкаПРМНаведениеЦ300М3
        {
            get { return _локКнопкаПрмНаведениеЦ300М3; }
            set { _локКнопкаПрмНаведениеЦ300М3 = value; }
        }

        public static bool локКнопкаПРМНаведениеЦ300М4
        {
            get { return _локКнопкаПрмНаведениеЦ300М4; }
            set { _локКнопкаПрмНаведениеЦ300М4 = value; }
        }

        public static bool локКнопкаМощностьН16
        {
            get { return _локКнопкаМощностьН16; }
            set { _локКнопкаМощностьН16 = value; }
        }

        public static bool локКнопкаМощностьАнт
        {
            get { return _локКнопкаМощностьАнт; }
            set { _локКнопкаМощностьАнт = value; }
        }

        public static bool локКнопкаН13_1
        {
            get { return _локКнопкаН131; }
            set { _локКнопкаН131 = value; }
        }

        public static bool локКнопкаН13_2
        {
            get { return _локКнопкаН132; }
            set { _локКнопкаН132 = value; }
        }

        public static bool локКнопкаН13_12
        {
            get { return _локКнопкаН1312; }
            set { _локКнопкаН1312 = value; }
        }
        #endregion
    }
}
