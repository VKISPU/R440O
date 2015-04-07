//-----------------------------------------------------------------------
// <copyright file="N18_MForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.N18_M
{
    using System.Windows.Forms;
    using Parameters;
    using ThirdParty;

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
            this.InitializeTogglesPosition();
            this.InitializeTumblersPosition();
        }

        #region Тумблеры
        private void N18_MТумблерДАБ5_Click(object sender, System.EventArgs e)
        {
            if (N18_MParameters.N18_MТумблерДАБ5 == "прм-1")
            {
                this.N18_MТумблерДАБ5.BackgroundImage = ControlElementImages.tumblerType5Right;
                N18_MParameters.N18_MТумблерДАБ5 = "прм-2";
            }
            else
            {
                this.N18_MТумблерДАБ5.BackgroundImage = ControlElementImages.tumblerType5Left;
                N18_MParameters.N18_MТумблерДАБ5 = "прм-1";
            }
        }

        private void N18_MТумблерКАУ_ПРМ_Click(object sender, System.EventArgs e)
        {
            if (N18_MParameters.N18_MТумблерКАУ_ПРМ == "б1-1")
            {
                this.N18_MТумблерКАУ_ПРМ.BackgroundImage = ControlElementImages.tumblerType5Right;
                N18_MParameters.N18_MТумблерКАУ_ПРМ = "б3-1";
            }
            else
            {
                this.N18_MТумблерКАУ_ПРМ.BackgroundImage = ControlElementImages.tumblerType5Left;
                N18_MParameters.N18_MТумблерКАУ_ПРМ = "б1-1";
            }
        }

        private void N18_MТумблерПРД_СС_Click(object sender, System.EventArgs e)
        {
            if (N18_MParameters.N18_MТумблерПРД_СС == "контур-П")
            {
                this.N18_MТумблерПРД_СС.BackgroundImage = ControlElementImages.tumblerType5Right;
                N18_MParameters.N18_MТумблерПРД_СС = "щв";
            }
            else
            {
                this.N18_MТумблерПРД_СС.BackgroundImage = ControlElementImages.tumblerType5Left;
                N18_MParameters.N18_MТумблерПРД_СС = "контур-П";
            }
        }

        private void N18_MТумблерТЛФ_ПРМ_Click(object sender, System.EventArgs e)
        {
            if (N18_MParameters.N18_MТумблерТЛФ_ПРМ == "осн")
            {
                this.N18_MТумблерТЛФ_ПРМ.BackgroundImage = ControlElementImages.tumblerType5Right;
                N18_MParameters.N18_MТумблерТЛФ_ПРМ = "резерв";
            }
            else
            {
                this.N18_MТумблерТЛФ_ПРМ.BackgroundImage = ControlElementImages.tumblerType5Left;
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

        private void N18_MПереключательВходК1_2_1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N18_MParameters.N18MПереключательВходК121 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N18_MParameters.N18MПереключательВходК121 -= 1;
            }

            var angle = N18_MParameters.N18MПереключательВходК121 * 40 - 120;
            N18_MПереключательВходК1_2_1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void N18_MПереключательПРД_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N18_MParameters.N18_MПереключательПРД += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N18_MParameters.N18_MПереключательПРД -= 1;
            }

            var angle = N18_MParameters.N18_MПереключательПРД * 40 - 120;
            N18_MПереключательПРД.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void N18_MПереключательПРДБМА12_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N18_MParameters.N18_MПереключательПРДБМА12 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N18_MParameters.N18_MПереключательПРДБМА12 -= 1;
            }

            var angle = N18_MParameters.N18_MПереключательПРДБМА12 * 28 - 180;
            if (N18_MParameters.N18_MПереключательПРДБМА12 == 6) angle += 12;
            else if (N18_MParameters.N18_MПереключательПРДБМА12 > 6) angle += 28;   ////Смещение
            N18_MПереключательПРДБМА12.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void N18_MПереключательПРМСС1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N18_MParameters.N18_MПереключательПРМСС1 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N18_MParameters.N18_MПереключательПРМСС1 -= 1;
            }

            var angle = N18_MParameters.N18_MПереключательПРМСС1 * 40 - 120;
            N18_MПереключательПРМСС1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void N18_MПереключательПРМСС2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N18_MParameters.N18_MПереключательПРМСС2 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N18_MParameters.N18_MПереключательПРМСС2 -= 1;
            }

            var angle = N18_MParameters.N18_MПереключательПРМСС2 * 40 - 120;
            N18_MПереключательПРМСС2.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void N18_MПереключатель48ПРМЩВ_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N18_MParameters.N18_MПереключатель48ПРМЩВ += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N18_MParameters.N18_MПереключатель48ПРМЩВ -= 1;
            }

            var angle = N18_MParameters.N18_MПереключатель48ПРМЩВ * 50 - 75;
            N18_MПереключатель48ПРМЩВ.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void N18_MПереключательВыход2РН_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N18_MParameters.N18_MПереключательВыход2РН += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N18_MParameters.N18_MПереключательВыход2РН -= 1;
            }

            var angle = N18_MParameters.N18_MПереключательВыход2РН * 50 - 75;
            N18_MПереключательВыход2РН.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void N18_MПереключательВыход1РН_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N18_MParameters.N18_MПереключательВыход1РН += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N18_MParameters.N18_MПереключательВыход1РН -= 1;
            }

            var angle = N18_MParameters.N18_MПереключательВыход1РН * 50 - 75;
            N18_MПереключательВыход1РН.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void N18_MПереключательВходБ22_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N18_MParameters.N18_MПереключательВходБ22 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N18_MParameters.N18_MПереключательВходБ22 -= 1;
            }

            var angle = N18_MParameters.N18_MПереключательВходБ22 * 50 - 75;
            N18_MПереключательВходБ22.BackgroundImage =
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

            angle = N18_MParameters.N18MПереключательВходК121 * 40 - 120;
            N18_MПереключательВходК1_2_1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.N18_MПереключательПРД * 40 - 120;
            N18_MПереключательПРД.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.N18_MПереключательПРДБМА12 * 28 - 180;
            if (N18_MParameters.N18_MПереключательПРДБМА12 == 6) angle += 12;
            else if (N18_MParameters.N18_MПереключательПРДБМА12 > 6) angle += 28;   ////Смещение
            N18_MПереключательПРДБМА12.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.N18_MПереключательПРМСС1 * 40 - 120;
            N18_MПереключательПРД.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.N18_MПереключатель48ПРМЩВ * 50 - 75;
            N18_MПереключатель48ПРМЩВ.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.N18_MПереключательВыход2РН * 50 - 75;
            N18_MПереключательВыход2РН.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.N18_MПереключательВыход1РН * 50 - 75;
            N18_MПереключательВыход1РН.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.N18_MПереключательВходБ22 * 50 - 75;
            N18_MПереключательВходБ22.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void InitializeTumblersPosition()
        {
            this.N18_MТумблерДАБ5.BackgroundImage = N18_MParameters.N18_MТумблерДАБ5 == "прм-1"
                ? ControlElementImages.tumblerType5Left
                : ControlElementImages.tumblerType5Right;

            this.N18_MТумблерКАУ_ПРМ.BackgroundImage = N18_MParameters.N18_MТумблерКАУ_ПРМ == "б1-1"
                ? ControlElementImages.tumblerType5Left
                : ControlElementImages.tumblerType5Right;

            this.N18_MТумблерПРД_СС.BackgroundImage = N18_MParameters.N18_MТумблерПРД_СС == "контур-П"
                ? ControlElementImages.tumblerType5Left
                : ControlElementImages.tumblerType5Right;

            this.N18_MТумблерТЛФ_ПРМ.BackgroundImage = N18_MParameters.N18_MТумблерТЛФ_ПРМ == "осн"
                ? ControlElementImages.tumblerType5Left
                : ControlElementImages.tumblerType5Right;
        }
        #endregion
    }
}