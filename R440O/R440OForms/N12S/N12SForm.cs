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
            N12SParameters.N12SIndicatorBetaCenter = 0;
            N12SParameters.N12SIndicatorBeta = 0;
            N12SParameters.N12SIndicatorAlphaCenter = 0;
            N12SParameters.N12SIndicatorAlpha = 0;

            timer = new Timer();
            timer.Enabled = false;

        }

        private readonly Timer timer;


        #region Индикаторы
        private void timerAlphaCenterLeft_Tick(object sender, EventArgs e)
        {
            N12SParameters.N12SIndicatorAlphaCenter += 0.5F;

            if (N12SParameters.N12SIndicatorAlphaCenter == 10)
            {
                N12SParameters.N12SIndicatorAlphaCenter = 0F;
                N12SParameters.N12SIndicatorAlpha += 10;
                if (N12SParameters.N12SIndicatorAlpha > 360) N12SParameters.N12SIndicatorAlpha = 10;
            }


            var angle = N12SParameters.N12SIndicatorAlphaCenter * (-36) + 36;
            N12SIndicatorAlphaCenter.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorCenter, angle);

            angle = N12SParameters.N12SIndicatorAlpha * (-1) - 67;
            N12SIndicatorAlpha.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorAlpha, angle);
        }

        private void timerAlphaCenterRight_Tick(object sender, EventArgs e)
        {
            N12SParameters.N12SIndicatorAlphaCenter -= 0.5F;

            if (N12SParameters.N12SIndicatorAlphaCenter == -0.5)
            {
                N12SParameters.N12SIndicatorAlphaCenter = 9.5F;
                N12SParameters.N12SIndicatorAlpha -= 10;

                if (N12SParameters.N12SIndicatorAlpha < 0) N12SParameters.N12SIndicatorAlpha = 350;
            }


            var angle = N12SParameters.N12SIndicatorAlphaCenter * (-36) + 36;
            N12SIndicatorAlphaCenter.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorCenter, angle);

            angle = N12SParameters.N12SIndicatorAlpha * (-1) - 67;
            N12SIndicatorAlpha.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorAlpha, angle);
        }

        private void timerBetaCenterLeft_Tick(object sender, EventArgs e)
        {
            N12SParameters.N12SIndicatorBetaCenter += 0.5F;

            if (N12SParameters.N12SIndicatorBetaCenter == 10)
            {
                N12SParameters.N12SIndicatorBetaCenter = 0F;
                N12SParameters.N12SIndicatorBeta+=10;
            }


            var angle = N12SParameters.N12SIndicatorBetaCenter * (-36)  + 36;
                N12SIndicatorBetaCenter.BackgroundImage =
                    TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorCenter, angle);

                angle = N12SParameters.N12SIndicatorBeta*(-1)+48;
                N12SIndicatorBeta.BackgroundImage =
                    TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorBeta, angle);
        }

        private void timerBetaCenterRight_Tick(object sender, EventArgs e)
        {
            N12SParameters.N12SIndicatorBetaCenter -= 0.5F;

            if (N12SParameters.N12SIndicatorBetaCenter == -0.5)
            {
                N12SParameters.N12SIndicatorBetaCenter = 9.5F;
                N12SParameters.N12SIndicatorBeta-=10;
            }


            var angle = N12SParameters.N12SIndicatorBetaCenter *(-36) + 36;
            N12SIndicatorBetaCenter.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorCenter, angle);

            angle = N12SParameters.N12SIndicatorBeta * (-1)+48;
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
                timer.Tick += timerAlphaCenterLeft_Tick;
                if (N12SParameters.N12SКнопкаУскор)
                    timer.Interval = 5;
                else
                    timer.Interval = 50;
                timer.Start();

                N12SТумблерА.BackgroundImage = ControlElementImages.tumblerType8Right;

            }
            if (e.Button == MouseButtons.Right)
            {
                timer.Tick += timerAlphaCenterRight_Tick;
                if (N12SParameters.N12SКнопкаУскор)
                    timer.Interval = 5;
                else
                    timer.Interval = 50;
                timer.Start();

                N12SТумблерА.BackgroundImage = ControlElementImages.tumblerType8Left;
            }
        }

        private void N12SТумблерА_MouseUp(object sender, MouseEventArgs e)
        {
            N12SТумблерА.BackgroundImage = null;
            timer.Stop();
            timer.Tick -= timerAlphaCenterRight_Tick;
            timer.Tick -= timerAlphaCenterLeft_Tick;

        }

        private void N12SТумблерБ_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                timer.Tick += timerBetaCenterLeft_Tick;
                if (N12SParameters.N12SКнопкаУскор)
                    timer.Interval = 5;
                else
                    timer.Interval = 50;
                timer.Start();

                N12SТумблерБ.BackgroundImage = ControlElementImages.tumblerType8Up;

            }
            if (e.Button == MouseButtons.Right)
            {
                timer.Tick += timerBetaCenterRight_Tick;
                if (N12SParameters.N12SКнопкаУскор)
                    timer.Interval = 5;
                else
                    timer.Interval = 50;
                timer.Start();

                N12SТумблерБ.BackgroundImage = ControlElementImages.tumblerType8Down;
            }
        }

        private void N12SТумблерБ_MouseUp(object sender, MouseEventArgs e)
        {
            N12SТумблерБ.BackgroundImage = null;
            timer.Stop();
            timer.Tick -= timerBetaCenterRight_Tick;
            timer.Tick -= timerBetaCenterLeft_Tick;
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
            var angle = N12SParameters.N12SIndicatorBetaCenter * (-36) + 36;
            N12SIndicatorBetaCenter.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorCenter, angle);

            angle = N12SParameters.N12SIndicatorBeta * (-1) + 48;
            N12SIndicatorBeta.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorBeta, angle);

            angle = N12SParameters.N12SIndicatorAlphaCenter * (-36) + 36;
            N12SIndicatorAlphaCenter.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorCenter, angle);

            angle = N12SParameters.N12SIndicatorAlpha * (-1) - 67;
            N12SIndicatorAlpha.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.N12SIndicatorAlpha, angle);

        }
        #endregion


    }
}