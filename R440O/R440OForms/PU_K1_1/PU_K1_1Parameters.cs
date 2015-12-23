using System.Security.Cryptography.X509Certificates;
using R440O.R440OForms.K03M_01;
using R440O.R440OForms.N15;
using R440O.R440OForms.N502B;
using R440O.ThirdParty;

namespace R440O.Parameters
{
    static class PU_K1_1Parameters
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
            OnParameterChanged();
        }

        #endregion

        #region Лампочка

        public static bool ЛампочкаCеть
        {
            get { return K03M_01Parameters.БлокВключен; }
        }

        #endregion
        
        #region Тумблеры
        ////Тумблеры 
        /// <summary>
        /// Возможные состояния: 0. Дист - дистанционное управление, 1. Откл - отключено, 2. Мест - местное управление.
        /// </summary>
        private static int _ТумблерПитание = 1;

        /// <summary>
        /// Флаг нужен чтобы после удалённого включения блока, когда тумблер на пук
        /// переводится в положения выкл., а потом обратно на удалённое включение,
        /// чтоб блок включался сразу же.
        /// </summary>
        private static bool _включенУдаленно = false;

        public static int ТумблерПитание
        {
            get { return _ТумблерПитание; }

            set
            {
                if (value >= 0 && value <= 2)
                {
                    _ТумблерПитание = value;
                    if (value == 0 && _включенУдаленно)
                    {
                        ВключитьБлок();
                    }
                    if (value == 2 && N15Parameters.Лампочка27В && N502BParameters.ТумблерН15)
                    {
                        ВключитьБлок();
                    }
                    if (value == 1)
                    {
                        ВыключитьБлок();
                    }
                     ResetParameters();
                }
            }
        }

        private static bool _ТумблерВентВкл = false;

        public static bool ТумблерВентВкл
        {
            get { return _ТумблерВентВкл; }
            set
            {
                _ТумблерВентВкл = value;
                ResetParameters();
            }
        }
        #endregion

        #region Переключатели
        /// <summary>
        /// Положение переключателя контроля
        /// </summary>
        private static int _ПереключательКаналы = 1;

        public static int ПереключательКаналы
        {
            get
            {
                return _ПереключательКаналы;
            }

            set
            {
                if (value > 0 && value < 5)
                {
                    _ПереключательКаналы = value;
                    ResetParameters();
                }
            }
        }

        /// <summary>
        /// Положение переключателя контроля
        /// </summary>
        private static int _ПереключательНапряжение = 1;

        public static int ПереключательНапряжение
        {
            get
            {
                return _ПереключательНапряжение;
            }

            set
            {
                if (value > 0 && value < 13)
                {
                    _ПереключательНапряжение = value;
                    if (K03M_01Parameters.БлокВключен)
                    {
                        АктивизироватьСтрелкуНапряжения();
                    }
                    ResetParameters();
                }
            }
        }

        // Какой-то трэш
        /*
        /// <summary>
        /// Названия положений переключателя контроля. Второй столбец - комплект включён. Третий - комплект выключен.
        /// </summary>
        public static string[,] _ЗначенияПереключательНапряжение = { 
            { "-27", "0" },
            { "-12,6", "0" },
            { "-5", "0" },
            { "+5", "0" },
            { "+6", "0" },
            { "+12,6 I", "0" },
            { "+12,6 III", "0" },
            { "+23 I", "0" },
            { "+23 II", "0" },
            { "+60 I", "0" },
            { "+60 II", "0" },
            { "+120", "0" }
        };
        /// <summary>
        /// Названия положений переключателя контроля. Второй столбец - комплект включён. Третий - комплект выключен.
        /// </summary>
           public static string[,] _ЗначенияПереключательКаналы = { 
                { "ПРМ 1", "0" },
                { "ПРМ 2", "0" },
                { "ПРД 1", "0" },
                { "ПРД 2", "0" }
            };
         */
        #endregion

        private static int _напряжение = 0;

        public static int Напряжение
        {
            get { return _напряжение; }
            set
            {
                if (value >= 0 && value <= 20)
                {
                    _напряжение = value;
                }
            }
        }

        public static bool ПопытатьсяВключитьБлокУдаленно()
        {
            _включенУдаленно = true;
            if (ТумблерПитание == 0)
            {
                ВключитьБлок();
                return true;
            }
            return false;
        }

        public static bool ПопытатьсяВыключитьБлокУдаленно()
        {
            _включенУдаленно = false;
            if (ТумблерПитание == 0)
            {
                ВыключитьБлок();
                return true;
            }
            return false;
        }

        public static void АктивизироватьСтрелкуНапряжения()
        {
            Напряжение = 7;
            EasyTimer.SetTimeout((() =>
            {
                Напряжение = 10;
                ResetParameters();
            }), 300);
        }



        public static void ВключитьБлок()
        {
            K03M_01Parameters.БлокВключен = true;
            K03M_01Parameters.НачатьПоискСНачала();
            АктивизироватьСтрелкуНапряжения();

            ResetParameters();
            K03M_01Parameters.ResetParameters();
        }

        public static void ВыключитьБлок()
        {
            K03M_01Parameters.ОтменитьПоиск();
            K03M_01Parameters.БлокВключен = false;
            Напряжение = 0;
            ResetParameters();
            K03M_01Parameters.ResetParameters();
        }
    }
}
