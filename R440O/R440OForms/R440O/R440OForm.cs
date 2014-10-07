using System;
using System.Linq;
using System.Windows.Forms;
using R440O.R440OForms.A205M_1;
using R440O.R440OForms.A205M_2;

namespace R440O.R440OForms.R440O
{
    public partial class R440OForm : Form
    {
        public R440OForm()
        {
            InitializeComponent();
        }
        
        private void R440OButtonA205M_1_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<A205M_1Form>().Any())
            {
                this.OwnedForms.OfType<A205M_1Form>().First().Activate();
            }
            else
            {
                Form thisForm = new A205M_1Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonA205M_2_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<A205M_2Form>().Any())
            {
                this.OwnedForms.OfType<A205M_2Form>().First().Activate();
            }
            else
            {
                Form thisForm = new A205M_2Form();
                thisForm.Show(this);
            }
        }
    }
}
