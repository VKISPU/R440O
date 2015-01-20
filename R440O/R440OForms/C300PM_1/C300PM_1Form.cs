namespace R440O.R440OForms.C300PM_1
{
    using System.Windows.Forms;
    using Parameters;

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
            this.InitializeLamps();
        }

        /// <summary>
        /// Инициализирует начальное состояние ламп блока.
        /// </summary>
        private void InitializeLamps()
        {
            C300PM_1Лампочка2К.BackgroundImage = C300PM_1Parameters.C300PM_1Комплект1
                ? ControlElementImages.lampType10OnGreen
                : null;
            C300PM_1Лампочка1К.BackgroundImage = C300PM_1Parameters.C300PM_1Комплект2
                ? ControlElementImages.lampType10OnGreen
                : null;
        }
    }
}