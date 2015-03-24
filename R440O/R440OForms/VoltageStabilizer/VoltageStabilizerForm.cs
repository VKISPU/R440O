namespace R440O.R440OForms.VoltageStabilizer
{
    using System.Drawing;
    using System.Windows.Forms;
    using ThirdParty;

    /// <summary>
    /// Форма блока стабилизатор напряжения
    /// </summary>
    public partial class VoltageStabilizerForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="VoltageStabilizerForm"/>
        /// </summary>
        public VoltageStabilizerForm()
        {
            this.InitializeComponent();
            this.InitializeTogglePosition();
            this.InitializeLamps();
            VoltageStabilizerParameters.RefreshForm += RefreshForm;
        }

        #region Обработка действий пользователя

        /// <summary>
        /// Обработка клика на кабельный вход 220В.
        /// Если питание отключено, оно будет установлено на 220В.
        /// Если питание установлено на 220В, то оно будет отключено.
        /// Если питание установлено на 380В, то оно будет переключено на 220В.
        /// </summary>
        private void КабельВход1_Click(object sender, System.EventArgs e)
        {
            switch (VoltageStabilizerParameters.КабельВход)
            {
                case 0:
                    КабельВход1.BackgroundImage = ControlElementImages.voltageStabilizerInput;
                    VoltageStabilizerParameters.КабельВход = 220;
                    break;
                case 220:
                    КабельВход1.BackgroundImage = null;
                    VoltageStabilizerParameters.КабельВход = 0;
                    break;
                case 380:
                    КабельВход1.BackgroundImage = ControlElementImages.voltageStabilizerInput;
                    КабельВход2.BackgroundImage = null;
                    VoltageStabilizerParameters.КабельВход = 220;
                    break;
            }
        }

        /// <summary>
        /// Обработка клика на кабельный вход 380В.
        /// Если питание отключено, оно будет установлено на 380В.
        /// Если питание установлено на 380В, то оно будет отключено.
        /// Если питание установлено на 220В, то оно будет переключено на 380В.
        /// </summary>
        private void КабельВход2_Click(object sender, System.EventArgs e)
        {
            switch (VoltageStabilizerParameters.КабельВход)
            {
                case 0:
                    КабельВход2.BackgroundImage = ControlElementImages.voltageStabilizerInput;
                    VoltageStabilizerParameters.КабельВход = 380;
                    break;
                case 220:
                    КабельВход1.BackgroundImage = null;
                    КабельВход2.BackgroundImage = ControlElementImages.voltageStabilizerInput;
                    VoltageStabilizerParameters.КабельВход = 380;
                    break;
                case 380:
                    КабельВход2.BackgroundImage = null;
                    VoltageStabilizerParameters.КабельВход = 0;
                    break;
            }
        }

        /// <summary>
        /// Переключатель КонтрольНапряжения
        /// </summary>
        private void ПереключательКонтрольНапр_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                VoltageStabilizerParameters.ПереключательКонтрольНапр += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                VoltageStabilizerParameters.ПереключательКонтрольНапр -= 1;
            }

            var angle = VoltageStabilizerParameters.ПереключательКонтрольНапр*30 - 195;
            ПереключательКонтрольНапр.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
        }

        #endregion

        #region Иницилизация ламп и переключателя

        /// <summary>
        /// Инициализация начальных положений переключателей, а также
        /// восстановление положений при повторном открытии формы
        /// </summary>
        private void InitializeTogglePosition()
        {
            switch (VoltageStabilizerParameters.КабельВход)
            {
                case 0:
                    КабельВход1.BackgroundImage = null;
                    КабельВход2.BackgroundImage = null;
                    break;
                case 220:
                    КабельВход1.BackgroundImage = ControlElementImages.voltageStabilizerInput;
                    КабельВход2.BackgroundImage = null;
                    break;
                case 380:
                    КабельВход1.BackgroundImage = null;
                    КабельВход2.BackgroundImage = ControlElementImages.voltageStabilizerInput;
                    break;
            }
            var angle = VoltageStabilizerParameters.ПереключательКонтрольНапр*30 - 195;
            ПереключательКонтрольНапр.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
        }

        private void InitializeLamps()
        {
            ЛампочкаСетьВкл.BackgroundImage = VoltageStabilizerParameters.ЛампочкаСетьВкл
                ? ControlElementImages.lampType9OnGreen
                : null;

            ЛампочкаАвария.BackgroundImage = VoltageStabilizerParameters.ЛампочкаАвария
                ? ControlElementImages.lampType6OnRed
                : null;
        }

        #endregion

        private void RefreshForm()
        {
            ИндикаторНапряжения.Invalidate();
            ЛампочкаСетьВкл.BackgroundImage = VoltageStabilizerParameters.ЛампочкаСетьВкл
                ? ControlElementImages.lampType9OnGreen
                : null;

            ЛампочкаАвария.BackgroundImage = VoltageStabilizerParameters.ЛампочкаАвария
                ? ControlElementImages.lampType6OnRed
                : null;
        }

        #region Отрисовка индикатора напряжения

        private void ИндикаторНапряжения_Paint(object sender, PaintEventArgs e)
        {
            switch (VoltageStabilizerParameters.ИндикаторНапряжение())
            {
                case 0:
                    DrawLine(e.Graphics, 10, 50, 50, 80);
                    break;
                case 127:
                    DrawLine(e.Graphics, 35, 40, 60, 80);
                    break;
                case 220:
                    DrawLine(e.Graphics, 55, 30, 65, 80);
                    break;
                case 380:
                    DrawLine(e.Graphics, 100, 30, 70, 80);
                    break;
            }
        }

        private void DrawLine(Graphics g, int x1, int y1, int x2, int y2)
        {
            var point1 = new Point(x1, y1);
            var point2 = new Point(x2, y2);
            var myPen = new Pen(Color.Black, 5);
            g.DrawLine(myPen, point1, point2);
        }

        #endregion
    }
}