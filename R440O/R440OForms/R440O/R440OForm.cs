//-----------------------------------------------------------------------
// <copyright file="R440OForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using R440O.R440OForms.A304;
using R440O.R440OForms.N15;

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
                
                //Подписка на события
                switch (newForm.Name)
                {
                    case "A304Form":
                    {
                        var newA304Form = new A304Form();
                        var n15Form = (N15Form)this.getSpecificForm("N15Form");
                        if (n15Form != null)
                        {
                            n15Form.OnA30412Click += newA304Form.TurnLampsEvent;
                        }
                        newForm = newA304Form;
                    }
                    break;

                    case "N15Form":
                    {
                        var n15Form = new N15Form();
                        var newA304Form = (A304Form)this.getSpecificForm("A304Form");
                        if (newA304Form != null)
                        {
                            n15Form.OnA30412Click += newA304Form.TurnLampsEvent;
                        }
                        newForm = n15Form;
                    }
                    break;
                }
                newForm.Show(this);
            }
            catch
            {
                throw new Exception();
            }
        }

        private Form getSpecificForm(string formName)
        {
            foreach (Form form in OwnedForms.Where(form => form.Name == formName))
            {
                var specificForm = new Form();
                specificForm = form;
                return specificForm;
            }
            return null;
        }
        private void R440OForm_Load(object sender, EventArgs e)
        {
        }
    }
}