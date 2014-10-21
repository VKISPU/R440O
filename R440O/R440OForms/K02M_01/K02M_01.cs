﻿//-----------------------------------------------------------------------
// <copyright file="K02M_01.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.K02M_01
{
    using System.Windows.Forms;
    using K02M_01Inside;

    /// <summary>
    /// Форма блока К02-М-1
    /// </summary>
    public partial class K02M_01Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="K02M_01Form"/>
        /// </summary>
        public K02M_01Form()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender">Объет вызвавший событие</param>
        /// <param name="e">Событие закрытия формы</param>
        private void K02M_01ButtonInside_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Form thisForm = new K02M_01InsideForm();
            thisForm.Show(this);
        }
    }
}