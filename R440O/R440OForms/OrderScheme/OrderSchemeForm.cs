namespace R440O.R440OForms.OrderScheme
{
    using System.Windows.Forms;
    using C300M_1;
    using N15Inside;
    using N18_M;

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
            CorrectStation();
        }

        /// <summary>
        /// Поправление настроек станции в соответствии с настройками корреспондента
        /// </summary>
        private void CorrectStation()
        {
            C300M_1Parameters.КнопкиВидРаботы[9] = true;
            N15InsideParameters.ПереключательПУЛ4801 = 9;
            N18_MParameters.ПереключательВходБ22 = 1;
            N18_MParameters.ПереключательПРМ1 = 1;
            N18_MParameters.ПереключательПРМ2 = 1;
            N18_MParameters.Переключатель48ПрмЩв = 1;
        }

        private void InitializeParameters()
        {
            ПередачаУсловныйНомерВолны1.Text = OrderSchemeParameters.ПередачаУсловныйНомерВолны1.ToString();
            ПередачаУсловныйНомерВолны2.Text = OrderSchemeParameters.ПередачаУсловныйНомерВолны2.ToString();
            ПередачаУсловныйНомерВолны3.Text = OrderSchemeParameters.ПередачаУсловныйНомерВолны3.ToString();

            ПередачаПроверкаНаСебяА503_1.Text = OrderSchemeParameters.ПередачаПроверкаНаСебяУсловныйНомерВолныА5031
                + "/" + OrderSchemeParameters.ПередачаПроверкаНаСебяУсловныйНомерСтволаА5031;
            ПередачаПроверкаНаСебяА503_2.Text = OrderSchemeParameters.ПередачаПроверкаНаСебяУсловныйНомерВолныА5032
                + "/" + OrderSchemeParameters.ПередачаПроверкаНаСебяУсловныйНомерСтволаА5032;
            ПередачаПроверкаНаСебяА503_3.Text = OrderSchemeParameters.ПередачаПроверкаНаСебяУсловныйНомерВолныА5033
                + "/" + OrderSchemeParameters.ПередачаПроверкаНаСебяУсловныйНомерСтволаА5033;

            ПередачаПроверкаНаСебяИС3_1.Text = ПередачаПроверкаНаСебяА503_1.Text;
            ПередачаПроверкаНаСебяИС3_2.Text = ПередачаПроверкаНаСебяА503_2.Text;
            ПередачаПроверкаНаСебяИС3_3.Text = ПередачаПроверкаНаСебяА503_3.Text;

            ПриемВидМодуляции1.Text = "ОФТ-" + OrderSchemeParameters.ПриемВидМодуляцииСкорость1;

            ПриемУсловныйНомерВолны1.Text = OrderSchemeParameters.ПриемУсловныйНомерВолны1
                + "/" + OrderSchemeParameters.ПриемУсловныйНомерСтвола1;

            ПриемНомерПотока1.Text = OrderSchemeParameters.ПриемНомерПотока1.ToString();
        }
    }
}