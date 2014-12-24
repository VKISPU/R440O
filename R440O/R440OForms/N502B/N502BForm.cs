//-----------------------------------------------------------------------
// <copyright file="N502BForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using R440O.Parameters;
using R440O.ThirdParty;

namespace R440O.R440OForms.N502B
{
    using System.Windows.Forms;

    /// <summary>
    /// Форма блока Н502Б
    /// </summary>
    public partial class N502BForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="N502BForm"/>
        /// </summary>
        public N502BForm()
        {
            this.InitializeComponent();
            this.InitializeTogglesPosition();
            this.InitializeTumblersPosition();
            this.InitializeLamps();
        }

        #region Тумблеры
        private void N502BТумблерЭлектрооборуд_Click(object sender, System.EventArgs e)
        {
            N502BParameters.N502BТумблерЭлектрооборуд = !N502BParameters.N502BТумблерЭлектрооборуд;
            this.N502BТумблерЭлектрооборуд.BackgroundImage = N502BParameters.N502BТумблерЭлектрооборуд
                ? ControlElementImages.tumblerType2Up
                : ControlElementImages.tumblerType2Down;
            if (this.PowerTumblersChanged != null)
            {
                this.PowerTumblersChanged();
            }
        }

        private void N502BТумблерВыпрямитель27В_Click(object sender, System.EventArgs e)
        {
            N502BParameters.N502BТумблерВыпрямитель27В = !N502BParameters.N502BТумблерВыпрямитель27В;
            this.N502BТумблерВыпрямитель27В.BackgroundImage = N502BParameters.N502BТумблерВыпрямитель27В
                ? ControlElementImages.tumblerType2Up
                : ControlElementImages.tumblerType2Down;
            if (this.PowerTumblersChanged != null)
            {
                this.PowerTumblersChanged();
            }
        }

        private void N502BТумблерОсвещение_Click(object sender, System.EventArgs e)
        {
            if (N502BParameters.N502BТумблерОсвещение == "true")
            {
                this.N502BТумблерОсвещение.BackgroundImage = ControlElementImages.tumblerType2Down;
                N502BParameters.N502BТумблерОсвещение = "false";
            }
            else
            {
                this.N502BТумблерОсвещение.BackgroundImage = ControlElementImages.tumblerType2Up;
                N502BParameters.N502BТумблерОсвещение = "true";
            }
        }

        private void N502BТумблерН13_1_Click(object sender, System.EventArgs e)
        {
            if (N502BParameters.N502BТумблерН13_1 == "true")
            {
                this.N502BТумблерН13_1.BackgroundImage = ControlElementImages.tumblerType2Down;
                N502BParameters.N502BТумблерН13_1 = "false";
            }
            else
            {
                this.N502BТумблерН13_1.BackgroundImage = ControlElementImages.tumblerType2Up;
                N502BParameters.N502BТумблерН13_1 = "true";
            }
        }

        private void N502BТумблерН13_2_Click(object sender, System.EventArgs e)
        {
            if (N502BParameters.N502BТумблерН13_2 == "true")
            {
                this.N502BТумблерН13_2.BackgroundImage = ControlElementImages.tumblerType2Down;
                N502BParameters.N502BТумблерН13_2 = "false";
            }
            else
            {
                this.N502BТумблерН13_2.BackgroundImage = ControlElementImages.tumblerType2Up;
                N502BParameters.N502BТумблерН13_2 = "true";
            }
        }

        private void N502BТумблерН15_Click(object sender, System.EventArgs e)
        {
            if (N502BParameters.N502BТумблерН15 == "true")
            {
                this.N502BТумблерН15.BackgroundImage = ControlElementImages.tumblerType2Down;
                N502BParameters.N502BТумблерН15 = "false";
            }
            else
            {
                this.N502BТумблерН15.BackgroundImage = ControlElementImages.tumblerType2Up;
                N502BParameters.N502BТумблерН15 = "true";
            }
        }

