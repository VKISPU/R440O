//-----------------------------------------------------------------------
// <copyright file="A205M_2Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.A205M_2
{
    using System.Windows.Forms;
    using Parameters;
    using ThirdParty;

    /// <summary>
    /// Форма блока А205М-2
    /// </summary>
    public partial class A205M_2Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="A205M_2Form"/>.
        /// </summary>
        public A205M_2Form()
        {
            this.InitializeComponent();
            this.InitializeToggles();
        }

        private void InitializeToggles()
        {
            A205M_2ТумблерКЭД.BackgroundImage = A205M_2Parameters.A205M_2ТумблерКЭД
                ? ControlElementImages.tumblerType6Up
                : ControlElementImages.tumblerType6Down;

            var angle = A205M_2Parameters.A205M_2ПереключательВолнаX10000 * 35 - 90;
            A205M_2ПереключательВолнаX10000.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_2Parameters.A205M_2ПереключательВолнаX1000 * 35 - 160;
            A205M_2ПереключательВолнаX1000.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_2Parameters.A205M_2ПереключательВолнаX100 * 35 - 160;
            A205M_2ПереключательВолнаX100.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_2Parameters.A205M_2ПереключательВолнаX10 * 35 - 160;
            A205M_2ПереключательВолнаX10.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_2Parameters.A205M_2ПереключательВолнаX1 * 35 - 160;
            A205M_2ПереключательВолнаX1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_2Parameters.A205M_2ПереключательКонтроль * 30 - 180;
            A205M_2ПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_2Parameters.A205M_2ПереключательВидРаботы * 30 - 75;
            A205M_2ПереключательВидРаботы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);

            angle = A205M_2Parameters.A205M_2ПереключательВходЧТ * 30 - 60;
            A205M_2ПереключательВходЧТ.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);
        }

        private void A205M_2ПереключательКЭД_Click(object sender, System.EventArgs e)
        {
            A205M_2Parameters.A205M_2ТумблерКЭД = !A205M_2Parameters.A205M_2ТумблерКЭД;
            A205M_2ТумблерКЭД.BackgroundImage = A205M_2Parameters.A205M_2ТумблерКЭД
                ? ControlElementImages.tumblerType6Up
                : ControlElementImages.tumblerType6Down;
        }

        #region Отображение на дисплее текущей выбранной волны
        private void A205M_2КнопкаОтсчет_MouseDown(object sender, MouseEventArgs e)
        {
            A205M_2КнопкаОтсчет.BackgroundImage = null;
            A205M_2Дисплей.Text = A205M_2Parameters.A205M_2ПереключательВолнаX10000 + "  " +
                                  A205M_2Parameters.A205M_2ПереключательВолнаX1000 + "  " +
                                  A205M_2Parameters.A205M_2ПереключательВолнаX100 + "  " +
                                  A205M_2Parameters.A205M_2ПереключательВолнаX10 + "  " +
                                  A205M_2Parameters.A205M_2ПереключательВолнаX1;

        }

        private void A205M_2КнопкаОтсчет_MouseUp(object sender, MouseEventArgs e)
        {
            A205M_2КнопкаОтсчет.BackgroundImage = ControlElementImages.buttonRoundType6;
            A205M_2Дисплей.Text = string.Empty;
        }
        #endregion

        #region Установка переключателей волны
        private void A205M_2ПереключательВолнаX10000_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A205M_2Parameters.A205M_2ПереключательВолнаX10000 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A205M_2Parameters.A205M_2ПереключательВолнаX10000 -= 1;
            }

            var angle = A205M_2Parameters.A205M_2ПереключательВолнаX10000 * 35 - 90;
            A205M_2ПереключательВолнаX10000.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);
        }

        private void A205M_2ПереключательВолнаX1000_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A205M_2Parameters.A205M_2ПереключательВолнаX1000 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A205M_2Parameters.A205M_2ПереключательВолнаX1000 -= 1;
            }

            var angle = A205M_2Parameters.A205M_2ПереключательВолнаX1000 * 35 - 160;
            A205M_2ПереключательВолнаX1000.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);
        }

        private void A205M_2ПереключательВолнаX100_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A205M_2Parameters.A205M_2ПереключательВолнаX100 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A205M_2Parameters.A205M_2ПереключательВолнаX100 -= 1;
            }

            var angle = A205M_2Parameters.A205M_2ПереключательВолнаX100 * 35 - 160;
            A205M_2ПереключательВолнаX100.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);
        }

        private void A205M_2ПереключательВолнаX10_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A205M_2Parameters.A205M_2ПереключательВолнаX10 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A205M_2Parameters.A205M_2ПереключательВолнаX10 -= 1;
            }

            var angle = A205M_2Parameters.A205M_2ПереключательВолнаX10 * 35 - 160;
            A205M_2ПереключательВолнаX10.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);
        }

        private void A205M_2ПереключательВолнаX1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A205M_2Parameters.A205M_2ПереключательВолнаX1 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A205M_2Parameters.A205M_2ПереключательВолнаX1 -= 1;
            }

            var angle = A205M_2Parameters.A205M_2ПереключательВолнаX1 * 35 - 160;
            A205M_2ПереключательВолнаX1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);
        }
        #endregion

        #region Переключатели контроля, вида работы, входы чт
        private void A205M_2ПереключательКонтроль_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A205M_2Parameters.A205M_2ПереключательКонтроль += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A205M_2Parameters.A205M_2ПереключательКонтроль -= 1;
            }

            var angle = A205M_2Parameters.A205M_2ПереключательКонтроль * 30 - 180;
            A205M_2ПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);
        }

        private void A205M_2ПереключательВидРаботы_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A205M_2Parameters.A205M_2ПереключательВидРаботы += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A205M_2Parameters.A205M_2ПереключательВидРаботы -= 1;
            }

            var angle = A205M_2Parameters.A205M_2ПереключательВидРаботы * 30 - 75;
            A205M_2ПереключательВидРаботы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);
        }

        private void A205M_2ПереключательВходЧТ_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A205M_2Parameters.A205M_2ПереключательВходЧТ += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A205M_2Parameters.A205M_2ПереключательВходЧТ -= 1;
            }

            var angle = A205M_2Parameters.A205M_2ПереключательВходЧТ * 30 - 60;
            A205M_2ПереключательВходЧТ.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType6, angle);
        }
        #endregion
    }
}