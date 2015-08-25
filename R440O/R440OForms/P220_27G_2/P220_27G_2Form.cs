namespace R440O.R440OForms.P220_27G_2
{
    using System.Windows.Forms;
    using BaseClasses;

    /// <summary>
    /// Форма блока П220-27Г-3
    /// </summary>
    public partial class P220_27G_2Form : Form, IRefreshableForm
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="P220_27G_2Form"/>
        /// </summary>
        public P220_27G_2Form()
        {
            this.InitializeComponent();
            P220_27G_2Parameters.ParameterChanged += RefreshFormElements;
            RefreshFormElements();
        }

        private void P220_27G_2ТумблерСеть_Click(object sender, System.EventArgs e)
        {
            P220_27G_2Parameters.ТумблерСеть = !P220_27G_2Parameters.ТумблерСеть;
        }

        private void P220_27G_2ТумблерМуДу_Click(object sender, System.EventArgs e)
        {
            P220_27G_2Parameters.ТумблерМуДу = !P220_27G_2Parameters.ТумблерМуДу;
        }

        public void RefreshFormElements()
        {
            ЛампочкаСеть.BackgroundImage = P220_27G_2Parameters.ЛампочкаСеть
                ? ControlElementImages.lampType9OnGreen
                : null;

            this.ТумблерМуДу.BackgroundImage = P220_27G_2Parameters.ТумблерМуДу
                ? ControlElementImages.tumblerType4Down
                : ControlElementImages.tumblerType4Up;

            this.ТумблерСеть.BackgroundImage = P220_27G_2Parameters.ТумблерСеть
                ? ControlElementImages.tumblerType6Up
                : ControlElementImages.tumblerType6Down;
        }
    }
}