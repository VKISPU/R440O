using System.Windows.Forms;

namespace R440O.R440OForms.K05M_01Inside
{
    public partial class K05M_01InsideForm : Form
    {
        public K05M_01InsideForm()
        {
            InitializeComponent();
        }

        private void K05M_01InsideForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}