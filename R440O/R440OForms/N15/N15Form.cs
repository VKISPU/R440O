//-----------------------------------------------------------------------
// <copyright file="N15Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------


using System.Reflection;
using System.Threading.Tasks;
using R440O.InternalBlocks;
using R440O.R440OForms.N15Inside;
using R440O.R440OForms.N502B;
using R440O.ThirdParty;

namespace R440O.R440OForms.N15
{
    using BaseClasses;
    using System;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// ����� ����� �-15
    /// </summary>
    public partial class N15Form : Form, IRefreshableForm
    {
        /// <summary>
        /// �������������� ����� ��������� ������ <see cref="N15Form"/>
        /// </summary>
        public N15Form()
        {
            this.InitializeComponent();
            N15Parameters.ParameterChanged += RefreshFormElements;
            RefreshFormElements();
        }

        #region ������������� ��������� ����������

        public void RefreshFormElements()
        {
            InitializeButtons();
            InitializeTumblers();
            InitializeLamps();

            ����������������.BackgroundImage = TransformImageHelper.RotateImageByAngle(
                    ControlElementImages.revolverRoundSmall,
                    (float)N15Parameters.����������������);
        }

        /// <summary>
        /// ��������� ������ � ��������� ��������� �� ���������
        /// </summary>
        private void InitializeButtons()
        {
            �������������������300�1.Visible = !N15Parameters.�������������������300�1;
            �������������������300�2.Visible = !N15Parameters.�������������������300�2;
            �������������������300�3.Visible = !N15Parameters.�������������������300�3;
            �������������������300�4.Visible = !N15Parameters.�������������������300�4;
            �����������������.Visible = !N15Parameters.�����������������;
            ���������������16.Visible = !N15Parameters.���������������16;

            �������13_1.Visible = !N15Parameters.�������13_1;
            �������13_2.Visible = !N15Parameters.�������13_2;
            �������13_12.Visible = !N15Parameters.�������13_12;
        }

        /// <summary>
        /// ��������� ��������� � ��������� ��������� �� ���������
        /// </summary>
        private void InitializeTumblers()
        {
            PropertyInfo[] propertyList;
            foreach (Control item in Panel.Controls)
            {
                if (!item.Name.Contains("�������") || item.Name.Contains("�������5���") || item.Name.Contains("�������������")) continue;
                propertyList = typeof(N15LocalParameters).GetProperties();
                foreach (var property in propertyList.Where(property => ("���" + item.Name) == property.Name
                                         && !property.Name.Contains("5���") && !property.Name.Contains("������")))
                {
                    item.BackgroundImage = (bool)property.GetValue(null)
                        ? ControlElementImages.tumblerType3Up
                        : ControlElementImages.tumblerType3Down;
                }
            }

            ��������20512.BackgroundImage = N15LocalParameters.�����������20512
                            ? ControlElementImages.tumblerType4Up
                            : ControlElementImages.tumblerType4Down;

            ��������30412.BackgroundImage = N15Parameters.��������30412
                            ? ControlElementImages.tumblerType3Up
                            : ControlElementImages.tumblerType3Down;

            #region �������� ���������� ��� ������� ������ ���

            ��������503�.BackgroundImage = N15Parameters.��������503�
                ? ControlElementImages.tumblerType3Up
                : ControlElementImages.tumblerType3Down;

            �����������.BackgroundImage = null;
            �����������1.BackgroundImage = null;
            �����������2.BackgroundImage = null;
            �������5���.BackgroundImage = null;

            �������������.BackgroundImage = N15Parameters.�������������
                            ? ControlElementImages.tumblerType4Up
                            : ControlElementImages.tumblerType4Down;

            ����������������.BackgroundImage = N15Parameters.����������������
                            ? ControlElementImages.tumblerType4Up
                            : ControlElementImages.tumblerType4Down;

            ����������������.BackgroundImage = N15Parameters.����������������
                            ? ControlElementImages.tumblerType4Up
                            : ControlElementImages.tumblerType4Down;
            #endregion

        }

        private string List;

        /// <summary>
        /// ��������� �������� � ��������� ��������� �� ���������
        /// </summary>
        private void InitializeLamps()
        {
            foreach (Control item in Panel.Controls)
            {
                if (!item.Name.Contains("��������")) continue;
                var fieldList = typeof(N15Parameters).GetProperties();
                foreach (var property in fieldList.Where(property => item.Name == property.Name))
                {
                    if (item.Name.Contains("�300�") || item.Name.Contains("���") || item.Name.Contains("�205") ||
                        item.Name.Contains("��1"))
                    {
                        item.BackgroundImage = (bool)property.GetValue(null)
                            ? ControlElementImages.lampType8OnRed
                            : null;
                    }
                    else
                    {
                        item.BackgroundImage = (bool)property.GetValue(null)
                            ? ControlElementImages.lampType5OnRed
                            : null;
                    }
                    break;
                }
            }
        }
        #endregion

