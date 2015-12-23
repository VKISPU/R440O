using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R440O.R440OForms.N18_M_Bottom
{
    public partial class N18_M_BottomForm : Form
    {
        public N18_M_BottomForm()
        {
            InitializeComponent();
        }

        private void КабельК11_Click(object sender, EventArgs e)
        {
            N18_M_BottomParameters.ActiveCable = 0;
            DrawForm();
        }

        private void КабельК12_Click(object sender, EventArgs e)
        {
            N18_M_BottomParameters.ActiveCable = 1;
            DrawForm();
        }

        private void АктивныйКабель_Click(object sender, EventArgs e)
        {
            N18_M_BottomParameters.ActiveCable = null;
            DrawForm();
        }
        private void DrawForm()
        {
            КабельК11.Visible = N18_M_BottomParameters.ActiveCable != 0;
            КабельК12.Visible = N18_M_BottomParameters.ActiveCable != 1;

            if (N18_M_BottomParameters.ActiveCable == 0)
            {
                АктивныйКабель.BackgroundImage = ControlElementImages.kabelInputK11;
                АктивныйКабель.Visible = true;
            }
            if (N18_M_BottomParameters.ActiveCable == 1)
            {
                АктивныйКабель.BackgroundImage = ControlElementImages.kabelInputK12;
                АктивныйКабель.Visible = true;
            }
            if (N18_M_BottomParameters.ActiveCable == null)
            {
                АктивныйКабель.Visible = false;
            }
        }
    }
}
