namespace R440O.Parameters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using СостоянияЭлементов.Контур_П;
    using R440O.R440OForms;
    using R440O.R440OForms.N15;
    using R440O.ThirdParty;

    public class Kontur_P3Parameters
    {
        #region Лапочки
        public static bool ЛампочкаКонтрольПодписи = false;
        public static bool ЛампочкаКП1Канал10 = false;
        public static bool ЛампочкаКП1Канал11 = false;
        public static bool ЛампочкаКП2Прием = false;
        public static bool ЛампочкаКП3Сбой = false;
        public static bool ЛампочкаКП3Канал10 = false;
        public static bool ЛампочкаКП3Канал11 = false;
        public static bool ЛампочкаКП3Канал12 = false;

        public static bool ЛампочкаКП4Канал1 = false;
        public static bool ЛампочкаКП4Канал2 = false;
        public static bool ЛампочкаКП4Канал3 = false;
        public static bool ЛампочкаКП4Канал4 = false;
        public static bool ЛампочкаКП4Канал5 = false;
        public static bool ЛампочкаКП4Канал6 = false;
        public static bool ЛампочкаКП4Канал7 = false;
        public static bool ЛампочкаКП4Канал8 = false;
        public static bool ЛампочкаКП4Канал9 = false;

        public static bool ЛампочкаКП5Прием = false;

        public static bool ЛампочкаНеиспр = false;
        public static bool ЛампочкаКонтроль = false;
        public static bool ЛампочкаСбойПодписи = false;

        public static bool ЛампочкаПередача = false;

        public static bool ЛампочкаОтбой = false;
        public static bool ЛампочкаИнформПринята = false;

        public static bool ЛампочкаКП6Передача = false;
        public static bool ЛампочкаКП6Сбой = false;
        public static bool ЛампочкаКП6Режим3 = false;

        public static bool ЛампочкаПР1_ЗА = false;
        public static bool ЛампочкаПР2_ЗА = false;
        public static bool ЛампочкаСеть = false;
        #endregion

        #region Тумблеры
        private static EТумблерКонтроль _ТумблерКонтроль = EТумблерКонтроль.КОНТРОЛЬ_1;
        public static EТумблерКонтроль ТумблерКонтроль
        {
            get { return _ТумблерКонтроль; }
            set { _ТумблерКонтроль = value; }
        }

        private static EТумблерМткПУ _ТумблерМткПУ = EТумблерМткПУ.МТК;
        public static EТумблерМткПУ ТумблерМткПУ
        {
            get { return _ТумблерМткПУ; }
            set { _ТумблерМткПУ = value; }
        }

        private static EТумблерДокументирование _ТумблерДокументирование = EТумблерДокументирование.ОТКЛ;
        public static EТумблерДокументирование ТумблерДокументирование
        {
            get { return _ТумблерДокументирование; }
            set { _ТумблерДокументирование = value; }
        }

        private static EТумблерАсинхрСинхр _ТумблерАсинхрСинхр = EТумблерАсинхрСинхр.СИНХР;
        public static EТумблерАсинхрСинхр ТумблерАсинхрСинхр
        {
            get { return _ТумблерАсинхрСинхр; }
            set { _ТумблерАсинхрСинхр = value; }
        }

        private static EТумблерРежим _ТумблерРежим = EТумблерРежим.РЕЖИМ_1;
        public static EТумблерРежим ТумблерРежим
        {
            get { return _ТумблерРежим; }
            set { _ТумблерРежим = value; }
        }

        private static EТумблерСеть _ТумблерСеть = EТумблерСеть.ОТКЛ;
        public static EТумблерСеть ТумблерСеть
        {
            get { return _ТумблерСеть; }
            set { _ТумблерСеть = value; }
        }

        #endregion

        #region ПереключательПриоритет
        /// <summary>
        /// Положение переключателя Приоритет
        /// </summary>
        private static EПереключательПриоритет _ПереключательПриоритет = EПереключательПриоритет._0;
        public static EПереключательПриоритет ПереключательПриоритет
        {
            get { return _ПереключательПриоритет; }
            set
            {
                if (value >= EПереключательПриоритет._0 && value <= EПереключательПриоритет._9)
                {
                    _ПереключательПриоритет = value;
                }
            }
        }
        #endregion

        #region ПереключательКонтроль
        /// <summary>
        /// Положение переключателя Приоритет
        /// </summary>
        private static EПереключательКонтроль _ПереключательКонтроль = EПереключательКонтроль.ОТКЛ;
        public static EПереключательКонтроль ПереключательКонтроль
        {
            get { return _ПереключательКонтроль; }
            set
            {
                if (value >= EПереключательКонтроль.ОТКЛ
                    && value <= EПереключательКонтроль._p9B_резерв)
                {
                    _ПереключательКонтроль = value;
                }
            }
        }

        /// <summary>
        /// Названия положений переключателя Контроль
        /// </summary>
        private static string[] ПоложенияПереключательКонтроль = {
            "откл",
            "+9В",
            "+5Вст",
            "+12В",
            "сеть",
            "+20В",
            "-20В",
            "+15В",
            "-15В",
            "+9Врезерв"
        };
        #endregion
    }
}
