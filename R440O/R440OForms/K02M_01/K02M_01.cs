using System.Linq;
using System.Windows.Forms;
using R440O.R440OForms.K02M_01Inside;

namespace R440O.R440OForms.K02M_01
{
    public partial class K02M_01Form : Form
    {
        public K02M_01Form()
        {
            InitializeComponent();
        }

        private void K02M_01ButtonInside_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Form thisForm = new K02M_01InsideForm();
            thisForm.Show(this);
        }
    }
}