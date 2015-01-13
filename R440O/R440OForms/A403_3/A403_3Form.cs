//-----------------------------------------------------------------------
// <copyright file="A403_3Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using R440O.Parameters;

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
        /// Задание начального положения тумблера для выбора комплекта блока. Задание состояния лампочек для данного блока.
        /// </summary>
        private void InitializeControls()
        {
            A403_3Тублер1К2К.BackgroundImage = A403_3Parameters.A403_3Тублер1К2К == 1
                ? ControlElementImages.tumblerType4Left
                : ControlElementImages.tumblerType4Right;
        }

        private void A403_3Тублер1К2К_Click(object sender, System.EventArgs e)
        {
            if (A403_3Parameters.A403_3Тублер1К2К == 1)
            {
                A403_3Parameters.A403_3Тублер1К2К = 2;
                A403_3Тублер1К2К.BackgroundImage = ControlElementImages.tumblerType4Right;
            }
            else
            {
                A403_3Parameters.A403_3Тублер1К2К = 1;
                A403_3Тублер1К2К.BackgroundImage = ControlElementImages.tumblerType4Left;
            }
        }
    }
}