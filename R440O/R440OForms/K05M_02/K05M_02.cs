//-----------------------------------------------------------------------
// <copyright file="K05M_02.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.K05M_02
{
    using System.Windows.Forms;
    using K05M_02Inside;

    /// <summary>
    /// Форма блока К05-М-2
    /// </summary>
    public partial class K05M_02Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="K05M_02Form"/>
        /// </summary>
        public K05M_02Form()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Открытие формы внутренней части блока
        /// </summary>
        /// <param name="sender">Объет вызвавший событие</param>
        /// <param name="e">Событие закрытия формы</param>
        private void K05M_02ButtonInside_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Form thisForm = new K05M_02InsideForm();
            thisForm.Show(this);
        }
    }
}