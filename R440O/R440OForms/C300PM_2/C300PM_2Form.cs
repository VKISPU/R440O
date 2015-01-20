namespace R440O.R440OForms.C300PM_2
{
    using System.Windows.Forms;
    using Parameters;

    /// <summary>
    /// Форма блока С300ПМ-2
    /// </summary>
    public partial class C300PM_2Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="C300PM_2Form"/>
        /// </summary>
        public C300PM_2Form()
        {
            this.InitializeComponent(); 
            this.InitializeLamps();
        }

        /// <summary>
        /// Инициализирует начальное состояние ламп блока.
        /// </summary>
        private void InitializeLamps()
        {
            C300PM_2Лампочка2К.BackgroundImage = C300PM_2Parameters.C300PM_2Комплект1
                ? ControlElementImages.lampType10OnGreen
                : null;
            C300PM_2Лампочка1К.BackgroundImage = C300PM_2Parameters.C300PM_2Комплект2
                ? ControlElementImages.lampType10OnGreen
                : null;
        }
    }
}