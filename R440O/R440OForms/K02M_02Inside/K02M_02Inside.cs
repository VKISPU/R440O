using System.Windows.Forms;

namespace R440O.R440OForms.K02M_02Inside
{
    public partial class K02M_02InsideForm : Form
    {
        public K02M_02InsideForm()
        {
            InitializeComponent();
        }

        private void K02M_02InsideForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}