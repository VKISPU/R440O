//-----------------------------------------------------------------------
// <copyright file="C300M_1Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.C300M_1
{
    using System.Windows.Forms;
    using Parameters;

    /// <summary>
    /// Форма блока С300М-1
    /// </summary>
    public partial class C300M_1Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="C300M_1Form"/>
        /// </summary>
        public C300M_1Form()
        {
            this.InitializeComponent();
        }

        #region Кнопки ВИД РАБОТЫ
        private void Ц300М_1КнопкаВидРаботы0d025_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаВидРаботы0d025.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d025 = "true";

            this.Ц300М_1КнопкаВидРаботы0d05.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d05 = "false";
            this.Ц300М_1КнопкаВидРаботы0d1.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d1 = "false";
            this.Ц300М_1КнопкаВидРаботы1d2.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы1d2 = "false";
            this.Ц300М_1КнопкаВидРаботы2d4.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы2d4 = "false";
            this.Ц300М_1КнопкаВидРаботы4d8.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы4d8 = "false";
            this.Ц300М_1КнопкаВидРаботы48.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы48 = "false";
            this.Ц300М_1КнопкаВидРаботы96144.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы96144 = "false";
            this.Ц300М_1КнопкаВидРаботы240.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы240 = "false";
            this.Ц300М_1КнопкаВидРаботы480.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы480 = "false";
        }

        private void Ц300М_1КнопкаВидРаботы0d05_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаВидРаботы0d05.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d05 = "true";

            this.Ц300М_1КнопкаВидРаботы0d025.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d025 = "false";
            this.Ц300М_1КнопкаВидРаботы0d1.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d1 = "false";
            this.Ц300М_1КнопкаВидРаботы1d2.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы1d2 = "false";
            this.Ц300М_1КнопкаВидРаботы2d4.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы2d4 = "false";
            this.Ц300М_1КнопкаВидРаботы4d8.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы4d8 = "false";
            this.Ц300М_1КнопкаВидРаботы48.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы48 = "false";
            this.Ц300М_1КнопкаВидРаботы96144.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы96144 = "false";
            this.Ц300М_1КнопкаВидРаботы240.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы240 = "false";
            this.Ц300М_1КнопкаВидРаботы480.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы480 = "false";
        }

        private void Ц300М_1КнопкаВидРаботы0d1_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаВидРаботы0d1.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d1 = "true";

            this.Ц300М_1КнопкаВидРаботы0d025.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d025 = "false";
            this.Ц300М_1КнопкаВидРаботы0d05.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d05 = "false";
            this.Ц300М_1КнопкаВидРаботы1d2.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы1d2 = "false";
            this.Ц300М_1КнопкаВидРаботы2d4.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы2d4 = "false";
            this.Ц300М_1КнопкаВидРаботы4d8.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы4d8 = "false";
            this.Ц300М_1КнопкаВидРаботы48.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы48 = "false";
            this.Ц300М_1КнопкаВидРаботы96144.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы96144 = "false";
            this.Ц300М_1КнопкаВидРаботы240.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы240 = "false";
            this.Ц300М_1КнопкаВидРаботы480.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы480 = "false";
        }

        private void Ц300М_1КнопкаВидРаботы1d2_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаВидРаботы1d2.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы1d2 = "true";

            this.Ц300М_1КнопкаВидРаботы0d025.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d025 = "false";
            this.Ц300М_1КнопкаВидРаботы0d05.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d05 = "false";
            this.Ц300М_1КнопкаВидРаботы0d1.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d1 = "false";
            this.Ц300М_1КнопкаВидРаботы2d4.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы2d4 = "false";
            this.Ц300М_1КнопкаВидРаботы4d8.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы4d8 = "false";
            this.Ц300М_1КнопкаВидРаботы48.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы48 = "false";
            this.Ц300М_1КнопкаВидРаботы96144.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы96144 = "false";
            this.Ц300М_1КнопкаВидРаботы240.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы240 = "false";
            this.Ц300М_1КнопкаВидРаботы480.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы480 = "false";
        }

        private void Ц300М_1КнопкаВидРаботы2d4_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаВидРаботы2d4.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы2d4 = "true";

            this.Ц300М_1КнопкаВидРаботы0d025.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d025 = "false";
            this.Ц300М_1КнопкаВидРаботы0d05.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d05 = "false";
            this.Ц300М_1КнопкаВидРаботы0d1.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d1 = "false";
            this.Ц300М_1КнопкаВидРаботы1d2.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы1d2 = "false";
            this.Ц300М_1КнопкаВидРаботы4d8.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы4d8 = "false";
            this.Ц300М_1КнопкаВидРаботы48.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы48 = "false";
            this.Ц300М_1КнопкаВидРаботы96144.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы96144 = "false";
            this.Ц300М_1КнопкаВидРаботы240.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы240 = "false";
            this.Ц300М_1КнопкаВидРаботы480.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы480 = "false";
        }

        private void Ц300М_1КнопкаВидРаботы4d8_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаВидРаботы4d8.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы4d8 = "true";

            this.Ц300М_1КнопкаВидРаботы0d025.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d025 = "false";
            this.Ц300М_1КнопкаВидРаботы0d05.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d05 = "false";
            this.Ц300М_1КнопкаВидРаботы0d1.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d1 = "false";
            this.Ц300М_1КнопкаВидРаботы1d2.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы1d2 = "false";
            this.Ц300М_1КнопкаВидРаботы2d4.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы2d4 = "false";
            this.Ц300М_1КнопкаВидРаботы48.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы48 = "false";
            this.Ц300М_1КнопкаВидРаботы96144.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы96144 = "false";
            this.Ц300М_1КнопкаВидРаботы240.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы240 = "false";
            this.Ц300М_1КнопкаВидРаботы480.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы480 = "false";
        }

        private void Ц300М_1КнопкаВидРаботы48_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаВидРаботы48.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы48 = "true";

            this.Ц300М_1КнопкаВидРаботы0d025.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d025 = "false";
            this.Ц300М_1КнопкаВидРаботы0d05.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d05 = "false";
            this.Ц300М_1КнопкаВидРаботы0d1.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d1 = "false";
            this.Ц300М_1КнопкаВидРаботы1d2.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы1d2 = "false";
            this.Ц300М_1КнопкаВидРаботы2d4.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы2d4 = "false";
            this.Ц300М_1КнопкаВидРаботы4d8.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы4d8 = "false";
            this.Ц300М_1КнопкаВидРаботы96144.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы96144 = "false";
            this.Ц300М_1КнопкаВидРаботы240.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы240 = "false";
            this.Ц300М_1КнопкаВидРаботы480.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы480 = "false";
        }

        private void Ц300М_1КнопкаВидРаботы96144_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаВидРаботы96144.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы96144 = "true";

            this.Ц300М_1КнопкаВидРаботы0d025.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d025 = "false";
            this.Ц300М_1КнопкаВидРаботы0d05.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d05 = "false";
            this.Ц300М_1КнопкаВидРаботы0d1.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d1 = "false";
            this.Ц300М_1КнопкаВидРаботы1d2.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы1d2 = "false";
            this.Ц300М_1КнопкаВидРаботы2d4.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы2d4 = "false";
            this.Ц300М_1КнопкаВидРаботы4d8.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы4d8 = "false";
            this.Ц300М_1КнопкаВидРаботы48.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы48 = "false";
            this.Ц300М_1КнопкаВидРаботы240.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы240 = "false";
            this.Ц300М_1КнопкаВидРаботы480.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы480 = "false";
        }

        private void Ц300М_1КнопкаВидРаботы240_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаВидРаботы240.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы240 = "true";

            this.Ц300М_1КнопкаВидРаботы0d025.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d025 = "false";
            this.Ц300М_1КнопкаВидРаботы0d05.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d05 = "false";
            this.Ц300М_1КнопкаВидРаботы0d1.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d1 = "false";
            this.Ц300М_1КнопкаВидРаботы1d2.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы1d2 = "false";
            this.Ц300М_1КнопкаВидРаботы2d4.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы2d4 = "false";
            this.Ц300М_1КнопкаВидРаботы4d8.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы4d8 = "false";
            this.Ц300М_1КнопкаВидРаботы48.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы48 = "false";
            this.Ц300М_1КнопкаВидРаботы96144.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы96144 = "false";
            this.Ц300М_1КнопкаВидРаботы480.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы480 = "false";
        }

        private void Ц300М_1КнопкаВидРаботы480_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаВидРаботы480.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы480 = "true";

            this.Ц300М_1КнопкаВидРаботы0d025.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d025 = "false";
            this.Ц300М_1КнопкаВидРаботы0d05.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d05 = "false";
            this.Ц300М_1КнопкаВидРаботы0d1.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d1 = "false";
            this.Ц300М_1КнопкаВидРаботы1d2.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы1d2 = "false";
            this.Ц300М_1КнопкаВидРаботы2d4.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы2d4 = "false";
            this.Ц300М_1КнопкаВидРаботы4d8.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы4d8 = "false";
            this.Ц300М_1КнопкаВидРаботы48.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы48 = "false";
            this.Ц300М_1КнопкаВидРаботы96144.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы96144 = "false";
            this.Ц300М_1КнопкаВидРаботы240.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы240 = "false";
        }

        private void Ц300М_1КнопкаВидРаботыСброс_MouseDown(object sender, MouseEventArgs e)
        {
            this.Ц300М_1КнопкаВидРаботыСброс.BackgroundImage = null;
            this.Ц300М_1КнопкаВидРаботыСброс.Text = "";
            C300M_1Parameters.Ц300М_1КнопкаВидРаботыСброс = "true";
        }

        private void Ц300М_1КнопкаВидРаботыСброс_MouseUp(object sender, MouseEventArgs e)
        {
            this.Ц300М_1КнопкаВидРаботыСброс.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.Ц300М_1КнопкаВидРаботыСброс.Text = "Сброс";
            C300M_1Parameters.Ц300М_1КнопкаВидРаботыСброс = "false";

            this.Ц300М_1КнопкаВидРаботы0d025.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d025 = "false";
            this.Ц300М_1КнопкаВидРаботы0d05.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d05 = "false";
            this.Ц300М_1КнопкаВидРаботы0d1.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d1 = "false";
            this.Ц300М_1КнопкаВидРаботы1d2.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы1d2 = "false";
            this.Ц300М_1КнопкаВидРаботы2d4.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы2d4 = "false";
            this.Ц300М_1КнопкаВидРаботы4d8.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы4d8 = "false";
            this.Ц300М_1КнопкаВидРаботы48.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы48 = "false";
            this.Ц300М_1КнопкаВидРаботы96144.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы96144 = "false";
            this.Ц300М_1КнопкаВидРаботы240.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы240 = "false";
            this.Ц300М_1КнопкаВидРаботы480.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы480 = "false";
        }
        #endregion

        #region Кнопки КОНТРОЛЬ РЕЖИМА
        private void Ц300М_1КнопкаКонтрольРежимаУрСигн_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаКонтрольРежимаУрСигн.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаУрСигн = "true";

            this.Ц300М_1КнопкаКонтрольРежимаУрШума.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаУрШума = "false";
            this.Ц300М_1КнопкаКонтрольРежима0АПЧ.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежима0АПЧ = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПоиск.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПоиск = "false";
            this.Ц300М_1КнопкаКонтрольРежимаГЕТ_2.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаГЕТ_2 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс5.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс5 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс6d3.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс6d3 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс27.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс27 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус5.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус5 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус12d8.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус12d8 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус27.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус27 = "false";
        }

        private void Ц300М_1КнопкаКонтрольРежимаУрШума_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаКонтрольРежимаУрШума.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаУрШума = "true";

            this.Ц300М_1КнопкаКонтрольРежимаУрСигн.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаУрСигн = "false";
            this.Ц300М_1КнопкаКонтрольРежима0АПЧ.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежима0АПЧ = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПоиск.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПоиск = "false";
            this.Ц300М_1КнопкаКонтрольРежимаГЕТ_2.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаГЕТ_2 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс5.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс5 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс6d3.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс6d3 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс27.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс27 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус5.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус5 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус12d8.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус12d8 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус27.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус27 = "false";
        }

        private void Ц300М_1КнопкаКонтрольРежима0АПЧ_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаКонтрольРежима0АПЧ.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежима0АПЧ = "true";

            this.Ц300М_1КнопкаКонтрольРежимаУрСигн.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаУрСигн = "false";
            this.Ц300М_1КнопкаКонтрольРежимаУрШума.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаУрШума = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПоиск.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПоиск = "false";
            this.Ц300М_1КнопкаКонтрольРежимаГЕТ_2.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаГЕТ_2 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс5.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс5 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс6d3.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс6d3 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс27.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс27 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус5.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус5 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус12d8.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус12d8 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус27.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус27 = "false";
        }

        private void Ц300М_1КнопкаКонтрольРежимаПоиск_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаКонтрольРежимаПоиск.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПоиск = "true";

            this.Ц300М_1КнопкаКонтрольРежимаУрСигн.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаУрСигн = "false";
            this.Ц300М_1КнопкаКонтрольРежимаУрШума.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаУрШума = "false";
            this.Ц300М_1КнопкаКонтрольРежима0АПЧ.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежима0АПЧ = "false";
            this.Ц300М_1КнопкаКонтрольРежимаГЕТ_2.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаГЕТ_2 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс5.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс5 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс6d3.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс6d3 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс27.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс27 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус5.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус5 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус12d8.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус12d8 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус27.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус27 = "false";
        }

        private void Ц300М_1КнопкаКонтрольРежимаГЕТ_2_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаКонтрольРежимаГЕТ_2.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаГЕТ_2 = "true";

            this.Ц300М_1КнопкаКонтрольРежимаУрСигн.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаУрСигн = "false";
            this.Ц300М_1КнопкаКонтрольРежимаУрШума.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаУрШума = "false";
            this.Ц300М_1КнопкаКонтрольРежима0АПЧ.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежима0АПЧ = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПоиск.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПоиск = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс5.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс5 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс6d3.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс6d3 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс27.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс27 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус5.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус5 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус12d8.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус12d8 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус27.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус27 = "false";
        }

        private void Ц300М_1КнопкаКонтрольРежимаПлюс5_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаКонтрольРежимаПлюс5.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс5 = "true";

            this.Ц300М_1КнопкаКонтрольРежимаУрСигн.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаУрСигн = "false";
            this.Ц300М_1КнопкаКонтрольРежимаУрШума.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаУрШума = "false";
            this.Ц300М_1КнопкаКонтрольРежима0АПЧ.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежима0АПЧ = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПоиск.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПоиск = "false";
            this.Ц300М_1КнопкаКонтрольРежимаГЕТ_2.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаГЕТ_2 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс6d3.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс6d3 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс27.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс27 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус5.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус5 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус12d8.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус12d8 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус27.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус27 = "false";
        }

        private void Ц300М_1КнопкаКонтрольРежимаПлюс6d3_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаКонтрольРежимаПлюс6d3.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс6d3 = "true";

            this.Ц300М_1КнопкаКонтрольРежимаУрСигн.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаУрСигн = "false";
            this.Ц300М_1КнопкаКонтрольРежимаУрШума.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаУрШума = "false";
            this.Ц300М_1КнопкаКонтрольРежима0АПЧ.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежима0АПЧ = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПоиск.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПоиск = "false";
            this.Ц300М_1КнопкаКонтрольРежимаГЕТ_2.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаГЕТ_2 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс5.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс5 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс27.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс27 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус5.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус5 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус12d8.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус12d8 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус27.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус27 = "false";
        }

        private void Ц300М_1КнопкаКонтрольРежимаПлюс27_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаКонтрольРежимаПлюс27.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс27 = "true";

            this.Ц300М_1КнопкаКонтрольРежимаУрСигн.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаУрСигн = "false";
            this.Ц300М_1КнопкаКонтрольРежимаУрШума.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаУрШума = "false";
            this.Ц300М_1КнопкаКонтрольРежима0АПЧ.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежима0АПЧ = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПоиск.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПоиск = "false";
            this.Ц300М_1КнопкаКонтрольРежимаГЕТ_2.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаГЕТ_2 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс5.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс5 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс6d3.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс6d3 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус5.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус5 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус12d8.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус12d8 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус27.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус27 = "false";
        }

        private void Ц300М_1КнопкаКонтрольРежимаМинус5_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаКонтрольРежимаМинус5.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус5 = "true";

            this.Ц300М_1КнопкаКонтрольРежимаУрСигн.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаУрСигн = "false";
            this.Ц300М_1КнопкаКонтрольРежимаУрШума.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаУрШума = "false";
            this.Ц300М_1КнопкаКонтрольРежима0АПЧ.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежима0АПЧ = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПоиск.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПоиск = "false";
            this.Ц300М_1КнопкаКонтрольРежимаГЕТ_2.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаГЕТ_2 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс5.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс5 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс6d3.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс6d3 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс27.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс27 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус12d8.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус12d8 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус27.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус27 = "false";
        }

        private void Ц300М_1КнопкаКонтрольРежимаМинус12d8_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаКонтрольРежимаМинус12d8.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус12d8 = "true";

            this.Ц300М_1КнопкаКонтрольРежимаУрСигн.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаУрСигн = "false";
            this.Ц300М_1КнопкаКонтрольРежимаУрШума.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаУрШума = "false";
            this.Ц300М_1КнопкаКонтрольРежима0АПЧ.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежима0АПЧ = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПоиск.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПоиск = "false";
            this.Ц300М_1КнопкаКонтрольРежимаГЕТ_2.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаГЕТ_2 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс5.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс5 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс6d3.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс6d3 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс27.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс27 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус5.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус5 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус27.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус27 = "false";
        }

        private void Ц300М_1КнопкаКонтрольРежимаМинус27_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаКонтрольРежимаМинус27.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус27 = "true";

            this.Ц300М_1КнопкаКонтрольРежимаУрСигн.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаУрСигн = "false";
            this.Ц300М_1КнопкаКонтрольРежимаУрШума.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаУрШума = "false";
            this.Ц300М_1КнопкаКонтрольРежима0АПЧ.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежима0АПЧ = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПоиск.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПоиск = "false";
            this.Ц300М_1КнопкаКонтрольРежимаГЕТ_2.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаГЕТ_2 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс5.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс5 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс6d3.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс6d3 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаПлюс27.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс27 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус5.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус5 = "false";
            this.Ц300М_1КнопкаКонтрольРежимаМинус12d8.Visible = true;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус12d8 = "false";
        }
        #endregion
    }
}