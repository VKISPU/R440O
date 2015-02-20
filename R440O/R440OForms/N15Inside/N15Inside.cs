//-----------------------------------------------------------------------
// <copyright file="N15Inside.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.N15Inside
{
    using System.Windows.Forms;
    using Parameters;
    using ThirdParty;

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
            this.InitializeTumblersPosition();
            this.InitializeTogglesPosition();
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

        #region Переключатели
        private void N15InsideПереключательПУЛ480_1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N15InsideParameters.N15InsideПереключательПУЛ480_1 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N15InsideParameters.N15InsideПереключательПУЛ480_1 -= 1;
            }

            var angle = N15InsideParameters.N15InsideПереключательПУЛ480_1 * 36 + 72;
            N15InsideПереключательПУЛ480_1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType8, angle);
        }

        private void N15InsideПереключательПУЛ480_2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N15InsideParameters.N15InsideПереключательПУЛ480_2 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N15InsideParameters.N15InsideПереключательПУЛ480_2 -= 1;
            }

            var angle = N15InsideParameters.N15InsideПереключательПУЛ480_2 * 36 + 72;
            N15InsideПереключательПУЛ480_2.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType8, angle);
        }

        private void N15InsideПереключательПУЛ48ПРД_1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N15InsideParameters.N15InsideПереключательПУЛ48ПРД_1 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N15InsideParameters.N15InsideПереключательПУЛ48ПРД_1 -= 1;
            }

            var angle = N15InsideParameters.N15InsideПереключательПУЛ48ПРД_1 * 30 + 160;
            N15InsideПереключательПУЛ48ПРД_1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType8, angle);
        }

        private void N15InsideПереключательПУЛ48ПРД_2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N15InsideParameters.N15InsideПереключательПУЛ48ПРД_2 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N15InsideParameters.N15InsideПереключательПУЛ48ПРД_2 -= 1;
            }

            var angle = N15InsideParameters.N15InsideПереключательПУЛ48ПРД_2 * 30 + 160;
            N15InsideПереключательПУЛ48ПРД_2.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType8, angle);
        }
        #endregion

        #region Тумблеры
        private void N15InsideТумблерПУЛ480ЧтОфт1_Click(object sender, System.EventArgs e)
        {
            if (N15InsideParameters.N15InsideТумблерПУЛ480ЧтОфт1 == "ЧТ1")
            {
                this.N15InsideТумблерПУЛ480ЧтОфт1.BackgroundImage = ControlElementImages.tumblerType4Right;
                N15InsideParameters.N15InsideТумблерПУЛ480ЧтОфт1 = "ОФТ1";
            }
            else
            {
                this.N15InsideТумблерПУЛ480ЧтОфт1.BackgroundImage = ControlElementImages.tumblerType4Left;
                N15InsideParameters.N15InsideТумблерПУЛ480ЧтОфт1 = "ЧТ1";
            }
        }

        private void N15InsideТумблерПУЛ48ПРДЧтОфт1_Click(object sender, System.EventArgs e)
        {
            if (N15InsideParameters.N15InsideТумблерПУЛ48ПРДЧтОфт1 == "ОФТ1")
            {
                this.N15InsideТумблерПУЛ48ПРДЧтОфт1.BackgroundImage = ControlElementImages.tumblerType4Right;
                N15InsideParameters.N15InsideТумблерПУЛ48ПРДЧтОфт1 = "ЧТ1";
            }
            else
            {
                this.N15InsideТумблерПУЛ48ПРДЧтОфт1.BackgroundImage = ControlElementImages.tumblerType4Left;
                N15InsideParameters.N15InsideТумблерПУЛ48ПРДЧтОфт1 = "ОФТ1";
            }
        }

        private void N15InsideТумблерПУЛ480ЧтОфт2_Click(object sender, System.EventArgs e)
        {
            if (N15InsideParameters.N15InsideТумблерПУЛ480ЧтОфт2 == "ЧТ2")
            {
                this.N15InsideТумблерПУЛ480ЧтОфт2.BackgroundImage = ControlElementImages.tumblerType4Right;
                N15InsideParameters.N15InsideТумблерПУЛ480ЧтОфт2 = "ОФТ2";
            }
            else
            {
                this.N15InsideТумблерПУЛ480ЧтОфт2.BackgroundImage = ControlElementImages.tumblerType4Left;
                N15InsideParameters.N15InsideТумблерПУЛ480ЧтОфт2 = "ЧТ2";
            }
        }

        private void N15InsideТумблерПУЛ48ПРДЧтОфт2_Click(object sender, System.EventArgs e)
        {
            if (N15InsideParameters.N15InsideТумблерПУЛ48ПРДЧтОфт2 == "ОФТ2")
            {
                this.N15InsideТумблерПУЛ48ПРДЧтОфт2.BackgroundImage = ControlElementImages.tumblerType4Right;
                N15InsideParameters.N15InsideТумблерПУЛ48ПРДЧтОфт2 = "ЧТ1";
            }
            else
            {
                this.N15InsideТумблерПУЛ48ПРДЧтОфт2.BackgroundImage = ControlElementImages.tumblerType4Left;
                N15InsideParameters.N15InsideТумблерПУЛ48ПРДЧтОфт2 = "ОФТ2";
            }
        }
        #endregion

        private void InitializeTumblersPosition()
        {
            this.N15InsideТумблерПУЛ480ЧтОфт1.BackgroundImage = N15InsideParameters.N15InsideТумблерПУЛ480ЧтОфт1 == "ЧТ1"
                ? ControlElementImages.tumblerType4Left
                : ControlElementImages.tumblerType4Right;

            this.N15InsideТумблерПУЛ480ЧтОфт2.BackgroundImage = N15InsideParameters.N15InsideТумблерПУЛ480ЧтОфт2 == "ЧТ2"
                ? ControlElementImages.tumblerType4Left
                : ControlElementImages.tumblerType4Right;

            this.N15InsideТумблерПУЛ48ПРДЧтОфт1.BackgroundImage = N15InsideParameters.N15InsideТумблерПУЛ48ПРДЧтОфт1 == "ОФТ1"
                ? ControlElementImages.tumblerType4Left
                : ControlElementImages.tumblerType4Right;

            this.N15InsideТумблерПУЛ48ПРДЧтОфт2.BackgroundImage = N15InsideParameters.N15InsideТумблерПУЛ48ПРДЧтОфт2 == "ОФТ2"
                ? ControlElementImages.tumblerType4Left
                : ControlElementImages.tumblerType4Right;
        }

        private void InitializeTogglesPosition()
        {
            var angle = N15InsideParameters.N15InsideПереключательПУЛ480_1 * 36 + 72;
            N15InsideПереключательПУЛ480_1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType8, angle);

            angle = N15InsideParameters.N15InsideПереключательПУЛ480_2 * 36 + 72;
            N15InsideПереключательПУЛ480_2.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType8, angle);

            angle = N15InsideParameters.N15InsideПереключательПУЛ48ПРД_1 * 30 + 160;
            N15InsideПереключательПУЛ48ПРД_1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType8, angle);

            angle = N15InsideParameters.N15InsideПереключательПУЛ48ПРД_2 * 30 + 160;
            N15InsideПереключательПУЛ48ПРД_2.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType8, angle);
        }
    }
}