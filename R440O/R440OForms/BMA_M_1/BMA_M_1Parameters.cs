namespace R440O.Parameters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using СостоянияЭлементов.БМА_М;

    class BMA_M_1Parameters
    {
        #region Переключатели
        #region ПереключательКонтроль
        private static EПереключательКонтроль _ПереключательКонтроль = EПереключательКонтроль.РАБОТА_1;
        public static EПереключательКонтроль ПереключательКонтроль
        {
            get { return _ПереключательКонтроль; }
            set
            {
                if (value >= EПереключательКонтроль.РАБОТА_1
                    && value <= EПереключательКонтроль.РАБОТА_2)
                    _ПереключательКонтроль = value;
            }
        }
        #endregion

        #region ПереключательРекуррента
        private static EПереключательРекуррента _ПереключательРекуррента = EПереключательРекуррента._15;
        public static EПереключательРекуррента ПереключательРекуррента
        {
            get { return _ПереключательРекуррента; }
            set
            {
                if (value >= EПереключательРекуррента._15
                    && value <= EПереключательРекуррента._1023)
                    _ПереключательРекуррента = value;
            }
        }
        #endregion

        #region ПереключательРежимРаботы
        private static EПереключательРежимРаботы _ПереключательРежимРаботы = EПереключательРежимРаботы.МУ_АВТ;
        public static EПереключательРежимРаботы ПереключательРежимРаботы
        {
            get { return _ПереключательРежимРаботы; }
            set
            {
                if (value >= EПереключательРежимРаботы.МУ_АВТ
                    && value <= EПереключательРежимРаботы.ДО_АВТ) 
                    _ПереключательРежимРаботы = value;
            }
        }
        #endregion

        #region ПереключательКоррАЧХ
        private static EПереключательКоррАЧХ _ПереключательКоррАЧХ = EПереключательКоррАЧХ._1;
        public static EПереключательКоррАЧХ ПереключательКоррАЧХ
        {
            get { return _ПереключательКоррАЧХ; }
            set
            {
                if (value >= EПереключательКоррАЧХ._1
                    && value <= EПереключательКоррАЧХ._6) 
                    _ПереключательКоррАЧХ = value;
            }
        }
        #endregion

        #region ПереключательЧастотаВызова
        private static EПереключательЧастотаВызова _ПереключательЧастотаВызова = EПереключательЧастотаВызова._2d1;
        public static EПереключательЧастотаВызова ПереключательЧастотаВызова
        {
            get { return _ПереключательЧастотаВызова; }
            set
            {
                if (value >= EПереключательЧастотаВызова._2d1
                    && value <= EПереключательЧастотаВызова._3d2) 
                    _ПереключательЧастотаВызова = value;
            }
        }
        #endregion

        #region ПереключательУровниСигналаПрдПрм
        private static EПереключательУровниСигналаПрдПрм _ПереключательУровниСигналаПрдПрм = EПереключательУровниСигналаПрдПрм._m13_m13;
        public static EПереключательУровниСигналаПрдПрм ПереключательУровниСигналаПрдПрм
        {
            get { return _ПереключательУровниСигналаПрдПрм; }
            set
            {
                if (value >= EПереключательУровниСигналаПрдПрм._m13_m13
                    && value <= EПереключательУровниСигналаПрдПрм._28_m10d5) 
                    _ПереключательУровниСигналаПрдПрм = value;
            }
        }
        #endregion

        #region ПереключательРежимы
        private static EПереключательРежимы _ПереключательРежимы = EПереключательРежимы.ДОФТ;
        public static EПереключательРежимы ПереключательРежимы
        {
            get { return _ПереключательРежимы; }
            set
            {
                if (value >= EПереключательРежимы.ДОФТ
                    && value <= EПереключательРежимы.ЧТ) 
                    _ПереключательРежимы = value;
            }
        }
        #endregion

        #region ПереключательЗапретЗапроса
        private static EПереключательЗапретЗапроса _ПереключательЗапретЗапроса = EПереключательЗапретЗапроса.ВЫКЛ;
        public static EПереключательЗапретЗапроса ПереключательЗапретЗапроса
        {
            get { return _ПереключательЗапретЗапроса; }
            set
            {
                if (value >= EПереключательЗапретЗапроса.ВЫКЛ
                    && value <= EПереключательЗапретЗапроса.ВКЛ) 
                    _ПереключательЗапретЗапроса = value;
            }
        }
        #endregion

        #region ПереключательКоррКанала
        private static EПереключательКоррКанала _ПереключательКоррКанала = EПереключательКоррКанала.ВЫКЛ;
        public static EПереключательКоррКанала ПереключательКоррКанала
        {
            get { return _ПереключательКоррКанала; }
            set
            {
                if (value >= EПереключательКоррКанала.ВЫКЛ 
                    && value <= EПереключательКоррКанала.ВКЛ) 
                    _ПереключательКоррКанала = value;
            }
        }
        #endregion
        #endregion

        #region Кнопки
        public static bool КнопкаШлейфТЧ;
        public static bool КнопкаШлейфДК;
        public static bool КнопкаПитаниеВКЛ;
        public static bool КнопкаПитаниеВЫКЛ = true;
        #endregion

        #region Лампочки
        public static bool ЛампочкаТЧБ = false;
        public static bool ЛампочкаФЗ = false;
        public static bool ЛампочкаДК = false;
        public static bool ЛампочкаСинхрТЧ = false;
        public static bool ЛампочкаСинхрДК = false;
        public static bool ЛампочкаПрдТЧ = false;
        public static bool ЛампочкаПрдДК = false;
        public static bool ЛампочкаПрмТЧ = false;
        public static bool ЛампочкаПрмФР = false;
        public static bool ЛампочкаПрмДК1 = false;
        public static bool ЛампочкаПрмДК2 = false;

        public static bool ЛампочкаПитание_5В = false;
        public static bool ЛампочкаПитание_10В = false;
        public static bool ЛампочкаПитание_12В = false;
        public static bool ЛампочкаПитание_15В = false;
        public static bool ЛампочкаПитание_15Вplus = false;

        public static bool ЛампочкаКонтрольНенорм = false;
        public static bool ЛампочкаКонтрольНорм = false;
        public static bool ЛампочкаКонтрольТест = false;
        public static bool ЛампочкаКонтрольДК = false;
        public static bool ЛампочкаКонтрольТЧ = false;
        public static bool ЛампочкаКонтрольКомпл = false;

        public static bool ЛампочкаРекуррента15 = false;
        public static bool ЛампочкаРекуррента31 = false;
        public static bool ЛампочкаРекуррента511 = false;
        public static bool ЛампочкаРекуррента1023 = false;

        public static bool ЛампочкаАвтомКоманда1 = false;
        public static bool ЛампочкаАвтомКоманда2 = false;

        public static bool ЛампочкаИсправно = false;
        public static bool ЛампочкаНеисправно = false;

        public static bool ЛампочкаРРР = false;
        public static bool ЛампочкаДист = false;

        #endregion
    }
}
