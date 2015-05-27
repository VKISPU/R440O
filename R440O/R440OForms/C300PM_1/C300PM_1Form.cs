namespace R440O.R440OForms.C300PM_1
{
    using System.Windows.Forms;

    /// <summary>
    /// Форма блока С300ПМ-1
    /// </summary>
    public partial class C300PM_1Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="C300PM_1Form"/>
        /// </summary>
        public C300PM_1Form()
        {
            this.InitializeComponent();
            C300PM_1Parameters.RefreshForm += this.InitializeLamps;

            InitializeLamps();
        }

        /// <summary>
        /// Инициализирует начальное состояние ламп блока.
        /// </summary>
        private void InitializeLamps()
        {
            ЛампочкаКомплект1.BackgroundImage = C300PM_1Parameters.ЛампочкаКомплект1
                ? ControlElementImages.lampType10OnGreen
                : null;
            ЛампочкаКомплект2.BackgroundImage = C300PM_1Parameters.ЛампочкаКомплект2
                ? ControlElementImages.lampType10OnGreen
                : null;
        }
    }
}