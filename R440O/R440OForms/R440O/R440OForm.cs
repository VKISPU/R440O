using System;
using System.Linq;
using System.Windows.Forms;
using R440O.R440OForms.A205M_1;

namespace R440O.R440OForms.R440O
{
    public partial class R440OForm : Form
    {
        public R440OForm()
        {
            InitializeComponent();
        }
        
        #region A205
        private void buttonA205M_1_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<A205M_1Form>().Any())
            {
                this.OwnedForms.OfType<A205M_1Form>().First().Activate();
            }
            else
            {
                Form a205Form = new A205M_1Form();
                a205Form.Show(this);
            }
        }
        #endregion
    }
}
