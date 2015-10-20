//-----------------------------------------------------------------------
// <copyright file="A403_3Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using R440O.BaseClasses;

namespace R440O.R440OForms.A403_3
{
    using System.Windows.Forms;

    /// <summary>
    /// Форма блока A403-3
    /// </summary>
    public partial class A403_3Form : Form, IRefreshableForm
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="A403_3Form"/>.
        /// </summary>
        public A403_3Form()
        {
            InitializeComponent();
            A403_3Parameters.ParameterChanged += RefreshFormElements;
            RefreshFormElements();
        }

        /// <summary>
        /// Задание начального положения тумблера для выбора комплекта блока
        /// </summary>
        public void RefreshFormElements()
        {
            ТублерКомплект.BackgroundImage = A403_3Parameters.ТублерКомплект
                ? ControlElementImages.tumblerType4Left
                : ControlElementImages.tumblerType4Right;

            //лампочки
            Лампочка1Комплект_1.BackgroundImage = A403_3Parameters.Лампочка1Комплект_1
                ? ControlElementImages.lampType5OnRed
                : null;
            Лампочка1Комплект_2.BackgroundImage = A403_3Parameters.Лампочка1Комплект_2
                ? ControlElementImages.lampType5OnRed
                : null;
            Лампочка1Комплект_3.BackgroundImage = A403_3Parameters.Лампочка1Комплект_3
                ? ControlElementImages.lampType5OnRed
                : null;
            Лампочка1Комплект_4.BackgroundImage = A403_3Parameters.Лампочка1Комплект_4
                ? ControlElementImages.lampType5OnRed
                : null;

            Лампочка2Комплект_1.BackgroundImage = A403_3Parameters.Лампочка2Комплект_1
                ? ControlElementImages.lampType5OnRed
                : null;
            Лампочка2Комплект_2.BackgroundImage = A403_3Parameters.Лампочка2Комплект_2
                ? ControlElementImages.lampType5OnRed
                : null;
            Лампочка2Комплект_3.BackgroundImage = A403_3Parameters.Лампочка2Комплект_3
                ? ControlElementImages.lampType5OnRed
                : null;
            Лампочка2Комплект_4.BackgroundImage = A403_3Parameters.Лампочка2Комплект_4
                ? ControlElementImages.lampType5OnRed
                : null;
        }

        private void ТублерКомплект_Click(object sender, System.EventArgs e)
        {
            A403_3Parameters.ТублерКомплект = !A403_3Parameters.ТублерКомплект;
        }

        private void A403_3Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            A403_3Parameters.ParameterChanged -= RefreshFormElements;
        }
    }
}