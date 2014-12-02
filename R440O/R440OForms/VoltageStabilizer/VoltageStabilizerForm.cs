//-----------------------------------------------------------------------
// <copyright file="VoltageStabilizerForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.VoltageStabilizer
{
    using System.Windows.Forms;
    using Parameters;
    using ThirdParty;

    /// <summary>
    /// Форма блока стабилизатор напряжения
    /// </summary>
    public partial class VoltageStabilizerForm : Form
    {      
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="VoltageStabilizerForm"/>
        /// </summary>
        public VoltageStabilizerForm()
        {
            this.InitializeComponent();
            this.InitializeTogglePosition();
        }
        
        /// <summary>
        /// Если в текущий момент времени включено питание 380, а клик происходит по месту,
        /// где находится вход для кабеля 220 вольт - кабель переключается на 220.
        /// </summary>
        private void VoltageStabilizerКабельВход1_Click(object sender, System.EventArgs e)
        {
            if (VoltageStabilizerParameters.VoltageStabilizerКабельВход == "380")
            {
                this.VoltageStabilizerКабельВход1.BackgroundImage = ControlElementImages.voltageStabilizerInput;
                this.VoltageStabilizerКабельВход2.BackgroundImage = null;
                VoltageStabilizerParameters.VoltageStabilizerКабельВход = "220";
            }
        }

        /// <summary>
        /// Если в текущий момент времени включено питание 220, а клик происходит по месту,
        /// где находится вход для кабеля 380 вольт - кабель переключается на 380.
        /// </summary>
        private void VoltageStabilizerКабельВход2_Click(object sender, System.EventArgs e)
        {
            if (VoltageStabilizerParameters.VoltageStabilizerКабельВход == "220")
            {
                this.VoltageStabilizerКабельВход1.BackgroundImage = null;
                this.VoltageStabilizerКабельВход2.BackgroundImage = ControlElementImages.voltageStabilizerInput;
                VoltageStabilizerParameters.VoltageStabilizerКабельВход = "380";
            }
        }

        /// <summary>
        /// Переключатель КонтрольНапряжения
        /// </summary>
        private void VoltageStabilizerПереключательКонтрольНапр_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                VoltageStabilizerParameters.VoltageStabilizerПереключательКонтрольНапр += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                VoltageStabilizerParameters.VoltageStabilizerПереключательКонтрольНапр -= 1;
            }

            var angle = VoltageStabilizerParameters.VoltageStabilizerПереключательКонтрольНапр * 30 - 195;
            VoltageStabilizerПереключательКонтрольНапр.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
        }

        /// <summary>
        /// Инициализация начальных положений переключателей, а также
        /// восстановление положений при повторном открытии формы
        /// </summary>
        private void InitializeTogglePosition()
        {
            if (VoltageStabilizerParameters.VoltageStabilizerКабельВход == "220")
            {
                this.VoltageStabilizerКабельВход1.BackgroundImage = ControlElementImages.voltageStabilizerInput;
                this.VoltageStabilizerКабельВход2.BackgroundImage = null;
            }
            else
            {
                this.VoltageStabilizerКабельВход1.BackgroundImage = null;
                this.VoltageStabilizerКабельВход2.BackgroundImage = ControlElementImages.voltageStabilizerInput;
            }

            var angle = VoltageStabilizerParameters.VoltageStabilizerПереключательКонтрольНапр * 30 - 195;
            VoltageStabilizerПереключательКонтрольНапр.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);      
        }
    }
}