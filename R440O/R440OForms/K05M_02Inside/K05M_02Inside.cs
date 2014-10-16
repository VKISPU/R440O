using System.Windows.Forms;

namespace R440O.R440OForms.K05M_02Inside
{
    public partial class K05M_02InsideForm: Form
    {
        public K05M_02InsideForm()
        {
            InitializeComponent();
        }

        private void K05M_02InsideForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
