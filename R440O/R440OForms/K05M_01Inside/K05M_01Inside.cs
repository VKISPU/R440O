//-----------------------------------------------------------------------
// <copyright file="K05M_01Inside.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.K05M_01Inside
{
    using System.Windows.Forms;

    /// <summary>
    /// Внутренняя часть блока К05-М-1
    /// </summary>
    public partial class K05M_01InsideForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="K05M_01InsideForm"/>
        /// </summary>
        public K05M_01InsideForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Закрытие формы внутренней части блока
        /// </summary>
        /// <param name="sender">Объет вызвавший событие</param>
        /// <param name="e">Событие закрытия формы</param>
        private void K05M_01InsideForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}