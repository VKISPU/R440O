using System;
using R440O.R440OForms.N15;
using R440O.R440OForms.N502B;

namespace R440O.R440OForms.C300M_2
{
    internal class C300M_2Parameters
    {
        #region Private

        private static bool _кнопкаВидРаботыСброс;
        private static bool _кнопкаКонтрольРежимаМинус27;
        private static bool _кнопкиПитание;
        private static bool _кнопкаПоиск;
        private static bool _кнопкаИндикацияВолны;
        private static int _переключательВолна1000 = 0;
        private static int _переключательВолна100 = 0;
        private static int _переключательВолна10 = 0;
        private static int _переключательВолна1 = 0;
        private static bool _тумблерУправление;
        private static bool _тумблерВведение;
        private static bool _тумблерБлокировка;
        private static bool _тумблерВидВключения;
        private static bool _тумблерАнализСимметрии;
        private static bool _тумблерРегулировкаУровня;
        private static bool _тумблерАСЧ;
        private static bool _тумблерВидМодуляции;
        private static bool _тумблерПределы;

        #endregion

        #region Таймер

        public static bool TimerOn = false;
        public static bool OnLeft = false;

        private static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        #endregion

        public static bool НеполноеВключение
        {
            get { return N15Parameters.Включен; }
        }
        public static bool Включен
        {
            get { return НеполноеВключение && ((ТумблерУправление && N15Parameters.ТумблерЦ300М2) || (!ТумблерУправление && КнопкиПитание)); }
        }

        #region Кнопки ВИД РАБОТЫ

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
        public static C300M_2КнопкиВидРаботы КнопкиВидРаботы = new C300M_2КнопкиВидРаботы();      

        /// <summary>
        /// Кнопка Сброс, отжимает все кнопки Вида Работы
        /// </summary>
        public static bool КнопкаВидРаботыСброс
        {
            get { return _кнопкаВидРаботыСброс; }
            set
            {
                _кнопкаВидРаботыСброс = value;
                КнопкиВидРаботы[0] = false;

                //RefreshIndicators();
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
        public static C300M_2КнопкиКонтрольРежима КнопкиКонтрольРежима = new C300M_2КнопкиКонтрольРежима();
        /// <summary>
        /// Кнопка -27, отжимает все кнопки Контроля Режима
        /// </summary>
        public static bool КнопкаКонтрольРежимаМинус27
        {
            get { return _кнопкаКонтрольРежимаМинус27; }
            set
            {
                _кнопкаКонтрольРежимаМинус27 = value;
                КнопкиКонтрольРежима[0] = false;

                //RefreshIndicators();
            }
        }

        #endregion

        #region Кнопки ПИТАНИЕ
        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static bool КнопкиПитание
        {
            get { return _кнопкиПитание; }
            set
            {
                if (НеполноеВключение) _кнопкиПитание = value;
                ResetParameters();
            }
        }
        #endregion

        #region Кнопки Поиск и Индикация волны

        public static bool КнопкаПоиск
        {
            get { return _кнопкаПоиск; }
            set
            {
                _кнопкаПоиск = value;
                if (ЛампочкаСигнал && value)
                {
                    ИндикаторСигнал += 5;
                    Search();
                }
                OnParameterChanged();
            }
        }

        public static bool КнопкаИндикацияВолны
        {
            get { return _кнопкаИндикацияВолны; }
            set
            {
                if (Включен && value)
                    _кнопкаИндикацияВолны = value;
            }
        }

        #endregion

        #region Переключатели ВОЛНА

        /// <summary>
        /// 0 - 4
        /// </summary>
        public static int ПереключательВолна1000
        {
            get { return _переключательВолна1000; }

            set
            {
                if (value >= 0 && value <= 9)
                {
                    _переключательВолна1000 = value;
                    OnParameterChanged();
                }
            }
        }

        /// <summary>
        /// 0 - 9
        /// </summary>
        public static int ПереключательВолна100
        {
            get { return _переключательВолна100; }

            set
            {
                if (value >= 0 && value <= 9)
                {
                    _переключательВолна100 = value;
                    OnParameterChanged();
                }
            }
        }

        /// <summary>
        /// 0 - 9
        /// </summary>
        public static int ПереключательВолна10
        {
            get { return _переключательВолна10; }

            set
            {
                if (value >= 0 && value <= 9)
                {
                    _переключательВолна10 = value;
                    OnParameterChanged();
                }
            }
        }

        /// <summary>
        /// 0 - 9
        /// </summary>
        public static int ПереключательВолна1
        {
            get { return _переключательВолна1; }

            set
            {
                if (value >= 0 && value <= 9)
                {
                    _переключательВолна1 = value;
                    OnParameterChanged();
                }
            }
        }

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
                КнопкиПитание = (НеполноеВключение && !value && N15Parameters.ТумблерЦ300М2);
            }
        }

