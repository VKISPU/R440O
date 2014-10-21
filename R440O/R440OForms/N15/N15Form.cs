//-----------------------------------------------------------------------
// <copyright file="N15Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.N15
{
    using System;
    using System.Windows.Forms;
    using Parameters;

    /// <summary>
    /// Форма блока Н-15
    /// </summary>
    public partial class N15Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="N15Form"/>
        /// </summary>
        public N15Form()
        {
            this.InitializeComponent();
        }

        private void Н15КнопкаСтанцияВкл_MouseDown(object sender, MouseEventArgs e)
        {
            this.Н15КнопкаСтанцияВкл.BackgroundImage = null;
        }

        private void Н15КнопкаСтанцияВкл_MouseUp(object sender, MouseEventArgs e)
        {
            this.Н15КнопкаСтанцияВкл.BackgroundImage = ControlElementImages.buttonOnUpBlack;
            N15Parameters.Н15КнопкаСтанцияВкл = "true";
        }

        private void Н15КнопкаСтанцияВыкл_MouseDown(object sender, MouseEventArgs e)
        {
            this.Н15КнопкаСтанцияВыкл.BackgroundImage = null;
        }

        private void Н15КнопкаСтанцияВыкл_MouseUp(object sender, MouseEventArgs e)
        {
            this.Н15КнопкаСтанцияВыкл.BackgroundImage = ControlElementImages.buttonOffUpRed;
            N15Parameters.Н15КнопкаСтанцияВыкл = "true";
        }

        private void N15Form_Load(object sender, EventArgs e)
        {
        }
    }
}