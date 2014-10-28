//-----------------------------------------------------------------------
// <copyright file="N15Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.N15
{
    using System;
    using System.Windows.Forms;
    using Parameters;

    /// <summary>
    /// ����� ����� �-15
    /// </summary>
    public partial class N15Form : Form
    {
        /// <summary>
        /// �������������� ����� ��������� ������ <see cref="N15Form"/>
        /// </summary>

        #region ������
        public N15Form()
        {
            this.InitializeComponent();
        }

        private void �15����������������_MouseDown(object sender, MouseEventArgs e)
        {
            this.�15����������������.BackgroundImage = null;
        }

        private void �15����������������_MouseUp(object sender, MouseEventArgs e)
        {
            this.�15����������������.BackgroundImage = ControlElementImages.buttonOnUpBlack;
            N15Parameters.�15���������������� = "true";
        }

        private void �15�����������������_MouseDown(object sender, MouseEventArgs e)
        {
            this.�15�����������������.BackgroundImage = null;
        }

        private void �15�����������������_MouseUp(object sender, MouseEventArgs e)
        {
            this.�15�����������������.BackgroundImage = ControlElementImages.buttonOffUpRed;
            N15Parameters.�15����������������� = "true";
        }

        private void �15�������������������300�1_Click(object sender, EventArgs e)
        {
            this.�15�������������������300�1.Visible = false;
            N15Parameters.�15�������������������300�1 = "true";

            this.�15�������������������300�2.Visible = true;
            N15Parameters.�15�������������������300�2 = "false";
            this.�15�������������������300�3.Visible = true;
            N15Parameters.�15�������������������300�3 = "false";
            this.�15�������������������300�4.Visible = true;
            N15Parameters.�15�������������������300�4 = "false";
            this.�15���������������16.Visible = true;
            N15Parameters.�15���������������16 = "false";
            this.�15�����������������.Visible = true;
            N15Parameters.�15����������������� = "false";
            N15Parameters.�15������������������� = "false";
        }

        private void �15�������������������300�2_Click(object sender, EventArgs e)
        {
            this.�15�������������������300�2.Visible = false;
            N15Parameters.�15�������������������300�2 = "true";

            this.�15�������������������300�1.Visible = true;
            N15Parameters.�15�������������������300�1 = "false";
            this.�15�������������������300�3.Visible = true;
            N15Parameters.�15�������������������300�3 = "false";
            this.�15�������������������300�4.Visible = true;
            N15Parameters.�15�������������������300�4 = "false";
            this.�15���������������16.Visible = true;
            N15Parameters.�15���������������16 = "false";
            this.�15�����������������.Visible = true;
            N15Parameters.�15����������������� = "false";
            N15Parameters.�15������������������� = "false";
        }

        private void �15�������������������300�3_Click(object sender, EventArgs e)
        {
            this.�15�������������������300�3.Visible = false;
            N15Parameters.�15�������������������300�3 = "true";

            this.�15�������������������300�1.Visible = true;
            N15Parameters.�15�������������������300�1 = "false";
            this.�15�������������������300�2.Visible = true;
            N15Parameters.�15�������������������300�2 = "false";
            this.�15�������������������300�4.Visible = true;
            N15Parameters.�15�������������������300�4 = "false";
            this.�15���������������16.Visible = true;
            N15Parameters.�15���������������16 = "false";
            this.�15�����������������.Visible = true;
            N15Parameters.�15����������������� = "false";
            N15Parameters.�15������������������� = "false";
        }

        private void �15�������������������300�4_Click(object sender, EventArgs e)
        {
            this.�15�������������������300�4.Visible = false;
            N15Parameters.�15�������������������300�4 = "true";

            this.�15�������������������300�1.Visible = true;
            N15Parameters.�15�������������������300�1 = "false";
            this.�15�������������������300�2.Visible = true;
            N15Parameters.�15�������������������300�2 = "false";
            this.�15�������������������300�3.Visible = true;
            N15Parameters.�15�������������������300�3 = "false";
            this.�15���������������16.Visible = true;
            N15Parameters.�15���������������16 = "false";
            this.�15�����������������.Visible = true;
            N15Parameters.�15����������������� = "false";
            N15Parameters.�15������������������� = "false";
        }

        private void �15���������������16_Click(object sender, EventArgs e)
        {
            this.�15���������������16.Visible = false;
            N15Parameters.�15���������������16 = "true";

            this.�15�������������������300�1.Visible = true;
            N15Parameters.�15�������������������300�1 = "false";
            this.�15�������������������300�2.Visible = true;
            N15Parameters.�15�������������������300�2 = "false";
            this.�15�������������������300�3.Visible = true;
            N15Parameters.�15�������������������300�3 = "false";
            this.�15�������������������300�4.Visible = true;
            N15Parameters.�15�������������������300�4 = "false";
            this.�15�����������������.Visible = true;
            N15Parameters.�15����������������� = "false";
            N15Parameters.�15������������������� = "false";
        }

        private void �15�����������������_Click(object sender, EventArgs e)
        {
            this.�15�����������������.Visible = false;
            N15Parameters.�15����������������� = "true";

            this.�15�������������������300�1.Visible = true;
            N15Parameters.�15�������������������300�1 = "false";
            this.�15�������������������300�2.Visible = true;
            N15Parameters.�15�������������������300�2 = "false";
            this.�15�������������������300�3.Visible = true;
            N15Parameters.�15�������������������300�3 = "false";
            this.�15�������������������300�4.Visible = true;
            N15Parameters.�15�������������������300�4 = "false";
            this.�15���������������16.Visible = true;
            N15Parameters.�15���������������16 = "false";
            N15Parameters.�15������������������� = "false";
        }

        private void �15�������������������_MouseUp(object sender, MouseEventArgs e)
        {
            this.�15�������������������.BackgroundImage = ControlElementImages.buttonSquareType1UpWhite;
            this.�15�������������������.Text = "�����";
            N15Parameters.�15������������������� = "true";

            this.�15�������������������300�1.Visible = true;
            N15Parameters.�15�������������������300�1 = "false";
            this.�15�������������������300�2.Visible = true;
            N15Parameters.�15�������������������300�2 = "false";
            this.�15�������������������300�3.Visible = true;
            N15Parameters.�15�������������������300�3 = "false";
            this.�15�������������������300�4.Visible = true;
            N15Parameters.�15�������������������300�4 = "false";
            this.�15���������������16.Visible = true;
            N15Parameters.�15���������������16 = "false";
            this.�15�����������������.Visible = true;
            N15Parameters.�15����������������� = "false";
        }

        private void �15�������������������_MouseDown(object sender, MouseEventArgs e)
        {
            this.�15�������������������.BackgroundImage = null;
            this.�15�������������������.Text = "";
        }
        
        private void �15�������13_1_Click(object sender, EventArgs e)
        {
            this.�15�������13_1.Visible = false;
            N15Parameters.�15�������13_1 = "true";

            this.�15�������13_2.Visible = true;
            N15Parameters.�15�������13_2 = "false";
            this.�15�������13_12.Visible = true;
            N15Parameters.�15�������13_12 = "false";
            N15Parameters.�15����������� = "false";
        }

        private void �15�������13_2_Click(object sender, EventArgs e)
        {
            this.�15�������13_2.Visible = false;
            N15Parameters.�15�������13_2 = "true";

            this.�15�������13_1.Visible = true;
            N15Parameters.�15�������13_1 = "false";
            this.�15�������13_12.Visible = true;
            N15Parameters.�15�������13_12 = "false";
            N15Parameters.�15����������� = "false";
        }

        private void �15�������13_12_Click(object sender, EventArgs e)
        {
            this.�15�������13_12.Visible = false;
            N15Parameters.�15�������13_12 = "true";

            this.�15�������13_1.Visible = true;
            N15Parameters.�15�������13_1 = "false";
            this.�15�������13_2.Visible = true;
            N15Parameters.�15�������13_2 = "false";
            N15Parameters.�15����������� = "false";
        }

        private void �15�����������_MouseUp(object sender, MouseEventArgs e)
        {            
            this.�15�����������.BackgroundImage = ControlElementImages.buttonSquareType1UpWhite;
            this.�15�����������.Text = "�����";
            N15Parameters.�15����������� = "true";

            this.�15�������13_1.Visible = true;
            N15Parameters.�15�������13_1 = "false";
            this.�15�������13_2.Visible = true;
            N15Parameters.�15�������13_2 = "false";
            this.�15�������13_12.Visible = true;
            N15Parameters.�15�������13_12 = "false";
        }

        private void �15�����������_MouseDown(object sender, MouseEventArgs e)
        {
            this.�15�����������.BackgroundImage = null;
            this.�15�����������.Text = "";
        }
        #endregion

        private void N15Form_Load(object sender, EventArgs e)
        {

        }

        private void �15��������300�1_Click(object sender, EventArgs e)
        {
            if (N15Parameters.�15��������300�1 == "true")
            {
                this.�15��������300�1.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                N15Parameters.�15��������300�1 = "false";
            }
            else
            {
                this.�15��������300�1.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                N15Parameters.�15��������300�1 = "true";
            }
        }

        private void �15��������300�2_Click(object sender, EventArgs e)
        {
            if (N15Parameters.�15��������300�2 == "true")
            {
                this.�15��������300�2.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                N15Parameters.�15��������300�2 = "false";
            }
            else
            {
                this.�15��������300�2.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                N15Parameters.�15��������300�2 = "true";
            }
        }

        private void �15��������300�3_Click(object sender, EventArgs e)
        {
            if (N15Parameters.�15��������300�3 == "true")
            {
                this.�15��������300�3.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                N15Parameters.�15��������300�3 = "false";
            }
            else
            {
                this.�15��������300�3.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                N15Parameters.�15��������300�3 = "true";
            }
        }

        private void �15��������300�4_Click(object sender, EventArgs e)
        {
            if (N15Parameters.�15��������300�4 == "true")
            {
                this.�15��������300�4.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                N15Parameters.�15��������300�4 = "false";
            }
            else
            {
                this.�15��������300�4.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                N15Parameters.�15��������300�4 = "true";
            }
        }

        private void �15��������12�_Click(object sender, EventArgs e)
        {
            if (N15Parameters.�15��������12� == "true")
            {
                this.�15��������12�.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                N15Parameters.�15��������12� = "false";
            }
            else
            {
                this.�15��������12�.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                N15Parameters.�15��������12� = "true";
            }
        }

        private void �15����������_Click(object sender, EventArgs e)
        {
            if (N15Parameters.�15���������� == "true")
            {
                this.�15����������.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                N15Parameters.�15���������� = "false";
            }
            else
            {
                this.�15����������.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                N15Parameters.�15���������� = "true";
            }
        }

        private void �15����������_1_Click(object sender, EventArgs e)
        {
            if (N15Parameters.�15����������_1 == "true")
            {
                this.�15����������_1.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                N15Parameters.�15����������_1 = "false";
            }
            else
            {
                this.�15����������_1.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                N15Parameters.�15����������_1 = "true";
            }
        }

        private void �15����������_2_Click(object sender, EventArgs e)
        {
            if (N15Parameters.�15����������_2 == "true")
            {
                this.�15����������_2.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                N15Parameters.�15����������_2 = "false";
            }
            else
            {
                this.�15����������_2.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                N15Parameters.�15����������_2 = "true";
            }
        }

        private void �15��������205_Click(object sender, EventArgs e)
        {
            if (N15Parameters.�15��������205 == "true")
            {
                this.�15��������205.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                N15Parameters.�15��������205 = "false";
            }
            else
            {
                this.�15��������205.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                N15Parameters.�15��������205 = "true";
            }
        }

        private void �15��������1_1_Click(object sender, EventArgs e)
        {
            if (N15Parameters.�15��������1_1 == "true")
            {
                this.�15��������1_1.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                N15Parameters.�15��������1_1 = "false";
            }
            else
            {
                this.�15��������1_1.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                N15Parameters.�15��������1_1 = "true";
            }
        }

        private void �15��������1_2_Click(object sender, EventArgs e)
        {
            if (N15Parameters.�15��������1_2 == "true")
            {
                this.�15��������1_2.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                N15Parameters.�15��������1_2 = "false";
            }
            else
            {
                this.�15��������1_2.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                N15Parameters.�15��������1_2 = "true";
            }
        }

        private void �15�����������_Click(object sender, EventArgs e)
        {
            if (N15Parameters.�15����������� == "true")
            {
                this.�15�����������.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                N15Parameters.�15����������� = "false";
            }
            else
            {
                this.�15�����������.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                N15Parameters.�15����������� = "true";
            }
        }

        private void �15��������1_Click(object sender, EventArgs e)
        {
            if (N15Parameters.�15��������1 == "true")
            {
                this.�15��������1.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                N15Parameters.�15��������1 = "false";
            }
            else
            {
                this.�15��������1.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                N15Parameters.�15��������1 = "true";
            }
        }

        private void �15��������403_Click(object sender, EventArgs e)
        {
            if (N15Parameters.�15��������403 == "true")
            {
                this.�15��������403.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                N15Parameters.�15��������403 = "false";
            }
            else
            {
                this.�15��������403.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                N15Parameters.�15��������403 = "true";
            }
        }

        private void �15��������1_1_Click(object sender, EventArgs e)
        {
            if (N15Parameters.�15��������1_1 == "true")
            {
                this.�15��������1_1.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                N15Parameters.�15��������1_1 = "false";
            }
            else
            {
                this.�15��������1_1.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                N15Parameters.�15��������1_1 = "true";
            }
        }

        private void �15��������1_2_Click(object sender, EventArgs e)
        {
            if (N15Parameters.�15��������1_2 == "true")
            {
                this.�15��������1_2.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                N15Parameters.�15��������1_2 = "false";
            }
            else
            {
                this.�15��������1_2.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                N15Parameters.�15��������1_2 = "true";
            }
        }

        private void �15��������2_1_Click(object sender, EventArgs e)
        {
            if (N15Parameters.�15��������2_1 == "true")
            {
                this.�15��������2_1.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                N15Parameters.�15��������2_1 = "false";
            }
            else
            {
                this.�15��������2_1.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                N15Parameters.�15��������2_1 = "true";
            }
        }

        private void �15��������2_2_Click(object sender, EventArgs e)
        {
            if (N15Parameters.�15��������2_2 == "true")
            {
                this.�15��������2_2.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                N15Parameters.�15��������2_2 = "false";
            }
            else
            {
                this.�15��������2_2.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                N15Parameters.�15��������2_2 = "true";
            }
        }

        private void �15��������3_1_Click(object sender, EventArgs e)
        {
            if (N15Parameters.�15��������3_1 == "true")
            {
                this.�15��������3_1.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                N15Parameters.�15��������3_1 = "false";
            }
            else
            {
                this.�15��������3_1.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                N15Parameters.�15��������3_1 = "true";
            }
        }

        private void �15��������3_2_Click(object sender, EventArgs e)
        {
            if (N15Parameters.�15��������3_2 == "true")
            {
                this.�15��������3_2.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                N15Parameters.�15��������3_2 = "false";
            }
            else
            {
                this.�15��������3_2.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                N15Parameters.�15��������3_2 = "true";
            }
        }

        private void �15����������_5_Click(object sender, EventArgs e)
        {
            if (N15Parameters.�15����������_5 == "true")
            {
                this.�15����������_5.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                N15Parameters.�15����������_5 = "false";
            }
            else
            {
                this.�15����������_5.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                N15Parameters.�15����������_5 = "true";
            }
        }

        private void �15��������_�_Click(object sender, EventArgs e)
        {
            if (N15Parameters.�15��������_� == "true")
            {
                this.�15��������_�.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                N15Parameters.�15��������_� = "false";
            }
            else
            {
                this.�15��������_�.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                N15Parameters.�15��������_� = "true";
            }
        }
    }
}