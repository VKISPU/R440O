//-----------------------------------------------------------------------
// <copyright file="K05M_01.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.K05M_01
{
    using System.Windows.Forms;
    using K05M_01Inside;

    /// <summary>
    /// Форма блока К05-М-1
    /// </summary>
    public partial class K05M_01Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="K05M_01Form"/>
        /// </summary>
        public K05M_01Form()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Открытие формы внутренней части блока
        /// </summary>
        /// <param name="sender">Объет вызвавший событие</param>
        /// <param name="e">Событие закрытия формы</param>
        private void K05M_01ButtonInside_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Form thisForm = new K05M_01InsideForm();
            thisForm.Show(this);
        }
    }
}