//-----------------------------------------------------------------------
// <copyright file="BMA_M_1Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------
using R440O.trash;
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
        private void ПереключательКонтроль_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.ПереключательКонтроль += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.ПереключательКонтроль -= 1;
            }          
        }

        private void ПереключательРекурента_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.ПереключательРекуррента += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.ПереключательРекуррента -= 1;
            }
        }

        private void ПереключательРежимРаботы_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.ПереключательРежимРаботы += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.ПереключательРежимРаботы -= 1;
            }
        }

        private void ПереключательКоррАЧХ_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.ПереключательКоррАЧХ += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.ПереключательКоррАЧХ -= 1;
            }
        }

        private void ПереключательЧастотаВызова_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.ПереключательЧастотаВызова += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.ПереключательЧастотаВызова -= 1;
            }            
        }

        private void ПереключательУровниСигналаПрдПрм_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.ПереключательУровниСигналаПрдПрм += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.ПереключательУровниСигналаПрдПрм -= 1;
            }
        }

        private void ПереключательРежимы_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.ПереключательРежимы += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.ПереключательРежимы -= 1;
            }
        }

        private void ПереключательЗапретЗапроса_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.ПереключательЗапретЗапроса += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.ПереключательЗапретЗапроса -= 1;
            }            
        }

        private void ПереключательКоррКанала_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMA_M_1Parameters.ПереключательКоррКанала += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMA_M_1Parameters.ПереключательКоррКанала -= 1;
            }            
        }
        #endregion

        #region Кнопки
        private void КнопкаШлейфТЧ_Click(object sender, System.EventArgs e)
        {
            BMA_M_1Parameters.КнопкаШлейфТЧ = !BMA_M_1Parameters.КнопкаШлейфТЧ;
        }

        private void КнопкаШлейфДК_Click(object sender, System.EventArgs e)
        {
            BMA_M_1Parameters.КнопкаШлейфДК = !BMA_M_1Parameters.КнопкаШлейфДК;
        }

        private void КнопкаПроверка_MouseUp(object sender, MouseEventArgs e)
        {
            this.КнопкаПроверка.BackgroundImage = ControlElementImages.buttonSquareYellow;
            this.КнопкаПроверка.Text = "1";
        }

        private void КнопкаПроверка_MouseDown(object sender, MouseEventArgs e)
        {
            this.КнопкаПроверка.BackgroundImage = null;
        }

        private void КнопкаПитаниеВЫКЛ_MouseDown(object sender, MouseEventArgs e)
        {
            this.КнопкаПитаниеВЫКЛ.BackgroundImage = null;
        }

        private void КнопкаПитаниеВЫКЛ_MouseUp(object sender, MouseEventArgs e)
        {
            BMA_M_1Parameters.Питание = false;
        }

        private void КнопкаПитаниеВКЛ_MouseDown(object sender, MouseEventArgs e)
        {            
            this.КнопкаПитаниеВКЛ.BackgroundImage = null;
        }

        private void КнопкаПитаниеВКЛ_MouseUp(object sender, MouseEventArgs e)
        {           
            BMA_M_1Parameters.Питание = true;
        }
        #endregion


        public void RefreshForm()
        {
            #region Переключатели
            var angle = (int)BMA_M_1Parameters.ПереключательКонтроль * 30 - 100;
            ПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_1Parameters.ПереключательРекуррента * 30 - 70;
            ПереключательРекурента.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_1Parameters.ПереключательРежимРаботы * 30 - 70;
            ПереключательРежимРаботы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_1Parameters.ПереключательКоррАЧХ * 30 - 100;
            ПереключательКоррАЧХ.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_1Parameters.ПереключательЧастотаВызова * 30 - 70;
            ПереключательЧастотаВызова.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_1Parameters.ПереключательУровниСигналаПрдПрм * 30 - 70;
            ПереключательУровниСигналаПрдПрм.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_1Parameters.ПереключательРежимы * 30 - 70;
            ПереключательРежимы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_1Parameters.ПереключательЗапретЗапроса * 30 - 45;
            ПереключательЗапретЗапроса.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_1Parameters.ПереключательКоррКанала * 30 - 45;
            ПереключательКоррКанала.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_1Parameters.ПереключательКонтроль * 30 - 100;
            ПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_1Parameters.ПереключательЧастотаВызова * 30 - 70;
            ПереключательЧастотаВызова.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_1Parameters.ПереключательКоррКанала * 30 - 45;
            ПереключательКоррКанала.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
            
            angle = (int)BMA_M_1Parameters.ПереключательЗапретЗапроса * 30 - 45;
            ПереключательЗапретЗапроса.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_1Parameters.ПереключательРежимы * 30 - 70;
            ПереключательРежимы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_1Parameters.ПереключательУровниСигналаПрдПрм * 30 - 70;
            ПереключательУровниСигналаПрдПрм.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_1Parameters.ПереключательКоррАЧХ * 30 - 100;
            ПереключательКоррАЧХ.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_1Parameters.ПереключательРежимРаботы * 30 - 70;
            ПереключательРежимРаботы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = (int)BMA_M_1Parameters.ПереключательРекуррента * 30 - 70;
            ПереключательРекурента.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
            #endregion

            #region Кнопки
            if (BMA_M_1Parameters.КнопкаШлейфТЧ || BMA_M_1Parameters.ЛампочкаКонтрольКомпл)
            {
                this.КнопкаШлейфТЧ.BackgroundImage = null;
                this.КнопкаШлейфТЧ.Text = string.Empty;
            }
            else
            {
                this.КнопкаШлейфТЧ.BackgroundImage = ControlElementImages.buttonSquareYellow;
                this.КнопкаШлейфТЧ.Text = "ТЧ";
            }

            if (BMA_M_1Parameters.КнопкаШлейфДК || BMA_M_1Parameters.ЛампочкаКонтрольКомпл)
            {
                this.КнопкаШлейфДК.BackgroundImage = null;
                this.КнопкаШлейфДК.Text = string.Empty;
            }
            else
            {
                this.КнопкаШлейфДК.BackgroundImage = ControlElementImages.buttonSquareYellow;
                this.КнопкаШлейфДК.Text = "ДК";
            }

            this.КнопкаПитаниеВКЛ.BackgroundImage = BMA_M_1Parameters.Питание 
                ? ControlElementImages.buttonSquareBlueOn
                : ControlElementImages.buttonSquareBlueOff;

            this.КнопкаПитаниеВЫКЛ.BackgroundImage = !BMA_M_1Parameters.Питание && BMA_M_1Parameters.ПитаниеН502 ?
                ControlElementImages.buttonSquareBlueOn : ControlElementImages.buttonSquareBlueOff;
            #endregion           

            #region Лампочки
            PropertyInfo[] fieldList = typeof(BMA_M_1Parameters).GetProperties();
            foreach (Control item in Panel.Controls)
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