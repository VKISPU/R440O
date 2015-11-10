//-----------------------------------------------------------------------
// <copyright file="N15Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------


using System.Reflection;
using System.Runtime.InteropServices;
using R440O.InternalBlocks;
using R440O.R440OForms.N15Inside;
using R440O.R440OForms.N16;
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
            N15Parameters.IndicatorChanged += RefreshIndicator;
            RefreshFormElements();
        }

        #region ������������� ��������� ����������

        public void RefreshIndicator()
        {
            var angle = N15Parameters.����������������������� * 1.05F;
            �����������������������.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.arrow2, angle);
        }

        public void RefreshFormElements()
        {
            RefreshIndicator();
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

            �������13_1.Visible = !N15LocalParameters.����������13_1;
            �������13_2.Visible = !N15LocalParameters.����������13_2;
            �������13_12.Visible = !N15LocalParameters.����������13_12;
        }

        /// <summary>
        /// ��������� ��������� � ��������� ��������� �� ���������
        /// </summary>
        private void InitializeTumblers()
        {

            //�������� ����� ����� ��� ������� ��������� ������� �� ������ ���
            foreach (Control item in Panel.Controls)
            {
                if (!item.Name.Contains("�������")) continue;
                var propertyList = typeof (N15LocalParameters).GetProperties();
                foreach (var property in propertyList.Where(property => ("���" + item.Name) == property.Name
                                                                        && !property.Name.Contains("5���") &&
                                                                        !property.Name.Contains("������") &&
                                                                        !property.Name.Contains("�20512")))
                {
                    item.BackgroundImage = (bool) property.GetValue(null)
                        ? ControlElementImages.tumblerType3Up
                        : ControlElementImages.tumblerType3Down;
                }
            }

            ��������20512.BackgroundImage = N15LocalParameters.�����������20512
                ? ControlElementImages.tumblerType4Up
                : ControlElementImages.tumblerType4Down;


             //�������� ����� � ������ ����� ��� ������� �� ��������� ������� �� ������ ���
            ��������30412.BackgroundImage = N15Parameters.��������30412
                ? ControlElementImages.tumblerType3Up
                : ControlElementImages.tumblerType3Down;

            ��������503�.BackgroundImage = N15Parameters.��������503�
                ? ControlElementImages.tumblerType3Up
                : ControlElementImages.tumblerType3Down;

            �������������.BackgroundImage = N15LocalParameters.����������������
                ? ControlElementImages.tumblerType4Up
                : ControlElementImages.tumblerType4Down;

            ����������������.BackgroundImage = N15Parameters.����������������
                ? ControlElementImages.tumblerType4Up
                : ControlElementImages.tumblerType4Down;

            ����������������.BackgroundImage = N15Parameters.����������������
                ? ControlElementImages.tumblerType4Up
                : ControlElementImages.tumblerType4Down;

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
                var propertyList = typeof(N15Parameters).GetProperties();
                foreach (var property in propertyList.Where(property => item.Name == property.Name))
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
            foreach (var property in propertyList.Where(property => ("���" + item.Name) == property.Name && !item.Name.Contains("�20512")))
            {
                item.BackgroundImage = (bool)property.GetValue(null)
                        ? ControlElementImages.tumblerType3Up
                        : ControlElementImages.tumblerType3Down;
            }

            ��������20512.BackgroundImage = N15LocalParameters.�����������20512
                ? ControlElementImages.tumblerType4Up
                : ControlElementImages.tumblerType4Down;
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
                foreach (var property in parametersList.Where(property => localProperty.Name.Contains(property.Name) && localProperty.Name != "����������5���"
                    && localProperty.Name != "����������13_1" && localProperty.Name != "����������13_2" && localProperty.Name != "����������13_12" && localProperty.Name != "����������������"))
                {
                    property.SetValue(this, localProperty.GetValue(this));
                }
            }

            N15Parameters.�13_1 = (N15LocalParameters.����������13_1 || N15LocalParameters.����������13_12);
            N15Parameters.�13_2 = (N15LocalParameters.����������13_2 || N15LocalParameters.����������13_12);
        }

        private void ResetCurrentParameters()
        {
            var parametersList = typeof(N15Parameters).GetProperties();

            foreach (var property in parametersList.Where(property => property.Name.Contains("�������")
                && !property.Name.Contains("�503�") && !property.Name.Contains("����")
                && !property.Name.Contains("����") && !property.Name.Contains("5���")
                && !property.Name.Contains("������") && !property.Name.Contains("������")
                && !property.Name.Contains("�30412")))
            {
                property.SetValue(this, false);
            }

            N15Parameters.�13_1 = false;
            N15Parameters.�13_2 = false;
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
        private void �������13_1_Click(object sender, EventArgs e)
        {
            this.�������13_1.Visible = false;
            this.�������13_2.Visible = true;
            this.�������13_12.Visible = true;

            N15LocalParameters.����������13_1 = true;
            N15LocalParameters.����������13_2 = false;
            N15LocalParameters.����������13_12 = false;
            N16Parameters.������������13 = 1;
        }

        private void �������13_2_Click(object sender, EventArgs e)
        {
            this.�������13_2.Visible = false;
            this.�������13_1.Visible = true;
            this.�������13_12.Visible = true;

            N15LocalParameters.����������13_1 = false;
            N15LocalParameters.����������13_2 = true;
            N15LocalParameters.����������13_12 = false;
            N16Parameters.������������13 = 2;
        }

        private void �������13_12_Click(object sender, EventArgs e)
        {
            this.�������13_12.Visible = false;
            this.�������13_1.Visible = true;
            this.�������13_2.Visible = true;

            N15LocalParameters.����������13_1 = false;
            N15LocalParameters.����������13_2 = false;
            N15LocalParameters.����������13_12 = true;
            N16Parameters.������������13 = 3;
        }

        private void �����������_MouseUp(object sender, MouseEventArgs e)
        {
            N15Parameters.�������13 = 0;
            this.�����������.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.�����������.Text = "�����";
        }

        private void �����������_MouseDown(object sender, MouseEventArgs e)
        {
            this.�����������.BackgroundImage = null;
            this.�����������.Text = string.Empty;

            N15LocalParameters.����������13_1 = false;
            N15LocalParameters.����������13_2 = false;
            N15LocalParameters.����������13_12 = false;
            N16Parameters.������������13 = 0;
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
        private void ��������30412_Click(object sender, EventArgs e)
        {
            N15Parameters.��������30412 = !N15Parameters.��������30412;
        }

        private void ��������503�_Click(object sender, EventArgs e)
        {
            N15Parameters.��������503� = !N15Parameters.��������503�;
        }

        private void �������������_Click(object sender, EventArgs e)
        {
            N15LocalParameters.���������������� = !N15LocalParameters.����������������;
            N16Parameters.������������������������� = N15LocalParameters.����������������;
        }

        private void ����������������_Click(object sender, EventArgs e)
        {
            N15Parameters.���������������� = !N15Parameters.����������������;
        }

        private void ����������������_Click(object sender, EventArgs e)
        {
            N15Parameters.���������������� = !N15Parameters.����������������;
        }

        #region �������� � 3 �����������
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
        #endregion
        #endregion

        private void N15Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            N15Parameters.ParameterChanged -= RefreshFormElements;
        }



    }
}