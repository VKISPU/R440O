using System;
using System.Windows.Forms;
using R440O.Parameters;
using R440O.R440OForms.N15;

namespace R440O.R440OForms.A403_1
{
    public static class A403_1Parameters
    {
        #region Расчет

        public static double AlphaP = 0;
        public static double BetaP = 0;

        public static void Calculate()
        {
            //var a = ДисплейЗначения1К.GetInt(0, 0) / 10d;
            //var e = ДисплейЗначения1К.GetInt(0, 1) / 1000000d;
            //var i = ДисплейЗначения1К.GetRad(0, 2);
            //var omega = ДисплейЗначения1К.GetRad(0, 3);
            //var fi = ДисплейЗначения1К.GetRad(1, 1);
            //var H = ДисплейЗначения1К.GetInt(1, 2);
            //var t0 = ДисплейЗначения1К.GetTime(); //время в секундах
            //var lambda = ДисплейЗначения1К.GetRad(1, 0);
            //var lambda0 = ДисплейЗначения1К.GetRad(0, 4);
            //var T = ДисплейЗначения1К.GetTime();

            var a = 26541.9;
            var e = 0.741271;
            var i = (64 + 53.5F/60)*0.0174532925199;
            var omega = (279 + 10.5F/60)*0.0174532925199;
            var fi = (48 + 47.2F/60)*0.0174532925199;
            var H = 1;
            var t0 = 12*3600 + 37*60 + 23;
            var lambda = (356 + 28.5F/60)*0.0174532925199;
            var lambda0 = (77 + 38.5F/60)*0.0174532925199;
            var T = 11*3600 + 57*60 + 16;
            //Time = 21 * 3600 + 10 * 60;

            var m = 0d;
            var alpha = 0d;
            var beta = 0d;

            //while ((int)alpha != 47 && (int)beta != 22)
            for (int l = 0; l < 20; l++)
            {
                m += 0.0001;

                var cosE0 = (float) (0.5F*e + 0.5F*Math.Cos(omega))/
                            (0.5F + 0.5F*e*Math.Cos(omega));
                var absSinE0 = Math.Sqrt(1 - cosE0*cosE0);
                var sinE0 = Math.Sin(omega) < 0 ? absSinE0 : absSinE0*(-1);
                var tgE0 = (float) sinE0/cosE0;
                var E0 = Math.Atan(tgE0);
                var M0 = E0 - e*(1F/(Math.PI*2))*sinE0;
                var pzx = Math.Sin(omega)*Math.Sin(i);
                var pzy = Math.Cos(omega)*Math.Sin(i);
                var S = Math.Sin(omega)*Math.Cos(i);
                var C = Math.Cos(omega)*Math.Cos(i);
                var Rad = a*Math.Sqrt(1 - Math.Pow(e, 2));
                var f = 1/298.3;
                var Cfi = (6376.245/Math.Pow(10, 5))/
                          Math.Sqrt(1 - (2*f - f*f)*Math.Pow(Math.Sin(fi), 2));
                var Sfi = Cfi*Math.Pow(1 - f, 2);
                var X = (Cfi + H)*Math.Cos(fi);
                var Z = (Sfi + H)*Math.Sin(fi);


                var Msr = (float) (Time - t0)/T + M0;
                var Ek = E0; //Эксцентрическая аномалия 

                for (int j = 0; j < 20; j++)
                {
                    double deltaEk = (0.5*Msr + 0.5*(1F/(Math.PI*2)*e*Math.Sin(Ek) - 0.5*Ek))/(0.5 - 0.5*e*Math.Cos(Ek));
                    Ek = Ek + deltaEk;
                }

                var x1 = a*Math.Cos(Ek) - a*e;
                var y1 = Rad*Math.Sin(Ek);
                //     var m = 0.5; //а это что?
                var delta = (Time - t0)/m + lambda - lambda0;

                //элементы матрицы поворота
                var pxx = S*Math.Sin(delta) + Math.Cos(omega)*Math.Cos(delta);
                var pxy = C*Math.Sin(delta) - Math.Sin(omega)*Math.Cos(delta);
                var pyx = S*Math.Cos(delta) - Math.Cos(omega)*Math.Sin(delta);
                var pyy = C*Math.Cos(delta) + Math.Sin(omega)*Math.Sin(delta);

                //координаты ИСЗ в декартовой системе
                var x = pxx*x1 + pxy*y1;
                var y = pyx*x1 + pyy*y1;
                var z = pzx*x1 + pzy*y1;

                var ro = Math.Sqrt(Math.Pow(x - X, 2) + y*y + Math.Pow(z - Z, 2));
                var d = 6375.245*ro; //дальность (расстояние от наблюдателя до ИСЗ)
                var ksi = (z - Z)*Math.Cos(fi) - (x - X)*Math.Sin(fi);
                var eta = y;
                var dzeta = (z - Z)*Math.Sin(fi) + (x - X)*Math.Cos(fi);
                var tanAlpha = eta/ksi;
                alpha = Math.Atan(tanAlpha)*180/Math.PI; //азимут
                var tanBeta = dzeta/Math.Sqrt(ksi*ksi + eta*eta);
                beta = Math.Atan(tanBeta)*180/Math.PI; //угол места 
            }
            AlphaP = Math.Round(alpha, 3);
            BetaP = Math.Round(beta, 3);
        }

