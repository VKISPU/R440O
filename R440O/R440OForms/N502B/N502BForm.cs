//-----------------------------------------------------------------------
// <copyright file="N502BForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using System.Drawing;
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
            N502BParameters.RefreshForm += InitializeLamps;
            N502BParameters.RefreshForm += ИндикаторНапряжение.Invalidate;
            N502BParameters.RefreshForm += ИндикаторКонтрольНапряжения.Invalidate;

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
            N502BParameters.КнопкаВклНагрузки = true;
        }

        private void КнопкаВклНагрузки_MouseUp(object sender, MouseEventArgs e)
        {
            КнопкаВклНагрузки.BackgroundImage = ControlElementImages.buttonRoundType3;
            N502BParameters.КнопкаВклНагрузки = false;
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

        private void DrawLine(Graphics g, int x1, int y1, int x2, int y2)
        {
            var point1 = new Point(x1, y1);
            var point2 = new Point(x2, y2);
            var myPen = new Pen(Color.Black, 5);
            g.DrawLine(myPen, point1, point2);
        }

        #region Отрисовка индикатора напряжения
        private void ИндикаторНапряжение_Paint(object sender, PaintEventArgs e)
        {
            switch (N502BParameters.ИндикаторНапряжение)
            {
                case 0:
                    DrawLine(e.Graphics, 10, 40, 45, 55);
                    break;
                case 220:
                    DrawLine(e.Graphics, 20, 20, 45, 55);
                    break;
                case 380:
                    DrawLine(e.Graphics, 60, 20, 45, 55);
                    break;
            }
        }
        #endregion

        private void ИндикаторКонтрольНапряжения_Paint(object sender, PaintEventArgs e)
        {
            switch (N502BParameters.ИндикаторКонтрольНапряжения)
            {
                case 0:
                    DrawLine(e.Graphics, 0, 40, 45, 70);
                    break;
                case 10:
                    DrawLine(e.Graphics, 10, 35, 45, 70);
                    break;
                case 20:
                    DrawLine(e.Graphics, 20, 30, 45, 70);
                    break;
                case 30:
                    DrawLine(e.Graphics, 30, 25, 45, 70);
                    break;
                case 40:
                    DrawLine(e.Graphics, 40, 20, 45, 70);
                    break;
                case 50:
                    DrawLine(e.Graphics, 50, 25, 45, 70);
                    break;
                case 60:
                    DrawLine(e.Graphics, 60, 25, 45, 70);
                    break;
                case 70:
                    DrawLine(e.Graphics, 70, 30, 45, 70);
                    break;
                case 80:
                    DrawLine(e.Graphics, 80, 35, 45, 70);
                    break;
            }
        }

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