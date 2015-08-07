//-----------------------------------------------------------------------
// <copyright file="BMBForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.BMB
{
    using System.Windows.Forms;
    using BaseClasses;
    using ThirdParty;
    using СостоянияЭлементов.БМБ;

    /// <summary>
    /// Форма блока БМБ
    /// </summary>
    public partial class BMBForm : Form, IRefreshableForm
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="BMBForm"/>
        /// </summary>
        public BMBForm()
        {
            InitializeComponent();
            BMBParameters.RefreshForm += RefreshElements;
            RefreshElements();
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
        }

        #endregion

        public void RefreshElements()
        {
            InitializeButtons();
            InitializeToggles();
            InitializeLamps();
        }

        private void InitializeButtons()
        {
            this.КнопкаПередачаВызоваДк.BackgroundImage = BMBParameters.КнопкаПередачаВызоваДк == Кнопка.Горит
                ? null
                : BMBParameters.КнопкаПередачаВызоваДк == Кнопка.Отжата
                    ? ControlElementImages.buttonSquareYellow1
                    : TransformImageHelper.Scale(ControlElementImages.buttonSquareYellow1, 0.65F);

            this.КнопкаПередачаВызоваТч.BackgroundImage = BMBParameters.КнопкаПередачаВызоваТч == Кнопка.Горит
                ? null
                : BMBParameters.КнопкаПередачаВызоваТч == Кнопка.Отжата
                    ? ControlElementImages.buttonSquareYellow1
                    : TransformImageHelper.Scale(ControlElementImages.buttonSquareYellow1, 0.65F);

            this.КнопкаСлСвязь.BackgroundImage = BMBParameters.КнопкаСлСвязь == Кнопка.Горит
                 ? null
                 : BMBParameters.КнопкаСлСвязь == Кнопка.Отжата
                     ? ControlElementImages.buttonSquareYellow1
                     : TransformImageHelper.Scale(ControlElementImages.buttonSquareYellow1, 0.65F);

            this.КнопкаПитание.BackgroundImage = BMBParameters.КнопкаПитание == Кнопка.Горит
                 ? null
                 : BMBParameters.КнопкаПитание == Кнопка.Отжата
                     ? ControlElementImages.buttonSquareGreen
                     : TransformImageHelper.Scale(ControlElementImages.buttonSquareGreen, 0.65F);

            this.КнопкаЗвСигнал.BackgroundImage = BMBParameters.КнопкаЗвСигнал == Кнопка.Горит
                 ? null
                 : BMBParameters.КнопкаЗвСигнал == Кнопка.Отжата
                     ? ControlElementImages.buttonSquareGreen
                     : TransformImageHelper.Scale(ControlElementImages.buttonSquareGreen, 0.65F);

            this.КнопкаПередачаВызоваДк.Text = BMBParameters.КнопкаПередачаВызоваДк == Кнопка.Горит ? null : "ДК";
            this.КнопкаПередачаВызоваТч.Text = BMBParameters.КнопкаПередачаВызоваТч == Кнопка.Горит ? null : "ТЧ";
            this.КнопкаСлСвязь.Text = BMBParameters.КнопкаСлСвязь == Кнопка.Горит ? null : "ВКЛ";
            this.КнопкаПитание.Text = BMBParameters.КнопкаПитание == Кнопка.Горит ? null : "ВКЛ";
            this.КнопкаЗвСигнал.Text = BMBParameters.КнопкаЗвСигнал == Кнопка.Горит ? null : "ЗВ.\nСИГН.";
        }

        private void InitializeToggles()
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

        #region Кнопки

        private void КнопкаПитание_Click(object sender, System.EventArgs e)
        {
            BMBParameters.КнопкаПитание = BMBParameters.КнопкаПитание == Кнопка.Отжата ? Кнопка.Нажата : Кнопка.Отжата;
        }

        private void КнопкаЗвСигнал_Click(object sender, System.EventArgs e)
        {
            BMBParameters.КнопкаЗвСигнал = BMBParameters.КнопкаЗвСигнал == Кнопка.Отжата ? Кнопка.Нажата : Кнопка.Отжата;
        }

        private void КнопкаСлСвязь_Click(object sender, System.EventArgs e)
        {
            BMBParameters.КнопкаСлСвязь = BMBParameters.КнопкаСлСвязь == Кнопка.Отжата ? Кнопка.Нажата : Кнопка.Отжата;
        }

        private void КнопкаПередачаВызоваТч_Click(object sender, System.EventArgs e)
        {
            BMBParameters.КнопкаПередачаВызоваТч = BMBParameters.КнопкаПередачаВызоваТч == Кнопка.Отжата ? Кнопка.Нажата : Кнопка.Отжата;
        }

        private void КнопкаПередачаВызоваДк_Click(object sender, System.EventArgs e)
        {
            BMBParameters.КнопкаПередачаВызоваДк = BMBParameters.КнопкаПередачаВызоваДк == Кнопка.Отжата ? Кнопка.Нажата : Кнопка.Отжата;
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
        }
        #endregion

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