//-----------------------------------------------------------------------
// <copyright file="VoltageStabilizerForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using R440O.Parameters;

namespace R440O.R440OForms.VoltageStabilizer
{
    using System.Windows.Forms;

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
            VoltageStabilizerParameters.VoltageStabilizerКабельВход = "220";
        }

        private void VoltageStabilizerКабельВход1_Click(object sender, System.EventArgs e)
        {
            if (VoltageStabilizerParameters.VoltageStabilizerКабельВход == "380")
            {
                this.VoltageStabilizerКабельВход2.BackgroundImage = null;
                this.VoltageStabilizerКабельВход1.BackgroundImage = ControlElementImages.voltageStabilizerInput;
                VoltageStabilizerParameters.VoltageStabilizerКабельВход = "220";
            }
        }

        private void VoltageStabilizerКабельВход2_Click(object sender, System.EventArgs e)
        {
            if (VoltageStabilizerParameters.VoltageStabilizerКабельВход == "220")
            {
                this.VoltageStabilizerКабельВход1.BackgroundImage = null;
                this.VoltageStabilizerКабельВход2.BackgroundImage = ControlElementImages.voltageStabilizerInput;
                VoltageStabilizerParameters.VoltageStabilizerКабельВход = "380";
            }
        }
    }
}