//-----------------------------------------------------------------------
// <copyright file="B2_2Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.B2_2
{
    using System.Windows.Forms;
    using Parameters;

    /// <summary>
    /// Форма блока Б2-1
    /// </summary>
    public partial class B2_2Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="B2_2Form"/>.
        /// </summary>
        public B2_2Form()
        {
            this.InitializeComponent();
            this.InitializeTumblersPosition();
            this.InitializeButtonsPosition();
        }
        #region Кнопки
        private void B2_2КнопкаБК1_1_Click(object sender, System.EventArgs e)
        {
            this.B2_2КнопкаБК1_1.Visible = false;
            B2_2Parameters.B2_2КнопкаБК1_1 = "true";
            this.B2_2КнопкаБК1_2.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_2 = "false";
            this.B2_2КнопкаБК1_3.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_3 = "false";
            this.B2_2КнопкаБК1_4.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_4 = "false";
            this.B2_2КнопкаБК1_5.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_5 = "false";
            this.B2_2КнопкаБК1_6.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_6 = "false";
            this.B2_2КнопкаБК1_7.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_7 = "false";
            this.B2_2КнопкаБК1_8.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_8 = "false";
            this.B2_2КнопкаБК1_9.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_9 = "false";
        }

        private void B2_2КнопкаБК1_2_Click(object sender, System.EventArgs e)
        {
            this.B2_2КнопкаБК1_1.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_1 = "false";
            this.B2_2КнопкаБК1_2.Visible = false;
            B2_2Parameters.B2_2КнопкаБК1_2 = "true";
            this.B2_2КнопкаБК1_3.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_3 = "false";
            this.B2_2КнопкаБК1_4.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_4 = "false";
            this.B2_2КнопкаБК1_5.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_5 = "false";
            this.B2_2КнопкаБК1_6.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_6 = "false";
            this.B2_2КнопкаБК1_7.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_7 = "false";
            this.B2_2КнопкаБК1_8.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_8 = "false";
            this.B2_2КнопкаБК1_9.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_9 = "false";
        }

        private void B2_2КнопкаБК1_3_Click(object sender, System.EventArgs e)
        {
            this.B2_2КнопкаБК1_1.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_1 = "false";
            this.B2_2КнопкаБК1_2.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_2 = "false";
            this.B2_2КнопкаБК1_3.Visible = false;
            B2_2Parameters.B2_2КнопкаБК1_3 = "true";
            this.B2_2КнопкаБК1_4.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_4 = "false";
            this.B2_2КнопкаБК1_5.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_5 = "false";
            this.B2_2КнопкаБК1_6.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_6 = "false";
            this.B2_2КнопкаБК1_7.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_7 = "false";
            this.B2_2КнопкаБК1_8.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_8 = "false";
            this.B2_2КнопкаБК1_9.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_9 = "false";
        }

        private void B2_2КнопкаБК1_4_Click(object sender, System.EventArgs e)
        {
            this.B2_2КнопкаБК1_1.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_1 = "false";
            this.B2_2КнопкаБК1_2.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_2 = "false";
            this.B2_2КнопкаБК1_3.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_3 = "false";
            this.B2_2КнопкаБК1_4.Visible = false;
            B2_2Parameters.B2_2КнопкаБК1_4 = "true";
            this.B2_2КнопкаБК1_5.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_5 = "false";
            this.B2_2КнопкаБК1_6.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_6 = "false";
            this.B2_2КнопкаБК1_7.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_7 = "false";
            this.B2_2КнопкаБК1_8.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_8 = "false";
            this.B2_2КнопкаБК1_9.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_9 = "false";
        }

        private void B2_2КнопкаБК1_5_Click(object sender, System.EventArgs e)
        {
            this.B2_2КнопкаБК1_1.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_1 = "false";
            this.B2_2КнопкаБК1_2.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_2 = "false";
            this.B2_2КнопкаБК1_3.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_3 = "false";
            this.B2_2КнопкаБК1_4.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_4 = "false";
            this.B2_2КнопкаБК1_5.Visible = false;
            B2_2Parameters.B2_2КнопкаБК1_5 = "true";
            this.B2_2КнопкаБК1_6.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_6 = "false";
            this.B2_2КнопкаБК1_7.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_7 = "false";
            this.B2_2КнопкаБК1_8.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_8 = "false";
            this.B2_2КнопкаБК1_9.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_9 = "false";
        }

        private void B2_2КнопкаБК1_6_Click(object sender, System.EventArgs e)
        {
            this.B2_2КнопкаБК1_1.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_1 = "false";
            this.B2_2КнопкаБК1_2.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_2 = "false";
            this.B2_2КнопкаБК1_3.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_3 = "false";
            this.B2_2КнопкаБК1_4.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_4 = "false";
            this.B2_2КнопкаБК1_5.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_5 = "false";
            this.B2_2КнопкаБК1_6.Visible = false;
            B2_2Parameters.B2_2КнопкаБК1_6 = "true";
            this.B2_2КнопкаБК1_7.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_7 = "false";
            this.B2_2КнопкаБК1_8.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_8 = "false";
            this.B2_2КнопкаБК1_9.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_9 = "false";
        }

        private void B2_2КнопкаБК1_7_Click(object sender, System.EventArgs e)
        {
            this.B2_2КнопкаБК1_1.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_1 = "false";
            this.B2_2КнопкаБК1_2.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_2 = "false";
            this.B2_2КнопкаБК1_3.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_3 = "false";
            this.B2_2КнопкаБК1_4.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_4 = "false";
            this.B2_2КнопкаБК1_5.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_5 = "false";
            this.B2_2КнопкаБК1_6.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_6 = "false";
            this.B2_2КнопкаБК1_7.Visible = false;
            B2_2Parameters.B2_2КнопкаБК1_7 = "true";
            this.B2_2КнопкаБК1_8.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_8 = "false";
            this.B2_2КнопкаБК1_9.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_9 = "false";
        }

        private void B2_2КнопкаБК1_8_Click(object sender, System.EventArgs e)
        {
            this.B2_2КнопкаБК1_1.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_1 = "false";
            this.B2_2КнопкаБК1_2.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_2 = "false";
            this.B2_2КнопкаБК1_3.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_3 = "false";
            this.B2_2КнопкаБК1_4.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_4 = "false";
            this.B2_2КнопкаБК1_5.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_5 = "false";
            this.B2_2КнопкаБК1_6.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_6 = "false";
            this.B2_2КнопкаБК1_7.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_7 = "false";
            this.B2_2КнопкаБК1_8.Visible = false;
            B2_2Parameters.B2_2КнопкаБК1_8 = "true";
            this.B2_2КнопкаБК1_9.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_9 = "false";
        }

        private void B2_2КнопкаБК1_9_Click(object sender, System.EventArgs e)
        {
            this.B2_2КнопкаБК1_1.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_1 = "false";
            this.B2_2КнопкаБК1_2.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_2 = "false";
            this.B2_2КнопкаБК1_3.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_3 = "false";
            this.B2_2КнопкаБК1_4.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_4 = "false";
            this.B2_2КнопкаБК1_5.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_5 = "false";
            this.B2_2КнопкаБК1_6.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_6 = "false";
            this.B2_2КнопкаБК1_7.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_7 = "false";
            this.B2_2КнопкаБК1_8.Visible = true;
            B2_2Parameters.B2_2КнопкаБК1_8 = "false";
            this.B2_2КнопкаБК1_9.Visible = false;
            B2_2Parameters.B2_2КнопкаБК1_9 = "true";
        }

        private void B2_2КнопкаБК2_1_Click(object sender, System.EventArgs e)
        {
            this.B2_2КнопкаБК2_1.Visible = false;
            B2_2Parameters.B2_2КнопкаБК2_1 = "true";
            this.B2_2КнопкаБК2_2.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_2 = "false";
            this.B2_2КнопкаБК2_3.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_3 = "false";
            this.B2_2КнопкаБК2_4.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_4 = "false";
            this.B2_2КнопкаБК2_5.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_5 = "false";
            this.B2_2КнопкаБК2_6.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_6 = "false";
            this.B2_2КнопкаБК2_7.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_7 = "false";
            this.B2_2КнопкаБК2_8.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_8 = "false";
            this.B2_2КнопкаБК2_9.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_9 = "false";
        }

        private void B2_2КнопкаБК2_2_Click(object sender, System.EventArgs e)
        {
            this.B2_2КнопкаБК2_1.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_1 = "false";
            this.B2_2КнопкаБК2_2.Visible = false;
            B2_2Parameters.B2_2КнопкаБК2_2 = "true";
            this.B2_2КнопкаБК2_3.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_3 = "false";
            this.B2_2КнопкаБК2_4.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_4 = "false";
            this.B2_2КнопкаБК2_5.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_5 = "false";
            this.B2_2КнопкаБК2_6.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_6 = "false";
            this.B2_2КнопкаБК2_7.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_7 = "false";
            this.B2_2КнопкаБК2_8.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_8 = "false";
            this.B2_2КнопкаБК2_9.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_9 = "false";
        }

        private void B2_2КнопкаБК2_3_Click(object sender, System.EventArgs e)
        {
            this.B2_2КнопкаБК2_1.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_1 = "false";
            this.B2_2КнопкаБК2_2.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_2 = "false";
            this.B2_2КнопкаБК2_3.Visible = false;
            B2_2Parameters.B2_2КнопкаБК2_3 = "true";
            this.B2_2КнопкаБК2_4.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_4 = "false";
            this.B2_2КнопкаБК2_5.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_5 = "false";
            this.B2_2КнопкаБК2_6.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_6 = "false";
            this.B2_2КнопкаБК2_7.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_7 = "false";
            this.B2_2КнопкаБК2_8.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_8 = "false";
            this.B2_2КнопкаБК2_9.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_9 = "false";
        }

        private void B2_2КнопкаБК2_4_Click(object sender, System.EventArgs e)
        {
            this.B2_2КнопкаБК2_1.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_1 = "false";
            this.B2_2КнопкаБК2_2.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_2 = "false";
            this.B2_2КнопкаБК2_3.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_3 = "false";
            this.B2_2КнопкаБК2_4.Visible = false;
            B2_2Parameters.B2_2КнопкаБК2_4 = "true";
            this.B2_2КнопкаБК2_5.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_5 = "false";
            this.B2_2КнопкаБК2_6.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_6 = "false";
            this.B2_2КнопкаБК2_7.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_7 = "false";
            this.B2_2КнопкаБК2_8.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_8 = "false";
            this.B2_2КнопкаБК2_9.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_9 = "false";
        }

        private void B2_2КнопкаБК2_5_Click(object sender, System.EventArgs e)
        {
            this.B2_2КнопкаБК2_1.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_1 = "false";
            this.B2_2КнопкаБК2_2.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_2 = "false";
            this.B2_2КнопкаБК2_3.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_3 = "false";
            this.B2_2КнопкаБК2_4.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_4 = "false";
            this.B2_2КнопкаБК2_5.Visible = false;
            B2_2Parameters.B2_2КнопкаБК2_5 = "true";
            this.B2_2КнопкаБК2_6.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_6 = "false";
            this.B2_2КнопкаБК2_7.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_7 = "false";
            this.B2_2КнопкаБК2_8.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_8 = "false";
            this.B2_2КнопкаБК2_9.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_9 = "false";
        }

        private void B2_2КнопкаБК2_6_Click(object sender, System.EventArgs e)
        {
            this.B2_2КнопкаБК2_1.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_1 = "false";
            this.B2_2КнопкаБК2_2.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_2 = "false";
            this.B2_2КнопкаБК2_3.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_3 = "false";
            this.B2_2КнопкаБК2_4.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_4 = "false";
            this.B2_2КнопкаБК2_5.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_5 = "false";
            this.B2_2КнопкаБК2_6.Visible = false;
            B2_2Parameters.B2_2КнопкаБК2_6 = "true";
            this.B2_2КнопкаБК2_7.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_7 = "false";
            this.B2_2КнопкаБК2_8.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_8 = "false";
            this.B2_2КнопкаБК2_9.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_9 = "false";
        }

        private void B2_2КнопкаБК2_7_Click(object sender, System.EventArgs e)
        {
            this.B2_2КнопкаБК2_1.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_1 = "false";
            this.B2_2КнопкаБК2_2.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_2 = "false";
            this.B2_2КнопкаБК2_3.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_3 = "false";
            this.B2_2КнопкаБК2_4.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_4 = "false";
            this.B2_2КнопкаБК2_5.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_5 = "false";
            this.B2_2КнопкаБК2_6.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_6 = "false";
            this.B2_2КнопкаБК2_7.Visible = false;
            B2_2Parameters.B2_2КнопкаБК2_7 = "true";
            this.B2_2КнопкаБК2_8.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_8 = "false";
            this.B2_2КнопкаБК2_9.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_9 = "false";
        }

        private void B2_2КнопкаБК2_8_Click(object sender, System.EventArgs e)
        {
            this.B2_2КнопкаБК2_1.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_1 = "false";
            this.B2_2КнопкаБК2_2.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_2 = "false";
            this.B2_2КнопкаБК2_3.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_3 = "false";
            this.B2_2КнопкаБК2_4.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_4 = "false";
            this.B2_2КнопкаБК2_5.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_5 = "false";
            this.B2_2КнопкаБК2_6.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_6 = "false";
            this.B2_2КнопкаБК2_7.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_7 = "false";
            this.B2_2КнопкаБК2_8.Visible = false;
            B2_2Parameters.B2_2КнопкаБК2_8 = "true";
            this.B2_2КнопкаБК2_9.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_9 = "false";
        }

        private void B2_2КнопкаБК2_9_Click(object sender, System.EventArgs e)
        {
            this.B2_2КнопкаБК2_1.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_1 = "false";
            this.B2_2КнопкаБК2_2.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_2 = "false";
            this.B2_2КнопкаБК2_3.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_3 = "false";
            this.B2_2КнопкаБК2_4.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_4 = "false";
            this.B2_2КнопкаБК2_5.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_5 = "false";
            this.B2_2КнопкаБК2_6.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_6 = "false";
            this.B2_2КнопкаБК2_7.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_7 = "false";
            this.B2_2КнопкаБК2_8.Visible = true;
            B2_2Parameters.B2_2КнопкаБК2_8 = "false";
            this.B2_2КнопкаБК2_9.Visible = false;
            B2_2Parameters.B2_2КнопкаБК2_9 = "true";
        }
        #endregion

        #region Колодки
        private void B2_2КолодкаТЛГпр_1_Click(object sender, System.EventArgs e)
        {
            if (B2_2Parameters.B2_2КолодкаТЛГпр_1 == "false")
            {
                this.B2_2КолодкаТЛГпр_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B2_2КолодкаТЛГпр_2.Visible = false;
                B2_2Parameters.B2_2КолодкаТЛГпр_1 = "true";
                this.B2_2КолодкаТЛГпр_2.BackgroundImage = null;
                B2_2Parameters.B2_2КолодкаТЛГпр_2 = "false";
            }
            else
            {
                this.B2_2КолодкаТЛГпр_1.BackgroundImage = null;
                B2_2Parameters.B2_2КолодкаТЛГпр_1 = "false";
                this.B2_2КолодкаТЛГпр_2.Visible = true;
            }
        }
        private void B2_2КолодкаТЛГпр_2_Click(object sender, System.EventArgs e)
        {
            if (B2_2Parameters.B2_2КолодкаТЛГпр_2 == "false")
            {
                this.B2_2КолодкаТЛГпр_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B2_2КолодкаТЛГпр_1.Visible = false;
                B2_2Parameters.B2_2КолодкаТЛГпр_2 = "true";
                this.B2_2КолодкаТЛГпр_1.BackgroundImage = null;
                B2_2Parameters.B2_2КолодкаТЛГпр_1 = "false";
            }
            else
            {
                this.B2_2КолодкаТЛГпр_1.Visible = true;
                this.B2_2КолодкаТЛГпр_2.BackgroundImage = null;
                B2_2Parameters.B2_2КолодкаТЛГпр_2 = "false";
            }
        }


        private void B2_2КолодкаТКСпр2_1_Click(object sender, System.EventArgs e)
        {
            if (B2_2Parameters.B2_2КолодкаТКСпр2_1 == "false")
            {
                this.B2_2КолодкаТКСпр2_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B2_2КолодкаТКСпр2_2.Visible = false;
                B2_2Parameters.B2_2КолодкаТКСпр2_1 = "true";
                this.B2_2КолодкаТКСпр2_2.BackgroundImage = null;
                B2_2Parameters.B2_2КолодкаТКСпр2_2 = "false";
            }
            else
            {
                this.B2_2КолодкаТКСпр2_1.BackgroundImage = null;
                B2_2Parameters.B2_2КолодкаТКСпр2_1 = "false";
                this.B2_2КолодкаТКСпр2_2.Visible = true;
            }
        }

        private void B2_2КолодкаТКСпр2_2_Click(object sender, System.EventArgs e)
        {
            if (B2_2Parameters.B2_2КолодкаТКСпр2_2 == "false")
            {
                this.B2_2КолодкаТКСпр2_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B2_2КолодкаТКСпр2_1.Visible = false;
                B2_2Parameters.B2_2КолодкаТКСпр2_2 = "true";
                this.B2_2КолодкаТКСпр2_1.BackgroundImage = null;
                B2_2Parameters.B2_2КолодкаТКСпр2_1 = "false";
            }
            else
            {
                this.B2_2КолодкаТКСпр2_1.Visible = true;
                this.B2_2КолодкаТКСпр2_2.BackgroundImage = null;
                B2_2Parameters.B2_2КолодкаТКСпр2_2 = "false";
            }
        }
        #endregion

        private void B2_2ТумблерМуДу_Click(object sender, System.EventArgs e)
        {
            if (B2_2Parameters.B2_2ТумблерМуДу == "Му")
            {
                this.B2_2ТумблерМуДу.BackgroundImage = ControlElementImages.tumblerType4Down;
                B2_2Parameters.B2_2ТумблерМуДу = "Ду";
            }
            else
            {
                this.B2_2ТумблерМуДу.BackgroundImage = ControlElementImages.tumblerType4Up;
                B2_2Parameters.B2_2ТумблерМуДу = "Му";
            }
        }

        private void InitializeTumblersPosition()
        {
            this.B2_2ТумблерМуДу.BackgroundImage = B2_2Parameters.B2_2ТумблерМуДу == "Ду"
                ? ControlElementImages.tumblerType4Down
                : ControlElementImages.tumblerType4Up;
        }

        private void InitializeButtonsPosition()
        {
            if (B2_2Parameters.B2_2КнопкаБК1_1 == "true")
                this.B2_2КнопкаБК1_1.Visible = false;

            else if (B2_2Parameters.B2_2КнопкаБК1_2 == "true")
                this.B2_2КнопкаБК1_2.Visible = false;

            else if (B2_2Parameters.B2_2КнопкаБК1_3 == "true")

                this.B2_2КнопкаБК1_3.Visible = false;

            else if (B2_2Parameters.B2_2КнопкаБК1_4 == "true")

                this.B2_2КнопкаБК1_4.Visible = false;

            else if (B2_2Parameters.B2_2КнопкаБК1_5 == "true")
                this.B2_2КнопкаБК1_5.Visible = false;

            else if (B2_2Parameters.B2_2КнопкаБК1_6 == "true")
                this.B2_2КнопкаБК1_6.Visible = false;

            else if (B2_2Parameters.B2_2КнопкаБК1_7 == "true")
                this.B2_2КнопкаБК1_7.Visible = false;

            else if (B2_2Parameters.B2_2КнопкаБК1_8 == "true")
                this.B2_2КнопкаБК1_8.Visible = false;

            else if (B2_2Parameters.B2_2КнопкаБК1_9 == "true")
                this.B2_2КнопкаБК1_9.Visible = false;




            if (B2_2Parameters.B2_2КнопкаБК2_1 == "true")
                this.B2_2КнопкаБК2_1.Visible = false;


            else if (B2_2Parameters.B2_2КнопкаБК2_2 == "true")
                this.B2_2КнопкаБК2_2.Visible = false;

            else if (B2_2Parameters.B2_2КнопкаБК2_3 == "true")
                this.B2_2КнопкаБК2_3.Visible = false;

            else if (B2_2Parameters.B2_2КнопкаБК2_4 == "true")
                this.B2_2КнопкаБК2_4.Visible = false;

            else if (B2_2Parameters.B2_2КнопкаБК2_5 == "true")
                this.B2_2КнопкаБК2_5.Visible = false;

            else if (B2_2Parameters.B2_2КнопкаБК2_6 == "true")
                this.B2_2КнопкаБК2_6.Visible = false;

            else if (B2_2Parameters.B2_2КнопкаБК2_7 == "true")
                this.B2_2КнопкаБК2_7.Visible = false;

            else if (B2_2Parameters.B2_2КнопкаБК2_8 == "true")
                this.B2_2КнопкаБК2_8.Visible = false;

            else if (B2_2Parameters.B2_2КнопкаБК2_9 == "true")
                this.B2_2КнопкаБК2_9.Visible = false;


            if (B2_2Parameters.B2_2КолодкаТЛГпр_1 == "true")
            {
                this.B2_2КолодкаТЛГпр_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B2_2КолодкаТЛГпр_2.Visible = false;
                this.B2_2КолодкаТЛГпр_2.BackgroundImage = null;
            }
            else if (B2_2Parameters.B2_2КолодкаТЛГпр_2 == "true")
            {
                this.B2_2КолодкаТЛГпр_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B2_2КолодкаТЛГпр_1.Visible = false;
                this.B2_2КолодкаТЛГпр_1.BackgroundImage = null;
            }


            if (B2_2Parameters.B2_2КолодкаТКСпр2_1 == "true")
            {
                this.B2_2КолодкаТКСпр2_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B2_2КолодкаТКСпр2_2.Visible = false;
                this.B2_2КолодкаТКСпр2_2.BackgroundImage = null;
            }
            else if (B2_2Parameters.B2_2КолодкаТКСпр2_2 == "true")
            {
                this.B2_2КолодкаТКСпр2_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B2_2КолодкаТКСпр2_1.Visible = false;
                this.B2_2КолодкаТКСпр2_1.BackgroundImage = null;
            }

        }

    }
}