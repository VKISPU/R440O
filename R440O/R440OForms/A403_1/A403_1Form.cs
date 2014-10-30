//-----------------------------------------------------------------------
// <copyright file="A403_1Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using R440O.Parameters;

namespace R440O.R440OForms.A403_1
{
    using System.Windows.Forms;

    /// <summary>
    /// Форма блока А403-1
    /// </summary>
    public partial class A403_1Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="A403_1Form"/>.
        /// </summary>
        public A403_1Form()
        {
            this.InitializeComponent();
            A403_1Parameters.A403_1ТумблерСеть = "откл";
            A403_1Parameters.A403_1ТумблерСеть = "1";
            A403_1Parameters.A403_1ТумблерГотов = "откл";
            A403_1Parameters.A403_1ТумблерГруппа = "2группа";
            A403_1Parameters.A403_1ТумблерАвтКоррекция = "откл";
        }

        #region Тумблеры
        private void A403_1ТумблерСеть_Click(object sender, System.EventArgs e)
        {
            if (A403_1Parameters.A403_1ТумблерСеть == "сеть")
            {
                this.A403_1ТумблерСеть.BackgroundImage = ControlElementImages.tumblerVerticalType3Down;
                A403_1Parameters.A403_1ТумблерСеть = "откл";
            }
            else
            {
                this.A403_1ТумблерСеть.BackgroundImage = ControlElementImages.tumblerVerticalType3Up;
                A403_1Parameters.A403_1ТумблерСеть = "сеть";
            }
        }

        private void A403_1ТумблерКомплект_Click(object sender, System.EventArgs e)
        {
            if (A403_1Parameters.A403_1ТумблерКомплект == "1")
            {
                this.A403_1ТумблерКомплект.BackgroundImage = ControlElementImages.tumblerHorizontalType1Right;
                A403_1Parameters.A403_1ТумблерКомплект = "2";
            }
            else
            {
                this.A403_1ТумблерКомплект.BackgroundImage = ControlElementImages.tumblerHorizontalType1Left;
                A403_1Parameters.A403_1ТумблерКомплект = "1";
            }
        }

        private void A403_1ТумблерГотов_Click(object sender, System.EventArgs e)
        {
            if (A403_1Parameters.A403_1ТумблерГотов == "готов")
            {
                this.A403_1ТумблерГотов.BackgroundImage = ControlElementImages.tumblerVerticalType1Down;
                A403_1Parameters.A403_1ТумблерГотов = "откл";
            }
            else
            {
                this.A403_1ТумблерГотов.BackgroundImage = ControlElementImages.tumblerVerticalType1Up;
                A403_1Parameters.A403_1ТумблерГотов = "готов";
            }
        }

        private void A403_1ТумблерГруппа_Click(object sender, System.EventArgs e)
        {
            if (A403_1Parameters.A403_1ТумблерГруппа == "1группа")
            {
                this.A403_1ТумблерГруппа.BackgroundImage = ControlElementImages.tumblerVerticalType1Down;
                A403_1Parameters.A403_1ТумблерГруппа = "2группа";
            }
            else
            {
                this.A403_1ТумблерГруппа.BackgroundImage = ControlElementImages.tumblerVerticalType1Up;
                A403_1Parameters.A403_1ТумблерГруппа = "1группа";
            }
        }

        private void A403_1ТумблерАвтКоррекция_Click(object sender, System.EventArgs e)
        {
            if (A403_1Parameters.A403_1ТумблерАвтКоррекция == "автКоррекция")
            {
                this.A403_1ТумблерАвтКоррекция.BackgroundImage = ControlElementImages.tumblerVerticalType1Down;
                A403_1Parameters.A403_1ТумблерАвтКоррекция = "откл";
            }
            else
            {
                this.A403_1ТумблерАвтКоррекция.BackgroundImage = ControlElementImages.tumblerVerticalType1Up;
                A403_1Parameters.A403_1ТумблерАвтКоррекция = "автКоррекция";
            }
        }
        #endregion
    }
}