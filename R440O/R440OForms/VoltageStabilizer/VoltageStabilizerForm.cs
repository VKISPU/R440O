//-----------------------------------------------------------------------
// <copyright file="VoltageStabilizerForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using R440O.Parameters;

namespace R440O.R440OForms.VoltageStabilizer
{
    using System.Windows.Forms;
    using System.Drawing;

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

        public float angle = 15;

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

        private void VoltageStabilizerПереключательКонтрольНапр_Paint(object sender, PaintEventArgs e)
        {
            Image im = ControlElementImages.toggleType3;
            e.Graphics.TranslateTransform(im.Width / 2, VoltageStabilizerПереключательКонтрольНапр.Height / 2);
            e.Graphics.RotateTransform(angle);
            e.Graphics.DrawImage(im, -im.Width / 2, -im.Height / 2);
            e.Graphics.RotateTransform(-angle);
        }

        private void VoltageStabilizerПереключательКонтрольНапр_Click(object sender, System.EventArgs e)
        {
            angle += 30f;
            VoltageStabilizerПереключательКонтрольНапр.Invalidate();
        }
    }
}