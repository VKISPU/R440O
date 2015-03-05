//-----------------------------------------------------------------------
// <copyright file="C300M_2Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.C300M_2
{
    using System.Windows.Forms;
    using Parameters;
    using ThirdParty;
    using System.Reflection;

    /// <summary>
    /// Форма блока С300М-1
    /// </summary>
    public partial class C300M_2Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="C300M_2Form"/>
        /// </summary>
        public C300M_2Form()
        {
            this.InitializeComponent();
            this.InitializeTogglesPosition();
            this.InitializeButtonsPosition();
            this.InitializeTumblersPosition();
        }

        #region Кнопки ВИД РАБОТЫ
        private void Ц300М_2КнопкаВидРаботы0d025_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_2КнопкаВидРаботы0d025.Visible = false;
            C300M_2Parameters.Ц300М_2КнопкаВидРаботы0d025 = "true";

            foreach (Control control in C300M_2Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_2КнопкаВидРаботы0d025")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_2Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_2КнопкаВидРаботы0d025")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_2КнопкаВидРаботы0d05_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_2КнопкаВидРаботы0d05.Visible = false;
            C300M_2Parameters.Ц300М_2КнопкаВидРаботы0d05 = "true";

            foreach (Control control in C300M_2Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_2КнопкаВидРаботы0d05")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_2Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_2КнопкаВидРаботы0d05")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_2КнопкаВидРаботы0d1_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_2КнопкаВидРаботы0d1.Visible = false;
            C300M_2Parameters.Ц300М_2КнопкаВидРаботы0d1 = "true";

            foreach (Control control in C300M_2Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_2КнопкаВидРаботы0d1")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_2Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_2КнопкаВидРаботы0d1")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_2КнопкаВидРаботы1d2_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_2КнопкаВидРаботы1d2.Visible = false;
            C300M_2Parameters.Ц300М_2КнопкаВидРаботы1d2 = "true";

            foreach (Control control in C300M_2Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_2КнопкаВидРаботы1d2")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_2Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_2КнопкаВидРаботы1d2")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_2КнопкаВидРаботы2d4_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_2КнопкаВидРаботы2d4.Visible = false;
            C300M_2Parameters.Ц300М_2КнопкаВидРаботы2d4 = "true";

            foreach (Control control in C300M_2Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_2КнопкаВидРаботы2d4")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_2Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_2КнопкаВидРаботы2d4")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_2КнопкаВидРаботы4d8_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_2КнопкаВидРаботы4d8.Visible = false;
            C300M_2Parameters.Ц300М_2КнопкаВидРаботы4d8 = "true";

            foreach (Control control in C300M_2Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_2КнопкаВидРаботы4d8")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_2Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_2КнопкаВидРаботы4d8")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_2КнопкаВидРаботы48_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_2КнопкаВидРаботы48.Visible = false;
            C300M_2Parameters.Ц300М_2КнопкаВидРаботы48 = "true";

            foreach (Control control in C300M_2Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_2КнопкаВидРаботы48")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_2Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_2КнопкаВидРаботы48")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_2КнопкаВидРаботы96144_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_2КнопкаВидРаботы96144.Visible = false;
            C300M_2Parameters.Ц300М_2КнопкаВидРаботы96144 = "true";

            foreach (Control control in C300M_2Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_2КнопкаВидРаботы96144")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_2Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_2КнопкаВидРаботы96144")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_2КнопкаВидРаботы240_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_2КнопкаВидРаботы240.Visible = false;
            C300M_2Parameters.Ц300М_2КнопкаВидРаботы240 = "true";

            foreach (Control control in C300M_2Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_2КнопкаВидРаботы240")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_2Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_2КнопкаВидРаботы240")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_2КнопкаВидРаботы480_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_2КнопкаВидРаботы480.Visible = false;
            C300M_2Parameters.Ц300М_2КнопкаВидРаботы480 = "true";

            foreach (Control control in C300M_2Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы") && control.Name != "Ц300М_2КнопкаВидРаботы480")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_2Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы") && property.Name != "Ц300М_2КнопкаВидРаботы480")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_2КнопкаВидРаботыСброс_MouseDown(object sender, MouseEventArgs e)
        {
            this.Ц300М_2КнопкаВидРаботыСброс.BackgroundImage = null;
            this.Ц300М_2КнопкаВидРаботыСброс.Text = "";
            C300M_2Parameters.Ц300М_2КнопкаВидРаботыСброс = "true";

            foreach (Control control in C300M_2Panel.Controls)
            {
                if (control.Name.Contains("КнопкаВидРаботы"))
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_2Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаВидРаботы"))
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_2КнопкаВидРаботыСброс_MouseUp(object sender, MouseEventArgs e)
        {
            this.Ц300М_2КнопкаВидРаботыСброс.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.Ц300М_2КнопкаВидРаботыСброс.Text = "Сброс";
            C300M_2Parameters.Ц300М_2КнопкаВидРаботыСброс = "false";
        }
        #endregion

        #region Кнопки КОНТРОЛЬ РЕЖИМА
        private void Ц300М_2КнопкаКонтрольРежимаУрСигн_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_2КнопкаКонтрольРежимаУрСигн.Visible = false;
            C300M_2Parameters.Ц300М_2КнопкаКонтрольРежимаУрСигн = "true";

            foreach (Control control in C300M_2Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_2КнопкаКонтрольРежимаУрСигн")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_2Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_2КнопкаКонтрольРежимаУрСигн")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_2КнопкаКонтрольРежимаУрШума_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_2КнопкаКонтрольРежимаУрШума.Visible = false;
            C300M_2Parameters.Ц300М_2КнопкаКонтрольРежимаУрШума = "true";

            foreach (Control control in C300M_2Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_2КнопкаКонтрольРежимаУрШума")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_2Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_2КнопкаКонтрольРежимаУрШума")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_2КнопкаКонтрольРежима0АПЧ_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_2КнопкаКонтрольРежима0АПЧ.Visible = false;
            C300M_2Parameters.Ц300М_2КнопкаКонтрольРежима0АПЧ = "true";

            foreach (Control control in C300M_2Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_2КнопкаКонтрольРежима0АПЧ")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_2Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_2КнопкаКонтрольРежима0АПЧ")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_2КнопкаКонтрольРежимаПоиск_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_2КнопкаКонтрольРежимаПоиск.Visible = false;
            C300M_2Parameters.Ц300М_2КнопкаКонтрольРежимаПоиск = "true";

            foreach (Control control in C300M_2Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_2КнопкаКонтрольРежимаПоиск")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_2Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_2КнопкаКонтрольРежимаПоиск")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_2КнопкаКонтрольРежимаГЕТ_2_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_2КнопкаКонтрольРежимаГЕТ_2.Visible = false;
            C300M_2Parameters.Ц300М_2КнопкаКонтрольРежимаГЕТ_2 = "true";

            foreach (Control control in C300M_2Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_2КнопкаКонтрольРежимаГЕТ_2")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_2Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_2КнопкаКонтрольРежимаГЕТ_2")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_2КнопкаКонтрольРежимаПлюс5_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_2КнопкаКонтрольРежимаПлюс5.Visible = false;
            C300M_2Parameters.Ц300М_2КнопкаКонтрольРежимаПлюс5 = "true";

            foreach (Control control in C300M_2Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_2КнопкаКонтрольРежимаПлюс5")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_2Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_2КнопкаКонтрольРежимаПлюс5")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_2КнопкаКонтрольРежимаПлюс6d3_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_2КнопкаКонтрольРежимаПлюс6d3.Visible = false;
            C300M_2Parameters.Ц300М_2КнопкаКонтрольРежимаПлюс6d3 = "true";

            foreach (Control control in C300M_2Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_2КнопкаКонтрольРежимаПлюс6d3")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_2Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_2КнопкаКонтрольРежимаПлюс6d3")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_2КнопкаКонтрольРежимаПлюс27_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_2КнопкаКонтрольРежимаПлюс27.Visible = false;
            C300M_2Parameters.Ц300М_2КнопкаКонтрольРежимаПлюс27 = "true";

            foreach (Control control in C300M_2Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_2КнопкаКонтрольРежимаПлюс27")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_2Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_2КнопкаКонтрольРежимаПлюс27")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_2КнопкаКонтрольРежимаМинус5_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_2КнопкаКонтрольРежимаМинус5.Visible = false;
            C300M_2Parameters.Ц300М_2КнопкаКонтрольРежимаМинус5 = "true";

            foreach (Control control in C300M_2Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_2КнопкаКонтрольРежимаМинус5")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_2Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_2КнопкаКонтрольРежимаМинус5")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_2КнопкаКонтрольРежимаМинус12d8_Click(object sender, System.EventArgs e)
        {
            this.Ц300М_2КнопкаКонтрольРежимаМинус12d8.Visible = false;
            C300M_2Parameters.Ц300М_2КнопкаКонтрольРежимаМинус12d8 = "true";

            foreach (Control control in C300M_2Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_2КнопкаКонтрольРежимаМинус12d8")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_2Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_2КнопкаКонтрольРежимаМинус12d8")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_2КнопкаКонтрольРежимаМинус27_MouseDown(object sender, MouseEventArgs e)
        {
            this.Ц300М_2КнопкаКонтрольРежимаМинус27.BackgroundImage = null;
            this.Ц300М_2КнопкаКонтрольРежимаМинус27.Text = "";
            C300M_2Parameters.Ц300М_2КнопкаКонтрольРежимаМинус27 = "true";

            foreach (Control control in C300M_2Panel.Controls)
            {
                if (control.Name.Contains("КнопкаКонтрольРежима") && control.Name != "Ц300М_2КнопкаКонтрольРежимаМинус27")
                {
                    control.Visible = true;
                }
            }

            PropertyInfo[] propertyList = typeof(C300M_2Parameters).GetProperties();
            foreach (PropertyInfo property in propertyList)
            {
                if (property.Name.Contains("КнопкаКонтрольРежима") && property.Name != "Ц300М_2КнопкаКонтрольРежимаМинус27")
                {
                    property.SetValue(null, "false");
                }
            }
        }

        private void Ц300М_2КнопкаКонтрольРежимаМинус27_MouseUp(object sender, MouseEventArgs e)
        {
            this.Ц300М_2КнопкаКонтрольРежимаМинус27.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.Ц300М_2КнопкаКонтрольРежимаМинус27.Text = "-27";
            C300M_2Parameters.Ц300М_2КнопкаКонтрольРежимаМинус27 = "false";
        }
        #endregion

        #region Кнопка Индикация волны
        private void Ц300М_2КнопкаИндикацияВолны_MouseDown(object sender, MouseEventArgs e)
        {
            this.Ц300М_2КнопкаИндикацияВолны.BackgroundImage = null;
            C300M_2Parameters.Ц300М_2КнопкаИндикацияВолны = "true";
            Ц300М_2ИндикаторВолна1000.Text = System.Convert.ToString(C300M_2Parameters.Ц300М_2ПереключательВолна1000);
            Ц300М_2ИндикаторВолна1000.Visible = true;
            Ц300М_2ИндикаторВолна100.Text = System.Convert.ToString(C300M_2Parameters.Ц300М_2ПереключательВолна100);
            Ц300М_2ИндикаторВолна100.Visible = true;
            Ц300М_2ИндикаторВолна10.Text = System.Convert.ToString(C300M_2Parameters.Ц300М_2ПереключательВолна10);
            Ц300М_2ИндикаторВолна10.Visible = true;
            Ц300М_2ИндикаторВолна1.Text = System.Convert.ToString(C300M_2Parameters.Ц300М_2ПереключательВолна1);
            Ц300М_2ИндикаторВолна1.Visible = true;
        }

        private void Ц300М_2КнопкаИндикацияВолны_MouseUp(object sender, MouseEventArgs e)
        {
            this.Ц300М_2КнопкаИндикацияВолны.BackgroundImage = ControlElementImages.buttonSquareWhite;
            C300M_2Parameters.Ц300М_2КнопкаИндикацияВолны = "false";
            Ц300М_2ИндикаторВолна1000.Visible = false;
            Ц300М_2ИндикаторВолна100.Visible = false;
            Ц300М_2ИндикаторВолна10.Visible = false;
            Ц300М_2ИндикаторВолна1.Visible = false;
        }
        #endregion

        #region Переключатели Волна
        private void Ц300М_2ПереключательВолна1000_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                C300M_2Parameters.Ц300М_2ПереключательВолна1000 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                C300M_2Parameters.Ц300М_2ПереключательВолна1000 -= 1;
            }

            var angle = C300M_2Parameters.Ц300М_2ПереключательВолна1000 * 30 - 135;
            Ц300М_2ПереключательВолна1000.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
        }

        private void Ц300М_2ПереключательВолна100_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                C300M_2Parameters.Ц300М_2ПереключательВолна100 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                C300M_2Parameters.Ц300М_2ПереключательВолна100 -= 1;
            }

            var angle = C300M_2Parameters.Ц300М_2ПереключательВолна100 * 30 - 135;
            Ц300М_2ПереключательВолна100.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
        }

        private void Ц300М_2ПереключательВолна10_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                C300M_2Parameters.Ц300М_2ПереключательВолна10 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                C300M_2Parameters.Ц300М_2ПереключательВолна10 -= 1;
            }

            var angle = C300M_2Parameters.Ц300М_2ПереключательВолна10 * 30 - 135;
            Ц300М_2ПереключательВолна10.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
        }

        private void Ц300М_2ПереключательВолна1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                C300M_2Parameters.Ц300М_2ПереключательВолна1 += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                C300M_2Parameters.Ц300М_2ПереключательВолна1 -= 1;
            }

            var angle = C300M_2Parameters.Ц300М_2ПереключательВолна1 * 30 - 135;
            Ц300М_2ПереключательВолна1.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType3, angle);
        }
        #endregion

        #region Установка органов управления в положение их последней настройки
        /// <summary>
        /// Установка переключателей в положение последней их установки
        /// </summary>
        private void InitializeTogglesPosition()
        {
            foreach (Control item in C300M_2Panel.Controls)
            {
                if (item.Name.Contains("Переключатель"))
                {
                    PropertyInfo[] fieldList = typeof(C300M_2Parameters).GetProperties();
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
            foreach (Control item in C300M_2Panel.Controls)
            {
                if (item.Name.Contains("Кнопка"))
                {
                    PropertyInfo[] fieldList = typeof(C300M_2Parameters).GetProperties();
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
            this.Ц300М_2ТумблерВведениеЧТОФТ.BackgroundImage = C300M_2Parameters.Ц300М_2ТумблерВведениеЧТОФТ == "ЧТ"
                ? ControlElementImages.tumblerType3Up
                : ControlElementImages.tumblerType3Down;

            this.Ц300М_2ТумблерПоискБлокировкаВклОткл.BackgroundImage = C300M_2Parameters.Ц300М_2ТумблерПоискБлокировкаВклОткл == "Вкл"
                ? ControlElementImages.tumblerType3Up
                : ControlElementImages.tumblerType3Down;

            this.Ц300М_2ТумблерПоискВид_ВклАвтоматичРучн.BackgroundImage = C300M_2Parameters.Ц300М_2ТумблерПоискВид_ВклАвтоматичРучн == "Автоматич"
                ? ControlElementImages.tumblerType3Up
                : ControlElementImages.tumblerType3Down;

            this.Ц300М_2ТумблерПоискС_АналСимметрОткл.BackgroundImage = C300M_2Parameters.Ц300М_2ТумблерПоискС_АналСимметрОткл == "Симметр"
                ? ControlElementImages.tumblerType3Up
                : ControlElementImages.tumblerType3Down;

            this.Ц300М_2ТумблерАСЧОткл.BackgroundImage = C300M_2Parameters.Ц300М_2ТумблерАСЧОткл == "АСЧ"
                ? ControlElementImages.tumblerType3Up
                : ControlElementImages.tumblerType3Down;

            this.Ц300М_2ТумблерАРУРРУ.BackgroundImage = C300M_2Parameters.Ц300М_2ТумблерАРУРРУ == "АРУ"
                ? ControlElementImages.tumblerType3Up
                : ControlElementImages.tumblerType3Down;

            this.Ц300М_2ТумблерЧТОФТ.BackgroundImage = C300M_2Parameters.Ц300М_2ТумблерЧТОФТ == "ЧТ"
                ? ControlElementImages.tumblerType3Up
                : ControlElementImages.tumblerType3Down;

            this.Ц300М_2ТумблерПоискПределы.BackgroundImage = C300M_2Parameters.Ц300М_2ТумблерПоискПределы == "300"
                ? ControlElementImages.tumblerType3Left
                : ControlElementImages.tumblerType3Right;

        }
        #endregion

        #region Тумблеры
        private void Ц300М_2ТумблерВведениеЧТОФТ_Click(object sender, System.EventArgs e)
        {
            if (C300M_2Parameters.Ц300М_2ТумблерВведениеЧТОФТ == "ЧТ")
            {
                this.Ц300М_2ТумблерВведениеЧТОФТ.BackgroundImage = ControlElementImages.tumblerType3Down;
                C300M_2Parameters.Ц300М_2ТумблерВведениеЧТОФТ = "ОФТ";
            }
            else
            {
                this.Ц300М_2ТумблерВведениеЧТОФТ.BackgroundImage = ControlElementImages.tumblerType3Up;
                C300M_2Parameters.Ц300М_2ТумблерВведениеЧТОФТ = "ЧТ";
            }
        }

        private void Ц300М_2ТумблерПоискБлокировкаВклОткл_Click(object sender, System.EventArgs e)
        {
            if (C300M_2Parameters.Ц300М_2ТумблерПоискБлокировкаВклОткл == "Вкл")
            {
                this.Ц300М_2ТумблерПоискБлокировкаВклОткл.BackgroundImage = ControlElementImages.tumblerType3Down;
                C300M_2Parameters.Ц300М_2ТумблерПоискБлокировкаВклОткл = "Откл";
            }
            else
            {
                this.Ц300М_2ТумблерПоискБлокировкаВклОткл.BackgroundImage = ControlElementImages.tumblerType3Up;
                C300M_2Parameters.Ц300М_2ТумблерПоискБлокировкаВклОткл = "Вкл";
            }
        }

        private void Ц300М_2ТумблерПоискВид_ВклАвтоматичРучн_Click(object sender, System.EventArgs e)
        {
            if (C300M_2Parameters.Ц300М_2ТумблерПоискВид_ВклАвтоматичРучн == "Автоматич")
            {
                this.Ц300М_2ТумблерПоискВид_ВклАвтоматичРучн.BackgroundImage = ControlElementImages.tumblerType3Down;
                C300M_2Parameters.Ц300М_2ТумблерПоискВид_ВклАвтоматичРучн = "Ручн";
            }
            else
            {
                this.Ц300М_2ТумблерПоискВид_ВклАвтоматичРучн.BackgroundImage = ControlElementImages.tumblerType3Up;
                C300M_2Parameters.Ц300М_2ТумблерПоискВид_ВклАвтоматичРучн = "Автоматич";
            }
        }

        private void Ц300М_2ТумблерПоискС_АналСимметрОткл_Click(object sender, System.EventArgs e)
        {
            if (C300M_2Parameters.Ц300М_2ТумблерПоискС_АналСимметрОткл == "Симметр")
            {
                this.Ц300М_2ТумблерПоискС_АналСимметрОткл.BackgroundImage = ControlElementImages.tumblerType3Down;
                C300M_2Parameters.Ц300М_2ТумблерПоискС_АналСимметрОткл = "Откл";
            }
            else
            {
                this.Ц300М_2ТумблерПоискС_АналСимметрОткл.BackgroundImage = ControlElementImages.tumblerType3Up;
                C300M_2Parameters.Ц300М_2ТумблерПоискС_АналСимметрОткл = "Симметр";
            }
        }

        private void Ц300М_2ТумблерАСЧОткл_Click(object sender, System.EventArgs e)
        {
            if (C300M_2Parameters.Ц300М_2ТумблерАСЧОткл == "АСЧ")
            {
                this.Ц300М_2ТумблерАСЧОткл.BackgroundImage = ControlElementImages.tumblerType3Down;
                C300M_2Parameters.Ц300М_2ТумблерАСЧОткл = "Откл";
            }
            else
            {
                this.Ц300М_2ТумблерАСЧОткл.BackgroundImage = ControlElementImages.tumblerType3Up;
                C300M_2Parameters.Ц300М_2ТумблерАСЧОткл = "АСЧ";
            }
        }

        private void Ц300М_2ТумблерАРУРРУ_Click(object sender, System.EventArgs e)
        {
            if (C300M_2Parameters.Ц300М_2ТумблерАРУРРУ == "АРУ")
            {
                this.Ц300М_2ТумблерАРУРРУ.BackgroundImage = ControlElementImages.tumblerType3Down;
                C300M_2Parameters.Ц300М_2ТумблерАРУРРУ = "РРУ";
            }
            else
            {
                this.Ц300М_2ТумблерАРУРРУ.BackgroundImage = ControlElementImages.tumblerType3Up;
                C300M_2Parameters.Ц300М_2ТумблерАРУРРУ = "АРУ";
            }
        }

        private void Ц300М_2ТумблерЧТОФТ_Click(object sender, System.EventArgs e)
        {
            if (C300M_2Parameters.Ц300М_2ТумблерЧТОФТ == "ЧТ")
            {
                this.Ц300М_2ТумблерЧТОФТ.BackgroundImage = ControlElementImages.tumblerType3Down;
                C300M_2Parameters.Ц300М_2ТумблерЧТОФТ = "ОФТ";
            }
            else
            {
                this.Ц300М_2ТумблерЧТОФТ.BackgroundImage = ControlElementImages.tumblerType3Up;
                C300M_2Parameters.Ц300М_2ТумблерЧТОФТ = "ЧТ";
            }
        }

        private void Ц300М_2ТумблерПоискПределы_Click(object sender, System.EventArgs e)
        {
            if (C300M_2Parameters.Ц300М_2ТумблерПоискПределы == "300")
            {
                this.Ц300М_2ТумблерПоискПределы.BackgroundImage = ControlElementImages.tumblerType3Right;
                C300M_2Parameters.Ц300М_2ТумблерПоискПределы = "60";
            }
            else
            {
                this.Ц300М_2ТумблерПоискПределы.BackgroundImage = ControlElementImages.tumblerType3Left;
                C300M_2Parameters.Ц300М_2ТумблерПоискПределы = "300";
            }
        }

        private void Ц300М_2ТумблерУправление_Click(object sender, System.EventArgs e)
        {
            if (C300M_2Parameters.Ц300М_2ТумблерУправление == "Местное")
            {
                this.Ц300М_2ТумблерУправление.BackgroundImage = ControlElementImages.tumblerType4Up;
                C300M_2Parameters.Ц300М_2ТумблерУправление = "Дистанц";
            }
            else
            {
                this.Ц300М_2ТумблерУправление.BackgroundImage = ControlElementImages.tumblerType4Down;
                C300M_2Parameters.Ц300М_2ТумблерУправление = "Местное";
            }
        }
        #endregion

        #region Кнопки ПИТАНИЕ
        private void Ц300М_2КнопкаПитаниеВкл_MouseDown(object sender, MouseEventArgs e)
        {
            Ц300М_2КнопкаПитаниеВкл.BackgroundImage = null;
            Ц300М_2КнопкаПитаниеВкл.Text = "";
            C300M_2Parameters.Ц300М_2КнопкаПитаниеВкл = "true";
        }

        private void Ц300М_2КнопкаПитаниеВкл_MouseUp(object sender, MouseEventArgs e)
        {
            Ц300М_2КнопкаПитаниеВкл.BackgroundImage = ControlElementImages.buttonSquareWhite;
            Ц300М_2КнопкаПитаниеВкл.Text = "ВКЛ";
            C300M_2Parameters.Ц300М_2КнопкаПитаниеВкл = "false";
        }

        private void Ц300М_2КнопкаПитаниеВыкл_MouseDown(object sender, MouseEventArgs e)
        {
            Ц300М_2КнопкаПитаниеВыкл.BackgroundImage = null;
            Ц300М_2КнопкаПитаниеВыкл.Text = "";
            C300M_2Parameters.Ц300М_2КнопкаПитаниеВыкл = "true";
        }

        private void Ц300М_2КнопкаПитаниеВыкл_MouseUp(object sender, MouseEventArgs e)
        {
            Ц300М_2КнопкаПитаниеВыкл.BackgroundImage = ControlElementImages.buttonSquareWhite;
            Ц300М_2КнопкаПитаниеВыкл.Text = "ОТКЛ";
            C300M_2Parameters.Ц300М_2КнопкаПитаниеВыкл = "false";
        }
        #endregion

        #region Кнопка ПОИСК
        private void Ц300М_2КнопкаПоискВкл_MouseDown(object sender, MouseEventArgs e)
        {
            Ц300М_2КнопкаПоискВкл.BackgroundImage = null;
            Ц300М_2КнопкаПоискВкл.Text = "";
            C300M_2Parameters.Ц300М_2КнопкаПоискВкл = "true";
        }
        #endregion

        private void Ц300М_2КнопкаПоискВкл_MouseUp(object sender, MouseEventArgs e)
        {
            Ц300М_2КнопкаПоискВкл.BackgroundImage = ControlElementImages.buttonSquareWhite;
            Ц300М_2КнопкаПоискВкл.Text = "ВКЛ";
            C300M_2Parameters.Ц300М_2КнопкаПоискВкл = "false";
        }
    }
}