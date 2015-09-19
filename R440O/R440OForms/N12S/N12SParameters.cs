﻿using System;
using System.Windows.Forms;
using R440O.R440OForms.N15;

namespace R440O.Parameters
{
    class N12SParameters
    {
        public static bool Включен
        {
            get
            {
                return ТумблерСеть && N15Parameters.ТумблерН12С; 
            }
        }

        private static int _тумблерА;
        private static int _тумблерБ;
        private static bool _тумблерСеть;
        private static bool _кнопкаУскор;

        #region Тумблеры и кнопка
        public static bool ТумблерСеть
        {
            get { return _тумблерСеть; }
            set
            {
                _тумблерСеть = value;
                OnParameterChanged();
            }
        }

        public static int ТумблерА
        {
            get { return _тумблерА; }
            set
            {
                _тумблерА = value;

                if (ЛампочкаГотовность)
                    switch (_тумблерА)
                    {
                        case -1:
                            {
                                timer.Enabled = true;
                                timer.Interval = КнопкаУскор ? 5 : 50;
                                timer.Tick += timerAlphaLeft_Tick;
                                timer.Tick -= timerAlphaReturn_Tick;
                                timer.Start();
                                break;
                            }
                        case 0:
                            {
                                timer.Tick -= timerAlphaLeft_Tick;
                                timer.Tick -= timerAlphaRight_Tick;
                                timer.Tick += timerAlphaReturn_Tick;
                                break;
                            }
                        case 1:
                            {
                                timer.Enabled = true;
                                timer.Interval = КнопкаУскор ? 5 : 50;
                                timer.Tick += timerAlphaRight_Tick;
                                timer.Tick -= timerAlphaReturn_Tick;
                                timer.Start();
                                break;
                            }

                    }
                OnParameterChanged();
            }
        }

        public static int ТумблерБ
        {
            get { return _тумблерБ; }
            set
            {
                _тумблерБ = value;

                if (ЛампочкаГотовность)
                    switch (_тумблерБ)
                    {
                        case -1:
                            {
                                timer.Enabled = true;
                                timer.Interval = КнопкаУскор ? 5 : 50;
                                timer.Tick += timerBetaLeft_Tick;
                                timer.Tick -= timerBetaReturn_Tick;
                                timer.Start();
                                break;
                            }
                        case 0:
                            {
                                timer.Tick -= timerBetaLeft_Tick;
                                timer.Tick -= timerBetaRight_Tick;
                                timer.Tick += timerBetaReturn_Tick;
                                break;
                            }
                        case 1:
                            {
                                timer.Enabled = true;
                                timer.Interval = КнопкаУскор ? 5 : 50;
                                timer.Tick -= timerBetaReturn_Tick;
                                timer.Tick += timerBetaRight_Tick;
                                timer.Start();
                                break;
                            }
                    }
                OnParameterChanged();
            }
        }

        public static bool КнопкаУскор
        {
            get { return _кнопкаУскор; }
            set
            {
                _кнопкаУскор = value;
                OnParameterChanged();
            }
        }
        #endregion

        #region Лампочки
        public static bool ЛампочкаУпорА
        {
            get { return (ИндикаторAlpha <= -270 || ИндикаторAlpha >= 270) && Включен; }
        }

        public static bool ЛампочкаУпорБ
        {
            get { return (ИндикаторBeta <= 0 || ИндикаторBeta >= 90) && Включен; }
        }

        public static bool ЛампочкаГотовность
        {
            get { return Включен; }
        }
        #endregion

        #region Индикаторы

        /// <summary>
        /// значения от -270 до 270, но крутиться могут произвольно
        /// </summary>
        public static float ИндикаторAlpha { get; set; }

        /// <summary>
        /// значения от 0 до 90, но крутиться могут произвольно
        /// </summary>
        public static float ИндикаторBeta { get; set; }

        #endregion

        #region Потенциометры

        #region ПотенциометрBetaИ
        private static float _потенциометрBetaИ = 0;

        public static float ПотенциометрBetaИ
        {
            get { return _потенциометрBetaИ; }
            set
            {
                if (value >= 0 && value <= 90 && !ЛампочкаУпорБ) _потенциометрBetaИ = value;
                OnParameterChanged();
            }
        }
        #endregion

        #region ПотенциометрBetaV
        private static float _потенциометрBetaV = 0;

        public static float ПотенциометрBetaV
        {
            get
            {
                if (!Включен)
                {
                    _потенциометрBetaV = 0;
                    timer.Stop();
                    timer.Enabled = false;
                }
                else
                {
                    if (ЛампочкаУпорБ && !timer.Enabled)
                        _потенциометрBetaV = 0;
                }

                if (_потенциометрBetaV >= -0.2 && _потенциометрBetaV <= 0.2)
                    timer.Tick -= timerBetaReturn_Tick;

                return _потенциометрBetaV;
            }
            set
            {
                if (((!КнопкаУскор && value >= -10 && value <= 10) || (КнопкаУскор && value >= -20 && value <= 20))
                    && !(_потенциометрBetaV - value < 0 && ПотенциометрBetaИ < 45 && ЛампочкаУпорБ)
                    && !(_потенциометрBetaV - value > 0 && ПотенциометрBetaИ > 45 && ЛампочкаУпорБ)
                    && !(_потенциометрBetaV >= -0.2 && _потенциометрBetaV <= 0.2 && ЛампочкаУпорБ))

                    _потенциометрBetaV = value;
            }
        }
        #endregion

