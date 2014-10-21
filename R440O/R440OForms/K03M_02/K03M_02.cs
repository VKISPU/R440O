﻿using System.Windows.Forms;
using R440O.R440OForms.K03M_02Inside;

namespace R440O.R440OForms.K03M_02
{
    public partial class K03M_02Form : Form
    {
        public K03M_02Form()
        {
            InitializeComponent();
        }

        private void K03M_02Cover_Click(object sender, System.EventArgs e)
        {
            K03M_02Cover.Visible = false;
        }

        private void K03M_02ButtonInside_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Form thisForm = new K03M_02InsideForm();
            thisForm.Show(this);
        }
    }
}