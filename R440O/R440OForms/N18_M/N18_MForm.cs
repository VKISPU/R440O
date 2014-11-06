//-----------------------------------------------------------------------
// <copyright file="N18_MForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using R440O.Parameters;

namespace R440O.R440OForms.N18_M
{
    using System.Windows.Forms;

    /// <summary>
    /// Форма блока Н-18-М
    /// </summary>
    public partial class N18_MForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="N18_MForm"/>
        /// </summary>
        public N18_MForm()
        {
            this.InitializeComponent();
            N18_MParameters.N18_MТумблерДАБ5 = "прм1";
            N18_MParameters.N18_MТумблерКАУ_ПРМ = "Б11";
            N18_MParameters.N18_MТумблерПРД_СС = "КонтурП";
        }

        private void N18_MТумблерДАБ5_Click(object sender, System.EventArgs e)
        {
            if (N18_MParameters.N18_MТумблерДАБ5 == "прм1")
            {
                this.N18_MТумблерДАБ5.BackgroundImage = ControlElementImages.tumblerHorizontalType5Right;
                N18_MParameters.N18_MТумблерДАБ5 = "прм2";
            }
            else
            {
                this.N18_MТумблерДАБ5.BackgroundImage = ControlElementImages.tumblerHorizontalType5Left;
                N18_MParameters.N18_MТумблерДАБ5 = "прм1";
            }
        }

        private void N18_MТумблерКАУ_ПРМ_Click(object sender, System.EventArgs e)
        {
            if (N18_MParameters.N18_MТумблерКАУ_ПРМ == "Б11")
            {
                this.N18_MТумблерКАУ_ПРМ.BackgroundImage = ControlElementImages.tumblerHorizontalType5Right;
                N18_MParameters.N18_MТумблерКАУ_ПРМ = "Б31";
            }
            else
            {
                this.N18_MТумблерКАУ_ПРМ.BackgroundImage = ControlElementImages.tumblerHorizontalType5Left;
                N18_MParameters.N18_MТумблерКАУ_ПРМ = "Б11";
            }
        }

        private void N18_MТумблерПРД_СС_Click(object sender, System.EventArgs e)
        {
            if (N18_MParameters.N18_MТумблерПРД_СС == "КонтурП")
            {
                this.N18_MТумблерПРД_СС.BackgroundImage = ControlElementImages.tumblerHorizontalType5Right;
                N18_MParameters.N18_MТумблерПРД_СС = "ЩВ";
            }
            else
            {
                this.N18_MТумблерПРД_СС.BackgroundImage = ControlElementImages.tumblerHorizontalType5Left;
                N18_MParameters.N18_MТумблерПРД_СС = "КонтурП";
            }
        }

        private void N18_MТумблерТЛФ_ПРМ_Click(object sender, System.EventArgs e)
        {
            if (N18_MParameters.N18_MТумблерТЛФ_ПРМ == "осн")
            {
                this.N18_MТумблерТЛФ_ПРМ.BackgroundImage = ControlElementImages.tumblerHorizontalType5Right;
                N18_MParameters.N18_MТумблерТЛФ_ПРМ = "резерв";
            }
            else
            {
                this.N18_MТумблерТЛФ_ПРМ.BackgroundImage = ControlElementImages.tumblerHorizontalType5Left;
                N18_MParameters.N18_MТумблерТЛФ_ПРМ = "осн";
            }
        }
    }
}