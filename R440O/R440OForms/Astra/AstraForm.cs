﻿//-----------------------------------------------------------------------
// <copyright file="AstraForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.Astra
{
    using System.Windows.Forms;
    using Parameters;
    using ThirdParty;

    /// <summary>
    /// Форма блока Астра
    /// </summary>
    public partial class AstraForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AstraForm"/>.
        /// </summary>
        public AstraForm()
        {
            InitializeComponent();
            AstraParameters.ParameterChanged += RefreshFormElements;
            RefreshFormElements();
        }

        #region Инициализация
        private void RefreshFormElements()
        {
            //переключатели

            var angle = AstraParameters.ПереключательТлгТлф * 30 - 150;
            ПереключательТлгТлф.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = AstraParameters.ПереключательВнешнегоПитания * 30;
            ПереключательВнешнегоПитания.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = AstraParameters.ПереключательКонтроль * 35 - 160;
            ПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = AstraParameters.ПереключательДиапазоны * 30 - 148;
            ПереключательДиапазоны.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = AstraParameters.ПереключательВыходаРеле * 30 - 60;
            ПереключательВыходаРеле.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            ТумблерШпУп.BackgroundImage = AstraParameters.ТумблерШпУп
                ? ControlElementImages.tumblerType5Left
                : ControlElementImages.tumblerType5Right;

            //регуляторы

            РегуляторЧастота.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.revolverRoundBlack, AstraParameters.РегуляторЧастота);
            РегуляторУсиление.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.revolverRoundBlack, AstraParameters.РегуляторУсиление);
            РегуляторУсилениеПЧ.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.revolverRoundBlack, AstraParameters.РегуляторУсилениеПЧ);

            // кнопки
            Кнопка150_270.Visible = !AstraParameters.Кнопка150_270;
            Кнопка270_480.Visible = !AstraParameters.Кнопка270_480;
            Кнопка480_860.Visible = !AstraParameters.Кнопка480_860;
            Кнопка860_1500.Visible = !AstraParameters.Кнопка860_1500;
        }

        #endregion

        #region Кнопки

        private void AstraКнопка150_270_Click(object sender, System.EventArgs e)
        {
            switchToButton(1);
        }

        private void AstraКнопка270_480_Click(object sender, System.EventArgs e)
        {
            switchToButton(2);
        }

        private void AstraКнопка480_860_Click(object sender, System.EventArgs e)
        {
            switchToButton(3);
        }

        private void AstraКнопка860_1500_Click(object sender, System.EventArgs e)
        {
            switchToButton(4);
        }

        /// <summary>
        /// Переключает на нажатую пользователем кнопку, определяющую некоторый заданный диапазон.
        /// </summary>
        /// <param name="numberOfButton">Номер нажатой кнопки по порядку слева направо.</param>
        private void switchToButton(int numberOfButton)
        {
            AstraParameters.Кнопка150_270 = numberOfButton == 1;
            AstraParameters.Кнопка270_480 = numberOfButton == 2;
            AstraParameters.Кнопка480_860 = numberOfButton == 3;
            AstraParameters.Кнопка860_1500 = numberOfButton == 4;
            Кнопка150_270.Visible = !AstraParameters.Кнопка150_270;
            Кнопка270_480.Visible = !AstraParameters.Кнопка270_480;
            Кнопка480_860.Visible = !AstraParameters.Кнопка480_860;
            Кнопка860_1500.Visible = !AstraParameters.Кнопка860_1500;
        }

        #endregion

        #region Переключатели

        private void AstraПереключательТлгТлф_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AstraParameters.ПереключательТлгТлф += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                AstraParameters.ПереключательТлгТлф -= 1;
            }
        }

        private void AstraПереключательВнешнегоПитания_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AstraParameters.ПереключательВнешнегоПитания += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                AstraParameters.ПереключательВнешнегоПитания -= 1;
            }
        }

        private void AstraПереключательКонтроль_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AstraParameters.ПереключательКонтроль += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                AstraParameters.ПереключательКонтроль -= 1;
            }
        }

        private void AstraПереключательДиапазоны_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AstraParameters.ПереключательДиапазоны += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                AstraParameters.ПереключательДиапазоны -= 1;
            }
        }

        private void AstraПереключательВыходаРеле_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AstraParameters.ПереключательВыходаРеле += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                AstraParameters.ПереключательВыходаРеле -= 1;
            }

        }
        #endregion

        #region Переключатель комплекта и тумблер
        private void AstraТумблерШпУп_Click(object sender, System.EventArgs e)
        {
            AstraParameters.ТумблерШпУп = !AstraParameters.ТумблерШпУп;
        }

        private void AstraКнопкаЧастота_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаЧастота.BackgroundImage = ControlElementImages.buttonRoundType2;
        }

        private void AstraКнопкаЧастота_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаЧастота.BackgroundImage = null;
        }
        #endregion

        #region Регуляторы

        private bool isManipulation;
        private void AstraРегулятор_MouseDown(object sender, MouseEventArgs e)
        {
            isManipulation = true;
        }

        private void AstraРегулятор_MouseUp(object sender, MouseEventArgs e)
        {
            isManipulation = false;
        }

        private void AstraРегуляторЧастота_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isManipulation) return;
            var button = sender as Button;
            var angle = TransformImageHelper.CalculateAngle(button.Width, button.Height, e);
            AstraParameters.РегуляторЧастота = angle;
            РегуляторЧастота.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.revolverRoundBlack, AstraParameters.РегуляторЧастота);
        }

        private void AstraРегуляторУсиление_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isManipulation) return;
            var button = sender as Button;
            var angle = TransformImageHelper.CalculateAngle(button.Width, button.Height, e);
            AstraParameters.РегуляторУсиление = angle;
            РегуляторУсиление.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.revolverRoundBlack, AstraParameters.РегуляторУсиление);
        }

        private void AstraРегуляторУсилениеПЧ_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isManipulation) return;
            var button = sender as Button;
            var angle = TransformImageHelper.CalculateAngle(button.Width, button.Height, e);
            AstraParameters.РегуляторУсилениеПЧ = angle;
            РегуляторУсилениеПЧ.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.revolverRoundBlack, AstraParameters.РегуляторУсилениеПЧ);
        }
        #endregion

        private void AstraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AstraParameters.ParameterChanged -= RefreshFormElements;
        }
    }
}