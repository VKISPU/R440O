using System.Windows.Forms;
using R440O.R440OForms.K05M_01Inside;

namespace R440O.R440OForms.K05M_01
{
    public partial class K05M_01Form: Form
    {
        public K05M_01Form()
        {
            InitializeComponent();
        }

        private void K05M_01ButtonInside_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Form thisForm = new K05M_01InsideForm();
            thisForm.Show(this);
        }
    }
}
