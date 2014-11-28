//-----------------------------------------------------------------------
// <copyright file="B1_2Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using R440O.Parameters;

namespace R440O.R440OForms.B1_2
{
    using System.Windows.Forms;
    
    /// <summary>
    /// Форма блока Б1-2
    /// </summary>
    public partial class B1_2Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="B1_2Form"/>.
        /// </summary>
        public B1_2Form()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Переключение кнопки скорость В ГР
        /// </summary>
        private void B1_2КнопкаСкоростьГР_Click(object sender, System.EventArgs e)
        {
            if (B1_2Parameters.B1_2КнопкаСкоростьГР == "false")
            {
                this.B1_2КнопкаСкоростьГР.BackgroundImage = null;
                B1_2Parameters.B1_2КнопкаСкоростьГР = "true";
            }
            else
            {
                this.B1_2КнопкаСкоростьГР.BackgroundImage = ControlElementImages.buttonRectType1;
                B1_2Parameters.B1_2КнопкаСкоростьГР = "false";
            }
        }

        /// <summary>
        /// Переключение кнопки скорость В АБ 1ТЛФК
        /// </summary>
        private void B1_2КнопкаСкоростьАБ_1ТЛФ_К_Click(object sender, System.EventArgs e)
        {
            if (B1_2Parameters.B1_2КнопкаСкоростьАБ_1ТЛФ_К == "false")
            {
                this.B1_2КнопкаСкоростьАБ_1ТЛФ_К.BackgroundImage = null;
                B1_2Parameters.B1_2КнопкаСкоростьАБ_1ТЛФ_К = "true";
            }
            else
            {
                this.B1_2КнопкаСкоростьАБ_1ТЛФ_К.BackgroundImage = ControlElementImages.buttonRectType1;
                B1_2Parameters.B1_2КнопкаСкоростьАБ_1ТЛФ_К = "false";
            }
        }

        /// <summary>
        /// Переключение тумблера управления питанием блока
        /// </summary>
        private void B1_2ТумблерМуДу_Click(object sender, System.EventArgs e)
        {
            if (B1_2Parameters.B1_2ТумблерМуДу == "Му")
            {
                this.B1_2ТумблерМуДу.BackgroundImage = ControlElementImages.tumblerType4Down;
                B1_2Parameters.B1_2ТумблерМуДу = "Ду";
            }
            else
            {
                this.B1_2ТумблерМуДу.BackgroundImage = ControlElementImages.tumblerType4Up;
                B1_2Parameters.B1_2ТумблерМуДу = "Му";
            }
        }
    }
}