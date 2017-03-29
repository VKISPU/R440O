using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using R440O.R440OForms.R440O;
using R440O.InternalBlocks;

namespace R440O
{
    public partial class StationForm : Form
    {
        public StationForm()
        {
            InitializeComponent();
            Antenna.FindRetranslator(() =>
            {
                ParametersConfig.SetParameters();
                Antenna.StartServerPing();
                RunR400O();
            });
        }

        public void RunR400O()
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.Hide();
                var r440o = new R440OForm();
                r440o.Show();
            });
        }
    }
}
