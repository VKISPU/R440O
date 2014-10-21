using System.Windows.Forms;

namespace R440O.R440OForms.K02M_01Inside
{
    public partial class K02M_01InsideForm : Form
    {
        public K02M_01InsideForm()
        {
            InitializeComponent();
        }

        private void K02M_01InsideForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}