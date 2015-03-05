//-----------------------------------------------------------------------
// <copyright file="P220_27G_2Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.P220_27G_2
{
    using System.Windows.Forms;
    using Parameters;

    /// <summary>
    /// Форма блока П220-27Г-3
    /// </summary>
    public partial class P220_27G_2Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="P220_27G_2Form"/>
        /// </summary>
        public P220_27G_2Form()
        {
            this.InitializeComponent();
            this.InitializeTumblersPosition();
        }

        private void P220_27G_2ТумблерСеть_Click(object sender, System.EventArgs e)
        {
            if (P220_27G_2Parameters.P220_27G_2ТумблерСеть)
            {
                this.P220_27G_2ТумблерСеть.BackgroundImage = ControlElementImages.tumblerType6Down;
                P220_27G_2Parameters.P220_27G_2ТумблерСеть = false;
            }
            else
            {
                this.P220_27G_2ТумблерСеть.BackgroundImage = ControlElementImages.tumblerType6Up;
                P220_27G_2Parameters.P220_27G_2ТумблерСеть = true;
            }
        }

        private void P220_27G_2ТумблерМуДу_Click(object sender, System.EventArgs e)
        {
            if (P220_27G_2Parameters.P220_27G_2ТумблерМуДу == "Му")
            {
                this.P220_27G_2ТумблерМуДу.BackgroundImage = ControlElementImages.tumblerType4Down;
                P220_27G_2Parameters.P220_27G_2ТумблерМуДу = "Ду";
            }
            else
            {
                this.P220_27G_2ТумблерМуДу.BackgroundImage = ControlElementImages.tumblerType4Up;
                P220_27G_2Parameters.P220_27G_2ТумблерМуДу = "Му";
            }
        }

        private void InitializeTumblersPosition()
        {
            this.P220_27G_2ТумблерМуДу.BackgroundImage = P220_27G_2Parameters.P220_27G_2ТумблерМуДу == "Ду"
                ? ControlElementImages.tumblerType4Down
                : ControlElementImages.tumblerType4Up;

            this.P220_27G_2ТумблерСеть.BackgroundImage = P220_27G_2Parameters.P220_27G_2ТумблерСеть
                ? ControlElementImages.tumblerType6Up
                : ControlElementImages.tumblerType6Down;
        }
    }
}