        #region ���������� ��������� ����������

        /// <summary>
        /// ����������� ��������� ���������, ������� ���������� ����� ������ �������.���.
        /// </summary>
        /// <param name="parameterName"></param>
        private void RefreshFormElement(string parameterName)
        {
            var item = Panel.Controls.Find(parameterName, false)[0];
            if (item == null) return;
            if (!item.Name.Contains("�������")) return;

            var propertyList = typeof(N15LocalParameters).GetProperties();
            foreach (var property in propertyList.Where(property => ("���" + item.Name) == property.Name))
            {
                item.BackgroundImage = (bool)property.GetValue(null)
                        ? ControlElementImages.tumblerType3Up
                        : ControlElementImages.tumblerType3Down;
            }

            ��������20512.BackgroundImage = N15LocalParameters.�����������20512
                            ? ControlElementImages.tumblerType4Up
                            : ControlElementImages.tumblerType4Down;
        }

        private void ��������30412_Click(object sender, EventArgs e)
        {
            N15Parameters.��������30412 = !N15Parameters.��������30412;
        }



        /// <summary>
        /// �������������� ��������� ��������� ������� � ������������ � ����������� ����������
        /// </summary>
        private void SetCurrentParameters()
        {
            var parametersList = typeof(N15Parameters).GetProperties();
            var localParametersList = typeof(N15LocalParameters).GetProperties();
            foreach (var localProperty in localParametersList)
            {
                foreach (var property in parametersList.Where(property => localProperty.Name.Contains(property.Name) && localProperty.Name != "����������5���" && localProperty.Name != "����������������"))
                {
                    property.SetValue(this, localProperty.GetValue(this));
                }
            }
        }

        private void ResetCurrentParameters()
        {
            var parametersList = typeof(N15Parameters).GetProperties();
            foreach (var property in parametersList.Where(property => property.Name.Contains("�������")
                && !property.Name.Contains("�503�") && !property.Name.Contains("����")
                && !property.Name.Contains("����") && !property.Name.Contains("5���")
                && !property.Name.Contains("������") && !property.Name.Contains("������")))
            {
                property.SetValue(this, false);
            }
        }

        #endregion

        #region ��������� � ���������� ������ �������, �������� �����

        private void ����������������_MouseDown(object sender, MouseEventArgs e)
        {
            this.����������������.BackgroundImage = null;
            SetCurrentParameters();
            N15Parameters.ResetParameters();
        }

        private void ����������������_MouseUp(object sender, MouseEventArgs e)
        {
            this.����������������.BackgroundImage = ControlElementImages.buttonN15On;
            var d = MSHUParameters.��������������;
        }

        private void �����������������_MouseDown(object sender, MouseEventArgs e)
        {
            this.�����������������.BackgroundImage = null;
            ResetCurrentParameters();
            N15Parameters.ResetParameters();
        }

        private void �����������������_MouseUp(object sender, MouseEventArgs e)
        {
            this.�����������������.BackgroundImage = ControlElementImages.buttonN15Off;

        }

        private void N15ButtonInside1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form thisForm = new N15InsideForm();
            thisForm.Show(this);
        }

        private void N15ButtonInside2_Click(object sender, EventArgs e)
        {
            N15ButtonInside1_Click(sender, e);
        }

        #endregion

        #region ������ ��� ���������/�300� 1 2 3 4 � �������� �16 ��� �����

        private void �������������������300�1_Click(object sender, EventArgs e)
        {
            N15Parameters.�������������������300�1 = true;
            N15Parameters.�������������������300�2 = false;
            N15Parameters.�������������������300�3 = false;
            N15Parameters.�������������������300�4 = false;
            N15Parameters.���������������16 = false;
            N15Parameters.����������������� = false;
        }

        private void �������������������300�2_Click(object sender, EventArgs e)
        {
            N15Parameters.�������������������300�1 = false;
            N15Parameters.�������������������300�2 = true;
            N15Parameters.�������������������300�3 = false;
            N15Parameters.�������������������300�4 = false;
            N15Parameters.���������������16 = false;
            N15Parameters.����������������� = false;
        }

