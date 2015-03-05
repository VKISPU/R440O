//-----------------------------------------------------------------------
// <copyright file="OrderSchemeForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.OrderScheme
{
    using System.Windows.Forms;
    using Parameters;
    /// <summary>
    /// Форма блока Схемы-Приказ
    /// </summary>
    public partial class OrderSchemeForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="OrderSchemeForm"/>
        /// </summary>
        public OrderSchemeForm()
        {
            this.InitializeComponent();
            InitializeParameters();
        }

        private void InitializeParameters()
        {
            OrderSchemeParameters.GenerateParameters();

            ПередачаУсловныйНомерВолны1.Text = OrderSchemeParameters.ПередачаУсловныйНомерВолны1.ToString();
            ПередачаУсловныйНомерВолны2.Text = OrderSchemeParameters.ПередачаУсловныйНомерВолны2.ToString();
            ПередачаУсловныйНомерВолны3.Text = OrderSchemeParameters.ПередачаУсловныйНомерВолны3.ToString();

            ПередачаПроверкаНаСебяА503_1.Text = OrderSchemeParameters.ПередачаПроверкаНаСебяУсловныйНомерВолныА503_1
                + "/" + OrderSchemeParameters.ПередачаПроверкаНаСебяУсловныйНомерСтволаА503_1;
            ПередачаПроверкаНаСебяА503_2.Text = OrderSchemeParameters.ПередачаПроверкаНаСебяУсловныйНомерВолныА503_2
                + "/" + OrderSchemeParameters.ПередачаПроверкаНаСебяУсловныйНомерСтволаА503_2;
            ПередачаПроверкаНаСебяА503_3.Text = OrderSchemeParameters.ПередачаПроверкаНаСебяУсловныйНомерВолныА503_3
                + "/" + OrderSchemeParameters.ПередачаПроверкаНаСебяУсловныйНомерСтволаА503_3;

            ПередачаПроверкаНаСебяИС3_1.Text = ПередачаПроверкаНаСебяА503_1.Text;
            ПередачаПроверкаНаСебяИС3_2.Text = ПередачаПроверкаНаСебяА503_2.Text;
            ПередачаПроверкаНаСебяИС3_3.Text = ПередачаПроверкаНаСебяА503_3.Text;

            ПриемВидМодуляции1.Text = "ОФТ-" + OrderSchemeParameters.ПриемВидМодуляцииСкорость1;

            ПриемУсловныйНомерВолны1.Text = OrderSchemeParameters.ПриемУсловныйНомерВолны1
                + "/" + OrderSchemeParameters.ПередачаПроверкаНаСебяУсловныйНомерСтволаА503_1;

            ПриемНомерПотока1.Text = OrderSchemeParameters.ПриемНомерПотока1.ToString();
        }
    }
}