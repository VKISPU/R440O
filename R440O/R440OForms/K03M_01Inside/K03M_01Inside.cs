using System.Windows.Forms;

namespace R440O.R440OForms.K03M_01Inside
{
    public partial class K03M_01InsideForm: Form
    {
        public K03M_01InsideForm()
        {
            InitializeComponent();
        }

        private void K03M_01InsideForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