        /// <summary>
        /// Возможные состояния: true - ЧТ, false - ОФТ
        /// </summary>
        public static bool ТумблерВведение
        {
            get { return _тумблерВведение; }
            set
            {
                _тумблерВведение = value;
                OnParameterChanged();
            }
        }


        /// <summary>
        /// Возможные состояния: true - Вкл, false - Откл
        /// </summary>
        public static bool ТумблерБлокировка
        {
            get { return _тумблерБлокировка; }
            set
            {
                _тумблерБлокировка = value;
                Search();
                if (value) timer.Enabled = false;
                OnParameterChanged();
            }
        }

        /// <summary>
        /// Возможные состояния: true - Автоматическое, false - Ручное
        /// </summary>
        public static bool ТумблерВидВключения
        {
            get { return _тумблерВидВключения; }
            set
            {
                _тумблерВидВключения = value;
                OnParameterChanged();
            }
        }

        /// <summary>
        /// Возможные состояния: true - С анализом симметрии, false - Откл
        /// </summary>
        public static bool ТумблерАнализСимметрии
        {
            get { return _тумблерАнализСимметрии; }
            set
            {
                _тумблерАнализСимметрии = value;
                OnParameterChanged();
            }
        }

        /// <summary>
        /// Возможные состояния: true - Автоматическое слежение частоты, false - Откл
        /// </summary>
        public static bool ТумблерАСЧ
        {
            get { return _тумблерАСЧ; }
            set
            {
                _тумблерАСЧ = value;
                OnParameterChanged();
            }
        }

        /// <summary>
        /// Возможные состояния: true - Автоматическая регулировка уровня, false - Ручная регулировка уровня
        /// </summary>
        public static bool ТумблерРегулировкаУровня
        {
            get { return _тумблерРегулировкаУровня; }
            set
            {
                _тумблерРегулировкаУровня = value;
                OnParameterChanged();
            }
        }

        /// <summary>
        /// Возможные состояния: true - ЧТ, false - ОФТ
        /// </summary>
        public static bool ТумблерВидМодуляции
        {
            get { return _тумблерВидМодуляции; }
            set
            {
                _тумблерВидМодуляции = value;
                OnParameterChanged();
            }
        }

        /// <summary>
        /// Возможные состояния: true - +-60, false - +-300
        /// </summary>
        public static bool ТумблерПределы
        {
            get { return _тумблерПределы; }
            set
            {
                _тумблерПределы = value;
                OnParameterChanged();
            }
        }

        #endregion

        #region Лампочки

        public static bool ЛампочкаСигнал
        {
            get { return false; }
        }

        public static bool ЛампочкаПитание
        {
            get
            {
                return Включен;
            }
        }

        public static bool ЛампочкаПоиск
        {
            get { return Включен && !ЛампочкаСигнал && timer.Enabled; }
        }

        #endregion

        #region Индикатор

        private static float _индикаторСигнал = 0;

