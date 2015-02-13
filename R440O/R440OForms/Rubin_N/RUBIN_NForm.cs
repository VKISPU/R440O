//-----------------------------------------------------------------------
// <copyright file="Rubin_NForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using R440O.Parameters;
using R440O.ThirdParty;

namespace R440O.R440OForms.Rubin_N
{
    using System.Windows.Forms;

    /// <summary>
    /// Форма блока пульт управления Рубин-Н
    /// </summary>
    public partial class Rubin_NForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Rubin_NForm"/>
        /// </summary>
        public Rubin_NForm()
        {
            this.InitializeComponent();
            InitializeTogglesPosition();
            InitializeTumblersPosition();
            InitializeButtonsPosition();
        }

        #region Инициализация

        private void InitializeButtonsPosition()
        {
            if (Rubin_NParameters.Rubin_NКнопкаВкл)
            {
                this.Rubin_NКнопкаВкл.BackgroundImage = null;
                this.Rubin_NКнопкаВкл.Text = string.Empty;
            }
            else
            {
                this.Rubin_NКнопкаВкл.BackgroundImage = ControlElementImages.buttonSquareYellow;
                this.Rubin_NКнопкаВкл.Text = "ВКЛ";
            }

            if (Rubin_NParameters.Rubin_NКнопкаОткл)
            {
                this.Rubin_NКнопкаОткл.BackgroundImage = null;
                this.Rubin_NКнопкаОткл.Text = string.Empty;
            }
            else
            {
                this.Rubin_NКнопкаОткл.BackgroundImage = ControlElementImages.buttonSquareYellow;
                this.Rubin_NКнопкаОткл.Text = "ОТКЛ";
            }
        }

        private void InitializeTogglesPosition()
        {
            var angle = Rubin_NParameters.Rubin_NПереключательГрупСкор * 33 - 80;
            Rubin_NПереключательГрупСкор.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = Rubin_NParameters.Rubin_NПереключательКонтроль * 35 - 85;
            Rubin_NПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = Rubin_NParameters.Rubin_NПереключательN5063_2кБод * 35 - 85;
            Rubin_NПереключательN5063_2кБод.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = Rubin_NParameters.Rubin_NПереключательN5063_6812кБод * 17 - 170;
            Rubin_NПереключательN5063_6812кБод.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = Rubin_NParameters.Rubin_NПереключательN5063_48кБод * 35 - 185;
            Rubin_NПереключательN5063_48кБод.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = Rubin_NParameters.Rubin_NПереключательN4963_2кБод * 35 - 85;
            Rubin_NПереключательN4963_2кБод.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = Rubin_NParameters.Rubin_NПереключательN4963_6812кБод * 17 - 170;
            Rubin_NПереключательN4963_6812кБод.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = Rubin_NParameters.Rubin_NПереключательN4963_48кБод * 35 - 185;
            Rubin_NПереключательN4963_48кБод.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = Rubin_NParameters.Rubin_NПереключательN4923_2кБод * 35 - 85;
            Rubin_NПереключательN4923_2кБод.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = Rubin_NParameters.Rubin_NПереключательN4923_6812кБод * 17 - 170;
            Rubin_NПереключательN4923_6812кБод.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = Rubin_NParameters.Rubin_NПереключательN4923_48кБод * 35 - 185;
            Rubin_NПереключательN4923_48кБод.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void InitializeTumblersPosition()
        {
            this.Rubin_NТумблерПолярность.BackgroundImage = Rubin_NParameters.Rubin_NТумблерПолярность == "+"
              ? ControlElementImages.tumblerType4Left
              : ControlElementImages.tumblerType4Right;

            this.Rubin_NТумблерБлок5063.BackgroundImage = Rubin_NParameters.Rubin_NТумблерБлок5063 == "4.8"
              ? ControlElementImages.tumblerType4Left
              : ControlElementImages.tumblerType4Right;

            this.Rubin_NТумблерБлок4923.BackgroundImage = Rubin_NParameters.Rubin_NТумблерБлок4923 == "4.8"
              ? ControlElementImages.tumblerType4Left
              : ControlElementImages.tumblerType4Right;

            this.Rubin_NТумблерБлок4963.BackgroundImage = Rubin_NParameters.Rubin_NТумблерБлок4963 == "4.8"
              ? ControlElementImages.tumblerType4Left
              : ControlElementImages.tumblerType4Right;
        }
        #endregion

        #region Переключатели
        private void Rubin_NПереключательГрупСкор_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Rubin_NParameters.Rubin_NПереключательГрупСкор += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                Rubin_NParameters.Rubin_NПереключательГрупСкор -= 1;
            }

