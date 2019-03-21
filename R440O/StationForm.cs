using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using R440O.R440OForms.R440O;
using R440O.ThirdParty;

namespace R440O
{
    public partial class StationForm : Form
    {
        private Timer таймерПоискаСервера = new Timer();
        private R440OForm r440OForm;

        public StationForm()
        {
            InitializeComponent();
            pcNumber.Text += Dns.GetHostName().Substring(2,2);
        }

        public void tick(object sender, EventArgs e)
        {
            if (!HttpHelper.ПоискИдет)
            {
                HttpHelper.ПроверитьАдресс("http://" + "192.168.0." + LastByteIP.Text + ":8080/");
            }
            else
            {
                if (!HttpHelper.СерверНайден)
                {
                    RunR400O();
                }
            }
        }

        public void RunR400O()
        {
            таймерПоискаСервера.Stop();
            ParametersConfig.SetParameters();
            this.Hide();
            r440OForm = new R440OForm();
            r440OForm.FormClosedEvent += OnR440oFormClosed;
            r440OForm.Show();
        }

        private void OfflineWorkButton_Click(object sender, EventArgs e)
        {
            ParametersConfig.setIsLearning(true);
            RunR400O();
        }

        private void OnR440oFormClosed()
        {
            this.Close();
        }

        private void StartSearchButton_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            таймерПоискаСервера.Enabled = true;
            таймерПоискаСервера.Interval = 1000;
            таймерПоискаСервера.Tick += tick;
            таймерПоискаСервера.Start();
        }

        private void LastByteIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void LastByteIP_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(LastByteIP.Text))
            {
                StartSearchButton.Enabled = false;
            }
            else
            {
                StartSearchButton.Enabled = true;
            }
        }
    }
}
