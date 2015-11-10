using System;
using System.Windows.Forms;
using R440O.R440OForms.N15;

namespace R440O.R440OForms.A403_1
{
    public static class A403_1Parameters
    {
        public static bool Включен
        {
            get
            {
                return Включен = ТумблерСеть && N15Parameters.ТумблерА403 && N15Parameters.Включен;
            }
            set
            {
                if (!_включен && value) //включение
                {
                    timer.Enabled = true;
                    timer.Tick += timer_Tick;
                    timer.Interval = 1000;
                    timer.Start();
                }
                else if (_включен && !value) //отключение
                {
                    ДисплейЗначения.ОчиститьЗначения();

                    timer.Enabled = false;
                    timer.Tick -= timer_Tick;
                    timer.Stop();
                    Time = 0;

                    _значение = "";
                }

                _включен = value;
            }
        }

        /// <summary>
        /// Показывает, было ли записано значение в ДисплейЗначения
        /// </summary>
        public static bool IsWritten { get; set; }

        /// <summary>
        /// true - 1 комплект, false - 2 комплект
        /// </summary>
        public static bool Комплект
        {
            get { return _комплект; }
            set
            {
                if (_комплект != value)
                    Time = 0;
                _комплект = value;
            }
        }

        #region Private

        private static bool _включен;
        private static bool _тумблерСеть;
        private static bool _тумблерГотов;
        private static bool _тумблерАвтКоррекция;
        private static bool _тумблерГруппа;
        private static bool _тумблерКомплект;
        private static string _значение = "";
        private static bool _кнопкаУстВремени;
        private static bool _комплект;

        #endregion

        #region Таймер

        /// <summary>
        /// Переменная для хранения времени работы
        /// </summary>
        public static int Time = 0;

        /// <summary>
        /// Таймер для времени работы
        /// </summary>
        public static Timer timer = new Timer();

        /// <summary>
        /// Обработчик события тика таймера: инкремент времени
        /// </summary>
        public static void timer_Tick(object sender, EventArgs e)
        {
            if (КнопкиПараметры.PressedButton == -1)
            {
                //форматированная запись в значение для последующего отображения на дисплее
                _значение = " " + (Time / 3600 / 10) + (Time / 3600 % 10) +
                           (Time / 60 % 60 / 10) + (Time / 60 % 60 % 10) +
                           (Time % 60 / 10) + (Time % 60 % 10);
                if (Time > 86400)
                {
                    _значение = "";
                    Time = 0;
                }
                OnDisplayChanged();
            }
            Time++;
        }

        #endregion

        #region Лампочки

        /// <summary>
        /// Возможные состояния: true - работает 1 комплект, false - не работает 1 комплект
        /// </summary>
        public static bool ЛампочкаКомплект1
        {
            get { return Включен && Комплект; }
        }

        /// <summary>
        /// Возможные состояния: true - работает 2 комплект, false - не работает 2 комплект
        /// </summary>
        public static bool ЛампочкаКомплект2
        {
            get { return Включен && !Комплект; }
        }

        #endregion

        #region Тумблеры

        public static bool ТумблерСеть
        {
            get { return _тумблерСеть; }
            set
            {
                _тумблерСеть = value;
                OnParameterChanged();
                N15Parameters.ResetParametersAlternative();
            }
        }

