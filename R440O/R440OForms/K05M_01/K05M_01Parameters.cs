using R440O.R440OForms.A205M_1;
using R440O.R440OForms.K03M_01;
using R440O.R440OForms.K05M_01Inside;
using R440O.R440OForms.K04M_01;
using R440O.R440OForms.PU_K1_1;
using R440O.BaseClasses;

namespace R440O.R440OForms.K05M_01
{
    static class K05M_01Parameters
    {
        #region событие

        public delegate void ParameterChangedHandler();
        public static event ParameterChangedHandler ParameterChanged;

        private static void OnParameterChanged()
        {
            var handler = ParameterChanged;
            if (handler != null) handler();
        }

        public static void ResetParameters()
        {
            A205M_1Parameters.ResetParameters();
            OnParameterChanged();
        }

        #endregion

        #region  Перекючатели

        private static int _ПереключательПередачаКонтроль = 1;
        private static int _ПереключательОслабление;
        private static int _ПереключательРодРаботы;
        private static int _ПереключательКанал1;
        private static int _ПереключательКанал2;


        /// <summary>
        /// 0 - передача работа, 1 - контроль прм, 2 - контроль частота, 3 - контроль борта
        /// </summary>
        public static int ПереключательПередачаКонтроль
        {
            get
            {
                return _ПереключательПередачаКонтроль;
            }

            set
            {
                if (value >= 0 && value <= 3)
                {
                    _ПереключательПередачаКонтроль = value;
                    K03M_01Parameters.ПересчитатьНайденоИлиНеНайдено();
                    ResetParameters();
                }
            }
        }
        public static int ПереключательОслабление
        {
            get
            {
                return _ПереключательОслабление;
            }

            set
            {
                if (value >= 0 && value <= 2)
                {
                    _ПереключательОслабление = value;
                    ResetParameters();
                }
            }
        }
        public static int ПереключательРодРаботы
        {
            get
            {
                return _ПереключательРодРаботы;
            }

            set
            {
                if (value >= 0 && value <= 2)
                {
                    _ПереключательРодРаботы = value;
                    ResetParameters();
                }
            }
        }
        public static int ПереключательКанал1
        {
            get
            {
                return _ПереключательКанал1;
            }

            set
            {
                if (value >= 0 && value <= 3)
                {
                    _ПереключательКанал1 = value;
                    ResetParameters();
                }
            }
        }
        public static int ПереключательКанал2
        {
            get
            {
                return _ПереключательКанал2;
            }

            set
            {
                if (value >= 0 && value <= 2)
                {
                    _ПереключательКанал2 = value;
                    ResetParameters();;
                }
            }
        }
        #endregion

        private static int _cтрелкаУровень = 0;

        public static int СтрелкаУровень
        {
            get { return _cтрелкаУровень; }
            set
            {
                if (value >= -9 && value <= 9 && _cтрелкаУровень != value)
                {
                    _cтрелкаУровень = value;
                    ResetParameters();
                }
            }
        }

        public static bool СтрелкаУровеньВЗакрашенномСекторе
        {
            get { return СтрелкаУровень >= 0 && СтрелкаУровень <= 9; }
        }

        public static KulonSignal Сигнал
        {
            get
            {                
                return PU_K1_1Parameters.Включен ?
                    new KulonSignal(K04M_01Parameters.ЧастотаПрд) : null;
            }
        }
    }
}
