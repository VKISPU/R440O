using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R440O.R440OForms.PowerShield
{
    public partial class TLF_TCHForm : Form
    {
        public TLF_TCHForm()
        {
            InitializeComponent();
        }

        private void TLF_TCHForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void Штырь_Click(object sender, EventArgs e)
        {
            var СвязанныйШтырь = sender as Button;
            var text = СвязанныйШтырь.Name;
            int НомерШтыря = text.Length == 6 ?
                (int)char.GetNumericValue(text[5]) :
                10 * (int)char.GetNumericValue(text[5]) + (int)char.GetNumericValue(text[6]);
           
        }

        private void Гнездо_Click(object sender, EventArgs e)
        {
            var СвязанноеГнездо = sender as Button;
            var text = СвязанноеГнездо.Name;
            int НомерГнезда = text.Length == 7 ?
                (int)char.GetNumericValue(text[6]) :
                10 * (int)char.GetNumericValue(text[6]) + (int)char.GetNumericValue(text[7]);

        }
    }
}
