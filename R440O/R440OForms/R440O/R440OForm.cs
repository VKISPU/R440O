//-----------------------------------------------------------------------
// <copyright file="R440OForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.R440O
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using Parameters;

    /// <summary>
    /// Форма станции Р440-О
    /// </summary>
    public partial class R440OForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="R440OForm"/>
        /// </summary>
        public R440OForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Открытие формы блока в соотвествии с нажатой кнопкой
        /// </summary>
        /// <param name="sender">Нажатая кнопка</param>
        /// <param name="e">Событие нажатия</param>
        private void R440OButtonCommon_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            const string BUTTON_STRINGS = "Button";
            var blockName =
                button.Name.Substring(button.Name.IndexOf(BUTTON_STRINGS, StringComparison.Ordinal) + BUTTON_STRINGS.Length);
            var formName = blockName + "Form";

            // Активация формы соответствующей нажатой кнопке
            foreach (Form form in OwnedForms.Where(form => form.Name == formName))
            {
                form.WindowState = FormWindowState.Normal;
                form.Activate();
                return;
            }

            // Открытие новой формы соответствующей нажатой кнопке
            try
            {
                const string R440_O_FORMS_STRING = "R440O.R440OForms.";
                var typeName = R440_O_FORMS_STRING + blockName + "." + formName;
                // ReSharper disable once AssignNullToNotNullAttribute by trycatch
                var thisForm = Activator.CreateInstance(type: Type.GetType(typeName));
                var newForm = (Form)thisForm;
                newForm.Show(this);
            }
            catch
            {
                throw new Exception();
            }
        }

        private void R440OForm_Load(object sender, EventArgs e)
        {
        }
    }
}