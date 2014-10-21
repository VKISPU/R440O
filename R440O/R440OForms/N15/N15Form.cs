using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using R440O.ThirdParty;
using R440O.Parameters;

namespace R440O.R440OForms.N15
{
    public partial class N15Form : Form
    {
        public N15Form()
        {
            InitializeComponent();
        }

        private void Н15КнопкаСтанцияВкл_MouseDown(object sender, MouseEventArgs e)
        {
            this.Н15КнопкаСтанцияВкл.BackgroundImage = null;
        }

        private void Н15КнопкаСтанцияВкл_MouseUp(object sender, MouseEventArgs e)
        {
            this.Н15КнопкаСтанцияВкл.BackgroundImage = ControlElementImages.buttonOnUpBlack;
            N15Parameters.Н15КнопкаСтанцияВкл = "true";
        }

        private void Н15КнопкаСтанцияВыкл_MouseDown(object sender, MouseEventArgs e)
        {
            this.Н15КнопкаСтанцияВыкл.BackgroundImage = null;
        }

        private void Н15КнопкаСтанцияВыкл_MouseUp(object sender, MouseEventArgs e)
        {
            this.Н15КнопкаСтанцияВыкл.BackgroundImage = ControlElementImages.buttonOffUpRed;
            N15Parameters.Н15КнопкаСтанцияВыкл = "true";
        }

        private void N15Form_Load(object sender, EventArgs e)
        {

        }
    }
}