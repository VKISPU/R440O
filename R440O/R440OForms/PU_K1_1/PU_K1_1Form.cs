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
        public void RefreshFormElements()
        {
            this.InitializeTogglePosition();
            this.InitializeTogglePosition();
            this.InitializeTumblers();
            this.InitializeLamp();
            this.InitializeIndicatorPosition();
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PU_K1_1Form"/>
        /// </summary>
        public PU_K1_1Form()
        {
            PU_K1_1Parameters.ParameterChanged += RefreshFormElements;
            this.InitializeComponent();
            this.RefreshFormElements();
        }

        /// <summary>
        /// Задание начальных положений переключателей
        /// </summary>
        private void InitializeTogglePosition()
        {
            var angle = PU_K1_1Parameters.ПереключательКаналы * 30 - 75;
            ПереключательКаналы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);

            angle = PU_K1_1Parameters.ПереключательНапряжение * 28 - 180;
            ПереключательНапряжение.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
        }

        /// <summary>
        /// Задание Положения индикатора напряжения
        /// </summary>
        private void InitializeIndicatorPosition()
        {
            var angle = PU_K1_1Parameters.Напряжение*6-60;
            СтрелкаКонтроляНапряжения.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow2, angle);
        }

        private void InitializeTumblers()
        {
            switch (PU_K1_1Parameters.ТумблерПитание)
            {
                case 0:
                    {
                        ТумблерПитание.BackgroundImage = ControlElementImages.tumblerType6Up;
                    }
                    break;
                case 1:
                    {
                        ТумблерПитание.BackgroundImage = null;
                    }
                    break;
                case 2:
                    {
                        ТумблерПитание.BackgroundImage = ControlElementImages.tumblerType6Down;
                    }
                    break;
            }
            this.ТумблерВентВкл.BackgroundImage = PU_K1_1Parameters.ТумблерВентВкл ? ControlElementImages.tumblerType4Up : ControlElementImages.tumblerType4Down;
        }

        private void InitializeLamp()
        {
            ЛампочкаCеть.BackgroundImage = PU_K1_1Parameters.ЛампочкаCеть
               ? ControlElementImages.lampType9OnGreen
               : null;
        }

        private void ТумблерПитание_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) PU_K1_1Parameters.ТумблерПитание--;
            else PU_K1_1Parameters.ТумблерПитание++;
        }

        private void ПереключательКаналы_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PU_K1_1Parameters.ПереключательКаналы++;
            }
            else
            {
                PU_K1_1Parameters.ПереключательКаналы--;
            }
        }

        private void ПереключательНапряжение_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PU_K1_1Parameters.ПереключательНапряжение++;
            }
            else
            {
                PU_K1_1Parameters.ПереключательНапряжение--;
            }
        }
       

        private void ТумблерВентВкл_Click(object sender, System.EventArgs e)
        {
            PU_K1_1Parameters.ТумблерВентВкл = !PU_K1_1Parameters.ТумблерВентВкл;
        }
    }
}