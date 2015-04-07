//-----------------------------------------------------------------------
// <copyright file="A205M_2Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using R440O.R440OForms.A205M_1;

namespace R440O.R440OForms.A205M_2
{
    using System.Windows.Forms;
    using ThirdParty;

    /// <summary>
    /// Форма блока А205М-1
    /// </summary>
    public partial class A205M_2Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="A205M_2Form"/>.
        /// </summary>
        public A205M_2Form()
        {
            this.InitializeComponent();
            A205M_2Parameters.RefreshForm += RefreshForm;
            RefreshForm();
        }

        #region Инициализация элементов управления формы
        private void RefreshForm()
        {
            ИндикаторКонтроль.Invalidate();

            ТумблерКЭД.BackgroundImage = A205M_1Parameters.ТумблерКЭД
                ? ControlElementImages.tumblerType6Up
                : ControlElementImages.tumblerType6Down;

            var angle = A205M_2Parameters.ПереключательВолнаX10000 * 35 - 90;
            ПереключательВолнаX10000.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_2Parameters.ПереключательВолнаX1000 * 35 - 160;
            ПереключательВолнаX1000.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_2Parameters.ПереключательВолнаX100 * 35 - 160;
            ПереключательВолнаX100.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_2Parameters.ПереключательВолнаX10 * 35 - 160;
            ПереключательВолнаX10.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_2Parameters.ПереключательВолнаX1 * 35 - 160;
            ПереключательВолнаX1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_2Parameters.ПереключательКонтроль * 30 - 180;
            ПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_2Parameters.ПереключательВидРаботы * 30 - 75;
            ПереключательВидРаботы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_2Parameters.ПереключательВходЧТ * 30 - 60;
            ПереключательВходЧТ.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            ЛампочкаНормРаб.BackgroundImage = A205M_2Parameters.ЛампочкаНормРаб
                ? ControlElementImages.lampType13OnGreen
                : null;
        }

        private void ИндикаторКонтроль_Paint(object sender, PaintEventArgs e)
        {
            switch (A205M_2Parameters.ИндикаторКонтроль)
            {
                case 0:
                    TransformImageHelper.DrawLine(e.Graphics, 10, 40, 60, 80);
                    break;
                case 27:
                    TransformImageHelper.DrawLine(e.Graphics, 65, 20, 60, 80);
                    break;
            }
        } 
        #endregion

        private void ПереключательКЭД_Click(object sender, System.EventArgs e)
        {
            A205M_1Parameters.ТумблерКЭД = !A205M_1Parameters.ТумблерКЭД;
        }

        #region Отображение на дисплее текущей выбранной волны

        private void КнопкаОтсчет_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаОтсчет.BackgroundImage = null;
            Дисплей.Text = A205M_2Parameters.ПереключательВолнаX10000 + "  " +
                           A205M_2Parameters.ПереключательВолнаX1000 + "  " +
                           A205M_2Parameters.ПереключательВолнаX100 + "  " +
                           A205M_2Parameters.ПереключательВолнаX10 + "  " +
                           A205M_2Parameters.ПереключательВолнаX1;

        }

        private void КнопкаОтсчет_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаОтсчет.BackgroundImage = ControlElementImages.buttonRoundType6;
            Дисплей.Text = string.Empty;
        }

        #endregion

        #region Установка переключателей волны

        private void ПереключательВолнаX10000_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) A205M_2Parameters.ПереключательВолнаX10000 += 1;
            if (e.Button == MouseButtons.Right) A205M_2Parameters.ПереключательВолнаX10000 -= 1;
        }

        private void ПереключательВолнаX1000_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) A205M_2Parameters.ПереключательВолнаX1000 += 1;
            if (e.Button == MouseButtons.Right) A205M_2Parameters.ПереключательВолнаX1000 -= 1;
        }

        private void ПереключательВолнаX100_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) A205M_2Parameters.ПереключательВолнаX100 += 1;
            if (e.Button == MouseButtons.Right) A205M_2Parameters.ПереключательВолнаX100 -= 1;
        }

        private void ПереключательВолнаX10_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) A205M_2Parameters.ПереключательВолнаX10 += 1;
            if (e.Button == MouseButtons.Right) A205M_2Parameters.ПереключательВолнаX10 -= 1;
        }

        private void ПереключательВолнаX1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) A205M_2Parameters.ПереключательВолнаX1 += 1;
            if (e.Button == MouseButtons.Right) A205M_2Parameters.ПереключательВолнаX1 -= 1;
        }

        #endregion

        #region Переключатели контроля, вида работы, входы чт

        private void ПереключательКонтроль_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) A205M_2Parameters.ПереключательКонтроль += 1;
            if (e.Button == MouseButtons.Right) A205M_2Parameters.ПереключательКонтроль -= 1;
        }

        private void ПереключательВидРаботы_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) A205M_2Parameters.ПереключательВидРаботы += 1;
            if (e.Button == MouseButtons.Right) A205M_2Parameters.ПереключательВидРаботы -= 1;
        }

        private void A205M_2ПереключательВходЧТ_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) A205M_2Parameters.ПереключательВходЧТ += 1;
            if (e.Button == MouseButtons.Right) A205M_2Parameters.ПереключательВходЧТ -= 1;
        }

        #endregion
    }
}