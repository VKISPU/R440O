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
            this.InitializeComponent();
            this.InitializeButtonsPosition();
            this.InitializeTogglesPosition();
            this.InitializeIndicatorsPosition();
        }

        #region Кнопки
        private void BMBКнопкаНаборКоманды1_MouseDown(object sender, MouseEventArgs e)
        {
            this.BMBКнопкаНаборКоманды1.BackgroundImage = null;
            this.BMBКнопкаНаборКоманды1.Text = string.Empty;

            if (BMBParameters.BMBИндикаторНаборКоманды[1] <= '2' && BMBParameters.BMBКнопкаПитание)
            {
                BMBParameters.BMBИндикаторНаборКоманды += "1";
                BMBParameters.BMBИндикаторНаборКоманды =
                    BMBParameters.BMBИндикаторНаборКоманды.Substring(BMBParameters.BMBИндикаторНаборКоманды.Length - 2,
                        2);
                this.BMBИндикаторНаборКоманды.Text = BMBParameters.BMBИндикаторНаборКоманды;
            }

        }

        private void BMBКнопкаНаборКоманды1_MouseUp(object sender, MouseEventArgs e)
        {
            this.BMBКнопкаНаборКоманды1.BackgroundImage = ControlElementImages.buttonSquareBlue;
            this.BMBКнопкаНаборКоманды1.Text = "1";
        }

        private void BMBКнопкаНаборКоманды2_MouseDown(object sender, MouseEventArgs e)
        {
            this.BMBКнопкаНаборКоманды2.BackgroundImage = null;
            this.BMBКнопкаНаборКоманды2.Text = string.Empty;

            if (BMBParameters.BMBИндикаторНаборКоманды[1] <= '2' && BMBParameters.BMBКнопкаПитание)
            {
                BMBParameters.BMBИндикаторНаборКоманды += "2";
                BMBParameters.BMBИндикаторНаборКоманды =
                    BMBParameters.BMBИндикаторНаборКоманды.Substring(BMBParameters.BMBИндикаторНаборКоманды.Length - 2,
                        2);
                this.BMBИндикаторНаборКоманды.Text = BMBParameters.BMBИндикаторНаборКоманды;
            }
        }

        private void BMBКнопкаНаборКоманды2_MouseUp(object sender, MouseEventArgs e)
        {
            this.BMBКнопкаНаборКоманды2.BackgroundImage = ControlElementImages.buttonSquareBlue;
            this.BMBКнопкаНаборКоманды2.Text = "2";
        }

        private void BMBКнопкаНаборКоманды3_MouseDown(object sender, MouseEventArgs e)
        {
            this.BMBКнопкаНаборКоманды3.BackgroundImage = null;
            this.BMBКнопкаНаборКоманды3.Text = string.Empty;

            if (BMBParameters.BMBИндикаторНаборКоманды[1] <= '2' && BMBParameters.BMBКнопкаПитание)
            {
                BMBParameters.BMBИндикаторНаборКоманды += "3";
                BMBParameters.BMBИндикаторНаборКоманды =
                    BMBParameters.BMBИндикаторНаборКоманды.Substring(BMBParameters.BMBИндикаторНаборКоманды.Length - 2,
                        2);
                this.BMBИндикаторНаборКоманды.Text = BMBParameters.BMBИндикаторНаборКоманды;
            }
        }

        private void BMBКнопкаНаборКоманды3_MouseUp(object sender, MouseEventArgs e)
        {
            this.BMBКнопкаНаборКоманды3.BackgroundImage = ControlElementImages.buttonSquareBlue;
            this.BMBКнопкаНаборКоманды3.Text = "3";
        }

        private void BMBКнопкаНаборКоманды4_MouseDown(object sender, MouseEventArgs e)
        {
            this.BMBКнопкаНаборКоманды4.BackgroundImage = null;
            this.BMBКнопкаНаборКоманды4.Text = string.Empty;

            if (BMBParameters.BMBИндикаторНаборКоманды[1] <= '2' && BMBParameters.BMBКнопкаПитание)
            {
                BMBParameters.BMBИндикаторНаборКоманды += "4";
                BMBParameters.BMBИндикаторНаборКоманды =
                    BMBParameters.BMBИндикаторНаборКоманды.Substring(BMBParameters.BMBИндикаторНаборКоманды.Length - 2,
                        2);
                this.BMBИндикаторНаборКоманды.Text = BMBParameters.BMBИндикаторНаборКоманды;
            }
        }

        private void BMBКнопкаНаборКоманды4_MouseUp(object sender, MouseEventArgs e)
        {
            this.BMBКнопкаНаборКоманды4.BackgroundImage = ControlElementImages.buttonSquareBlue;
            this.BMBКнопкаНаборКоманды4.Text = "4";
        }

        private void BMBКнопкаНаборКоманды5_MouseDown(object sender, MouseEventArgs e)
        {
            this.BMBКнопкаНаборКоманды5.BackgroundImage = null;
            this.BMBКнопкаНаборКоманды5.Text = string.Empty;

            if (BMBParameters.BMBИндикаторНаборКоманды[1] <= '2' && BMBParameters.BMBКнопкаПитание)
            {
                BMBParameters.BMBИндикаторНаборКоманды += "5";
                BMBParameters.BMBИндикаторНаборКоманды =
                    BMBParameters.BMBИндикаторНаборКоманды.Substring(BMBParameters.BMBИндикаторНаборКоманды.Length - 2,
                        2);
                this.BMBИндикаторНаборКоманды.Text = BMBParameters.BMBИндикаторНаборКоманды;
            }
        }

        private void BMBКнопкаНаборКоманды5_MouseUp(object sender, MouseEventArgs e)
        {
            this.BMBКнопкаНаборКоманды5.BackgroundImage = ControlElementImages.buttonSquareBlue;
            this.BMBКнопкаНаборКоманды5.Text = "5";
        }

        private void BMBКнопкаНаборКоманды6_MouseDown(object sender, MouseEventArgs e)
        {
            this.BMBКнопкаНаборКоманды6.BackgroundImage = null;
            this.BMBКнопкаНаборКоманды6.Text = string.Empty;

            if (BMBParameters.BMBИндикаторНаборКоманды[1] <= '2' && BMBParameters.BMBКнопкаПитание)
            {
                BMBParameters.BMBИндикаторНаборКоманды += "6";
                BMBParameters.BMBИндикаторНаборКоманды =
                    BMBParameters.BMBИндикаторНаборКоманды.Substring(BMBParameters.BMBИндикаторНаборКоманды.Length - 2,
                        2);
                this.BMBИндикаторНаборКоманды.Text = BMBParameters.BMBИндикаторНаборКоманды;
            }
        }

        private void BMBКнопкаНаборКоманды6_MouseUp(object sender, MouseEventArgs e)
        {
            this.BMBКнопкаНаборКоманды6.BackgroundImage = ControlElementImages.buttonSquareBlue;
            this.BMBКнопкаНаборКоманды6.Text = "6";
        }

        private void BMBКнопкаНаборКоманды7_MouseDown(object sender, MouseEventArgs e)
        {
            this.BMBКнопкаНаборКоманды7.BackgroundImage = null;
            this.BMBКнопкаНаборКоманды7.Text = string.Empty;

            if (BMBParameters.BMBИндикаторНаборКоманды[1] <= '2' && BMBParameters.BMBКнопкаПитание)
            {
                BMBParameters.BMBИндикаторНаборКоманды += "7";
                BMBParameters.BMBИндикаторНаборКоманды =
                    BMBParameters.BMBИндикаторНаборКоманды.Substring(BMBParameters.BMBИндикаторНаборКоманды.Length - 2,
                        2);
                this.BMBИндикаторНаборКоманды.Text = BMBParameters.BMBИндикаторНаборКоманды;
            }
        }

        private void BMBКнопкаНаборКоманды7_MouseUp(object sender, MouseEventArgs e)
        {
            this.BMBКнопкаНаборКоманды7.BackgroundImage = ControlElementImages.buttonSquareBlue;
            this.BMBКнопкаНаборКоманды7.Text = "7";
        }

        private void BMBКнопкаНаборКоманды8_MouseDown(object sender, MouseEventArgs e)
        {
            this.BMBКнопкаНаборКоманды8.BackgroundImage = null;
            this.BMBКнопкаНаборКоманды8.Text = string.Empty;

            if (BMBParameters.BMBИндикаторНаборКоманды[1] <= '2' && BMBParameters.BMBКнопкаПитание)
            {
                BMBParameters.BMBИндикаторНаборКоманды += "8";
                BMBParameters.BMBИндикаторНаборКоманды =
                    BMBParameters.BMBИндикаторНаборКоманды.Substring(BMBParameters.BMBИндикаторНаборКоманды.Length - 2,
                        2);
                this.BMBИндикаторНаборКоманды.Text = BMBParameters.BMBИндикаторНаборКоманды;
            }
        }

        private void BMBКнопкаНаборКоманды8_MouseUp(object sender, MouseEventArgs e)
        {
            this.BMBКнопкаНаборКоманды8.BackgroundImage = ControlElementImages.buttonSquareBlue;
            this.BMBКнопкаНаборКоманды8.Text = "8";
        }

        private void BMBКнопкаНаборКоманды9_MouseDown(object sender, MouseEventArgs e)
        {
            this.BMBКнопкаНаборКоманды9.BackgroundImage = null;
            this.BMBКнопкаНаборКоманды9.Text = string.Empty;

            if (BMBParameters.BMBИндикаторНаборКоманды[1] <= '2' && BMBParameters.BMBКнопкаПитание)
            {
                BMBParameters.BMBИндикаторНаборКоманды += "9";
                BMBParameters.BMBИндикаторНаборКоманды =
                    BMBParameters.BMBИндикаторНаборКоманды.Substring(BMBParameters.BMBИндикаторНаборКоманды.Length - 2,
                        2);
                this.BMBИндикаторНаборКоманды.Text = BMBParameters.BMBИндикаторНаборКоманды;
            }
        }

        private void BMBКнопкаНаборКоманды9_MouseUp(object sender, MouseEventArgs e)
        {
            this.BMBКнопкаНаборКоманды9.BackgroundImage = ControlElementImages.buttonSquareBlue;
            this.BMBКнопкаНаборКоманды9.Text = "9";
        }

        private void BMBКнопкаНаборКоманды0_MouseDown(object sender, MouseEventArgs e)
        {
            this.BMBКнопкаНаборКоманды0.BackgroundImage = null;
            this.BMBКнопкаНаборКоманды0.Text = string.Empty;

            if (BMBParameters.BMBИндикаторНаборКоманды[1] <= '2' && BMBParameters.BMBКнопкаПитание)
            {
                BMBParameters.BMBИндикаторНаборКоманды += "0";
                BMBParameters.BMBИндикаторНаборКоманды =
                    BMBParameters.BMBИндикаторНаборКоманды.Substring(BMBParameters.BMBИндикаторНаборКоманды.Length - 2,
                        2);
                this.BMBИндикаторНаборКоманды.Text = BMBParameters.BMBИндикаторНаборКоманды;
            }
        }

        private void BMBКнопкаНаборКоманды0_MouseUp(object sender, MouseEventArgs e)
        {
            this.BMBКнопкаНаборКоманды0.BackgroundImage = ControlElementImages.buttonSquareBlue;
            this.BMBКнопкаНаборКоманды0.Text = "0";
        }

        private void BMBКнопкаПередачаКоманды_MouseDown(object sender, MouseEventArgs e)
        {
            this.BMBКнопкаПередачаКоманды.BackgroundImage = null;
            this.BMBКнопкаПередачаКоманды.Text = string.Empty;

        }

        private void BMBКнопкаПередачаКоманды_MouseUp(object sender, MouseEventArgs e)
        {
            this.BMBКнопкаПередачаКоманды.BackgroundImage = ControlElementImages.buttonSquareBlue;
            this.BMBКнопкаПередачаКоманды.Text = "ВКЛ";
        }

        private void BMBКнопкаПередачаВызоваДК_Click(object sender, System.EventArgs e)
        {
            if (BMBParameters.BMBКнопкаПередачаВызоваДК)
            {
                this.BMBКнопкаПередачаВызоваДК.BackgroundImage = ControlElementImages.buttonSquareYellow1;
                this.BMBКнопкаПередачаВызоваДК.Text = "ДК";
                BMBParameters.BMBЛампочкаДК = false;
                this.BMBЛампочкаДК.BackgroundImage = null;
            }
            else
            {
                this.BMBКнопкаПередачаВызоваДК.BackgroundImage = null;
                this.BMBКнопкаПередачаВызоваДК.Text = string.Empty;
                if (BMBParameters.BMBКнопкаПитание)
                {
                    BMBParameters.BMBЛампочкаДК = true;
                    this.BMBЛампочкаДК.BackgroundImage = ControlElementImages.lampType7OnRed;
                }
            }
            BMBParameters.BMBКнопкаПередачаВызоваДК = !BMBParameters.BMBКнопкаПередачаВызоваДК;
        }

        private void BMBКнопкаПередачаВызоваТЧ_Click(object sender, System.EventArgs e)
        {
            if (BMBParameters.BMBКнопкаПередачаВызоваТЧ)
            {
                this.BMBКнопкаПередачаВызоваТЧ.BackgroundImage = ControlElementImages.buttonSquareYellow1;
                this.BMBКнопкаПередачаВызоваТЧ.Text = "ТЧ";
                BMBParameters.BMBЛампочкаТЧ = false;
                this.BMBЛампочкаТЧ.BackgroundImage = null;
            }
            else
            {
                this.BMBКнопкаПередачаВызоваТЧ.BackgroundImage = null;
                this.BMBКнопкаПередачаВызоваТЧ.Text = string.Empty;
                if (BMBParameters.BMBКнопкаПитание)
                {
                    BMBParameters.BMBЛампочкаТЧ = true;
                    this.BMBЛампочкаТЧ.BackgroundImage = ControlElementImages.lampType7OnRed;
                }
            }
            BMBParameters.BMBКнопкаПередачаВызоваТЧ = !BMBParameters.BMBКнопкаПередачаВызоваТЧ;
        }

        private void BMBКнопкаСлСвязь_Click(object sender, System.EventArgs e)
        {
            if (BMBParameters.BMBКнопкаСлСвязь)
            {
                this.BMBКнопкаСлСвязь.BackgroundImage = ControlElementImages.buttonSquareYellow1;
                this.BMBКнопкаСлСвязь.Text = "ВКЛ";
            }
            else
            {
                this.BMBКнопкаСлСвязь.BackgroundImage = null;
                this.BMBКнопкаСлСвязь.Text = string.Empty;
            }
            BMBParameters.BMBКнопкаСлСвязь = !BMBParameters.BMBКнопкаСлСвязь;
        }

        private void BMBКнопкаПитание_Click(object sender, System.EventArgs e)
        {
            if (BMBParameters.BMBКнопкаПитание)
            {
                this.BMBКнопкаПитание.BackgroundImage = ControlElementImages.buttonSquareGreen;
                this.BMBКнопкаПитание.Text = "ВКЛ";

                BMBParameters.BMBИндикаторНаборКоманды = "  ";
                this.BMBИндикаторНаборКоманды.Text = BMBParameters.BMBИндикаторНаборКоманды;
                BMBParameters.BMBИндикаторПриемКоманды = "  ";
                this.BMBИндикаторПриемКоманды.Text = BMBParameters.BMBИндикаторПриемКоманды;
            }
            else
            {
                this.BMBКнопкаПитание.BackgroundImage = null;
                this.BMBКнопкаПитание.Text = string.Empty;
            }
            BMBParameters.BMBКнопкаПитание = !BMBParameters.BMBКнопкаПитание;
        }

        private void BMBКнопкаЗвСигнал_Click(object sender, System.EventArgs e)
        {
            if (BMBParameters.BMBКнопкаЗвСигнал)
            {
                this.BMBКнопкаЗвСигнал.BackgroundImage = ControlElementImages.buttonSquareGreen;
                this.BMBКнопкаЗвСигнал.Text = " ЗВ СИГН";
            }
            else
            {
                this.BMBКнопкаЗвСигнал.BackgroundImage = null;
                this.BMBКнопкаЗвСигнал.Text = string.Empty;
            }
            BMBParameters.BMBКнопкаЗвСигнал = !BMBParameters.BMBКнопкаЗвСигнал;
        }
