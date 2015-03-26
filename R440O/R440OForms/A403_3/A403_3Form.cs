//-----------------------------------------------------------------------
// <copyright file="A403_3Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.A403_3
{
    using System.Windows.Forms;

    /// <summary>
    /// Форма блока A403-3
    /// </summary>
    public partial class A403_3Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="A403_3Form"/>.
        /// </summary>
        public A403_3Form()
        {
            this.InitializeComponent();
            this.InitializeControls();
        }

        /// <summary>
        /// Задание начального положения тумблера для выбора комплекта блока
        /// </summary>
        private void InitializeControls()
        {
            Тублер1К2К.BackgroundImage = A403_3Parameters.Тублер1К2К
                ? ControlElementImages.tumblerType4Left
                : ControlElementImages.tumblerType4Right;
        }

        private void Тублер1К2К_Click(object sender, System.EventArgs e)
        {
            A403_3Parameters.Тублер1К2К = !A403_3Parameters.Тублер1К2К;
            Тублер1К2К.BackgroundImage = A403_3Parameters.Тублер1К2К
                ? ControlElementImages.tumblerType4Left
                : ControlElementImages.tumblerType4Right;
        }
    }
}