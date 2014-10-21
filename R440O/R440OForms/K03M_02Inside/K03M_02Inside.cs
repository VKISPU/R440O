//-----------------------------------------------------------------------
// <copyright file="K03M_02Inside.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.K03M_02Inside
{
    using System.Windows.Forms;

    /// <summary>
    /// Форма внутренней части блока К03-М-2
    /// </summary>
    public partial class K03M_02InsideForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="K03M_02InsideForm"/>
        /// </summary>
        public K03M_02InsideForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender">Объет вызвавший событие</param>
        /// <param name="e">Событие закрытия формы</param>
        private void K03M_02InsideForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}