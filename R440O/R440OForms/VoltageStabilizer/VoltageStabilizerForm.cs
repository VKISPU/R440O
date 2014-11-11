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
        private int _angleКонтрольНапряжения = 15;
        
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="VoltageStabilizerForm"/>
        /// </summary>
        public VoltageStabilizerForm()
        {
            this.InitializeComponent();
            VoltageStabilizerParameters.VoltageStabilizerКабельВход = "220";
            _angleКонтрольНапряжения = 15;
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
        /// Перерисовка переключателя контроля напряжения для нового положения
        /// </summary>
        private void VoltageStabilizerПереключательКонтрольНапр_Paint(object sender, PaintEventArgs e)
        {
            Image im = ControlElementImages.toggleType3;
            e.Graphics.TranslateTransform(im.Width / 2, VoltageStabilizerПереключательКонтрольНапр.Height / 2);
            e.Graphics.RotateTransform(_angleКонтрольНапряжения);
            e.Graphics.DrawImage(im, -im.Width / 2, -im.Height / 2);
            e.Graphics.RotateTransform(-_angleКонтрольНапряжения);
        }

        /// <summary>
        /// Вызывает перерисовку переключателя контроля напряжения в соответствии с новым значением угла.
        /// </summary>
        private void VoltageStabilizerПереключательКонтрольНапр_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _angleКонтрольНапряжения += 30;
            }

            if (e.Button == MouseButtons.Right)
            {
                _angleКонтрольНапряжения -= 30;
            }

            VoltageStabilizerПереключательКонтрольНапр.Invalidate();
        }
    }
}