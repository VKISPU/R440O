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
    using System.Threading;

    /// <summary>
    /// ����� ����� �-15
    /// </summary>
    public partial class N15Form : Form
    {
        //��������
        private static string ����15��������300�1 { get; set; }
        private static string ����15��������300�2 { get; set; }
        private static string ����15��������300�3 { get; set; }
        private static string ����15��������300�4 { get; set; }
        private static string ����15��������12� { get; set; }
        private static string ����15���������� { get; set; }
        private static string ����15����������_1 { get; set; }
        private static string ����15����������_2 { get; set; }
        private static string ����15��������205 { get; set; }
        private static string ����15��������20512 { get; set; }
        private static string ����15����������� { get; set; }
        private static string ����15��������1 { get; set; }
        private static string ����15��������403 { get; set; }
        private static string ����15��������1_1 { get; set; }
        private static string ����15��������1_2 { get; set; }
        private static string ����15��������1_1 { get; set; }
        private static string ����15��������1_2 { get; set; }
        private static string ����15��������2_1 { get; set; }
        private static string ����15��������2_2 { get; set; }
        private static string ����15��������3_1 { get; set; }
        private static string ����15��������3_2 { get; set; }
        private static string ����15����������_5 { get; set; }
        private static string ����15��������_� { get; set; }

        //������
        private static string ����15�������13_1 { get; set; }
        private static string ����15�������13_2 { get; set; }
        private static string ����15�������13_12 { get; set; }

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

            #region �15��������300�1
            N15Parameters.�15��������300�1 = ����15��������300�1;
            if (N15Parameters.�15��������300�1 == "true")
            {
                N15Parameters.�15���������300����1 = "true";
                this.�15���������300����1.BackgroundImage = ControlElementImages.lampType8OnRed;
            }
            else
            {
                N15Parameters.�15���������300����1 = "false";
                this.�15���������300����1.BackgroundImage = null;
            }
            #endregion

            #region �15��������300�2
            N15Parameters.�15��������300�2 = ����15��������300�2;
            if (N15Parameters.�15��������300�2 == "true")
            {
                N15Parameters.�15���������300����2 = "true";
                this.�15���������300����2.BackgroundImage = ControlElementImages.lampType8OnRed;
            }
            else
            {
                N15Parameters.�15���������300����2 = "false";
                this.�15���������300����2.BackgroundImage = null;
            }
            #endregion

            #region �15��������300�3
            N15Parameters.�15��������300�3 = ����15��������300�3;
            if (N15Parameters.�15��������300�3 == "true")
            {
                N15Parameters.�15���������300����3 = "true";
                this.�15���������300����3.BackgroundImage = ControlElementImages.lampType8OnRed;
            }
            else
            {
                N15Parameters.�15���������300����3 = "false";
                this.�15���������300����3.BackgroundImage = null;
            }
            #endregion

            #region �15��������300�4
            N15Parameters.�15��������300�4 = ����15��������300�4;
            if (N15Parameters.�15��������300�4 == "true")
            {
                N15Parameters.�15���������300����4 = "true";
                this.�15���������300����4.BackgroundImage = ControlElementImages.lampType8OnRed;
            }
            else
            {
                N15Parameters.�15���������300����4 = "false";
                this.�15���������300����4.BackgroundImage = null;
            }
            #endregion

            #region �15��������12�
            N15Parameters.�15��������12� = ����15��������12�;
            if (N15Parameters.�15��������12� == "true")
            {
                N15Parameters.�15���������12� = "true";
                this.�15���������12�.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.�15���������12� = "false";
                this.�15���������12�.BackgroundImage = null;
            }
            #endregion

            #region �15����������
            N15Parameters.�15���������� = ����15����������;
            
            if (N15Parameters.�15���������� == "true")
            {
                N15Parameters.�15���������306 = "true";
                this.�15���������306.BackgroundImage = ControlElementImages.lampType5OnRed;

                N15Parameters.�15����������� = "true";
                this.�15�����������.BackgroundImage = ControlElementImages.lampType5OnRed;

                if (N15Parameters.�15��������30412 == "1")
                {
                    N15Parameters.�15���������3041 = "true";
                    this.�15���������3041.BackgroundImage = ControlElementImages.lampType5OnRed;
                }
                else
                    if (N15Parameters.�15��������30412 == "2")
                    {
                        N15Parameters.�15���������3042 = "true";
                        this.�15���������3042.BackgroundImage = ControlElementImages.lampType5OnRed;
                    }
            }
            else
            {
                N15Parameters.�15����������� = "false";
                this.�15�����������.BackgroundImage = null;

                N15Parameters.�15���������306 = "false";
                this.�15���������306.BackgroundImage = null;

                if (N15Parameters.�15���������3041 == "true")
                {
                    N15Parameters.�15���������3041 = "false";
                    this.�15���������3041.BackgroundImage = null;
                }
                else
                    if (N15Parameters.�15���������3042 == "true")
                    {
                        N15Parameters.�15���������3042 = "false";
                        this.�15���������3042.BackgroundImage = null;
                    }
            }
            if (A30412StateChange != null)
            {
                A30412StateChange();
            }
            #endregion

            #region �15����������_1
            N15Parameters.�15����������_1 = ����15����������_1;
            if (N15Parameters.�15����������_1 == "true")
            {
                N15Parameters.�15�����������_1 = "true";
                this.�15�����������_1.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.�15�����������_1 = "false";
                this.�15�����������_1.BackgroundImage = null;
            }
            #endregion

            #region �15����������_2
            N15Parameters.�15����������_2 = ����15����������_2;
            if (N15Parameters.�15����������_2 == "true")
            {
                N15Parameters.�15�����������_2 = "true";
                this.�15�����������_2.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.�15�����������_2 = "false";
                this.�15�����������_2.BackgroundImage = null;
            }
            #endregion

            #region �15��������205 and �15��������20512
            N15Parameters.�15��������205 = ����15��������205;
            N15Parameters.�15��������20512 = ����15��������20512;
            if (N15Parameters.�15��������205 == "true")
            {
                if (N15Parameters.�15��������20512 == "1")
                {
                    N15Parameters.�15��������������1 = "true";
                    this.�15��������������1.BackgroundImage = ControlElementImages.lampType8OnRed;
                    N15Parameters.�15�����������������1 = "true";
                    this.�15�����������������1.BackgroundImage = ControlElementImages.lampType8OnRed;
                    N15Parameters.�15����������1������1 = "true";
                    this.�15����������1������1.BackgroundImage = ControlElementImages.lampType8OnRed;

                    N15Parameters.�15��������������2 = "false";
                    this.�15��������������2.BackgroundImage = null;
                    N15Parameters.�15�����������������2 = "false";
                    this.�15�����������������2.BackgroundImage = null;
                    N15Parameters.�15����������1������2 = "false";
                    this.�15����������1������2.BackgroundImage = null;
                }
                else
                {
                    N15Parameters.�15��������������2 = "true";
                    this.�15��������������2.BackgroundImage = ControlElementImages.lampType8OnRed;
                    N15Parameters.�15�����������������2 = "true";
                    this.�15�����������������2.BackgroundImage = ControlElementImages.lampType8OnRed;
                    N15Parameters.�15����������1������2 = "true";
                    this.�15����������1������2.BackgroundImage = ControlElementImages.lampType8OnRed;

                    N15Parameters.�15��������������1 = "false";
                    this.�15��������������1.BackgroundImage = null;
                    N15Parameters.�15�����������������1 = "false";
                    this.�15�����������������1.BackgroundImage = null;
                    N15Parameters.�15����������1������1 = "false";
                    this.�15����������1������1.BackgroundImage = null;
                }
            }
            else
            {
                N15Parameters.�15��������������2 = "false";
                this.�15��������������2.BackgroundImage = null;
                N15Parameters.�15�����������������2 = "false";
                this.�15�����������������2.BackgroundImage = null;
                N15Parameters.�15����������1������2 = "false";
                this.�15����������1������2.BackgroundImage = null;

                N15Parameters.�15��������������1 = "false";
                this.�15��������������1.BackgroundImage = null;
                N15Parameters.�15�����������������1 = "false";
                this.�15�����������������1.BackgroundImage = null;
                N15Parameters.�15����������1������1 = "false";
                this.�15����������1������1.BackgroundImage = null;
            }
            #endregion

            #region �15�����������
            N15Parameters.�15����������� = ����15�����������;
            if (N15Parameters.�15����������� == "true")
            {
                N15Parameters.�15������������ = "true";
                this.�15������������.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.�15������������ = "false";
                this.�15������������.BackgroundImage = null;
            }
            #endregion

            #region �15��������1
            N15Parameters.�15��������1 = ����15��������1;
            if (N15Parameters.�15��������1 == "true")
            {
                N15Parameters.�15���������1 = "true";
                this.�15���������1.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.�15���������1 = "false";
                this.�15���������1.BackgroundImage = null;
            }
            #endregion

            N15Parameters.�15��������403 = ����15��������403;
            N15Parameters.�15��������1_1 = ����15��������1_1;
            N15Parameters.�15��������1_2 = ����15��������1_2;

            #region �15��������1_1
            N15Parameters.�15��������1_1 = ����15��������1_1;
            if (N15Parameters.�15��������1_1 == "true")
            {
                N15Parameters.�15���������1_1 = "true";
                this.�15���������1_1.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.�15���������1_1 = "false";
                this.�15���������1_1.BackgroundImage = null;
            }
            #endregion

            #region �15��������1_2
            N15Parameters.�15��������1_2 = ����15��������1_2;
            if (N15Parameters.�15��������1_2 == "true")
            {
                N15Parameters.�15���������1_2 = "true";
                this.�15���������1_2.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.�15���������1_2 = "false";
                this.�15���������1_2.BackgroundImage = null;
            }
            #endregion

            #region �15��������2_1
            N15Parameters.�15��������2_1 = ����15��������2_1;
            if (N15Parameters.�15��������2_1 == "true")
            {
                N15Parameters.�15���������2_1 = "true";
                this.�15���������2_1.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.�15���������2_1 = "false";
                this.�15���������2_1.BackgroundImage = null;
            }
            #endregion

            #region �15��������2_2
            N15Parameters.�15��������2_2 = ����15��������2_2;
            if (N15Parameters.�15��������2_2 == "true")
            {
                N15Parameters.�15���������2_2 = "true";
                this.�15���������2_2.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.�15���������2_2 = "false";
                this.�15���������2_2.BackgroundImage = null;
            }
            #endregion

            #region �15��������3_1
            N15Parameters.�15��������3_1 = ����15��������3_1;
            if (N15Parameters.�15��������3_1 == "true")
            {
                N15Parameters.�15���������3_1 = "true";
                this.�15���������3_1.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.�15���������3_1 = "false";
                this.�15���������3_1.BackgroundImage = null;
            }
            #endregion

            #region �15��������3_2
            N15Parameters.�15��������3_2 = ����15��������3_2;
            if (N15Parameters.�15��������3_2 == "true")
            {
                N15Parameters.�15���������3_2 = "true";
                this.�15���������3_2.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.�15���������3_2 = "false";
                this.�15���������3_2.BackgroundImage = null;
            }
            #endregion

            N15Parameters.�15����������_5 = ����15����������_5;

            #region �15��������_�
            N15Parameters.�15��������_� = ����15��������_�;
            if (N15Parameters.�15��������_� == "true")
            {
                N15Parameters.�15���������_� = "true";
                this.�15���������_�.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                N15Parameters.�15���������_� = "false";
                this.�15���������_�.BackgroundImage = null;
            }
            #endregion

            N15Parameters.�15�������13_1 = ����15�������13_1;
            N15Parameters.�15�������13_2 = ����15�������13_2;
            N15Parameters.�15�������13_12 = ����15�������13_12;
        }

        #region ������ ����
        private void �15�����������������_MouseDown(object sender, MouseEventArgs e)
        {
            this.�15�����������������.BackgroundImage = null;
        }

        private void �15�����������������_MouseUp(object sender, MouseEventArgs e)
        {
            this.�15�����������������.BackgroundImage = ControlElementImages.buttonOffUpRed;
            N15Parameters.�15����������������� = "true";
        }
        #endregion

        #region ������ ��� ���������/�300� 1 2 3 4 � �������� �16 ��� �����
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
        }

        private void �15�������������������_MouseDown(object sender, MouseEventArgs e)
        {
            this.�15�������������������.BackgroundImage = null;
            this.�15�������������������.Text = "";
        }

        private void �15�������������������_MouseUp(object sender, MouseEventArgs e)
        {
            this.�15�������������������.BackgroundImage = ControlElementImages.buttonSquareType1UpWhite;
            this.�15�������������������.Text = "�����";

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
        #endregion

        #region ������ �13-1 �13-2 �13-1,2 �����
        private void �15�������13_1_Click(object sender, EventArgs e)
        {
            this.�15�������13_1.Visible = false;
            this.�15�������13_2.Visible = true;
            this.�15�������13_12.Visible = true;

            if (����15�������13_2 == "false" && ����15�������13_12 == "false")
            {
                Application.DoEvents();
                Thread.Sleep(2000);
                this.�15���������16�13_1.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                Application.DoEvents();
                Thread.Sleep(2000);
                this.�15���������16�13_12.BackgroundImage = ControlElementImages.lampType5OnRed;
                this.�15���������16�13_2.BackgroundImage = null;

                Application.DoEvents();
                Thread.Sleep(2000);
                this.�15���������16�13_1.BackgroundImage = ControlElementImages.lampType5OnRed;
                this.�15���������16�13_12.BackgroundImage = null;
            }

            ����15�������13_1 = "true";            
            ����15�������13_2 = "false";            
            ����15�������13_12 = "false";

            N15Parameters.�15���������16�13_1 = "true";
            N15Parameters.�15���������16�13_2 = "false";
            N15Parameters.�15���������16�13_12 = "false";
        }

        private void �15�������13_2_Click(object sender, EventArgs e)
        {
            this.�15�������13_2.Visible = false;
            this.�15�������13_1.Visible = true;
            this.�15�������13_12.Visible = true;

            if (����15�������13_1 == "false" && ����15�������13_12 == "false")
            {
                Application.DoEvents();
                Thread.Sleep(2000);
                this.�15���������16�13_2.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                Application.DoEvents();
                Thread.Sleep(2000);
                this.�15���������16�13_1.BackgroundImage = ControlElementImages.lampType5OnRed;
                this.�15���������16�13_12.BackgroundImage = null;

                Application.DoEvents();
                Thread.Sleep(2000);
                this.�15���������16�13_2.BackgroundImage = ControlElementImages.lampType5OnRed;
                this.�15���������16�13_1.BackgroundImage = null;
            }            
            ����15�������13_2 = "true";            
            ����15�������13_1 = "false";            
            ����15�������13_12 = "false";
            N15Parameters.�15���������16�13_1 = "false";
            N15Parameters.�15���������16�13_2 = "true";
            N15Parameters.�15���������16�13_12 = "false";

           
        }

        private void �15�������13_12_Click(object sender, EventArgs e)
        {
            this.�15�������13_12.Visible = false;
            this.�15�������13_1.Visible = true;
            this.�15�������13_2.Visible = true;

            if (����15�������13_1 == "false" && ����15�������13_2 == "false")
            {
                Application.DoEvents();
                Thread.Sleep(2000);
                this.�15���������16�13_12.BackgroundImage = ControlElementImages.lampType5OnRed;
            }
            else
            {
                Application.DoEvents();
                Thread.Sleep(2000);
                this.�15���������16�13_2.BackgroundImage = ControlElementImages.lampType5OnRed;
                this.�15���������16�13_1.BackgroundImage = null;

                Application.DoEvents();
                Thread.Sleep(2000);
                this.�15���������16�13_12.BackgroundImage = ControlElementImages.lampType5OnRed;
                this.�15���������16�13_2.BackgroundImage = null;
            }
            
            ����15�������13_12 = "true";            
            ����15�������13_1 = "false";            
            ����15�������13_2 = "false";

            N15Parameters.�15���������16�13_1 = "false";
            N15Parameters.�15���������16�13_2 = "false";
            N15Parameters.�15���������16�13_12 = "true";        
        }

        private void �15�����������_MouseUp(object sender, MouseEventArgs e)
        {
            this.�15�����������.BackgroundImage = ControlElementImages.buttonSquareType1UpWhite;
            this.�15�����������.Text = "�����";

            this.�15�������13_1.Visible = true;
            //����15�������13_1 = "false";
            this.�15�������13_2.Visible = true;
            //����15�������13_2 = "false";
            this.�15�������13_12.Visible = true;
            //����15�������13_12 = "false";
        }

        private void �15�����������_MouseDown(object sender, MouseEventArgs e)
        {
            this.�15�����������.BackgroundImage = null;
            this.�15�����������.Text = "";
        }
        #endregion

        private void N15Form_Load(object sender, EventArgs e)
        {
            ����15��������300�1 = N15Parameters.�15��������300�1;
            ����15��������300�2 = N15Parameters.�15��������300�2;
            ����15��������300�3 = N15Parameters.�15��������300�3;
            ����15��������300�4 = N15Parameters.�15��������300�4;
            ����15��������12� = N15Parameters.�15��������12�;
            ����15���������� = N15Parameters.�15����������;
            ����15����������_1 = N15Parameters.�15����������_1;
            ����15����������_2 = N15Parameters.�15����������_2;
            ����15��������205 = N15Parameters.�15��������205;
            ����15��������20512 = N15Parameters.�15��������20512;
            ����15����������� = N15Parameters.�15�����������;
            ����15��������1 = N15Parameters.�15��������1;
            ����15��������403 = N15Parameters.�15��������403;
            ����15��������1_1 = N15Parameters.�15��������1_1;
            ����15��������1_2 = N15Parameters.�15��������1_2;
            ����15��������1_1 = N15Parameters.�15��������1_1;
            ����15��������1_2 = N15Parameters.�15��������1_2;
            ����15��������2_1 = N15Parameters.�15��������2_1;
            ����15��������2_2 = N15Parameters.�15��������2_2;
            ����15��������3_1 = N15Parameters.�15��������3_1;
            ����15��������3_2 = N15Parameters.�15��������3_2;
            ����15����������_5 = N15Parameters.�15����������_5;
            ����15��������_� = N15Parameters.�15��������_�;

            ����15�������13_1 = N15Parameters.�15�������13_1;
            ����15�������13_2 = N15Parameters.�15�������13_2;
            ����15�������13_12 = N15Parameters.�15�������13_12;
        }

        private void �15��������300�1_Click(object sender, EventArgs e)
        {
            if (����15��������300�1 == "true")
            {
                this.�15��������300�1.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                ����15��������300�1 = "false";
            }
            else
            {
                this.�15��������300�1.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                ����15��������300�1 = "true";
            }
        }

        private void �15��������300�2_Click(object sender, EventArgs e)
        {
            if (����15��������300�2 == "true")
            {
                this.�15��������300�2.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                ����15��������300�2 = "false";
            }
            else
            {
                this.�15��������300�2.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                ����15��������300�2 = "true";
            }
        }

        private void �15��������300�3_Click(object sender, EventArgs e)
        {
            if (����15��������300�3 == "true")
            {
                this.�15��������300�3.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                ����15��������300�3 = "false";
            }
            else
            {
                this.�15��������300�3.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                ����15��������300�3 = "true";
            }
        }

        private void �15��������300�4_Click(object sender, EventArgs e)
        {
            if (����15��������300�4 == "true")
            {
                this.�15��������300�4.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                ����15��������300�4 = "false";
            }
            else
            {
                this.�15��������300�4.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                ����15��������300�4 = "true";
            }
        }

        private void �15��������12�_Click(object sender, EventArgs e)
        {
            if (����15��������12� == "true")
            {
                this.�15��������12�.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                ����15��������12� = "false";
            }
            else
            {
                this.�15��������12�.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                ����15��������12� = "true";
            }
        }

        private void �15����������_Click(object sender, EventArgs e)
        {
            if (����15���������� == "true")
            {
                this.�15����������.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                ����15���������� = "false";
            }
            else
            {
                this.�15����������.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                ����15���������� = "true";
            }
        }

        private void �15����������_1_Click(object sender, EventArgs e)
        {
            if (����15����������_1 == "true")
            {
                this.�15����������_1.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                ����15����������_1 = "false";
            }
            else
            {
                this.�15����������_1.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                ����15����������_1 = "true";
            }
        }

        private void �15����������_2_Click(object sender, EventArgs e)
        {
            if (����15����������_2 == "true")
            {
                this.�15����������_2.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                ����15����������_2 = "false";
            }
            else
            {
                this.�15����������_2.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                ����15����������_2 = "true";
            }
        }

        private void �15��������205_Click(object sender, EventArgs e)
        {
            if (����15��������205 == "true")
            {
                this.�15��������205.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                ����15��������205 = "false";
            }
            else
            {
                this.�15��������205.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                ����15��������205 = "true";
            }
        }

        private void �15��������1_1_Click(object sender, EventArgs e)
        {
            if (����15��������1_1 == "true")
            {
                this.�15��������1_1.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                ����15��������1_1 = "false";
            }
            else
            {
                this.�15��������1_1.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                ����15��������1_1 = "true";
            }
        }

        private void �15��������1_2_Click(object sender, EventArgs e)
        {
            if (����15��������1_2 == "true")
            {
                this.�15��������1_2.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                ����15��������1_2 = "false";
            }
            else
            {
                this.�15��������1_2.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                ����15��������1_2 = "true";
            }
        }

        private void �15�����������_Click(object sender, EventArgs e)
        {
            if (����15����������� == "true")
            {
                this.�15�����������.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                ����15����������� = "false";
            }
            else
            {
                this.�15�����������.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                ����15����������� = "true";
            }
        }

        private void �15��������1_Click(object sender, EventArgs e)
        {
            if (����15��������1 == "true")
            {
                this.�15��������1.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                ����15��������1 = "false";
            }
            else
            {
                this.�15��������1.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                ����15��������1 = "true";
            }
        }

        private void �15��������403_Click(object sender, EventArgs e)
        {
            if (����15��������403 == "true")
            {
                this.�15��������403.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                ����15��������403 = "false";
            }
            else
            {
                this.�15��������403.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                ����15��������403 = "true";
            }
        }

        private void �15��������1_1_Click(object sender, EventArgs e)
        {
            if (����15��������1_1 == "true")
            {
                this.�15��������1_1.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                ����15��������1_1 = "false";
            }
            else
            {
                this.�15��������1_1.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                ����15��������1_1 = "true";
            }
        }

        private void �15��������1_2_Click(object sender, EventArgs e)
        {
            if (����15��������1_2 == "true")
            {
                this.�15��������1_2.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                ����15��������1_2 = "false";
            }
            else
            {
                this.�15��������1_2.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                ����15��������1_2 = "true";
            }
        }

        private void �15��������2_1_Click(object sender, EventArgs e)
        {
            if (����15��������2_1 == "true")
            {
                this.�15��������2_1.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                ����15��������2_1 = "false";
            }
            else
            {
                this.�15��������2_1.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                ����15��������2_1 = "true";
            }
        }

        private void �15��������2_2_Click(object sender, EventArgs e)
        {
            if (����15��������2_2 == "true")
            {
                this.�15��������2_2.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                ����15��������2_2 = "false";
            }
            else
            {
                this.�15��������2_2.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                ����15��������2_2 = "true";
            }
        }

        private void �15��������3_1_Click(object sender, EventArgs e)
        {
            if (����15��������3_1 == "true")
            {
                this.�15��������3_1.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                ����15��������3_1 = "false";
            }
            else
            {
                this.�15��������3_1.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                ����15��������3_1 = "true";
            }
        }

        private void �15��������3_2_Click(object sender, EventArgs e)
        {
            if (����15��������3_2 == "true")
            {
                this.�15��������3_2.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                ����15��������3_2 = "false";
            }
            else
            {
                this.�15��������3_2.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                ����15��������3_2 = "true";
            }
        }

        private void �15����������_5_Click(object sender, EventArgs e)
        {
            if (����15����������_5 == "true")
            {
                this.�15����������_5.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                ����15����������_5 = "false";
            }
            else
            {
                this.�15����������_5.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                ����15����������_5 = "true";
            }
        }

        private void �15��������_�_Click(object sender, EventArgs e)
        {
            if (����15��������_� == "true")
            {
                this.�15��������_�.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                ����15��������_� = "false";
            }
            else
            {
                this.�15��������_�.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                ����15��������_� = "true";
            }
        }

        private void �15��������20512_Click(object sender, EventArgs e)
        {
            if (����15��������20512 == "1")
            {
                this.�15��������20512.BackgroundImage = ControlElementImages.tumblerVerticalType1Down;
                ����15��������20512 = "2";
            }
            else
            {
                this.�15��������20512.BackgroundImage = ControlElementImages.tumblerVerticalType1Up;
                ����15��������20512 = "1";
            }
        }

        private void �15��������30412_Click(object sender, EventArgs e)
        {
            if (N15Parameters.�15��������30412 == "1")
            {
                this.�15��������30412.BackgroundImage = ControlElementImages.tumblerVerticalType5Down;
                N15Parameters.�15��������30412 = "2";
                if (N15Parameters.�15����������� == "true")
                {
                    N15Parameters.�15���������3042 = "true";
                    this.�15���������3042.BackgroundImage = ControlElementImages.lampType5OnRed;

                    N15Parameters.�15���������3041 = "false";
                    this.�15���������3041.BackgroundImage = null;
                    if (A30412StateChange != null)
                    {
                        A30412StateChange();
                    }
                }
            }
            else
            {
                this.�15��������30412.BackgroundImage = ControlElementImages.tumblerVerticalType5Up;
                N15Parameters.�15��������30412 = "1";
                if (N15Parameters.�15����������� == "true")
                {
                    N15Parameters.�15���������3041 = "true";
                    this.�15���������3041.BackgroundImage = ControlElementImages.lampType5OnRed;

                    N15Parameters.�15���������3042 = "false";
                    this.�15���������3042.BackgroundImage = null;
                    if (A30412StateChange != null)
                    {
                        A30412StateChange();
                    }
                }
            }
        }

        #region �������
        public delegate void VoidVoidSignature();
        /// <summary>
        /// ���������� ��������� ����� A304
        /// </summary>
        public event VoidVoidSignature A30412StateChange; 
        #endregion
    }
}