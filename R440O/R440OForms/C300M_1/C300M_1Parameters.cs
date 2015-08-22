using System;
using R440O.R440OForms.N15;
using R440O.R440OForms.C300PM_1;
using R440O.R440OForms.N502B;
using System.Windows.Forms;
using R440O.BaseClasses;
using R440O.Parameters;
using R440O.ОбщиеТипыДанных;

namespace R440O.R440OForms.C300M_1
{
    class C300M_1Parameters
    {
        public static bool Питание
        {
            get { return _питание; }
            set
            {
                _питание = value;
                N15Parameters.ResetParameters();
                if (value) Search();
                OnParameterChanged();
            }
        }

        private static bool _питание = true;

        #region Кнопки ВИД РАБОТЫ

        public static double ТекущаяСкоростьРаботы
        {
            get
            {
                var speed = .0;
                switch (_кнопкаВидРаботы)
                {
                    case 0: speed = 0.025;
                        break;
                    case 1: speed = 0.25;
                        break;
                    case 2: speed = 0.1;
                        break;
                    case 3: speed = 1.2;
                        break;
                    case 4: speed = 2.4;
                        break;
                    case 5: speed = 4.8;
                        break;
                    case 6: speed = 48;
                        break;
                    case 7: speed = 96;
                        break;
                    case 8: speed = 240;
                        break;
                    case 9: speed = 480;
                        break;
                }
                return speed;
            }
        }

        /// <summary>
        /// Названия кнопок:
        /// 0 - 0.025,
        /// 1 - 0.05,
        /// 2 - 0.1,
        /// 3 - 1.2,
        /// 4 - 2.4,
        /// 5 - 4.8,
        /// 6 - 48,
        /// 7 - 96/144,
        /// 8 - 240,
        /// 9 - 480.
        /// </summary>
        public static bool[] КнопкиВидРаботы = new bool[10];
        public static int КнопкаВидРаботы
        {
            get { return _кнопкаВидРаботы; }
            set
            {
                _кнопкаВидРаботы = value;
                for (var i = 0; i < КнопкиВидРаботы.Length; i++)
                    КнопкиВидРаботы[i] = false;
                КнопкиВидРаботы[_кнопкаВидРаботы] = true;
                SetArrowIndicatorSpeed();
                Search();
                if (ParameterChanged != null) ParameterChanged();
            }
        }

        private static int _кнопкаВидРаботы = -1;

        /// <summary>
        /// Кнопка Сброс, отжимает все кнопки Вида Работы
        /// </summary>
        private static bool _кнопкаВидРаботыСброс;
        public static bool КнопкаВидРаботыСброс
        {
            get { return _кнопкаВидРаботыСброс; }
            set
            {
                _кнопкаВидРаботыСброс = value;
                for (int i = 0; i < КнопкиВидРаботы.Length; i++)
                    КнопкиВидРаботы[i] = false;
                Search();
                if (ParameterChanged != null) ParameterChanged();
            }
        }
        #endregion

        #region Кнопки КОНТРОЛЬ РЕЖИМА
        /// <summary>
        /// Названия кнопок:
        /// 0 - Уровень сигнала,
        /// 1 - Уровень шума,
        /// 2 - '0' АПЧ,
        /// 3 - Поиск,
        /// 4 - ГЕТ-2,
        /// 5 - +5,
        /// 6 - +6.3,
        /// 7 - +27,
        /// 8 - -5,
        /// 9 - -12.6.
        /// </summary>

        public static bool[] КнопкиКонтрольРежима = new bool[10];
        public static int КнопкаКонтрольРежима
        {
            get { return _кнопкаКонтрольРежима; }
            set
            {
                _кнопкаКонтрольРежима = value;

                for (int i = 0; i < КнопкиКонтрольРежима.Length; i++)
                    КнопкиКонтрольРежима[i] = false;
                КнопкиКонтрольРежима[_кнопкаКонтрольРежима] = true;
                ИндикаторСигнал = _диапазонПойманногоСигнала;
                OnParameterChanged();
                Search();
                
            }
        }
        private static int _кнопкаКонтрольРежима = -1;


        /// <summary>
        /// Кнопка -27, отжимает все кнопки Контроля Режима
        /// </summary>
        public static bool КнопкаКонтрольРежимаМинус27
        {
            get { return _кнопкаКонтрольРежимаМинус27; }
            set
            {
                _кнопкаКонтрольРежимаМинус27 = value;
                for (int i = 0; i < КнопкиКонтрольРежима.Length; i++)
                    КнопкиКонтрольРежима[i] = false;
                Search();
                OnParameterChanged();
            }
        }
        private static bool _кнопкаКонтрольРежимаМинус27;
        #endregion
        
