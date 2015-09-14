using System;
using System.Timers;
using System.Windows.Forms;
using R440O.R440OForms.N502B;
using R440O.R440OForms.PowerCabel;

namespace R440O.R440OForms.A403_1
{
    public class A403_1Parameters
    {

        #region Таймер
        public static int Time = 0;

        public static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public static void timer_Tick(object sender, EventArgs e)
        {
            if (ТумблерСеть && N502BParameters.ЛампочкаСфазировано)
            {
                if (Array.IndexOf(КнопкиПараметры, true) == -1)
                {
                    Значение = (Time / 3600 / 10).ToString() + (Time / 3600 % 10) +
                               (Time / 60 % 60 / 10) + (Time / 60 % 60 % 10) +
                               (Time % 60 / 10) + (Time % 60 % 10);
                    if (RefreshForm != null) RefreshForm();
                }
                Time++;
            }
        }
        #endregion

        #region Лампочки
        ////Лампочки
        private static bool _лампочкаКомплект1;
        public static bool ЛампочкаКомплект1
        {
            get { return _лампочкаКомплект1; }
            set
            {
                _лампочкаКомплект1 = value;
                if (RefreshForm != null) RefreshForm();
            }
        }

        private static bool _лампочкаКомплект2;
        public static bool ЛампочкаКомплект2
        {
            get { return _лампочкаКомплект2; }
            set
            {
                _лампочкаКомплект2 = value;
                if (RefreshForm != null) RefreshForm();
            }
        }
        #endregion

        #region Тумблеры
        ////Тумблеры
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
                }

