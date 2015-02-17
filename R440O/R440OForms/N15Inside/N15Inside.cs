//-----------------------------------------------------------------------
// <copyright file="N15Inside.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.N15Inside
{
    using System.Windows.Forms;

    /// <summary>
    /// Форма внутренней части блока Н15
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
        /// Закрытие формы внутренней части блока
        /// </summary>
        /// <param name="sender">Объет вызвавший событие</param>
        /// <param name="e">Событие закрытия формы</param>
        private void N15InsideForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}