            var angle = Rubin_NParameters.Rubin_NПереключательГрупСкор * 33 - 80;
            Rubin_NПереключательГрупСкор.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void Rubin_NПереключательКонтроль_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Rubin_NParameters.Rubin_NПереключательКонтроль += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                Rubin_NParameters.Rubin_NПереключательКонтроль -= 1;
            }

            var angle = Rubin_NParameters.Rubin_NПереключательКонтроль * 35 - 85;
            Rubin_NПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void Rubin_NПереключательN5063_2кБод_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Rubin_NParameters.Rubin_NПереключательN5063_2кБод += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                Rubin_NParameters.Rubin_NПереключательN5063_2кБод -= 1;
            }

            var angle = Rubin_NParameters.Rubin_NПереключательN5063_2кБод * 35 - 85;
            Rubin_NПереключательN5063_2кБод.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void Rubin_NПереключательN5063_6812кБод_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Rubin_NParameters.Rubin_NПереключательN5063_6812кБод += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                Rubin_NParameters.Rubin_NПереключательN5063_6812кБод -= 1;
            }

            var angle = Rubin_NParameters.Rubin_NПереключательN5063_6812кБод * 17 - 170;
            if (Rubin_NParameters.Rubin_NПереключательN5063_6812кБод > 9) angle += 25;
            Rubin_NПереключательN5063_6812кБод.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void Rubin_NПереключательN5063_48кБод_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Rubin_NParameters.Rubin_NПереключательN5063_48кБод += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                Rubin_NParameters.Rubin_NПереключательN5063_48кБод -= 1;
            }

            var angle = Rubin_NParameters.Rubin_NПереключательN5063_48кБод * 35 - 185;
            Rubin_NПереключательN5063_48кБод.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void Rubin_NПереключательN4923_2кБод_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Rubin_NParameters.Rubin_NПереключательN4923_2кБод += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                Rubin_NParameters.Rubin_NПереключательN4923_2кБод -= 1;
            }

            var angle = Rubin_NParameters.Rubin_NПереключательN4923_2кБод * 35 - 85;
            Rubin_NПереключательN4923_2кБод.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void Rubin_NПереключательN4923_6812кБод_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Rubin_NParameters.Rubin_NПереключательN4923_6812кБод += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                Rubin_NParameters.Rubin_NПереключательN4923_6812кБод -= 1;
            }

            var angle = Rubin_NParameters.Rubin_NПереключательN4923_6812кБод * 17 - 170;
            if (Rubin_NParameters.Rubin_NПереключательN4923_6812кБод > 9) angle += 25;
            Rubin_NПереключательN4923_6812кБод.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }


        private void Rubin_NПереключательN4923_48кБод_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Rubin_NParameters.Rubin_NПереключательN4923_48кБод += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                Rubin_NParameters.Rubin_NПереключательN4923_48кБод -= 1;
            }

            var angle = Rubin_NParameters.Rubin_NПереключательN4923_48кБод * 35 - 185;
            Rubin_NПереключательN4923_48кБод.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void Rubin_NПереключательN4963_2кБод_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Rubin_NParameters.Rubin_NПереключательN4963_2кБод += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                Rubin_NParameters.Rubin_NПереключательN4963_2кБод -= 1;
            }

            var angle = Rubin_NParameters.Rubin_NПереключательN4963_2кБод * 35 - 85;
            Rubin_NПереключательN4963_2кБод.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void Rubin_NПереключательN4963_6812кБод_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Rubin_NParameters.Rubin_NПереключательN4963_6812кБод += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                Rubin_NParameters.Rubin_NПереключательN4963_6812кБод -= 1;
            }

            var angle = Rubin_NParameters.Rubin_NПереключательN4963_6812кБод * 17 - 170;
            if (Rubin_NParameters.Rubin_NПереключательN4963_6812кБод > 9) angle += 25;
            Rubin_NПереключательN4963_6812кБод.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }


        private void Rubin_NПереключательN4963_48кБод_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Rubin_NParameters.Rubin_NПереключательN4963_48кБод += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                Rubin_NParameters.Rubin_NПереключательN4963_48кБод -= 1;
            }

            var angle = Rubin_NParameters.Rubin_NПереключательN4963_48кБод * 35 - 185;
            Rubin_NПереключательN4963_48кБод.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }
        #endregion

        #region Кнопки
        private void Rubin_NКнопкаОсн_MouseDown(object sender, MouseEventArgs e)
        {
            Rubin_NКнопкаОсн.BackgroundImage = null;
        }

        private void Rubin_NКнопкаОсн_MouseUp(object sender, MouseEventArgs e)
        {
            Rubin_NКнопкаОсн.BackgroundImage = ControlElementImages.buttonRoundType7;
        }

        private void Rubin_NКнопкаРезервированиеВкл_MouseDown(object sender, MouseEventArgs e)
        {
            Rubin_NКнопкаРезервированиеВкл.BackgroundImage = null;
        }

        private void Rubin_NКнопкаРезервированиеВкл_MouseUp(object sender, MouseEventArgs e)
        {
            Rubin_NКнопкаРезервированиеВкл.BackgroundImage = ControlElementImages.buttonRoundType7;
        }

        private void Rubin_NКнопкаРезервированиеОткл_MouseDown(object sender, MouseEventArgs e)
        {
            Rubin_NКнопкаРезервированиеОткл.BackgroundImage = null;
        }

        private void Rubin_NКнопкаРезервированиеОткл_MouseUp(object sender, MouseEventArgs e)
        {
            Rubin_NКнопкаРезервированиеОткл.BackgroundImage = ControlElementImages.buttonRoundType7;
        }

        private void Rubin_NКнопкаТранзит_MouseDown(object sender, MouseEventArgs e)
        {
            Rubin_NКнопкаТранзит.BackgroundImage = null;
        }

        private void Rubin_NКнопкаТранзит_MouseUp(object sender, MouseEventArgs e)
        {
            Rubin_NКнопкаТранзит.BackgroundImage = ControlElementImages.buttonRoundType7;
        }

        private void Rubin_NКнопкаРабота_MouseDown(object sender, MouseEventArgs e)
        {
            Rubin_NКнопкаРабота.BackgroundImage = null;
        }

        private void Rubin_NКнопкаРабота_MouseUp(object sender, MouseEventArgs e)
        {
            Rubin_NКнопкаРабота.BackgroundImage = ControlElementImages.buttonRoundType7;
        }

        private void Rubin_NКнопкаВкл_Click(object sender, System.EventArgs e)
        {
            if (Rubin_NParameters.Rubin_NКнопкаВкл)
            {
                this.Rubin_NКнопкаВкл.BackgroundImage = ControlElementImages.buttonSquareYellow;
                this.Rubin_NКнопкаВкл.Text = "ВКЛ";
            }
            else
            {
                this.Rubin_NКнопкаВкл.BackgroundImage = null;
                this.Rubin_NКнопкаВкл.Text = string.Empty;
            }
            Rubin_NParameters.Rubin_NКнопкаВкл = !Rubin_NParameters.Rubin_NКнопкаВкл;
        }

        private void Rubin_NКнопкаОткл_Click(object sender, System.EventArgs e)
        {
            if (Rubin_NParameters.Rubin_NКнопкаОткл)
            {
                this.Rubin_NКнопкаОткл.BackgroundImage = ControlElementImages.buttonSquareYellow;
                this.Rubin_NКнопкаОткл.Text = "ОТКЛ";
            }
            else
            {
                this.Rubin_NКнопкаОткл.BackgroundImage = null;
                this.Rubin_NКнопкаОткл.Text = string.Empty;
            }
            Rubin_NParameters.Rubin_NКнопкаОткл = !Rubin_NParameters.Rubin_NКнопкаОткл;
        }

        #endregion

        #region Тумблеры
        private void Rubin_NТумблерПолярность_Click(object sender, System.EventArgs e)
        {
            if (Rubin_NParameters.Rubin_NТумблерПолярность == "+")
            {
                this.Rubin_NТумблерПолярность.BackgroundImage = ControlElementImages.tumblerType4Right;
                Rubin_NParameters.Rubin_NТумблерПолярность = "-";
            }
            else
            {
                this.Rubin_NТумблерПолярность.BackgroundImage = ControlElementImages.tumblerType4Left;
                Rubin_NParameters.Rubin_NТумблерПолярность = "+";
            }
        }

        private void Rubin_NТумблерБлок5063_Click(object sender, System.EventArgs e)
        {
            if (Rubin_NParameters.Rubin_NТумблерБлок5063 == "4.8")
            {
                this.Rubin_NТумблерБлок5063.BackgroundImage = ControlElementImages.tumblerType4Right;
                Rubin_NParameters.Rubin_NТумблерБлок5063 = "5.2";
            }
            else
            {
                this.Rubin_NТумблерБлок5063.BackgroundImage = ControlElementImages.tumblerType4Left;
                Rubin_NParameters.Rubin_NТумблерБлок5063 = "4.8";
            }
        }

        private void Rubin_NТумблерБлок4923_Click(object sender, System.EventArgs e)
        {
            if (Rubin_NParameters.Rubin_NТумблерБлок4923 == "4.8")
            {
                this.Rubin_NТумблерБлок4923.BackgroundImage = ControlElementImages.tumblerType4Right;
                Rubin_NParameters.Rubin_NТумблерБлок4923 = "5.2";
            }
            else
            {
                this.Rubin_NТумблерБлок4923.BackgroundImage = ControlElementImages.tumblerType4Left;
                Rubin_NParameters.Rubin_NТумблерБлок4923 = "4.8";
            }
        }

        private void Rubin_NТумблерБлок4963_Click(object sender, System.EventArgs e)
        {
            if (Rubin_NParameters.Rubin_NТумблерБлок4963 == "4.8")
            {
                this.Rubin_NТумблерБлок4963.BackgroundImage = ControlElementImages.tumblerType4Right;
                Rubin_NParameters.Rubin_NТумблерБлок4963 = "5.2";
            }
            else
            {
                this.Rubin_NТумблерБлок4963.BackgroundImage = ControlElementImages.tumblerType4Left;
                Rubin_NParameters.Rubin_NТумблерБлок4963 = "4.8";
            }
        }
        #endregion
    }
}