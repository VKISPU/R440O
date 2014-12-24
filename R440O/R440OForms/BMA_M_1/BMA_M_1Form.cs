//-----------------------------------------------------------------------
// <copyright file="BMA_M_1Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.BMA_M_1
{
    using System.Windows.Forms;
    using Parameters;
    using ThirdParty;
    /// <summary>
    /// Форма блока БМА-М-1
    /// </summary>
    public partial class BMA_M_1Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="BMA_M_1Form"/>.
        /// </summary>
        public BMA_M_1Form()
        {
            this.InitializeComponent();
            this.InitializeTogglesPosition();
            this.InitializeButtonsPosition();
        }
        #region Переключатели
        private void BMA_M_1ПереключательКонтроль_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.BMA_M_1ПереключательКонтроль += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.BMA_M_1ПереключательКонтроль -= 1;
            }

            var angle = BMA_M_1Parameters.BMA_M_1ПереключательКонтроль * 30 - 100;
            BMA_M_1ПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_1ПереключательРекурента_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.BMA_M_1ПереключательРекурента += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.BMA_M_1ПереключательРекурента -= 1;
            }

            var angle = BMA_M_1Parameters.BMA_M_1ПереключательРекурента * 30 - 70;
            BMA_M_1ПереключательРекурента.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_1ПереключательРежимРаботы_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.BMA_M_1ПереключательРежимРаботы += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.BMA_M_1ПереключательРежимРаботы -= 1;
            }

            var angle = BMA_M_1Parameters.BMA_M_1ПереключательРежимРаботы * 30 - 70;
            BMA_M_1ПереключательРежимРаботы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_1ПереключательКоррАЧХ_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.BMA_M_1ПереключательКоррАЧХ += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.BMA_M_1ПереключательКоррАЧХ -= 1;
            }

            var angle = BMA_M_1Parameters.BMA_M_1ПереключательКоррАЧХ * 30 - 100;
            BMA_M_1ПереключательКоррАЧХ.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_1ПереключательЧастотаВызова_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.BMA_M_1ПереключательЧастотаВызова += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.BMA_M_1ПереключательЧастотаВызова -= 1;
            }

            var angle = BMA_M_1Parameters.BMA_M_1ПереключательЧастотаВызова * 30 - 70;
            BMA_M_1ПереключательЧастотаВызова.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_1ПереключательУровниСигналаПрдПрм_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.BMA_M_1ПереключательУровниСигналаПрдПрм += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.BMA_M_1ПереключательУровниСигналаПрдПрм -= 1;
            }

            var angle = BMA_M_1Parameters.BMA_M_1ПереключательУровниСигналаПрдПрм * 30 - 70;
            BMA_M_1ПереключательУровниСигналаПрдПрм.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_1ПереключательРежимы_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.BMA_M_1ПереключательРежимы += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.BMA_M_1ПереключательРежимы -= 1;
            }

            var angle = BMA_M_1Parameters.BMA_M_1ПереключательРежимы * 30 - 70;
            BMA_M_1ПереключательРежимы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_1ПереключательЗапретЗапроса_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.BMA_M_1ПереключательЗапретЗапроса += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.BMA_M_1ПереключательЗапретЗапроса -= 1;
            }

            var angle = BMA_M_1Parameters.BMA_M_1ПереключательЗапретЗапроса * 30 - 45;
            BMA_M_1ПереключательЗапретЗапроса.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_1ПереключательКоррКанала_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.BMA_M_1ПереключательКоррКанала += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.BMA_M_1ПереключательКоррКанала -= 1;
            }

            var angle = BMA_M_1Parameters.BMA_M_1ПереключательКоррКанала * 30 - 45;
            BMA_M_1ПереключательКоррКанала.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }
        #endregion


        #region Кнопки
        private void BMA_M_1КнопкаШлейфТЧ_Click(object sender, System.EventArgs e)
        {
            if (BMA_M_1Parameters.BMA_M_1КнопкаШлейфТЧ)
            {
                this.BMA_M_1КнопкаШлейфТЧ.BackgroundImage = ControlElementImages.buttonSquareYellow;
                this.BMA_M_1КнопкаШлейфТЧ.Text = "ТЧ";
            }
            else
            {
                this.BMA_M_1КнопкаШлейфТЧ.BackgroundImage = null;
                this.BMA_M_1КнопкаШлейфТЧ.Text = string.Empty;
            }
            BMA_M_1Parameters.BMA_M_1КнопкаШлейфТЧ = !BMA_M_1Parameters.BMA_M_1КнопкаШлейфТЧ;
        }

        private void BMA_M_1КнопкаШлейфДК_Click(object sender, System.EventArgs e)
        {
            if (BMA_M_1Parameters.BMA_M_1КнопкаШлейфДК)
            {
                this.BMA_M_1КнопкаШлейфДК.BackgroundImage = ControlElementImages.buttonSquareYellow;
                this.BMA_M_1КнопкаШлейфДК.Text = "ДК";
            }
            else
            {
                this.BMA_M_1КнопкаШлейфДК.BackgroundImage = null;
                this.BMA_M_1КнопкаШлейфДК.Text = string.Empty;
            }
            BMA_M_1Parameters.BMA_M_1КнопкаШлейфДК = !BMA_M_1Parameters.BMA_M_1КнопкаШлейфДК;
        }

        private void BMA_M_1КнопкаПроверка_MouseUp(object sender, MouseEventArgs e)
        {
            this.BMA_M_1КнопкаПроверка.BackgroundImage = ControlElementImages.buttonSquareYellow;
            this.BMA_M_1КнопкаПроверка.Text = "1";
        }

        private void BMA_M_1КнопкаПроверка_MouseDown(object sender, MouseEventArgs e)
        {
            this.BMA_M_1КнопкаПроверка.BackgroundImage = null;
            this.BMA_M_1КнопкаПроверка.Text = string.Empty;
        }


        private void BMA_M_1КнопкаПитаниеВЫКЛ_MouseDown(object sender, MouseEventArgs e)
        {
            this.BMA_M_1КнопкаПитаниеВЫКЛ.Text = string.Empty;
            this.BMA_M_1КнопкаПитаниеВЫКЛ.BackgroundImage = null;

            if (BMA_M_1Parameters.BMA_M_1КнопкаПитаниеВКЛ)
            {
                BMA_M_1Parameters.BMA_M_1КнопкаПитаниеВЫКЛ = true;
                BMA_M_1Parameters.BMA_M_1КнопкаПитаниеВКЛ = false;
                this.BMA_M_1КнопкаПитаниеВКЛ.BackgroundImage = ControlElementImages.buttonSquareBlueOff;
            }
        }

        private void BMA_M_1КнопкаПитаниеВЫКЛ_MouseUp(object sender, MouseEventArgs e)
        {
            this.BMA_M_1КнопкаПитаниеВЫКЛ.Text = "ВЫКЛ";
            if (BMA_M_1Parameters.BMA_M_1КнопкаПитаниеВЫКЛ)
                this.BMA_M_1КнопкаПитаниеВЫКЛ.BackgroundImage = ControlElementImages.buttonSquareBlueOn;
            else
            {
                this.BMA_M_1КнопкаПитаниеВЫКЛ.BackgroundImage = ControlElementImages.buttonSquareBlueOff;
                BMA_M_1Parameters.BMA_M_1КнопкаПитаниеВКЛ = !BMA_M_1Parameters.BMA_M_1КнопкаПитаниеВКЛ;
            }
        }

        private void BMA_M_1КнопкаПитаниеВКЛ_MouseDown(object sender, MouseEventArgs e)
        {
            this.BMA_M_1КнопкаПитаниеВКЛ.Text = string.Empty;
            this.BMA_M_1КнопкаПитаниеВКЛ.BackgroundImage = null;

            if (BMA_M_1Parameters.BMA_M_1КнопкаПитаниеВЫКЛ)
            {
                BMA_M_1Parameters.BMA_M_1КнопкаПитаниеВКЛ = true;
                BMA_M_1Parameters.BMA_M_1КнопкаПитаниеВЫКЛ = false;
                this.BMA_M_1КнопкаПитаниеВЫКЛ.BackgroundImage = ControlElementImages.buttonSquareBlueOff;
            }
        }

        private void BMA_M_1КнопкаПитаниеВКЛ_MouseUp(object sender, MouseEventArgs e)
        {
            this.BMA_M_1КнопкаПитаниеВКЛ.Text = "ВКЛ";
            if (BMA_M_1Parameters.BMA_M_1КнопкаПитаниеВКЛ)
                this.BMA_M_1КнопкаПитаниеВКЛ.BackgroundImage = ControlElementImages.buttonSquareBlueOn;
            else
            {
                this.BMA_M_1КнопкаПитаниеВКЛ.BackgroundImage = ControlElementImages.buttonSquareBlueOff;
                BMA_M_1Parameters.BMA_M_1КнопкаПитаниеВКЛ = !BMA_M_1Parameters.BMA_M_1КнопкаПитаниеВКЛ;
            }

        }
        #endregion


        #region Инициализация
        private void InitializeTogglesPosition()
        {
            var angle = BMA_M_1Parameters.BMA_M_1ПереключательКонтроль * 30 - 100;
            BMA_M_1ПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = BMA_M_1Parameters.BMA_M_1ПереключательРекурента * 30 - 70;
            BMA_M_1ПереключательРекурента.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = BMA_M_1Parameters.BMA_M_1ПереключательРежимРаботы * 30 - 70;
            BMA_M_1ПереключательРежимРаботы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = BMA_M_1Parameters.BMA_M_1ПереключательКоррАЧХ * 30 - 100;
            BMA_M_1ПереключательКоррАЧХ.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = BMA_M_1Parameters.BMA_M_1ПереключательЧастотаВызова * 30 - 70;
            BMA_M_1ПереключательЧастотаВызова.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = BMA_M_1Parameters.BMA_M_1ПереключательУровниСигналаПрдПрм * 30 - 70;
            BMA_M_1ПереключательУровниСигналаПрдПрм.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = BMA_M_1Parameters.BMA_M_1ПереключательРежимы * 30 - 70;
            BMA_M_1ПереключательРежимы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = BMA_M_1Parameters.BMA_M_1ПереключательЗапретЗапроса * 30 - 45;
            BMA_M_1ПереключательЗапретЗапроса.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = BMA_M_1Parameters.BMA_M_1ПереключательКоррКанала * 30 - 45;
            BMA_M_1ПереключательКоррКанала.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void InitializeButtonsPosition()
        {
            if (BMA_M_1Parameters.BMA_M_1КнопкаШлейфТЧ)
            {
                this.BMA_M_1КнопкаШлейфТЧ.BackgroundImage = null;
                this.BMA_M_1КнопкаШлейфТЧ.Text = string.Empty;
            }
            else
            {
                this.BMA_M_1КнопкаШлейфТЧ.BackgroundImage = ControlElementImages.buttonSquareYellow;
                this.BMA_M_1КнопкаШлейфТЧ.Text = "ТЧ";
            }

            if (BMA_M_1Parameters.BMA_M_1КнопкаШлейфДК)
            {
                this.BMA_M_1КнопкаШлейфДК.BackgroundImage = null;
                this.BMA_M_1КнопкаШлейфДК.Text = string.Empty;
            }
            else
            {
                this.BMA_M_1КнопкаШлейфДК.BackgroundImage = ControlElementImages.buttonSquareYellow;
                this.BMA_M_1КнопкаШлейфДК.Text = "ДК";
            }

            this.BMA_M_1КнопкаПитаниеВКЛ.BackgroundImage = BMA_M_1Parameters.BMA_M_1КнопкаПитаниеВКЛ
                ? ControlElementImages.buttonSquareBlueOn
                : ControlElementImages.buttonSquareBlueOff;

            this.BMA_M_1КнопкаПитаниеВЫКЛ.BackgroundImage = BMA_M_1Parameters.BMA_M_1КнопкаПитаниеВЫКЛ
                ? ControlElementImages.buttonSquareBlueOn
                : ControlElementImages.buttonSquareBlueOff;
        }
        #endregion

    }
}