//-----------------------------------------------------------------------
// <copyright file="K04M_02.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.K04M_02
{
    using System.Windows.Forms;

    /// <summary>
    /// Форма блока К04-М-1
    /// </summary>
    public partial class K04M_02Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="K04M_02Form"/>
        /// </summary>
        public K04M_02Form()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Снятие крышки на форме блока
        /// </summary>
        /// <param name="sender">Объет вызвавший событие</param>
        /// <param name="e">Событие закрытия формы</param>
        private void K04M_02Cover_Click(object sender, System.EventArgs e)
        {
            K04M_02Cover.Visible = false;
        }
    }
}