        #region Кнопки Поиск и Индикация волны
        public static bool КнопкаПоиск
        {
            get { return _кнопкаПоиск; }
            set
            {
                _кнопкаПоиск = value;
                if (!value) ЛампочкаПоиск = false;
                Search();
            }
        }
        private static bool _кнопкаПоиск;

        public static bool КнопкаИндикацияВолны
        {
            get { return _кнопкаИндикацияВолны; }
            set { if (ЛампочкаПитание) _кнопкаИндикацияВолны = value; }
        }
        private static bool _кнопкаИндикацияВолны;
        #endregion

        #region Переключатели ВОЛНА

        public static int Волна
        {
            get
            {
                return _переключательВолна1000 * 1000
                    + _переключательВолна100 * 100
                    + _переключательВолна10 * 10
                    + _переключательВолна1;
            }
        }

        /// <summary>
        /// 0 - 4
        /// </summary>
        public static int ПереключательВолна1000
        {
            get
            {
                return _переключательВолна1000;
            }

            set
            {
                if (value >= 0 && value <= 9)
                {
                    _переключательВолна1000 = value;
                    if (ParameterChanged != null) ParameterChanged();
                }
            }
        }
        private static int _переключательВолна1000;

        /// <summary>
        /// 0 - 9
        /// </summary>
        public static int ПереключательВолна100
        {
            get
            {
                return _переключательВолна100;
            }

            set
            {
                if (value >= 0 && value <= 9)
                {
                    _переключательВолна100 = value;
                    if (ParameterChanged != null) ParameterChanged();
                }
            }
        }
        private static int _переключательВолна100;

        /// <summary>
        /// 0 - 9
        /// </summary>
        public static int ПереключательВолна10
        {
            get
            {
                return _переключательВолна10;
            }

            set
            {
                if (value >= 0 && value <= 9)
                {
                    _переключательВолна10 = value;
                    if (ParameterChanged != null) ParameterChanged();
                }
            }
        }
        private static int _переключательВолна10;

        /// <summary>
        /// 0 - 9
        /// </summary>
        public static int ПереключательВолна1
        {
            get
            {
                return _переключательВолна1;
            }

            set
            {
                if (value >= 0 && value <= 9)
                {
                    _переключательВолна1 = value;
                    if (ParameterChanged != null) ParameterChanged();
                }
            }
        }
        private static int _переключательВолна1 = 0;
        #endregion

        #region Тумблеры
        /// <summary>
        /// Возможные состояния: true - Дистанционное; false - Местное;
        /// </summary>
        public static bool ТумблерУправление 
        { 
            get { return _тумблерУправление; } 
            set 
            { 
                _тумблерУправление = value;
                if(value)
                    ResetParameters();
                Search();
                if (ParameterChanged != null) ParameterChanged(); 
            } 
        }
        private static bool _тумблерУправление = false;

        /// <summary>
        /// Возможные состояния: true - ЧТ, false - ОФТ
        /// </summary>
        public static bool ТумблерВведение
        {
            get { return _тумблерВведение; }
            set
            {
                _тумблерВведение = value;
                Search();
                if (ParameterChanged != null) ParameterChanged();
            }
        }

        public static Модуляция ТумблерВведениеМодуляция
        {
            get { return _тумблерВведение ? Модуляция.ЧТ : Модуляция.ОФТ; }
        }

        private static bool _тумблерВведение;

        /// <summary>
        /// Возможные состояния: true - Вкл, false - Откл
        /// </summary>
        public static bool ТумблерБлокировка { get { return _тумблерБлокировка; } set { _тумблерБлокировка = value; Search(); if (ParameterChanged != null) ParameterChanged(); } }
        private static bool _тумблерБлокировка = false;

        /// <summary>
        /// Возможные состояния: true - Автоматическое, false - Ручное
        /// </summary>
        public static bool ТумблерВидВключения { get { return _тумблерВидВключения; } set { _тумблерВидВключения = value; if (ParameterChanged != null) ParameterChanged(); } }
        private static bool _тумблерВидВключения = false;

        /// <summary>
        /// Возможные состояния: true - С анализом симметрии, false - Откл
        /// </summary>
        public static bool ТумблерАнализСимметрии { get { return _тумблерАнализСимметрии; } set { _тумблерАнализСимметрии = value; if (ParameterChanged != null) ParameterChanged(); } }
        private static bool _тумблерАнализСимметрии = false;

        /// <summary>
        /// Возможные состояния: true - Автоматическое слежение частоты, false - Откл
        /// </summary>
        public static bool ТумблерАСЧ { get { return _тумблерАСЧ; } set { _тумблерАСЧ = value; if (ParameterChanged != null) ParameterChanged(); } }
        private static bool _тумблерАСЧ = false;

