//-----------------------------------------------------------------------
// <copyright file="N502BForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Globalization;
using R440O.ThirdParty;

namespace R440O.R440OForms.N502B
{
    using System.Windows.Forms;

    public partial class N502BForm : Form
    {
        public N502BForm()
        {
            InitializeComponent();
            N502BParameters.RefreshForm += RefreshForm;
            N502BParameters.СледитьЗаВременем();
            RefreshForm();
        }
        
        #region Тумблеры

        private void ТумблерЭлектрооборудование_Click(object sender, System.EventArgs e)
        {
            N502BParameters.ТумблерЭлектрооборудование = !N502BParameters.ТумблерЭлектрооборудование;
        }

        private void ТумблерВыпрямитель27В_Click(object sender, System.EventArgs e)
        {
            N502BParameters.ТумблерВыпрямитель27В = !N502BParameters.ТумблерВыпрямитель27В;
        }

        private void ТумблерОсвещение_Click(object sender, System.EventArgs e)
        {
            N502BParameters.ТумблерОсвещение = !N502BParameters.ТумблерОсвещение;
        }

        private void ТумблерН131_Click(object sender, System.EventArgs e)
        {
            N502BParameters.ТумблерН131 = !N502BParameters.ТумблерН131;
        }

        private void ТумблерН132_Click(object sender, System.EventArgs e)
        {
            N502BParameters.ТумблерН132 = !N502BParameters.ТумблерН132;
        }

        private void ТумблерН15_Click(object sender, System.EventArgs e)
        {
            N502BParameters.ТумблерН15 = !N502BParameters.ТумблерН15;
        }

