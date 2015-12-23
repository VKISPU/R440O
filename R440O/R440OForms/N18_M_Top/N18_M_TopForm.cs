using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R440O.R440OForms.N18_M_Top
{
    public partial class N18_M_TopForm : Form
    {
        public N18_M_TopForm()
        {
            InitializeComponent();
        }

        private void DrawForm()
        {
            foreach (Control control in this.Controls)
            {
                if (N18_M_TopParameters.ГнездоДляКабеляК11 == control.Name)
                {
                    control.BackgroundImage = ControlElementImages.kabelInputK11;
                }
                else if (N18_M_TopParameters.ГнездоДляКабеляК12 == control.Name)
                {
                    control.BackgroundImage = ControlElementImages.kabelInputK12;
                }
                else
                {
                    control.BackgroundImage = null;
                }
            }
        }

        private void onButtonClick(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    N18_M_TopParameters.ГнездоДляКабеляК11 = button.Name;
                    if (N18_M_TopParameters.ГнездоДляКабеляК12 == N18_M_TopParameters.ГнездоДляКабеляК11)
                    {
                        N18_M_TopParameters.ГнездоДляКабеляК12 = "";
                    }
                }
                if (e.Button == MouseButtons.Right)
                {
                    N18_M_TopParameters.ГнездоДляКабеляК12 = button.Name;
                    if (N18_M_TopParameters.ГнездоДляКабеляК11 == N18_M_TopParameters.ГнездоДляКабеляК12)
                    {
                        N18_M_TopParameters.ГнездоДляКабеляК11 = "";
                    }
                }
                DrawForm();
            }
        }
    }
}
