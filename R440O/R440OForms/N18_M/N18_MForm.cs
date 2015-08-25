namespace R440O.R440OForms.N18_M
{
    using System.Windows.Forms;
    using BaseClasses;
    using ThirdParty;
    using СостоянияЭлементов;

    /// <summary>
    /// Форма блока Н-18-М
    /// </summary>
    public partial class N18_MForm : Form, IRefreshableForm
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="N18_MForm"/>
        /// </summary>
        public N18_MForm()
        {
            this.InitializeComponent();
            N18_MParameters.ParameterChanged += RefreshFormElements;
            RefreshFormElements();
        }
        
        #region Тумблеры
        private void N18_MТумблерДАБ5_Click(object sender, System.EventArgs e)
        {
            N18_MParameters.ТумблерДАБ5 = N18_MParameters.ТумблерДАБ5 == ТумблерДаб5.Прм1 ? ТумблерДаб5.Прм2 : ТумблерДаб5.Прм1;
        }

        private void N18_MТумблерКАУ_ПРМ_Click(object sender, System.EventArgs e)
        {
            N18_MParameters.ТумблерКАУ_ПРМ = N18_MParameters.ТумблерКАУ_ПРМ == ТумблерКауПрм.Б11 ? ТумблерКауПрм.Б31 : ТумблерКауПрм.Б11;
        }

        private void N18_MТумблерПРД_СС_Click(object sender, System.EventArgs e)
        {
            N18_MParameters.ТумблерПРД_СС = N18_MParameters.ТумблерПРД_СС == ТумблерПрдСс.КонтурП ? ТумблерПрдСс.Щв : ТумблерПрдСс.КонтурП;
        }

        private void N18_MТумблерТЛФ_ПРМ_Click(object sender, System.EventArgs e)
        {
            N18_MParameters.ТумблерТЛФ_ПРМ = N18_MParameters.ТумблерТЛФ_ПРМ == ТумблерТлфПрм.Осн ? ТумблерТлфПрм.Резерв : ТумблерТлфПрм.Осн;
        }

        #endregion

        #region Переключатели
        private void N18_MПереключательПРМ1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N18_MParameters.ПереключательПРМ1 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N18_MParameters.ПереключательПРМ1 -= 1;
            }
        }

        private void N18_MПереключательПРМ2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N18_MParameters.ПереключательПРМ2 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N18_MParameters.ПереключательПРМ2 -= 1;
            }
        }

        private void N18_MПереключательВходК1_2_1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N18_MParameters.ПереключательВходК121 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N18_MParameters.ПереключательВходК121 -= 1;
            }
        }

        private void N18_MПереключательПРД_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N18_MParameters.ПереключательПРД += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N18_MParameters.ПереключательПРД -= 1;
            }
        }

        private void N18_MПереключательПРДБМА12_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N18_MParameters.ПереключательПрдБма12 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N18_MParameters.ПереключательПрдБма12 -= 1;
            }
        }

        private void N18_MПереключательПРМСС1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N18_MParameters.ПереключательПрмСс1 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N18_MParameters.ПереключательПрмСс1 -= 1;
            }
        }

        private void N18_MПереключательПРМСС2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N18_MParameters.ПереключательПрмСс2 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N18_MParameters.ПереключательПрмСс2 -= 1;
            }
        }

        private void N18_MПереключатель48ПРМЩВ_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N18_MParameters.Переключатель48ПрмЩв += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N18_MParameters.Переключатель48ПрмЩв -= 1;
            }
        }

        private void N18_MПереключательВыход2РН_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N18_MParameters.ПереключательВыход2РН += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N18_MParameters.ПереключательВыход2РН -= 1;
            }
        }

        private void N18_MПереключательВыход1РН_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N18_MParameters.ПереключательВыход1РН += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N18_MParameters.ПереключательВыход1РН -= 1;
            }
        }

        private void N18_MПереключательВходБ22_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N18_MParameters.ПереключательВходБ22 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                N18_MParameters.ПереключательВходБ22 -= 1;
            }
        }
        #endregion

        public void RefreshFormElements()
        {
            this.N18_MТумблерДАБ5.BackgroundImage = N18_MParameters.ТумблерДАБ5 == ТумблерДаб5.Прм1
                ? ControlElementImages.tumblerType5Left
                : ControlElementImages.tumblerType5Right;

            this.N18_MТумблерКАУ_ПРМ.BackgroundImage = N18_MParameters.ТумблерКАУ_ПРМ == ТумблерКауПрм.Б11
                ? ControlElementImages.tumblerType5Left
                : ControlElementImages.tumblerType5Right;

            this.N18_MТумблерПРД_СС.BackgroundImage = N18_MParameters.ТумблерПРД_СС == ТумблерПрдСс.КонтурП
                ? ControlElementImages.tumblerType5Left
                : ControlElementImages.tumblerType5Right;

            this.N18_MТумблерТЛФ_ПРМ.BackgroundImage = N18_MParameters.ТумблерТЛФ_ПРМ == ТумблерТлфПрм.Осн
                ? ControlElementImages.tumblerType5Left
                : ControlElementImages.tumblerType5Right;

            var angle = N18_MParameters.ПереключательПРМ1 * 40 - 120;
            N18_MПереключательПРМ1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.ПереключательПРМ2 * 40 - 120;
            N18_MПереключательПРМ2.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.ПереключательВходК121 * 40 - 120;
            N18_MПереключательВходК1_2_1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.ПереключательПРД * 40 - 120;
            N18_MПереключательПРД.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.ПереключательПрдБма12 * 28 - 180;
            if (N18_MParameters.ПереключательПрдБма12 == 6) angle += 12;
            else if (N18_MParameters.ПереключательПрдБма12 > 6) angle += 28;   ////Смещение
            N18_MПереключательПРДБМА12.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.ПереключательПрмСс1 * 40 - 120;
            N18_MПереключательПРМСС1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.ПереключательПрмСс2 * 40 - 120;
            N18_MПереключательПРМСС2.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.Переключатель48ПрмЩв * 50 - 75;
            N18_MПереключатель48ПРМЩВ.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.ПереключательВыход2РН * 50 - 75;
            N18_MПереключательВыход2РН.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.ПереключательВыход1РН * 50 - 75;
            N18_MПереключательВыход1РН.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.ПереключательВходБ22 * 50 - 75;
            N18_MПереключательВходБ22.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }
    }
}