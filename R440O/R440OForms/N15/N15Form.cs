//-----------------------------------------------------------------------
// <copyright file="N15Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using System.Linq;
using System.Threading.Tasks;
using R440O.R440OForms.N15Inside;

namespace R440O.R440OForms.N15
{
    using System;
    using System.Windows.Forms;

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
            N15Parameters.RefreshForm += InitializeForm;
            N15LocalParameters.RefreshFormElement += RefreshFormElement;
            InitializeForm();
        }

        #region ������������� ��������� ����������

        private void InitializeForm()
        {
            InitializeButtons();
            InitializeTumblers();
            InitializeLamps();
        }

        /// <summary>
        /// ��������� ������ � ��������� ��������� �� ���������
        /// </summary>
        private void InitializeButtons()
        {
            foreach (Control item in Panel.Controls)
            {
                if (!item.Name.Contains("������")) continue;
                var fieldList = typeof(N15Parameters).GetProperties();
                foreach (var property in fieldList.Where(property => item.Name == property.Name))
                {
                    var val = !(bool)property.GetValue(null);
                    item.Visible = val;
                    break;
                }
            }

            foreach (Control item in Panel.Controls)
            {
                if (!item.Name.Contains("������")) continue;
                var fieldList = typeof(N15LocalParameters).GetProperties();
                foreach (var property in fieldList.Where(property => property.Name.Contains(item.Name)))
                {
                    var val = !(bool)property.GetValue(null);
                    item.Visible = val;
                    break;
                }
            }
        }

        /// <summary>
        /// ��������� ��������� � ��������� ��������� �� ���������
        /// </summary>
        private void InitializeTumblers()
        {
            foreach (Control item in Panel.Controls)
            {
                if (!item.Name.Contains("�������")) continue;
                var propertyList = typeof(N15LocalParameters).GetProperties();
                foreach (var property in propertyList.Where(property => ("���" + item.Name) == property.Name))
                {
                    if (item.Name.Contains("��������20512") ||
                        item.Name.Contains("�������������") ||
                        item.Name.Contains("����������������") ||
                        item.Name.Contains("����������������"))
                    {
                        item.BackgroundImage = (bool)property.GetValue(null)
                            ? ControlElementImages.tumblerType4Up
                            : ControlElementImages.tumblerType4Down;
                    }
                    else
                    {
                        item.BackgroundImage = (bool)property.GetValue(null)
                            ? ControlElementImages.tumblerType3Up
                            : ControlElementImages.tumblerType3Down;
                    }
                }
            }
        }

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
                        item.Name.Contains("��1") || item.Name.Contains("A205"))
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

        private void RefreshFormElement(string parameterName)
        {
            var item = Panel.Controls.Find(parameterName, false)[0];
            if (item == null) return;
            if (!item.Name.Contains("�������")) return;

            var propertyList = typeof (N15LocalParameters).GetProperties();
            foreach (var property in propertyList.Where(property => ("���" + item.Name) == property.Name))
            {
                if (item.Name.Contains("��������20512") ||
                    item.Name.Contains("�������������") ||
                    item.Name.Contains("����������������") ||
                    item.Name.Contains("����������������"))
                {
                    item.BackgroundImage = (bool) property.GetValue(null)
                        ? ControlElementImages.tumblerType4Up
                        : ControlElementImages.tumblerType4Down;
                }
                else
                {
                    item.BackgroundImage = (bool) property.GetValue(null)
                        ? ControlElementImages.tumblerType3Up
                        : ControlElementImages.tumblerType3Down;
                }
            }
        }
        

        /// <summary>
        /// �������������� ��������� ��������� ������� � ������������ � ����������� ����������
        /// </summary>
        private void ResetCurrentParameters()
        {
            var parametersList = typeof(N15Parameters).GetProperties();
            var localParametersList = typeof(N15LocalParameters).GetProperties();
            foreach (var localProperty in localParametersList)
            {
                foreach (var property in parametersList.Where(property => localProperty.Name.Contains(property.Name)))
                {
                    property.SetValue(this, localProperty.GetValue(this));
                }
            }
        }

        #endregion

        #region ��������� � ���������� ������ �������, �������� �����

        private void ����������������_MouseDown(object sender, MouseEventArgs e)
        {
            this.����������������.BackgroundImage = null;
        }

        private void ����������������_MouseUp(object sender, MouseEventArgs e)
        {
            this.����������������.BackgroundImage = ControlElementImages.buttonN15On;
            ResetCurrentParameters();
            N15Parameters.ResetParameters();
        }

        private void �15�����������������_MouseDown(object sender, MouseEventArgs e)
        {
            this.�����������������.BackgroundImage = null;
        }

        private void �15�����������������_MouseUp(object sender, MouseEventArgs e)
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

        private void �15�������������������300�1_Click(object sender, EventArgs e)
        {
            N15Parameters.�������������������300�1 = true;
            N15Parameters.�������������������300�2 = false;
            N15Parameters.�������������������300�3 = false;
            N15Parameters.�������������������300�4 = false;
            N15Parameters.���������������16 = false;
            N15Parameters.����������������� = false;
        }

        private void �15�������������������300�2_Click(object sender, EventArgs e)
        {
            N15Parameters.�������������������300�1 = false;
            N15Parameters.�������������������300�2 = true;
            N15Parameters.�������������������300�3 = false;
            N15Parameters.�������������������300�4 = false;
            N15Parameters.���������������16 = false;
            N15Parameters.����������������� = false;
        }

        private void �15�������������������300�3_Click(object sender, EventArgs e)
        {
            N15Parameters.�������������������300�1 = false;
            N15Parameters.�������������������300�2 = false;
            N15Parameters.�������������������300�3 = true;
            N15Parameters.�������������������300�4 = false;
            N15Parameters.���������������16 = false;
            N15Parameters.����������������� = false;
        }

        private void �15�������������������300�4_Click(object sender, EventArgs e)
        {
            N15Parameters.�������������������300�1 = false;
            N15Parameters.�������������������300�2 = false;
            N15Parameters.�������������������300�3 = false;
            N15Parameters.�������������������300�4 = true;
            N15Parameters.���������������16 = false;
            N15Parameters.����������������� = false;
        }

        private void �15���������������16_Click(object sender, EventArgs e)
        {
            N15Parameters.�������������������300�1 = false;
            N15Parameters.�������������������300�2 = false;
            N15Parameters.�������������������300�3 = false;
            N15Parameters.�������������������300�4 = false;
            N15Parameters.���������������16 = true;
            N15Parameters.����������������� = false;
        }

        private void �15�����������������_Click(object sender, EventArgs e)
        {
            N15Parameters.�������������������300�1 = false;
            N15Parameters.�������������������300�2 = false;
            N15Parameters.�������������������300�3 = false;
            N15Parameters.�������������������300�4 = false;
            N15Parameters.���������������16 = false;
            N15Parameters.����������������� = true;
        }

        private void �15�������������������_MouseDown(object sender, MouseEventArgs e)
        {
            this.�������������������.BackgroundImage = null;
            this.�������������������.Text = string.Empty;
        }

        private void �15�������������������_MouseUp(object sender, MouseEventArgs e)
        {
            this.�������������������.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.�������������������.Text = "�����";
            N15Parameters.�������������������300�1 = false;
            N15Parameters.�������������������300�2 = false;
            N15Parameters.�������������������300�3 = false;
            N15Parameters.�������������������300�4 = false;
            N15Parameters.���������������16 = false;
            N15Parameters.����������������� = false;
        }

        #endregion

        #region ������ �13-1 �13-2 �13-1,2 �����
        private async void �15�������13_1_Click(object sender, EventArgs e)
        {

            this.�������13_1.Visible = false;
            this.�������13_2.Visible = true;
            this.�������13_12.Visible = true;

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

            N15Parameters.�������13_1 = true;
            N15Parameters.�������13_2 = false;
            N15Parameters.�������13_12 = false;

            N15Parameters.���������16�13_1 = true;
            N15Parameters.���������16�13_2 = false;
            N15Parameters.���������16�13_12 = false;

        }

        private async void �15�������13_2_Click(object sender, EventArgs e)
        {
            this.�������13_2.Visible = false;
            this.�������13_1.Visible = true;
            this.�������13_12.Visible = true;

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

            N15Parameters.�������13_1 = false;
            N15Parameters.�������13_2 = true;
            N15Parameters.�������13_12 = false;

            N15Parameters.���������16�13_1 = false;
            N15Parameters.���������16�13_2 = true;
            N15Parameters.���������16�13_12 = false;

        }

        private async void �15�������13_12_Click(object sender, EventArgs e)
        {
            this.�������13_12.Visible = false;
            this.�������13_1.Visible = true;
            this.�������13_2.Visible = true;

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

            N15Parameters.�������13_1 = false;
            N15Parameters.�������13_2 = false;
            N15Parameters.�������13_12 = true;

            N15Parameters.���������16�13_1 = false;
            N15Parameters.���������16�13_2 = false;
            N15Parameters.���������16�13_12 = true;

        }

        private async void �15�����������_MouseUp(object sender, MouseEventArgs e)
        {
            this.�����������.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.�����������.Text = "�����";

            this.�������13_1.Visible = true;
            this.�������13_2.Visible = true;
            this.�������13_12.Visible = true;

            await Task.Delay(300);
            this.���������16�13_1.BackgroundImage = null;
            this.���������16�13_2.BackgroundImage = null;
            this.���������16�13_12.BackgroundImage = null;

            N15Parameters.�������13_1 = false;
            N15Parameters.�������13_2 = false;
            N15Parameters.�������13_12 = false;

            N15Parameters.���������16�13_1 = false;
            N15Parameters.���������16�13_2 = false;
            N15Parameters.���������16�13_12 = false;

        }

        private void �15�����������_MouseDown(object sender, MouseEventArgs e)
        {
            this.�����������.BackgroundImage = null;
            this.�����������.Text = string.Empty;
        }
        #endregion

        private void �������_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            var localParameter = typeof(N15LocalParameters).GetProperty("���" + button.Name);
            var newValue = !(bool)localParameter.GetValue(null);
            localParameter.SetValue(null, newValue);
        }
    }
}