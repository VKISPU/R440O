//-----------------------------------------------------------------------
// <copyright file="A205M_1Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using R440O.ThirdParty;

namespace R440O.R440OForms.A205M_1
{
    using System.Windows.Forms;
    using Parameters;

    /// <summary>
    /// Форма блока А205М-1
    /// </summary>
    public partial class A205M_1Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="A205M_1Form"/>.
        /// </summary>
        public A205M_1Form()
        {
            this.InitializeComponent();
            this.InitializeToggles();
        }

        private void InitializeToggles()
        {
            var angle = A205M_1Parameters.A205M_1ПереключательВолнаX10000 * 35 - 90;
            A205M_1ПереключательВолнаX10000.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_1Parameters.A205M_1ПереключательВолнаX1000 * 35 - 160;
            A205M_1ПереключательВолнаX1000.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_1Parameters.A205M_1ПереключательВолнаX100 * 35 - 160;
            A205M_1ПереключательВолнаX100.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_1Parameters.A205M_1ПереключательВолнаX10 * 35 - 160;
            A205M_1ПереключательВолнаX10.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_1Parameters.A205M_1ПереключательВолнаX1 * 35 - 160;
            A205M_1ПереключательВолнаX1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_1Parameters.A205M_1ПереключательКонтроль * 30 - 180;
            A205M_1ПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_1Parameters.A205M_1ПереключательВидРаботы * 30 - 75;
            A205M_1ПереключательВидРаботы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_1Parameters.A205M_1ПереключательВходЧТ * 30 - 60;
            A205M_1ПереключательВходЧТ.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);
        }

        private void A205M_1ПереключательКЭД_Click(object sender, System.EventArgs e)
        {
            A205M_1Parameters.A205M_1ТумблерКЭД = ! A205M_1Parameters.A205M_1ТумблерКЭД;
            A205M_1ТумблерКЭД.BackgroundImage = A205M_1Parameters.A205M_1ТумблерКЭД
                ? ControlElementImages.tumblerType6Up
                : ControlElementImages.tumblerType6Down;
        }

        #region Отображение на дисплее текущей выбранной волны
        private void A205M_1КнопкаОтсчет_MouseDown(object sender, MouseEventArgs e)
        {
            A205M_1КнопкаОтсчет.BackgroundImage = null;
            A205M_1Дисплей.Text = A205M_1Parameters.A205M_1ПереключательВолнаX10000 + "  " +
                                  A205M_1Parameters.A205M_1ПереключательВолнаX1000 + "  " +
                                  A205M_1Parameters.A205M_1ПереключательВолнаX100 + "  " +
                                  A205M_1Parameters.A205M_1ПереключательВолнаX10 + "  " +
                                  A205M_1Parameters.A205M_1ПереключательВолнаX1;

        }

        private void A205M_1КнопкаОтсчет_MouseUp(object sender, MouseEventArgs e)
        {
            A205M_1КнопкаОтсчет.BackgroundImage = ControlElementImages.buttonRoundType6;
            A205M_1Дисплей.Text = string.Empty;
        } 
        #endregion

        #region Установка переключателей волны
        private void A205M_1ПереключательВолнаX10000_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A205M_1Parameters.A205M_1ПереключательВолнаX10000 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A205M_1Parameters.A205M_1ПереключательВолнаX10000 -= 1;
            }

            var angle = A205M_1Parameters.A205M_1ПереключательВолнаX10000 * 35 - 90;
            A205M_1ПереключательВолнаX10000.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);
        }

        private void A205M_1ПереключательВолнаX1000_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A205M_1Parameters.A205M_1ПереключательВолнаX1000 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A205M_1Parameters.A205M_1ПереключательВолнаX1000 -= 1;
            }

            var angle = A205M_1Parameters.A205M_1ПереключательВолнаX1000 * 35 - 160;
            A205M_1ПереключательВолнаX1000.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);
        }

        private void A205M_1ПереключательВолнаX100_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A205M_1Parameters.A205M_1ПереключательВолнаX100 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A205M_1Parameters.A205M_1ПереключательВолнаX100 -= 1;
            }

            var angle = A205M_1Parameters.A205M_1ПереключательВолнаX100 * 35 - 160;
            A205M_1ПереключательВолнаX100.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);
        }

        private void A205M_1ПереключательВолнаX10_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A205M_1Parameters.A205M_1ПереключательВолнаX10 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A205M_1Parameters.A205M_1ПереключательВолнаX10 -= 1;
            }

            var angle = A205M_1Parameters.A205M_1ПереключательВолнаX10 * 35 - 160;
            A205M_1ПереключательВолнаX10.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);
        }

        private void A205M_1ПереключательВолнаX1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A205M_1Parameters.A205M_1ПереключательВолнаX1 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A205M_1Parameters.A205M_1ПереключательВолнаX1 -= 1;
            }

            var angle = A205M_1Parameters.A205M_1ПереключательВолнаX1 * 35 - 160;
            A205M_1ПереключательВолнаX1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);
        } 
        #endregion

        private void A205M_1ПереключательКонтроль_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A205M_1Parameters.A205M_1ПереключательКонтроль += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A205M_1Parameters.A205M_1ПереключательКонтроль -= 1;
            }

            var angle = A205M_1Parameters.A205M_1ПереключательКонтроль * 30 - 180;
            A205M_1ПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);
        }

        private void A205M_1ПереключательВидРаботы_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A205M_1Parameters.A205M_1ПереключательВидРаботы += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A205M_1Parameters.A205M_1ПереключательВидРаботы -= 1;
            }

            var angle = A205M_1Parameters.A205M_1ПереключательВидРаботы * 30 - 75;
            A205M_1ПереключательВидРаботы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);
        }

        private void A205M_1ПереключательВходЧТ_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A205M_1Parameters.A205M_1ПереключательВходЧТ += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A205M_1Parameters.A205M_1ПереключательВходЧТ -= 1;
            }

            var angle = A205M_1Parameters.A205M_1ПереключательВходЧТ * 30 - 60;
            A205M_1ПереключательВходЧТ.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);
        }
    }
}