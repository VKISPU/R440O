//-----------------------------------------------------------------------
// <copyright file="N12SForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using System;
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
            this.InitializeComponent();
            InitializeButtonsPosition();
            InitializeIndicatorsPosition();         

            timer = new Timer();
            timer.Enabled = false;

        }

        private readonly Timer timer;


        #region Индикаторы
        private void timerAlphaRight_Tick(object sender, EventArgs e)
        {
            N12SParameters.N12SIndicatorAlpha += 0.5F;

            var angle = N12SParameters.N12SIndicatorAlpha * (-36) + 36;
            N12SIndicatorAlphaCenter.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorCenter, angle);

            angle = (N12SParameters.N12SIndicatorAlpha - N12SParameters.N12SIndicatorAlpha % 10) * (-1) - 67 - N12SParameters.N12SIndicatorAlpha % 10;
            N12SIndicatorAlpha.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorAlpha, angle);
        }

        private void timerAlphaLeft_Tick(object sender, EventArgs e)
        {
            N12SParameters.N12SIndicatorAlpha -= 0.5F;

            var angle = N12SParameters.N12SIndicatorAlpha * (-36) + 36;
            N12SIndicatorAlphaCenter.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorCenter, angle);

            angle = (N12SParameters.N12SIndicatorAlpha - N12SParameters.N12SIndicatorAlpha % 10) * (-1) - 67 - N12SParameters.N12SIndicatorAlpha % 10;
            N12SIndicatorAlpha.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorAlpha, angle);
        }

        private void timerBetaLeft_Tick(object sender, EventArgs e)
        {
            N12SParameters.N12SIndicatorBeta += 0.5F;


            var angle = N12SParameters.N12SIndicatorBeta * (-36)  + 36;
                N12SIndicatorBetaCenter.BackgroundImage =
                    TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorCenter, angle);

                angle = (N12SParameters.N12SIndicatorBeta - N12SParameters.N12SIndicatorBeta % 10) * (-1) + 48 - N12SParameters.N12SIndicatorBeta % 10;
                N12SIndicatorBeta.BackgroundImage =
                    TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorBeta, angle);
        }

        private void timerBetaRight_Tick(object sender, EventArgs e)
        {
            N12SParameters.N12SIndicatorBeta -= 0.5F;

            var angle = N12SParameters.N12SIndicatorBeta *(-36) + 36;
            N12SIndicatorBetaCenter.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorCenter, angle);

            angle = (N12SParameters.N12SIndicatorBeta - N12SParameters.N12SIndicatorBeta % 10) * (-1) + 48 - N12SParameters.N12SIndicatorBeta % 10;
            N12SIndicatorBeta.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorBeta, angle);
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

        #region Тумблеры
        private void N12SТумблерА_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (N12SParameters.N12SIndicatorAlpha != 0)
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
                if (N12SParameters.N12SIndicatorAlpha != 340)
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
            timer.Stop();
            timer.Tick -= timerAlphaRight_Tick;
            timer.Tick -= timerAlphaLeft_Tick;

        }

        private void N12SТумблерБ_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (N12SParameters.N12SIndicatorBeta != 90)
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
                if (N12SParameters.N12SIndicatorBeta != 0)
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
            timer.Stop();
            timer.Tick -= timerBetaRight_Tick;
            timer.Tick -= timerBetaLeft_Tick;
       }

        private void N12SТумблерСеть_Click(object sender, System.EventArgs e)
        {
            if (N12SParameters.N12SТумблерСеть)
                N12SТумблерСеть.BackgroundImage = ControlElementImages.tumblerType8Down;
            else
                N12SТумблерСеть.BackgroundImage = ControlElementImages.tumblerType8Up;
            N12SParameters.N12SТумблерСеть = !N12SParameters.N12SТумблерСеть;
        }
        #endregion

        #region Инициализация
        private void InitializeButtonsPosition()
        {
            if (!N12SParameters.N12SКнопкаУскор)
                N12SКнопкаУскор.BackgroundImage = null;
            else
                N12SКнопкаУскор.BackgroundImage = ControlElementImages.buttonRoundType8;

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

            angle = (N12SParameters.N12SIndicatorBeta - N12SParameters.N12SIndicatorBeta % 10) * (-1) + 48 - N12SParameters.N12SIndicatorBeta % 10;
            N12SIndicatorBeta.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorBeta, angle);

            angle = N12SParameters.N12SIndicatorAlpha * (-36) + 36;
            N12SIndicatorAlphaCenter.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorCenter, angle);

            angle = (N12SParameters.N12SIndicatorAlpha - N12SParameters.N12SIndicatorAlpha % 10) * (-1) - 67 - N12SParameters.N12SIndicatorAlpha % 10;
            N12SIndicatorAlpha.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorAlpha, angle);

        }
        #endregion


    }
}