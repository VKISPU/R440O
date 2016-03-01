using R440O.R440OForms.BMB;
using R440O.R440OForms.N502B;
using R440O.R440OForms.TLF_TCH;

namespace R440O.Parameters
{
    using System;

    using СостоянияЭлементов.БМА_М;
    using R440OForms.N15;
    using ThirdParty;

    class BMA_M_1Parameters
    {

        #region Питнаие

        private static bool _питание;
        public static bool Питание
        {
            get { return _питание && ПитаниеН502; }
            set
            {
                bool last = _питание;
                _питание = value;
                if (!last && _питание)
                {
                    BMBParameters.ОбнулитьНабор();
                    BMBParameters.МерцаниеЛампочиНаправления(1);
                }
                N15Parameters.ResetParametersAlternative();       
                Refresh();
            }
        }
        
        public static bool ПитаниеН502
        {
            get
            {
               return N502BParameters.ТумблерВыпрямитель27В
                      && N502BParameters.ТумблерЭлектрооборудование
                      && N502BParameters.ЛампочкаСфазировано;
            }
        }
        #endregion

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
                Refresh();
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
                Refresh();
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
                Refresh();
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
                Refresh();
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
                Refresh();
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
                Refresh();
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
                Refresh();
            }
        }
        #endregion

        #endregion

        #region Кнопки
        private static bool _кнопкаШлейфТЧ;
        private static bool _кнопкаШлейфДК;

        public static bool КнопкаШлейфДК
        {
            get { return _кнопкаШлейфДК; }
            set
            {
                _кнопкаШлейфДК = value;
                Refresh();
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
                Refresh();
            }
        }
        #endregion

        #region Лампочки
        
        public static bool ЛампочкаДК
        {
            get
            {
                switch (ПереключательКонтроль)
                {
                    case (EПереключательКонтроль.РАБОТА_1):
                    case (EПереключательКонтроль.РАБОТА_2):
                        {

                            return Питание && !(BMBParameters.ЛампочкаДк && BMBParameters.ПереключательРаботаКонтроль == 1
                            || КнопкаШлейфДК);
                        }
                    case (EПереключательКонтроль.ТЧ):
                        {
                            return false;
                        }
                    case (EПереключательКонтроль.ДК):
                        {
                            return false;
                        }
                }
                return false;     
            }
        }
        public static bool ЛампочкаСинхрТЧ
        {
            get
            {
                switch (ПереключательКонтроль)
                {
                    case (EПереключательКонтроль.РАБОТА_1):
                    case (EПереключательКонтроль.РАБОТА_2):
                        {

                            return Питание && (КнопкаШлейфТЧ);
                        }
                    case (EПереключательКонтроль.ТЧ):
                        {
                            return Питание && (КнопкаШлейфДК || (!TLF_TCHParametrs.БМА1ПередачаКаналТЧ));
                        }
                }
                return false;
            }
        }
        public static bool ЛампочкаСинхрДК = false;
        public static bool ЛампочкаТЧБ
        {
            get
            {
                switch (ПереключательКонтроль)
                {
                    case (EПереключательКонтроль.РАБОТА_1):
                    case (EПереключательКонтроль.РАБОТА_2):
                        {

                            return Питание && (BMBParameters.ЛампочкаТч && 
                            КнопкаШлейфТЧ && BMBParameters.ПереключательРаботаКонтроль == 1);
                        }
                    case (EПереключательКонтроль.ТЧ):
                        {
                            return false;
                        }
                    case (EПереключательКонтроль.ДК):
                        {
                            return false;
                        }
                }
                return false;
            }
        }
        public static bool ЛампочкаФЗ
        {
              get
            {
                switch (ПереключательКонтроль)
                {
                    case (EПереключательКонтроль.РАБОТА_1):
                    case (EПереключательКонтроль.РАБОТА_2):
                        {
                            return Питание && (КнопкаШлейфТЧ);
                        }
                    case (EПереключательКонтроль.ТЧ):
                        {
                            return false;
                        }
                    case (EПереключательКонтроль.ДК):
                        {
                            return false;
                        }
                }
                return false;
            }
            
        }
        public static bool ЛампочкаПрдТЧ
        {
            get
            {
                switch (ПереключательКонтроль)
                {
                    case (EПереключательКонтроль.РАБОТА_1):
                    case (EПереключательКонтроль.РАБОТА_2):
                        {
                            return Питание
                                && !(КнопкаШлейфТЧ
                                && BMBParameters.ПереключательРаботаКонтроль == 1
                                && BMBParameters.КнопкаПередачаВызоваТч == СостоянияЭлементов.БМБ.Кнопка.Горит
                                && BMBParameters.КнопкаСлСвязь == СостоянияЭлементов.БМБ.Кнопка.Горит);
                        }
                    case (EПереключательКонтроль.ТЧ):
                        {
                            return false;
                        }
                    case (EПереключательКонтроль.ДК):
                        {
                            return false;
                        }
                }
                return false;
            }
        }
        public static bool ЛампочкаПрмТЧ
        {
            get
            {
                switch (ПереключательКонтроль)
                {
                    case (EПереключательКонтроль.РАБОТА_1):
                    case (EПереключательКонтроль.РАБОТА_2):
                        {
                            return Питание && !КнопкаШлейфТЧ;
                        }
                    case (EПереключательКонтроль.ТЧ):
                        {
                            return false;
                        }
                    case (EПереключательКонтроль.ДК):
                        {
                            return false;
                        }
                }
                return false;
                //        && !TLF_TCHParametrs.БМА1ПриемКаналТЧ;

            }
        }
        public static bool ЛампочкаПрдДК
        {
            get
            {
                switch (ПереключательКонтроль)
                {
                    case (EПереключательКонтроль.РАБОТА_1):
                    case (EПереключательКонтроль.РАБОТА_2):
                        {
                            return Питание//N15Parameters.ЛампочкаБМА_1                            
                            && !(КнопкаШлейфДК
                            && BMBParameters.ПереключательРаботаКонтроль == 1
                            && BMBParameters.КнопкаПередачаВызоваДк == СостоянияЭлементов.БМБ.Кнопка.Горит
                            && BMBParameters.КнопкаСлСвязь == СостоянияЭлементов.БМБ.Кнопка.Горит);
                        }
                    case (EПереключательКонтроль.ТЧ):
                        {
                            return false;
                        }
                    case (EПереключательКонтроль.ДК):
                        {
                            return false;
                        }
                }
                return false;
            }
        }
        public static bool ЛампочкаПрмФР
        {
            get
            {             
                switch (ПереключательКонтроль)
                {
                    case (EПереключательКонтроль.РАБОТА_1):
                    case (EПереключательКонтроль.РАБОТА_2):
                        {
                            return Питание//N15Parameters.ЛампочкаБМА_1                            
                            && КнопкаШлейфТЧ;
                        }
                    case (EПереключательКонтроль.ТЧ):
                        {
                            return false;
                        }
                    case (EПереключательКонтроль.ДК):
                        {
                            return false;
                        }
                }
                return false;
            }
        }
        public static bool ЛампочкаПрмДК1
        {
            get
            {
                switch (ПереключательКонтроль)
                {
                    case (EПереключательКонтроль.РАБОТА_1):
                    case (EПереключательКонтроль.РАБОТА_2):
                        {
                            return Питание && !(BMBParameters.ЛампочкаДк && BMBParameters.ПереключательРаботаКонтроль == 1
                            || КнопкаШлейфДК);
                        }
                    case (EПереключательКонтроль.ТЧ):
                        {
                            return false;
                        }
                    case (EПереключательКонтроль.ДК):
                        {
                            return false;
                        }
                }
                return false;
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
                if (Питание//N15Parameters.ЛампочкаБМА_1
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
                if (Питание
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
                return Питание &&
                    ПереключательКонтроль == EПереключательКонтроль.ТЕСТ;
            }
        }
        public static bool ЛампочкаКонтрольДК
        {
            get
            {
                return Питание &&
                    ПереключательКонтроль == EПереключательКонтроль.ДК;
            }
        }
        public static bool ЛампочкаКонтрольТЧ
        {
            get
            {
                return Питание &&
                    ПереключательКонтроль == EПереключательКонтроль.ТЧ;
            }
        }
        public static bool ЛампочкаКонтрольКомпл
        {
            get
            {
                return Питание &&
                    ПереключательКонтроль == EПереключательКонтроль.КОМПЛ;
            }
        }

        public static bool ЛампочкаРекуррента15
        {
            get
            {
                return Питание &&
                    ПереключательРекуррента == EПереключательРекуррента._15;
            }
        }
        public static bool ЛампочкаРекуррента31
        {
            get
            {
                return Питание &&
                    ПереключательРекуррента == EПереключательРекуррента._31;
            }
        }
        public static bool ЛампочкаРекуррента511
        {
            get
            {
                return Питание &&
                    ПереключательРекуррента == EПереключательРекуррента._511;
            }
        }
        public static bool ЛампочкаРекуррента1023
        {
            get
            {
                return Питание &&
                    ПереключательРекуррента == EПереключательРекуррента._1023;
            }
        }

        public static bool ЛампочкаАвтомКоманда1 = false;
        public static bool ЛампочкаАвтомКоманда2 = false;
        public static bool ЛампочкаИсправно
        {
            get
            {
                return Питание;
            }
        }
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
