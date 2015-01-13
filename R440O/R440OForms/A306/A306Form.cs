namespace R440O.R440OForms.A306
{
    using System.Windows.Forms;
    using Parameters;
    /// <summary>
    /// Форма блока А306
    /// </summary>
    public partial class A306Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="A306Form"/>.
        /// </summary>
        public A306Form()
        {
            this.InitializeComponent();
            this.InitializeTumblers();
        }

        /// <summary>
        /// Задает начальные полочения переключателей на блоке A306.
        /// </summary>
        private void InitializeTumblers()
        {
            A306ТумблерДистанцМестн.BackgroundImage = A306Parameters.A306ТумблерДистанцМестн ? ControlElementImages.tumblerType4Up : ControlElementImages.tumblerType4Down;
            A306ТумблерВклВыкл.BackgroundImage = A306Parameters.A306ТумблерВклВыкл ? ControlElementImages.tumblerType4Up : ControlElementImages.tumblerType4Down;
        }

        private void A306ТумблерДистанцМестн_Click(object sender, System.EventArgs e)
        {
            A306Parameters.A306ТумблерДистанцМестн = !A306Parameters.A306ТумблерДистанцМестн;
            A306ТумблерДистанцМестн.BackgroundImage = A306Parameters.A306ТумблерДистанцМестн ? ControlElementImages.tumblerType4Up : ControlElementImages.tumblerType4Down;
        }

        private void A306ТумблерВклВыкл_Click(object sender, System.EventArgs e)
        {
            A306Parameters.A306ТумблерВклВыкл = !A306Parameters.A306ТумблерВклВыкл;
            A306ТумблерВклВыкл.BackgroundImage = A306Parameters.A306ТумблерВклВыкл ? ControlElementImages.tumblerType4Up : ControlElementImages.tumblerType4Down;
        }
    }
}