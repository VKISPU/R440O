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

        private void N15Form_Load(object sender, EventArgs e)
        {
        }
    }
}