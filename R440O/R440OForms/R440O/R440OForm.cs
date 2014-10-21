using System;
using System.Linq;
using System.Windows.Forms;

namespace R440O.R440OForms.R440O
{
    public partial class R440OForm : Form
    {
        public R440OForm()
        {
            InitializeComponent();
        }

        private void R440OButtonCommon_Click(object sender, EventArgs e)
        {
            var button = (Button) sender;
            const string buttonString = "Button";
            var blockName =
                button.Name.Substring(button.Name.IndexOf(buttonString, StringComparison.Ordinal) + buttonString.Length);
            var formName = blockName + "Form";
            foreach (Form form in OwnedForms.Where(form => form.Name == formName))
            {
                form.WindowState = FormWindowState.Normal;
                form.Activate();
                return;
            }

            try
            {
                const string r440OFormsString = "R440O.R440OForms.";
                var typeName = r440OFormsString + blockName + "." + formName;
                // ReSharper disable once AssignNullToNotNullAttribute by trycatch
                var thisForm = Activator.CreateInstance(type: Type.GetType(typeName));
                var newForm = (Form) thisForm;
                newForm.Show(this);
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}