#endregion

        #region Переключатели

        private void BMBПереключательРаботаКонтроль_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BMBParameters.BMBПереключательРаботаКонтроль += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                BMBParameters.BMBПереключательРаботаКонтроль -= 1;
            }

            var angle = BMBParameters.BMBПереключательРаботаКонтроль * 30 - 45;
            BMBПереключательРаботаКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

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
            if (BMBParameters.BMBКнопкаПередачаВызоваДК)
            {
                this.BMBКнопкаПередачаВызоваДК.BackgroundImage = null;
                this.BMBКнопкаПередачаВызоваДК.Text = string.Empty;
                BMBParameters.BMBЛампочкаДК = true;
                this.BMBЛампочкаДК.BackgroundImage = ControlElementImages.lampType7OnRed;
            }
            else
            {
                this.BMBКнопкаПередачаВызоваДК.BackgroundImage = ControlElementImages.buttonSquareYellow1;
                this.BMBКнопкаПередачаВызоваДК.Text = "ДК";
                BMBParameters.BMBЛампочкаДК = false;
                this.BMBЛампочкаДК.BackgroundImage = null;
            }

            if (BMBParameters.BMBКнопкаПередачаВызоваТЧ)
            {
                this.BMBКнопкаПередачаВызоваТЧ.BackgroundImage = null;
                this.BMBКнопкаПередачаВызоваТЧ.Text = string.Empty;
                BMBParameters.BMBЛампочкаТЧ = true;
                this.BMBЛампочкаТЧ.BackgroundImage = ControlElementImages.lampType7OnRed;
            }
            else
            {
                this.BMBКнопкаПередачаВызоваТЧ.BackgroundImage = ControlElementImages.buttonSquareYellow1;
                this.BMBКнопкаПередачаВызоваТЧ.Text = "ТЧ";
                BMBParameters.BMBЛампочкаТЧ = false;
                this.BMBЛампочкаТЧ.BackgroundImage = null;
            }

            if (BMBParameters.BMBКнопкаСлСвязь)
            {
                this.BMBКнопкаСлСвязь.BackgroundImage = null;
                this.BMBКнопкаСлСвязь.Text = string.Empty;
            }
            else
            {
                this.BMBКнопкаСлСвязь.BackgroundImage = ControlElementImages.buttonSquareYellow1;
                this.BMBКнопкаСлСвязь.Text = "ВКЛ";
            }


            if (BMBParameters.BMBКнопкаПитание)
            {
                this.BMBКнопкаПитание.BackgroundImage = null;
                this.BMBКнопкаПитание.Text = string.Empty;
            }
            else
            {
                this.BMBКнопкаПитание.BackgroundImage = ControlElementImages.buttonSquareGreen;
                this.BMBКнопкаПитание.Text = "ВКЛ";
            }

            if (BMBParameters.BMBКнопкаЗвСигнал)
            {
                this.BMBКнопкаЗвСигнал.BackgroundImage = null;
                this.BMBКнопкаЗвСигнал.Text = string.Empty;
            }
            else
            {
                this.BMBКнопкаЗвСигнал.BackgroundImage = ControlElementImages.buttonSquareGreen;
                this.BMBКнопкаЗвСигнал.Text = " ЗВ СИГН";
            }
        }

        private void InitializeTogglesPosition()
        {
            var angle = BMBParameters.BMBПереключательРаботаКонтроль * 30 - 45;
            BMBПереключательРаботаКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = BMBParameters.BMBПереключательПодключениеРезерва * 40 - 80;
            BMBПереключательПодключениеРезерва.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = BMBParameters.BMBПереключательНаправление * 30 - 75;
            BMBПереключательНаправление.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void InitializeIndicatorsPosition()
        {
            BMBИндикаторНаборКоманды.Text = BMBParameters.BMBИндикаторНаборКоманды;
            BMBИндикаторПриемКоманды.Text = BMBParameters.BMBИндикаторПриемКоманды;
        }

    }
}