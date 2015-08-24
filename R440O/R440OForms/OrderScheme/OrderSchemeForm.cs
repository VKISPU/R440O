using R440O.R440OForms.B3_2;

namespace R440O.R440OForms.OrderScheme
{
    using System.Windows.Forms;
    using C300M_1;
    using N15Inside;
    using N18_M;
    using B3_1;
    using N15;

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
            C300M_1Parameters.КнопкаВидРаботы = 8;
            N15Parameters.ТумблерА503Б = false;
            N15InsideParameters.ПереключательПУЛ4801 = 8;
            N18_MParameters.ПереключательВходБ22 = 1;
            N18_MParameters.ПереключательПРМ1 = 1;
            N18_MParameters.ПереключательПРМ2 = 1;
            N18_MParameters.Переключатель48ПрмЩв = 1;

            B3_1Parameters.КолодкаКРПР = 2;
            B3_1Parameters.КолодкаОКпр1Ас = true;
            B3_1Parameters.КолодкаУКК1 = 9;

            B3_2Parameters.КолодкаКРПР = 2;
            B3_2Parameters.КолодкаОКпр1Ас = true;
            B3_2Parameters.КолодкаУКК1 = 9;
        }

        private void InitializeParameters()
        {
            // Проверка на себя
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

            // Прием со спутника
            ПриемВидМодуляции1.Text = "ОФТ-" + OrderSchemeParameters.ПриемВидМодуляцииСкорость1;
            ПриемУсловныйНомерВолны1.Text = OrderSchemeParameters.ПриемУсловныйНомерВолны1
                + "/" + OrderSchemeParameters.ПриемУсловныйНомерСтвола1;

            ПриемНомерПотока1.Text = OrderSchemeParameters.ПриемНомерПотока1.ToString();
            ПриемНомерГруппы1.Text = OrderSchemeParameters.ПриемНомерГруппы1.ToString();
            ПриемНомерКаналаТЛФ.Text = OrderSchemeParameters.ПриемНомерКаналаТЛФ.ToString();
            ПриемНомерКаналаТЛГ.Text = OrderSchemeParameters.ПриемНомерКаналаТЛГ.ToString();
        }
    }
}