//-----------------------------------------------------------------------
// <copyright file="BMA_M_1Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.BMA_M_1
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
    public partial class BMA_M_1Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="BMA_M_1Form"/>.
        /// </summary>
        public BMA_M_1Form()
        {
            this.InitializeComponent();
            BMA_M_1Parameters.RefreshForm += RefreshForm;
            RefreshForm();
        }

        #region Переключатели
        private void BMA_M_1ПереключательКонтроль_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.ПереключательКонтроль += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.ПереключательКонтроль -= 1;
            }

            var angle = (int)BMA_M_1Parameters.ПереключательКонтроль * 30 - 100;
            BMA_M_1ПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_1ПереключательРекурента_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.ПереключательРекуррента += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.ПереключательРекуррента -= 1;
            }

            var angle = (int)BMA_M_1Parameters.ПереключательРекуррента * 30 - 70;
            BMA_M_1ПереключательРекурента.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_1ПереключательРежимРаботы_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.ПереключательРежимРаботы += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.ПереключательРежимРаботы -= 1;
            }

            var angle = (int)BMA_M_1Parameters.ПереключательРежимРаботы * 30 - 70;
            BMA_M_1ПереключательРежимРаботы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_1ПереключательКоррАЧХ_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.ПереключательКоррАЧХ += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.ПереключательКоррАЧХ -= 1;
            }

            var angle = (int)BMA_M_1Parameters.ПереключательКоррАЧХ * 30 - 100;
            BMA_M_1ПереключательКоррАЧХ.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_1ПереключательЧастотаВызова_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.ПереключательЧастотаВызова += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.ПереключательЧастотаВызова -= 1;
            }

            var angle = (int)BMA_M_1Parameters.ПереключательЧастотаВызова * 30 - 70;
            BMA_M_1ПереключательЧастотаВызова.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_1ПереключательУровниСигналаПрдПрм_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.ПереключательУровниСигналаПрдПрм += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.ПереключательУровниСигналаПрдПрм -= 1;
            }

            var angle = (int)BMA_M_1Parameters.ПереключательУровниСигналаПрдПрм * 30 - 70;
            BMA_M_1ПереключательУровниСигналаПрдПрм.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_1ПереключательРежимы_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.ПереключательРежимы += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.ПереключательРежимы -= 1;
            }

            var angle = (int)BMA_M_1Parameters.ПереключательРежимы * 30 - 70;
            BMA_M_1ПереключательРежимы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_1ПереключательЗапретЗапроса_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.ПереключательЗапретЗапроса += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.ПереключательЗапретЗапроса -= 1;
            }

            var angle = (int)BMA_M_1Parameters.ПереключательЗапретЗапроса * 30 - 45;
            BMA_M_1ПереключательЗапретЗапроса.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void BMA_M_1ПереключательКоррКанала_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.ПереключательКоррКанала += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.ПереключательКоррКанала -= 1;
            }

            var angle = (int)BMA_M_1Parameters.ПереключательКоррКанала * 30 - 45;
            BMA_M_1ПереключательКоррКанала.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }
        #endregion

        #region Кнопки
        private void BMA_M_1КнопкаШлейфТЧ_Click(object sender, System.EventArgs e)
        {
            BMA_M_1Parameters.КнопкаШлейфТЧ = !BMA_M_1Parameters.КнопкаШлейфТЧ;
        }

        private void BMA_M_1КнопкаШлейфДК_Click(object sender, System.EventArgs e)
        {
            BMA_M_1Parameters.КнопкаШлейфДК = !BMA_M_1Parameters.КнопкаШлейфДК;
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

        }

        private void BMA_M_1КнопкаПитаниеВЫКЛ_MouseUp(object sender, MouseEventArgs e)
        {
            this.BMA_M_1КнопкаПитаниеВЫКЛ.Text = "ВЫКЛ";
            //this.BMA_M_1КнопкаПитаниеВЫКЛ.BackgroundImage = ControlElementImages.buttonSquareBlueOn;
            BMA_M_1Parameters.КнопкаПитаниеВЫКЛ = true;
        }

        private void BMA_M_1КнопкаПитаниеВКЛ_MouseDown(object sender, MouseEventArgs e)
        {
            this.BMA_M_1КнопкаПитаниеВКЛ.Text = string.Empty;
            this.BMA_M_1КнопкаПитаниеВКЛ.BackgroundImage = null;//TransformImageHelper.Scale(ControlElementImages.buttonSquareBlueOff, 93);
        }

        private void BMA_M_1КнопкаПитаниеВКЛ_MouseUp(object sender, MouseEventArgs e)
        {
            this.BMA_M_1КнопкаПитаниеВКЛ.Text = "ВКЛ";
            BMA_M_1Parameters.КнопкаПитаниеВКЛ = true;
            //this.BMA_M_1КнопкаПитаниеВКЛ.BackgroundImage = ControlElementImages.buttonSquareBlueOn;

        }
        #endregion

        public void RefreshForm()
        {
            #region Переключатели
            var angle = (int)BMA_M_1Parameters.ПереключательКонтроль * 30 - 100;
            BMA_M_1ПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_1Parameters.ПереключательРекуррента * 30 - 70;
            BMA_M_1ПереключательРекурента.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_1Parameters.ПереключательРежимРаботы * 30 - 70;
            BMA_M_1ПереключательРежимРаботы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_1Parameters.ПереключательКоррАЧХ * 30 - 100;
            BMA_M_1ПереключательКоррАЧХ.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_1Parameters.ПереключательЧастотаВызова * 30 - 70;
            BMA_M_1ПереключательЧастотаВызова.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_1Parameters.ПереключательУровниСигналаПрдПрм * 30 - 70;
            BMA_M_1ПереключательУровниСигналаПрдПрм.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_1Parameters.ПереключательРежимы * 30 - 70;
            BMA_M_1ПереключательРежимы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_1Parameters.ПереключательЗапретЗапроса * 30 - 45;
            BMA_M_1ПереключательЗапретЗапроса.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_1Parameters.ПереключательКоррКанала * 30 - 45;
            BMA_M_1ПереключательКоррКанала.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
            #endregion

            #region Кнопки
            if (BMA_M_1Parameters.КнопкаШлейфТЧ || BMA_M_1Parameters.ЛампочкаКонтрольКомпл)
            {
                this.BMA_M_1КнопкаШлейфТЧ.BackgroundImage = null;
                this.BMA_M_1КнопкаШлейфТЧ.Text = string.Empty;
            }
            else
            {
                this.BMA_M_1КнопкаШлейфТЧ.BackgroundImage = ControlElementImages.buttonSquareYellow;
                this.BMA_M_1КнопкаШлейфТЧ.Text = "ТЧ";
            }

            if (BMA_M_1Parameters.КнопкаШлейфДК || BMA_M_1Parameters.ЛампочкаКонтрольКомпл)
            {
                this.BMA_M_1КнопкаШлейфДК.BackgroundImage = null;
                this.BMA_M_1КнопкаШлейфДК.Text = string.Empty;
            }
            else
            {
                this.BMA_M_1КнопкаШлейфДК.BackgroundImage = ControlElementImages.buttonSquareYellow;
                this.BMA_M_1КнопкаШлейфДК.Text = "ДК";
            }
            this.BMA_M_1КнопкаПитаниеВКЛ.BackgroundImage = BMA_M_1Parameters.Питание 
                ? ControlElementImages.buttonSquareBlueOn
                : ControlElementImages.buttonSquareBlueOff;

            if (BMA_M_1Parameters.Питание)
                this.BMA_M_1КнопкаПитаниеВКЛ.BackgroundImage = ControlElementImages.buttonSquareBlueOn;
            else
                this.BMA_M_1КнопкаПитаниеВКЛ.BackgroundImage = ControlElementImages.buttonSquareBlueOff;

            this.BMA_M_1КнопкаПитаниеВЫКЛ.BackgroundImage = !BMA_M_1Parameters.Питание && BMA_M_1Parameters.ПитаниеН502 ?
                ControlElementImages.buttonSquareBlueOn : ControlElementImages.buttonSquareBlueOff;
            #endregion

            #region Какая-то магия  с лампочками
            /*
            foreach (Control item in BMA_M_1Panel.Controls)
            {
                if (item.Name.Contains("Лампочка"))
                {
                    if (item.Name.Contains("ЛампочкаИсправно"))
                    {
                        ЛампочкаИсправно.BackColor = BMA_M_1Parameters.ЛампочкаИсправно ? Color.FromArgb(100, 50, 250, 50) : Color.Transparent;
                    }
                    else
                        if (item.Name.Contains("ЛампочкаКонтрольКомпл"))
                        {
                            if (BMA_M_1Parameters.ЛампочкаКонтрольКомпл)
                            {
                                ЛампочкаКонтрольКомпл.BackgroundImage = ControlElementImages.lampType7OnRed;
                                if (!BMA_M_1Parameters.КнопкаШлейфДК)
                                {                                    
                                    BMA_M_1КнопкаШлейфДК.BackgroundImage = ControlElementImages.buttonSquareYellowOn;
                                    
                                }
                                if(!BMA_M_1Parameters.КнопкаШлейфТЧ)
                                {
                                    BMA_M_1КнопкаШлейфТЧ.BackgroundImage = ControlElementImages.buttonSquareYellowOn;
                                }

                            }
                            else
                            {
                                ЛампочкаКонтрольКомпл.BackgroundImage = null;
                                if (!BMA_M_1Parameters.КнопкаШлейфДК)
                                {
                                    BMA_M_1КнопкаШлейфДК.BackgroundImage = ControlElementImages.buttonSquareYellow;

                                }
                                if (!BMA_M_1Parameters.КнопкаШлейфТЧ)
                                {
                                    BMA_M_1КнопкаШлейфТЧ.BackgroundImage = ControlElementImages.buttonSquareYellow;
                                }
                            }
                        }
                        else
                        {
                            PropertyInfo[] fieldList = typeof(BMA_M_1Parameters).GetProperties();
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

            if (BMA_M_1Parameters.ЛампочкаДК)
            {
                ЛампочкаДК.BackgroundImage = ControlElementImages.lampType7OnRed;
            }
            else
            {
                ЛампочкаДК.BackgroundImage = null;
            }

            if (BMA_M_1Parameters.ЛампочкаТЧБ)
            {
                ЛампочкаТЧБ.BackgroundImage = ControlElementImages.lampType7OnRed;
            }
            else
            {
                ЛампочкаТЧБ.BackgroundImage = null;
            }
         */
            #endregion

            #region Лампочки
            PropertyInfo[] fieldList = typeof(BMA_M_1Parameters).GetProperties();
            foreach (Control item in BMA_M_1Panel.Controls)
            {
                if (item.Name.Contains("Лампочка"))
                {
                    if (item.Name.Contains("ЛампочкаИсправно"))
                    {
                        ЛампочкаИсправно.BackColor = BMA_M_1Parameters.ЛампочкаИсправно ? Color.FromArgb(100, 50, 250, 50) : Color.Transparent;
                        continue;
                    }
                    foreach (PropertyInfo property in fieldList)
                    {
                        if (item.Name == property.Name)
                        {
                            item.BackgroundImage = Convert.ToBoolean(property.GetValue(null))
                            ? ControlElementImages.lampType7OnRed
                            : null;
                        }
                    }
                }
            }
            #endregion

        }
    }
}