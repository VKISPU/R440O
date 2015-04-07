using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R440O.R440OForms.N502B;

namespace R440O.Parameters
{
    class BMBParameters
    {
        #region ПереключательРаботаКонтроль
        public static int ПереключательРаботаКонтроль
        {
            get { return _переключательРаботаКонтроль; }
            set
            {
                if (value > 0 && value < 3) 
                    _переключательРаботаКонтроль = value;
                ResetParameters();
            }
        }
        private static int _переключательРаботаКонтроль = 1;
        #endregion

        #region ПереключательПодключениеРезерва
        /// <summary>
        /// Положение переключателя подключение резерва
        /// </summary>
        private static int _BMBПереключательПодключениеРезерва = 1;

        public static int BMBПереключательПодключениеРезерва
        {
            get { return _BMBПереключательПодключениеРезерва; }
            set
            {
                if (value > 0 && value < 4) _BMBПереключательПодключениеРезерва = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя подключение резерва
        /// </summary>
        private static string[] BMBПоложенияПереключательПодключениеРезерва = {
            "1",
            "2",
            "3"
        };
        #endregion

        #region ПереключательНаправление
        /// <summary>
        /// Положение переключателя направления
        /// </summary>
        private static int _BMBПереключательНаправление = 1;

        public static int BMBПереключательНаправление
        {
            get { return _BMBПереключательНаправление; }
            set
            {
                if (value > 0 && value < 5) _BMBПереключательНаправление = value;
            }
        }

        /// <summary>
        /// Названия положений переключателя направления
        /// </summary>
        private static string[] BMBПоложенияПереключательНаправление = {
            "1",
            "2",
            "3",
            "4"
        };
        #endregion

        #region Кнопки
        public static bool КнопкаПередачаВызоваТч
        {
            get { return _кнопкаПередачаВызоваТч; }
            set
            {
                _кнопкаПередачаВызоваТч = value;
                ResetParameters();
            }
        }
        private static bool _кнопкаПередачаВызоваТч;

        public static bool КнопкаПередачаВызоваДк
        {
            get { return _кнопкаПередачаВызоваДк; }
            set
            {
                _кнопкаПередачаВызоваДк = value;
                ResetParameters();
            }
        }
        private static bool _кнопкаПередачаВызоваДк;

        public static bool КнопкаСлСвязь
        {
            get { return _кнопкаСлСвязь; }
            set
            {
                _кнопкаСлСвязь = value;
                ResetParameters();
            }
        }
        private static bool _кнопкаСлСвязь;

        public static bool КнопкаПитание
        {
            get { return _кнопкаПитание; }
            set
            {
                _кнопкаПитание = value;
                ResetParameters();
            }
        }
        private static bool _кнопкаПитание;

        public static bool КнопкаЗвСигнал
        {
            get { return _кнопкаЗвСигнал; }
            set
            {
                _кнопкаЗвСигнал = value;
                ResetParameters();
            }
        }
        private static bool _кнопкаЗвСигнал;
        #endregion

        #region Лампочки
        public static bool ЛампочкаДк
        {
            get { return _лампочкаДк; }
            set
            {
                _лампочкаДк = value;
                if (RefreshForm != null)
                {
                    RefreshForm();
                }
            }
        }
        private static bool _лампочкаДк;

        public static bool ЛампочкаТч
        {
            get { return _лампочкаТч; }
            set
            {
                _лампочкаТч = value;
                if (RefreshForm != null)
                {
                    RefreshForm();
                }
            }
        }
        private static bool _лампочкаТч;

        public static bool BMBЛампочкаРезервВкл = false;
        public static bool BMBЛампочкаПриемВызова = false;
        public static bool BMBЛампочкаНаправление1 = false;
        public static bool BMBЛампочкаНаправление2 = false;
        public static bool BMBЛампочкаНаправление3 = false;
        public static bool BMBЛампочкаНаправление4 = false;
        #endregion

        public static void ResetParameters()
        {
            ЛампочкаДк = КнопкаПитание && КнопкаПередачаВызоваДк && N502BParameters.ТумблерВыпрямитель27В 
                && N502BParameters.ЛампочкаСфазировано && ПереключательРаботаКонтроль == 2;
            ЛампочкаТч = КнопкаПитание && КнопкаПередачаВызоваТч && N502BParameters.ТумблерВыпрямитель27В
                && N502BParameters.ЛампочкаСфазировано && ПереключательРаботаКонтроль == 2;
        }

        public delegate void VoidVoidSignature();
        public static event VoidVoidSignature RefreshForm;

    }
}
