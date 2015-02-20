//-----------------------------------------------------------------------
// <copyright file="C300M_1Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.C300M_1
{
    using System.Windows.Forms;
    using Parameters;
    using ThirdParty;
    using System.Reflection;

    /// <summary>
    /// Форма блока С300М-1
    /// </summary>
    public partial class C300M_1Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="C300M_1Form"/>
        /// </summary>
        public C300M_1Form()
        {
            this.InitializeComponent();
            this.InitializeTogglesPosition();
            this.InitializeButtonsPosition();
            this.InitializeTumblersPosition();
        }

        #region Кнопки ВИД РАБОТЫ
        private void Ц300М_1КнопкаВидРаботы0d025_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаВидРаботы0d025.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d025 = "true";

            foreach (Control control in C300M_1Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_1КнопкаВидРаботы0d025")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_1Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_1КнопкаВидРаботы0d025")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_1КнопкаВидРаботы0d05_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаВидРаботы0d05.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d05 = "true";

            foreach (Control control in C300M_1Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_1КнопкаВидРаботы0d05")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_1Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_1КнопкаВидРаботы0d05")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_1КнопкаВидРаботы0d1_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаВидРаботы0d1.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы0d1 = "true";

            foreach (Control control in C300M_1Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_1КнопкаВидРаботы0d1")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_1Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_1КнопкаВидРаботы0d1")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_1КнопкаВидРаботы1d2_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаВидРаботы1d2.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы1d2 = "true";

            foreach (Control control in C300M_1Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_1КнопкаВидРаботы1d2")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_1Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_1КнопкаВидРаботы1d2")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_1КнопкаВидРаботы2d4_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаВидРаботы2d4.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы2d4 = "true";

            foreach (Control control in C300M_1Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_1КнопкаВидРаботы2d4")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_1Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_1КнопкаВидРаботы2d4")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_1КнопкаВидРаботы4d8_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаВидРаботы4d8.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы4d8 = "true";

            foreach (Control control in C300M_1Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_1КнопкаВидРаботы4d8")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_1Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_1КнопкаВидРаботы4d8")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_1КнопкаВидРаботы48_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаВидРаботы48.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы48 = "true";

            foreach (Control control in C300M_1Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_1КнопкаВидРаботы48")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_1Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_1КнопкаВидРаботы48")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_1КнопкаВидРаботы96144_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаВидРаботы96144.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы96144 = "true";

            foreach (Control control in C300M_1Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_1КнопкаВидРаботы96144")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_1Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_1КнопкаВидРаботы96144")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_1КнопкаВидРаботы240_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаВидРаботы240.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы240 = "true";

            foreach (Control control in C300M_1Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_1КнопкаВидРаботы240")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_1Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_1КнопкаВидРаботы240")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_1КнопкаВидРаботы480_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаВидРаботы480.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаВидРаботы480 = "true";

            foreach (Control control in C300M_1Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_1КнопкаВидРаботы480")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_1Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_1КнопкаВидРаботы480")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_1КнопкаВидРаботыСброс_MouseDown(object sender, MouseEventArgs e)
        {
            this.Ц300М_1КнопкаВидРаботыСброс.BackgroundImage = null;
            this.Ц300М_1КнопкаВидРаботыСброс.Text = "";
            C300M_1Parameters.Ц300М_1КнопкаВидРаботыСброс = "true";

            foreach (Control control in C300M_1Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы"))
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_1Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы"))
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_1КнопкаВидРаботыСброс_MouseUp(object sender, MouseEventArgs e)
        {
            this.Ц300М_1КнопкаВидРаботыСброс.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.Ц300М_1КнопкаВидРаботыСброс.Text = "Сброс";
            C300M_1Parameters.Ц300М_1КнопкаВидРаботыСброс = "false";
        }
        #endregion

        #region Кнопки КОНТРОЛЬ РЕЖИМА
        private void Ц300М_1КнопкаКонтрольРежимаУрСигн_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаКонтрольРежимаУрСигн.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаУрСигн = "true";

            foreach (Control control in C300M_1Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_1КнопкаКонтрольРежимаУрСигн")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_1Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_1КнопкаКонтрольРежимаУрСигн")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_1КнопкаКонтрольРежимаУрШума_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаКонтрольРежимаУрШума.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаУрШума = "true";

            foreach (Control control in C300M_1Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_1КнопкаКонтрольРежимаУрШума")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_1Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_1КнопкаКонтрольРежимаУрШума")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_1КнопкаКонтрольРежима0АПЧ_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаКонтрольРежима0АПЧ.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежима0АПЧ = "true";

            foreach (Control control in C300M_1Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_1КнопкаКонтрольРежима0АПЧ")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_1Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_1КнопкаКонтрольРежима0АПЧ")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_1КнопкаКонтрольРежимаПоиск_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаКонтрольРежимаПоиск.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПоиск = "true";

            foreach (Control control in C300M_1Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_1КнопкаКонтрольРежимаПоиск")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_1Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_1КнопкаКонтрольРежимаПоиск")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_1КнопкаКонтрольРежимаГЕТ_2_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаКонтрольРежимаГЕТ_2.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаГЕТ_2 = "true";

            foreach (Control control in C300M_1Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_1КнопкаКонтрольРежимаГЕТ_2")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_1Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_1КнопкаКонтрольРежимаГЕТ_2")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_1КнопкаКонтрольРежимаПлюс5_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаКонтрольРежимаПлюс5.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс5 = "true";

            foreach (Control control in C300M_1Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_1КнопкаКонтрольРежимаПлюс5")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_1Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_1КнопкаКонтрольРежимаПлюс5")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_1КнопкаКонтрольРежимаПлюс6d3_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаКонтрольРежимаПлюс6d3.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс6d3 = "true";

            foreach (Control control in C300M_1Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_1КнопкаКонтрольРежимаПлюс6d3")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_1Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_1КнопкаКонтрольРежимаПлюс6d3")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_1КнопкаКонтрольРежимаПлюс27_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаКонтрольРежимаПлюс27.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаПлюс27 = "true";

            foreach (Control control in C300M_1Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_1КнопкаКонтрольРежимаПлюс27")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_1Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_1КнопкаКонтрольРежимаПлюс27")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_1КнопкаКонтрольРежимаМинус5_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаКонтрольРежимаМинус5.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус5 = "true";

            foreach (Control control in C300M_1Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_1КнопкаКонтрольРежимаМинус5")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_1Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_1КнопкаКонтрольРежимаМинус5")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_1КнопкаКонтрольРежимаМинус12d8_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_1КнопкаКонтрольРежимаМинус12d8.Visible = false;
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус12d8 = "true";

            foreach (Control control in C300M_1Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_1КнопкаКонтрольРежимаМинус12d8")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_1Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_1КнопкаКонтрольРежимаМинус12d8")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_1КнопкаКонтрольРежимаМинус27_MouseDown(object sender, MouseEventArgs e)
        {
            this.Ц300М_1КнопкаКонтрольРежимаМинус27.BackgroundImage = null;
            this.Ц300М_1КнопкаКонтрольРежимаМинус27.Text = "";
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус27 = "true";

            foreach (Control control in C300M_1Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_1КнопкаКонтрольРежимаМинус27")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_1Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_1КнопкаКонтрольРежимаМинус27")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_1КнопкаКонтрольРежимаМинус27_MouseUp(object sender, MouseEventArgs e)
        {
            this.Ц300М_1КнопкаКонтрольРежимаМинус27.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.Ц300М_1КнопкаКонтрольРежимаМинус27.Text = "-27";
            C300M_1Parameters.Ц300М_1КнопкаКонтрольРежимаМинус27 = "false";
        }
        #endregion

        #region Кнопка Индикация волны
        private void Ц300М_1КнопкаИндикацияВолны_MouseDown(object sender, MouseEventArgs e)
        {
            this.Ц300М_1КнопкаИндикацияВолны.BackgroundImage = null;
            C300M_1Parameters.Ц300М_1КнопкаИндикацияВолны = "true";
            Ц300М_1ИндикаторВолна1000.Text = System.Convert.ToString(C300M_1Parameters.Ц300М_1ПереключательВолна1000);
            Ц300М_1ИндикаторВолна1000.Visible = true;
            Ц300М_1ИндикаторВолна100.Text = System.Convert.ToString(C300M_1Parameters.Ц300М_1ПереключательВолна100);
            Ц300М_1ИндикаторВолна100.Visible = true;
            Ц300М_1ИндикаторВолна10.Text = System.Convert.ToString(C300M_1Parameters.Ц300М_1ПереключательВолна10);
            Ц300М_1ИндикаторВолна10.Visible = true;
            Ц300М_1ИндикаторВолна1.Text = System.Convert.ToString(C300M_1Parameters.Ц300М_1ПереключательВолна1);
            Ц300М_1ИндикаторВолна1.Visible = true;
        }

        private void Ц300М_1КнопкаИндикацияВолны_MouseUp(object sender, MouseEventArgs e)
        {
            this.Ц300М_1КнопкаИндикацияВолны.BackgroundImage = ControlElementImages.buttonSquareWhite;
            C300M_1Parameters.Ц300М_1КнопкаИндикацияВолны = "false";
            Ц300М_1ИндикаторВолна1000.Visible = false;
            Ц300М_1ИндикаторВолна100.Visible = false;
            Ц300М_1ИндикаторВолна10.Visible = false;
            Ц300М_1ИндикаторВолна1.Visible = false;
        }
        #endregion

        #region Переключатели Волна
        private void Ц300М_1ПереключательВолна1000_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                C300M_1Parameters.Ц300М_1ПереключательВолна1000 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                C300M_1Parameters.Ц300М_1ПереключательВолна1000 -= 1;
            }

            var angle = C300M_1Parameters.Ц300М_1ПереключательВолна1000 * 30 - 135;
            Ц300М_1ПереключательВолна1000.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
        }

        private void Ц300М_1ПереключательВолна100_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                C300M_1Parameters.Ц300М_1ПереключательВолна100 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                C300M_1Parameters.Ц300М_1ПереключательВолна100 -= 1;
            }

            var angle = C300M_1Parameters.Ц300М_1ПереключательВолна100 * 30 - 135;
            Ц300М_1ПереключательВолна100.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
        }

        private void Ц300М_1ПереключательВолна10_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                C300M_1Parameters.Ц300М_1ПереключательВолна10 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                C300M_1Parameters.Ц300М_1ПереключательВолна10 -= 1;
            }

            var angle = C300M_1Parameters.Ц300М_1ПереключательВолна10 * 30 - 135;
            Ц300М_1ПереключательВолна10.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
        }

        private void Ц300М_1ПереключательВолна1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                C300M_1Parameters.Ц300М_1ПереключательВолна1 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                C300M_1Parameters.Ц300М_1ПереключательВолна1 -= 1;
            }

            var angle = C300M_1Parameters.Ц300М_1ПереключательВолна1 * 30 - 135;
            Ц300М_1ПереключательВолна1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
        }
        #endregion

        #region Установка органов управления в положение их последней настройки
        /// <summary>
        /// Установка переключателей в положение последней их установки
        /// </summary>
        private void InitializeTogglesPosition()
        {
            foreach (Control item in C300M_1Panel.Controls)
            {
                if (item.Name.Contains("Переключатель"))
                {
                    PropertyInfo[] fieldList = typeof(C300M_1Parameters).GetProperties();
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
            foreach (Control item in C300M_1Panel.Controls)
            {
                if (item.Name.Contains("Кнопка"))
                {
                    PropertyInfo[] fieldList = typeof(C300M_1Parameters).GetProperties();
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
            this.Ц300М_1ТумблерВведениеЧТОФТ.BackgroundImage = C300M_1Parameters.Ц300М_1ТумблерВведениеЧТОФТ == "ЧТ"
                ? ControlElementImages.tumblerType3Up
                : ControlElementImages.tumblerType3Down;

            this.Ц300М_1ТумблерПоискБлокировкаВклОткл.BackgroundImage = C300M_1Parameters.Ц300М_1ТумблерПоискБлокировкаВклОткл == "Вкл"
                ? ControlElementImages.tumblerType3Up
                : ControlElementImages.tumblerType3Down;

            this.Ц300М_1ТумблерПоискВид_ВклАвтоматичРучн.BackgroundImage = C300M_1Parameters.Ц300М_1ТумблерПоискВид_ВклАвтоматичРучн == "Автоматич"
                ? ControlElementImages.tumblerType3Up
                : ControlElementImages.tumblerType3Down;

            this.Ц300М_1ТумблерПоискС_АналСимметрОткл.BackgroundImage = C300M_1Parameters.Ц300М_1ТумблерПоискС_АналСимметрОткл == "Симметр"
                ? ControlElementImages.tumblerType3Up
                : ControlElementImages.tumblerType3Down;

            this.Ц300М_1ТумблерАСЧОткл.BackgroundImage = C300M_1Parameters.Ц300М_1ТумблерАСЧОткл == "АСЧ"
                ? ControlElementImages.tumblerType3Up
                : ControlElementImages.tumblerType3Down;

            this.Ц300М_1ТумблерАРУРРУ.BackgroundImage = C300M_1Parameters.Ц300М_1ТумблерАРУРРУ == "АРУ"
                ? ControlElementImages.tumblerType3Up
                : ControlElementImages.tumblerType3Down;

            this.Ц300М_1ТумблерЧТОФТ.BackgroundImage = C300M_1Parameters.Ц300М_1ТумблерЧТОФТ == "ЧТ"
                ? ControlElementImages.tumblerType3Up
                : ControlElementImages.tumblerType3Down;

            this.Ц300М_1ТумблерПоискПределы.BackgroundImage = C300M_1Parameters.Ц300М_1ТумблерПоискПределы == "300"
                ? ControlElementImages.tumblerType3Left
                : ControlElementImages.tumblerType3Right;

        }
        #endregion

        #region Тумблеры
        private void Ц300М_1ТумблерВведениеЧТОФТ_Click(object sender, System.EventArgs e)
        {
            if (C300M_1Parameters.Ц300М_1ТумблерВведениеЧТОФТ == "ЧТ")
            {
                this.Ц300М_1ТумблерВведениеЧТОФТ.BackgroundImage = ControlElementImages.tumblerType3Down;
                C300M_1Parameters.Ц300М_1ТумблерВведениеЧТОФТ = "ОФТ";
            }
            else
            {
                this.Ц300М_1ТумблерВведениеЧТОФТ.BackgroundImage = ControlElementImages.tumblerType3Up;
                C300M_1Parameters.Ц300М_1ТумблерВведениеЧТОФТ = "ЧТ";
            }
        }

        private void Ц300М_1ТумблерПоискБлокировкаВклОткл_Click(object sender, System.EventArgs e)
        {
            if (C300M_1Parameters.Ц300М_1ТумблерПоискБлокировкаВклОткл == "Вкл")
            {
                this.Ц300М_1ТумблерПоискБлокировкаВклОткл.BackgroundImage = ControlElementImages.tumblerType3Down;
                C300M_1Parameters.Ц300М_1ТумблерПоискБлокировкаВклОткл = "Откл";
            }
            else
            {
                this.Ц300М_1ТумблерПоискБлокировкаВклОткл.BackgroundImage = ControlElementImages.tumblerType3Up;
                C300M_1Parameters.Ц300М_1ТумблерПоискБлокировкаВклОткл = "Вкл";
            }
        }

        private void Ц300М_1ТумблерПоискВид_ВклАвтоматичРучн_Click(object sender, System.EventArgs e)
        {
            if (C300M_1Parameters.Ц300М_1ТумблерПоискВид_ВклАвтоматичРучн == "Автоматич")
            {
                this.Ц300М_1ТумблерПоискВид_ВклАвтоматичРучн.BackgroundImage = ControlElementImages.tumblerType3Down;
                C300M_1Parameters.Ц300М_1ТумблерПоискВид_ВклАвтоматичРучн = "Ручн";
            }
            else
            {
                this.Ц300М_1ТумблерПоискВид_ВклАвтоматичРучн.BackgroundImage = ControlElementImages.tumblerType3Up;
                C300M_1Parameters.Ц300М_1ТумблерПоискВид_ВклАвтоматичРучн = "Автоматич";
            }
        }

        private void Ц300М_1ТумблерПоискС_АналСимметрОткл_Click(object sender, System.EventArgs e)
        {
            if (C300M_1Parameters.Ц300М_1ТумблерПоискС_АналСимметрОткл == "Симметр")
            {
                this.Ц300М_1ТумблерПоискС_АналСимметрОткл.BackgroundImage = ControlElementImages.tumblerType3Down;
                C300M_1Parameters.Ц300М_1ТумблерПоискС_АналСимметрОткл = "Откл";
            }
            else
            {
                this.Ц300М_1ТумблерПоискС_АналСимметрОткл.BackgroundImage = ControlElementImages.tumblerType3Up;
                C300M_1Parameters.Ц300М_1ТумблерПоискС_АналСимметрОткл = "Симметр";
            }
        }

        private void Ц300М_1ТумблерАСЧОткл_Click(object sender, System.EventArgs e)
        {
            if (C300M_1Parameters.Ц300М_1ТумблерАСЧОткл == "АСЧ")
            {
                this.Ц300М_1ТумблерАСЧОткл.BackgroundImage = ControlElementImages.tumblerType3Down;
                C300M_1Parameters.Ц300М_1ТумблерАСЧОткл = "Откл";
            }
            else
            {
                this.Ц300М_1ТумблерАСЧОткл.BackgroundImage = ControlElementImages.tumblerType3Up;
                C300M_1Parameters.Ц300М_1ТумблерАСЧОткл = "АСЧ";
            }
        }

        private void Ц300М_1ТумблерАРУРРУ_Click(object sender, System.EventArgs e)
        {
            if (C300M_1Parameters.Ц300М_1ТумблерАРУРРУ == "АРУ")
            {
                this.Ц300М_1ТумблерАРУРРУ.BackgroundImage = ControlElementImages.tumblerType3Down;
                C300M_1Parameters.Ц300М_1ТумблерАРУРРУ = "РРУ";
            }
            else
            {
                this.Ц300М_1ТумблерАРУРРУ.BackgroundImage = ControlElementImages.tumblerType3Up;
                C300M_1Parameters.Ц300М_1ТумблерАРУРРУ = "АРУ";
            }
        }

        private void Ц300М_1ТумблерЧТОФТ_Click(object sender, System.EventArgs e)
        {
            if (C300M_1Parameters.Ц300М_1ТумблерЧТОФТ == "ЧТ")
            {
                this.Ц300М_1ТумблерЧТОФТ.BackgroundImage = ControlElementImages.tumblerType3Down;
                C300M_1Parameters.Ц300М_1ТумблерЧТОФТ = "ОФТ";
            }
            else
            {
                this.Ц300М_1ТумблерЧТОФТ.BackgroundImage = ControlElementImages.tumblerType3Up;
                C300M_1Parameters.Ц300М_1ТумблерЧТОФТ = "ЧТ";
            }
        }

        private void Ц300М_1ТумблерПоискПределы_Click(object sender, System.EventArgs e)
        {
            if (C300M_1Parameters.Ц300М_1ТумблерПоискПределы == "300")
            {
                this.Ц300М_1ТумблерПоискПределы.BackgroundImage = ControlElementImages.tumblerType3Right;
                C300M_1Parameters.Ц300М_1ТумблерПоискПределы = "60";
            }
            else
            {
                this.Ц300М_1ТумблерПоискПределы.BackgroundImage = ControlElementImages.tumblerType3Left;
                C300M_1Parameters.Ц300М_1ТумблерПоискПределы = "300";
            }
        }
        #endregion
    }
}