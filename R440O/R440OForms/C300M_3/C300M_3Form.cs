//-----------------------------------------------------------------------
// <copyright file="C300M_3Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.C300M_3
{
    using System.Windows.Forms;
    using Parameters;
    using ThirdParty;
    using System.Reflection;

    /// <summary>
    /// Форма блока С300М-1
    /// </summary>
    public partial class C300M_3Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="C300M_3Form"/>
        /// </summary>
        public C300M_3Form()
        {
            this.InitializeComponent();
            this.InitializeTogglesPosition();
            this.InitializeButtonsPosition();
            this.InitializeTumblersPosition();
        }

        #region Кнопки ВИД РАБОТЫ
        private void Ц300М_3КнопкаВидРаботы0d025_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_3КнопкаВидРаботы0d025.Visible = false;
            C300M_3Parameters.Ц300М_3КнопкаВидРаботы0d025 = "true";

            foreach (Control control in C300M_3Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_3КнопкаВидРаботы0d025")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_3Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_3КнопкаВидРаботы0d025")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_3КнопкаВидРаботы0d05_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_3КнопкаВидРаботы0d05.Visible = false;
            C300M_3Parameters.Ц300М_3КнопкаВидРаботы0d05 = "true";

            foreach (Control control in C300M_3Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_3КнопкаВидРаботы0d05")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_3Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_3КнопкаВидРаботы0d05")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_3КнопкаВидРаботы0d1_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_3КнопкаВидРаботы0d1.Visible = false;
            C300M_3Parameters.Ц300М_3КнопкаВидРаботы0d1 = "true";

            foreach (Control control in C300M_3Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_3КнопкаВидРаботы0d1")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_3Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_3КнопкаВидРаботы0d1")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_3КнопкаВидРаботы1d2_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_3КнопкаВидРаботы1d2.Visible = false;
            C300M_3Parameters.Ц300М_3КнопкаВидРаботы1d2 = "true";

            foreach (Control control in C300M_3Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_3КнопкаВидРаботы1d2")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_3Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_3КнопкаВидРаботы1d2")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_3КнопкаВидРаботы2d4_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_3КнопкаВидРаботы2d4.Visible = false;
            C300M_3Parameters.Ц300М_3КнопкаВидРаботы2d4 = "true";

            foreach (Control control in C300M_3Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_3КнопкаВидРаботы2d4")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_3Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_3КнопкаВидРаботы2d4")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_3КнопкаВидРаботы4d8_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_3КнопкаВидРаботы4d8.Visible = false;
            C300M_3Parameters.Ц300М_3КнопкаВидРаботы4d8 = "true";

            foreach (Control control in C300M_3Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_3КнопкаВидРаботы4d8")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_3Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_3КнопкаВидРаботы4d8")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_3КнопкаВидРаботы48_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_3КнопкаВидРаботы48.Visible = false;
            C300M_3Parameters.Ц300М_3КнопкаВидРаботы48 = "true";

            foreach (Control control in C300M_3Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_3КнопкаВидРаботы48")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_3Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_3КнопкаВидРаботы48")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_3КнопкаВидРаботы96144_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_3КнопкаВидРаботы96144.Visible = false;
            C300M_3Parameters.Ц300М_3КнопкаВидРаботы96144 = "true";

            foreach (Control control in C300M_3Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_3КнопкаВидРаботы96144")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_3Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_3КнопкаВидРаботы96144")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_3КнопкаВидРаботы240_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_3КнопкаВидРаботы240.Visible = false;
            C300M_3Parameters.Ц300М_3КнопкаВидРаботы240 = "true";

            foreach (Control control in C300M_3Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_3КнопкаВидРаботы240")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_3Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_3КнопкаВидРаботы240")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_3КнопкаВидРаботы480_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_3КнопкаВидРаботы480.Visible = false;
            C300M_3Parameters.Ц300М_3КнопкаВидРаботы480 = "true";

            foreach (Control control in C300M_3Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_3КнопкаВидРаботы480")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_3Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_3КнопкаВидРаботы480")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_3КнопкаВидРаботыСброс_MouseDown(object sender, MouseEventArgs e)
        {
            this.Ц300М_3КнопкаВидРаботыСброс.BackgroundImage = null;
            this.Ц300М_3КнопкаВидРаботыСброс.Text = "";
            C300M_3Parameters.Ц300М_3КнопкаВидРаботыСброс = "true";

            foreach (Control control in C300M_3Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы"))
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_3Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы"))
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_3КнопкаВидРаботыСброс_MouseUp(object sender, MouseEventArgs e)
        {
            this.Ц300М_3КнопкаВидРаботыСброс.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.Ц300М_3КнопкаВидРаботыСброс.Text = "Сброс";
            C300M_3Parameters.Ц300М_3КнопкаВидРаботыСброс = "false";
        }
        #endregion

        #region Кнопки КОНТРОЛЬ РЕЖИМА
        private void Ц300М_3КнопкаКонтрольРежимаУрСигн_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_3КнопкаКонтрольРежимаУрСигн.Visible = false;
            C300M_3Parameters.Ц300М_3КнопкаКонтрольРежимаУрСигн = "true";

            foreach (Control control in C300M_3Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_3КнопкаКонтрольРежимаУрСигн")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_3Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_3КнопкаКонтрольРежимаУрСигн")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_3КнопкаКонтрольРежимаУрШума_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_3КнопкаКонтрольРежимаУрШума.Visible = false;
            C300M_3Parameters.Ц300М_3КнопкаКонтрольРежимаУрШума = "true";

            foreach (Control control in C300M_3Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_3КнопкаКонтрольРежимаУрШума")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_3Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_3КнопкаКонтрольРежимаУрШума")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_3КнопкаКонтрольРежима0АПЧ_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_3КнопкаКонтрольРежима0АПЧ.Visible = false;
            C300M_3Parameters.Ц300М_3КнопкаКонтрольРежима0АПЧ = "true";

            foreach (Control control in C300M_3Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_3КнопкаКонтрольРежима0АПЧ")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_3Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_3КнопкаКонтрольРежима0АПЧ")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_3КнопкаКонтрольРежимаПоиск_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_3КнопкаКонтрольРежимаПоиск.Visible = false;
            C300M_3Parameters.Ц300М_3КнопкаКонтрольРежимаПоиск = "true";

            foreach (Control control in C300M_3Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_3КнопкаКонтрольРежимаПоиск")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_3Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_3КнопкаКонтрольРежимаПоиск")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_3КнопкаКонтрольРежимаГЕТ_2_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_3КнопкаКонтрольРежимаГЕТ_2.Visible = false;
            C300M_3Parameters.Ц300М_3КнопкаКонтрольРежимаГЕТ_2 = "true";

            foreach (Control control in C300M_3Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_3КнопкаКонтрольРежимаГЕТ_2")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_3Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_3КнопкаКонтрольРежимаГЕТ_2")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_3КнопкаКонтрольРежимаПлюс5_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_3КнопкаКонтрольРежимаПлюс5.Visible = false;
            C300M_3Parameters.Ц300М_3КнопкаКонтрольРежимаПлюс5 = "true";

            foreach (Control control in C300M_3Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_3КнопкаКонтрольРежимаПлюс5")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_3Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_3КнопкаКонтрольРежимаПлюс5")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_3КнопкаКонтрольРежимаПлюс6d3_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_3КнопкаКонтрольРежимаПлюс6d3.Visible = false;
            C300M_3Parameters.Ц300М_3КнопкаКонтрольРежимаПлюс6d3 = "true";

            foreach (Control control in C300M_3Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_3КнопкаКонтрольРежимаПлюс6d3")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_3Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_3КнопкаКонтрольРежимаПлюс6d3")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_3КнопкаКонтрольРежимаПлюс27_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_3КнопкаКонтрольРежимаПлюс27.Visible = false;
            C300M_3Parameters.Ц300М_3КнопкаКонтрольРежимаПлюс27 = "true";

            foreach (Control control in C300M_3Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_3КнопкаКонтрольРежимаПлюс27")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_3Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_3КнопкаКонтрольРежимаПлюс27")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_3КнопкаКонтрольРежимаМинус5_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_3КнопкаКонтрольРежимаМинус5.Visible = false;
            C300M_3Parameters.Ц300М_3КнопкаКонтрольРежимаМинус5 = "true";

            foreach (Control control in C300M_3Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_3КнопкаКонтрольРежимаМинус5")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_3Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_3КнопкаКонтрольРежимаМинус5")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_3КнопкаКонтрольРежимаМинус12d8_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_3КнопкаКонтрольРежимаМинус12d8.Visible = false;
            C300M_3Parameters.Ц300М_3КнопкаКонтрольРежимаМинус12d8 = "true";

            foreach (Control control in C300M_3Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_3КнопкаКонтрольРежимаМинус12d8")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_3Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_3КнопкаКонтрольРежимаМинус12d8")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_3КнопкаКонтрольРежимаМинус27_MouseDown(object sender, MouseEventArgs e)
        {
            this.Ц300М_3КнопкаКонтрольРежимаМинус27.BackgroundImage = null;
            this.Ц300М_3КнопкаКонтрольРежимаМинус27.Text = "";
            C300M_3Parameters.Ц300М_3КнопкаКонтрольРежимаМинус27 = "true";

            foreach (Control control in C300M_3Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_3КнопкаКонтрольРежимаМинус27")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_3Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_3КнопкаКонтрольРежимаМинус27")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_3КнопкаКонтрольРежимаМинус27_MouseUp(object sender, MouseEventArgs e)
        {
            this.Ц300М_3КнопкаКонтрольРежимаМинус27.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.Ц300М_3КнопкаКонтрольРежимаМинус27.Text = "-27";
            C300M_3Parameters.Ц300М_3КнопкаКонтрольРежимаМинус27 = "false";
        }
        #endregion

        #region Кнопка Индикация волны
        private void Ц300М_3КнопкаИндикацияВолны_MouseDown(object sender, MouseEventArgs e)
        {
            this.Ц300М_3КнопкаИндикацияВолны.BackgroundImage = null;
            C300M_3Parameters.Ц300М_3КнопкаИндикацияВолны = "true";
            Ц300М_3ИндикаторВолна1000.Text = System.Convert.ToString(C300M_3Parameters.Ц300М_3ПереключательВолна1000);
            Ц300М_3ИндикаторВолна1000.Visible = true;
            Ц300М_3ИндикаторВолна100.Text = System.Convert.ToString(C300M_3Parameters.Ц300М_3ПереключательВолна100);
            Ц300М_3ИндикаторВолна100.Visible = true;
            Ц300М_3ИндикаторВолна10.Text = System.Convert.ToString(C300M_3Parameters.Ц300М_3ПереключательВолна10);
            Ц300М_3ИндикаторВолна10.Visible = true;
            Ц300М_3ИндикаторВолна1.Text = System.Convert.ToString(C300M_3Parameters.Ц300М_3ПереключательВолна1);
            Ц300М_3ИндикаторВолна1.Visible = true;
        }

        private void Ц300М_3КнопкаИндикацияВолны_MouseUp(object sender, MouseEventArgs e)
        {
            this.Ц300М_3КнопкаИндикацияВолны.BackgroundImage = ControlElementImages.buttonSquareWhite;
            C300M_3Parameters.Ц300М_3КнопкаИндикацияВолны = "false";
            Ц300М_3ИндикаторВолна1000.Visible = false;
            Ц300М_3ИндикаторВолна100.Visible = false;
            Ц300М_3ИндикаторВолна10.Visible = false;
            Ц300М_3ИндикаторВолна1.Visible = false;
        }
        #endregion

        #region Переключатели Волна
        private void Ц300М_3ПереключательВолна1000_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                C300M_3Parameters.Ц300М_3ПереключательВолна1000 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                C300M_3Parameters.Ц300М_3ПереключательВолна1000 -= 1;
            }

            var angle = C300M_3Parameters.Ц300М_3ПереключательВолна1000 * 30 - 135;
            Ц300М_3ПереключательВолна1000.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
        }

        private void Ц300М_3ПереключательВолна100_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                C300M_3Parameters.Ц300М_3ПереключательВолна100 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                C300M_3Parameters.Ц300М_3ПереключательВолна100 -= 1;
            }

            var angle = C300M_3Parameters.Ц300М_3ПереключательВолна100 * 30 - 135;
            Ц300М_3ПереключательВолна100.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
        }

        private void Ц300М_3ПереключательВолна10_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                C300M_3Parameters.Ц300М_3ПереключательВолна10 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                C300M_3Parameters.Ц300М_3ПереключательВолна10 -= 1;
            }

            var angle = C300M_3Parameters.Ц300М_3ПереключательВолна10 * 30 - 135;
            Ц300М_3ПереключательВолна10.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
        }

        private void Ц300М_3ПереключательВолна1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                C300M_3Parameters.Ц300М_3ПереключательВолна1 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                C300M_3Parameters.Ц300М_3ПереключательВолна1 -= 1;
            }

            var angle = C300M_3Parameters.Ц300М_3ПереключательВолна1 * 30 - 135;
            Ц300М_3ПереключательВолна1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
        }
        #endregion

        #region Установка органов управления в положение их последней настройки
        /// <summary>
        /// Установка переключателей в положение последней их установки
        /// </summary>
        private void InitializeTogglesPosition()
        {
            foreach (Control item in C300M_3Panel.Controls)
            {
                if (item.Name.Contains("Переключатель"))
                {
                    PropertyInfo[] fieldList = typeof(C300M_3Parameters).GetProperties();
                    foreach (PropertyInfo property in fieldList)
                    {
                        if (item.Name == property.Name)
                        {
                            var angle = System.Convert.ToInt32(property.GetValue(null)) * 30 - 135;
                            item.BackgroundImage = TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Установка кнопок в положение последней их установки
        /// </summary>
        private void InitializeButtonsPosition()
        {
            foreach (Control item in C300M_3Panel.Controls)
            {
                if (item.Name.Contains("Кнопка"))
                {
                    PropertyInfo[] fieldList = typeof(C300M_3Parameters).GetProperties();
                    foreach (PropertyInfo property in fieldList)
                    {
                        if (item.Name == property.Name)
                        {
                            string value = System.Convert.ToString(property.GetValue(null));
                            item.Visible = (value != "true") ? true : false;
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Установка тумблеров в положение последней их установки
        /// </summary>
        private void InitializeTumblersPosition()
        {
            this.Ц300М_3ТумблерВведениеЧТОФТ.BackgroundImage = C300M_3Parameters.Ц300М_3ТумблерВведениеЧТОФТ == "ЧТ"
                ? ControlElementImages.tumblerType3Up
                : ControlElementImages.tumblerType3Down;

            this.Ц300М_3ТумблерПоискБлокировкаВклОткл.BackgroundImage = C300M_3Parameters.Ц300М_3ТумблерПоискБлокировкаВклОткл == "Вкл"
                ? ControlElementImages.tumblerType3Up
                : ControlElementImages.tumblerType3Down;

            this.Ц300М_3ТумблерПоискВид_ВклАвтоматичРучн.BackgroundImage = C300M_3Parameters.Ц300М_3ТумблерПоискВид_ВклАвтоматичРучн == "Автоматич"
                ? ControlElementImages.tumblerType3Up
                : ControlElementImages.tumblerType3Down;

            this.Ц300М_3ТумблерПоискС_АналСимметрОткл.BackgroundImage = C300M_3Parameters.Ц300М_3ТумблерПоискС_АналСимметрОткл == "Симметр"
                ? ControlElementImages.tumblerType3Up
                : ControlElementImages.tumblerType3Down;

            this.Ц300М_3ТумблерАСЧОткл.BackgroundImage = C300M_3Parameters.Ц300М_3ТумблерАСЧОткл == "АСЧ"
                ? ControlElementImages.tumblerType3Up
                : ControlElementImages.tumblerType3Down;

            this.Ц300М_3ТумблерАРУРРУ.BackgroundImage = C300M_3Parameters.Ц300М_3ТумблерАРУРРУ == "АРУ"
                ? ControlElementImages.tumblerType3Up
                : ControlElementImages.tumblerType3Down;

            this.Ц300М_3ТумблерЧТОФТ.BackgroundImage = C300M_3Parameters.Ц300М_3ТумблерЧТОФТ == "ЧТ"
                ? ControlElementImages.tumblerType3Up
                : ControlElementImages.tumblerType3Down;

            this.Ц300М_3ТумблерПоискПределы.BackgroundImage = C300M_3Parameters.Ц300М_3ТумблерПоискПределы == "300"
                ? ControlElementImages.tumblerType3Left
                : ControlElementImages.tumblerType3Right;

        }
        #endregion

        #region Тумблеры
        private void Ц300М_3ТумблерВведениеЧТОФТ_Click(object sender, System.EventArgs e)
        {
            if (C300M_3Parameters.Ц300М_3ТумблерВведениеЧТОФТ == "ЧТ")
            {
                this.Ц300М_3ТумблерВведениеЧТОФТ.BackgroundImage = ControlElementImages.tumblerType3Down;
                C300M_3Parameters.Ц300М_3ТумблерВведениеЧТОФТ = "ОФТ";
            }
            else
            {
                this.Ц300М_3ТумблерВведениеЧТОФТ.BackgroundImage = ControlElementImages.tumblerType3Up;
                C300M_3Parameters.Ц300М_3ТумблерВведениеЧТОФТ = "ЧТ";
            }
        }

        private void Ц300М_3ТумблерПоискБлокировкаВклОткл_Click(object sender, System.EventArgs e)
        {
            if (C300M_3Parameters.Ц300М_3ТумблерПоискБлокировкаВклОткл == "Вкл")
            {
                this.Ц300М_3ТумблерПоискБлокировкаВклОткл.BackgroundImage = ControlElementImages.tumblerType3Down;
                C300M_3Parameters.Ц300М_3ТумблерПоискБлокировкаВклОткл = "Откл";
            }
            else
            {
                this.Ц300М_3ТумблерПоискБлокировкаВклОткл.BackgroundImage = ControlElementImages.tumblerType3Up;
                C300M_3Parameters.Ц300М_3ТумблерПоискБлокировкаВклОткл = "Вкл";
            }
        }

        private void Ц300М_3ТумблерПоискВид_ВклАвтоматичРучн_Click(object sender, System.EventArgs e)
        {
            if (C300M_3Parameters.Ц300М_3ТумблерПоискВид_ВклАвтоматичРучн == "Автоматич")
            {
                this.Ц300М_3ТумблерПоискВид_ВклАвтоматичРучн.BackgroundImage = ControlElementImages.tumblerType3Down;
                C300M_3Parameters.Ц300М_3ТумблерПоискВид_ВклАвтоматичРучн = "Ручн";
            }
            else
            {
                this.Ц300М_3ТумблерПоискВид_ВклАвтоматичРучн.BackgroundImage = ControlElementImages.tumblerType3Up;
                C300M_3Parameters.Ц300М_3ТумблерПоискВид_ВклАвтоматичРучн = "Автоматич";
            }
        }

        private void Ц300М_3ТумблерПоискС_АналСимметрОткл_Click(object sender, System.EventArgs e)
        {
            if (C300M_3Parameters.Ц300М_3ТумблерПоискС_АналСимметрОткл == "Симметр")
            {
                this.Ц300М_3ТумблерПоискС_АналСимметрОткл.BackgroundImage = ControlElementImages.tumblerType3Down;
                C300M_3Parameters.Ц300М_3ТумблерПоискС_АналСимметрОткл = "Откл";
            }
            else
            {
                this.Ц300М_3ТумблерПоискС_АналСимметрОткл.BackgroundImage = ControlElementImages.tumblerType3Up;
                C300M_3Parameters.Ц300М_3ТумблерПоискС_АналСимметрОткл = "Симметр";
            }
        }

        private void Ц300М_3ТумблерАСЧОткл_Click(object sender, System.EventArgs e)
        {
            if (C300M_3Parameters.Ц300М_3ТумблерАСЧОткл == "АСЧ")
            {
                this.Ц300М_3ТумблерАСЧОткл.BackgroundImage = ControlElementImages.tumblerType3Down;
                C300M_3Parameters.Ц300М_3ТумблерАСЧОткл = "Откл";
            }
            else
            {
                this.Ц300М_3ТумблерАСЧОткл.BackgroundImage = ControlElementImages.tumblerType3Up;
                C300M_3Parameters.Ц300М_3ТумблерАСЧОткл = "АСЧ";
            }
        }

        private void Ц300М_3ТумблерАРУРРУ_Click(object sender, System.EventArgs e)
        {
            if (C300M_3Parameters.Ц300М_3ТумблерАРУРРУ == "АРУ")
            {
                this.Ц300М_3ТумблерАРУРРУ.BackgroundImage = ControlElementImages.tumblerType3Down;
                C300M_3Parameters.Ц300М_3ТумблерАРУРРУ = "РРУ";
            }
            else
            {
                this.Ц300М_3ТумблерАРУРРУ.BackgroundImage = ControlElementImages.tumblerType3Up;
                C300M_3Parameters.Ц300М_3ТумблерАРУРРУ = "АРУ";
            }
        }

        private void Ц300М_3ТумблерЧТОФТ_Click(object sender, System.EventArgs e)
        {
            if (C300M_3Parameters.Ц300М_3ТумблерЧТОФТ == "ЧТ")
            {
                this.Ц300М_3ТумблерЧТОФТ.BackgroundImage = ControlElementImages.tumblerType3Down;
                C300M_3Parameters.Ц300М_3ТумблерЧТОФТ = "ОФТ";
            }
            else
            {
                this.Ц300М_3ТумблерЧТОФТ.BackgroundImage = ControlElementImages.tumblerType3Up;
                C300M_3Parameters.Ц300М_3ТумблерЧТОФТ = "ЧТ";
            }
        }

        private void Ц300М_3ТумблерПоискПределы_Click(object sender, System.EventArgs e)
        {
            if (C300M_3Parameters.Ц300М_3ТумблерПоискПределы == "300")
            {
                this.Ц300М_3ТумблерПоискПределы.BackgroundImage = ControlElementImages.tumblerType3Right;
                C300M_3Parameters.Ц300М_3ТумблерПоискПределы = "60";
            }
            else
            {
                this.Ц300М_3ТумблерПоискПределы.BackgroundImage = ControlElementImages.tumblerType3Left;
                C300M_3Parameters.Ц300М_3ТумблерПоискПределы = "300";
            }
        }
        #endregion

        #region Кнопки ПИТАНИЕ
        private void Ц300М_3КнопкаПитаниеВкл_MouseDown(object sender, MouseEventArgs e)
        {
            Ц300М_3КнопкаПитаниеВкл.BackgroundImage = null;
            Ц300М_3КнопкаПитаниеВкл.Text = "";
            C300M_3Parameters.Ц300М_3КнопкаПитаниеВкл = "true";
        }

        private void Ц300М_3КнопкаПитаниеВкл_MouseUp(object sender, MouseEventArgs e)
        {
            Ц300М_3КнопкаПитаниеВкл.BackgroundImage = ControlElementImages.buttonSquareWhite;
            Ц300М_3КнопкаПитаниеВкл.Text = "ВКЛ";
            C300M_3Parameters.Ц300М_3КнопкаПитаниеВкл = "false";
        }

        private void Ц300М_3КнопкаПитаниеВыкл_MouseDown(object sender, MouseEventArgs e)
        {
            Ц300М_3КнопкаПитаниеВыкл.BackgroundImage = null;
            Ц300М_3КнопкаПитаниеВыкл.Text = "";
            C300M_3Parameters.Ц300М_3КнопкаПитаниеВыкл = "true";
        }

        private void Ц300М_3КнопкаПитаниеВыкл_MouseUp(object sender, MouseEventArgs e)
        {
            Ц300М_3КнопкаПитаниеВыкл.BackgroundImage = ControlElementImages.buttonSquareWhite;
            Ц300М_3КнопкаПитаниеВыкл.Text = "ОТКЛ";
            C300M_3Parameters.Ц300М_3КнопкаПитаниеВыкл = "false";
        }
        #endregion

        #region Кнопка ПОИСК
        private void Ц300М_3КнопкаПоискВкл_MouseDown(object sender, MouseEventArgs e)
        {
            Ц300М_3КнопкаПоискВкл.BackgroundImage = null;
            Ц300М_3КнопкаПоискВкл.Text = "";
            C300M_3Parameters.Ц300М_3КнопкаПоискВкл = "true";
        }
        #endregion

        private void Ц300М_3КнопкаПоискВкл_MouseUp(object sender, MouseEventArgs e)
        {
            Ц300М_3КнопкаПоискВкл.BackgroundImage = ControlElementImages.buttonSquareWhite;
            Ц300М_3КнопкаПоискВкл.Text = "ВКЛ";
            C300M_3Parameters.Ц300М_3КнопкаПоискВкл = "false";
        }
    }
}