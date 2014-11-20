//-----------------------------------------------------------------------
// <copyright file="PowerCabelForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using R440O.Parameters;

namespace R440O.R440OForms.PowerCabel
{
    using System.Windows.Forms;

    /// <summary>
    /// Форма блока кабель питания
    /// </summary>
    public partial class PowerCabelForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PowerCabelForm"/>
        /// </summary>
        public PowerCabelForm()
        {
            this.InitializeComponent();
        }

        private void PowerCabelТумблерОсвещение_Click(object sender, System.EventArgs e)
        {
            if (PowerCabelParameters.PowerCabelТумблерОсвещение == "true")
            {
                this.PowerCabelТумблерОсвещение.BackgroundImage = ControlElementImages.tumblerHorizontalType4Left;
                PowerCabelParameters.PowerCabelТумблерОсвещение = "false";
            }
            else
            {
                this.PowerCabelТумблерОсвещение.BackgroundImage = ControlElementImages.tumblerHorizontalType4Right;
                PowerCabelParameters.PowerCabelТумблерОсвещение = "true";
            }
        }

        private void PowerCabelВход_Click(object sender, System.EventArgs e)
        {
            if (PowerCabelParameters.PowerCabelВход == "true")
            {
                this.PowerCabelВход.BackgroundImage = null;
                PowerCabelParameters.PowerCabelВход = "false";
            }
            else
            {
                this.PowerCabelВход.BackgroundImage = ControlElementImages.powerCabelEnter;
                PowerCabelParameters.PowerCabelВход = "true";
            }
        }


    }
}