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
    using A304;
    using N15;
    using N502B;
    using NKN_1;
    using NKN_2;

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
                var thisForm = Activator.CreateInstance(Type.GetType(typeName));
                var newForm = (Form)thisForm;
                
                //Подписка на события
                switch (newForm.Name)
                {
                    case "A304Form":
                    {
                        var newA304Form = new A304Form();
                        var n15Form = (N15Form)this.GetSpecificForm("N15Form");
                        if (n15Form != null)
                        {
                            n15Form.A30412StateChange += newA304Form.TurnLampsEvent;
                        }
                        newForm = newA304Form;
                    }
                    break;

                    case "N15Form":
                    {
                        var n15Form = new N15Form();
                        var newA304Form = (A304Form)this.GetSpecificForm("A304Form");
                        if (newA304Form != null)
                        {
                            n15Form.A30412StateChange += newA304Form.TurnLampsEvent;
                        }
                        newForm = n15Form;
                    }
                    break;
                    case "N502BForm":
                    {
                        var newN502BForm = new N502BForm();
                        var nkn1Form = (NKN_1Form)this.GetSpecificForm("NKN_1Form");
                        if (nkn1Form != null) newN502BForm.PowerTumblersChanged += nkn1Form.TurnLamps;

                        var nkn2Form = (NKN_2Form)this.GetSpecificForm("NKN_2Form");
                        if (nkn2Form != null) newN502BForm.PowerTumblersChanged += nkn2Form.TurnLamps;

                        newForm = newN502BForm;
                    }
                    break;

                    case "NKN_1Form":
                    {
                        var newNkn1Form = new NKN_1Form();
                        var n502BForm = (N502BForm)this.GetSpecificForm("N502BForm");
                        if (n502BForm != null)
                        {
                            n502BForm.PowerTumblersChanged += newNkn1Form.TurnLamps;
                        }
                        newForm = newNkn1Form;
                    }
                    break;

                    case "NKN_2Form":
                    {
                        var newNkn2Form = new NKN_2Form();
                        var n502BForm = (N502BForm)this.GetSpecificForm("N502BForm");
                        if (n502BForm != null)
                        {
                            n502BForm.PowerTumblersChanged += newNkn2Form.TurnLamps;
                        }
                        newForm = newNkn2Form;
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

        private Form GetSpecificForm(string formName)
        {
            return (from form in OwnedForms.Where(form => form.Name == formName) 
                    let specificForm = new Form() select form).FirstOrDefault();
        }

        private void R440OForm_Load(object sender, EventArgs e)
        {
        }
    }
}