        #endregion

        public static bool Включен
        {
            get { return ТумблерСеть && N15Parameters.ТумблерА403 && N15Parameters.Включен; }
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

        public static string Дисплей
        {
            get
            {
                switch (ПереключательПроверка)
                {
                    case 3:
                        _значение = GradForDisplay(AlphaP);
                        break;
                    case 4:
                        _значение = GradForDisplay(BetaP);
                        break;
                    case 6:
                        _значение = GradForDisplay(N12SParameters.ПотенциометрAlphaИ);
                        break;
                    case 7:
                        _значение = GradForDisplay(N12SParameters.ПотенциометрBetaИ);
                        break;
                }
                return Значение;
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
            if (Включен && ТумблерГотов)
                Calculate();

            if (КнопкиПараметры.PressedButton == -1 && ПереключательПроверка != 6)
            {
                //форматированная запись в значение для последующего отображения на дисплее
                _значение = " " + (Time/3600/10) + (Time/3600%10) +
                            (Time/60%60/10) + (Time/60%60%10) +
                            (Time%60/10) + (Time%60%10);
                if (Time > 86400)
                {
                    _значение = "";
                    Time = 0;
                }
                OnDisplayChanged();
            }
            Time++;
        }

        private static void SetTimer()
        {
            timer.Stop();
            timer.Tick -= timer_Tick;
            if (Включен) //включение
            {
                timer.Enabled = true;
                timer.Tick += timer_Tick;
                timer.Interval = 1000;
                timer.Start();
                timer_Tick(null, null);
            }
            else //отключение
            {
                ДисплейЗначения1К.ОчиститьЗначения();
                ДисплейЗначения2К.ОчиститьЗначения();
                _значение = "";
                timer.Enabled = false;
                Time = 0;
            }
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
                SetTimer();
                OnParameterChanged();
                N15Parameters.ResetParametersAlternative();
            }
        }

        public static bool ТумблерГотов
        {
            get { return _тумблерГотов; }
            set
            {
                if (Включен && _тумблерГотов == false && value)
                {
                    Calculate();
                }
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
        /// 5 - РИ,
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
                //switch (value)
                //{
                //    case 5:
                //    {
                //        if (ТумблерАвтКоррекция)

                //        break;
                //    }
                //}
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
                if (Включен && value && !ТумблерАвтКоррекция)
                {
                    int hours =
                        Int32.Parse(ТумблерКомплект
                            ? ДисплейЗначения1К[0, 8].Substring(1, 2)
                            : ДисплейЗначения2К[0, 8].Substring(1, 2));
                    int minutes =
                        Int32.Parse(ТумблерКомплект
                            ? ДисплейЗначения1К[0, 8].Substring(3, 2)
                            : ДисплейЗначения2К[0, 8].Substring(3, 2));
                    int seconds =
                        Int32.Parse(ТумблерКомплект
                            ? ДисплейЗначения1К[0, 8].Substring(5, 2)
                            : ДисплейЗначения2К[0, 8].Substring(5, 2));
                    Time = hours*3600 + minutes*60 + seconds;
                }

                _кнопкаУстВремени = value;
            }
        }

        #endregion

        #region Табло

        /// <summary>
        /// Матрица для хранения введённых значений для 1 комплекта, 1 строка соответствует значениям 1 группы переменных, а 2 для 2 группы.
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
        public static A403_1ЗначенияПараметров ДисплейЗначения1К = new A403_1ЗначенияПараметров();

        /// <summary>
        /// Матрица для хранения введённых значений для 2 комплекта, 1 строка соответствует значениям 1 группы переменных, а 2 для 2 группы.
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
        public static A403_1ЗначенияПараметров ДисплейЗначения2К = new A403_1ЗначенияПараметров();


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
                        if (ТумблерКомплект)
                            ДисплейЗначения1К[ТумблерГруппа ? 0 : 1, КнопкиПараметры.PressedButton] = value;
                        else
                            ДисплейЗначения2К[ТумблерГруппа ? 0 : 1, КнопкиПараметры.PressedButton] = value;
                        _значение = "";
                    }
                    else if (value.Length == 7)
                    {
                        if (ТумблерКомплект)
                            ДисплейЗначения1К[ТумблерГруппа ? 0 : 1, КнопкиПараметры.PressedButton] = value;
                        else
                            ДисплейЗначения2К[ТумблерГруппа ? 0 : 1, КнопкиПараметры.PressedButton] = value;
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

        /// <summary>
        /// Для преобразования значения угла в градусах в строку для отображения на дисплее
        /// </summary>
        private static string GradForDisplay(double value)
        {
            var angle = Math.Abs((int) value).ToString().PadLeft(3, '0') +
                        Math.Abs((int) (value%1*60*10)).ToString().PadLeft(3, '0');
            return value >= 0 ? "+" + angle : "-" + angle;
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
            SetTimer();
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

        public static bool[] КнопкиПараметры = {false, false, false, false, false, false, false, false, false, false};

        public bool this[int buttonNumber]
        {
            get { return КнопкиПараметры[buttonNumber]; }
            set
            {
                for (int i = 0; i < 9; i++)
                    КнопкиПараметры[i] = false;

                if (buttonNumber != 9)
                {
                    for (int i = 0; i < 9; i++)
                        КнопкиПараметры[i] = false;
                    КнопкиПараметры[buttonNumber] = true;
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
                        : "+" + (time/3600/10) + (time/3600%10) +
                          (time/60%60/10) + (time/60%60%10) +
                          (time%60/10) + (time%60%10);
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
            ДисплейЗначения[0, 8] = "+000000";
        }

        public int GetInt(int группа, int номер)
        {
            return ДисплейЗначения[группа, номер] == "" ? 0 : int.Parse(ДисплейЗначения[группа, номер]);
        }

        public int GetTime()
        {
            int hours = 0, minutes = 0, seconds = 0;
            if (ДисплейЗначения[0, 5].Length == 7)
            {
                hours = int.Parse(ДисплейЗначения[0, 5].Substring(1, 2));
                minutes = int.Parse(ДисплейЗначения[0, 5].Substring(3, 2));
                seconds = int.Parse(ДисплейЗначения[0, 5].Substring(5, 2));
            }
            return hours*3600 + minutes*60 + seconds;
        }

        public double GetRad(int группа, int номер)
        {
            return (GetInt(группа, номер)/1000 + (GetInt(группа, номер)%1000/10d)/60d)*0.0174532925199;
        }
    }

    #endregion
}