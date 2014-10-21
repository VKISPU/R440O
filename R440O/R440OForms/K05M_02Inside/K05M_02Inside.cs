//-----------------------------------------------------------------------
// <copyright file="K05M_02Inside.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.K05M_02Inside
{
    using System.Windows.Forms;

    /// <summary>
    /// Внутренняя часть блока К05-М-2
    /// </summary>
    public partial class K05M_02InsideForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="K05M_02InsideForm"/>
        /// </summary>
        public K05M_02InsideForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Закрытие формы внутренней части блока
        /// </summary>
        /// <param name="sender">Объет вызвавший событие</param>
        /// <param name="e">Событие закрытия формы</param>
        private void K05M_02InsideForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}