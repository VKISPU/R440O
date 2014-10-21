//-----------------------------------------------------------------------
// <copyright file="K03M_01.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.K03M_01
{
    using System.Windows.Forms;
    using K03M_01Inside;

    /// <summary>
    /// Форма блока К03-М-1
    /// </summary>
    public partial class K03M_01Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="K03M_01Form"/>
        /// </summary>
        public K03M_01Form()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Снятие крышки на форме блока
        /// </summary>
        /// <param name="sender">Объет вызвавший событие</param>
        /// <param name="e">Событие закрытия формы</param>
        private void K03M_01Cover_Click(object sender, System.EventArgs e)
        {
            K03M_01Cover.Visible = false;
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender">Объет вызвавший событие</param>
        /// <param name="e">Событие закрытия формы</param>
        private void K03M_01ButtonInside_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Form thisForm = new K03M_01InsideForm();
            thisForm.Show(this);
        }
    }
}