//-----------------------------------------------------------------------
// <copyright file="B1_1Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.B1_1
{
    using System.Windows.Forms;
    using Parameters;

    /// <summary>
    /// Форма блока Б1-1
    /// </summary>
    public partial class B1_1Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="B1_1Form"/>.
        /// </summary>
        public B1_1Form()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Переключение кнопки скорость В ГР
        /// </summary>
        private void B1_1КнопкаСкоростьГР_Click(object sender, System.EventArgs e)
        {
            if (B1_1Parameters.B1_1КнопкаСкоростьГР == "false")
            {
                this.B1_1КнопкаСкоростьГР.BackgroundImage = null;
                B1_1Parameters.B1_1КнопкаСкоростьГР = "true";
            }
            else
            {
                this.B1_1КнопкаСкоростьГР.BackgroundImage = ControlElementImages.buttonRectType1;
                B1_1Parameters.B1_1КнопкаСкоростьГР = "false";
            }
        }

        /// <summary>
        /// Переключение кнопки скорость В АБ 1ТЛФК
        /// </summary>
        private void B1_1КнопкаСкоростьАБ_1ТЛФ_К_Click(object sender, System.EventArgs e)
        {
            if (B1_1Parameters.B1_1КнопкаСкоростьАБ_1ТЛФ_К == "false")
            {
                this.B1_1КнопкаСкоростьАБ_1ТЛФ_К.BackgroundImage = null;
                B1_1Parameters.B1_1КнопкаСкоростьАБ_1ТЛФ_К = "true";
            }
            else
            {
                this.B1_1КнопкаСкоростьАБ_1ТЛФ_К.BackgroundImage = ControlElementImages.buttonRectType1;
                B1_1Parameters.B1_1КнопкаСкоростьАБ_1ТЛФ_К = "false";
            }
        }

        /// <summary>
        /// Переключение тумблера управления питанием блока
        /// </summary>
        private void B1_1ТумблерМуДу_Click(object sender, System.EventArgs e)
        {
            if (B1_1Parameters.B1_1ТумблерМуДу == "Му")
            {
                this.B1_1ТумблерМуДу.BackgroundImage = ControlElementImages.tumblerType4Down;
                B1_1Parameters.B1_1ТумблерМуДу = "Ду";
            }
            else
            {
                this.B1_1ТумблерМуДу.BackgroundImage = ControlElementImages.tumblerType4Up;
                B1_1Parameters.B1_1ТумблерМуДу = "Му";
            }
        }
    }
}