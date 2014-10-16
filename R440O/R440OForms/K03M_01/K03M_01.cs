using System.Windows.Forms;
using R440O.R440OForms.K03M_01Inside;

namespace R440O.R440OForms.K03M_01
{
    public partial class K03M_01Form: Form
    {
        public K03M_01Form()
        {
            InitializeComponent();
        }

        private void K03M_01Cover_Click(object sender, System.EventArgs e)
        {
            K03M_01Cover.Visible = false;
        }

        private void K03M_01ButtonInside_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Form thisForm = new K03M_01InsideForm();
            thisForm.Show(this);
        }
    }
}
