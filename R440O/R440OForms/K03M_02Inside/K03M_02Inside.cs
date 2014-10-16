using System.Windows.Forms;

namespace R440O.R440OForms.K03M_02Inside
{
    public partial class K03M_02InsideForm: Form
    {
        public K03M_02InsideForm()
        {
            InitializeComponent();
        }

        private void K03M_02InsideForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
