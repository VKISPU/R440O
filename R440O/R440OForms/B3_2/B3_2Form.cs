//-----------------------------------------------------------------------
// <copyright file="B3_2Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.B3_2
{
    using System.Windows.Forms;
    using Parameters;

    /// <summary>
    /// Форма блока Б3-1
    /// </summary>
    public partial class B3_2Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="B3_2Form"/>
        /// </summary>
        public B3_2Form()
        {
            this.InitializeComponent();
            this.InitializeButtonsPosition();
            this.InitializeTumblersPosition();
        }

        #region УКК1 Колодки
        private void B3_2КолодкаУКК1_1_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаУКК1_1 == "false")
            {
                this.B3_2КолодкаУКК1_1.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаУКК1_1 = "true";
                this.B3_2КолодкаУКК1_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_2 = "false";
                this.B3_2КолодкаУКК1_3.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_3 = "false";
                this.B3_2КолодкаУКК1_4.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_4 = "false";
                this.B3_2КолодкаУКК1_5.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_5 = "false";
                this.B3_2КолодкаУКК1_6.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_6 = "false";
                this.B3_2КолодкаУКК1_7.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_7 = "false";
                this.B3_2КолодкаУКК1_8.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_8 = "false";
                this.B3_2КолодкаУКК1_9.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_9 = "false";
            }
            else
            {
                this.B3_2КолодкаУКК1_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_1 = "false";
            }
        }

        private void B3_2КолодкаУКК1_2_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаУКК1_2 == "false")
            {
                this.B3_2КолодкаУКК1_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_1 = "false";

                this.B3_2КолодкаУКК1_2.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаУКК1_2 = "true";
                this.B3_2КолодкаУКК1_3.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_3 = "false";
                this.B3_2КолодкаУКК1_4.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_4 = "false";
                this.B3_2КолодкаУКК1_5.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_5 = "false";
                this.B3_2КолодкаУКК1_6.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_6 = "false";
                this.B3_2КолодкаУКК1_7.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_7 = "false";
                this.B3_2КолодкаУКК1_8.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_8 = "false";
                this.B3_2КолодкаУКК1_9.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_9 = "false";
            }
            else
            {
                this.B3_2КолодкаУКК1_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_2 = "false";
            }
        }

        private void B3_2КолодкаУКК1_3_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаУКК1_3 == "false")
            {
                this.B3_2КолодкаУКК1_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_1 = "false";
                this.B3_2КолодкаУКК1_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_2 = "false";
                this.B3_2КолодкаУКК1_3.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаУКК1_3 = "true";
                this.B3_2КолодкаУКК1_4.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_4 = "false";
                this.B3_2КолодкаУКК1_5.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_5 = "false";
                this.B3_2КолодкаУКК1_6.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_6 = "false";
                this.B3_2КолодкаУКК1_7.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_7 = "false";
                this.B3_2КолодкаУКК1_8.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_8 = "false";
                this.B3_2КолодкаУКК1_9.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_9 = "false";
            }
            else
            {
                this.B3_2КолодкаУКК1_3.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_3 = "false";
            }
        }

        private void B3_2КолодкаУКК1_4_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаУКК1_4 == "false")
            {
                this.B3_2КолодкаУКК1_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_1 = "false";
                this.B3_2КолодкаУКК1_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_2 = "false";
                this.B3_2КолодкаУКК1_3.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_3 = "false";
                this.B3_2КолодкаУКК1_4.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаУКК1_4 = "true";
                this.B3_2КолодкаУКК1_5.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_5 = "false";
                this.B3_2КолодкаУКК1_6.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_6 = "false";
                this.B3_2КолодкаУКК1_7.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_7 = "false";
                this.B3_2КолодкаУКК1_8.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_8 = "false";
                this.B3_2КолодкаУКК1_9.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_9 = "false";
            }
            else
            {
                this.B3_2КолодкаУКК1_4.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_4 = "false";
            }
        }

        private void B3_2КолодкаУКК1_5_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаУКК1_5 == "false")
            {
                this.B3_2КолодкаУКК1_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_1 = "false";
                this.B3_2КолодкаУКК1_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_2 = "false";
                this.B3_2КолодкаУКК1_3.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_3 = "false";
                this.B3_2КолодкаУКК1_4.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_4 = "false";
                this.B3_2КолодкаУКК1_5.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаУКК1_5 = "true";
                this.B3_2КолодкаУКК1_6.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_6 = "false";
                this.B3_2КолодкаУКК1_7.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_7 = "false";
                this.B3_2КолодкаУКК1_8.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_8 = "false";
                this.B3_2КолодкаУКК1_9.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_9 = "false";
            }
            else
            {
                this.B3_2КолодкаУКК1_5.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_5 = "false";
            }
        }

        private void B3_2КолодкаУКК1_6_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаУКК1_6 == "false")
            {
                this.B3_2КолодкаУКК1_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_1 = "false";
                this.B3_2КолодкаУКК1_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_2 = "false";
                this.B3_2КолодкаУКК1_3.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_3 = "false";
                this.B3_2КолодкаУКК1_4.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_4 = "false";
                this.B3_2КолодкаУКК1_5.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_5 = "false";
                this.B3_2КолодкаУКК1_6.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаУКК1_6 = "true";
                this.B3_2КолодкаУКК1_7.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_7 = "false";
                this.B3_2КолодкаУКК1_8.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_8 = "false";
                this.B3_2КолодкаУКК1_9.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_9 = "false";
            }
            else
            {
                this.B3_2КолодкаУКК1_6.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_6 = "false";
            }
        }

        private void B3_2КолодкаУКК1_7_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаУКК1_7 == "false")
            {
                this.B3_2КолодкаУКК1_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_1 = "false";
                this.B3_2КолодкаУКК1_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_2 = "false";
                this.B3_2КолодкаУКК1_3.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_3 = "false";
                this.B3_2КолодкаУКК1_4.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_4 = "false";
                this.B3_2КолодкаУКК1_5.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_5 = "false";
                this.B3_2КолодкаУКК1_6.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_6 = "false";
                this.B3_2КолодкаУКК1_7.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаУКК1_7 = "true";
                this.B3_2КолодкаУКК1_8.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_8 = "false";
                this.B3_2КолодкаУКК1_9.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_9 = "false";
            }
            else
            {
                this.B3_2КолодкаУКК1_7.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_7 = "false";
            }
        }

        private void B3_2КолодкаУКК1_8_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаУКК1_8 == "false")
            {
                this.B3_2КолодкаУКК1_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_1 = "false";
                this.B3_2КолодкаУКК1_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_2 = "false";
                this.B3_2КолодкаУКК1_3.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_3 = "false";
                this.B3_2КолодкаУКК1_4.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_4 = "false";
                this.B3_2КолодкаУКК1_5.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_5 = "false";
                this.B3_2КолодкаУКК1_6.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_6 = "false";
                this.B3_2КолодкаУКК1_7.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_7 = "false";
                this.B3_2КолодкаУКК1_8.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаУКК1_8 = "true";
                this.B3_2КолодкаУКК1_9.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_9 = "false";
            }
            else
            {
                this.B3_2КолодкаУКК1_8.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_8 = "false";
            }
        }

        private void B3_2КолодкаУКК1_9_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаУКК1_9 == "false")
            {
                this.B3_2КолодкаУКК1_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_1 = "false";
                this.B3_2КолодкаУКК1_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_2 = "false";
                this.B3_2КолодкаУКК1_3.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_3 = "false";
                this.B3_2КолодкаУКК1_4.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_4 = "false";
                this.B3_2КолодкаУКК1_5.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_5 = "false";
                this.B3_2КолодкаУКК1_6.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_6 = "false";
                this.B3_2КолодкаУКК1_7.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_7 = "false";
                this.B3_2КолодкаУКК1_8.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_8 = "false";
                this.B3_2КолодкаУКК1_9.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаУКК1_9 = "true";
            }
            else
            {
                this.B3_2КолодкаУКК1_9.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК1_9 = "false";
            }
        }
        #endregion

        #region УКК2 Колодки
        private void B3_2КолодкаУКК2_1_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаУКК2_1 == "false")
            {
                this.B3_2КолодкаУКК2_1.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаУКК2_1 = "true";
                this.B3_2КолодкаУКК2_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_2 = "false";
                this.B3_2КолодкаУКК2_3.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_3 = "false";
                this.B3_2КолодкаУКК2_4.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_4 = "false";
                this.B3_2КолодкаУКК2_5.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_5 = "false";
                this.B3_2КолодкаУКК2_6.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_6 = "false";
                this.B3_2КолодкаУКК2_7.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_7 = "false";
                this.B3_2КолодкаУКК2_8.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_8 = "false";
                this.B3_2КолодкаУКК2_9.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_9 = "false";
            }
            else
            {
                this.B3_2КолодкаУКК2_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_1 = "false";
            }
        }

        private void B3_2КолодкаУКК2_2_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаУКК2_2 == "false")
            {
                this.B3_2КолодкаУКК2_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_1 = "false";

                this.B3_2КолодкаУКК2_2.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаУКК2_2 = "true";
                this.B3_2КолодкаУКК2_3.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_3 = "false";
                this.B3_2КолодкаУКК2_4.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_4 = "false";
                this.B3_2КолодкаУКК2_5.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_5 = "false";
                this.B3_2КолодкаУКК2_6.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_6 = "false";
                this.B3_2КолодкаУКК2_7.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_7 = "false";
                this.B3_2КолодкаУКК2_8.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_8 = "false";
                this.B3_2КолодкаУКК2_9.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_9 = "false";
            }
            else
            {
                this.B3_2КолодкаУКК2_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_2 = "false";
            }
        }

        private void B3_2КолодкаУКК2_3_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаУКК2_3 == "false")
            {
                this.B3_2КолодкаУКК2_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_1 = "false";
                this.B3_2КолодкаУКК2_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_2 = "false";
                this.B3_2КолодкаУКК2_3.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаУКК2_3 = "true";
                this.B3_2КолодкаУКК2_4.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_4 = "false";
                this.B3_2КолодкаУКК2_5.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_5 = "false";
                this.B3_2КолодкаУКК2_6.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_6 = "false";
                this.B3_2КолодкаУКК2_7.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_7 = "false";
                this.B3_2КолодкаУКК2_8.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_8 = "false";
                this.B3_2КолодкаУКК2_9.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_9 = "false";
            }
            else
            {
                this.B3_2КолодкаУКК2_3.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_3 = "false";
            }
        }

        private void B3_2КолодкаУКК2_4_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаУКК2_4 == "false")
            {
                this.B3_2КолодкаУКК2_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_1 = "false";
                this.B3_2КолодкаУКК2_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_2 = "false";
                this.B3_2КолодкаУКК2_3.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_3 = "false";
                this.B3_2КолодкаУКК2_4.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаУКК2_4 = "true";
                this.B3_2КолодкаУКК2_5.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_5 = "false";
                this.B3_2КолодкаУКК2_6.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_6 = "false";
                this.B3_2КолодкаУКК2_7.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_7 = "false";
                this.B3_2КолодкаУКК2_8.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_8 = "false";
                this.B3_2КолодкаУКК2_9.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_9 = "false";
            }
            else
            {
                this.B3_2КолодкаУКК2_4.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_4 = "false";
            }
        }

        private void B3_2КолодкаУКК2_5_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаУКК2_5 == "false")
            {
                this.B3_2КолодкаУКК2_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_1 = "false";
                this.B3_2КолодкаУКК2_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_2 = "false";
                this.B3_2КолодкаУКК2_3.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_3 = "false";
                this.B3_2КолодкаУКК2_4.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_4 = "false";
                this.B3_2КолодкаУКК2_5.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаУКК2_5 = "true";
                this.B3_2КолодкаУКК2_6.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_6 = "false";
                this.B3_2КолодкаУКК2_7.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_7 = "false";
                this.B3_2КолодкаУКК2_8.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_8 = "false";
                this.B3_2КолодкаУКК2_9.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_9 = "false";
            }
            else
            {
                this.B3_2КолодкаУКК2_5.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_5 = "false";
            }
        }

        private void B3_2КолодкаУКК2_6_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаУКК2_6 == "false")
            {
                this.B3_2КолодкаУКК2_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_1 = "false";
                this.B3_2КолодкаУКК2_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_2 = "false";
                this.B3_2КолодкаУКК2_3.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_3 = "false";
                this.B3_2КолодкаУКК2_4.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_4 = "false";
                this.B3_2КолодкаУКК2_5.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_5 = "false";
                this.B3_2КолодкаУКК2_6.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаУКК2_6 = "true";
                this.B3_2КолодкаУКК2_7.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_7 = "false";
                this.B3_2КолодкаУКК2_8.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_8 = "false";
                this.B3_2КолодкаУКК2_9.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_9 = "false";
            }
            else
            {
                this.B3_2КолодкаУКК2_6.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_6 = "false";
            }
        }

        private void B3_2КолодкаУКК2_7_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаУКК2_7 == "false")
            {
                this.B3_2КолодкаУКК2_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_1 = "false";
                this.B3_2КолодкаУКК2_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_2 = "false";
                this.B3_2КолодкаУКК2_3.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_3 = "false";
                this.B3_2КолодкаУКК2_4.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_4 = "false";
                this.B3_2КолодкаУКК2_5.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_5 = "false";
                this.B3_2КолодкаУКК2_6.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_6 = "false";
                this.B3_2КолодкаУКК2_7.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаУКК2_7 = "true";
                this.B3_2КолодкаУКК2_8.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_8 = "false";
                this.B3_2КолодкаУКК2_9.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_9 = "false";
            }
            else
            {
                this.B3_2КолодкаУКК2_7.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_7 = "false";
            }
        }

        private void B3_2КолодкаУКК2_8_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаУКК2_8 == "false")
            {
                this.B3_2КолодкаУКК2_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_1 = "false";
                this.B3_2КолодкаУКК2_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_2 = "false";
                this.B3_2КолодкаУКК2_3.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_3 = "false";
                this.B3_2КолодкаУКК2_4.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_4 = "false";
                this.B3_2КолодкаУКК2_5.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_5 = "false";
                this.B3_2КолодкаУКК2_6.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_6 = "false";
                this.B3_2КолодкаУКК2_7.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_7 = "false";
                this.B3_2КолодкаУКК2_8.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаУКК2_8 = "true";
                this.B3_2КолодкаУКК2_9.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_9 = "false";
            }
            else
            {
                this.B3_2КолодкаУКК2_8.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_8 = "false";
            }
        }

        private void B3_2КолодкаУКК2_9_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаУКК2_9 == "false")
            {
                this.B3_2КолодкаУКК2_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_1 = "false";
                this.B3_2КолодкаУКК2_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_2 = "false";
                this.B3_2КолодкаУКК2_3.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_3 = "false";
                this.B3_2КолодкаУКК2_4.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_4 = "false";
                this.B3_2КолодкаУКК2_5.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_5 = "false";
                this.B3_2КолодкаУКК2_6.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_6 = "false";
                this.B3_2КолодкаУКК2_7.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_7 = "false";
                this.B3_2КолодкаУКК2_8.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_8 = "false";
                this.B3_2КолодкаУКК2_9.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаУКК2_9 = "true";
            }
            else
            {
                this.B3_2КолодкаУКК2_9.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаУКК2_9 = "false";
            }
        }
        #endregion

        #region ОКпр1 Колодки
        private void B3_2КолодкаОКпр1_син_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаОКпр1_син == "false")
            {
                this.B3_2КолодкаОКпр1_син.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаОКпр1_син = "true";
                this.B3_2КолодкаОКпр1_ас.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаОКпр1_ас = "false";
            }
            else
            {
                this.B3_2КолодкаОКпр1_син.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаОКпр1_син = "false";
            }
        }

        private void B3_2КолодкаОКпр1_ас_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаОКпр1_ас == "false")
            {
                this.B3_2КолодкаОКпр1_ас.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаОКпр1_ас = "true";
                this.B3_2КолодкаОКпр1_син.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаОКпр1_син = "false";
            }
            else
            {
                this.B3_2КолодкаОКпр1_ас.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаОКпр1_ас = "false";
            }
        }
        #endregion

        #region ОКпр2 Колодки
        private void B3_2КолодкаОКпр2_син_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаОКпр2_син == "false")
            {
                this.B3_2КолодкаОКпр2_син.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаОКпр2_син = "true";
                this.B3_2КолодкаОКпр2_ас.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаОКпр2_ас = "false";
            }
            else
            {
                this.B3_2КолодкаОКпр2_син.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаОКпр2_син = "false";
            }
        }

        private void B3_2КолодкаОКпр2_ас_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаОКпр2_ас == "false")
            {
                this.B3_2КолодкаОКпр2_ас.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаОКпр2_ас = "true";
                this.B3_2КолодкаОКпр2_син.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаОКпр2_син = "false";
            }
            else
            {
                this.B3_2КолодкаОКпр2_ас.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаОКпр2_ас = "false";
            }
        }
        #endregion

        #region КРПР Колодки
        private void B3_2КолодкаКРПР_1_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаКРПР_1 == "false")
            {
                this.B3_2КолодкаКРПР_1.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаКРПР_1 = "true";
                this.B3_2КолодкаКРПР_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаКРПР_2 = "false";
                this.B3_2КолодкаКРПР_3.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаКРПР_3 = "false";
                this.B3_2КолодкаКРПР_4.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаКРПР_4 = "false";
                this.B3_2КолодкаКРПР_5.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаКРПР_5 = "false";
            }
            else
            {
                this.B3_2КолодкаКРПР_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаКРПР_1 = "false";
            }
        }

        private void B3_2КолодкаКРПР_2_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаКРПР_2 == "false")
            {
                this.B3_2КолодкаКРПР_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаКРПР_1 = "false";
                this.B3_2КолодкаКРПР_2.BackgroundImage = ControlElementImages.jumperType2; ;
                B3_2Parameters.B3_2КолодкаКРПР_2 = "true";
                this.B3_2КолодкаКРПР_3.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаКРПР_3 = "false";
                this.B3_2КолодкаКРПР_4.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаКРПР_4 = "false";
                this.B3_2КолодкаКРПР_5.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаКРПР_5 = "false";
            }
            else
            {
                this.B3_2КолодкаКРПР_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаКРПР_2 = "false";
            }
        }

        private void B3_2КолодкаКРПР_3_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаКРПР_3 == "false")
            {
                this.B3_2КолодкаКРПР_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаКРПР_1 = "false";
                this.B3_2КолодкаКРПР_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаКРПР_2 = "false";
                this.B3_2КолодкаКРПР_3.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаКРПР_3 = "true";
                this.B3_2КолодкаКРПР_4.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаКРПР_4 = "false";
                this.B3_2КолодкаКРПР_5.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаКРПР_5 = "false";
            }
            else
            {
                this.B3_2КолодкаКРПР_3.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаКРПР_3 = "false";
            }
        }

        private void B3_2КолодкаКРПР_4_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаКРПР_4 == "false")
            {
                this.B3_2КолодкаКРПР_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаКРПР_1 = "false";
                this.B3_2КолодкаКРПР_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаКРПР_2 = "false";
                this.B3_2КолодкаКРПР_3.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаКРПР_3 = "false";
                this.B3_2КолодкаКРПР_4.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаКРПР_4 = "true";
                this.B3_2КолодкаКРПР_5.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаКРПР_5 = "false";
            }
            else
            {
                this.B3_2КолодкаКРПР_4.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаКРПР_4 = "false";
            }
        }

        private void B3_2КолодкаКРПР_5_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаКРПР_5 == "false")
            {
                this.B3_2КолодкаКРПР_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаКРПР_1 = "false";
                this.B3_2КолодкаКРПР_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаКРПР_2 = "false";
                this.B3_2КолодкаКРПР_3.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаКРПР_3 = "false";
                this.B3_2КолодкаКРПР_4.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаКРПР_5 = "false";
                this.B3_2КолодкаКРПР_5.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаКРПР_5 = "true";
            }
            else
            {
                this.B3_2КолодкаКРПР_5.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаКРПР_5 = "false";
            }
        }
        #endregion

        #region ТЛГпр1 Колодки
        private void B3_2КолодкаТЛГпр1_1_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаТЛГпр1_1 == "false")
            {
                this.B3_2КолодкаТЛГпр1_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B3_2КолодкаТЛГпр1_2.Visible = false;
                B3_2Parameters.B3_2КолодкаТЛГпр1_1 = "true";
                this.B3_2КолодкаТЛГпр1_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаТЛГпр1_2 = "false";
            }
            else
            {
                this.B3_2КолодкаТЛГпр1_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаТЛГпр1_1 = "false";
                this.B3_2КолодкаТЛГпр1_2.Visible = true;
            }
        }

        private void B3_2КолодкаТЛГпр1_2_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаТЛГпр1_2 == "false")
            {
                this.B3_2КолодкаТЛГпр1_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B3_2КолодкаТЛГпр1_1.Visible = false;
                B3_2Parameters.B3_2КолодкаТЛГпр1_2 = "true";
                this.B3_2КолодкаТЛГпр1_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаТЛГпр1_1 = "false";
            }
            else
            {
                this.B3_2КолодкаТЛГпр1_1.Visible = true;
                this.B3_2КолодкаТЛГпр1_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаТЛГпр1_2 = "false";
            }
        }
        #endregion

        #region ТЛГпр2 Колодки
        private void B3_2КолодкаТЛГпр2_1_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаТЛГпр2_1 == "false")
            {
                this.B3_2КолодкаТЛГпр2_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B3_2КолодкаТЛГпр2_2.Visible = false;
                B3_2Parameters.B3_2КолодкаТЛГпр2_1 = "true";
                this.B3_2КолодкаТЛГпр2_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаТЛГпр2_2 = "false";
            }
            else
            {
                this.B3_2КолодкаТЛГпр2_2.Visible = true;
                this.B3_2КолодкаТЛГпр2_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаТЛГпр2_1 = "false";
            }
        }
        private void B3_2КолодкаТЛГпр2_2_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаТЛГпр2_2 == "false")
            {
                this.B3_2КолодкаТЛГпр2_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B3_2КолодкаТЛГпр2_1.Visible = false;
                B3_2Parameters.B3_2КолодкаТЛГпр2_2 = "true";
                this.B3_2КолодкаТЛГпр2_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаТЛГпр2_1 = "false";
            }
            else
            {
                this.B3_2КолодкаТЛГпр2_1.Visible = true;
                this.B3_2КолодкаТЛГпр2_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаТЛГпр2_2 = "false";
            }
        }
        #endregion

        #region ТЛГпр3 Колодки
        private void B3_2КолодкаТЛГпр3_1_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаТЛГпр3_1 == "false")
            {
                this.B3_2КолодкаТЛГпр3_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B3_2КолодкаТЛГпр3_2.Visible = false;
                B3_2Parameters.B3_2КолодкаТЛГпр3_1 = "true";
                this.B3_2КолодкаТЛГпр3_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаТЛГпр3_2 = "false";
            }
            else
            {
                this.B3_2КолодкаТЛГпр3_2.Visible = true;
                this.B3_2КолодкаТЛГпр3_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаТЛГпр3_1 = "false";
            }
        }

        private void B3_2КолодкаТЛГпр3_2_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаТЛГпр3_2 == "false")
            {
                this.B3_2КолодкаТЛГпр3_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B3_2КолодкаТЛГпр3_1.Visible = false;
                B3_2Parameters.B3_2КолодкаТЛГпр3_2 = "true";
                this.B3_2КолодкаТЛГпр3_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаТЛГпр3_1 = "false";
            }
            else
            {
                this.B3_2КолодкаТЛГпр3_1.Visible = true;
                this.B3_2КолодкаТЛГпр3_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаТЛГпр3_2 = "false";
            }
        }
        #endregion

        private void B3_2ТумблерМуДу_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2ТумблерМуДу == "Му")
            {
                this.B3_2ТумблерМуДу.BackgroundImage = ControlElementImages.tumblerType4Down;
                B3_2Parameters.B3_2ТумблерМуДу = "Ду";
            }
            else
            {
                this.B3_2ТумблерМуДу.BackgroundImage = ControlElementImages.tumblerType4Up;
                B3_2Parameters.B3_2ТумблерМуДу = "Му";
            }
        }

        private void InitializeButtonsPosition()
        {

            if (B3_2Parameters.B3_2КолодкаУКК1_1 == "true")
                this.B3_2КолодкаУКК1_1.BackgroundImage = ControlElementImages.jumperType2;

            else if (B3_2Parameters.B3_2КолодкаУКК1_2 == "true")
                this.B3_2КолодкаУКК1_2.BackgroundImage = ControlElementImages.jumperType2;

            else if (B3_2Parameters.B3_2КолодкаУКК1_3 == "true")
                this.B3_2КолодкаУКК1_3.BackgroundImage = ControlElementImages.jumperType2;

            else if (B3_2Parameters.B3_2КолодкаУКК1_4 == "true")
                this.B3_2КолодкаУКК1_4.BackgroundImage = ControlElementImages.jumperType2;

            else if (B3_2Parameters.B3_2КолодкаУКК1_5 == "true")
                this.B3_2КолодкаУКК1_5.BackgroundImage = ControlElementImages.jumperType2;

            else if (B3_2Parameters.B3_2КолодкаУКК1_6 == "true")
                this.B3_2КолодкаУКК1_6.BackgroundImage = ControlElementImages.jumperType2;

            else if (B3_2Parameters.B3_2КолодкаУКК1_7 == "true")
                this.B3_2КолодкаУКК1_7.BackgroundImage = ControlElementImages.jumperType2;

            else if (B3_2Parameters.B3_2КолодкаУКК1_8 == "true")
                this.B3_2КолодкаУКК1_8.BackgroundImage = ControlElementImages.jumperType2;

            else if (B3_2Parameters.B3_2КолодкаУКК1_9 == "true")
                this.B3_2КолодкаУКК1_9.BackgroundImage = ControlElementImages.jumperType2;


            if (B3_2Parameters.B3_2КолодкаУКК2_1 == "true")
                this.B3_2КолодкаУКК2_1.BackgroundImage = ControlElementImages.jumperType2;

            else if (B3_2Parameters.B3_2КолодкаУКК2_2 == "true")
                this.B3_2КолодкаУКК2_2.BackgroundImage = ControlElementImages.jumperType2;

            else if (B3_2Parameters.B3_2КолодкаУКК2_3 == "true")
                this.B3_2КолодкаУКК2_3.BackgroundImage = ControlElementImages.jumperType2;

            else if (B3_2Parameters.B3_2КолодкаУКК2_4 == "true")
                this.B3_2КолодкаУКК2_4.BackgroundImage = ControlElementImages.jumperType2;

            else if (B3_2Parameters.B3_2КолодкаУКК2_5 == "true")
                this.B3_2КолодкаУКК2_5.BackgroundImage = ControlElementImages.jumperType2;

            else if (B3_2Parameters.B3_2КолодкаУКК2_6 == "true")
                this.B3_2КолодкаУКК2_6.BackgroundImage = ControlElementImages.jumperType2;

            else if (B3_2Parameters.B3_2КолодкаУКК2_7 == "true")
                this.B3_2КолодкаУКК2_7.BackgroundImage = ControlElementImages.jumperType2;

            else if (B3_2Parameters.B3_2КолодкаУКК2_8 == "true")
                this.B3_2КолодкаУКК2_8.BackgroundImage = ControlElementImages.jumperType2;

            else if (B3_2Parameters.B3_2КолодкаУКК2_9 == "true")
                this.B3_2КолодкаУКК2_9.BackgroundImage = ControlElementImages.jumperType2;

            if (B3_2Parameters.B3_2КолодкаОКпр1_син == "true")
                this.B3_2КолодкаОКпр1_син.BackgroundImage = ControlElementImages.jumperType2;

            else if (B3_2Parameters.B3_2КолодкаОКпр1_ас == "true")
                this.B3_2КолодкаОКпр1_син.BackgroundImage = ControlElementImages.jumperType2;

            if (B3_2Parameters.B3_2КолодкаОКпр2_син == "true")
                this.B3_2КолодкаОКпр2_син.BackgroundImage = ControlElementImages.jumperType2;

            else if (B3_2Parameters.B3_2КолодкаОКпр2_ас == "true")
                this.B3_2КолодкаОКпр2_син.BackgroundImage = ControlElementImages.jumperType2;

            if (B3_2Parameters.B3_2КолодкаКРПР_1 == "true")
                this.B3_2КолодкаКРПР_1.BackgroundImage = ControlElementImages.jumperType2;

            else if (B3_2Parameters.B3_2КолодкаКРПР_2 == "true")
                this.B3_2КолодкаКРПР_2.BackgroundImage = ControlElementImages.jumperType2;

            else if (B3_2Parameters.B3_2КолодкаКРПР_3 == "true")
                this.B3_2КолодкаКРПР_3.BackgroundImage = ControlElementImages.jumperType2;

            else if (B3_2Parameters.B3_2КолодкаКРПР_4 == "true")
                this.B3_2КолодкаКРПР_4.BackgroundImage = ControlElementImages.jumperType2;

            else if (B3_2Parameters.B3_2КолодкаКРПР_5 == "true")
                this.B3_2КолодкаКРПР_5.BackgroundImage = ControlElementImages.jumperType2;

            if (B3_2Parameters.B3_2КолодкаТЛГпр1_1 == "true")
            {
                this.B3_2КолодкаТЛГпр1_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B3_2КолодкаТЛГпр1_2.Visible = false;
                this.B3_2КолодкаТЛГпр1_2.BackgroundImage = null;
            }
            else if (B3_2Parameters.B3_2КолодкаТЛГпр1_2 == "true")
            {
                this.B3_2КолодкаТЛГпр1_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B3_2КолодкаТЛГпр1_1.Visible = false;
                this.B3_2КолодкаТЛГпр1_1.BackgroundImage = null;
            }

            if (B3_2Parameters.B3_2КолодкаТЛГпр2_1 == "true")
            {
                this.B3_2КолодкаТЛГпр2_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B3_2КолодкаТЛГпр2_2.Visible = false;
                this.B3_2КолодкаТЛГпр2_2.BackgroundImage = null;
            }
            else if (B3_2Parameters.B3_2КолодкаТЛГпр2_2 == "true")
            {
                this.B3_2КолодкаТЛГпр2_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B3_2КолодкаТЛГпр2_1.Visible = false;
                this.B3_2КолодкаТЛГпр2_1.BackgroundImage = null;
            }

            if (B3_2Parameters.B3_2КолодкаТЛГпр3_1 == "true")
            {
                this.B3_2КолодкаТЛГпр3_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B3_2КолодкаТЛГпр3_2.Visible = false;
                this.B3_2КолодкаТЛГпр3_2.BackgroundImage = null;
            }
            else if (B3_2Parameters.B3_2КолодкаТЛГпр3_2 == "true")
            {
                this.B3_2КолодкаТЛГпр3_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B3_2КолодкаТЛГпр3_1.Visible = false;
                this.B3_2КолодкаТЛГпр3_1.BackgroundImage = null;
            }
        }

        private void InitializeTumblersPosition()
        {
            this.B3_2ТумблерМуДу.BackgroundImage = B3_2Parameters.B3_2ТумблерМуДу == "Ду"
                ? ControlElementImages.tumblerType4Down
                : ControlElementImages.tumblerType4Up;
        }
    }
}