namespace R440O.R440OForms.C300PM_3
{
    using System.Windows.Forms;
    using Parameters;
    
    /// <summary>
    /// Форма блока С300ПМ-3
    /// </summary>
    public partial class C300PM_3Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="C300PM_3Form"/>
        /// </summary>
        public C300PM_3Form()
        {
            this.InitializeComponent();
            this.InitializeLamps();
        }

        /// <summary>
        /// Инициализирует начальное состояние ламп блока.
        /// </summary>
        private void InitializeLamps()
        {
            C300PM_3Лампочка2К.BackgroundImage = C300PM_3Parameters.C300PM_3Комплект1
                ? ControlElementImages.lampType10OnGreen
                : null;
            C300PM_3Лампочка1К.BackgroundImage = C300PM_3Parameters.C300PM_3Комплект2
                ? ControlElementImages.lampType10OnGreen
                : null;
        }
    }
}