        private void �������������������300�3_Click(object sender, EventArgs e)
        {
            N15Parameters.�������������������300�1 = false;
            N15Parameters.�������������������300�2 = false;
            N15Parameters.�������������������300�3 = true;
            N15Parameters.�������������������300�4 = false;
            N15Parameters.���������������16 = false;
            N15Parameters.����������������� = false;
        }

        private void �������������������300�4_Click(object sender, EventArgs e)
        {
            N15Parameters.�������������������300�1 = false;
            N15Parameters.�������������������300�2 = false;
            N15Parameters.�������������������300�3 = false;
            N15Parameters.�������������������300�4 = true;
            N15Parameters.���������������16 = false;
            N15Parameters.����������������� = false;
        }

        private void ���������������16_Click(object sender, EventArgs e)
        {
            N15Parameters.�������������������300�1 = false;
            N15Parameters.�������������������300�2 = false;
            N15Parameters.�������������������300�3 = false;
            N15Parameters.�������������������300�4 = false;
            N15Parameters.���������������16 = true;
            N15Parameters.����������������� = false;
        }

        private void �����������������_Click(object sender, EventArgs e)
        {
            N15Parameters.�������������������300�1 = false;
            N15Parameters.�������������������300�2 = false;
            N15Parameters.�������������������300�3 = false;
            N15Parameters.�������������������300�4 = false;
            N15Parameters.���������������16 = false;
            N15Parameters.����������������� = true;
        }

        private void �������������������_MouseDown(object sender, MouseEventArgs e)
        {
            this.�������������������.BackgroundImage = null;
            this.�������������������.Text = string.Empty;

            N15Parameters.�������������������300�1 = false;
            N15Parameters.�������������������300�2 = false;
            N15Parameters.�������������������300�3 = false;
            N15Parameters.�������������������300�4 = false;
            N15Parameters.���������������16 = false;
            N15Parameters.����������������� = false;
        }

        private void �������������������_MouseUp(object sender, MouseEventArgs e)
        {
            this.�������������������.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.�������������������.Text = "�����";
        }

        #endregion

        #region ������ �13-1 �13-2 �13-1,2 �����
        private async void �������13_1_Click(object sender, EventArgs e)
        {

            this.�������13_1.Visible = false;
            this.�������13_2.Visible = true;
            this.�������13_12.Visible = true;
            if (N15Parameters.�����������������)
            {
                if (N15Parameters.�������13_2 == false && N15Parameters.�������13_12 == false)
                {
                    await Task.Delay(300);
                    this.���������16�13_1.BackgroundImage = ControlElementImages.lampType5OnRed;
                }
                else
                {
                    await Task.Delay(300);
                    this.���������16�13_12.BackgroundImage = ControlElementImages.lampType5OnRed;
                    this.���������16�13_2.BackgroundImage = null;

                    await Task.Delay(300);
                    this.���������16�13_1.BackgroundImage = ControlElementImages.lampType5OnRed;
                    this.���������16�13_12.BackgroundImage = null;
                }
            }


            N15Parameters.�������13_1 = true;
            N15Parameters.�������13_2 = false;
            N15Parameters.�������13_12 = false;
        }

        private async void �������13_2_Click(object sender, EventArgs e)
        {
            this.�������13_2.Visible = false;
            this.�������13_1.Visible = true;
            this.�������13_12.Visible = true;

            if (N15Parameters.�����������������)
            {
                if (N15Parameters.�������13_1 == false && N15Parameters.�������13_12 == false)
                {
                    await Task.Delay(300);
                    this.���������16�13_2.BackgroundImage = ControlElementImages.lampType5OnRed;
                }
                else
                {
                    await Task.Delay(300);
                    this.���������16�13_1.BackgroundImage = ControlElementImages.lampType5OnRed;
                    this.���������16�13_12.BackgroundImage = null;

                    await Task.Delay(300);
                    this.���������16�13_2.BackgroundImage = ControlElementImages.lampType5OnRed;
                    this.���������16�13_1.BackgroundImage = null;
                }

            }

            N15Parameters.�������13_1 = false;
            N15Parameters.�������13_2 = true;
            N15Parameters.�������13_12 = false;
        }

        private async void �������13_12_Click(object sender, EventArgs e)
        {
            this.�������13_12.Visible = false;
            this.�������13_1.Visible = true;
            this.�������13_2.Visible = true;

            if (N15Parameters.�����������������)
            {
                if (N15Parameters.�������13_1 == false && N15Parameters.�������13_2 == false)
                {
                    await Task.Delay(300);
                    this.���������16�13_12.BackgroundImage = ControlElementImages.lampType5OnRed;
                }
                else
                {
                    await Task.Delay(300);
                    this.���������16�13_2.BackgroundImage = ControlElementImages.lampType5OnRed;
                    this.���������16�13_1.BackgroundImage = null;

                    await Task.Delay(300);
                    this.���������16�13_12.BackgroundImage = ControlElementImages.lampType5OnRed;
                    this.���������16�13_2.BackgroundImage = null;
                }
            }

            N15Parameters.�������13_1 = false;
            N15Parameters.�������13_2 = false;
            N15Parameters.�������13_12 = true;
        }