        /// <summary>
        /// Возможные состояния: true - Автоматическая регулировка уровня, false - Ручная регулировка уровня
        /// </summary>
        public static bool ТумблерРегулировкаУровня { get { return _тумблерРегулировкаУровня; } set { _тумблерРегулировкаУровня = value; if (ParameterChanged != null) ParameterChanged(); } }
        private static bool _тумблерРегулировкаУровня = false;

        /// <summary>
        /// Возможные состояния: true - ЧТ, false - ОФТ
        /// </summary>
        public static bool ТумблерВидМодуляции
        {
            get { return _тумблерВидМодуляции; }
            set
            {
                _тумблерВидМодуляции = value;
                Search();
                if (ParameterChanged != null) ParameterChanged();
            }
        }

        public static Модуляция ТумблерВидМодуляцииМодуляция
        {
            get { return _тумблерВидМодуляции ? Модуляция.ЧТ : Модуляция.ОФТ; }
        }

        private static bool _тумблерВидМодуляции = false;

        /// <summary>
        /// Возможные состояния: true - +-60, false - +-300
        /// </summary>
        public static bool ТумблерПределы { get { return _тумблерПределы; } set { _тумблерПределы = value; if (ParameterChanged != null) ParameterChanged(); } }
        private static bool _тумблерПределы = false;
        #endregion

        #region Лампочки
        private static bool _лампочкаСигнал;
        public static bool ЛампочкаСигнал
        {
            get { return ЛампочкаПитание && Сигнал; }
        }

        public static bool Сигнал { get; set; }

        private static bool _лампочкаПитание;
        public static bool ЛампочкаПитание
        {
            get
            {
                return N15Parameters.Включен &&
                            (!ТумблерУправление && Питание ||
                             (ТумблерУправление && N15Parameters.ТумблерЦ300М1));
            }
        }

        private static bool _лампочкаПоиск;
        public static bool ЛампочкаПоиск
        {
            get { return _лампочкаПоиск; }
            set
            {
                _лампочкаПоиск = value;
                if (ParameterChanged != null) ParameterChanged();
            }
        }
        #endregion

        #region Индикатор
        private static float _индикаторСигнал;
        public static float ИндикаторСигнал
        {
            get
            {
                if (N15Parameters.Включен)
                {
                    if (ЛампочкаПитание)
                    {
                        if (timer.Enabled) return _индикаторСигнал;
                        switch (Array.IndexOf(КнопкиКонтрольРежима, true))
                        {
                            case 0:
                                return (A306Parameters.ВыходнойСигнал1 != null)
                                    ? _индикаторСигнал = (float) A306Parameters.ВыходнойСигнал1.Level
                                    : _индикаторСигнал = 0;
                            case 1:
                                if (ТумблерРегулировкаУровня && A306Parameters.ВыходнойСигнал1 != null)
                                    return (Array.IndexOf(КнопкиВидРаботы, true) == -1)
                                        ? _индикаторСигнал = 50
                                        : _индикаторСигнал = 50 - (float) A306Parameters.ВыходнойСигнал1.Level;
                                return (Array.IndexOf(КнопкиВидРаботы, true) == -1 &&
                                        A306Parameters.ВыходнойСигнал1 != null)
                                    ? _индикаторСигнал = 50 - (float) A306Parameters.ВыходнойСигнал1.Level
                                    : _индикаторСигнал = 50;
                            case 2:
                                if (!ТумблерРегулировкаУровня)
                                    return _индикаторСигнал = 0;
                                break;
                            case 3:
                                return _индикаторСигнал;
                            case 4:
                                return _индикаторСигнал = 30;
                            case 5:
                            case 6:
                            case 7:
                                return _индикаторСигнал = 41;
                            case 8:
                            case 9:
                                return _индикаторСигнал = -43;
                            default:
                                return КнопкаКонтрольРежимаМинус27
                                    ? _индикаторСигнал = -43
                                    : _индикаторСигнал = 0;
                        }
                    }
                    else
                    {
                        return КнопкиКонтрольРежима[7]
                            ? _индикаторСигнал = 41
                            : _индикаторСигнал = 0;
                    }
                }
                else
                {
                    return _индикаторСигнал = 0;
                }

                return _индикаторСигнал;
            }
            set
            {
                if (value >= -51 && value <= 51) _индикаторСигнал = value;
                OnParameterChanged();
            }
        }
        #endregion

        #region Поиск сигнала
        //Инициализация таймера
        private static Timer timer = new Timer();
        private static bool СтрелкаДвижетсяНалево = false;

        //Поиск значения индикатора (Движение стрелки)
        [STAThread]
        public static void Search()
        {
            //Полная остановка таймера с отпиской метода установки условий поиска
            timer.Tick -= SetSearchConditions;
            timer.Stop();
            timer.Enabled = false;
            if (ЛампочкаПитание && ((Array.IndexOf(КнопкиКонтрольРежима, true) == 3) || (КнопкаПоиск)))
            {
                if (!ТумблерБлокировка && Array.IndexOf(КнопкиВидРаботы, true) != -1)
                {
                    timer.Enabled = true;
                    SetArrowIndicatorSpeed();
                    timer.Tick += SetSearchConditions;
                    timer.Start();
                }
            }
        }

