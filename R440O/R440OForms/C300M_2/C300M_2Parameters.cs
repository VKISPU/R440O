﻿using System;
using R440O.R440OForms.N15;
using R440O.R440OForms.C300PM_1;
using R440O.R440OForms.N502B;

namespace R440O.R440OForms.C300M_2
{
    class C300M_2Parameters
    {
        #region Таймер
        public static bool TimerOn = false;
        public static bool OnLeft = false;
        #endregion

        static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

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
        public static bool[] КнопкиВидРаботы = { false, false, false, false, false, false, false, false, false, false };
        public static int КнопкаВидРаботы
        {
            get { return _кнопкаВидРаботы; }
            set
            {
                _кнопкаВидРаботы = value;
                for (int i = 0; i < КнопкиВидРаботы.Length; i++)
                   КнопкиВидРаботы[i] = false;
                КнопкиВидРаботы[_кнопкаВидРаботы] = true;

                TimerSet();
                RefreshForm();
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

                RefreshIndicators();
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
        
        public static bool[] КнопкиКонтрольРежима = { false, false, false, false, false, false, false, false, false, false };
        public static int КнопкаКонтрольРежима
        {
            get { return _кнопкаКонтрольРежима; }
            set
            {
                _кнопкаКонтрольРежима = value;

                for (int i = 0; i < КнопкиКонтрольРежима.Length; i++)
                    КнопкиКонтрольРежима[i] = false;
                КнопкиКонтрольРежима[_кнопкаКонтрольРежима] = true;

                RefreshIndicators();
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

                RefreshIndicators();
            }
        }
        private static bool _кнопкаКонтрольРежимаМинус27;
        #endregion

        #region Кнопки ПИТАНИЕ
        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static bool КнопкаПитаниеВкл
        {
            get { return _кнопкаПитаниеВкл; }
            set
            {
                _кнопкаПитаниеВкл = value;
                if (value)
                {
                    ResetParameters();
                    RefreshIndicators();
                }
            }
        }
        private static bool _кнопкаПитаниеВкл;

        /// <summary>
        /// Возможные состояния: true, false
        /// </summary>
        public static bool КнопкаПитаниеВыкл
        {
            get { return _кнопкаПитаниеВыкл; }
            set
            {
                _кнопкаПитаниеВыкл = value;
                if (value)
                {
                    ResetParameters();
                    RefreshIndicators();
                }
            }
        }
        private static bool _кнопкаПитаниеВыкл;
        #endregion

        #region Кнопки Поиск и Индикация волны
        public static bool КнопкаПоиск
        {
            get { return _кнопкаПоиск; }
            set
            {
                _кнопкаПоиск = value;
                if (value) Search();
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
                    if (RefreshForm != null) RefreshForm();
                }
            }
        }
        private static int _переключательВолна1000 = 0;

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
                    if (RefreshForm != null) RefreshForm();
                }
            }
        }
        private static int _переключательВолна100 = 0;

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
                    if (RefreshForm != null) RefreshForm();
                }
            }
        }
        private static int _переключательВолна10 = 0;

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
                    if (RefreshForm != null) RefreshForm();
                }
            }
        }
        private static int _переключательВолна1 = 0;
        #endregion

        #region Тумблеры
        /// <summary>
        /// Возможные состояния: true - Дистанционное; false - Местное;
        /// </summary>
        public static bool ТумблерУправление { get { return _тумблерУправление; } set { _тумблерУправление = value; ResetParameters(); if (RefreshForm != null) RefreshForm(); } }
        private static bool _тумблерУправление = false;


        /// <summary>
        /// Возможные состояния: true - ЧТ, false - ОФТ
        /// </summary>
        public static bool ТумблерВведение { get { return _тумблерВведение; } set { _тумблерВведение = value; if (RefreshForm != null) RefreshForm(); } }
        private static bool _тумблерВведение = false;

        /// <summary>
        /// Возможные состояния: true - Вкл, false - Откл
        /// </summary>
        public static bool ТумблерБлокировка { get { return _тумблерБлокировка; } set { _тумблерБлокировка = value; Search(); if (RefreshForm != null) RefreshForm(); } }
        private static bool _тумблерБлокировка = false;

        /// <summary>
        /// Возможные состояния: true - Автоматическое, false - Ручное
        /// </summary>
        public static bool ТумблерВидВключения { get { return _тумблерВидВключения; } set { _тумблерВидВключения = value; if (RefreshForm != null) RefreshForm(); } }
        private static bool _тумблерВидВключения = false;

        /// <summary>
        /// Возможные состояния: true - С анализом симметрии, false - Откл
        /// </summary>
        public static bool ТумблерАнализСимметрии { get { return _тумблерАнализСимметрии; } set { _тумблерАнализСимметрии = value; if (RefreshForm != null) RefreshForm(); } }
        private static bool _тумблерАнализСимметрии = false;

        /// <summary>
        /// Возможные состояния: true - Автоматическое слежение частоты, false - Откл
        /// </summary>
        public static bool ТумблерАСЧ { get { return _тумблерАСЧ; } set { _тумблерАСЧ = value; if (RefreshForm != null) RefreshForm(); } }
        private static bool _тумблерАСЧ = false;

        /// <summary>
        /// Возможные состояния: true - Автоматическая регулировка уровня, false - Ручная регулировка уровня
        /// </summary>
        public static bool ТумблерРегулировкаУровня { get { return _тумблерРегулировкаУровня; } set { _тумблерРегулировкаУровня = value; RefreshIndicators(); } }
        private static bool _тумблерРегулировкаУровня = false;

        /// <summary>
        /// Возможные состояния: true - ЧТ, false - ОФТ
        /// </summary>
        public static bool ТумблерВидМодуляции { get { return _тумблерВидМодуляции; } set { _тумблерВидМодуляции = value; if (RefreshForm != null) RefreshForm(); } }
        private static bool _тумблерВидМодуляции = false;

        /// <summary>
        /// Возможные состояния: true - +-60, false - +-300
        /// </summary>
        public static bool ТумблерПределы { get { return _тумблерПределы; } set { _тумблерПределы = value; if (RefreshForm != null) RefreshForm(); } }
        private static bool _тумблерПределы = false;
        #endregion

        #region Лампочки
        private static bool _лампочкаСигнал;
        public static bool ЛампочкаСигнал
        {
            get { return _лампочкаСигнал; }
            set
            {
                _лампочкаСигнал = value;
                if (RefreshForm != null) RefreshForm();
            }
        }

        private static bool _лампочкаПитание;
        public static bool ЛампочкаПитание
        {
            get { return _лампочкаПитание; }
            set
            {
                _лампочкаПитание = value;
                C300PM_1Parameters.ResetParameters();
                if (!value)
                    RefreshIndicators();
                if (RefreshForm != null) RefreshForm();
            }
        }

        private static bool _лампочкаПоиск;
        public static bool ЛампочкаПоиск
        {
            get { return _лампочкаПоиск; }
            set
            {
                _лампочкаПоиск = value;
                if (RefreshForm != null) RefreshForm();
            }
        }
        #endregion

        #region Индикатор
        private static float _индикаторСигнал = 0;

        public static float ИндикаторСигнал
        {
            get
            {
                return _индикаторСигнал;
            }
            set
            {
                if (value >= -51 && value <= 51) _индикаторСигнал = value;
                if (RefreshForm != null) RefreshForm();
            }
        }
        #endregion

        public static void ResetParameters()
        {
            ЛампочкаПитание = N502BParameters.ЛампочкаСфазировано
                              && N502BParameters.ТумблерЭлектрооборудование && N502BParameters.ТумблерВыпрямитель27В
                              && N502BParameters.ТумблерН15 &&
                              ((!ТумблерУправление && КнопкаПитаниеВкл) ||
                               (ТумблерУправление && N15Parameters.ТумблерЦ300М2));

            ЛампочкаПоиск = ЛампочкаПитание && !ЛампочкаСигнал;
        }

        public static void RefreshIndicators()
        {
            Search();
            if (N502BParameters.ТумблерВыпрямитель27В && N502BParameters.ЛампочкаСфазировано && N502BParameters.ТумблерЭлектрооборудование)
                if (N502BParameters.ТумблерН15)
                {
                    if (ЛампочкаПитание)
                    {
                        switch (Array.IndexOf(КнопкиКонтрольРежима, true))
                        {
                            case 0:
                                ИндикаторСигнал = (ЛампочкаСигнал)
                                    ? 50
                                    : 0;
                                break;
                            case 1:
                                if (ТумблерРегулировкаУровня)
                                    ИндикаторСигнал = (Array.IndexOf(КнопкиВидРаботы, true) == -1)
                                        ? 50
                                        : 30;
                                else
                                    ИндикаторСигнал = (Array.IndexOf(КнопкиВидРаботы, true) == -1)
                                       ? 30
                                       : 50;
                                break;
                            case 2:
                                ИндикаторСигнал = 0;
                                break;
                            case 3:
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
                                ИндикаторСигнал = (КнопкаКонтрольРежимаМинус27)
                                    ? -43
                                    : 0;
                                break;
                        }
                    }
                    else
                    {
                        ИндикаторСигнал = (КнопкиКонтрольРежима[7])
                        ? 41
                        : 0;
                    }
                }
                else
                {
                    ИндикаторСигнал = 0;
                }
            else ИндикаторСигнал = 0;
            if (RefreshForm != null) RefreshForm();
        }

        [STAThread]
        private static void Search()
        {
            timer.Tick -= timer_Tick;
            timer.Stop();
            if (ЛампочкаПитание && ((Array.IndexOf(КнопкиКонтрольРежима, true) == 3) || (КнопкаПоиск)))
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

        static void timer_Tick(object sender, EventArgs e)
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
            RefreshForm();
        }


        //Изменение скорости работы таймера
        static void TimerSet()
        {
            if (timer.Enabled)
            {
                if (Array.IndexOf(КнопкиВидРаботы, true) == -1)
                    timer.Interval = 10;
                else timer.Interval = 100 - Array.IndexOf(КнопкиВидРаботы, true) * 10;
            }
        }


        public delegate void VoidVoidSignature();
        public static event VoidVoidSignature RefreshForm;
    }
}