        public static float ИндикаторСигнал
        {
            get {
                if (НеполноеВключение)
                {
                    if (Включен)
                    {
                        switch (КнопкиКонтрольРежима.PressedButton)
                        {
                            case 0:
                                return _индикаторСигнал = (ЛампочкаСигнал)
                                    ? 50
                                    : 0;
                            case 1:
                                if (ТумблерРегулировкаУровня)
                                    return _индикаторСигнал = (КнопкиВидРаботы.PressedButton == -1 || КнопкиВидРаботы.PressedButton == 10)
                                        ? 10
                                        : 30;
                                return _индикаторСигнал = (КнопкиВидРаботы.PressedButton == -1 || КнопкиВидРаботы.PressedButton == 10)
                                        ? 10
                                        : 60;
                            case 2:
                                return _индикаторСигнал = 0;
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
                            case 10:
                                return _индикаторСигнал = - 43;
                        }
                    }
                    else
                    {
                        return _индикаторСигнал = (КнопкиКонтрольРежима[7]) ? 41 : 0;
                    }
                }
                return _индикаторСигнал = 0;
            }
            set
            {
                if (value >= -51 && value <= 51) _индикаторСигнал = value;
                OnIndicatorChanged();
            }
        }

        #endregion

        [STAThread]
        public static void Search()
        {
            timer.Tick -= timer_Tick;
            timer.Stop();
            if (Включен &&
                (КнопкиКонтрольРежима.PressedButton == 3) || (КнопкаПоиск && ЛампочкаСигнал))
            {
                if (!ТумблерБлокировка)
                {
                    timer.Enabled = true;
                    TimerSet();
                    timer.Tick += timer_Tick;
                    timer.Start();
                }
                else timer.Enabled = false;
            }
            else timer.Enabled = false;
        }

        private static void timer_Tick(object sender, EventArgs e)
        {
            int Predel1 = (ТумблерПределы)
                ? -35
                : -50;
            int Predel2 = (ТумблерПределы)
                ? -20
                : 50;

            if (OnLeft)
            {
                ИндикаторСигнал -= 0.3F;
                if (ИндикаторСигнал < Predel1)
                    OnLeft = false;
            }
            else
            {
                ИндикаторСигнал += 0.3F;
                if (ИндикаторСигнал > Predel2)
                    OnLeft = true;
            }

            //***Условие на поиск сигнала***//
            //OnIndicatorChanged();
        }


        //Изменение скорости работы таймера
        public static void TimerSet()
        {
            if (timer.Enabled)
            {
                timer.Interval = (КнопкиВидРаботы.PressedButton == 10 || (КнопкиВидРаботы.PressedButton == -1))
                    ? 10
                    : 100 - КнопкиВидРаботы.PressedButton * 10;
            }
        }

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

            //Для сброса питания
            if (!Включен) _кнопкиПитание = false;
            if (Включен) Search();
        }

        public delegate void IndicatorChangedHandler();
        public static event IndicatorChangedHandler IndicatorChanged;

        private static void OnIndicatorChanged()
        {
            var handler = IndicatorChanged;
            if (handler != null) handler();
        }

        public static void ResetIndicator()
        {
            OnIndicatorChanged();
        }
    }

    public class C300M_2КнопкиКонтрольРежима
    {
        public static bool[] КнопкиКонтрольРежима = { false, false, false, false, false, false, false, false, false, false, false };

        public bool this[int buttonNumber]
        {
            get { return КнопкиКонтрольРежима[buttonNumber]; }
            set
            {
                for (int i = 0; i < 10; i++)
                    КнопкиКонтрольРежима[i] = false;

               КнопкиКонтрольРежима[buttonNumber] = value;

               C300M_2Parameters.ResetParameters();
               C300M_2Parameters.Search();
            }
        }

        public int PressedButton
        {
            get { return Array.IndexOf(КнопкиКонтрольРежима, true); }
        }
    }

    public class C300M_2КнопкиВидРаботы
    {
        public static bool[] КнопкиВидРаботы = { false, false, false, false, false, false, false, false, false, false, false };

        public bool this[int buttonNumber]
        {
            get { return КнопкиВидРаботы[buttonNumber]; }
            set
            {
                for (int i = 0; i < 10; i++)
                    КнопкиВидРаботы[i] = false;

                КнопкиВидРаботы[buttonNumber] = true;

                C300M_2Parameters.TimerSet();
                C300M_2Parameters.ResetParameters();
            }
        }

        public int PressedButton
        {
            get { return Array.IndexOf(КнопкиВидРаботы, true); }
        }
    }
}
