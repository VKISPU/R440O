using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using R440O.R440OForms.K02M_01;
using R440O.R440OForms.K02M_01Inside;
using R440O.R440OForms.K03M_01Inside;
using R440O.R440OForms.K04M_01;
using R440O.R440OForms.K05M_01;
using R440O.R440OForms.K05M_01Inside;

namespace R440O.R440OForms.K03M_01
{
    static class K03M_01Parameters
    {
        // Внимание, в OnParameterChanged добавлен вызов метода.
        #region событие

        public delegate void ParameterChangedHandler();
        public static event ParameterChangedHandler ParameterChanged;

        private static void OnParameterChanged()
        {
            // При каждом изменении любого тумблера надо обновлять значения
            ПересчитатьМаксимальноеИМинимальноеЗнчения();
            var handler = ParameterChanged;
            if (handler != null) handler();
        }

        public static void ResetParameters()
        {
            OnParameterChanged();
        }

        #endregion

        #region Лампочки
        public static bool Лампочка0
        {
            get { return (_текущееЗначениеПоиска >= 0); }
        }
        public static bool Лампочка1
        {
            get
            {
                return ((_текущееЗначениеПоиска > 0 && _текущееЗначениеПоиска%2 > 0)
                        || (_текущееЗначениеПоиска < 0 && -(_текущееЗначениеПоиска + 1)%2 <= 0));
            }
        }
        public static bool Лампочка2
        {
            get
            {
                return ((_текущееЗначениеПоиска > 0 && _текущееЗначениеПоиска%4 > 1) ||
                    (_текущееЗначениеПоиска < 0 && -(_текущееЗначениеПоиска + 1) % 4 <= 1));
            }
        }
        public static bool Лампочка4
        {
            get
            {
                return ((_текущееЗначениеПоиска > 0 && _текущееЗначениеПоиска % 8 > 3) ||
                  (_текущееЗначениеПоиска < 0 && -(_текущееЗначениеПоиска + 1) % 8 <= 3));
            }
        }
        public static bool Лампочка8
        {
            get
            {
                return ((_текущееЗначениеПоиска > 0 && _текущееЗначениеПоиска % 16 > 7) ||
                  (_текущееЗначениеПоиска < 0 && -(_текущееЗначениеПоиска + 1) % 16 <= 7));
            }
        }
        public static bool Лампочка16
        {
            get
            {
                return ((_текущееЗначениеПоиска > 0 && _текущееЗначениеПоиска % 32 > 15) ||
                (_текущееЗначениеПоиска < 0 && -(_текущееЗначениеПоиска + 1) % 32 <= 15));
            }
        }
        public static bool Лампочка32
        {
            get
            {
                return ((_текущееЗначениеПоиска > 0 && _текущееЗначениеПоиска % 64 > 31) ||
                (_текущееЗначениеПоиска < 0 && -(_текущееЗначениеПоиска + 1) % 64 <= 31));
            }
        }
        #endregion

        #region Переключатели
        private static bool _переключатель0 = false;
        private static bool _переключатель1 = false;
        private static bool _переключатель2 = false;
        private static bool _переключатель4 = false;
        private static bool _переключатель8 = false;
        private static bool _переключатель16 = false;
        private static bool _переключатель32 = false;
        private static bool _переключательНепрОднокр = true;
        private static bool _переключательАвтРучн = true;


        /// <summary>
        /// Положение переключателя контроля
        /// </summary>
        private static int _переключательЗонаПоиска = 1;

