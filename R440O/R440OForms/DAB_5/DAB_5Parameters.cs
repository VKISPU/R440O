﻿namespace R440O.Parameters
{
    using R440O.R440OForms.N15;
    using R440O.ThirdParty;
    using R440O.СостоянияЭлементов.ДАБ5;
    using System;
    using System.Reflection;
    /// <summary>
    /// Состояния элементов блока ДАБ-5
    /// </summary>
    class DAB_5Parameters
    {
        private static EТумблерПитание _ТумблерПитание;
        public static EТумблерПитание ТумблерПитание
        {
            get { return _ТумблерПитание; }
            set
            {
                _ТумблерПитание = value;
                N15Parameters.ResetParameters();
                if (ЛампочкаПитание)
                    TurnOn();
                else
                    TurnOff();
                Refresh();
            }
        }

        #region Лампочки ДАБ-5 УП
        public static bool ЛампочкаПитание
        {
            get { return N15Parameters.ЛампочкаДАБ_5; }
        }

        public static bool ЛампочкаРежимМестн
        {
            get { return ЛампочкаПитание; }
        }

        private static bool _ЛампочкаРежимАвтом;
        public static bool ЛампочкаРежимАвтом 
        {
            get { return _ЛампочкаРежимАвтом; }
        }

        private static bool _ЛампочкаРежимРучн;
        public static bool ЛампочкаРежимРучн
        {
            get { return _ЛампочкаРежимРучн; }
        }

        private static bool _ЛампочкаВыборПрмПрд1;
        public static bool ЛампочкаВыборПрмПрд1
        {
            get { return _ЛампочкаВыборПрмПрд1; }
        }

        private static bool _ЛампочкаВыборПрмПрд2;
        public static bool ЛампочкаВыборПрмПрд2
        {
            get { return _ЛампочкаВыборПрмПрд2; }
        }

        private static bool _ЛампочкаВыборБП1;
        public static bool ЛампочкаВыборБП1
        {
            get { return _ЛампочкаВыборБП1; }
        }

        private static bool _ЛампочкаВыборБП2;
        public static bool ЛампочкаВыборБП2
        {
            get { return _ЛампочкаВыборБП2; }
        }

        private static bool _ЛампочкаРежимРабота1К;
        public static bool ЛампочкаРежимРабота1К
        {
            get { return _ЛампочкаРежимРабота1К; }
        }

        private static bool _ЛампочкаРежимШлейф1К;
        public static bool ЛампочкаРежимШлейф1К
        {
            get { return _ЛампочкаРежимШлейф1К; }
        }

        private static bool _ЛампочкаРежимПрмПрд1К;
        public static bool ЛампочкаРежимПрмПрд1К
        {
            get { return _ЛампочкаРежимПрмПрд1К; }
        }

        private static bool _ЛампочкаРежимПрм1К;
        public static bool ЛампочкаРежимПрм1К
        {
            get { return _ЛампочкаРежимПрм1К; }
        }


        private static bool _ЛампочкаРежимРабота2К;
        public static bool ЛампочкаРежимРабота2К
        {
            get { return _ЛампочкаРежимРабота2К; }
        }

        private static bool _ЛампочкаРежимШлейф2К;
        public static bool ЛампочкаРежимШлейф2К
        {
            get { return _ЛампочкаРежимШлейф2К; }
        }

        private static bool _ЛампочкаРежимПрмПрд2К;
        public static bool ЛампочкаРежимПрмПрд2К
        {
            get { return _ЛампочкаРежимПрмПрд2К; }
        }

        private static bool _ЛампочкаРежимПрм2К;
        public static bool ЛампочкаРежимПрм2К
        {
            get { return _ЛампочкаРежимПрм2К; }
        }
        #endregion

        #region Лампочки Комплекты
        private static bool _Лампочка1КомплектПрдДаб51БиВых;
        public static bool Лампочка1КомплектПрдДаб51БиВых
        {
            get { return _Лампочка1КомплектПрдДаб51БиВых; }
        }

        private static bool _Лампочка1КомплектПрдДаб51БиВх;
        public static bool Лампочка1КомплектПрдДаб51БиВх
        {
            get { return _Лампочка1КомплектПрдДаб51БиВх; }
        }

        private static bool _Лампочка1КомплектПрдДаб51ВхСс;
        public static bool Лампочка1КомплектПрдДаб51ВхСс
        {
            get { return _Лампочка1КомплектПрдДаб51ВхСс; }
        }

        private static bool _Лампочка1КомплектПрдДаб5_1ВхКк;
        public static bool Лампочка1КомплектПрдДаб5_1ВхКк
        {
            get { return _Лампочка1КомплектПрдДаб5_1ВхКк; }
        }

        private static bool _Лампочка1КомплектПрдДаб5_1ВыхСс;
        public static bool Лампочка1КомплектПрдДаб5_1ВыхСс
        {
            get { return _Лампочка1КомплектПрдДаб5_1ВыхСс; }
        }

        private static bool _Лампочка1КомплектПрдДаб5_1ВыхКк;
        public static bool Лампочка1КомплектПрдДаб5_1ВыхКк
        {
            get { return _Лампочка1КомплектПрдДаб5_1ВыхКк; }
        }

        private static bool _Лампочка1КомплектПрдДаб5_1ВыхТч;
        public static bool Лампочка1КомплектПрдДаб5_1ВыхТч
        {
            get { return _Лампочка1КомплектПрдДаб5_1ВыхТч; }
        }

        private static bool _Лампочка1КомплектПрдДаб5ГВкл;
        public static bool Лампочка1КомплектПрдДаб5ГВкл
        {
            get { return _Лампочка1КомплектПрдДаб5ГВкл; }
        }

        private static bool _Лампочка1КомплектПрдДаб5ГТСнх;
        public static bool Лампочка1КомплектПрдДаб5ГТСнх
        {
            get { return _Лампочка1КомплектПрдДаб5ГТСнх; }
        }

        private static bool _Лампочка1КомплектПрдДаб5ГТакт;
        public static bool Лампочка1КомплектПрдДаб5ГТакт
        {
            get { return _Лампочка1КомплектПрдДаб5ГТакт; }
        }

        private static bool _Лампочка1КомплектПрмДаб51БиВых;
        public static bool Лампочка1КомплектПрмДаб51БиВых
        {
            get { return _Лампочка1КомплектПрмДаб51БиВых; }
        }

        private static bool _Лампочка1КомплектПрмДаб51БиВх;
        public static bool Лампочка1КомплектПрмДаб51БиВх
        {
            get { return _Лампочка1КомплектПрмДаб51БиВх; }
        }

        private static bool _Лампочка1КомплектПрмДаб51ВхСс;
        public static bool Лампочка1КомплектПрмДаб51ВхСс
        {
            get { return _Лампочка1КомплектПрмДаб51ВхСс; }
        }

        private static bool _Лампочка1КомплектПрмДаб5_1ВхКк;
        public static bool Лампочка1КомплектПрмДаб5_1ВхКк
        {
            get { return _Лампочка1КомплектПрмДаб5_1ВхКк; }
        }

        private static bool _Лампочка1КомплектПрмДаб5_1ВыхСс;
        public static bool Лампочка1КомплектПрмДаб5_1ВыхСс
        {
            get { return _Лампочка1КомплектПрмДаб5_1ВыхСс; }
        }

        private static bool _Лампочка1КомплектПрмДаб5_1ВыхКк;
        public static bool Лампочка1КомплектПрмДаб5_1ВыхКк
        {
            get { return _Лампочка1КомплектПрмДаб5_1ВыхКк; }
        }

        private static bool _Лампочка1КомплектПрмДаб5_1ВыхТч;
        public static bool Лампочка1КомплектПрмДаб5_1ВыхТч
        {
            get { return _Лампочка1КомплектПрмДаб5_1ВыхТч; }
        }

        private static bool _Лампочка1КомплектПрмДаб5ГВкл;
        public static bool Лампочка1КомплектПрмДаб5ГВкл
        {
            get { return _Лампочка1КомплектПрмДаб5ГВкл; }
        }

        private static IDisposable timer_Лампочка1КомплектПрмДаб5ГТСнх = null;
        private static bool _Лампочка1КомплектПрмДаб5ГТСнх;
        public static bool Лампочка1КомплектПрмДаб5ГТСнх
        {
            get { return _Лампочка1КомплектПрмДаб5ГТСнх; }
        }

        private static IDisposable timer_Лампочка1КомплектПрмДаб5ГЦСнх = null;
        private static bool _Лампочка1КомплектПрмДаб5ГЦСнх;
        public static bool Лампочка1КомплектПрмДаб5ГЦСнх
        {
            get { return _Лампочка1КомплектПрмДаб5ГЦСнх; }
        }

        private static bool _Лампочка1КомплектПрмДаб5ГТакт;
        public static bool Лампочка1КомплектПрмДаб5ГТакт
        {
            get { return _Лампочка1КомплектПрмДаб5ГТакт; }
        }

        private static IDisposable timer_Лампочка1КомплектПрмДаб5ГИмТлф = null;
        private static bool _Лампочка1КомплектПрмДаб5ГИмТлф;
        public static bool Лампочка1КомплектПрмДаб5ГИмТлф
        {
            get { return _Лампочка1КомплектПрмДаб5ГИмТлф; }
        }

        private static IDisposable timer_Лампочка1КомплектПрмДаб5ГИмСс = null;
        private static bool _Лампочка1КомплектПрмДаб5ГИмСс;
        public static bool Лампочка1КомплектПрмДаб5ГИмСс
        {
            get { return _Лампочка1КомплектПрмДаб5ГИмСс; }
        }

        private static IDisposable timer_Лампочка1КомплектПрмДаб5ГИмКк = null;
        private static bool _Лампочка1КомплектПрмДаб5ГИмКк;
        public static bool Лампочка1КомплектПрмДаб5ГИмКк
        {
            get { return _Лампочка1КомплектПрмДаб5ГИмКк; }
        }

        private static bool _Лампочка2КомплектПрдДаб51БиВых;
        public static bool Лампочка2КомплектПрдДаб51БиВых
        {
            get { return _Лампочка2КомплектПрдДаб51БиВых; }
        }

        private static bool _Лампочка2КомплектПрдДаб51БиВх;
        public static bool Лампочка2КомплектПрдДаб51БиВх
        {
            get { return _Лампочка2КомплектПрдДаб51БиВх; }
        }

        private static bool _Лампочка2КомплектПрдДаб51ВхСс;
        public static bool Лампочка2КомплектПрдДаб51ВхСс
        {
            get { return _Лампочка2КомплектПрдДаб51ВхСс; }
        }

        private static bool _Лампочка2КомплектПрдДаб5_1ВхКк;
        public static bool Лампочка2КомплектПрдДаб5_1ВхКк
        {
            get { return _Лампочка2КомплектПрдДаб5_1ВхКк; }
        }

        private static bool _Лампочка2КомплектПрдДаб5_1ВыхСс;
        public static bool Лампочка2КомплектПрдДаб5_1ВыхСс
        {
            get { return _Лампочка2КомплектПрдДаб5_1ВыхСс; }
        }

        private static bool _Лампочка2КомплектПрдДаб5_1ВыхКк;
        public static bool Лампочка2КомплектПрдДаб5_1ВыхКк
        {
            get { return _Лампочка2КомплектПрдДаб5_1ВыхКк; }
        }

        private static bool _Лампочка2КомплектПрдДаб5_1ВыхТч;
        public static bool Лампочка2КомплектПрдДаб5_1ВыхТч
        {
            get { return _Лампочка2КомплектПрдДаб5_1ВыхТч; }
        }

        private static bool _Лампочка2КомплектПрдДаб5ГВкл;
        public static bool Лампочка2КомплектПрдДаб5ГВкл
        {
            get { return _Лампочка2КомплектПрдДаб5ГВкл; }
        }

        private static bool _Лампочка2КомплектПрдДаб5ГТСнх;
        public static bool Лампочка2КомплектПрдДаб5ГТСнх
        {
            get { return _Лампочка2КомплектПрдДаб5ГТСнх; }
        }

        private static bool _Лампочка2КомплектПрдДаб5ГТакт;
        public static bool Лампочка2КомплектПрдДаб5ГТакт
        {
            get { return _Лампочка2КомплектПрдДаб5ГТакт; }
        }

        private static bool _Лампочка2КомплектПрмДаб51БиВых;
        public static bool Лампочка2КомплектПрмДаб51БиВых
        {
            get { return _Лампочка2КомплектПрмДаб51БиВых; }
        }

        private static bool _Лампочка2КомплектПрмДаб51БиВх;
        public static bool Лампочка2КомплектПрмДаб51БиВх
        {
            get { return _Лампочка2КомплектПрмДаб51БиВх; }
        }

        private static bool _Лампочка2КомплектПрмДаб51ВхСс;
        public static bool Лампочка2КомплектПрмДаб51ВхСс
        {
            get { return _Лампочка2КомплектПрмДаб51ВхСс; }
        }

        private static bool _Лампочка2КомплектПрмДаб5_1ВхКк;
        public static bool Лампочка2КомплектПрмДаб5_1ВхКк
        {
            get { return _Лампочка2КомплектПрмДаб5_1ВхКк; }
        }

        private static bool _Лампочка2КомплектПрмДаб5_1ВыхСс;
        public static bool Лампочка2КомплектПрмДаб5_1ВыхСс
        {
            get { return _Лампочка2КомплектПрмДаб5_1ВыхСс; }
        }

        private static bool _Лампочка2КомплектПрмДаб5_1ВыхКк;
        public static bool Лампочка2КомплектПрмДаб5_1ВыхКк
        {
            get { return _Лампочка2КомплектПрмДаб5_1ВыхКк; }
        }

        private static bool _Лампочка2КомплектПрмДаб5_1ВыхТч;
        public static bool Лампочка2КомплектПрмДаб5_1ВыхТч
        {
            get { return _Лампочка2КомплектПрмДаб5_1ВыхТч; }
        }

        private static bool _Лампочка2КомплектПрмДаб5ГВкл;
        public static bool Лампочка2КомплектПрмДаб5ГВкл
        {
            get { return _Лампочка2КомплектПрмДаб5ГВкл; }
        }

        private static IDisposable timer_Лампочка2КомплектПрмДаб5ГТСнх = null;
        private static bool _Лампочка2КомплектПрмДаб5ГТСнх;
        public static bool Лампочка2КомплектПрмДаб5ГТСнх
        {
            get { return _Лампочка2КомплектПрмДаб5ГТСнх; }
        }

        private static IDisposable timer_Лампочка2КомплектПрмДаб5ГЦСнх = null;
        private static bool _Лампочка2КомплектПрмДаб5ГЦСнх;
        public static bool Лампочка2КомплектПрмДаб5ГЦСнх
        {
            get { return _Лампочка2КомплектПрмДаб5ГЦСнх; }
        }

        private static bool _Лампочка2КомплектПрмДаб5ГТакт;
        public static bool Лампочка2КомплектПрмДаб5ГТакт
        {
            get { return _Лампочка2КомплектПрмДаб5ГТакт; }
        }

        private static IDisposable timer_Лампочка2КомплектПрмДаб5ГИмТлф = null;
        private static bool _Лампочка2КомплектПрмДаб5ГИмТлф;
        public static bool Лампочка2КомплектПрмДаб5ГИмТлф
        {
            get { return _Лампочка2КомплектПрмДаб5ГИмТлф; }
        }

        private static IDisposable timer_Лампочка2КомплектПрмДаб5ГИмСс = null;
        private static bool _Лампочка2КомплектПрмДаб5ГИмСс;
        public static bool Лампочка2КомплектПрмДаб5ГИмСс
        {
            get { return _Лампочка2КомплектПрмДаб5ГИмСс; }
        }

        private static IDisposable timer_Лампочка2КомплектПрмДаб5ГИмКк = null;
        private static bool _Лампочка2КомплектПрмДаб5ГИмКк;
        public static bool Лампочка2КомплектПрмДаб5ГИмКк
        {
            get { return _Лампочка2КомплектПрмДаб5ГИмКк; }
        }

        private static bool _Лампочка2КомплектИмВкл;
        public static bool Лампочка2КомплектИмВкл
        {
            get { return ЛампочкаРежимПрмПрд1К || ЛампочкаРежимПрмПрд2К || ЛампочкаРежимПрм1К || ЛампочкаРежимПрм2К; }
        }

        private static bool _Лампочка2КомплектИмТСнх;
        public static bool Лампочка2КомплектИмТСнх
        {
            get { return _Лампочка2КомплектИмТСнх; }
        }

        private static bool _Лампочка2КомплектИмТакт;
        public static bool Лампочка2КомплектИмТакт
        {
            get { return _Лампочка2КомплектИмТакт; }
        }
        #endregion

        #region События кнопок
        public static void НажатьКнопкуРежимРучн()
        {
            if (ЛампочкаПитание)
            {
                _ЛампочкаРежимРучн = true;
                _ЛампочкаРежимАвтом = false;
                Refresh();
            }
        }

        public static void НажатьКнопкуРежимАвтом()
        {
            if (ЛампочкаПитание)
            {
                _ЛампочкаРежимРучн = false;
                _ЛампочкаРежимАвтом = true;
                Refresh();
            }
        }

        public static void НажатьКнопкуВыборПрмПрд1()
        {
            if (ЛампочкаПитание)
            {
                _ЛампочкаВыборПрмПрд1 = true;
                _ЛампочкаВыборПрмПрд2 = false;
                Refresh();
            }
        }

        public static void НажатьКнопкуВыборПрмПрд2()
        {
            if (ЛампочкаПитание)
            {
                _ЛампочкаВыборПрмПрд1 = false;
                _ЛампочкаВыборПрмПрд2 = true;
                Refresh();
            }
        }

        public static void НажатьКнопкуВыборБП1()
        {
            if (ЛампочкаПитание)
            {
                _ЛампочкаВыборБП1 = true;
                _ЛампочкаВыборБП2 = false;
                Refresh();
            }
        }

        public static void НажатьКнопкуВыборБП2()
        {
            if (ЛампочкаПитание)
            {
                _ЛампочкаВыборБП1 = false;
                _ЛампочкаВыборБП2 = true;
                Refresh();
            }
        }

        public static void НажатьКнопкуРежимРабота1К()
        {
            if (ЛампочкаПитание)
            {
                _ЛампочкаРежимРабота1К = true;
                _ЛампочкаРежимШлейф1К = false;
                _ЛампочкаРежимПрмПрд1К = false;
                _ЛампочкаРежимПрм1К = false;
                ВключитьЛампочкиВкл1Комплекта();
                Refresh();
            }
        }

        public static void НажатьКнопкуРежимРабота2К()
        {
            if (ЛампочкаПитание)
            {
                _ЛампочкаРежимРабота2К = true;
                _ЛампочкаРежимШлейф2К = false;
                _ЛампочкаРежимПрмПрд2К = false;
                _ЛампочкаРежимПрм2К = false;
                ВключитьЛампочкиВкл2Комплекта();
                Refresh();
            }
        }

        public static void НажатьКнопкуРежимШлейф1К()
        {
            if (ЛампочкаПитание)
            {
                _ЛампочкаРежимРабота1К = false;
                _ЛампочкаРежимШлейф1К = true;
                _ЛампочкаРежимПрмПрд1К = false;
                _ЛампочкаРежимПрм1К = false;
                ВключитьЛампочкиВкл1Комплекта();
                Refresh();
            }
        }

        public static void НажатьКнопкуРежимШлейф2К()
        {
            if (ЛампочкаПитание)
            {
                _ЛампочкаРежимРабота2К = false;
                _ЛампочкаРежимШлейф2К = true;
                _ЛампочкаРежимПрмПрд2К = false;
                _ЛампочкаРежимПрм2К = false;
                ВключитьЛампочкиВкл2Комплекта();
                Refresh();
            }
        }

        public static void НажатьКнопкуРежимПрмПрд1К()
        {
            if (ЛампочкаПитание)
            {
                _ЛампочкаРежимРабота1К = false;
                _ЛампочкаРежимШлейф1К = false;
                _ЛампочкаРежимПрмПрд1К = true;
                _ЛампочкаРежимПрм1К = false;
                ВключитьЛампочкиВкл1Комплекта();

                if (timer_Лампочка1КомплектПрмДаб5ГИмКк != null)
                    timer_Лампочка1КомплектПрмДаб5ГИмКк.Dispose();
                _Лампочка1КомплектПрмДаб5ГИмКк = true;
                timer_Лампочка1КомплектПрмДаб5ГИмКк = EasyTimer.SetTimeout(() =>
                {
                    _Лампочка1КомплектПрмДаб5ГИмКк = false;
                    Refresh();
                    timer_Лампочка1КомплектПрмДаб5ГИмКк.Dispose();
                }, 2000);

                if (timer_Лампочка1КомплектПрмДаб5ГИмСс != null)
                    timer_Лампочка1КомплектПрмДаб5ГИмСс.Dispose();
                _Лампочка1КомплектПрмДаб5ГИмСс = true;
                timer_Лампочка1КомплектПрмДаб5ГИмСс = EasyTimer.SetTimeout(() =>
                {
                    _Лампочка1КомплектПрмДаб5ГИмСс = false;
                    Refresh();
                    timer_Лампочка1КомплектПрмДаб5ГИмСс.Dispose();
                }, 2000);

                if (timer_Лампочка1КомплектПрмДаб5ГИмТлф != null)
                    timer_Лампочка1КомплектПрмДаб5ГИмТлф.Dispose();
                _Лампочка1КомплектПрмДаб5ГИмТлф = true;
                timer_Лампочка1КомплектПрмДаб5ГИмТлф = EasyTimer.SetTimeout(() =>
                {
                    _Лампочка1КомплектПрмДаб5ГИмТлф = false;
                    Refresh();
                    timer_Лампочка1КомплектПрмДаб5ГИмТлф.Dispose();
                }, 4000);

                if (timer_Лампочка1КомплектПрмДаб5ГЦСнх != null)
                    timer_Лампочка1КомплектПрмДаб5ГЦСнх.Dispose();
                timer_Лампочка1КомплектПрмДаб5ГЦСнх = EasyTimer.SetTimeout(() =>
                {
                    _Лампочка1КомплектПрмДаб5ГЦСнх = true;
                    Refresh();
                    timer_Лампочка1КомплектПрмДаб5ГЦСнх = EasyTimer.SetTimeout(() =>
                    {
                        _Лампочка1КомплектПрмДаб5ГЦСнх = false;
                        Refresh();
                        timer_Лампочка1КомплектПрмДаб5ГЦСнх.Dispose();
                    }, 2000);
                }, 2000);

                if (timer_Лампочка1КомплектПрмДаб5ГТСнх != null)
                    timer_Лампочка1КомплектПрмДаб5ГТСнх.Dispose();
                _Лампочка1КомплектПрмДаб5ГТСнх = true;
                timer_Лампочка1КомплектПрмДаб5ГТСнх = EasyTimer.SetTimeout(() =>
                {
                    _Лампочка1КомплектПрмДаб5ГТСнх = false;
                    Refresh();
                    timer_Лампочка1КомплектПрмДаб5ГТСнх.Dispose();
                }, 1000);

                Refresh();
            }
        }

        public static void НажатьКнопкуРежимПрмПрд2К()
        {
            if (ЛампочкаПитание)
            {
                _ЛампочкаРежимРабота2К = false;
                _ЛампочкаРежимШлейф2К = false;
                _ЛампочкаРежимПрмПрд2К = true;
                _ЛампочкаРежимПрм2К = false;
                ВключитьЛампочкиВкл2Комплекта();

                if (timer_Лампочка2КомплектПрмДаб5ГИмКк != null)
                    timer_Лампочка2КомплектПрмДаб5ГИмКк.Dispose();
                _Лампочка2КомплектПрмДаб5ГИмКк = true;
                timer_Лампочка2КомплектПрмДаб5ГИмКк = EasyTimer.SetTimeout(() =>
                {
                    _Лампочка2КомплектПрмДаб5ГИмКк = false;
                    Refresh();
                    timer_Лампочка2КомплектПрмДаб5ГИмКк.Dispose();
                }, 2000);

                if (timer_Лампочка2КомплектПрмДаб5ГИмСс != null)
                    timer_Лампочка2КомплектПрмДаб5ГИмСс.Dispose();
                _Лампочка2КомплектПрмДаб5ГИмСс = true;
                timer_Лампочка2КомплектПрмДаб5ГИмСс = EasyTimer.SetTimeout(() =>
                {
                    _Лампочка2КомплектПрмДаб5ГИмСс = false;
                    Refresh();
                    timer_Лампочка2КомплектПрмДаб5ГИмСс.Dispose();
                }, 2000);

                if (timer_Лампочка2КомплектПрмДаб5ГИмТлф != null)
                    timer_Лампочка2КомплектПрмДаб5ГИмТлф.Dispose();
                _Лампочка2КомплектПрмДаб5ГИмТлф = true;
                timer_Лампочка2КомплектПрмДаб5ГИмТлф = EasyTimer.SetTimeout(() =>
                {
                    _Лампочка2КомплектПрмДаб5ГИмТлф = false;
                    Refresh();
                    timer_Лампочка2КомплектПрмДаб5ГИмТлф.Dispose();
                }, 4000);

                if (timer_Лампочка2КомплектПрмДаб5ГЦСнх != null)
                    timer_Лампочка2КомплектПрмДаб5ГЦСнх.Dispose();
                timer_Лампочка2КомплектПрмДаб5ГЦСнх = EasyTimer.SetTimeout(() =>
                {
                    _Лампочка2КомплектПрмДаб5ГЦСнх = true;
                    Refresh();
                    timer_Лампочка2КомплектПрмДаб5ГЦСнх = EasyTimer.SetTimeout(() =>
                    {
                        _Лампочка2КомплектПрмДаб5ГЦСнх = false;
                        Refresh();
                        timer_Лампочка2КомплектПрмДаб5ГЦСнх.Dispose();
                    }, 2000);
                }, 2000);

                if (timer_Лампочка2КомплектПрмДаб5ГТСнх != null)
                    timer_Лампочка2КомплектПрмДаб5ГТСнх.Dispose();
                _Лампочка2КомплектПрмДаб5ГТСнх = true;
                timer_Лампочка2КомплектПрмДаб5ГТСнх = EasyTimer.SetTimeout(() =>
                {
                    _Лампочка2КомплектПрмДаб5ГТСнх = false;
                    Refresh();
                    timer_Лампочка2КомплектПрмДаб5ГТСнх.Dispose();
                }, 1000);

                Refresh();
            }
        }

        public static void НажатьКнопкуРежимПрм1К()
        {
            if (ЛампочкаПитание)
            {
                _ЛампочкаРежимРабота1К = false;
                _ЛампочкаРежимШлейф1К = false;
                _ЛампочкаРежимПрмПрд1К = false;
                _ЛампочкаРежимПрм1К = true;
                ВключитьЛампочкиВкл1Комплекта();

                if (timer_Лампочка1КомплектПрмДаб5ГИмКк != null)
                    timer_Лампочка1КомплектПрмДаб5ГИмКк.Dispose();
                _Лампочка1КомплектПрмДаб5ГИмКк = true;
                timer_Лампочка1КомплектПрмДаб5ГИмКк = EasyTimer.SetTimeout(() => 
                {
                    _Лампочка1КомплектПрмДаб5ГИмКк = false;
                    Refresh();
                    timer_Лампочка1КомплектПрмДаб5ГИмКк.Dispose();
                }, 2000);

                if (timer_Лампочка1КомплектПрмДаб5ГИмСс != null)
                    timer_Лампочка1КомплектПрмДаб5ГИмСс.Dispose();
                _Лампочка1КомплектПрмДаб5ГИмСс = true;
                timer_Лампочка1КомплектПрмДаб5ГИмСс = EasyTimer.SetTimeout(() =>
                {
                    _Лампочка1КомплектПрмДаб5ГИмСс = false;
                    Refresh();
                    timer_Лампочка1КомплектПрмДаб5ГИмСс.Dispose();
                }, 2000);

                if (timer_Лампочка1КомплектПрмДаб5ГИмТлф != null)
                    timer_Лампочка1КомплектПрмДаб5ГИмТлф.Dispose();
                _Лампочка1КомплектПрмДаб5ГИмТлф = true;
                timer_Лампочка1КомплектПрмДаб5ГИмТлф = EasyTimer.SetTimeout(() =>
                {
                    _Лампочка1КомплектПрмДаб5ГИмТлф = false;
                    Refresh();
                    timer_Лампочка1КомплектПрмДаб5ГИмТлф.Dispose();
                }, 4000);

                if (timer_Лампочка1КомплектПрмДаб5ГЦСнх != null)
                    timer_Лампочка1КомплектПрмДаб5ГЦСнх.Dispose();
                timer_Лампочка1КомплектПрмДаб5ГЦСнх = EasyTimer.SetTimeout(() =>
                {
                    _Лампочка1КомплектПрмДаб5ГЦСнх = true;
                    Refresh();
                    timer_Лампочка1КомплектПрмДаб5ГЦСнх = EasyTimer.SetTimeout(() =>
                    {
                        _Лампочка1КомплектПрмДаб5ГЦСнх = false;
                        Refresh();
                        timer_Лампочка1КомплектПрмДаб5ГЦСнх.Dispose();
                    }, 2000);
                }, 2000);
                Refresh();
            }
        }

        public static void НажатьКнопкуРежимПрм2К()
        {
            if (ЛампочкаПитание)
            {
                _ЛампочкаРежимРабота2К = false;
                _ЛампочкаРежимШлейф2К = false;
                _ЛампочкаРежимПрмПрд2К = false;
                _ЛампочкаРежимПрм2К = true;
                ВключитьЛампочкиВкл2Комплекта();

                if (timer_Лампочка2КомплектПрмДаб5ГИмКк != null)
                    timer_Лампочка2КомплектПрмДаб5ГИмКк.Dispose();
                _Лампочка2КомплектПрмДаб5ГИмКк = true;
                timer_Лампочка2КомплектПрмДаб5ГИмКк = EasyTimer.SetTimeout(() =>
                {
                    _Лампочка2КомплектПрмДаб5ГИмКк = false;
                    Refresh();
                    timer_Лампочка2КомплектПрмДаб5ГИмКк.Dispose();
                }, 2000);

                if (timer_Лампочка2КомплектПрмДаб5ГИмСс != null)
                    timer_Лампочка2КомплектПрмДаб5ГИмСс.Dispose();
                _Лампочка2КомплектПрмДаб5ГИмСс = true;
                timer_Лампочка2КомплектПрмДаб5ГИмСс = EasyTimer.SetTimeout(() =>
                {
                    _Лампочка2КомплектПрмДаб5ГИмСс = false;
                    Refresh();
                    timer_Лампочка2КомплектПрмДаб5ГИмСс.Dispose();
                }, 2000);

                if (timer_Лампочка2КомплектПрмДаб5ГИмТлф != null)
                    timer_Лампочка2КомплектПрмДаб5ГИмТлф.Dispose();
                _Лампочка2КомплектПрмДаб5ГИмТлф = true;
                timer_Лампочка2КомплектПрмДаб5ГИмТлф = EasyTimer.SetTimeout(() =>
                {
                    _Лампочка2КомплектПрмДаб5ГИмТлф = false;
                    Refresh();
                    timer_Лампочка2КомплектПрмДаб5ГИмТлф.Dispose();
                }, 4000);

                if (timer_Лампочка2КомплектПрмДаб5ГЦСнх != null)
                    timer_Лампочка2КомплектПрмДаб5ГЦСнх.Dispose();
                timer_Лампочка2КомплектПрмДаб5ГЦСнх = EasyTimer.SetTimeout(() =>
                {
                    _Лампочка2КомплектПрмДаб5ГЦСнх = true;
                    Refresh();
                    timer_Лампочка2КомплектПрмДаб5ГЦСнх = EasyTimer.SetTimeout(() =>
                    {
                        _Лампочка2КомплектПрмДаб5ГЦСнх = false;
                        Refresh();
                        timer_Лампочка2КомплектПрмДаб5ГЦСнх.Dispose();
                    }, 2000);
                }, 2000);
                Refresh();
            }
        }

        public static void НажатьКнопкуРежимВыкл1К()
        {
            _ЛампочкаРежимРабота1К = false;
            _ЛампочкаРежимШлейф1К = false;
            _ЛампочкаРежимПрмПрд1К = false;
            _ЛампочкаРежимПрм1К = false;
            ВыключитьЛампочкиВкл1Комплекта();
            СброситьВсеТаймерыИСвязанныеСНимиЛампочки1Комплекта();
            Refresh();
        }

        public static void НажатьКнопкуРежимВыкл2К()
        {
            _ЛампочкаРежимРабота2К = false;
            _ЛампочкаРежимШлейф2К = false;
            _ЛампочкаРежимПрмПрд2К = false;
            _ЛампочкаРежимПрм2К = false;
            ВыключитьЛампочкиВкл2Комплекта();
            СброситьВсеТаймерыИСвязанныеСНимиЛампочки2Комплекта();
            Refresh();
        }
        #endregion

        #region Другие функции
        private static void ВключитьЛампочкиВкл1Комплекта()
        {
            _Лампочка1КомплектПрдДаб5ГВкл = true;
            _Лампочка1КомплектПрмДаб5ГВкл = true;
        }

        private static void ВключитьЛампочкиВкл2Комплекта()
        {
            _Лампочка2КомплектПрдДаб5ГВкл = true;
            _Лампочка2КомплектПрмДаб5ГВкл = true;
        }


        private static void ВыключитьЛампочкиВкл1Комплекта()
        {
            _Лампочка1КомплектПрдДаб5ГВкл = false;
            _Лампочка1КомплектПрмДаб5ГВкл = false;
        }

        private static void ВыключитьЛампочкиВкл2Комплекта()
        {
            _Лампочка2КомплектПрдДаб5ГВкл = false;
            _Лампочка2КомплектПрмДаб5ГВкл = false;
        }


        private static void СброситьВсеТаймерыИСвязанныеСНимиЛампочки1Комплекта()
        {
            if (timer_Лампочка1КомплектПрмДаб5ГИмКк != null)
                timer_Лампочка1КомплектПрмДаб5ГИмКк.Dispose();
            _Лампочка1КомплектПрмДаб5ГИмКк = false;

            if (timer_Лампочка1КомплектПрмДаб5ГИмСс != null)
                timer_Лампочка1КомплектПрмДаб5ГИмСс.Dispose();
            _Лампочка1КомплектПрмДаб5ГИмСс = false;

            if (timer_Лампочка1КомплектПрмДаб5ГИмТлф != null)
                timer_Лампочка1КомплектПрмДаб5ГИмТлф.Dispose();
            _Лампочка1КомплектПрмДаб5ГИмТлф = false;

            if (timer_Лампочка1КомплектПрмДаб5ГЦСнх != null)
                timer_Лампочка1КомплектПрмДаб5ГЦСнх.Dispose();
            _Лампочка1КомплектПрмДаб5ГЦСнх = false;

            if (timer_Лампочка1КомплектПрмДаб5ГТСнх != null)
                timer_Лампочка1КомплектПрмДаб5ГТСнх.Dispose();
            _Лампочка1КомплектПрмДаб5ГТСнх = false;
        }

        private static void СброситьВсеТаймерыИСвязанныеСНимиЛампочки2Комплекта()
        {
            if (timer_Лампочка2КомплектПрмДаб5ГИмКк != null)
                timer_Лампочка2КомплектПрмДаб5ГИмКк.Dispose();
            _Лампочка2КомплектПрмДаб5ГИмКк = false;

            if (timer_Лампочка2КомплектПрмДаб5ГИмСс != null)
                timer_Лампочка2КомплектПрмДаб5ГИмСс.Dispose();
            _Лампочка2КомплектПрмДаб5ГИмСс = false;

            if (timer_Лампочка2КомплектПрмДаб5ГИмТлф != null)
                timer_Лампочка2КомплектПрмДаб5ГИмТлф.Dispose();
            _Лампочка2КомплектПрмДаб5ГИмТлф = false;

            if (timer_Лампочка2КомплектПрмДаб5ГЦСнх != null)
                timer_Лампочка2КомплектПрмДаб5ГЦСнх.Dispose();
            _Лампочка2КомплектПрмДаб5ГЦСнх = false;

            if (timer_Лампочка2КомплектПрмДаб5ГТСнх != null)
                timer_Лампочка2КомплектПрмДаб5ГТСнх.Dispose();
            _Лампочка2КомплектПрмДаб5ГТСнх = false;
        }
        #endregion

        private static void TurnOff()
        {
            #region Лампочки ДАБ-5 УП
            _ЛампочкаРежимАвтом = false;
            _ЛампочкаРежимРучн = false;
            _ЛампочкаВыборПрмПрд1 = false;
            _ЛампочкаВыборПрмПрд2 = false;
            _ЛампочкаВыборБП1 = false;
            _ЛампочкаВыборБП2 = false;
            _ЛампочкаРежимРабота1К = false;
            _ЛампочкаРежимРабота2К = false;
            _ЛампочкаРежимШлейф1К = false;
            _ЛампочкаРежимШлейф2К = false;
            _ЛампочкаРежимПрмПрд1К = false;
            _ЛампочкаРежимПрмПрд2К = false;
            _ЛампочкаРежимПрм1К = false;
            _ЛампочкаРежимПрм2К = false;
            #endregion

            ВыключитьЛампочкиВкл1Комплекта();
            ВыключитьЛампочкиВкл2Комплекта();
            СброситьВсеТаймерыИСвязанныеСНимиЛампочки1Комплекта();
            СброситьВсеТаймерыИСвязанныеСНимиЛампочки2Комплекта();
        }

        private static void TurnOn()
        {
            НажатьКнопкуРежимРучн();
            НажатьКнопкуВыборПрмПрд1();
            НажатьКнопкуВыборБП1();
            НажатьКнопкуРежимРабота1К();
            НажатьКнопкуРежимРабота2К();
        }

        public delegate void VoidVoidSignature();
        public static event VoidVoidSignature RefreshForm;

        public static void Refresh()
        {
            if (RefreshForm != null)
                RefreshForm();
        }
    }
}