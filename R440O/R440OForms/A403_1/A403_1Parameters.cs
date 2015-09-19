﻿using System;
using System.Windows.Forms;
using R440O.R440OForms.N15;

namespace R440O.R440OForms.A403_1
{
    public class A403_1Parameters
    {
        public static bool Включен
        {
            get
            {
                return ТумблерСеть && N15Parameters.ТумблерА403;
            }
        }

        #region Таймер
        public static int Time = 0;

        public static Timer timer = new Timer();

        public static void timer_Tick(object sender, EventArgs e)
        {
            if (Array.IndexOf(КнопкиПараметры.ToArray(), true) == -1)
            {
                Значение = " " + (Time / 3600 / 10) + (Time / 3600 % 10) +
                           (Time / 60 % 60 / 10) + (Time / 60 % 60 % 10) +
                           (Time % 60 / 10) + (Time % 60 % 10);
            }
            Time++;
        }
        #endregion

        #region Лампочки
        public static bool ЛампочкаКомплект1
        {
            get { return Включен && ТумблерКомплект; }
        }

        public static bool ЛампочкаКомплект2
        {
            get { return Включен && !ТумблерКомплект; }
        }
        #endregion

        #region Тумблеры
        private static bool _тумблерСеть;
        public static bool ТумблерСеть
        {
            get { return _тумблерСеть; }
            set
            {
                _тумблерСеть = value;

                if (value)
                {
                    timer.Enabled = true;
                    timer.Tick += timer_Tick;
                    timer.Interval = 1000;
                    timer.Start();
                }
                else
                {
                    timer.Enabled = false;
                    timer.Tick -= timer_Tick;
                    timer.Stop();
                    Time = 0;
                    _значение = "";
                }

                OnParameterChanged();
            }
        }

        private static bool _тумблерГотов;
        public static bool ТумблерГотов
        {
            get { return _тумблерГотов; }
            set
            {
                _тумблерГотов = value;
                OnParameterChanged();
            }
        }

        private static bool _тумблерАвтКоррекция;
        public static bool ТумблерАвтКоррекция
        {
            get { return _тумблерАвтКоррекция; }
            set
            {
                _тумблерАвтКоррекция = value;
                OnParameterChanged();
            }
        }

        /// <summary>
        /// Возможные состояния: true - 1 Группа, false - 2 Группа
        /// </summary>
        public static bool ТумблерГруппа
        {
            get { return _тумблерГруппа; }
            set
            {
                ДисплейЗначения[(ТумблерГруппа) ? 0 : 1, Array.IndexOf(КнопкиПараметры.ToArray(), true)] = Значение;
                Значение = "";

                _тумблерГруппа = value;
                OnParameterChanged();
            }
        }
        private static bool _тумблерГруппа;


        /// <summary>
        /// Возможные состояния: true - 1 комплект, false - 2 комплект
        /// </summary>
        public static bool ТумблерКомплект
        {
            get { return _тумблерКомплект; }
            set
            {
                _тумблерКомплект = value;
                OnParameterChanged();
            }
        }
        private static bool _тумблерКомплект;

        #endregion

        #region Переключатели

        #region Переключатель проверка
        /// <summary>
        /// Положение переключателя проверки
        /// </summary>
        private static int _переключательПроверка = 1;

        /// <summary>
        /// Названия положений:
        /// 1 - 0,
        /// 2 - t,
        /// 3 - alpha P,
        /// 4 - beta P,
        /// 5 - delta F,
        /// 6 - alpha phi,
        /// 7 - beta phi,
        /// 8 - Д,
        /// 9 - Ш,
        /// 10 - К
        /// </summary>
        public static int ПереключательПроверка
        {
            get { return _переключательПроверка; }
            set
            {
                if (value > 0 && value < 11) _переключательПроверка = value;
                OnParameterChanged();
            }
        }
        #endregion

        #region ПереключательРежимРаботы
        /// <summary>
        /// Положение переключателя режима работы
        /// </summary>
        private static int _переключательРежимРаботы = 1;

