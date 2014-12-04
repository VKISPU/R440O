//-----------------------------------------------------------------------
// <copyright file="A1Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.A1
{
    using System.Windows.Forms;
    using Parameters;

    /// <summary>
    /// Форма блока А1
    /// </summary>
    public partial class A1Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="A1Form"/>
        /// </summary>
        public A1Form()
        {
            this.InitializeComponent();
            this.InitializeTumblersPosition();
            this.InitializeButtonsPosition();
        }

        /// <summary>
        /// Переключение кнопки скорость В АБ 1ТЛФК
        /// </summary>
        private void A1КнопкаСкоростьАБ_1ТЛФ_К_Click(object sender, System.EventArgs e)
        {
            if (A1Parameters.A1КнопкаСкоростьАБ_1ТЛФ_К == "false")
            {
                this.A1КнопкаСкоростьАБ_1ТЛФ_К.BackgroundImage = null;
                A1Parameters.A1КнопкаСкоростьАБ_1ТЛФ_К = "true";
            }
            else
            {
                this.A1КнопкаСкоростьАБ_1ТЛФ_К.BackgroundImage = ControlElementImages.buttonRectType1;
                A1Parameters.A1КнопкаСкоростьАБ_1ТЛФ_К = "false";
            }
        }

        /// <summary>
        /// Переключение кнопки скорость В ГР
        /// </summary>
        private void A1КнопкаСкоростьГР_Click(object sender, System.EventArgs e)
        {
            if (A1Parameters.A1КнопкаСкоростьГР == "false")
            {
                this.A1КнопкаСкоростьГР.BackgroundImage = null;
                A1Parameters.A1КнопкаСкоростьГР = "true";
            }
            else
            {
                this.A1КнопкаСкоростьГР.BackgroundImage = ControlElementImages.buttonRectType1;
                A1Parameters.A1КнопкаСкоростьГР = "false";
            }
        }

        /// <summary>
        /// Переключение тумблера управления питанием блока
        /// </summary>
        private void A1ТумблерМуДу_Click(object sender, System.EventArgs e)
        {
            if (A1Parameters.A1ТумблерМуДу == "Му")
            {
                this.A1ТумблерМуДу.BackgroundImage = ControlElementImages.tumblerType4Down;
                A1Parameters.A1ТумблерМуДу = "Ду";
            }
            else
            {
                this.A1ТумблерМуДу.BackgroundImage = ControlElementImages.tumblerType4Up;
                A1Parameters.A1ТумблерМуДу = "Му";
            }
        }


        private void InitializeTumblersPosition()
        {
            this.A1ТумблерМуДу.BackgroundImage = A1Parameters.A1ТумблерМуДу == "Ду"
                ? ControlElementImages.tumblerType4Down
                : ControlElementImages.tumblerType4Up;
        }

        private void InitializeButtonsPosition()
        {
            this.A1КнопкаСкоростьГР.BackgroundImage = A1Parameters.A1КнопкаСкоростьГР == "true"
                ? null
                : ControlElementImages.buttonRectType1;

            this.A1КнопкаСкоростьАБ_1ТЛФ_К.BackgroundImage = A1Parameters.A1КнопкаСкоростьАБ_1ТЛФ_К == "true"
                ? null
                : ControlElementImages.buttonRectType1;
        }
    }
}