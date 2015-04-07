//-----------------------------------------------------------------------
// <copyright file="BMBForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using R440O.Parameters;
using R440O.ThirdParty;

namespace R440O.R440OForms.BMB
{
    using System.Windows.Forms;

    /// <summary>
    /// Форма блока БМБ
    /// </summary>
    public partial class BMBForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="BMBForm"/>
        /// </summary>
        public BMBForm()
        {
            InitializeComponent();
            InitializeButtonsPosition();
            InitializeTogglesPosition();
            InitializeLamps();
            BMBParameters.RefreshForm += InitializeLamps;
        }

        #region Переключатели

        private void BMBПереключательПодключениеРезерва_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMBParameters.BMBПереключательПодключениеРезерва += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMBParameters.BMBПереключательПодключениеРезерва -= 1;
            }

            var angle = BMBParameters.BMBПереключательПодключениеРезерва * 40 - 80;
            BMBПереключательПодключениеРезерва.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMBПереключательНаправление_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMBParameters.BMBПереключательНаправление += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMBParameters.BMBПереключательНаправление -= 1;
            }

            var angle = BMBParameters.BMBПереключательНаправление * 30 - 75;
            BMBПереключательНаправление.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        #endregion

        private void InitializeButtonsPosition()
        {
            if (BMBParameters.КнопкаПередачаВызоваДк)
            {
                this.КнопкаПередачаВызоваДк.BackgroundImage = null;
                this.КнопкаПередачаВызоваДк.Text = string.Empty;
            }
            else
            {
                this.КнопкаПередачаВызоваДк.BackgroundImage = ControlElementImages.buttonSquareYellow1;
                this.КнопкаПередачаВызоваДк.Text = "ДК";
            }

            if (BMBParameters.КнопкаПередачаВызоваТч)
            {
                this.КнопкаПередачаВызоваТч.BackgroundImage = null;
                this.КнопкаПередачаВызоваТч.Text = string.Empty;
            }
            else
            {
                this.КнопкаПередачаВызоваТч.BackgroundImage = ControlElementImages.buttonSquareYellow1;
                this.КнопкаПередачаВызоваТч.Text = "ТЧ";
            }

            if (BMBParameters.КнопкаСлСвязь)
            {
                this.КнопкаСлСвязь.BackgroundImage = null;
                this.КнопкаСлСвязь.Text = string.Empty;
            }
            else
            {
                this.КнопкаСлСвязь.BackgroundImage = ControlElementImages.buttonSquareYellow1;
                this.КнопкаСлСвязь.Text = "ВКЛ";
            }


            if (BMBParameters.КнопкаПитание)
            {
                this.КнопкаПитание.BackgroundImage = null;
                this.КнопкаПитание.Text = string.Empty;
            }
            else
            {
                this.КнопкаПитание.BackgroundImage = ControlElementImages.buttonSquareGreen;
                this.КнопкаПитание.Text = "ВКЛ";
            }

            if (BMBParameters.КнопкаЗвСигнал)
            {
                this.КнопкаЗвСигнал.BackgroundImage = null;
                this.КнопкаЗвСигнал.Text = string.Empty;
            }
            else
            {
                this.КнопкаЗвСигнал.BackgroundImage = ControlElementImages.buttonSquareGreen;
                this.КнопкаЗвСигнал.Text = " ЗВ СИГН";
            }
        }

        private void InitializeTogglesPosition()
        {
            var angle = BMBParameters.ПереключательРаботаКонтроль * 30 - 45;
            ПереключательРаботаКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = BMBParameters.BMBПереключательПодключениеРезерва * 40 - 80;
            BMBПереключательПодключениеРезерва.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = BMBParameters.BMBПереключательНаправление * 30 - 75;
            BMBПереключательНаправление.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void InitializeLamps()
        {
            ЛампочкаТч.BackgroundImage = BMBParameters.ЛампочкаТч
                ? ControlElementImages.lampType7OnRed
                : null;
            ЛампочкаДк.BackgroundImage = BMBParameters.ЛампочкаДк
                ? ControlElementImages.lampType7OnRed
                : null;
        }

        private void КнопкаПитание_Click(object sender, System.EventArgs e)
        {
            BMBParameters.КнопкаПитание = !BMBParameters.КнопкаПитание;
            switch (BMBParameters.КнопкаПитание)
            {
                case true:
                    КнопкаПитание.BackgroundImage = null;
                    КнопкаПитание.Text = "";
                    break;
                case false:
                    КнопкаПитание.BackgroundImage = ControlElementImages.buttonSquareGreen;
                    КнопкаПитание.Text = "ВКЛ";
                    break;
            }
        }

        private void КнопкаЗвСигнал_Click(object sender, System.EventArgs e)
        {
            BMBParameters.КнопкаЗвСигнал = !BMBParameters.КнопкаЗвСигнал;
            switch (BMBParameters.КнопкаЗвСигнал)
            {
                case true:
                    КнопкаЗвСигнал.BackgroundImage = null;
                    КнопкаЗвСигнал.Text = "";
                    break;
                case false:
                    КнопкаЗвСигнал.BackgroundImage = ControlElementImages.buttonSquareGreen;
                    КнопкаЗвСигнал.Text = "ЗВ\nСИГН";
                    break;
            }
        }

        private void КнопкаСлСвязь_Click(object sender, System.EventArgs e)
        {
            BMBParameters.КнопкаСлСвязь = !BMBParameters.КнопкаСлСвязь;
            switch (BMBParameters.КнопкаСлСвязь)
            {
                case true:
                    КнопкаСлСвязь.BackgroundImage = null;
                    КнопкаСлСвязь.Text = "";
                    break;
                case false:
                    КнопкаСлСвязь.BackgroundImage = ControlElementImages.buttonSquareYellow1;
                    КнопкаСлСвязь.Text = "ВКЛ";
                    break;
            }
        }

        private void КнопкаПередачаВызоваТч_Click(object sender, System.EventArgs e)
        {
            BMBParameters.КнопкаПередачаВызоваТч = !BMBParameters.КнопкаПередачаВызоваТч;
            switch (BMBParameters.КнопкаПередачаВызоваТч)
            {
                case true:
                    КнопкаПередачаВызоваТч.BackgroundImage = null;
                    КнопкаПередачаВызоваТч.Text = "";
                    break;
                case false:
                    КнопкаПередачаВызоваТч.BackgroundImage = ControlElementImages.buttonSquareYellow1;
                    КнопкаПередачаВызоваТч.Text = "ТЧ";
                    break;
            }
        }

        private void КнопкаПередачаВызоваДк_Click(object sender, System.EventArgs e)
        {
            BMBParameters.КнопкаПередачаВызоваДк = !BMBParameters.КнопкаПередачаВызоваДк;
            switch (BMBParameters.КнопкаПередачаВызоваДк)
            {
                case true:
                    КнопкаПередачаВызоваДк.BackgroundImage = null;
                    КнопкаПередачаВызоваДк.Text = "";
                    break;
                case false:
                    КнопкаПередачаВызоваДк.BackgroundImage = ControlElementImages.buttonSquareYellow1;
                    КнопкаПередачаВызоваДк.Text = "ДК";
                    break;
            }
        }

        private void ПереключательРаботаКонтроль_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMBParameters.ПереключательРаботаКонтроль += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMBParameters.ПереключательРаботаКонтроль -= 1;
            }

            var angle = BMBParameters.ПереключательРаботаКонтроль * 30 - 45;
            ПереключательРаботаКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        #region КнопкаНаборКоманды1
        private void КнопкаНаборКоманды1_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаНаборКоманды1.BackgroundImage = null;
            КнопкаНаборКоманды1.Text = "";
        }

        private void КнопкаНаборКоманды1_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаНаборКоманды1.BackgroundImage = ControlElementImages.buttonSquareBlue;
            КнопкаНаборКоманды1.Text = "1";
        }
        #endregion

        #region КнопкаНаборКоманды2
        private void КнопкаНаборКоманды2_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаНаборКоманды2.BackgroundImage = null;
            КнопкаНаборКоманды2.Text = "";
        }

        private void КнопкаНаборКоманды2_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаНаборКоманды2.BackgroundImage = ControlElementImages.buttonSquareBlue;
            КнопкаНаборКоманды2.Text = "2";
        }
        #endregion

        #region КнопкаНаборКоманды3
        private void КнопкаНаборКоманды3_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаНаборКоманды3.BackgroundImage = null;
            КнопкаНаборКоманды3.Text = "";
        }

        private void КнопкаНаборКоманды3_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаНаборКоманды3.BackgroundImage = ControlElementImages.buttonSquareBlue;
            КнопкаНаборКоманды3.Text = "3";
        }
        #endregion

        #region КнопкаНаборКоманды4
        private void КнопкаНаборКоманды4_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаНаборКоманды4.BackgroundImage = null;
            КнопкаНаборКоманды4.Text = "";
        }

        private void КнопкаНаборКоманды4_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаНаборКоманды4.BackgroundImage = ControlElementImages.buttonSquareBlue;
            КнопкаНаборКоманды4.Text = "4";
        }
        #endregion

        #region КнопкаНаборКоманды5
        private void КнопкаНаборКоманды5_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаНаборКоманды5.BackgroundImage = null;
            КнопкаНаборКоманды5.Text = "";
        }

        private void КнопкаНаборКоманды5_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаНаборКоманды5.BackgroundImage = ControlElementImages.buttonSquareBlue;
            КнопкаНаборКоманды5.Text = "5";
        }
        #endregion

        #region КнопкаНаборКоманды6
        private void КнопкаНаборКоманды6_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаНаборКоманды6.BackgroundImage = null;
            КнопкаНаборКоманды6.Text = "";
        }

        private void КнопкаНаборКоманды6_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаНаборКоманды6.BackgroundImage = ControlElementImages.buttonSquareBlue;
            КнопкаНаборКоманды6.Text = "6";
        }
        #endregion

        #region КнопкаНаборКоманды7
        private void КнопкаНаборКоманды7_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаНаборКоманды7.BackgroundImage = null;
            КнопкаНаборКоманды7.Text = "";
        }

        private void КнопкаНаборКоманды7_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаНаборКоманды7.BackgroundImage = ControlElementImages.buttonSquareBlue;
            КнопкаНаборКоманды7.Text = "7";
        }
        #endregion

        #region КнопкаНаборКоманды8
        private void КнопкаНаборКоманды8_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаНаборКоманды8.BackgroundImage = null;
            КнопкаНаборКоманды8.Text = "";
        }

        private void КнопкаНаборКоманды8_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаНаборКоманды8.BackgroundImage = ControlElementImages.buttonSquareBlue;
            КнопкаНаборКоманды8.Text = "8";
        }
        #endregion

        #region КнопкаНаборКоманды9
        private void КнопкаНаборКоманды9_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаНаборКоманды9.BackgroundImage = null;
            КнопкаНаборКоманды9.Text = "";
        }

        private void КнопкаНаборКоманды9_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаНаборКоманды9.BackgroundImage = ControlElementImages.buttonSquareBlue;
            КнопкаНаборКоманды9.Text = "9";
        }
        #endregion

        #region КнопкаНаборКоманды0
        private void КнопкаНаборКоманды0_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаНаборКоманды0.BackgroundImage = null;
            КнопкаНаборКоманды0.Text = "";
        }

        private void КнопкаНаборКоманды0_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаНаборКоманды0.BackgroundImage = ControlElementImages.buttonSquareBlue;
            КнопкаНаборКоманды0.Text = "0";
        }
        #endregion

    }
}