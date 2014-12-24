//-----------------------------------------------------------------------
// <copyright file="PowerCabelForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.PowerCabel
{
    using System.Windows.Forms;
    using Parameters;

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
            InitializeComponent();
            InitializePosition();
        }

        private void PowerCabelТумблерОсвещение_Click(object sender, System.EventArgs e)
        {
            PowerCabelТумблерОсвещение.BackgroundImage = (PowerCabelParameters.PowerCabelТумблерОсвещение)
                ? ControlElementImages.tumblerType4Left
                : ControlElementImages.tumblerType4Right;
       
            PowerCabelParameters.PowerCabelТумблерОсвещение = !PowerCabelParameters.PowerCabelТумблерОсвещение;
        }

        private void PowerCabelВход_Click(object sender, System.EventArgs e)
        {
            PowerCabelВход.BackgroundImage = (PowerCabelParameters.PowerCabelВход)
                ? null
                : ControlElementImages.powerCabelEnter;

            PowerCabelParameters.PowerCabelВход = !PowerCabelParameters.PowerCabelВход;
        }

        private void InitializePosition()
        {
            PowerCabelВход.BackgroundImage = (PowerCabelParameters.PowerCabelВход)
                ? ControlElementImages.powerCabelEnter
                : null;

            PowerCabelТумблерОсвещение.BackgroundImage = (PowerCabelParameters.PowerCabelТумблерОсвещение)
                ? ControlElementImages.tumblerType4Right
                : ControlElementImages.tumblerType4Left;
        }
    }
}