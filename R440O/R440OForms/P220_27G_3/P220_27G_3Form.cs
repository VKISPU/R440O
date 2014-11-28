//-----------------------------------------------------------------------
// <copyright file="P220_27G_3Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using R440O.Parameters;

namespace R440O.R440OForms.P220_27G_3
{
    using System.Windows.Forms;

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
        }

        private void P220_27G_3ТумблерСеть_Click(object sender, System.EventArgs e)
        {
            if (P220_27G_3Parameters.P220_27G_3ТумблерСеть == "сеть")
            {
                this.P220_27G_3ТумблерСеть.BackgroundImage = ControlElementImages.tumblerType6Down;
                P220_27G_3Parameters.P220_27G_3ТумблерСеть = "откл";
            }
            else
            {
                this.P220_27G_3ТумблерСеть.BackgroundImage = ControlElementImages.tumblerType6Up;
                P220_27G_3Parameters.P220_27G_3ТумблерСеть = "сеть";
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
    }
}