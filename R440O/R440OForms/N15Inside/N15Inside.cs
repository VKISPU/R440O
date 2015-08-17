//-----------------------------------------------------------------------
// <copyright file="N15Inside.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.N15Inside
{
    using System.Windows.Forms;
    using BaseClasses;
    using ThirdParty;
    using ОбщиеТипыДанных;

    /// <summary>
    /// Форма внутренней части блока Н15
    /// </summary>
    public partial class N15InsideForm : Form, IRefreshableForm
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="N15InsideForm"/>
        /// </summary>
        public N15InsideForm()
        {
            this.InitializeComponent();
            N15InsideParameters.ParameterChanged += RefreshFormElements;
            RefreshFormElements();
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
                N15InsideParameters.ПереключательПУЛ4801 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N15InsideParameters.ПереключательПУЛ4801 -= 1;
            }
        }

        private void N15InsideПереключательПУЛ480_2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N15InsideParameters.ПереключательПУЛ4802 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N15InsideParameters.ПереключательПУЛ4802 -= 1;
            }
        }

        private void N15InsideПереключательПУЛ48ПРД_1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N15InsideParameters.ПереключательПУЛ48ПРД1 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N15InsideParameters.ПереключательПУЛ48ПРД1 -= 1;
            }
        }

        private void N15InsideПереключательПУЛ48ПРД_2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N15InsideParameters.ПереключательПУЛ48ПРД2 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N15InsideParameters.ПереключательПУЛ48ПРД2 -= 1;
            }
        }
        #endregion

        #region Тумблеры
        private void N15InsideТумблерПУЛ480ЧтОфт1_Click(object sender, System.EventArgs e)
        {
            N15InsideParameters.ТумблерПул480ЧтОфт1 = N15InsideParameters.ТумблерПул480ЧтОфт1 == Модуляция.ЧТ ? Модуляция.ОФТ : Модуляция.ЧТ;
        }

        private void N15InsideТумблерПУЛ48ПРДЧтОфт1_Click(object sender, System.EventArgs e)
        {
            N15InsideParameters.ТумблерПул48ПРДЧтОфт1 = N15InsideParameters.ТумблерПул48ПРДЧтОфт1 == Модуляция.ЧТ ? Модуляция.ОФТ : Модуляция.ЧТ;
        }

        private void N15InsideТумблерПУЛ480ЧтОфт2_Click(object sender, System.EventArgs e)
        {
            N15InsideParameters.ТумблерПул480ЧтОфт2 = N15InsideParameters.ТумблерПул480ЧтОфт2 == Модуляция.ЧТ ? Модуляция.ОФТ : Модуляция.ЧТ;
        }

        private void N15InsideТумблерПУЛ48ПРДЧтОфт2_Click(object sender, System.EventArgs e)
        {
            N15InsideParameters.ТумблерПул48ПРДЧтОфт2 = N15InsideParameters.ТумблерПул48ПРДЧтОфт2 == Модуляция.ЧТ ? Модуляция.ОФТ : Модуляция.ЧТ;
        }

        #endregion

        public void RefreshFormElements()
        {
            this.N15InsideТумблерПУЛ480ЧтОфт1.BackgroundImage = N15InsideParameters.ТумблерПул480ЧтОфт1 == Модуляция.ЧТ
               ? ControlElementImages.tumblerType4Left
               : ControlElementImages.tumblerType4Right;

            this.N15InsideТумблерПУЛ480ЧтОфт2.BackgroundImage = N15InsideParameters.ТумблерПул480ЧтОфт2 == Модуляция.ЧТ
                ? ControlElementImages.tumblerType4Left
                : ControlElementImages.tumblerType4Right;

            this.N15InsideТумблерПУЛ48ПРДЧтОфт1.BackgroundImage = N15InsideParameters.ТумблерПул48ПРДЧтОфт1 == Модуляция.ОФТ
                ? ControlElementImages.tumblerType4Left
                : ControlElementImages.tumblerType4Right;

            this.N15InsideТумблерПУЛ48ПРДЧтОфт2.BackgroundImage = N15InsideParameters.ТумблерПул48ПРДЧтОфт2 == Модуляция.ОФТ
                ? ControlElementImages.tumblerType4Left
                : ControlElementImages.tumblerType4Right;

            var angle = N15InsideParameters.ПереключательПУЛ4801 * 36 + 72;
            N15InsideПереключательПУЛ480_1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType8, angle);

            angle = N15InsideParameters.ПереключательПУЛ4802 * 36 + 72;
            N15InsideПереключательПУЛ480_2.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType8, angle);

            angle = N15InsideParameters.ПереключательПУЛ48ПРД1 * 30 + 160;
            N15InsideПереключательПУЛ48ПРД_1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType8, angle);

            angle = N15InsideParameters.ПереключательПУЛ48ПРД2 * 30 + 160;
            N15InsideПереключательПУЛ48ПРД_2.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType8, angle);
        }
    }
}