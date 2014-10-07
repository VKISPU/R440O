using System;
using System.Linq;
using System.Windows.Forms;
using R440O.R440OForms.A205M_1;
using R440O.R440OForms.A205M_2;
using R440O.R440OForms.A1;
using R440O.R440OForms.A304;
using R440O.R440OForms.B1_1;
using R440O.R440OForms.Wattmeter;

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

        private void R440OButtonA1_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<A1Form>().Any())
            {
                this.OwnedForms.OfType<A1Form>().First().Activate();
            }
            else
            {
                Form thisForm = new A1Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonA304_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<A304Form>().Any())
            {
                this.OwnedForms.OfType<A304Form>().First().Activate();
            }
            else
            {
                Form thisForm = new A304Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonB1_1_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<B1_1Form>().Any())
            {
                this.OwnedForms.OfType<B1_1Form>().First().Activate();
            }
            else
            {
                Form thisForm = new B1_1Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonWattmeter_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<WattmeterForm>().Any())
            {
                this.OwnedForms.OfType<WattmeterForm>().First().Activate();
            }
            else
            {
                Form thisForm = new WattmeterForm();
                thisForm.Show(this);
            }

        }
    }
}
