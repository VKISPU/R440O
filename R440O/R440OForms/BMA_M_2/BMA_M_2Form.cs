//-----------------------------------------------------------------------
// <copyright file="BMA_M_2Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.BMA_M_2
{
    using System.Windows.Forms;
    using Parameters;
    using ThirdParty;
    /// <summary>
    /// Форма блока БМА-М-1
    /// </summary>
    public partial class BMA_M_2Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="BMA_M_2Form"/>.
        /// </summary>
        public BMA_M_2Form()
        {
            this.InitializeComponent();
            this.InitializeTogglesPosition();
            this.InitializeButtonsPosition();
        }
        #region Переключатели
        private void BMA_M_2ПереключательКонтроль_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_2Parameters.BMA_M_2ПереключательКонтроль += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_2Parameters.BMA_M_2ПереключательКонтроль -= 1;
            }

            var angle = BMA_M_2Parameters.BMA_M_2ПереключательКонтроль * 30 - 100;
            BMA_M_2ПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_2ПереключательРекурента_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_2Parameters.BMA_M_2ПереключательРекурента += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_2Parameters.BMA_M_2ПереключательРекурента -= 1;
            }

            var angle = BMA_M_2Parameters.BMA_M_2ПереключательРекурента * 30 - 70;
            BMA_M_2ПереключательРекурента.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_2ПереключательРежимРаботы_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_2Parameters.BMA_M_2ПереключательРежимРаботы += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_2Parameters.BMA_M_2ПереключательРежимРаботы -= 1;
            }

            var angle = BMA_M_2Parameters.BMA_M_2ПереключательРежимРаботы * 30 - 70;
            BMA_M_2ПереключательРежимРаботы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_2ПереключательКоррАЧХ_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_2Parameters.BMA_M_2ПереключательКоррАЧХ += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_2Parameters.BMA_M_2ПереключательКоррАЧХ -= 1;
            }

            var angle = BMA_M_2Parameters.BMA_M_2ПереключательКоррАЧХ * 30 - 100;
            BMA_M_2ПереключательКоррАЧХ.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_2ПереключательЧастотаВызова_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_2Parameters.BMA_M_2ПереключательЧастотаВызова += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_2Parameters.BMA_M_2ПереключательЧастотаВызова -= 1;
            }

            var angle = BMA_M_2Parameters.BMA_M_2ПереключательЧастотаВызова * 30 - 70;
            BMA_M_2ПереключательЧастотаВызова.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_2ПереключательУровниСигналаПрдПрм_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_2Parameters.BMA_M_2ПереключательУровниСигналаПрдПрм += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_2Parameters.BMA_M_2ПереключательУровниСигналаПрдПрм -= 1;
            }

            var angle = BMA_M_2Parameters.BMA_M_2ПереключательУровниСигналаПрдПрм * 30 - 70;
            BMA_M_2ПереключательУровниСигналаПрдПрм.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_2ПереключательРежимы_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_2Parameters.BMA_M_2ПереключательРежимы += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_2Parameters.BMA_M_2ПереключательРежимы -= 1;
            }

            var angle = BMA_M_2Parameters.BMA_M_2ПереключательРежимы * 30 - 70;
            BMA_M_2ПереключательРежимы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_2ПереключательЗапретЗапроса_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_2Parameters.BMA_M_2ПереключательЗапретЗапроса += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_2Parameters.BMA_M_2ПереключательЗапретЗапроса -= 1;
            }

            var angle = BMA_M_2Parameters.BMA_M_2ПереключательЗапретЗапроса * 30 - 45;
            BMA_M_2ПереключательЗапретЗапроса.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_2ПереключательКоррКанала_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_2Parameters.BMA_M_2ПереключательКоррКанала += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_2Parameters.BMA_M_2ПереключательКоррКанала -= 1;
            }

            var angle = BMA_M_2Parameters.BMA_M_2ПереключательКоррКанала * 30 - 45;
            BMA_M_2ПереключательКоррКанала.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }
        #endregion


        #region Кнопки
        private void BMA_M_2КнопкаШлейфТЧ_Click(object sender, System.EventArgs e)
        {
            if (BMA_M_2Parameters.BMA_M_2КнопкаШлейфТЧ)
            {
                this.BMA_M_2КнопкаШлейфТЧ.BackgroundImage = ControlElementImages.buttonSquareYellow;
                this.BMA_M_2КнопкаШлейфТЧ.Text = "ТЧ";
            }
            else
            {
                this.BMA_M_2КнопкаШлейфТЧ.BackgroundImage = null;
                this.BMA_M_2КнопкаШлейфТЧ.Text = string.Empty;
            }
            BMA_M_2Parameters.BMA_M_2КнопкаШлейфТЧ = !BMA_M_2Parameters.BMA_M_2КнопкаШлейфТЧ;
        }

        private void BMA_M_2КнопкаШлейфДК_Click(object sender, System.EventArgs e)
        {
            if (BMA_M_2Parameters.BMA_M_2КнопкаШлейфДК)
            {
                this.BMA_M_2КнопкаШлейфДК.BackgroundImage = ControlElementImages.buttonSquareYellow;
                this.BMA_M_2КнопкаШлейфДК.Text = "ДК";
            }
            else
            {
                this.BMA_M_2КнопкаШлейфДК.BackgroundImage = null;
                this.BMA_M_2КнопкаШлейфДК.Text = string.Empty;
            }
            BMA_M_2Parameters.BMA_M_2КнопкаШлейфДК = !BMA_M_2Parameters.BMA_M_2КнопкаШлейфДК;
        }

        private void BMA_M_2КнопкаПроверка_MouseUp(object sender, MouseEventArgs e)
        {
            this.BMA_M_2КнопкаПроверка.BackgroundImage = ControlElementImages.buttonSquareYellow;
            this.BMA_M_2КнопкаПроверка.Text = "1";
        }

        private void BMA_M_2КнопкаПроверка_MouseDown(object sender, MouseEventArgs e)
        {
            this.BMA_M_2КнопкаПроверка.BackgroundImage = null;
            this.BMA_M_2КнопкаПроверка.Text = string.Empty;
        }


        private void BMA_M_2КнопкаПитаниеВЫКЛ_MouseDown(object sender, MouseEventArgs e)
        {
            this.BMA_M_2КнопкаПитаниеВЫКЛ.Text = string.Empty;
            this.BMA_M_2КнопкаПитаниеВЫКЛ.BackgroundImage = null;

            if (BMA_M_2Parameters.BMA_M_2КнопкаПитаниеВКЛ)
            {
                BMA_M_2Parameters.BMA_M_2КнопкаПитаниеВЫКЛ = true;
                BMA_M_2Parameters.BMA_M_2КнопкаПитаниеВКЛ = false;
                this.BMA_M_2КнопкаПитаниеВКЛ.BackgroundImage = ControlElementImages.buttonSquareBlueOff;
            }
        }

        private void BMA_M_2КнопкаПитаниеВЫКЛ_MouseUp(object sender, MouseEventArgs e)
        {
            this.BMA_M_2КнопкаПитаниеВЫКЛ.Text = "ВЫКЛ";
            if (BMA_M_2Parameters.BMA_M_2КнопкаПитаниеВЫКЛ)
                this.BMA_M_2КнопкаПитаниеВЫКЛ.BackgroundImage = ControlElementImages.buttonSquareBlueOn;
            else
            {
                this.BMA_M_2КнопкаПитаниеВЫКЛ.BackgroundImage = ControlElementImages.buttonSquareBlueOff;
                BMA_M_2Parameters.BMA_M_2КнопкаПитаниеВКЛ = !BMA_M_2Parameters.BMA_M_2КнопкаПитаниеВКЛ;
            }
        }

        private void BMA_M_2КнопкаПитаниеВКЛ_MouseDown(object sender, MouseEventArgs e)
        {
            this.BMA_M_2КнопкаПитаниеВКЛ.Text = string.Empty;
            this.BMA_M_2КнопкаПитаниеВКЛ.BackgroundImage = null;

            if (BMA_M_2Parameters.BMA_M_2КнопкаПитаниеВЫКЛ)
            {
                BMA_M_2Parameters.BMA_M_2КнопкаПитаниеВКЛ = true;
                BMA_M_2Parameters.BMA_M_2КнопкаПитаниеВЫКЛ = false;
                this.BMA_M_2КнопкаПитаниеВЫКЛ.BackgroundImage = ControlElementImages.buttonSquareBlueOff;
            }
        }

        private void BMA_M_2КнопкаПитаниеВКЛ_MouseUp(object sender, MouseEventArgs e)
        {
            this.BMA_M_2КнопкаПитаниеВКЛ.Text = "ВКЛ";
            if (BMA_M_2Parameters.BMA_M_2КнопкаПитаниеВКЛ)
                this.BMA_M_2КнопкаПитаниеВКЛ.BackgroundImage = ControlElementImages.buttonSquareBlueOn;
            else
            {
                this.BMA_M_2КнопкаПитаниеВКЛ.BackgroundImage = ControlElementImages.buttonSquareBlueOff;
                BMA_M_2Parameters.BMA_M_2КнопкаПитаниеВКЛ = !BMA_M_2Parameters.BMA_M_2КнопкаПитаниеВКЛ;
            }

        }
        #endregion


        #region Инициализация
        private void InitializeTogglesPosition()
        {
            var angle = BMA_M_2Parameters.BMA_M_2ПереключательКонтроль * 30 - 100;
            BMA_M_2ПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = BMA_M_2Parameters.BMA_M_2ПереключательРекурента * 30 - 70;
            BMA_M_2ПереключательРекурента.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = BMA_M_2Parameters.BMA_M_2ПереключательРежимРаботы * 30 - 70;
            BMA_M_2ПереключательРежимРаботы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = BMA_M_2Parameters.BMA_M_2ПереключательКоррАЧХ * 30 - 100;
            BMA_M_2ПереключательКоррАЧХ.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = BMA_M_2Parameters.BMA_M_2ПереключательЧастотаВызова * 30 - 70;
            BMA_M_2ПереключательЧастотаВызова.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = BMA_M_2Parameters.BMA_M_2ПереключательУровниСигналаПрдПрм * 30 - 70;
            BMA_M_2ПереключательУровниСигналаПрдПрм.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = BMA_M_2Parameters.BMA_M_2ПереключательРежимы * 30 - 70;
            BMA_M_2ПереключательРежимы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = BMA_M_2Parameters.BMA_M_2ПереключательЗапретЗапроса * 30 - 45;
            BMA_M_2ПереключательЗапретЗапроса.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = BMA_M_2Parameters.BMA_M_2ПереключательКоррКанала * 30 - 45;
            BMA_M_2ПереключательКоррКанала.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void InitializeButtonsPosition()
        {
            if (BMA_M_2Parameters.BMA_M_2КнопкаШлейфТЧ)
            {
                this.BMA_M_2КнопкаШлейфТЧ.BackgroundImage = null;
                this.BMA_M_2КнопкаШлейфТЧ.Text = string.Empty;
            }
            else
            {
                this.BMA_M_2КнопкаШлейфТЧ.BackgroundImage = ControlElementImages.buttonSquareYellow;
                this.BMA_M_2КнопкаШлейфТЧ.Text = "ТЧ";
            }

            if (BMA_M_2Parameters.BMA_M_2КнопкаШлейфДК)
            {
                this.BMA_M_2КнопкаШлейфДК.BackgroundImage = null;
                this.BMA_M_2КнопкаШлейфДК.Text = string.Empty;
            }
            else
            {
                this.BMA_M_2КнопкаШлейфДК.BackgroundImage = ControlElementImages.buttonSquareYellow;
                this.BMA_M_2КнопкаШлейфДК.Text = "ДК";
            }

            this.BMA_M_2КнопкаПитаниеВКЛ.BackgroundImage = BMA_M_2Parameters.BMA_M_2КнопкаПитаниеВКЛ
                ? ControlElementImages.buttonSquareBlueOn
                : ControlElementImages.buttonSquareBlueOff;

            this.BMA_M_2КнопкаПитаниеВЫКЛ.BackgroundImage = BMA_M_2Parameters.BMA_M_2КнопкаПитаниеВЫКЛ
                ? ControlElementImages.buttonSquareBlueOn
                : ControlElementImages.buttonSquareBlueOff;
        }
        #endregion

    }
}