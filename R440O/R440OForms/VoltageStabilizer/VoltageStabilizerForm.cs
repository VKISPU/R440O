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
            this.InitializeLamps();
        }

        /// <summary>
        /// Обработка клика на кабельный вход 220В.
        /// Если питание отключено, оно будет установлено на 220В.
        /// Если питание установлено на 220В, то оно будет отключено.
        /// Если питание установлено на 380В, то оно будет переключено на 220В.
        /// </summary>
        private void VoltageStabilizerКабельВход1_Click(object sender, System.EventArgs e)
        {
            switch (VoltageStabilizerParameters.VoltageStabilizerКабельВход)
            {
                case "0":
                    VoltageStabilizerКабельВход1.BackgroundImage = ControlElementImages.voltageStabilizerInput;
                    VoltageStabilizerParameters.VoltageStabilizerКабельВход = "220";
                    break;
                case "220":
                    VoltageStabilizerКабельВход1.BackgroundImage = null;
                    VoltageStabilizerParameters.VoltageStabilizerКабельВход = "0";
                    break;
                case "380":
                    VoltageStabilizerКабельВход1.BackgroundImage = ControlElementImages.voltageStabilizerInput;
                    VoltageStabilizerКабельВход2.BackgroundImage = null;
                    VoltageStabilizerParameters.VoltageStabilizerКабельВход = "220";
                    break;
            }
        }

        /// <summary>
        /// Обработка клика на кабельный вход 380В.
        /// Если питание отключено, оно будет установлено на 380В.
        /// Если питание установлено на 380В, то оно будет отключено.
        /// Если питание установлено на 220В, то оно будет переключено на 380В.
        /// </summary>
        private void VoltageStabilizerКабельВход2_Click(object sender, System.EventArgs e)
        {
            switch (VoltageStabilizerParameters.VoltageStabilizerКабельВход)
            {
                case "0":
                    VoltageStabilizerКабельВход2.BackgroundImage = ControlElementImages.voltageStabilizerInput;
                    VoltageStabilizerParameters.VoltageStabilizerКабельВход = "380";
                    break;
                case "220":
                    VoltageStabilizerКабельВход1.BackgroundImage = null;
                    VoltageStabilizerКабельВход2.BackgroundImage = ControlElementImages.voltageStabilizerInput;
                    VoltageStabilizerParameters.VoltageStabilizerКабельВход = "380";    
                    break;
                case "380":
                    VoltageStabilizerКабельВход2.BackgroundImage = null;
                    VoltageStabilizerParameters.VoltageStabilizerКабельВход = "0";
                    break;
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
            switch (VoltageStabilizerParameters.VoltageStabilizerКабельВход)
            {
                case "0":
                    VoltageStabilizerКабельВход1.BackgroundImage = null;
                    VoltageStabilizerКабельВход2.BackgroundImage = null;
                    break;
                case "220":
                    VoltageStabilizerКабельВход1.BackgroundImage = ControlElementImages.voltageStabilizerInput;
                    VoltageStabilizerКабельВход2.BackgroundImage = null;
                    break;
                case "380":
                    VoltageStabilizerКабельВход1.BackgroundImage = null;
                    VoltageStabilizerКабельВход2.BackgroundImage = ControlElementImages.voltageStabilizerInput;
                    break;
            }
            var angle = VoltageStabilizerParameters.VoltageStabilizerПереключательКонтрольНапр * 30 - 195;
            VoltageStabilizerПереключательКонтрольНапр.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
        }

        private void InitializeLamps()
        {
            VoltageStabilizerЛампочкаСетьВкл.BackgroundImage = VoltageStabilizerParameters.VoltageStabilizerЛампочкаСетьВкл
                ? ControlElementImages.lampType9OnGreen
                : null;

            VoltageStabilizerЛампочкаАвария.BackgroundImage = VoltageStabilizerParameters.VoltageStabilizerЛампочкаАвария
                ? ControlElementImages.lampType6OnRed
                : null;
        }
    }
}