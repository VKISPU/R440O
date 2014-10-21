//-----------------------------------------------------------------------
// <copyright file="K03M_02.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.K03M_02
{
    using System.Windows.Forms;
    using K03M_02Inside;

    /// <summary>
    /// Форма блока К03-М-1
    /// </summary>
    public partial class K03M_02Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="K03M_02Form"/>
        /// </summary>
        public K03M_02Form()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Снятие крышки на форме блока
        /// </summary>
        /// <param name="sender">Объет вызвавший событие</param>
        /// <param name="e">Событие закрытия формы</param>
        private void K03M_02Cover_Click(object sender, System.EventArgs e)
        {
            K03M_02Cover.Visible = false;
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender">Объет вызвавший событие</param>
        /// <param name="e">Событие закрытия формы</param>
        private void K03M_02ButtonInside_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Form thisForm = new K03M_02InsideForm();
            thisForm.Show(this);
        }
    }
}