//-----------------------------------------------------------------------
// <copyright file="N502BForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using R440O.R440OForms.PowerCabel;
using R440O.R440OForms.VoltageStabilizer;
using R440O.ThirdParty;


namespace R440O.R440OForms.N502B
{
    using System.Windows.Forms;

    public partial class N502BForm : Form
    {
        
        public N502BForm()
        {
            InitializeComponent();
            InitializeLamps();
            InitializeTumblersPosition();
            InitializeTogglesPosition();
            PowerCabelForm.RefreshForm += InitializeLamps;
        }

        #region Тумблеры

        private void ТумблерЭлектрооборудование_Click(object sender, System.EventArgs e)
        {
            N502BParameters.ТумблерЭлектрооборудование = !N502BParameters.ТумблерЭлектрооборудование;
            ТумблерЭлектрооборудование.BackgroundImage = N502BParameters.ТумблерЭлектрооборудование
                ? ControlElementImages.tumblerType2Up
                : ControlElementImages.tumblerType2Down;
        }

        private void ТумблерВыпрямитель27В_Click(object sender, System.EventArgs e)
        {
            N502BParameters.ТумблерВыпрямитель27В = !N502BParameters.ТумблерВыпрямитель27В;
            ТумблерВыпрямитель27В.BackgroundImage = N502BParameters.ТумблерВыпрямитель27В
                ? ControlElementImages.tumblerType2Up
                : ControlElementImages.tumblerType2Down;
        }

        private void ТумблерОсвещение_Click(object sender, System.EventArgs e)
        {
            N502BParameters.ТумблерОсвещение = !N502BParameters.ТумблерОсвещение;
            ТумблерОсвещение.BackgroundImage = N502BParameters.ТумблерОсвещение
                ? ControlElementImages.tumblerType2Up
                : ControlElementImages.tumblerType2Down;
        }

        private void ТумблерН131_Click(object sender, System.EventArgs e)
        {
            N502BParameters.ТумблерН131 = !N502BParameters.ТумблерН131;
            ТумблерН131.BackgroundImage = N502BParameters.ТумблерН131
                ? ControlElementImages.tumblerType2Up
                : ControlElementImages.tumblerType2Down;
        }

        private void ТумблерН132_Click(object sender, System.EventArgs e)
        {
            N502BParameters.ТумблерН132 = !N502BParameters.ТумблерН132;
            ТумблерН132.BackgroundImage = N502BParameters.ТумблерН132
                ? ControlElementImages.tumblerType2Up
                : ControlElementImages.tumblerType2Down;
        }

        private void ТумблерН15_Click(object sender, System.EventArgs e)
        {
            N502BParameters.ТумблерН15 = !N502BParameters.ТумблерН15;
            ТумблерН15.BackgroundImage = N502BParameters.ТумблерН15
                ? ControlElementImages.tumblerType2Up
                : ControlElementImages.tumblerType2Down;
        }

        private void ТумблерОсвещение1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    switch (N502BParameters.ТумблерОсвещение1)
                    {
                        case 1:
                            ТумблерОсвещение1.BackgroundImage = ControlElementImages.tumblerType5Middle;
                            N502BParameters.ТумблерОсвещение1 = 2;
                            break;
                        case 2:
                            ТумблерОсвещение1.BackgroundImage = ControlElementImages.tumblerType5Down;
                            N502BParameters.ТумблерОсвещение1 = 3;
                            break;
                    }
                    break;
                case MouseButtons.Right:
                    switch (N502BParameters.ТумблерОсвещение1)
                    {
                        case 3:
                            ТумблерОсвещение1.BackgroundImage = ControlElementImages.tumblerType5Middle;
                            N502BParameters.ТумблерОсвещение1 = 2;
                            break;
                        case 2:
                            ТумблерОсвещение1.BackgroundImage = ControlElementImages.tumblerType5Up;
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
                            ТумблерОсвещение2.BackgroundImage = ControlElementImages.tumblerType5Middle;
                            N502BParameters.ТумблерОсвещение2 = 2;
                            break;
                        case 2:
                            ТумблерОсвещение2.BackgroundImage = ControlElementImages.tumblerType5Down;
                            N502BParameters.ТумблерОсвещение2 = 3;
                            break;
                    }
                    break;
                case MouseButtons.Right:
                    switch (N502BParameters.ТумблерОсвещение2)
                    {
                        case 3:
                            ТумблерОсвещение2.BackgroundImage = ControlElementImages.tumblerType5Middle;
                            N502BParameters.ТумблерОсвещение2 = 2;
                            break;
                        case 2:
                            ТумблерОсвещение2.BackgroundImage = ControlElementImages.tumblerType5Up;
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
            if (!(N502BParameters.ЛампочкаСеть & N502BParameters.ПереключательФазировка == 4 &
                  N502BParameters.ПереключательСеть & VoltageStabilizerParameters.КабельВход == 380)) return;
            N502BParameters.ЛампочкаСфазировано = true;

            InitializeLamps();
        }

        private void КнопкаВклНагрузки_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаВклНагрузки.BackgroundImage = ControlElementImages.buttonRoundType3;
        }
        #endregion

        #region Переключатели

        private void ПереключательСеть_Click(object sender, System.EventArgs e)
        {
            if (N502BParameters.ПереключательСеть)
            {
                ПереключательСеть.BackgroundImage = ControlElementImages.tumblerN502BPowerDown;
                N502BParameters.ПереключательСеть = false;
                N502BParameters.ЛампочкаСфазировано = false;
                ЛампочкаСфазировано.BackgroundImage = null;
            }
            else
            {
                ПереключательСеть.BackgroundImage = ControlElementImages.tumblerN502BPowerUp;
                N502BParameters.ПереключательСеть = true;
            }
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

            var angle = N502BParameters.ПереключательНапряжение * 36 - 150;
            if (N502BParameters.ПереключательНапряжение >= 4) angle += 48;
            ПереключательНапряжение.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
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
            var angle = N502BParameters.ПереключательФазировка * 90 - 180;
            ПереключательФазировка.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType5, angle);

            if ((N502BParameters.ПереключательФазировка == 4 | N502BParameters.ПереключательФазировка == 2) & PowerCabelParameters.КабельСеть)
            {
                N502BParameters.ЛампочкаСеть = true;
            }
            else
            {
                N502BParameters.ЛампочкаСеть = false;
            }
            InitializeLamps();
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

            var angle = N502BParameters.ПереключательКонтрольНапряжения * 45 - 90;
            ПереключательКонтрольНапряжения.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType1, angle);
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

            var angle = N502BParameters.ПереключательТокНагрузкиИЗаряда * 40 - 180;
            ПереключательТокНагрузкиИЗаряда.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType4, angle);
        }

        #endregion

        #region Инициализация

        private void InitializeTumblersPosition()
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

        private void InitializeTogglesPosition()
        {
            ПереключательСеть.BackgroundImage = N502BParameters.ПереключательСеть
                ? ControlElementImages.tumblerN502BPowerUp
                : ControlElementImages.tumblerN502BPowerDown;

            var angle = N502BParameters.ПереключательНапряжение * 36 - 150;
            if (N502BParameters.ПереключательНапряжение >= 4) angle += 48;
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
        
        private void InitializeLamps()
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