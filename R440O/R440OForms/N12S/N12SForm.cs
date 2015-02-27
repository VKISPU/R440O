//-----------------------------------------------------------------------
// <copyright file="N12SForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using R440O.Parameters;
using R440O.ThirdParty;

namespace R440O.R440OForms.N12S
{
    using System.Windows.Forms;

    /// <summary>
    /// Форма блока Н-12-С
    /// </summary>
    public partial class N12SForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="N12SForm"/>
        /// </summary>
        public N12SForm()
        {
            InitializeComponent();
            InitializeButtonsPosition();
            InitializeIndicatorsPosition();         

            timer = new Timer();
            timer.Enabled = false;

            FormClosing += IndicatorsToNull;
            N12SТумблерСеть.Click += IndicatorsToNull;
        }

        private readonly Timer timer;

        #region Индикаторы
        private void timerAlphaRight_Tick(object sender, EventArgs e)
        {

            if (N12SParameters.N12SIndicatorAlpha >= -270 && N12SParameters.N12SIndicatorAlpha <= 270)
                N12SParameters.N12SIndicatorAlphaИ += 0.5F;
            N12SParameters.N12SIndicatorAlpha += 0.5F;

            //положение стрелок потенциометров
            if (N12SParameters.N12SIndicatorAlphaИ != -270)
                if (N12SParameters.N12SIndicatorAlphaV <= 10)
                    N12SParameters.N12SIndicatorAlphaV += 0.1F;
                else if (N12SParameters.N12SКнопкаУскор && N12SParameters.N12SIndicatorAlphaV <= 20)
                    N12SParameters.N12SIndicatorAlphaV += 0.1F;
                else if (N12SParameters.N12SIndicatorAlphaИ == -270 || N12SParameters.N12SIndicatorAlphaИ == 270)
                    N12SParameters.N12SIndicatorAlphaV += 0.1F;

            //отрисовка индикаторов (стрелок и кругов)
            var angle = N12SParameters.N12SIndicatorAlpha * (-36) + 36;
            N12SIndicatorAlphaCenter.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorCenter, angle);

