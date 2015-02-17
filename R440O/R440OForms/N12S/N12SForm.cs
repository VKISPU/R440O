//-----------------------------------------------------------------------
// <copyright file="N12SForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using R440O.Parameters;

namespace R440O.R440OForms.N12S
{
    using System.Windows.Forms;

    /// <summary>
    /// Форма блока Н-12-С
    /// </summary>
    public partial class N12SForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="N12SForm"/>
        /// </summary>
        public N12SForm()
        {
            this.InitializeComponent();
        }

        private void N12SТумблерА_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N12SParameters.N12SТумблерА++;
                N12SТумблерА.BackgroundImage = ControlElementImages.tumblerType6Left;
            }
            if (e.Button == MouseButtons.Right)
            {
                N12SParameters.N12SТумблерА--;
                N12SТумблерА.BackgroundImage = ControlElementImages.tumblerType6Right;
            }
        }

        private void N12SТумблерА_MouseUp(object sender, MouseEventArgs e)
        {
            N12SParameters.N12SТумблерА = 0;
            N12SТумблерА.BackgroundImage = null;
        }

        private void N12SТумблерБ_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N12SParameters.N12SТумблерБ++;
                N12SТумблерБ.BackgroundImage = ControlElementImages.tumblerType6Up;
            }
            if (e.Button == MouseButtons.Right)
            {
                N12SParameters.N12SТумблерБ--;
                N12SТумблерБ.BackgroundImage = ControlElementImages.tumblerType6Down;
            }
        }

        private void N12SТумблерБ_MouseUp(object sender, MouseEventArgs e)
        {
            N12SParameters.N12SТумблерБ = 0;
            N12SТумблерБ.BackgroundImage = null;
        }

        private void N12SКнопкаУскор_MouseDown(object sender, MouseEventArgs e)
        {
            N12SКнопкаУскор.BackgroundImage = ControlElementImages.buttonRoundType8;
        }

        private void N12SКнопкаУскор_MouseUp(object sender, MouseEventArgs e)
        {
            N12SКнопкаУскор.BackgroundImage = null;
        }
    }
}