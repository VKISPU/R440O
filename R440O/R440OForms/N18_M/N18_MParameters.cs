using R440O.R440OForms.A205M_1;
using R440O.R440OForms.A205M_2;
using R440O.R440OForms.N15;
using R440O.СостоянияЭлементов.Н18;

namespace R440O.R440OForms.N18_M
{
    class N18_MParameters
    {
        #region Лампочки
        //Лампочки
        public static string N18_MЛампочкаКЗТЛГ1 { get; set; }
        public static string N18_MЛампочкаКЗТЛГ2 { get; set; }
        public static string N18_MЛампочкаКЗТЛГ3 { get; set; }
        public static string N18_MЛампочкаКЗТЛГ4 { get; set; }
        public static string N18_MЛампочкаСПСТест { get; set; }
        public static string N18_MЛампочкаСПСИнформ { get; set; }
        public static string N18_MЛампочкаПилотК1_1 { get; set; }
        public static string N18_MЛампочкаПилотК1_2 { get; set; }
        public static string N18_MЛампочкаИнформК1_1 { get; set; }
        public static string N18_MЛампочкаИнформК1_2 { get; set; }
        #endregion

        #region Переключатели

        #region Двухпозиционные

        private static int _переключательВходБ22 = 1;
       
        /// <summary>
        /// 1 - б3-2,
        /// 2 - б3-1,
        /// </summary>
        public static int ПереключательВходБ22
        {
            get { return _переключательВходБ22; }
            set
            {
                if (value > 0 && value < 3) _переключательВходБ22 = value;
                OnParameterChanged();
            }
        }

        private static int _переключательВыход1РН = 1;

        /// <summary>
        /// 1 - б1-1,
        /// 2 - даб-5
        /// </summary>
        public static int ПереключательВыход1РН
        {
            get { return _переключательВыход1РН; }
            set
            {
                if (value > 0 && value < 3) _переключательВыход1РН = value;
                OnParameterChanged();
            }
        }

        private static int _переключательВыход2РН = 1;

        /// <summary>
        /// 1 - б1-2,
        /// 2 - даб-5
        /// </summary>
        public static int ПереключательВыход2РН
        {
            get { return _переключательВыход2РН; }
            set
            {
                if (value > 0 && value < 3) _переключательВыход2РН = value;
                OnParameterChanged();
            }
        }

        private static int _переключатель48ПрмЩв = 1;

        /// <summary>
        /// 1 - б2,
        /// 2 - даб-5
        /// </summary>
        public static int Переключатель48ПрмЩв
        {
            get { return _переключатель48ПрмЩв; }
            set
            {
                if (value > 0 && value < 3) _переключатель48ПрмЩв = value;
                OnParameterChanged();
            }
        } 
        #endregion

        private static int _переключательПрмСс2 = 3;

        /// <summary>
        /// 1 - прм-2,
        /// 2 - б3-2,
        /// 3 - б2-2,
        /// 4 - б1-2,
        /// 5 - даб-5
        /// </summary>
        public static int ПереключательПрмСс2
        {
            get { return _переключательПрмСс2; }
            set
            {
                if (value > 0 && value < 6) _переключательПрмСс2 = value;
                OnParameterChanged();
            }
        }

        private static int _переключательПрмСс1 = 3;

        /// <summary>
        /// 1 - прм-1,
        /// 2 - б3-1,
        /// 3 - б2-1,
        /// 4 - б1-1,
        /// 5 - даб-5
        /// </summary>
        public static int ПереключательПрмСс1
        {
            get { return _переключательПрмСс1; }
            set
            {
                if (value > 0 && value < 6) _переключательПрмСс1 = value;
                OnParameterChanged();
            }
        }
        
        private static int _переключательПрдБма12 = 6;

