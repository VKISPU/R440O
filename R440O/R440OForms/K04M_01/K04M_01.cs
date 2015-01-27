//-----------------------------------------------------------------------
// <copyright file="K04M_01.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using System.Linq;
using R440O.Parameters;
using R440O.ThirdParty;

namespace R440O.R440OForms.K04M_01
{
    using System.Windows.Forms;

    /// <summary>
    /// Форма блока К04-М-1
    /// </summary>
    public partial class K04M_01Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="K04M_01Form"/>
        /// </summary>
        public K04M_01Form()
        {
            this.InitializeComponent();
            this.InitializeToggles();
        }

        private void InitializeToggles()
        {
            foreach (Control item in K04M_01Panel.Controls)
            {
                var fieldList = typeof(K04M_01Parameters).GetProperties();
                foreach (var field in fieldList.Where(property => item.Name == property.Name))
                {
                    if (item.Name.Contains("K04M_01Переключатель"))
                    {
                        var angle = (int)field.GetValue(null) * 26 - 120;
                        item.BackgroundImage =
                            TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
                    }
                }
            }
        }

        private void K04M_01Переключатель_MouseDown(object sender, MouseEventArgs e)
        {
            var item = sender as Button;
            var property = typeof (K04M_01Parameters).GetProperty(item.Name);
            if (e.Button == MouseButtons.Left)
            {
                property.SetValue(null, (int) property.GetValue(null) + 1);
            }

            if (e.Button == MouseButtons.Right)
            {
                property.SetValue(null, (int) property.GetValue(null) - 1);
            }

            var angle = (int) property.GetValue(null)*26 - 120;
            item.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void K04M_01Крышка_Click(object sender, System.EventArgs e)
        {
            K04M_01Крышка.Visible = false;
        }
    }
}