//-----------------------------------------------------------------------
// <copyright file="N18_MForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using R440O.Parameters;
using R440O.ThirdParty;

namespace R440O.R440OForms.N18_M
{
    using System.Windows.Forms;

    /// <summary>
    /// Форма блока Н-18-М
    /// </summary>
    public partial class N18_MForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="N18_MForm"/>
        /// </summary>
        public N18_MForm()
        {
            this.InitializeComponent();
            InitializeTogglesPosition();
        }

        #region Тумблеры
        private void N18_MТумблерДАБ5_Click(object sender, System.EventArgs e)
        {
            if (N18_MParameters.N18_MТумблерДАБ5 == "прм-1")
            {
                this.N18_MТумблерДАБ5.BackgroundImage = ControlElementImages.tumblerHorizontalType5Right;
                N18_MParameters.N18_MТумблерДАБ5 = "прм-2";
            }
            else
            {
                this.N18_MТумблерДАБ5.BackgroundImage = ControlElementImages.tumblerHorizontalType5Left;
                N18_MParameters.N18_MТумблерДАБ5 = "прм-1";
            }
        }

        private void N18_MТумблерКАУ_ПРМ_Click(object sender, System.EventArgs e)
        {
            if (N18_MParameters.N18_MТумблерКАУ_ПРМ == "б1-1")
            {
                this.N18_MТумблерКАУ_ПРМ.BackgroundImage = ControlElementImages.tumblerHorizontalType5Right;
                N18_MParameters.N18_MТумблерКАУ_ПРМ = "б3-1";
            }
            else
            {
                this.N18_MТумблерКАУ_ПРМ.BackgroundImage = ControlElementImages.tumblerHorizontalType5Left;
                N18_MParameters.N18_MТумблерКАУ_ПРМ = "б1-1";
            }
        }

        private void N18_MТумблерПРД_СС_Click(object sender, System.EventArgs e)
        {
            if (N18_MParameters.N18_MТумблерПРД_СС == "контур-П")
            {
                this.N18_MТумблерПРД_СС.BackgroundImage = ControlElementImages.tumblerHorizontalType5Right;
                N18_MParameters.N18_MТумблерПРД_СС = "ЩВ";
            }
            else
            {
                this.N18_MТумблерПРД_СС.BackgroundImage = ControlElementImages.tumblerHorizontalType5Left;
                N18_MParameters.N18_MТумблерПРД_СС = "контур-П";
            }
        }

        private void N18_MТумблерТЛФ_ПРМ_Click(object sender, System.EventArgs e)
        {
            if (N18_MParameters.N18_MТумблерТЛФ_ПРМ == "осн")
            {
                this.N18_MТумблерТЛФ_ПРМ.BackgroundImage = ControlElementImages.tumblerHorizontalType5Right;
                N18_MParameters.N18_MТумблерТЛФ_ПРМ = "резерв";
            }
            else
            {
                this.N18_MТумблерТЛФ_ПРМ.BackgroundImage = ControlElementImages.tumblerHorizontalType5Left;
                N18_MParameters.N18_MТумблерТЛФ_ПРМ = "осн";
            }
        }
        #endregion

        #region Переключатели
        private void N18_MПереключательПРМ1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N18_MParameters.N18_MПереключательПРМ1 += 1;
            }
            if (e.Button == MouseButtons.Right)
            {
                N18_MParameters.N18_MПереключательПРМ1 -= 1;
            }

            var angle = N18_MParameters.N18_MПереключательПРМ1 * 40 - 120;
            N18_MПереключательПРМ1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void N18_MПереключательПРМ2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N18_MParameters.N18_MПереключательПРМ2 += 1;
            }
            if (e.Button == MouseButtons.Right)
            {
                N18_MParameters.N18_MПереключательПРМ2 -= 1;
            }

            var angle = N18_MParameters.N18_MПереключательПРМ2 * 40 - 120;
            N18_MПереключательПРМ2.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }
        #endregion

        #region Инициализация
        private void InitializeTogglesPosition()
        {
            var angle = N18_MParameters.N18_MПереключательПРМ1 * 40 - 120;
            N18_MПереключательПРМ1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.N18_MПереключательПРМ2 * 40 - 120;
            N18_MПереключательПРМ2.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }
        #endregion
    }
}