                ResetParameters();
                if (RefreshForm != null) RefreshForm();
            }
        }

        private static bool _тумблерГотов;
        public static bool ТумблерГотов
        {
            get { return _тумблерГотов; }
            set
            {
                _тумблерГотов = value;
                if (RefreshForm != null) RefreshForm();
            }
        }

        private static bool _тумблерАвтКоррекция;

        public static bool ТумблерАвтКоррекция
        {
            get { return _тумблерАвтКоррекция; }
            set
            {
                _тумблерАвтКоррекция = value;
                if (RefreshForm != null) RefreshForm();
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
                //запись в массив значений текущего значения
                if (Array.IndexOf(КнопкиПараметры, true) != -1)
                {
                    switch (Значение.Length)
                    {
                        case 1:
                            if (Значение[0] != '-' && (Array.IndexOf(КнопкиПараметры, true) == 2 ||
                                Array.IndexOf(КнопкиПараметры, true) == 3) && !ТумблерГруппа)
                                ДисплейЗначения[(ТумблерГруппа) ? 0 : 1,
                                    Array.IndexOf(КнопкиПараметры, true)] = Значение;
                            break;
                        case 6:
                            if (Значение[0] != '-')
                                ДисплейЗначения[(ТумблерГруппа) ? 0 : 1,
                                    Array.IndexOf(КнопкиПараметры, true)] = Значение; break;
                        case 7:
                            if (Значение[0] == '-')
                                ДисплейЗначения[(ТумблерГруппа) ? 0 : 1,
                                    Array.IndexOf(КнопкиПараметры, true)] = Значение; break;
                    }
                    Значение = "";
                }

                _тумблерГруппа = value;
                ResetParameters();
                if (RefreshForm != null) RefreshForm();
            }
        }
        private static bool _тумблерГруппа;


        /// <summary>
        /// Возможные состояния: true - 1 комплект, false - 2 комплект
        /// </summary>
        public static bool _тумблерКомплект;
        public static bool ТумблерКомплект
        {
            get
            {
                return _тумблерКомплект;
            }
            set
            {
                _тумблерКомплект = value;
                ResetParameters();
                if (RefreshForm != null) RefreshForm();
            }
        }

        //N502BParameters.ResetParameters();
        #endregion

        #region Переключатели
        ////Переключатели

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
                if (RefreshForm != null) RefreshForm();
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
                if (RefreshForm != null) RefreshForm();
            }
        }
        #endregion

        #endregion

        #region Кнопки
        ////Кнопки
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
        public static bool[] КнопкиПараметры = { false, false, false, false, false, false, false, false, false };

        /// <summary>
        /// 9 - сброс
        /// </summary>
        private static int _кнопкаПараметр = -1;
        public static int КнопкаПараметр
        {
            get { return _кнопкаПараметр; }
            set
            {
                _кнопкаПараметр = value;
                //запись в массив значений текущего значения
                if (Array.IndexOf(КнопкиПараметры, true) != -1 && ТумблерСеть
                    && N502BParameters.ЛампочкаСфазировано)
                {
                    switch (Значение.Length)
                    {
                        case 1:
                            if (Значение[0] != '-' && (Array.IndexOf(КнопкиПараметры, true) == 2 ||
                                Array.IndexOf(КнопкиПараметры, true) == 3) && !ТумблерГруппа)
                                ДисплейЗначения[(ТумблерГруппа) ? 0 : 1,
                                    Array.IndexOf(КнопкиПараметры, true)] = Значение;
                            break;
                        case 6:
                            if (Значение[0] != '-')
                                ДисплейЗначения[(ТумблерГруппа) ? 0 : 1,
                                    Array.IndexOf(КнопкиПараметры, true)] = Значение;
                            break;
                        case 7:
                            if (Значение[0] == '-')
                                ДисплейЗначения[(ТумблерГруппа) ? 0 : 1,
                                    Array.IndexOf(КнопкиПараметры, true)] = Значение;
                            break;
                    }
                    Значение = "";
                }


                for (int i = 0; i < КнопкиПараметры.Length; i++)
                    КнопкиПараметры[i] = false;
                //проверка на сброс
                if (_кнопкаПараметр < 9) КнопкиПараметры[_кнопкаПараметр] = true;

                if (RefreshForm != null) RefreshForm();
            }
        }

        #endregion

        #region Табло
        /// <summary>
        /// Матрица для хранения введённых значений на дисплее, 1 строка соответствует значениям 1 группы переменных, а 2 для 2 группы.
        /// </summary>
        public static string[,] ДисплейЗначения = {  { "", "", "", "", "", "", "", "", ""},
                                                  { "", "", "", "", "", "", "", "", ""}    };

        private static string _значение = "";
        public static string Значение
        {
            get { return _значение; }
            set
            {
                if (ТумблерСеть || (!ТумблерСеть && value == ""))
                    if (value.Length == 0)
                    {
                        _значение = value;
                        if (RefreshForm != null) RefreshForm();
                    }
                    else if ((Array.IndexOf(КнопкиПараметры, true) == 2 ||
                                Array.IndexOf(КнопкиПараметры, true) == 3) && !ТумблерГруппа)
                    {
                        //ограничение на ввод параметров в 1 символ
                        if (value.Length <= 1 && value[0] != '-')
                        {
                            _значение = value;
                            if (RefreshForm != null) RefreshForm();
                        }
                    }
                    else if ((value[0] == '-' && value.Length <= 7) || (value[0] != '-' && value.Length <= 6))
                    {
                        _значение = value;
                        if (RefreshForm != null) RefreshForm();
                    }
            }
        }
        #endregion

        public delegate void VoidVoidSignature();
        public static event VoidVoidSignature RefreshForm;

        public static void ResetParameters()
        {
            ЛампочкаКомплект1 = ТумблерКомплект && ТумблерСеть && N502BParameters.ЛампочкаСфазировано;
            ЛампочкаКомплект2 = !ТумблерКомплект && ТумблерСеть && N502BParameters.ЛампочкаСфазировано;

            if (!ТумблерСеть)
            {
                for (int i = 0; i < 9; i++)
                {
                    ДисплейЗначения[0, i] = "";
                    ДисплейЗначения[1, i] = "";
                }
                Значение = "";
                Time = 0;
            }
        }
    }
}
