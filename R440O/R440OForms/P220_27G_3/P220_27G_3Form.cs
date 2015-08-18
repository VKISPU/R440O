//-----------------------------------------------------------------------
// <copyright file="P220_27G_3Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using R440O.BaseClasses;

namespace R440O.R440OForms.P220_27G_3
{
    using System.Windows.Forms;

    /// <summary>
    /// Форма блока П220-27Г-3
    /// </summary>
    public partial class P220_27G_3Form : Form, IRefreshableForm
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="P220_27G_3Form"/>
        /// </summary>
        public P220_27G_3Form()
        {
            this.InitializeComponent();
            P220_27G_3Parameters.ParameterChanged += RefreshFormElements;
            RefreshFormElements();
        }

        private void P220_27G_3ТумблерСеть_Click(object sender, System.EventArgs e)
        {
            P220_27G_3Parameters.ТумблерСеть = !P220_27G_3Parameters.ТумблерСеть;
        }

        private void P220_27G_3ТумблерМуДу_Click(object sender, System.EventArgs e)
        {
            P220_27G_3Parameters.ТумблерМуДу = !P220_27G_3Parameters.ТумблерМуДу;
        }

        public void RefreshFormElements()
        {
            ЛампочкаСеть.BackgroundImage = P220_27G_3Parameters.ЛампочкаСеть
                ? ControlElementImages.lampType9OnGreen
                : null;
            this.ТумблерМуДу.BackgroundImage = P220_27G_3Parameters.ТумблерМуДу
                ? ControlElementImages.tumblerType4Down
                : ControlElementImages.tumblerType4Up;

            this.ТумблерСеть.BackgroundImage = P220_27G_3Parameters.ТумблерСеть
                ? ControlElementImages.tumblerType6Up
                : ControlElementImages.tumblerType6Down;
        }
    }
}