        private void ТумблерОсвещение1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    switch (N502BParameters.ТумблерОсвещение1)
                    {
                        case 1:
                            N502BParameters.ТумблерОсвещение1 = 2;
                            break;
                        case 2:
                            N502BParameters.ТумблерОсвещение1 = 3;
                            break;
                    }
                    break;
                case MouseButtons.Right:
                    switch (N502BParameters.ТумблерОсвещение1)
                    {
                        case 3:
                            N502BParameters.ТумблерОсвещение1 = 2;
                            break;
                        case 2:
                            N502BParameters.ТумблерОсвещение1 = 1;
                            break;
                    }
                    break;
            }
        }

        private void ТумблерОсвещение2_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    switch (N502BParameters.ТумблерОсвещение2)
                    {
                        case 1:
                            N502BParameters.ТумблерОсвещение2 = 2;
                            break;
                        case 2:
                            N502BParameters.ТумблерОсвещение2 = 3;
                            break;
                    }
                    break;
                case MouseButtons.Right:
                    switch (N502BParameters.ТумблерОсвещение2)
                    {
                        case 3:
                            N502BParameters.ТумблерОсвещение2 = 2;
                            break;
                        case 2:
                            N502BParameters.ТумблерОсвещение2 = 1;
                            break;
                    }
                    break;
            }
        }

        #endregion

        #region Кнопки
        private void N502BКнопкаРБПСброс_MouseUp(object sender, MouseEventArgs e)
        {
            N502BКнопкаРБПСброс.BackgroundImage = ControlElementImages.buttonRoundType3;
        }

        private void N502BКнопкаРБПСброс_MouseDown(object sender, MouseEventArgs e)
        {
            N502BКнопкаРБПСброс.BackgroundImage = null;
        }

        private void N502BКнопкаРБППроверка_MouseUp(object sender, MouseEventArgs e)
        {
            N502BКнопкаРБППроверка.BackgroundImage = ControlElementImages.buttonRoundType3;
        }

        private void N502BКнопкаРБППроверка_MouseDown(object sender, MouseEventArgs e)
        {
            N502BКнопкаРБППроверка.BackgroundImage = null;
        }

        private void КнопкаВклНагрузки_MouseDown(object sender, MouseEventArgs e)
        {
            КнопкаВклНагрузки.BackgroundImage = null;
            N502BParameters.Нагрузка = true;
            N502BParameters.КнопкаНагрузка = true;
            ЛампочкаСфазировано.BackgroundImage = N502BParameters.ФазировкаГорит
                ? ControlElementImages.lampType12OnRed
                : null;

            var angle = N502BParameters.ИндикаторНапряжение * 0.25F - 70;
            ИндикаторНапряжение.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow2, angle);

            angle = N502BParameters.ИндикаторТокНагрузки * 0.25F - 70;
            ИндикаторТокНагрузки.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow2, angle);
            
        }

        private void КнопкаВклНагрузки_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаВклНагрузки.BackgroundImage = ControlElementImages.buttonRoundType3;
            N502BParameters.КнопкаНагрузка = false;
            RefreshForm();
        }
        #endregion

        #region Переключатели

        private void ПереключательСеть_Click(object sender, System.EventArgs e)
        {
            if (N502BParameters.ПереключательСеть)
            {
                ПереключательСеть.BackgroundImage = ControlElementImages.tumblerN502BPowerDown;
                N502BParameters.ПереключательСеть = false;
            }
            else
            {
                ПереключательСеть.BackgroundImage = ControlElementImages.tumblerN502BPowerUp;
                N502BParameters.ПереключательСеть = true;
            }
            if (N502BParameters.ЛампочкаСеть && N502BParameters.ПереключательСеть) N502BParameters.StationTimer.Start();
            else N502BParameters.StationTimer.Stop();
        }

        private void ПереключательНапряжение_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N502BParameters.ПереключательНапряжение += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N502BParameters.ПереключательНапряжение -= 1;
            }
        }

        private void ПереключательФазировка_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N502BParameters.ПереключательФазировка += 1;
                if (N502BParameters.ПереключательФазировка == 5) N502BParameters.ПереключательФазировка = 1;
            }
            if (e.Button == MouseButtons.Right)
            {
                N502BParameters.ПереключательФазировка -= 1;
                if (N502BParameters.ПереключательФазировка == 0) N502BParameters.ПереключательФазировка = 4;
            }
        }

        private void ПереключательКонтрольНапряжения_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N502BParameters.ПереключательКонтрольНапряжения += 1;
            }
            if (e.Button == MouseButtons.Right)
            {
                N502BParameters.ПереключательКонтрольНапряжения -= 1;
            }
        }

        private void ПереключательТокНагрузкиИЗаряда_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N502BParameters.ПереключательТокНагрузкиИЗаряда += 1;
            }
            if (e.Button == MouseButtons.Right)
            {
                N502BParameters.ПереключательТокНагрузкиИЗаряда -= 1;
            }
        }

        #endregion

        #region Обновление формы

        private void RefreshForm()
        {
            ВремяРаботы.Text = Math.Round(N502BParameters.ВремяРаботыСтанции.TotalHours, 1).ToString(CultureInfo.CurrentCulture);

            this.RefreshLamps();
            this.RefreshTogglesPosition();
            this.RefreshTumblersPosition();

            var angle = N502BParameters.ИндикаторНапряжение * 0.25F - 70;
            ИндикаторНапряжение.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow2, angle);

            angle = N502BParameters.ИндикаторТокНагрузки * 0.25F - 70;
            ИндикаторТокНагрузки.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow2, angle);

            angle = N502BParameters.ИндикаторКонтрольНапряжения * 1.5F - 60;
            ИндикаторКонтрольНапряжения.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow2, angle);

            angle = N502BParameters.ИндикаторТокНагрузкиИЗаряда * 1.75F - 70;
            ИндикаторТокНагрузкиИЗаряда.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow2, angle);
        }

        private void RefreshTumblersPosition()
        {
            ТумблерЭлектрооборудование.BackgroundImage = N502BParameters.ТумблерЭлектрооборудование ?
                ControlElementImages.tumblerType2Up : ControlElementImages.tumblerType2Down;

            ТумблерВыпрямитель27В.BackgroundImage = N502BParameters.ТумблерВыпрямитель27В ?
                ControlElementImages.tumblerType2Up : ControlElementImages.tumblerType2Down;

            ТумблерОсвещение.BackgroundImage = !N502BParameters.ТумблерОсвещение ?
                ControlElementImages.tumblerType2Down : ControlElementImages.tumblerType2Up;

            ТумблерН131.BackgroundImage = !N502BParameters.ТумблерН131 ?
                ControlElementImages.tumblerType2Down : ControlElementImages.tumblerType2Up;

            ТумблерН132.BackgroundImage = !N502BParameters.ТумблерН132 ?
                ControlElementImages.tumblerType2Down : ControlElementImages.tumblerType2Up;

            ТумблерН15.BackgroundImage = !N502BParameters.ТумблерН15 ?
                ControlElementImages.tumblerType2Down : ControlElementImages.tumblerType2Up;

            switch (N502BParameters.ТумблерОсвещение1)
            {
                case 2:
                    ТумблерОсвещение1.BackgroundImage = ControlElementImages.tumblerType5Middle;
                    break;
                case 1:
                    ТумблерОсвещение1.BackgroundImage = ControlElementImages.tumblerType5Up;
                    break;
                default:
                    ТумблерОсвещение1.BackgroundImage = ControlElementImages.tumblerType5Down;
                    break;
            }

            switch (N502BParameters.ТумблерОсвещение2)
            {
                case 2:
                    ТумблерОсвещение2.BackgroundImage = ControlElementImages.tumblerType5Middle;
                    break;
                case 1:
                    ТумблерОсвещение2.BackgroundImage = ControlElementImages.tumblerType5Up;
                    break;
                default:
                    ТумблерОсвещение2.BackgroundImage = ControlElementImages.tumblerType5Down;
                    break;
            }
        }

        private void RefreshTogglesPosition()
        {
            ПереключательСеть.BackgroundImage = N502BParameters.ПереключательСеть
                ? ControlElementImages.tumblerN502BPowerUp
                : ControlElementImages.tumblerN502BPowerDown;

            var angle = N502BParameters.ПереключательНапряжение * 38 - 150;
            ПереключательНапряжение.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N502BParameters.ПереключательФазировка * 90 - 180;
            ПереключательФазировка.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType5, angle);

            angle = N502BParameters.ПереключательКонтрольНапряжения * 45 - 90;
            ПереключательКонтрольНапряжения.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType1, angle);

            angle = N502BParameters.ПереключательТокНагрузкиИЗаряда * 40 - 180;
            ПереключательТокНагрузкиИЗаряда.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType4, angle);
        }

        private void RefreshLamps()
        {
            ЛампочкаСеть.BackgroundImage = N502BParameters.ЛампочкаСеть
                ? ControlElementImages.lampType12OnRed
                : null;

            ЛампочкаСфазировано.BackgroundImage = N502BParameters.ЛампочкаСфазировано
                ? ControlElementImages.lampType12OnRed
                : null;
        }

        #endregion
    }
}