            angle = - N12SParameters.N12SIndicatorAlpha - 67;
            N12SIndicatorAlpha.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorAlpha, angle);

            angle = N12SParameters.N12SIndicatorAlphaИ * 0.18F ;
            N12SIndicatorAlphaИ.BackgroundImage =
                   TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow, angle);

            angle = N12SParameters.N12SIndicatorAlphaV * 1.5F;
            N12SIndicatorAlphaV.BackgroundImage =
                   TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow, angle);

            if (N12SParameters.N12SIndicatorAlphaИ == -270 || N12SParameters.N12SIndicatorAlphaИ == 270)
            {
                N12SParameters.N12SЛампочкаУпорА = true;
                N12SЛампочкаУпорА.BackgroundImage = ControlElementImages.lampType6OnRed;
            }
            else
            {
                N12SParameters.N12SЛампочкаУпорА = false;
                N12SЛампочкаУпорА.BackgroundImage = null;
            }
        }

        private void timerAlphaLeft_Tick(object sender, EventArgs e)
        {
            if (N12SParameters.N12SIndicatorAlpha >= -270 && N12SParameters.N12SIndicatorAlpha <= 270)
                N12SParameters.N12SIndicatorAlphaИ -= 0.5F;
            N12SParameters.N12SIndicatorAlpha -= 0.5F;

            //положение стрелок потенциометров
            if (N12SParameters.N12SIndicatorAlphaИ != 270)
                if (N12SParameters.N12SIndicatorAlphaV >= -10)
                    N12SParameters.N12SIndicatorAlphaV -= 0.1F;
                else if (N12SParameters.N12SКнопкаУскор && N12SParameters.N12SIndicatorAlphaV >= -20)
                    N12SParameters.N12SIndicatorAlphaV -= 0.1F;
                else if (N12SParameters.N12SIndicatorAlphaИ == -270 || N12SParameters.N12SIndicatorAlphaИ == 270)
                    N12SParameters.N12SIndicatorAlphaV -= 0.1F;
            

            var angle = N12SParameters.N12SIndicatorAlpha * (-36) + 36;
            N12SIndicatorAlphaCenter.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorCenter, angle);

            angle = - N12SParameters.N12SIndicatorAlpha - 67;
            N12SIndicatorAlpha.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorAlpha, angle);

            angle = N12SParameters.N12SIndicatorAlphaИ * 0.18F ;
            N12SIndicatorAlphaИ.BackgroundImage =
                   TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow, angle);

            angle = N12SParameters.N12SIndicatorAlphaV * 1.5F;
            N12SIndicatorAlphaV.BackgroundImage =
                   TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow, angle);

            if (N12SParameters.N12SIndicatorAlphaИ == -270 || N12SParameters.N12SIndicatorAlphaИ == 270)
            {
                N12SParameters.N12SЛампочкаУпорА = true;
                N12SЛампочкаУпорА.BackgroundImage = ControlElementImages.lampType6OnRed;
            }
            else
            {
                N12SParameters.N12SЛампочкаУпорА = true;
                N12SЛампочкаУпорА.BackgroundImage = null;
            }

        }

        private void timerBetaLeft_Tick(object sender, EventArgs e)
        {
            if (N12SParameters.N12SIndicatorBeta >= 0 && N12SParameters.N12SIndicatorBeta <= 90)
                N12SParameters.N12SIndicatorBetaИ += 0.5F;
            N12SParameters.N12SIndicatorBeta += 0.5F;
            
            //работа стрелок потенциометра
            if (N12SParameters.N12SIndicatorBetaИ != 0)
                if (N12SParameters.N12SIndicatorBetaV <= 10)
                    N12SParameters.N12SIndicatorBetaV += 0.2F;
                else if (N12SParameters.N12SКнопкаУскор && N12SParameters.N12SIndicatorBetaV <= 20)
                    N12SParameters.N12SIndicatorBetaV += 0.2F;
                else if (N12SParameters.N12SIndicatorBetaИ == 0 || N12SParameters.N12SIndicatorBetaИ == 90)
                    N12SParameters.N12SIndicatorBetaV += 0.2F;

            var angle = N12SParameters.N12SIndicatorBeta * (-36)  + 36;
                N12SIndicatorBetaCenter.BackgroundImage =
                    TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorCenter, angle);

                angle = - N12SParameters.N12SIndicatorBeta + 48;
                N12SIndicatorBeta.BackgroundImage =
                    TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorBeta, angle);

                angle = N12SParameters.N12SIndicatorBetaИ * 1.1F - 50;
                N12SIndicatorBetaИ.BackgroundImage =
                       TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow, angle);

                angle = N12SParameters.N12SIndicatorBetaV * 1.5F;
                N12SIndicatorBetaV.BackgroundImage =
                       TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow, angle);

            if (N12SParameters.N12SIndicatorBetaИ == 90 || N12SParameters.N12SIndicatorBetaИ == 0)
            {
                N12SParameters.N12SЛампочкаУпорБ = true;
                N12SЛампочкаУпорБ.BackgroundImage = ControlElementImages.lampType6OnRed;
            }
            else
            {
                N12SParameters.N12SЛампочкаУпорБ = false;
                N12SЛампочкаУпорБ.BackgroundImage = null;
            }
        }

        private void timerBetaRight_Tick(object sender, EventArgs e)
        {
            if (N12SParameters.N12SIndicatorBeta >= 0 && N12SParameters.N12SIndicatorBeta <= 90)
                N12SParameters.N12SIndicatorBetaИ -= 0.5F;
            N12SParameters.N12SIndicatorBeta -= 0.5F;

            //работа потенциометров
            if (N12SParameters.N12SIndicatorBetaИ != 90)
                if (N12SParameters.N12SIndicatorBetaV >= -10)
                    N12SParameters.N12SIndicatorBetaV -= 0.2F;
                else if (N12SParameters.N12SКнопкаУскор && N12SParameters.N12SIndicatorBetaV >= -20)
                    N12SParameters.N12SIndicatorBetaV -= 0.2F;
                else if (N12SParameters.N12SIndicatorBetaИ == 0 || N12SParameters.N12SIndicatorBetaИ == 90)
                    N12SParameters.N12SIndicatorBetaV -= 0.2F;



            var angle = N12SParameters.N12SIndicatorBetaV * 1.5F;
            N12SIndicatorBetaV.BackgroundImage =
                   TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow, angle);

            angle = N12SParameters.N12SIndicatorBeta *(-36) + 36;
            N12SIndicatorBetaCenter.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorCenter, angle);

            angle = - N12SParameters.N12SIndicatorBeta + 48;
            N12SIndicatorBeta.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorBeta, angle);

            angle = N12SParameters.N12SIndicatorBetaИ*1.1F - 50;
            N12SIndicatorBetaИ.BackgroundImage =
                   TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow, angle);

            if (N12SParameters.N12SIndicatorBetaИ == 0 || N12SParameters.N12SIndicatorBetaИ == 90)
            {
                N12SParameters.N12SЛампочкаУпорБ = true;
                N12SЛампочкаУпорБ.BackgroundImage = ControlElementImages.lampType6OnRed;
            }
            else
            {
                N12SParameters.N12SЛампочкаУпорБ = false;
                N12SЛампочкаУпорБ.BackgroundImage = null;
            }
        }

        private void N12SКнопкаУскор_Click(object sender, System.EventArgs e)
        {
            if (N12SParameters.N12SКнопкаУскор)
                N12SКнопкаУскор.BackgroundImage = null;
            else
                N12SКнопкаУскор.BackgroundImage = ControlElementImages.buttonRoundType8;
            N12SParameters.N12SКнопкаУскор = !N12SParameters.N12SКнопкаУскор;
        }
        #endregion

        #region Потенциометры
        /// <summary>
        /// Сброс потенциометров при закрытии формы и отключении питания
        /// </summary>
        private void IndicatorsToNull(object sender, EventArgs e)
        {
 

            if (N12SParameters.N12SIndicatorBetaИ == 0)
                N12SParameters.N12SIndicatorBetaV = -30;
            else if (N12SParameters.N12SIndicatorBetaИ == 90)
                N12SParameters.N12SIndicatorBetaV = 30;
            else N12SParameters.N12SIndicatorBetaV = 0;

            if (N12SParameters.N12SIndicatorAlphaИ == -270)
                N12SParameters.N12SIndicatorAlphaV = -30;
            else if (N12SParameters.N12SIndicatorAlphaИ == 270)
                N12SParameters.N12SIndicatorAlphaV = 30;
            else N12SParameters.N12SIndicatorAlphaV = 0;
        }

        /// <summary>
        /// возврат стрелки потенциометра альфа
        /// </summary>
        private void timerAlphaReturn_Tick(object sender, EventArgs e)
        {
            if (N12SParameters.N12SIndicatorAlphaV == 0 || N12SParameters.N12SIndicatorAlphaИ == 270
                || N12SParameters.N12SIndicatorAlphaИ == -270)
                timer.Stop();
            else if (N12SParameters.N12SIndicatorAlphaV > 0)
            {
                N12SParameters.N12SIndicatorAlphaV -= 0.1F;

            }
            else
                N12SParameters.N12SIndicatorAlphaV += 0.1F;

            var angle = N12SParameters.N12SIndicatorAlphaV * 1.5F;
            N12SIndicatorAlphaV.BackgroundImage =
                   TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow, angle);

        }

        /// <summary>
        /// возврат стрелки потенциометра бета
        /// </summary>
        private void timerBetaReturn_Tick(object sender, EventArgs e)
        {
            if (N12SParameters.N12SIndicatorBetaV == 0 || N12SParameters.N12SIndicatorBetaИ == 90
                || N12SParameters.N12SIndicatorBetaИ == 0)
                timer.Stop();
            else if (N12SParameters.N12SIndicatorBetaV > 0)
                N12SParameters.N12SIndicatorBetaV -= 0.2F;
            else
                N12SParameters.N12SIndicatorBetaV += 0.2F;

            var angle = N12SParameters.N12SIndicatorBetaV * 1.5F;
            N12SIndicatorBetaV.BackgroundImage =
                   TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow, angle);
        }

        /// <summary>
        /// возврат стрелки потенциометра бета до 30 при упоре
        /// </summary>
        private void timerBetaReturnTo30_Tick(object sender, EventArgs e)
        {
            if (N12SParameters.N12SIndicatorBetaV >= 30 || N12SParameters.N12SIndicatorBetaV <= -30)
                timer.Stop();
            else if (N12SParameters.N12SIndicatorBetaИ == 90)
                N12SParameters.N12SIndicatorBetaV += 0.2F;
            else if (N12SParameters.N12SIndicatorBetaИ == 0)
                N12SParameters.N12SIndicatorBetaV -= 0.2F;

            var angle = N12SParameters.N12SIndicatorBetaV * 1.5F;
            N12SIndicatorBetaV.BackgroundImage =
                   TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow, angle);
        }

        /// <summary>
        /// возврат стрелки потенциометра бета до 30 при упоре
        /// </summary>
        private void timerAlphaReturnTo30_Tick(object sender, EventArgs e)
        {
            if (N12SParameters.N12SIndicatorAlphaV >= 30 || N12SParameters.N12SIndicatorAlphaV <= -30)
                timer.Stop();
            else if (N12SParameters.N12SIndicatorAlphaИ == 270)
                N12SParameters.N12SIndicatorAlphaV += 0.1F;
            else if (N12SParameters.N12SIndicatorAlphaИ == -270)
                N12SParameters.N12SIndicatorAlphaV -= 0.1F;

            var angle = N12SParameters.N12SIndicatorAlphaV * 1.5F;
            N12SIndicatorAlphaV.BackgroundImage =
                   TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow, angle);
        }
        #endregion

        #region Тумблеры
        private void N12SТумблерА_MouseDown(object sender, MouseEventArgs e)
        {
            timer.Tick -= timerAlphaReturnTo30_Tick;
            timer.Tick -= timerAlphaReturn_Tick;
            if (e.Button == MouseButtons.Left)
            {
                if (N12SParameters.N12SТумблерСеть)
                {
                    timer.Tick += timerAlphaLeft_Tick;
                    if (N12SParameters.N12SКнопкаУскор)
                        timer.Interval = 5;
                    else
                        timer.Interval = 50;
                    timer.Start();
                }
                N12SТумблерА.BackgroundImage = ControlElementImages.tumblerType8Left;
            }
            if (e.Button == MouseButtons.Right)
            {
                if (N12SParameters.N12SТумблерСеть)
                {
                    timer.Tick += timerAlphaRight_Tick;
                    if (N12SParameters.N12SКнопкаУскор)
                        timer.Interval = 5;
                    else
                        timer.Interval = 50;
                    timer.Start();
                }
                N12SТумблерА.BackgroundImage = ControlElementImages.tumblerType8Right;
            }
                
        }

        private void N12SТумблерА_MouseUp(object sender, MouseEventArgs e)
        {
            N12SТумблерА.BackgroundImage = null;
            if (N12SParameters.N12SТумблерСеть)
            {
                timer.Stop();
                timer.Tick -= timerAlphaRight_Tick;
                timer.Tick -= timerAlphaLeft_Tick;

                //возвращаем назад потенциометр
                timer.Interval = 50;
                timer.Start();
                if (N12SParameters.N12SIndicatorAlphaИ == -270 || N12SParameters.N12SIndicatorAlphaИ == 270)
                    timer.Tick += timerAlphaReturnTo30_Tick;
                else
                    timer.Tick += timerAlphaReturn_Tick;
            }

        }

        private void N12SТумблерБ_MouseDown(object sender, MouseEventArgs e)
        {
            timer.Tick -= timerBetaReturn_Tick;
            timer.Tick -= timerBetaReturnTo30_Tick;
            if (e.Button == MouseButtons.Left)
            {
                if (N12SParameters.N12SТумблерСеть)
                {
                    timer.Tick += timerBetaLeft_Tick;
                    if (N12SParameters.N12SКнопкаУскор)
                        timer.Interval = 5;
                    else
                        timer.Interval = 50;
                    timer.Start();
                }
                N12SТумблерБ.BackgroundImage = ControlElementImages.tumblerType8Up;

            }
            if (e.Button == MouseButtons.Right)
            {
                if (N12SParameters.N12SТумблерСеть)
                {
                    timer.Tick += timerBetaRight_Tick;
                    if (N12SParameters.N12SКнопкаУскор)
                        timer.Interval = 5;
                    else
                        timer.Interval = 50;
                    timer.Start();
                }
                N12SТумблерБ.BackgroundImage = ControlElementImages.tumblerType8Down;
            }
        }

        private void N12SТумблерБ_MouseUp(object sender, MouseEventArgs e)
        {
            N12SТумблерБ.BackgroundImage = null;
            if (N12SParameters.N12SТумблерСеть)
            {
                timer.Stop();
                timer.Tick -= timerBetaRight_Tick;
                timer.Tick -= timerBetaLeft_Tick;

                //возвращаем назад потенциометр
                timer.Interval = 50;
                timer.Start();
                if (N12SParameters.N12SIndicatorBetaИ == 0 || N12SParameters.N12SIndicatorBetaИ == 90)
                    timer.Tick += timerBetaReturnTo30_Tick;
                else
                    timer.Tick += timerBetaReturn_Tick;
            }

        }

        private void N12SТумблерСеть_Click(object sender, System.EventArgs e)
        {
            if (N12SParameters.N12SТумблерСеть)
            {
                N12SТумблерСеть.BackgroundImage = ControlElementImages.tumblerType8Down;
                N12SParameters.N12SЛампочкаГотовность = false;
                
                //сбрасываем потенциометры
                timer.Stop();
                var angle = 0;
                N12SIndicatorBetaV.BackgroundImage =
                       TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow, angle);
                angle = -50;
                N12SIndicatorBetaИ.BackgroundImage =
                       TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow, angle);
                angle = 0;
                N12SIndicatorAlphaV.BackgroundImage =
                       TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow, angle);
                angle = 0;
                N12SIndicatorAlphaИ.BackgroundImage =
                       TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow, angle);

                //гасим лампочки
                N12SЛампочкаГотовность.BackgroundImage = null;
                N12SЛампочкаУпорА.BackgroundImage = null;
                N12SЛампочкаУпорБ.BackgroundImage = null;
            }
            else
            {
                N12SТумблерСеть.BackgroundImage = ControlElementImages.tumblerType8Up;
                N12SParameters.N12SЛампочкаГотовность = true;
                N12SЛампочкаГотовность.BackgroundImage = ControlElementImages.lampType10OnGreen;
                
            }
            N12SParameters.N12SТумблерСеть = !N12SParameters.N12SТумблерСеть;
            if (N12SParameters.N12SТумблерСеть) InitializeIndicatorsPosition();
        }
        #endregion

        #region Инициализация
        private void InitializeButtonsPosition()
        {
            if (!N12SParameters.N12SКнопкаУскор)
                N12SКнопкаУскор.BackgroundImage = null;
            else
                N12SКнопкаУскор.BackgroundImage =  ControlElementImages.buttonRoundType8;

            if (!N12SParameters.N12SТумблерСеть)
                N12SТумблерСеть.BackgroundImage = ControlElementImages.tumblerType8Down;
            else
                N12SТумблерСеть.BackgroundImage = ControlElementImages.tumblerType8Up;
        }

        private void InitializeIndicatorsPosition()
        {
            var angle = N12SParameters.N12SIndicatorBeta * (-36) + 36;
            N12SIndicatorBetaCenter.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorCenter, angle);

            angle = - N12SParameters.N12SIndicatorBeta + 48;
            N12SIndicatorBeta.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorBeta, angle);

            angle = N12SParameters.N12SIndicatorAlpha * (-36) + 36;
            N12SIndicatorAlphaCenter.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorCenter, angle);

            angle = - N12SParameters.N12SIndicatorAlpha - 67;
            N12SIndicatorAlpha.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorAlpha, angle);

            angle = (N12SParameters.N12SТумблерСеть) ? N12SParameters.N12SIndicatorBetaИ*1.1F - 50 : -50;
            N12SIndicatorBetaИ.BackgroundImage =
                   TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow, angle);

            angle = (N12SParameters.N12SТумблерСеть) ? N12SParameters.N12SIndicatorAlphaИ*0.18F : 0;
            N12SIndicatorAlphaИ.BackgroundImage =
                   TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow, angle);

            angle = (N12SParameters.N12SТумблерСеть) ? N12SParameters.N12SIndicatorAlphaV * 1.5F : 0;
            N12SIndicatorAlphaV.BackgroundImage =
                   TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow, angle);

            angle = (N12SParameters.N12SТумблерСеть) ? N12SParameters.N12SIndicatorBetaV * 1.5F : 0;
            N12SIndicatorBetaV.BackgroundImage =
                   TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow, angle);

            N12SЛампочкаГотовность.BackgroundImage = (N12SParameters.N12SТумблерСеть) 
                ? ControlElementImages.lampType10OnGreen : null;

            N12SЛампочкаУпорА.BackgroundImage = ((N12SParameters.N12SIndicatorAlphaИ == -270 || 
                N12SParameters.N12SIndicatorAlphaИ == 270) && N12SParameters.N12SТумблерСеть)
                ? ControlElementImages.lampType6OnRed
                : null;

            N12SЛампочкаУпорБ.BackgroundImage = ((N12SParameters.N12SIndicatorBetaИ == 0 || 
                N12SParameters.N12SIndicatorBetaИ == 90) && N12SParameters.N12SТумблерСеть)
                ? ControlElementImages.lampType6OnRed
                : null;
        }
        #endregion

    }
}