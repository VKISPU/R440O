using R440O.R440OForms.BMB;

namespace R440O.Parameters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using СостоянияЭлементов.БМА_М;
    using R440O.R440OForms;
    using R440O.R440OForms.N15;
    using R440O.ThirdParty;

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
                {
                    _ПереключательКонтроль = value;
                    _ЛампочкаКонтрольНенорм = true;
                    _ЛампочкаКонтрольНорм = false;
                    if (timer_ЛампочкаКонтрольНенорм != null)
                        timer_ЛампочкаКонтрольНенорм.Dispose();
                    Refresh();
                }
                
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
                Refresh();
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
        private static bool _кнопкаПитаниеВКЛ;
        private static bool _кнопкаШлейфТЧ;
        private static bool _кнопкаШлейфДК;
        public static bool КнопкаПитаниеВЫКЛ;

        public static bool КнопкаПитаниеВкл
        {
            get { return _кнопкаПитаниеВКЛ; }
            set
            {
                _кнопкаПитаниеВКЛ = value;
                BMBParameters.ResetParameters();
            }
        }

        public static bool КнопкаШлейфДК
        {
            get { return _кнопкаШлейфДК; }
            set
            {
                _кнопкаШлейфДК = value;
                BMBParameters.ResetParameters();
            }
        }

        public static bool КнопкаШлейфТЧ
        {
            get { return _кнопкаШлейфТЧ; }
            set
            {
                _кнопкаШлейфТЧ = value;
                BMBParameters.ResetParameters();
            }
        }
        #endregion

        #region Лампочки
        public static bool ЛампочкаТЧБ
        {
            get
            {
                return N15Parameters.ЛампочкаБМА_1
                    && (ПереключательКонтроль == EПереключательКонтроль.РАБОТА_1
                    || ПереключательКонтроль == EПереключательКонтроль.РАБОТА_2);
            }
        }
        public static bool ЛампочкаФЗ = false;
        public static bool ЛампочкаДК
        {
            get
            {
                return N15Parameters.ЛампочкаБМА_1
                    && (ПереключательКонтроль == EПереключательКонтроль.РАБОТА_1
                    || ПереключательКонтроль == EПереключательКонтроль.РАБОТА_2);
            }
        }
        public static bool ЛампочкаСинхрТЧ = false;
        public static bool ЛампочкаСинхрДК = false;
        public static bool ЛампочкаПрдТЧ
        {
            get
            {
                return N15Parameters.ЛампочкаБМА_1
                    && (ПереключательКонтроль == EПереключательКонтроль.РАБОТА_1
                    || ПереключательКонтроль == EПереключательКонтроль.РАБОТА_2);
            }
        }
        public static bool ЛампочкаПрдДК = false;
        public static bool ЛампочкаПрмТЧ
        {
            get
            {
                return N15Parameters.ЛампочкаБМА_1
                    && (ПереключательКонтроль == EПереключательКонтроль.РАБОТА_1
                    || ПереключательКонтроль == EПереключательКонтроль.РАБОТА_2);
            }
        }
        public static bool ЛампочкаПрмФР = false;
        public static bool ЛампочкаПрмДК1
        {
            get
            {
                return N15Parameters.ЛампочкаБМА_1
                    && (ПереключательКонтроль == EПереключательКонтроль.РАБОТА_1
                    || ПереключательКонтроль == EПереключательКонтроль.РАБОТА_2);
            }
        }
        public static bool ЛампочкаПрмДК2 = false;

        public static bool ЛампочкаПитание_5В = false;
        public static bool ЛампочкаПитание_10В = false;
        public static bool ЛампочкаПитание_12В = false;
        public static bool ЛампочкаПитание_15В = false;
        public static bool ЛампочкаПитание_15Вplus = false;


        private static IDisposable timer_ЛампочкаКонтрольНенорм = null;
        public static bool _ЛампочкаКонтрольНенорм = true;
        public static bool ЛампочкаКонтрольНенорм
        {
            get
            {
                if (N15Parameters.ЛампочкаБМА_1
                    && (ПереключательКонтроль > EПереключательКонтроль.РАБОТА_1
                  && ПереключательКонтроль < EПереключательКонтроль.РАБОТА_2)
                    && _ЛампочкаКонтрольНенорм)
                {
                    timer_ЛампочкаКонтрольНенорм = EasyTimer.SetTimeout(() =>
                    {
                        _ЛампочкаКонтрольНорм = true;
                        Refresh();                        
                    }, 4000);
                    timer_ЛампочкаКонтрольНенорм = EasyTimer.SetTimeout(() =>
                    {
                        _ЛампочкаКонтрольНенорм = false;
                        Refresh();
                    }, 8000);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool _ЛампочкаКонтрольНорм = false;
        public static bool ЛампочкаКонтрольНорм
        {
            get
            {
                if (N15Parameters.ЛампочкаБМА_1
                    && (ПереключательКонтроль > EПереключательКонтроль.РАБОТА_1
                  && ПереключательКонтроль < EПереключательКонтроль.РАБОТА_2)
                    && _ЛампочкаКонтрольНорм)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool ЛампочкаКонтрольТест
        {
            get
            {
                return N15Parameters.ЛампочкаБМА_1 && ПереключательКонтроль == EПереключательКонтроль.ТЕСТ;
            }
        }
        public static bool ЛампочкаКонтрольДК
        {
            get
            {
                return N15Parameters.ЛампочкаБМА_1 && ПереключательКонтроль == EПереключательКонтроль.ДК;
            }
        }
        public static bool ЛампочкаКонтрольТЧ
        {
            get
            {
                return N15Parameters.ЛампочкаБМА_1 && ПереключательКонтроль == EПереключательКонтроль.ТЧ;
            }
        }
        public static bool ЛампочкаКонтрольКомпл
        {
            get
            {
                return N15Parameters.ЛампочкаБМА_1 && ПереключательКонтроль == EПереключательКонтроль.КОМПЛ;
            }
        }

        public static bool ЛампочкаРекуррента15
        {
            get
            {
                return N15Parameters.ЛампочкаБМА_1 && ПереключательРекуррента == EПереключательРекуррента._15;
            }
        }
        public static bool ЛампочкаРекуррента31
        {
            get
            {
                return N15Parameters.ЛампочкаБМА_1 && ПереключательРекуррента == EПереключательРекуррента._31;
            }
        }
        public static bool ЛампочкаРекуррента511
        {
            get
            {
                return N15Parameters.ЛампочкаБМА_1 && ПереключательРекуррента == EПереключательРекуррента._511;
            }
        }
        public static bool ЛампочкаРекуррента1023
        {
            get
            {
                return N15Parameters.ЛампочкаБМА_1 && ПереключательРекуррента == EПереключательРекуррента._1023;
            }
        }

        public static bool ЛампочкаАвтомКоманда1 = false;
        public static bool ЛампочкаАвтомКоманда2 = false;
        public static bool ЛампочкаИсправно = false;
        public static bool ЛампочкаНеисправно = false;
        public static bool ЛампочкаРРР = false;
        public static bool ЛампочкаДист = false;


        #endregion

        public delegate void VoidVoidSignature();
        public static event VoidVoidSignature RefreshForm;

        public static void Refresh()
        {
            if (RefreshForm != null)
                RefreshForm();
        }


        public static void DisposeAllTimers()
        {
            if (timer_ЛампочкаКонтрольНенорм != null)
                timer_ЛампочкаКонтрольНенорм.Dispose();
        }

        public static void ResetLampsValue()
        {
            _ЛампочкаКонтрольНенорм = N15Parameters.ЛампочкаБМА_1;
            _ЛампочкаКонтрольНорм = !_ЛампочкаКонтрольНенорм;
        }
    }
}
