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

        private void Н15КнопкаПРМНаведениеЦ300М1_Click(object sender, EventArgs e)
        {
            this.Н15КнопкаПРМНаведениеЦ300М1.Visible = false;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М1 = "true";

            this.Н15КнопкаПРМНаведениеЦ300М2.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М2 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М3.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М3 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М4.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М4 = "false";
            this.Н15КнопкаМощностьН16.Visible = true;
            N15Parameters.Н15КнопкаМощностьН16 = "false";
            this.Н15КнопкаМощностьАнт.Visible = true;
            N15Parameters.Н15КнопкаМощностьАнт = "false";
            N15Parameters.Н15КнопкаМощностьСброс = "false";
        }

        private void Н15КнопкаПРМНаведениеЦ300М2_Click(object sender, EventArgs e)
        {
            this.Н15КнопкаПРМНаведениеЦ300М2.Visible = false;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М2 = "true";

            this.Н15КнопкаПРМНаведениеЦ300М1.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М1 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М3.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М3 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М4.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М4 = "false";
            this.Н15КнопкаМощностьН16.Visible = true;
            N15Parameters.Н15КнопкаМощностьН16 = "false";
            this.Н15КнопкаМощностьАнт.Visible = true;
            N15Parameters.Н15КнопкаМощностьАнт = "false";
            N15Parameters.Н15КнопкаМощностьСброс = "false";
        }

        private void Н15КнопкаПРМНаведениеЦ300М3_Click(object sender, EventArgs e)
        {
            this.Н15КнопкаПРМНаведениеЦ300М3.Visible = false;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М3 = "true";

            this.Н15КнопкаПРМНаведениеЦ300М1.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М1 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М2.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М2 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М4.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М4 = "false";
            this.Н15КнопкаМощностьН16.Visible = true;
            N15Parameters.Н15КнопкаМощностьН16 = "false";
            this.Н15КнопкаМощностьАнт.Visible = true;
            N15Parameters.Н15КнопкаМощностьАнт = "false";
            N15Parameters.Н15КнопкаМощностьСброс = "false";
        }

        private void Н15КнопкаПРМНаведениеЦ300М4_Click(object sender, EventArgs e)
        {
            this.Н15КнопкаПРМНаведениеЦ300М4.Visible = false;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М4 = "true";

            this.Н15КнопкаПРМНаведениеЦ300М1.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М1 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М2.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М2 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М3.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М3 = "false";
            this.Н15КнопкаМощностьН16.Visible = true;
            N15Parameters.Н15КнопкаМощностьН16 = "false";
            this.Н15КнопкаМощностьАнт.Visible = true;
            N15Parameters.Н15КнопкаМощностьАнт = "false";
            N15Parameters.Н15КнопкаМощностьСброс = "false";
        }

        private void Н15КнопкаМощностьН16_Click(object sender, EventArgs e)
        {
            this.Н15КнопкаМощностьН16.Visible = false;
            N15Parameters.Н15КнопкаМощностьН16 = "true";

            this.Н15КнопкаПРМНаведениеЦ300М1.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М1 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М2.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М2 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М3.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М3 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М4.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М4 = "false";
            this.Н15КнопкаМощностьАнт.Visible = true;
            N15Parameters.Н15КнопкаМощностьАнт = "false";
            N15Parameters.Н15КнопкаМощностьСброс = "false";
        }

        private void Н15КнопкаМощностьАнт_Click(object sender, EventArgs e)
        {
            this.Н15КнопкаМощностьАнт.Visible = false;
            N15Parameters.Н15КнопкаМощностьАнт = "true";

            this.Н15КнопкаПРМНаведениеЦ300М1.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М1 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М2.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М2 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М3.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М3 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М4.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М4 = "false";
            this.Н15КнопкаМощностьН16.Visible = true;
            N15Parameters.Н15КнопкаМощностьН16 = "false";
            N15Parameters.Н15КнопкаМощностьСброс = "false";
        }

        private void Н15КнопкаМощностьСброс_MouseUp(object sender, MouseEventArgs e)
        {
            this.Н15КнопкаМощностьСброс.BackgroundImage = ControlElementImages.buttonSquareType1UpWhite;
            this.Н15КнопкаМощностьСброс.Text = "СБРОС";
            N15Parameters.Н15КнопкаМощностьСброс = "true";

            this.Н15КнопкаПРМНаведениеЦ300М1.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М1 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М2.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М2 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М3.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М3 = "false";
            this.Н15КнопкаПРМНаведениеЦ300М4.Visible = true;
            N15Parameters.Н15КнопкаПРМНаведениеЦ300М4 = "false";
            this.Н15КнопкаМощностьН16.Visible = true;
            N15Parameters.Н15КнопкаМощностьН16 = "false";
            this.Н15КнопкаМощностьАнт.Visible = true;
            N15Parameters.Н15КнопкаМощностьАнт = "false";
        }

        private void Н15КнопкаМощностьСброс_MouseDown(object sender, MouseEventArgs e)
        {
            this.Н15КнопкаМощностьСброс.BackgroundImage = null;
            this.Н15КнопкаМощностьСброс.Text = "";
        }

        private void N15Form_Load(object sender, EventArgs e)
        {
        }

        private void Н15КнопкаН13_1_Click(object sender, EventArgs e)
        {
            this.Н15КнопкаН13_1.Visible = false;
            N15Parameters.Н15КнопкаН13_1 = "true";

            this.Н15КнопкаН13_2.Visible = true;
            N15Parameters.Н15КнопкаН13_2 = "false";
            this.Н15КнопкаН13_12.Visible = true;
            N15Parameters.Н15КнопкаН13_12 = "false";
            N15Parameters.Н15КнопкаСброс = "false";
        }

        private void Н15КнопкаН13_2_Click(object sender, EventArgs e)
        {
            this.Н15КнопкаН13_2.Visible = false;
            N15Parameters.Н15КнопкаН13_2 = "true";

            this.Н15КнопкаН13_1.Visible = true;
            N15Parameters.Н15КнопкаН13_1 = "false";
            this.Н15КнопкаН13_12.Visible = true;
            N15Parameters.Н15КнопкаН13_12 = "false";
            N15Parameters.Н15КнопкаСброс = "false";
        }

        private void Н15КнопкаН13_12_Click(object sender, EventArgs e)
        {
            this.Н15КнопкаН13_12.Visible = false;
            N15Parameters.Н15КнопкаН13_12 = "true";

            this.Н15КнопкаН13_1.Visible = true;
            N15Parameters.Н15КнопкаН13_1 = "false";
            this.Н15КнопкаН13_2.Visible = true;
            N15Parameters.Н15КнопкаН13_2 = "false";
            N15Parameters.Н15КнопкаСброс = "false";
        }

        private void Н15КнопкаСброс_MouseUp(object sender, MouseEventArgs e)
        {            
            this.Н15КнопкаСброс.BackgroundImage = ControlElementImages.buttonSquareType1UpWhite;
            this.Н15КнопкаСброс.Text = "СБРОС";
            N15Parameters.Н15КнопкаСброс = "true";

            this.Н15КнопкаН13_1.Visible = true;
            N15Parameters.Н15КнопкаН13_1 = "false";
            this.Н15КнопкаН13_2.Visible = true;
            N15Parameters.Н15КнопкаН13_2 = "false";
            this.Н15КнопкаН13_12.Visible = true;
            N15Parameters.Н15КнопкаН13_12 = "false";
        }

        private void Н15КнопкаСброс_MouseDown(object sender, MouseEventArgs e)
        {
            this.Н15КнопкаСброс.BackgroundImage = null;
            this.Н15КнопкаСброс.Text = "";
        }
    }
}