        private void �����������_MouseUp(object sender, MouseEventArgs e)
        {
            this.�����������.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.�����������.Text = "�����";
        }

        private async void �����������_MouseDown(object sender, MouseEventArgs e)
        {
            this.�����������.BackgroundImage = null;
            this.�����������.Text = string.Empty;

            N15Parameters.�������13_1 = false;
            N15Parameters.�������13_2 = false;
            N15Parameters.�������13_12 = false;


        }
        #endregion

        #region ���������

        private static bool isManipulation;

        private void ���������_MouseDown(object sender, MouseEventArgs e)
        {
            isManipulation = true;
        }

        private void ���������_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isManipulation) return;
            var button = sender as Button;
            var angle = TransformImageHelper.CalculateAngle(button.Width, button.Height, e);
            N15Parameters.���������������� = angle;
            button.BackgroundImage = TransformImageHelper.RotateImageByAngle(
                    ControlElementImages.revolverRoundSmall,
                    (float)N15Parameters.����������������);
        }

        private void ���������_MouseUp(object sender, MouseEventArgs e)
        {
            isManipulation = false;
        }
        #endregion

        #region ������� �� ��������
        private void �������_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            var localParameter = typeof(N15LocalParameters).GetProperty("���" + button.Name);
            var newValue = !(bool)localParameter.GetValue(null);
            localParameter.SetValue(null, newValue);
            RefreshFormElement(button.Name);
        }

        private void ��������503�_Click(object sender, EventArgs e)
        {
            N15Parameters.��������503� = !N15Parameters.��������503�;
        }

        private void �������������_Click(object sender, EventArgs e)
        {
            N15Parameters.������������� = !N15Parameters.�������������;
        }

        private void ����������������_Click(object sender, EventArgs e)
        {
            N15Parameters.���������������� = !N15Parameters.����������������;
        }

        private void ����������������_Click(object sender, EventArgs e)
        {
            N15Parameters.���������������� = !N15Parameters.����������������;
        }

        #endregion

        private void �������5���_MouseUp(object sender, MouseEventArgs e)
        {
            N15Parameters.�������5��� = 0;
            �������5���.BackgroundImage = null;
        }

        private void �������5���_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N15Parameters.�������5��� = 1;
                �������5���.BackgroundImage = ControlElementImages.tumblerType2Down;
            }
            if (e.Button == MouseButtons.Right)
            {
                N15Parameters.�������5��� = -1;
                �������5���.BackgroundImage = ControlElementImages.tumblerType2Up;
            }
        }

        private void �����������_MouseUp(object sender, MouseEventArgs e)
        {
            N15Parameters.����������� = 0;
            �����������.BackgroundImage = null;
        }

        private void �����������_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N15Parameters.����������� = 1;
                �����������.BackgroundImage = ControlElementImages.tumblerType2Down;
            }
            if (e.Button == MouseButtons.Right)
            {
                N15Parameters.����������� = -1;
                �����������.BackgroundImage = ControlElementImages.tumblerType2Up;
            }
        }

        private void �����������1_MouseUp(object sender, MouseEventArgs e)
        {
            N15Parameters.�����������1 = 0;
            �����������1.BackgroundImage = null;
        }

        private void �����������1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N15Parameters.�����������1 = 1;
                �����������1.BackgroundImage = ControlElementImages.tumblerType2Down;
            }
            if (e.Button == MouseButtons.Right)
            {
                N15Parameters.�����������1 = -1;
                �����������1.BackgroundImage = ControlElementImages.tumblerType2Up;
            }
        }

        private void �����������2_MouseUp(object sender, MouseEventArgs e)
        {
            N15Parameters.�����������2 = 0;
            �����������2.BackgroundImage = null;
        }

        private void �����������2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N15Parameters.�����������2 = 1;
                �����������2.BackgroundImage = ControlElementImages.tumblerType2Down;
            }
            if (e.Button == MouseButtons.Right)
            {
                N15Parameters.�����������2 = -1;
                �����������2.BackgroundImage = ControlElementImages.tumblerType2Up;
            }
        }

        private void N15Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            N15Parameters.ParameterChanged -= RefreshFormElements;
        }



    }
}