//-----------------------------------------------------------------------
// <copyright file="AstraForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.Astra
{
    using System.Windows.Forms;
    using Parameters;
    using ThirdParty;
    
    /// <summary>
    /// Форма блока Астра
    /// </summary>
    public partial class AstraForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AstraForm"/>.
        /// </summary>
        public AstraForm()
        {
            this.InitializeComponent();
            this.InitializeTogglesPosition();
        }

        #region Кнопки
        private void AstraКнопка150_270_Click(object sender, System.EventArgs e)
        {
            this.AstraКнопка150_270.Visible = false;
            this.AstraКнопка270_480.Visible = true;
            this.AstraКнопка480_860.Visible = true;
            this.AstraКнопка860_1500.Visible = true;
        }

        private void AstraКнопка270_480_Click(object sender, System.EventArgs e)
        {
            this.AstraКнопка150_270.Visible = true;
            this.AstraКнопка270_480.Visible = false;
            this.AstraКнопка480_860.Visible = true;
            this.AstraКнопка860_1500.Visible = true;
        }

        private void AstraКнопка480_860_Click(object sender, System.EventArgs e)
        {
            this.AstraКнопка150_270.Visible = true;
            this.AstraКнопка270_480.Visible = true;
            this.AstraКнопка480_860.Visible = false;
            this.AstraКнопка860_1500.Visible = true;
        }

        private void AstraКнопка860_1500_Click(object sender, System.EventArgs e)
        {
            this.AstraКнопка150_270.Visible = true;
            this.AstraКнопка270_480.Visible = true;
            this.AstraКнопка480_860.Visible = true;
            this.AstraКнопка860_1500.Visible = false;
        }
        #endregion

        #region Переключатели
        private void AstraПереключательТлгТлф_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AstraParameters.AstraПереключательТлгТлф += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                AstraParameters.AstraПереключательТлгТлф -= 1;
            }

            var angle = AstraParameters.AstraПереключательТлгТлф * 30 - 150;

            AstraПереключательТлгТлф.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void AstraПереключательВнешнегоПитания_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AstraParameters.AstraПереключательВнешнегоПитания += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                AstraParameters.AstraПереключательВнешнегоПитания -= 1;
            }

            var angle = AstraParameters.AstraПереключательВнешнегоПитания * 30;

            AstraПереключательВнешнегоПитания.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void AstraПереключательКонтроль_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AstraParameters.AstraПереключательКонтроль += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                AstraParameters.AstraПереключательКонтроль -= 1;
            }

            var angle = AstraParameters.AstraПереключательКонтроль * 35 - 160;

            AstraПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void AstraПереключательДиапазоны_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AstraParameters.AstraПереключательДиапазоны += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                AstraParameters.AstraПереключательДиапазоны -= 1;
            }

            var angle = AstraParameters.AstraПереключательДиапазоны * 30 - 148;

            AstraПереключательДиапазоны.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void AstraПереключательВыходаРеле_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AstraParameters.AstraПереключательВыходаРеле += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                AstraParameters.AstraПереключательВыходаРеле -= 1;
            }

            var angle = AstraParameters.AstraПереключательВыходаРеле * 30 - 60;

            AstraПереключательВыходаРеле.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }
#endregion

        #region Инициализация
        private void InitializeTogglesPosition()
        {
            var angle = AstraParameters.AstraПереключательТлгТлф * 30 - 150;
            AstraПереключательТлгТлф.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = AstraParameters.AstraПереключательВнешнегоПитания * 30;
            AstraПереключательВнешнегоПитания.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = AstraParameters.AstraПереключательКонтроль * 35 - 160;
            AstraПереключательКонтроль.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = AstraParameters.AstraПереключательДиапазоны * 30 - 148;
            AstraПереключательДиапазоны.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = AstraParameters.AstraПереключательВыходаРеле * 30 - 60;
            AstraПереключательВыходаРеле.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }
        #endregion

        private void AstraТумблерШпУп_Click(object sender, System.EventArgs e)
        {
            if (AstraParameters.AstraТумблерШпУп == "шп")
            {
                this.AstraТумблерШпУп.BackgroundImage = ControlElementImages.tumblerType2Right;
                AstraParameters.AstraТумблерШпУп = "уп";
            }
            else
            {
                this.AstraТумблерШпУп.BackgroundImage = ControlElementImages.tumblerType2Left;
                AstraParameters.AstraТумблерШпУп = "шп";
            }
        }
    }
}