        public static bool Переключатель0
        {
            get
            {
                return _переключатель0;
            }
            set
            {
                _переключатель0 = value;
                ResetParameters();
            }
        }
        public static bool Переключатель1
        {
            get
            {
                return _переключатель1;
            }
            set
            {
                _переключатель1 = value;
                ResetParameters();
            }
        }
        public static bool Переключатель2
        {
            get
            {
                return _переключатель2;
            }
            set
            {
                _переключатель2 = value;
                ResetParameters();
            }
        }
        public static bool Переключатель4
        {
            get
            {
                return _переключатель4;
            }
            set
            {
                _переключатель4 = value;
                ResetParameters();
            }
        }
        public static bool Переключатель8
        {
            get
            {
                return _переключатель8;
            }
            set
            {
                _переключатель8 = value;
                ResetParameters();
            }
        }
        public static bool Переключатель16
        {
            get
            {
                return _переключатель16;
            }
            set
            {
                _переключатель16 = value;
                ResetParameters();
            }
        }
        public static bool Переключатель32
        {
            get
            {
                return _переключатель32;
            }
            set
            {
                _переключатель32 = value;
                ResetParameters();
            }
        }
        public static bool ПереключательНепрОднокр
        {
            get
            {
                return _переключательНепрОднокр;
            }
            set
            {
                _переключательНепрОднокр = value;
                ResetParameters();
                if (value)
                {
                    НачатьПоискСНачала();
                }
                else
                {
                    НачатьРучнойПоиск();
                }
            }
        }
        public static bool ПереключательАвтРучн
        {
            get
            {
                return _переключательАвтРучн;
            }
            set
            {
                _переключательАвтРучн = value;
                ResetParameters();
                if (value)
                {
                    НачатьПоискСНачала();
                }
                else
                {
                    НачатьРучнойПоиск();
                }
            }
        }

        public static int ПереключательЗонаПоиска
        {
            get
            {
                return _переключательЗонаПоиска;
            }

            set
            {
                if (value > 0 && value < 5)
                {
                    _переключательЗонаПоиска = value;
                    ResetParameters();
                }
            }
        }
        #endregion        

        #region Логика работы Поиск

        // 0 и -0 в значении поиска это разные вещи, поэтому, для удобства,
        // все отрицательные значения сдвинуты на 1,
        // То есть -1 это на самом деле -0, а -2 это -1
        // 0 это и есть 0, то есть +0.

        private static int _временнаяПозицияПоиска;

        public static int ВременнаяПозицияПоиска
        {
            get { return _временнаяПозицияПоиска; }
        }

        public static void ИзменитьВременнуюПозициюПоиска(int delta)
        {
            if (СтатусПоиска == 2)
            {
                _временнаяПозицияПоиска += delta;
                if (_временнаяПозицияПоиска > 1000 || _временнаяПозицияПоиска < -1000)
                {
                    _временнаяПозицияПоиска *= -1;
                }
            }
            K02M_01Parameters.ResetParameters();
        }



        /// <summary>
        /// 0 - Поиск не идёт и ничего не найдено
        /// 1 - Ищется
        /// 2 - Найдено
        /// 3 - Ручной поиск
        /// </summary>
        public static int СтатусПоиска
        {
            get { return _статусПоиска; }
        }

        public static int ЗначениеПоиска
        {
            get { return (_текущееЗначениеПоиска < 0) ? _текущееЗначениеПоиска + 1 : _текущееЗначениеПоиска; }
        }

        public static void ПересчитатьНайденоИлиНеНайдено()
        {
            // Если частота совпадает при ПереключательПередачаКонтроль на к05 = прм
            // Или если частота совпадает по другому при ПереключательПередачаКонтроль на к05 !=прм
            // И ещё в придачу если все ключи совпадают
            if (((K04M_01Parameters.ЧастотаПрм + ЗначениеПоиска == K04M_01Parameters.ЧастотаПрд) &&
                 (K05M_01Parameters.ПереключательПередачаКонтроль == 1) ||
                 (K04M_01Parameters.ЧастотаПрм + ЗначениеПоиска + K04M_01Parameters.ЧастотаПрд == 140000) &&
                 (K05M_01Parameters.ПереключательПередачаКонтроль != 1)) &&
                K05M_01InsideParameters.Переключатель.GetArray()
                    .SequenceEqual(K03M_01InsideParameters.Переключатели.GetArray()))
            {
                // Найдено. Поиск останавливается.
                Найдено();
            }
            else
            {
                // Не найдено. Поиск стартует или продолжается.
                if (_статусПоиска == 2)
                {
                    НачатьПоискСНачала();
                }
            }
            Debug.WriteLine("СтатусПоиска: " + СтатусПоиска);
            Debug.WriteLine("Частота прм: " + K04M_01Parameters.ЧастотаПрм);
            Debug.WriteLine("Частота прд: " + K04M_01Parameters.ЧастотаПрд);
            Debug.WriteLine("ЗначениеПоиска: " + ЗначениеПоиска);
        }


        private static readonly Timer _таймерДляПоиска = new Timer();
        private static int _текущееЗначениеПоиска;
        private static int _максимальноеЗначениеПоиска;
        private static int _минимальноеЗначениеПоиска;
        private static int _статусПоиска;


