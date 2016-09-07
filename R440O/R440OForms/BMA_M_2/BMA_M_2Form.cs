//-----------------------------------------------------------------------
// <copyright file="BMA_M_2Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.BMA_M_2
{
    using System.Windows.Forms;
    using System.Reflection;
    using Parameters;
    using ThirdParty;
    using System;
    using System.Drawing;
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
            BMA_M_2Parameters.RefreshForm += RefreshForm;
            RefreshForm();
        }

        #region Переключатели
        private void BMA_M_2ПереключательКонтроль_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_2Parameters.ПереключательКонтроль += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_2Parameters.ПереключательКонтроль -= 1;
            }

            var angle = (int)BMA_M_2Parameters.ПереключательКонтроль * 30 - 100;
            BMA_M_2ПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_2ПереключательРекурента_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_2Parameters.ПереключательРекуррента += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_2Parameters.ПереключательРекуррента -= 1;
            }

            var angle = (int)BMA_M_2Parameters.ПереключательРекуррента * 30 - 70;
            BMA_M_2ПереключательРекурента.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_2ПереключательРежимРаботы_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_2Parameters.ПереключательРежимРаботы += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_2Parameters.ПереключательРежимРаботы -= 1;
            }

            var angle = (int)BMA_M_2Parameters.ПереключательРежимРаботы * 30 - 70;
            BMA_M_2ПереключательРежимРаботы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_2ПереключательКоррАЧХ_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_2Parameters.ПереключательКоррАЧХ += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_2Parameters.ПереключательКоррАЧХ -= 1;
            }

            var angle = (int)BMA_M_2Parameters.ПереключательКоррАЧХ * 30 - 100;
            BMA_M_2ПереключательКоррАЧХ.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_2ПереключательЧастотаВызова_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_2Parameters.ПереключательЧастотаВызова += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_2Parameters.ПереключательЧастотаВызова -= 1;
            }

            var angle = (int)BMA_M_2Parameters.ПереключательЧастотаВызова * 30 - 70;
            BMA_M_2ПереключательЧастотаВызова.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_2ПереключательУровниСигналаПрдПрм_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_2Parameters.ПереключательУровниСигналаПрдПрм += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_2Parameters.ПереключательУровниСигналаПрдПрм -= 1;
            }

            var angle = (int)BMA_M_2Parameters.ПереключательУровниСигналаПрдПрм * 30 - 70;
            BMA_M_2ПереключательУровниСигналаПрдПрм.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_2ПереключательРежимы_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_2Parameters.ПереключательРежимы += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_2Parameters.ПереключательРежимы -= 1;
            }

            var angle = (int)BMA_M_2Parameters.ПереключательРежимы * 30 - 70;
            BMA_M_2ПереключательРежимы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_2ПереключательЗапретЗапроса_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_2Parameters.ПереключательЗапретЗапроса += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_2Parameters.ПереключательЗапретЗапроса -= 1;
            }

            var angle = (int)BMA_M_2Parameters.ПереключательЗапретЗапроса * 30 - 45;
            BMA_M_2ПереключательЗапретЗапроса.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_2ПереключательКоррКанала_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_2Parameters.ПереключательКоррКанала += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_2Parameters.ПереключательКоррКанала -= 1;
            }

            var angle = (int)BMA_M_2Parameters.ПереключательКоррКанала * 30 - 45;
            BMA_M_2ПереключательКоррКанала.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }
        #endregion

        #region Кнопки
        private void BMA_M_2КнопкаШлейфТЧ_Click(object sender, System.EventArgs e)
        {
            if (BMA_M_2Parameters.КнопкаШлейфТЧ)
            {
                this.BMA_M_2КнопкаШлейфТЧ.BackgroundImage = ControlElementImages.buttonSquareYellow;
                this.BMA_M_2КнопкаШлейфТЧ.Text = "ТЧ";
            }
            else
            {
                this.BMA_M_2КнопкаШлейфТЧ.BackgroundImage = null;
                this.BMA_M_2КнопкаШлейфТЧ.Text = string.Empty;
            }
            BMA_M_2Parameters.КнопкаШлейфТЧ = !BMA_M_2Parameters.КнопкаШлейфТЧ;
        }

        private void BMA_M_2КнопкаШлейфДК_Click(object sender, System.EventArgs e)
        {
            if (BMA_M_2Parameters.КнопкаШлейфДК)
            {
                this.BMA_M_2КнопкаШлейфДК.BackgroundImage = ControlElementImages.buttonSquareYellow;
                this.BMA_M_2КнопкаШлейфДК.Text = "ДК";
            }
            else
            {
                this.BMA_M_2КнопкаШлейфДК.BackgroundImage = null;
                this.BMA_M_2КнопкаШлейфДК.Text = string.Empty;
            }
            BMA_M_2Parameters.КнопкаШлейфДК = !BMA_M_2Parameters.КнопкаШлейфДК;
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

        }

        private void BMA_M_2КнопкаПитаниеВЫКЛ_MouseUp(object sender, MouseEventArgs e)
        {
            this.BMA_M_2КнопкаПитаниеВЫКЛ.Text = "ВЫКЛ";
            this.BMA_M_2КнопкаПитаниеВЫКЛ.BackgroundImage = ControlElementImages.buttonSquareBlueOff;
            BMA_M_2Parameters.КнопкаПитаниеВЫКЛ = true;
        }

        private void BMA_M_2КнопкаПитаниеВКЛ_MouseDown(object sender, MouseEventArgs e)
        {
            this.BMA_M_2КнопкаПитаниеВКЛ.Text = string.Empty;
            this.BMA_M_2КнопкаПитаниеВКЛ.BackgroundImage = null;
        }

        private void BMA_M_2КнопкаПитаниеВКЛ_MouseUp(object sender, MouseEventArgs e)
        {
            this.BMA_M_2КнопкаПитаниеВКЛ.Text = "ВКЛ";
            BMA_M_2Parameters.КнопкаПитаниеВКЛ = true;
            this.BMA_M_2КнопкаПитаниеВКЛ.BackgroundImage = ControlElementImages.buttonSquareBlueOn;
            BMA_M_2Parameters.КнопкаПитаниеВКЛ = true;

        }
        #endregion

        public void RefreshForm()
        {
            #region Переключатели
            var angle = (int)BMA_M_2Parameters.ПереключательКонтроль * 30 - 100;
            BMA_M_2ПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_2Parameters.ПереключательРекуррента * 30 - 70;
            BMA_M_2ПереключательРекурента.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_2Parameters.ПереключательРежимРаботы * 30 - 70;
            BMA_M_2ПереключательРежимРаботы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_2Parameters.ПереключательКоррАЧХ * 30 - 100;
            BMA_M_2ПереключательКоррАЧХ.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_2Parameters.ПереключательЧастотаВызова * 30 - 70;
            BMA_M_2ПереключательЧастотаВызова.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_2Parameters.ПереключательУровниСигналаПрдПрм * 30 - 70;
            BMA_M_2ПереключательУровниСигналаПрдПрм.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_2Parameters.ПереключательРежимы * 30 - 70;
            BMA_M_2ПереключательРежимы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_2Parameters.ПереключательЗапретЗапроса * 30 - 45;
            BMA_M_2ПереключательЗапретЗапроса.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_2Parameters.ПереключательКоррКанала * 30 - 45;
            BMA_M_2ПереключательКоррКанала.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
            #endregion

            #region Кнопки
            if (BMA_M_2Parameters.КнопкаШлейфТЧ)
            {
                this.BMA_M_2КнопкаШлейфТЧ.BackgroundImage = null;
                this.BMA_M_2КнопкаШлейфТЧ.Text = string.Empty;
            }
            else
            {
                this.BMA_M_2КнопкаШлейфТЧ.BackgroundImage = ControlElementImages.buttonSquareYellow;
                this.BMA_M_2КнопкаШлейфТЧ.Text = "ТЧ";
            }

            if (BMA_M_2Parameters.КнопкаШлейфДК)
            {
                this.BMA_M_2КнопкаШлейфДК.BackgroundImage = null;
                this.BMA_M_2КнопкаШлейфДК.Text = string.Empty;
            }
            else
            {
                this.BMA_M_2КнопкаШлейфДК.BackgroundImage = ControlElementImages.buttonSquareYellow;
                this.BMA_M_2КнопкаШлейфДК.Text = "ДК";
            }
            this.BMA_M_2КнопкаПитаниеВКЛ.BackgroundImage = BMA_M_2Parameters.КнопкаПитаниеВКЛ
                ? ControlElementImages.buttonSquareBlueOn
                : ControlElementImages.buttonSquareBlueOff;

            this.BMA_M_2КнопкаПитаниеВЫКЛ.BackgroundImage = ControlElementImages.buttonSquareBlueOff;
            #endregion

            foreach (Control item in BMA_M_2Panel.Controls)
            {
                if (item.Name.Contains("Лампочка"))
                {
                    if (item.Name.Contains("ЛампочкаИсправно"))
                    {
                        ЛампочкаИсправно.BackColor = BMA_M_2Parameters.ЛампочкаИсправно ? Color.FromArgb(100, 50, 250, 50) : Color.Transparent;
                    }
                    else
                        if (item.Name.Contains("ЛампочкаКонтрольКомпл"))
                        {
                            if (BMA_M_2Parameters.ЛампочкаКонтрольКомпл)
                            {
                                ЛампочкаКонтрольКомпл.BackgroundImage = ControlElementImages.lampType7OnRed;
                                if (!BMA_M_2Parameters.КнопкаШлейфДК)
                                {
                                    BMA_M_2КнопкаШлейфДК.BackgroundImage = ControlElementImages.buttonSquareYellowOn;

                                }
                                if (!BMA_M_2Parameters.КнопкаШлейфТЧ)
                                {
                                    BMA_M_2КнопкаШлейфТЧ.BackgroundImage = ControlElementImages.buttonSquareYellowOn;
                                }

                            }
                            else
                            {
                                ЛампочкаКонтрольКомпл.BackgroundImage = null;
                                if (!BMA_M_2Parameters.КнопкаШлейфДК)
                                {
                                    BMA_M_2КнопкаШлейфДК.BackgroundImage = ControlElementImages.buttonSquareYellow;

                                }
                                if (!BMA_M_2Parameters.КнопкаШлейфТЧ)
                                {
                                    BMA_M_2КнопкаШлейфТЧ.BackgroundImage = ControlElementImages.buttonSquareYellow;
                                }
                            }
                        }
                        else
                        {
                            PropertyInfo[] fieldList = typeof(BMA_M_2Parameters).GetProperties();
                            foreach (PropertyInfo property in fieldList)
                            {
                                if (item.Name == property.Name)
                                {
                                    item.BackgroundImage = Convert.ToBoolean(property.GetValue(null))
                                    ? ControlElementImages.lampType7OnRed
                                    : null;
                                    break;
                                }
                            }
                        }
                }
            }

            if (BMA_M_2Parameters.ЛампочкаДК)
            {
                ЛампочкаДК.BackgroundImage = ControlElementImages.lampType7OnRed;
            }
            else
            {
                ЛампочкаДК.BackgroundImage = null;
            }

            if (BMA_M_2Parameters.ЛампочкаТЧБ)
            {
                ЛампочкаТЧБ.BackgroundImage = ControlElementImages.lampType7OnRed;
            }
            else
            {
                ЛампочкаТЧБ.BackgroundImage = null;
            }

        }
    }
}