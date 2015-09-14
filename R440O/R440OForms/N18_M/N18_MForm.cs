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
        private void ТумблерДАБ5_Click(object sender, System.EventArgs e)
        {
            N18_MParameters.ТумблерДАБ5 = !N18_MParameters.ТумблерДАБ5;
        }

        private void ТумблерКАУ_ПРМ_Click(object sender, System.EventArgs e)
        {
            N18_MParameters.ТумблерКАУ_ПРМ = !N18_MParameters.ТумблерКАУ_ПРМ;
        }

        private void ТумблерПРД_СС_Click(object sender, System.EventArgs e)
        {
            N18_MParameters.ТумблерПРД_СС = !N18_MParameters.ТумблерПРД_СС;
        }

        private void ТумблерТЛФ_ПРМ_Click(object sender, System.EventArgs e)
        {
            N18_MParameters.ТумблерТЛФ_ПРМ = !N18_MParameters.ТумблерТЛФ_ПРМ;
        }

        #endregion

        #region Переключатели
        private void ПереключательПРМ1_MouseUp(object sender, MouseEventArgs e)
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

        private void ПереключательПРМ2_MouseUp(object sender, MouseEventArgs e)
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

        private void ПереключательВходК1_2_1_MouseUp(object sender, MouseEventArgs e)
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

        private void ПереключательПРД_MouseUp(object sender, MouseEventArgs e)
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

        private void ПереключательПРДБМА12_MouseUp(object sender, MouseEventArgs e)
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

        private void ПереключательПРМСС1_MouseUp(object sender, MouseEventArgs e)
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

        private void ПереключательПРМСС2_MouseUp(object sender, MouseEventArgs e)
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

        private void Переключатель48ПРМЩВ_MouseUp(object sender, MouseEventArgs e)
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

        private void ПереключательВыход2РН_MouseUp(object sender, MouseEventArgs e)
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

        private void ПереключательВыход1РН_MouseUp(object sender, MouseEventArgs e)
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

        private void ПереключательВходБ22_MouseUp(object sender, MouseEventArgs e)
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
            ТумблерДАБ5.BackgroundImage = N18_MParameters.ТумблерДАБ5
                ? ControlElementImages.tumblerType5Right
                : ControlElementImages.tumblerType5Left;

            ТумблерКАУ_ПРМ.BackgroundImage = N18_MParameters.ТумблерКАУ_ПРМ
                ? ControlElementImages.tumblerType5Right
                : ControlElementImages.tumblerType5Left;

            ТумблерПРД_СС.BackgroundImage = N18_MParameters.ТумблерПРД_СС
                ? ControlElementImages.tumblerType5Right
                : ControlElementImages.tumblerType5Left;

            ТумблерТЛФ_ПРМ.BackgroundImage = N18_MParameters.ТумблерТЛФ_ПРМ
                ? ControlElementImages.tumblerType5Right
                : ControlElementImages.tumblerType5Left;

            var angle = N18_MParameters.ПереключательПРМ1 * 40 - 120;
            ПереключательПРМ1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.ПереключательПРМ2 * 40 - 120;
            ПереключательПРМ2.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.ПереключательВходК121 * 40 - 120;
            ПереключательВходК1_2_1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.ПереключательПРД * 40 - 120;
            ПереключательПРД.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.ПереключательПрдБма12 * 28 - 180;
            if (N18_MParameters.ПереключательПрдБма12 == 6) angle += 12;
            else if (N18_MParameters.ПереключательПрдБма12 > 6) angle += 28;   ////Смещение
            ПереключательПРДБМА12.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.ПереключательПрмСс1 * 40 - 120;
            ПереключательПРМСС1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.ПереключательПрмСс2 * 40 - 120;
            ПереключательПРМСС2.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.Переключатель48ПрмЩв * 50 - 75;
            Переключатель48ПРМЩВ.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.ПереключательВыход2РН * 50 - 75;
            ПереключательВыход2РН.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.ПереключательВыход1РН * 50 - 75;
            ПереключательВыход1РН.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = N18_MParameters.ПереключательВходБ22 * 50 - 75;
            ПереключательВходБ22.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }
    }
}