        public static void НачатьПоискСНачала()
        {
            _временнаяПозицияПоиска = 0;
            _статусПоиска = 1;
            ПересчитатьМаксимальноеИМинимальноеЗнчения();
            _текущееЗначениеПоиска = ПолучитьНачальноеЗначениеПоиска();
            ResetParameters();
            if (!_таймерДляПоиска.Enabled)
            {
                _таймерДляПоиска.Tick += ТикТаймераДляПоиска;
                _таймерДляПоиска.Interval = 1000;
                _таймерДляПоиска.Enabled = true;
            }

            K02M_01Parameters.ResetParameters();
        }

        public static void ОтменитьПоиск()
        {
            _статусПоиска = 0;
            if (_таймерДляПоиска.Enabled)
            {
                _таймерДляПоиска.Tick -= ТикТаймераДляПоиска;
                _таймерДляПоиска.Enabled = false;
            }
            ResetParameters();

            K02M_01Parameters.ResetParameters();
        }

        private static void Найдено()
        {
            _статусПоиска = 2;
            if (_таймерДляПоиска.Enabled)
            {
                _таймерДляПоиска.Tick -= ТикТаймераДляПоиска;
                _таймерДляПоиска.Enabled = false;
            }
            ResetParameters();

            K02M_01Parameters.ResetParameters();
        }

        private static void НачатьРучнойПоиск()
        {
            _статусПоиска = 3;
            if (_таймерДляПоиска.Enabled)
            {
                _таймерДляПоиска.Tick -= ТикТаймераДляПоиска;
                _таймерДляПоиска.Enabled = false;
            }
            ResetParameters();

            K02M_01Parameters.ResetParameters();
        }


        /// <summary>
        /// Когда меняются параметры (тумблеры или переключатель), надо изменять
        /// максимальное и минимальное значения поиска.
        /// </summary>
        private static void ПересчитатьМаксимальноеИМинимальноеЗнчения()
        {
            // Если зона поиска стоит +-64 то логика другая
            if (ПереключательЗонаПоиска == 4)
            {
                _максимальноеЗначениеПоиска = 64;
                _минимальноеЗначениеПоиска = -64-1;
            }
            else
            {
                // Которая выставлена переключателем на блоке (+2, +8, +32)
                // Для +-64 логика другая!
                int зонаПоиска = 0;
                switch (ПереключательЗонаПоиска)
                {
                    case 1:
                        зонаПоиска = 2;
                        break;
                    case 2:
                        зонаПоиска = 8;
                        break;
                    case 3:
                        зонаПоиска = 32;
                        break;
                }
                _минимальноеЗначениеПоиска = ПолучитьНачальноеЗначениеПоиска();
                _максимальноеЗначениеПоиска = _минимальноеЗначениеПоиска + зонаПоиска-1;
            }
        }

        private static void ТикТаймераДляПоиска(object o, EventArgs e)
        {
            // Текущее значение поиска увеличивается на 1, если доходит до максимума, скидывается в минимум.
            if (_текущееЗначениеПоиска >= _максимальноеЗначениеПоиска ||
                _текущееЗначениеПоиска < _минимальноеЗначениеПоиска)
            {
                _текущееЗначениеПоиска = _минимальноеЗначениеПоиска;
            }
            else
            {
                _текущееЗначениеПоиска++;
            }
            ПересчитатьНайденоИлиНеНайдено();
            ResetParameters();
        }

        /// <summary>
        /// По тумблерам определяет начальное значение зоны поиска
        /// (тумблеры в двоичной системе число представляют почти)
        /// </summary>
        /// <returns></returns>
        private static int ПолучитьНачальноеЗначениеПоиска()
        {
            int value = 0;
            value += (Переключатель1) ? 1 : 0;
            value += (Переключатель2) ? 2 : 0;
            value += (Переключатель4) ? 4 : 0;
            value += (Переключатель8) ? 8 : 0;
            value += (Переключатель16) ? 16 : 0;
            value += (Переключатель32) ? 32 : 0;
            // Переключатель ноль отвечает за знак
            // Если значение отрицательное, то убавляем его на 1,
            // Это чтобы -0 мог влезть в последовательность
            // -1 это на самом деле -0
            if (Переключатель0)
            {
                value = -value - 1;
            }
            return value;
        }

        #endregion
    }
}