        //Установка условий поиска
        static void SetSearchConditions(object sender, EventArgs e)
        {
            SetSearchInterval();
            Сигнал = false;
            if (!КнопкаПоиск && ВыходнойСигнал != null)
            {
                switch (ВыходнойСигнал.Modulation)
                {
                    case Модуляция.ОФТ:
                        if (ИндикаторСигнал < 2 && ИндикаторСигнал > -2)
                        {
                            StopSearch();
                        }
                        break;

                    case Модуляция.ЧТ:
                        if (ИндикаторСигнал < 2 && ИндикаторСигнал > -2)
                        {
                            StopSearch();
                        }
                        break;

                    case Модуляция.Отсутствует:
                        if (ИндикаторСигнал < 22 && ИндикаторСигнал > 18 ||
                            ИндикаторСигнал < -8 && ИндикаторСигнал > -12)
                        {
                            StopSearch();
                        }
                        break;


                }
            }
            else
            {
                ЛампочкаПоиск = true;
            }

            OnParameterChanged();
        }

        private static void SetSearchInterval()
        {
            var леваяГраница = (ТумблерПределы) ? -35 : -50;
            var праваяГраница = (ТумблерПределы) ? -20 : 50;

            if (!ЛампочкаСигнал)
                if (СтрелкаДвижетсяНалево)
                {
                    ИндикаторСигнал -= 0.3F;
                    if (ИндикаторСигнал < леваяГраница)
                        СтрелкаДвижетсяНалево = false;
                }
                else
                {
                    ИндикаторСигнал += 0.3F;
                    if (ИндикаторСигнал > праваяГраница)
                        СтрелкаДвижетсяНалево = true;
                }
        }

        private static void StopSearch()
        {
            Сигнал = true;
            _диапазонПойманногоСигнала = ИндикаторСигнал;
            СтрелкаДвижетсяНалево = false;
            timer.Stop();
        }

        //Изменение скорости движения стрелки индикатора
        static void SetArrowIndicatorSpeed()
        {
            if (timer.Enabled)
            {
                timer.Interval = 100 - Array.IndexOf(КнопкиВидРаботы, true) * 10;
            }
        }

        public static Signal ВыходнойСигнал
        {
            get
            {
                var signal = A306Parameters.ВыходнойСигнал1;
                if (signal != null
                    && signal.Level > 10
                    && signal.Wave == Волна
                    && (Math.Abs(signal.GroupSpeed - ТекущаяСкоростьРаботы) <= 0.5))
                {
                    if (signal.Modulation != ТумблерВведениеМодуляция
                    || signal.Modulation != ТумблерВидМодуляцииМодуляция) signal.Modulation = Модуляция.Отсутствует;
                    return signal;
                }
                return null;
            }
        }
        #endregion

        public delegate void ParameterChangedHandler();
        public static event ParameterChangedHandler ParameterChanged;

        public static void OnParameterChanged()
        {
            if (ParameterChanged != null) ParameterChanged();
        }

        public static void ResetParameters()
        {
            C300PM_1Parameters.ResetParameters();
            OnParameterChanged();
        }

        public static void RefreshIndicators()
        {
            if (N15Parameters.Включен)
            {
                if (ЛампочкаПитание)
                {
                    switch (Array.IndexOf(КнопкиКонтрольРежима, true))
                    {
                        case 0:
                            ИндикаторСигнал = (ЛампочкаСигнал) ? 50 : 0;
                            break;
                        case 1:
                            if (ТумблерРегулировкаУровня)
                                ИндикаторСигнал = (Array.IndexOf(КнопкиВидРаботы, true) == -1) ? 50 : 30;
                            else
                                ИндикаторСигнал = (Array.IndexOf(КнопкиВидРаботы, true) == -1) ? 30 : 50;
                            break;
                        case 2:
                            ИндикаторСигнал = 0;
                            break;
                        case 4:
                            ИндикаторСигнал = 30;
                            break;
                        case 5:
                        case 6:
                        case 7:
                            ИндикаторСигнал = 41;
                            break;
                        case 8:
                        case 9:
                            ИндикаторСигнал = -43;
                            break;
                        default:
                            ИндикаторСигнал = (КнопкаКонтрольРежимаМинус27) ? -43 : 0;
                            break;
                    }
                }
                else
                {
                    ИндикаторСигнал = (КнопкиКонтрольРежима[7]) ? 41 : 0;
                }
            }
            else ИндикаторСигнал = 0;

            OnParameterChanged();
        }

        private static float _диапазонПойманногоСигнала;
    }
}