        private void N502BТумблерОсвещение1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (N502BParameters.N502BТумблерОсвещение1 == "полное")
                {
                    this.N502BТумблерОсвещение1.BackgroundImage = ControlElementImages.tumblerType5Middle;
                    N502BParameters.N502BТумблерОсвещение1 = "откл";
                }
                else
                    if (N502BParameters.N502BТумблерОсвещение1 == "откл")
                    {
                        this.N502BТумблерОсвещение1.BackgroundImage = ControlElementImages.tumblerType5Down;
                        N502BParameters.N502BТумблерОсвещение1 = "дежурное";
                    }
            }
            else
                if (e.Button == MouseButtons.Right)
                {
                    if (N502BParameters.N502BТумблерОсвещение1 == "дежурное")
                    {
                        this.N502BТумблерОсвещение1.BackgroundImage = ControlElementImages.tumblerType5Middle;
                        N502BParameters.N502BТумблерОсвещение1 = "откл";
                    }
                    else
                        if (N502BParameters.N502BТумблерОсвещение1 == "откл")
                        {
                            this.N502BТумблерОсвещение1.BackgroundImage = ControlElementImages.tumblerType5Up;
                            N502BParameters.N502BТумблерОсвещение1 = "полное";
                        }
                }
        }

        private void N502BТумблерОсвещение2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (N502BParameters.N502BТумблерОсвещение2 == "полное")
                {
                    this.N502BТумблерОсвещение2.BackgroundImage = ControlElementImages.tumblerType5Middle;
                    N502BParameters.N502BТумблерОсвещение2 = "откл";
                }
                else
                    if (N502BParameters.N502BТумблерОсвещение2 == "откл")
                    {
                        this.N502BТумблерОсвещение2.BackgroundImage = ControlElementImages.tumblerType5Down;
                        N502BParameters.N502BТумблерОсвещение2 = "частичное";
                    }
            }
            else
                if (e.Button == MouseButtons.Right)
                {
                    if (N502BParameters.N502BТумблерОсвещение2 == "частичное")
                    {
                        this.N502BТумблерОсвещение2.BackgroundImage = ControlElementImages.tumblerType5Middle;
                        N502BParameters.N502BТумблерОсвещение2 = "откл";
                    }
                    else
                        if (N502BParameters.N502BТумблерОсвещение2 == "откл")
                        {
                            this.N502BТумблерОсвещение2.BackgroundImage = ControlElementImages.tumblerType5Up;
                            N502BParameters.N502BТумблерОсвещение2 = "полное";
                        }
                }
        }
        #endregion

        #region Кнопки
        private void N502BКнопкаРБПСброс_MouseUp(object sender, MouseEventArgs e)
        {
            this.N502BКнопкаРБПСброс.BackgroundImage = ControlElementImages.buttonRoundType3;
        }

        private void N502BКнопкаРБПСброс_MouseDown(object sender, MouseEventArgs e)
        {
            this.N502BКнопкаРБПСброс.BackgroundImage = null;
        }

        private void N502BКнопкаРБППроверка_MouseUp(object sender, MouseEventArgs e)
        {
            this.N502BКнопкаРБППроверка.BackgroundImage = ControlElementImages.buttonRoundType3;
        }

        private void N502BКнопкаРБППроверка_MouseDown(object sender, MouseEventArgs e)
        {
            this.N502BКнопкаРБППроверка.BackgroundImage = null;
        }

        private void N502BКнопкаВклНагрузки_MouseUp(object sender, MouseEventArgs e)
        {
            this.N502BКнопкаВклНагрузки.BackgroundImage = ControlElementImages.buttonRoundType3;
        }

        private void N502BКнопкаВклНагрузки_MouseDown(object sender, MouseEventArgs e)
        {
            this.N502BКнопкаВклНагрузки.BackgroundImage = null;
        }
        #endregion

        #region Переключатели
        private void N502BПереключательСеть_Click(object sender, System.EventArgs e)
        {
            if (N502BParameters.N502BПереключательСеть == "true")
            {
                this.N502BПереключательСеть.BackgroundImage = ControlElementImages.tumblerN502BPowerDown;
                N502BParameters.N502BПереключательСеть = "false";
            }
            else
            {
                this.N502BПереключательСеть.BackgroundImage = ControlElementImages.tumblerN502BPowerUp;
                N502BParameters.N502BПереключательСеть = "true";
            }
        }

        private void N502BПереключательНапряжениеButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N502BParameters.N502BПереключательНапряжение += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N502BParameters.N502BПереключательНапряжение -= 1;
            }

            var angle = N502BParameters.N502BПереключательНапряжение * 36 - 150;
            if (N502BParameters.N502BПереключательНапряжение >= 4) angle += 48; ////Смещение
            N502BПереключательНапряжение.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void N502BПереключательФазировка_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N502BParameters.N502BПереключательФазировка += 1;
                if (N502BParameters.N502BПереключательФазировка == 5) N502BParameters.N502BПереключательФазировка = 1;
            }
            if (e.Button == MouseButtons.Right)
            {
                N502BParameters.N502BПереключательФазировка -= 1;
                if (N502BParameters.N502BПереключательФазировка == 0) N502BParameters.N502BПереключательФазировка = 4;
            }
            var angle = N502BParameters.N502BПереключательФазировка * 90 - 180;
            N502BПереключательФазировка.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType5, angle);
        }

        private void N502BПереключательКонтрольНапряжения_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N502BParameters.N502BПереключательКонтрольНапряжения += 1;
            }
            if (e.Button == MouseButtons.Right)
            {
                N502BParameters.N502BПереключательКонтрольНапряжения -= 1;
            }

            var angle = N502BParameters.N502BПереключательКонтрольНапряжения * 45 - 90;
            N502BПереключательКонтрольНапряжения.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType1, angle);
        }

        private void N502BПереключательТокНагрузкиИЗаряда_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N502BParameters.N502BПереключательТокНагрузкиИЗаряда += 1;
            }
            if (e.Button == MouseButtons.Right)
            {
                N502BParameters.N502BПереключательТокНагрузкиИЗаряда -= 1;
            }

            var angle = N502BParameters.N502BПереключательТокНагрузкиИЗаряда * 40 - 180;
            N502BПереключательТокНагрузкиИЗаряда.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType4, angle);
        }
        #endregion

        #region Инициализация
        /// <summary>
        /// Инициализация начальных положений тумблеров, а также
        /// восстановление положений при повторном открытии формы
        /// </summary>
        private void InitializeTumblersPosition()
        {
            this.N502BТумблерЭлектрооборуд.BackgroundImage = N502BParameters.N502BТумблерЭлектрооборуд ?
                ControlElementImages.tumblerType2Up : ControlElementImages.tumblerType2Down;

            this.N502BТумблерВыпрямитель27В.BackgroundImage = N502BParameters.N502BТумблерВыпрямитель27В ?
                ControlElementImages.tumblerType2Up : ControlElementImages.tumblerType2Down;

            this.N502BТумблерОсвещение.BackgroundImage = N502BParameters.N502BТумблерОсвещение == "false" ?
                ControlElementImages.tumblerType2Down : ControlElementImages.tumblerType2Up;

            this.N502BТумблерН13_1.BackgroundImage = N502BParameters.N502BТумблерН13_1 == "false" ?
                ControlElementImages.tumblerType2Down : ControlElementImages.tumblerType2Up;

            this.N502BТумблерН13_2.BackgroundImage = N502BParameters.N502BТумблерН13_2 == "false" ?
                ControlElementImages.tumblerType2Down : ControlElementImages.tumblerType2Up;

            this.N502BТумблерН15.BackgroundImage = N502BParameters.N502BТумблерН15 == "false" ?
                ControlElementImages.tumblerType2Down : ControlElementImages.tumblerType2Up;

            if (N502BParameters.N502BТумблерОсвещение1 == "откл")
                this.N502BТумблерОсвещение1.BackgroundImage = ControlElementImages.tumblerType5Middle;
            else if (N502BParameters.N502BТумблерОсвещение1 == "полное")
                this.N502BТумблерОсвещение1.BackgroundImage = ControlElementImages.tumblerType5Up;
            else
                this.N502BТумблерОсвещение1.BackgroundImage = ControlElementImages.tumblerType5Down;

            if (N502BParameters.N502BТумблерОсвещение2 == "откл")
                this.N502BТумблерОсвещение2.BackgroundImage = ControlElementImages.tumblerType5Middle;
            else if (N502BParameters.N502BТумблерОсвещение2 == "полное")
                this.N502BТумблерОсвещение2.BackgroundImage = ControlElementImages.tumblerType5Up;
            else
                this.N502BТумблерОсвещение2.BackgroundImage = ControlElementImages.tumblerType5Down;
        }

        /// <summary>
        /// Инициализация начальных положений переключателей, а также
        /// восстановление положений при повторном открытии формы
        /// </summary>
        private void InitializeTogglesPosition()
        {
            N502BПереключательСеть.BackgroundImage = N502BParameters.N502BПереключательСеть == "true"
                ? ControlElementImages.tumblerN502BPowerUp
                : ControlElementImages.tumblerN502BPowerDown;

            var angle = N502BParameters.N502BПереключательНапряжение * 36 - 150;
            if (N502BParameters.N502BПереключательНапряжение >= 4) angle += 48;
            N502BПереключательНапряжение.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N502BParameters.N502BПереключательФазировка * 90 - 180;
            N502BПереключательФазировка.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType5, angle);

            angle = N502BParameters.N502BПереключательКонтрольНапряжения * 45 - 90;
            N502BПереключательКонтрольНапряжения.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType1, angle);

            angle = N502BParameters.N502BПереключательТокНагрузкиИЗаряда * 40 - 180;
            N502BПереключательТокНагрузкиИЗаряда.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType4, angle);
        }

        private void InitializeLamps()
        {
            N502BЛампочкаСеть.BackgroundImage = N502BParameters.N502BЛампочкаСеть
                    ? ControlElementImages.lampType12OnRed
                    : null;

            N502BЛампочкаСфазировано.BackgroundImage = N502BParameters.N502BЛампочкаСфазировано
                    ? ControlElementImages.lampType12OnRed
                    : null;

        }
        #endregion

        #region События
        public delegate void VoidVoidSignature();
        /// <summary>
        /// Событие переключения тумблеров управления питанием
        /// </summary>
        public event VoidVoidSignature PowerTumblersChanged;
        #endregion

    }
}