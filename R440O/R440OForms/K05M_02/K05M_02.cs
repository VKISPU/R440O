using System.Windows.Forms;
using R440O.R440OForms.K02M_02Inside;
using R440O.R440OForms.K05M_02Inside;

namespace R440O.R440OForms.K05M_02
{
    public partial class K05M_02Form: Form
    {
        public K05M_02Form()
        {
            InitializeComponent();
        }

        private void K05M_02ButtonInside_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Form thisForm = new K05M_02InsideForm();
            thisForm.Show(this);
        }
    }
}