        /// <summary>
        /// 1 - тлф-1/2,
        /// 2 - тлф-2/3,
        /// 3 - тлф-3/1,
        /// 4 - тлф-1/3,
        /// 5 - тлф-2/1,
        /// 6 - тлф-3/2,
        /// 7 - мод1,
        /// 8 - мод2,
        /// 9 - к1-2-1
        /// </summary>
        public static int ПереключательПрдБма12
        {
            get { return _переключательПрдБма12; }
            set
            {
                if (value > 0 && value < 10) _переключательПрдБма12 = value;
                OnParameterChanged();
            }
        }

        private static int _переключательПРД = 3;

        /// <summary>
        /// 1 - даб-5,
        /// 2 - а1,
        /// 3 - бма,
        /// 4 - тлг,
        /// 5 - сс
        /// </summary>
        public static int ПереключательПРД
        {
            get { return _переключательПРД; }
            set
            {
                if (value > 0 && value < 6) _переключательПРД = value;
                N15Parameters.ResetDiscret();
                OnParameterChanged();
            }
        }

        private static int _переключательВходК121 = 1;

        /// <summary>
        /// 1 - откл,
        /// 2 - бма-1,
        /// 3 - бма-2,
        /// 4 - щв
        /// </summary>
        public static int ПереключательВходК121
        {
            get { return _переключательВходК121; }
            set
            {
                if (value > 0 && value < 5) _переключательВходК121 = value;
                OnParameterChanged();
                A205M_1Parameters.ResetParameters();
                A205M_2Parameters.ResetParameters();
                N15Parameters.ResetParameters();
            }
        }

        private static int _переключательПРМ1 = 3;

        /// <summary>
        /// 1 - б3-1,
        /// 2 - б2-1,
        /// 3 - даб-5,
        /// 4 - б1-1,
        /// 5 - р-н
        /// </summary>
        public static int ПереключательПРМ1
        {
            get { return _переключательПРМ1; }
            set
            {
                if (value > 0 && value < 6) _переключательПРМ1 = value;
                OnParameterChanged();
            }
        }

        private static int _переключательПРМ2 = 3;

        /// <summary>
        /// 1 - б3-2,
        /// 2 - б2-2,
        /// 3 - даб-5,
        /// 4 - б1-2,
        /// р-н
        /// </summary>
        public static int ПереключательПРМ2
        {
            get { return _переключательПРМ2; }
            set
            {
                if (value > 0 && value < 6) _переключательПРМ2 = value;
                OnParameterChanged();
            }
        }

        #endregion

        #region Тумблеры
        private static ТумблерДаб5 _тумблерДАБ5 = ТумблерДаб5.Прм1;
        private static ТумблерКауПрм _тумблерКАУ_ПРМ = ТумблерКауПрм.Б11;
        private static ТумблерПрдСс _тумблерПРД_СС = ТумблерПрдСс.КонтурП;
        private static ТумблерТлфПрм _тумблерТЛФ_ПРМ = ТумблерТлфПрм.Осн;

        public static ТумблерДаб5 ТумблерДАБ5
        {
            get { return _тумблерДАБ5; }
            set
            {
                _тумблерДАБ5 = value;
                OnParameterChanged();
            }
        }

        public static ТумблерКауПрм ТумблерКАУ_ПРМ
        {
            get { return _тумблерКАУ_ПРМ; }
            set
            {
                _тумблерКАУ_ПРМ = value;
                OnParameterChanged();
            }
        }

        public static ТумблерПрдСс ТумблерПРД_СС
        {
            get { return _тумблерПРД_СС; }
            set
            {
                _тумблерПРД_СС = value;
                OnParameterChanged();
            }
        }

        public static ТумблерТлфПрм ТумблерТЛФ_ПРМ
        {
            get { return _тумблерТЛФ_ПРМ; }
            set
            {
                _тумблерТЛФ_ПРМ = value;
                OnParameterChanged();
            }
        }
        #endregion

        public delegate void ParameterChangedHandler();
        public static event ParameterChangedHandler ParameterChanged;

        private static void OnParameterChanged()
        {
            N15Parameters.ResetDiscret();
            var handler = ParameterChanged;
            if (handler != null) handler();
        }
    }
}