        public static bool ТумблерГотов
        {
            get { return _тумблерГотов; }
            set
            {
                _тумблерГотов = value;
                OnParameterChanged();
            }
        }

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
                _тумблерГруппа = value;
                if (Включен && КнопкиПараметры.PressedButton != -1)
                {
                    _значение = "";
                    IsWritten = false;
                }
                OnParameterChanged();
            }
        }


        /// <summary>
        /// Возможные состояния: true - 1 комплект, false - 2 комплект
        /// </summary>
        public static bool ТумблерКомплект
        {
            get { return _тумблерКомплект; }
            set
            {
                if ((value && !Комплект) || (!value && Комплект))
                    Комплект = !Комплект;

                _тумблерКомплект = value;
                OnParameterChanged();
            }
        }

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

        public static bool КнопкаУстВремени
        {
            get { return _кнопкаУстВремени; }
            set
            {
                if (Включен && !value && !ТумблерАвтКоррекция)
                {
                    int hours = Int32.Parse(ДисплейЗначения[0, 8].Substring(1, 2));
                    int minutes = Int32.Parse(ДисплейЗначения[0, 8].Substring(3, 2));
                    int seconds = Int32.Parse(ДисплейЗначения[0, 8].Substring(5, 2));
                    Time = hours * 3600 + minutes * 60 + seconds;
                }

                _кнопкаУстВремени = value;
            }
        }
        #endregion

        #region Табло

        /// <summary>
        /// Матрица для хранения введённых значений на дисплее, 1 строка соответствует значениям 1 группы переменных, а 2 для 2 группы.
        /// </summary>
        public static A403_1ЗначенияПараметров ДисплейЗначения = new A403_1ЗначенияПараметров();


        /// <summary>
        /// Свойство для хранения:
        /// введенного на табло значения но не сохраненного в ДисплейЗначения, а также
        /// отображения времени таймера
        /// </summary>
        public static string Значение
        {
            get { return _значение; }
            set
            {
                if (Включен && !IsWritten)
                {
                    if ((КнопкиПараметры.PressedButton == 2 || КнопкиПараметры.PressedButton == 3)
                        && !ТумблерГруппа && value.Length == 2)
                    {
                            ДисплейЗначения[ТумблерГруппа ? 0 : 1, КнопкиПараметры.PressedButton] = value;
                            _значение = "";
                    }
                    else if (value.Length == 7)
                    {
                        ДисплейЗначения[ТумблерГруппа ? 0 : 1, КнопкиПараметры.PressedButton] = value;
                        _значение = "";
                    }
                    else if (value.Length <= 7 && КнопкиПараметры.PressedButton != -1)
                    {
                        _значение = value;
                        OnDisplayChanged();
                    }
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

        #region DisplayReset

        public delegate void DisplayChangedHandler();

        public static event DisplayChangedHandler DisplayChanged;

        private static void OnDisplayChanged()
        {
            var handler = DisplayChanged;
            if (handler != null) handler();
        }

        public static void ResetDisplay()
        {
            OnDisplayChanged();
        }

        #endregion
    }
 
    #region IndexerClass
    public class A403_1Кнопки
    {
        // Для кнопки сброс также есть параметр чтобы отслеживать ее нажатие в данном классе, иначе не получается реализовать 
        // запрет пользователю на отжатие кнопок (нельзя отследить что инициатором является кнопка сброс а не пользователь)

        public static bool[] КнопкиПараметры = { false, false, false, false, false, false, false, false, false, false };
        public bool this[int buttonNumber]
        {
            get
            {
                return КнопкиПараметры[buttonNumber];
            }
            set
            {
                if (buttonNumber == 9) //если кнопка сброс - отжать все кнопки
                {
                    for (int i = 0; i < 9; i++)
                        КнопкиПараметры[i] = false;
                }
                else
                {
                    for (int i = 0; i < 9; i++)
                        КнопкиПараметры[i] = false;

                    КнопкиПараметры[buttonNumber] = value;
                    A403_1Parameters.IsWritten = false;
                }

                A403_1Parameters.ResetParameters();
            }
        }

        public int PressedButton
        {
            get { return Array.IndexOf(КнопкиПараметры, true); }
        }
    }

    public class A403_1ЗначенияПараметров
    {
        public static string[,] ДисплейЗначения =
        {
            {"", "", "", "", "", "", "", "", "+000000"},
            {"", "", "", "", "", "", "", "", ""}
        };

        public string this[int группа, int номерКнопки]
        {
            get { return ДисплейЗначения[группа, номерКнопки]; }
            set
            {
                //ограничения на размер хранимых значений
                if (A403_1Parameters.КнопкиПараметры.PressedButton == 8 && группа == 0
                    && value.Length == 7) //установка времени
                {
                    int hours = Int32.Parse(value.Substring(1, 2));
                    int minutes = Int32.Parse(value.Substring(3, 2));
                    int seconds = Int32.Parse(value.Substring(5, 2));
                    int time = hours*3600 + minutes*60 + seconds;

                    ДисплейЗначения[0, 8] = (time > 86400) 
                        ? "+275135"
                        : "+" + (time / 3600 / 10) + (time / 3600 % 10) +
                           (time / 60 % 60 / 10) + (time / 60 % 60 % 10) +
                           (time % 60 / 10) + (time % 60 % 10);
                }
                else if (группа == 1 && value.Length == 2
                         && (A403_1Parameters.КнопкиПараметры.PressedButton == 2
                             || A403_1Parameters.КнопкиПараметры.PressedButton == 3))
                {
                    ДисплейЗначения[группа, номерКнопки] = value;
                }
                else if (A403_1Parameters.КнопкиПараметры.PressedButton != -1 && value.Length == 7)
                {
                    ДисплейЗначения[группа, номерКнопки] = value;
                }
                else
                {
                    return;
                }

                A403_1Parameters.Значение = "";
                A403_1Parameters.ResetDisplay();
                A403_1Parameters.IsWritten = true;
            }
        }

        public void ОчиститьЗначения()
        {
            for (int i = 0; i < 9; i++)
            {
                ДисплейЗначения[0, i] = "";
                ДисплейЗначения[1, i] = "";
            }
        }
    }

    #endregion
}