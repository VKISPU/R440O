//-----------------------------------------------------------------------
// <copyright file="P220_27G_3Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.P220_27G_3
{
    using System.Windows.Forms;
    using Parameters;

    /// <summary>
    /// Форма блока П220-27Г-3
    /// </summary>
    public partial class P220_27G_3Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="P220_27G_3Form"/>
        /// </summary>
        public P220_27G_3Form()
        {
            this.InitializeComponent();
            this.InitializeTumblersPosition();
        }

        private void P220_27G_3ТумблерСеть_Click(object sender, System.EventArgs e)
        {
            if (P220_27G_3Parameters.P220_27G_3ТумблерСеть)
            {
                this.P220_27G_3ТумблерСеть.BackgroundImage = ControlElementImages.tumblerType6Down;
                P220_27G_3Parameters.P220_27G_3ТумблерСеть = false;
            }
            else
            {
                this.P220_27G_3ТумблерСеть.BackgroundImage = ControlElementImages.tumblerType6Up;
                P220_27G_3Parameters.P220_27G_3ТумблерСеть = true;
            }
        }

        private void P220_27G_3ТумблерМуДу_Click(object sender, System.EventArgs e)
        {
            if (P220_27G_3Parameters.P220_27G_3ТумблерМуДу == "Му")
            {
                this.P220_27G_3ТумблерМуДу.BackgroundImage = ControlElementImages.tumblerType4Down;
                P220_27G_3Parameters.P220_27G_3ТумблерМуДу = "Ду";
            }
            else
            {
                this.P220_27G_3ТумблерМуДу.BackgroundImage = ControlElementImages.tumblerType4Up;
                P220_27G_3Parameters.P220_27G_3ТумблерМуДу = "Му";
            }
        }

        private void InitializeTumblersPosition()
        {
            this.P220_27G_3ТумблерМуДу.BackgroundImage = P220_27G_3Parameters.P220_27G_3ТумблерМуДу == "Ду"
                ? ControlElementImages.tumblerType4Down
                : ControlElementImages.tumblerType4Up;

            this.P220_27G_3ТумблерСеть.BackgroundImage = P220_27G_3Parameters.P220_27G_3ТумблерСеть
                ? ControlElementImages.tumblerType6Up
                : ControlElementImages.tumblerType6Down;
        }
    }
}