        /// <summary>
        /// Названия положений:
        /// 1 - 0,
        /// 2 - РАБ1,
        /// 3 - РАБ2,
        /// 4 - ПРОГН,
        /// 5 - РН,
        /// 6 - ПУ,
        /// 7 - УВВ,
        /// 8 - БПР,
        /// </summary>
        public static int ПереключательРежимРаботы
        {
            get { return _переключательРежимРаботы; }
            set
            {
                if (value > 0 && value < 9) _переключательРежимРаботы = value;
                OnParameterChanged();
            }
        }
        #endregion

        #endregion

        #region Кнопки

        /// <summary>
        /// Названия кнопок:
        /// 0 - Аlpha/Lambda,
        /// 1 - Epsilon/Phi,
        /// 2 - I/H,
        /// 3 - Omega/N,
        /// 4 - Lambda0/f,
        /// 5 - t0/K,
        /// 6 - T/Kbeta,
        /// 7 - tсв/Yalpha,
        /// 8 - tуст/Ybeta,
        /// </summary>
        public static A403_1Кнопки КнопкиПараметры = new A403_1Кнопки();

        #endregion

        #region Табло

        /// <summary>
        /// Матрица для хранения введённых значений на дисплее, 1 строка соответствует значениям 1 группы переменных, а 2 для 2 группы.
        /// </summary>
        public static A403_1ЗначенияПараметров ДисплейЗначения = new A403_1ЗначенияПараметров();

        private static string _значение = "";

        public static string Значение
        {
            get { return _значение; }
            set
            {
                if ((Array.IndexOf(КнопкиПараметры.ToArray(), true) == 2 ||
                    Array.IndexOf(КнопкиПараметры.ToArray(), true) == 3) && !ТумблерГруппа)
                {
                    if (value.Length <= 2)
                    {
                        _значение = value;
                        OnParameterChanged();
                    }
                }
                else if (Включен && value.Length <= 7 && Array.IndexOf(A403_1Кнопки.КнопкиПараметры, true) != -1)
                {
                    _значение = value;
                    OnParameterChanged();
                }
                else if (Array.IndexOf(A403_1Кнопки.КнопкиПараметры, true) == -1)
                {
                    _значение = value;
                    OnParameterChanged();
                }
            }
        }
        #endregion

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
    }

    public class A403_1Кнопки
    {
        public static bool[] КнопкиПараметры = { false, false, false, false, false, false, false, false, false };
        public bool this[int buttonNumber]
        {
            get
            {
                return КнопкиПараметры[buttonNumber];
            }
            set
            {
                ////если нажата кнопка ввода параметров и мы ее отжимаем, запоминаем значение
                if (Array.IndexOf(КнопкиПараметры, true) != -1)
                {
                    A403_1Parameters.ДисплейЗначения[(A403_1Parameters.ТумблерГруппа) ? 0 : 1,
                        Array.IndexOf(КнопкиПараметры, true)] = A403_1Parameters.Значение;
                }
                A403_1Parameters.Значение = "";

                for (int i = 0; i < 9; i++)
                { КнопкиПараметры[i] = false; }
                КнопкиПараметры[buttonNumber] = value;

                A403_1Parameters.ResetParameters();
            }
        }

        public bool[] ToArray()
        {
            return КнопкиПараметры;
        }
    }

    public class A403_1ЗначенияПараметров
    {
        public static string[,] ДисплейЗначения = {  { "", "", "", "", "", "", "", "", ""},
                                                  { "", "", "", "", "", "", "", "", ""}    };
        public string this[int комплект, int номерКнопки]
        {
            get { return ДисплейЗначения[комплект, номерКнопки]; }
            set
            {
                if (комплект == 1 && value.Length == 2
                    && (Array.IndexOf(A403_1Parameters.КнопкиПараметры.ToArray(), true) == 2
                    || Array.IndexOf(A403_1Parameters.КнопкиПараметры.ToArray(), true) == 3))
                {
                    ДисплейЗначения[комплект, номерКнопки] = value;
                }
                else if (Array.IndexOf(A403_1Parameters.КнопкиПараметры.ToArray(), true) != -1 && value.Length == 7)
                {
                    ДисплейЗначения[комплект, номерКнопки] = value;
                }
            }
        }

        public string[,] ToArray()
        {
            return ДисплейЗначения;
        }
    }
}