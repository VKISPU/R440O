//-----------------------------------------------------------------------
// <copyright file="K02M_02Inside.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.K02M_02Inside
{
    using System.Windows.Forms;

    /// <summary>
    /// Форма внутренней части блока К02-М-1
    /// </summary>
    public partial class K02M_02InsideForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="K02M_02InsideForm"/>
        /// </summary>
        public K02M_02InsideForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender">Объет вызвавший событие</param>
        /// <param name="e">Событие закрытия формы</param>
        private void K02M_02InsideForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}