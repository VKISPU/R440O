using System.Linq;

namespace R440O.R440OForms.B1_1
{
    using System.Windows.Forms;
    using BaseClasses;

    /// <summary>
    /// Форма блока Б1-1
    /// </summary>
    public partial class B1_1Form : Form, IRefreshableForm
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="B1_1Form"/>.
        /// </summary>
        public B1_1Form()
        {
            this.InitializeComponent();
            B1_1Parameters.ParameterChanged += RefreshFormElements;
            this.RefreshFormElements();
        }

        #region Кнопки

        private void КнопкаСкоростьГР_Click(object sender, System.EventArgs e)
        {
            B1_1Parameters.КнопкаСкоростьГР = !B1_1Parameters.КнопкаСкоростьГР;
        }

        private void КнопкаСкоростьАБ_1ТЛФ_К_Click(object sender, System.EventArgs e)
        {
            B1_1Parameters.КнопкаСкоростьАб1ТлфК = !B1_1Parameters.КнопкаСкоростьАб1ТлфК;
        }

        #endregion

        #region ТЛГпр1 Колодки
        private void КолодкаТЛГпр1_1_Click(object sender, System.EventArgs e)
        {
            if (B1_1Parameters.КолодкаТлГпр11)
            {
                B1_1Parameters.КолодкаТлГпр11 = false;
            }
            else
            {
                B1_1Parameters.КолодкаТлГпр11 = true;
                B1_1Parameters.КолодкаТлГпр12 = false;
            }
        }

        private void КолодкаТЛГпр1_2_Click(object sender, System.EventArgs e)
        {
            if (B1_1Parameters.КолодкаТлГпр12)
            {
                B1_1Parameters.КолодкаТлГпр12 = false;
            }
            else
            {
                B1_1Parameters.КолодкаТлГпр12 = true;
                B1_1Parameters.КолодкаТлГпр11 = false;
            }
        }
        #endregion

        #region ТЛГпр2 Колодки
        private void КолодкаТЛГпр2_1_Click(object sender, System.EventArgs e)
        {
            if (B1_1Parameters.КолодкаТлГпр21)
            {
                B1_1Parameters.КолодкаТлГпр21 = false;
            }
            else
            {
                B1_1Parameters.КолодкаТлГпр21 = true;
                B1_1Parameters.КолодкаТлГпр22 = false;
            }
        }
        private void КолодкаТЛГпр2_2_Click(object sender, System.EventArgs e)
        {
            if (B1_1Parameters.КолодкаТлГпр22)
            {
                B1_1Parameters.КолодкаТлГпр22 = false;
            }
            else
            {
                B1_1Parameters.КолодкаТлГпр22 = true;
                B1_1Parameters.КолодкаТлГпр21 = false;
            }
        }
        #endregion

        #region ТЛГпр3 Колодки
        private void КолодкаТЛГпр3_1_Click(object sender, System.EventArgs e)
        {
            if (B1_1Parameters.КолодкаТлГпр31)
            {
                B1_1Parameters.КолодкаТлГпр31 = false;
            }
            else
            {
                B1_1Parameters.КолодкаТлГпр31 = true;
                B1_1Parameters.КолодкаТлГпр32 = false;
            }
        }

        private void КолодкаТЛГпр3_2_Click(object sender, System.EventArgs e)
        {
            if (B1_1Parameters.КолодкаТлГпр32)
            {
                B1_1Parameters.КолодкаТлГпр32 = false;
            }
            else
            {
                B1_1Parameters.КолодкаТлГпр32 = true;
                B1_1Parameters.КолодкаТлГпр31 = false;
            }
        }
        #endregion

        /// <summary>
        /// Переключение тумблера управления питанием блока
        /// </summary>
        private void ТумблерМуДу_Click(object sender, System.EventArgs e)
        {
            B1_1Parameters.ТумблерМуДу = !B1_1Parameters.ТумблерМуДу;
        }

        public void RefreshFormElements()
        {
            foreach (Control itemIn in Panel.Controls)
            {
                var item = itemIn;
                if (!item.Name.Contains("Лампочка")) continue;
                var propertiesList = typeof(B1_1Parameters).GetProperties();
                foreach (var prop in propertiesList.Where(field => item.Name == field.Name))
                {
                    if (item.Name.Contains("ЛампочкаПУЛ_2") ||
                        item.Name.Contains("ЛампочкаТКБтк1_2") ||
                        item.Name.Contains("ЛампочкаТКБтк2_2") ||
                        item.Name.Contains("ЛампочкаТКБтк3_2") ||
                        item.Name.Contains("ЛампочкаВУП_1"))
                        item.BackgroundImage = (bool)prop.GetValue(null)
                            ? ControlElementImages.lampType3OnRed
                            : null;
                    else if (item.Name.Contains("ЛампочкаТЛГпр")) 
                        item.BackgroundImage = (bool)prop.GetValue(null)
                            ? ControlElementImages.lampType4OnRed
                            : null;
                    else
                        item.BackgroundImage = (bool)prop.GetValue(null)
                            ? ControlElementImages.lampType2OnRed
                            : null;
                    break;
                }
            }

            this.ТумблерМуДу.BackgroundImage = B1_1Parameters.ТумблерМуДу
                ? ControlElementImages.tumblerType4Up
                : ControlElementImages.tumblerType4Down;

            this.КнопкаСкоростьГР.BackgroundImage = B1_1Parameters.КнопкаСкоростьГР
                ? null
                : ControlElementImages.buttonRectType1;

            this.КнопкаСкоростьАБ_1ТЛФ_К.BackgroundImage = B1_1Parameters.КнопкаСкоростьАб1ТлфК
                ? null
                : ControlElementImages.buttonRectType1;

            if (B1_1Parameters.КолодкаТлГпр11)
            {
                this.КолодкаТЛГпр1_1.BackgroundImage = ControlElementImages.jumperType1;
                this.КолодкаТЛГпр1_2.Visible = false;
                this.КолодкаТЛГпр1_2.BackgroundImage = null;
            }
            else if (B1_1Parameters.КолодкаТлГпр12)
            {
                this.КолодкаТЛГпр1_2.BackgroundImage = ControlElementImages.jumperType1;
                this.КолодкаТЛГпр1_1.Visible = false;
                this.КолодкаТЛГпр1_1.BackgroundImage = null;
            }

            if (B1_1Parameters.КолодкаТлГпр21)
            {
                this.КолодкаТЛГпр2_1.BackgroundImage = ControlElementImages.jumperType1;
                this.КолодкаТЛГпр2_2.Visible = false;
                this.КолодкаТЛГпр2_2.BackgroundImage = null;
            }
            else if (B1_1Parameters.КолодкаТлГпр22)
            {
                this.КолодкаТЛГпр2_2.BackgroundImage = ControlElementImages.jumperType1;
                this.КолодкаТЛГпр2_1.Visible = false;
                this.КолодкаТЛГпр2_1.BackgroundImage = null;
            }

            if (B1_1Parameters.КолодкаТлГпр31)
            {
                this.КолодкаТЛГпр3_1.BackgroundImage = ControlElementImages.jumperType1;
                this.КолодкаТЛГпр3_2.Visible = false;
                this.КолодкаТЛГпр3_2.BackgroundImage = null;
            }
            else if (B1_1Parameters.КолодкаТлГпр32)
            {
                this.КолодкаТЛГпр3_2.BackgroundImage = ControlElementImages.jumperType1;
                this.КолодкаТЛГпр3_1.Visible = false;
                this.КолодкаТЛГпр3_1.BackgroundImage = null;
            }
        }
    }
}