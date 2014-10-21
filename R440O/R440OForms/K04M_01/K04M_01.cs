//-----------------------------------------------------------------------
// <copyright file="K04M_01.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.K04M_01
{
    using System.Windows.Forms;

    /// <summary>
    /// Форма блока К04-М-1
    /// </summary>
    public partial class K04M_01Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="K04M_01Form"/>
        /// </summary>
        public K04M_01Form()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Снятие крышки на форме блока
        /// </summary>
        /// <param name="sender">Объет вызвавший событие</param>
        /// <param name="e">Событие закрытия формы</param>
        private void K04M_01Cover_Click(object sender, System.EventArgs e)
        {
            K04M_01Cover.Visible = false;
        }
    }
}