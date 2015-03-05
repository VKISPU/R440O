namespace R440O.R440OForms.PU_K1_1
{
    using System.Windows.Forms;
    using Parameters;
    using ThirdParty;

    /// <summary>
    /// Форма блока пульт управления К01-1
    /// </summary>
    public partial class PU_K1_1Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PU_K1_1Form"/>
        /// </summary>
        public PU_K1_1Form()
        {
            this.InitializeComponent();
            this.InitializeTogglePosition();
        }

        /// <summary>
        /// Задание начальных положений переключателей
        /// </summary>
        private void InitializeTogglePosition()
        {
            var angle = PU_K1_1Parameters.PU_K1_1ПереключательКаналы * 30 - 75;
            PU_K1_1ПереключательКаналы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);

            angle = PU_K1_1Parameters.PU_K1_1ПереключательНапряжение * 28 - 180;
            PU_K1_1ПереключательНапряжение.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
        }

        #region Взаимодействие с элементами управления
        private void PU_K1_1ТумблерПитание_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) PU_K1_1Parameters.PU_K1_1ТумблерПитание--;
            else PU_K1_1Parameters.PU_K1_1ТумблерПитание++;

            switch (PU_K1_1Parameters.PU_K1_1ТумблерПитание)
            {
                case 0:
                    {
                        PU_K1_1ТумблерПитание.BackgroundImage = ControlElementImages.tumblerType6Up;
                        PU_K1_1Parameters.PU_K1_1ЛампочкаCеть = true;
                    }
                    break;
                case 1:
                    {
                        PU_K1_1ТумблерПитание.BackgroundImage = null;
                        PU_K1_1Parameters.PU_K1_1ЛампочкаCеть = false;
                    }
                    break;
                case 2:
                    {
                        PU_K1_1ТумблерПитание.BackgroundImage = ControlElementImages.tumblerType6Down;
                        PU_K1_1Parameters.PU_K1_1ЛампочкаCеть = false;
                    }
                    break;
            }

            PU_K1_1ЛампочкаCеть.BackgroundImage = PU_K1_1Parameters.PU_K1_1ЛампочкаCеть
                ? ControlElementImages.lampType9OnGreen
                : null;
        }

        private void PU_K1_1ПереключательКаналы_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PU_K1_1Parameters.PU_K1_1ПереключательКаналы++;
            }
            else
            {
                PU_K1_1Parameters.PU_K1_1ПереключательКаналы--;
            }

            var angle = PU_K1_1Parameters.PU_K1_1ПереключательКаналы * 30 - 75;
            PU_K1_1ПереключательКаналы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
        }

        private void PU_K1_1ПереключательНапряжение_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PU_K1_1Parameters.PU_K1_1ПереключательНапряжение++;
            }
            else
            {
                PU_K1_1Parameters.PU_K1_1ПереключательНапряжение--;
            }

            var angle = PU_K1_1Parameters.PU_K1_1ПереключательНапряжение * 28 - 180;
            PU_K1_1ПереключательНапряжение.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
        }
        #endregion

        private void PU_K1_1ТумблерВентВкл_Click(object sender, System.EventArgs e)
        {
            if (PU_K1_1Parameters.PU_K1_1ТумблерВентВкл)
            {
                this.PU_K1_1ТумблерВентВкл.BackgroundImage = ControlElementImages.tumblerType4Down;
                PU_K1_1Parameters.PU_K1_1ТумблерВентВкл = false;
            }
            else
            {
                this.PU_K1_1ТумблерВентВкл.BackgroundImage = ControlElementImages.tumblerType4Up;
                PU_K1_1Parameters.PU_K1_1ТумблерВентВкл = true;
            }
        }
    }
}