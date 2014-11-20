//-----------------------------------------------------------------------
// <copyright file="K05M_01.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.N15Inside
{
    using System.Windows.Forms;
    using N15Inside;

    /// <summary>
    /// Форма блока К05-М-1
    /// </summary>
    public partial class N15InsideForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="N15InsideForm"/>
        /// </summary>
        public N15InsideForm()
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
            Form thisForm = new N15InsideForm();
            thisForm.Show(this);
        }
    }
}