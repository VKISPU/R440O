//-----------------------------------------------------------------------
// <copyright file="N15Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------


using System.Reflection;
using System.Threading.Tasks;
using R440O.InternalBlocks;
using R440O.R440OForms.N15Inside;
using R440O.ThirdParty;

namespace R440O.R440OForms.N15
{
    using System;
    using System.Linq;
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
            N15Parameters.ParameterChanged += RefreshForm;
            RefreshForm();
        }

        #region ������������� ��������� ����������

        private void RefreshForm()
        {
            InitializeButtons();
            InitializeTumblers();
            InitializeLamps();

            N15����������������.BackgroundImage = TransformImageHelper.RotateImageByAngle(
                    ControlElementImages.revolverRoundSmall,
                    (float)N15Parameters.����������������);
        }

        /// <summary>
        /// ��������� ������ � ��������� ��������� �� ���������
        /// </summary>
        private void InitializeButtons()
        {
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


        }

        /// <summary>
        /// ��������� ��������� � ��������� ��������� �� ���������
        /// </summary>
        private void InitializeTumblers()
        {
            PropertyInfo[] propertyList;
            foreach (Control item in Panel.Controls)
            {
                if (!item.Name.Contains("�������")) continue;
                propertyList = typeof (N15LocalParameters).GetProperties();
                foreach (var property in propertyList.Where(property => ("���" + item.Name) == property.Name
                    && !property.Name.Contains("����") && !property.Name.Contains("����") && !property.Name.Contains("5���")))
                {
                    item.BackgroundImage = (bool) property.GetValue(null)
                        ? ControlElementImages.tumblerType3Up
                        : ControlElementImages.tumblerType3Down;
                }
            }

            ��������20512.BackgroundImage = N15LocalParameters.�����������20512
                            ? ControlElementImages.tumblerType4Up
                            : ControlElementImages.tumblerType4Down;

            #region �������� ���������� ��� ������� ������ ���
            ��������503�.BackgroundImage = N15Parameters.��������503� 
                ? ControlElementImages.tumblerType3Up
                : ControlElementImages.tumblerType3Down;

            switch (N15Parameters.�������5���)
            {
                case 0:
                    �������5���.BackgroundImage = null;
                    break;
                case 1:
                    �������5���.BackgroundImage = ControlElementImages.tumblerType2Up;
                    break;
                default:
                    �������5���.BackgroundImage = ControlElementImages.tumblerType2Down;
                    break;
            }

            switch (N15Parameters.�����������)
            {
                case 0:
                    �����������.BackgroundImage = null;
                    break;
                case 1:
                    �����������.BackgroundImage = ControlElementImages.tumblerType2Up;
                    break;
                default:
                    �����������.BackgroundImage = ControlElementImages.tumblerType2Down;
                    break;
            }

            switch (N15Parameters.�����������1)
            {
                case 0:
                    �����������1.BackgroundImage = null;
                    break;
                case 1:
                    �����������1.BackgroundImage = ControlElementImages.tumblerType2Up;
                    break;
                default:
                    �����������1.BackgroundImage = ControlElementImages.tumblerType2Down;
                    break;
            }

            switch (N15Parameters.�����������2)
            {
                case 0:
                    �����������2.BackgroundImage = null;
                    break;
                case 1:
                    �����������2.BackgroundImage = ControlElementImages.tumblerType2Up;
                    break;
                default:
                    �����������2.BackgroundImage = ControlElementImages.tumblerType2Down;
                    break;
            }

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
            var d = MSHUParameters.��������������;
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

        }

        private void �15�����������_MouseDown(object sender, MouseEventArgs e)
        {
            this.�����������.BackgroundImage = null;
            this.�����������.Text = string.Empty;
        }
        #endregion

        #region ���������

        private static bool isManipulation;

        private void N15���������_MouseDown(object sender, MouseEventArgs e)
        {
            isManipulation = true;
        }

        private void N15���������_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isManipulation) return;
            var button = sender as Button;
            var angle = TransformImageHelper.CalculateAngle(button.Width, button.Height, e);
            N15Parameters.���������������� = angle;
            button.BackgroundImage = TransformImageHelper.RotateImageByAngle(
                    ControlElementImages.revolverRoundSmall,
                    (float)N15Parameters.����������������);
        }

        private void N15���������_MouseUp(object sender, MouseEventArgs e)
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
        }

        private void �������5���_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N15Parameters.�������5��� = 1;
            }
            if (e.Button == MouseButtons.Right)
            {
                N15Parameters.�������5��� = -1;
            }
        }

        private void �����������_MouseUp(object sender, MouseEventArgs e)
        {
            N15Parameters.����������� = 0;
        }

        private void �����������_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N15Parameters.����������� = 1;
            }
            if (e.Button == MouseButtons.Right)
            {
                N15Parameters.����������� = -1;
            }
        }

        private void �����������1_MouseUp(object sender, MouseEventArgs e)
        {
            N15Parameters.�����������1 = 0;
        }

        private void �����������1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N15Parameters.�����������1 = 1;
            }
            if (e.Button == MouseButtons.Right)
            {
                N15Parameters.�����������1 = -1;
            }
        }

        private void �����������2_MouseUp(object sender, MouseEventArgs e)
        {
            N15Parameters.�����������2 = 0;
        }

        private void �����������2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                N15Parameters.�����������2 = 1;
            }
            if (e.Button == MouseButtons.Right)
            {
                N15Parameters.�����������2 = -1;
            }
        }


    }
}