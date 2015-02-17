//-----------------------------------------------------------------------
// <copyright file="AstraForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using System;

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
            this.InitializeComponent();
            this.InitializeTogglesPosition();
            this.InitializeRevolvers();
        }

        private void InitializeRevolvers()
        {
            AstraРегуляторЧастота.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.revolverRound, AstraParameters.AstraРегуляторЧастота);
            AstraРегуляторУсиление.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.revolverRound, AstraParameters.AstraРегуляторУсиление);
            AstraРегуляторУсилениеПЧ.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.revolverRound, AstraParameters.AstraРегуляторУсилениеПЧ);
        }

        #region Кнопки

        private void AstraКнопка150_270_Click(object sender, System.EventArgs e)
        {
            this.switchToButton(1);
        }

        private void AstraКнопка270_480_Click(object sender, System.EventArgs e)
        {
            this.switchToButton(2);
        }

        private void AstraКнопка480_860_Click(object sender, System.EventArgs e)
        {
            this.switchToButton(3);
        }

        private void AstraКнопка860_1500_Click(object sender, System.EventArgs e)
        {
            this.switchToButton(4);
        }

        /// <summary>
        /// Переключает на нажатую пользователем кнопку, определяющую некоторый заданный диапазон.
        /// </summary>
        /// <param name="numberOfButton">Номер нажатой кнопки по порядку слева направо.</param>
        private void switchToButton(int numberOfButton)
        {
            this.AstraКнопка150_270.Visible = AstraParameters.AstraКнопка150_270 = numberOfButton != 1;
            this.AstraКнопка270_480.Visible = AstraParameters.AstraКнопка270_480 = numberOfButton != 2;
            this.AstraКнопка480_860.Visible = AstraParameters.AstraКнопка480_860 = numberOfButton != 3;
            this.AstraКнопка860_1500.Visible = AstraParameters.AstraКнопка860_1500 = numberOfButton != 4;
        }

        #endregion

        #region Переключатели

        private void AstraПереключательТлгТлф_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AstraParameters.AstraПереключательТлгТлф += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                AstraParameters.AstraПереключательТлгТлф -= 1;
            }

            var angle = AstraParameters.AstraПереключательТлгТлф*30 - 150;

            AstraПереключательТлгТлф.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void AstraПереключательВнешнегоПитания_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AstraParameters.AstraПереключательВнешнегоПитания += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                AstraParameters.AstraПереключательВнешнегоПитания -= 1;
            }

            var angle = AstraParameters.AstraПереключательВнешнегоПитания*30;

            AstraПереключательВнешнегоПитания.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void AstraПереключательКонтроль_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AstraParameters.AstraПереключательКонтроль += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                AstraParameters.AstraПереключательКонтроль -= 1;
            }

            var angle = AstraParameters.AstraПереключательКонтроль*35 - 160;

            AstraПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void AstraПереключательДиапазоны_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AstraParameters.AstraПереключательДиапазоны += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                AstraParameters.AstraПереключательДиапазоны -= 1;
            }

            var angle = AstraParameters.AstraПереключательДиапазоны*30 - 148;

            AstraПереключательДиапазоны.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void AstraПереключательВыходаРеле_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AstraParameters.AstraПереключательВыходаРеле += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                AstraParameters.AstraПереключательВыходаРеле -= 1;
            }

            var angle = AstraParameters.AstraПереключательВыходаРеле*30 - 60;

            AstraПереключательВыходаРеле.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

        }

        private void AstraТумблерШпУп_Click(object sender, System.EventArgs e)
        {
            AstraParameters.AstraТумблерШпУп = !AstraParameters.AstraТумблерШпУп;
            AstraТумблерШпУп.BackgroundImage = AstraParameters.AstraТумблерШпУп ? ControlElementImages.tumblerType2Left : ControlElementImages.tumblerType2Right;
        }

        #endregion

        #region Инициализация

        private void InitializeTogglesPosition()
        {
            var angle = AstraParameters.AstraПереключательТлгТлф*30 - 150;
            AstraПереключательТлгТлф.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = AstraParameters.AstraПереключательВнешнегоПитания*30;
            AstraПереключательВнешнегоПитания.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = AstraParameters.AstraПереключательКонтроль*35 - 160;
            AstraПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = AstraParameters.AstraПереключательДиапазоны*30 - 148;
            AstraПереключательДиапазоны.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = AstraParameters.AstraПереключательВыходаРеле*30 - 60;
            AstraПереключательВыходаРеле.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            AstraТумблерШпУп.BackgroundImage = AstraParameters.AstraТумблерШпУп ? ControlElementImages.tumblerType2Left : ControlElementImages.tumblerType2Right;
        }

        #endregion

        #region Переключатель комплекта
        private void A403_3Тублер1К2К_MouseDown(object sender, MouseEventArgs e)
        {
            AstraParameters.AstraКнопкаЧастота = true;
            A403_3Тублер1К2К.BackgroundImage = AstraParameters.AstraКнопкаЧастота
                ? ControlElementImages.buttonRoundType2
                : null;
        }

        private void A403_3Тублер1К2К_MouseUp(object sender, MouseEventArgs e)
        {
            AstraParameters.AstraКнопкаЧастота = false;
            A403_3Тублер1К2К.BackgroundImage = AstraParameters.AstraКнопкаЧастота
                ? ControlElementImages.buttonRoundType2
                : null;
        } 
        #endregion

        #region Вращатели

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
            AstraParameters.AstraРегуляторЧастота = angle;
            AstraРегуляторЧастота.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.revolverRound, AstraParameters.AstraРегуляторЧастота);
        }

        private void AstraРегуляторУсиление_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isManipulation) return;
            var button = sender as Button;
            var angle = TransformImageHelper.CalculateAngle(button.Width, button.Height, e);
            AstraParameters.AstraРегуляторУсиление = angle;
            AstraРегуляторУсиление.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.revolverRound, AstraParameters.AstraРегуляторУсиление);
        }

        private void AstraРегуляторУсилениеПЧ_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isManipulation) return;
            var button = sender as Button;
            var angle = TransformImageHelper.CalculateAngle(button.Width, button.Height, e);
            AstraParameters.AstraРегуляторУсилениеПЧ = angle;
            AstraРегуляторУсилениеПЧ.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.revolverRound, AstraParameters.AstraРегуляторУсилениеПЧ);
        }
        #endregion
    }
}