        #region ПотенциометрAlphaИ
        private static float _потенциометрAlphaИ = 0;

        public static float ПотенциометрAlphaИ
        {
            get { return _потенциометрAlphaИ; }
            set
            {
                if (value >= -270 && value <= 270 && !ЛампочкаУпорА) _потенциометрAlphaИ = value;
                OnParameterChanged();
            }
        }
        #endregion

        #region ПотенциометрAlphaV
        private static float _потенциометрAlphaV = 0;

        public static float ПотенциометрAlphaV
        {
            get
            {
                if (!Включен)
                {
                    _потенциометрAlphaV = 0;
                    timer.Stop();
                    timer.Enabled = false;
                }
                else
                {
                    if (ЛампочкаУпорА && !timer.Enabled)
                        _потенциометрAlphaV = 0;
                }

                if (_потенциометрAlphaV >= -0.05 && _потенциометрAlphaV <= 0.05)
                    timer.Tick -= timerAlphaReturn_Tick;

                return _потенциометрAlphaV;
            }
            set
            {
                if (((!КнопкаУскор && value >= -10 && value <= 10) || (КнопкаУскор && value >= -20 && value <= 20))
                    && !(_потенциометрAlphaV - value < 0 && ПотенциометрAlphaИ < 0 && ЛампочкаУпорА)
                    && !(_потенциометрAlphaV - value > 0 && ПотенциометрAlphaИ > 0 && ЛампочкаУпорА)
                    && !(_потенциометрAlphaV >= -0.05 && _потенциометрAlphaV <= 0.05 && ЛампочкаУпорА))

                    _потенциометрAlphaV = value;
            }
        }
        #endregion

        #endregion

        #region Вращение индикаторов и потенциометров
        private static Timer timer = new Timer();

        #region Альфа
        /// <summary>
        /// Вращение индиктора альфа вправо
        /// </summary>
        static void timerAlphaRight_Tick(object sender, EventArgs e)
        {
            ИндикаторAlpha += 0.5F;
            ПотенциометрAlphaИ += 0.5F;
            ПотенциометрAlphaV -= 0.1F;

            if (ЛампочкаУпорА)
                if (ПотенциометрAlphaV > 0)
                    ПотенциометрAlphaV -= 0.1F;
                else
                    ПотенциометрAlphaV += 0.1F;

            OnParameterChanged();
        }

        /// <summary>
        /// Вращение индиктора альфа влево
        /// </summary>
        static void timerAlphaLeft_Tick(object sender, EventArgs e)
        {
            ИндикаторAlpha -= 0.5F;
            ПотенциометрAlphaИ -= 0.5F;
            ПотенциометрAlphaV += 0.1F;

            if (ЛампочкаУпорА)
                if (ПотенциометрAlphaV > 0)
                    ПотенциометрAlphaV -= 0.1F;
                else
                    ПотенциометрAlphaV += 0.1F;

            OnParameterChanged();
        }

        /// <summary>
        /// возврат стрелки потенциометра альфа
        /// </summary>
        static void timerAlphaReturn_Tick(object sender, EventArgs e)
        {
            if (ПотенциометрAlphaV > 0)
                ПотенциометрAlphaV -= 0.1F;
            else
                ПотенциометрAlphaV += 0.1F;

            OnParameterChanged();
        }
        #endregion

        #region Бета
        /// <summary>
        /// Вращение индиктора бета вправо
        /// </summary>
        static void timerBetaRight_Tick(object sender, EventArgs e)
        {
            ИндикаторBeta += 0.5F;
            ПотенциометрBetaИ += 0.5F;
            ПотенциометрBetaV -= 0.2F;

            if (ЛампочкаУпорБ)
                if (ПотенциометрBetaV > 0)
                    ПотенциометрBetaV -= 0.2F;
                else
                    ПотенциометрBetaV += 0.2F;

            OnParameterChanged();
        }

        /// <summary>
        /// Вращение индиктора бета влево
        /// </summary>
        static void timerBetaLeft_Tick(object sender, EventArgs e)
        {
            ИндикаторBeta -= 0.5F;
            ПотенциометрBetaИ -= 0.5F;
            ПотенциометрBetaV += 0.2F;

            if (ЛампочкаУпорБ)
                if (ПотенциометрBetaV > 0)
                    ПотенциометрBetaV -= 0.2F;
                else
                    ПотенциометрBetaV += 0.2F;

            OnParameterChanged();
        }

        /// <summary>
        /// возврат стрелки потенциометра бета
        /// </summary>
        static void timerBetaReturn_Tick(object sender, EventArgs e)
        {
            if (ПотенциометрBetaV > 0)
                ПотенциометрBetaV -= КнопкаУскор ? 0.2F : 0.4F;
            else
                ПотенциометрBetaV += КнопкаУскор ? 0.2F : 0.4F;

            OnParameterChanged();
        }
        #endregion

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
}
