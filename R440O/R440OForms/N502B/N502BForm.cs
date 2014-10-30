﻿//-----------------------------------------------------------------------
// <copyright file="N502BForm.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using R440O.Parameters;

namespace R440O.R440OForms.N502B
{
    using System.Windows.Forms;

    /// <summary>
    /// Форма блока Н502Б
    /// </summary>
    public partial class N502BForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="N502BForm"/>
        /// </summary>
        public N502BForm()
        {
            this.InitializeComponent(); 
            N502BParameters.N502BТумблерОсвещение1 = "откл";
            N502BParameters.N502BТумблерОсвещение2 = "откл";
            N502BParameters.N502BКнопкаРБПСброс = "false";
            N502BParameters.N502BКнопкаВклНагрузки = "false";
            N502BParameters.N502BКнопкаРБППроверка = "false";
        }
        #region Тумблеры
        private void N502BТумблерЭлектрооборуд_Click(object sender, System.EventArgs e)
        {
            if (N502BParameters.N502BТумблерЭлектрооборуд == "true")
            {
                this.N502BТумблерЭлектрооборуд.BackgroundImage = ControlElementImages.tumblerVerticalType2Down;
                N502BParameters.N502BТумблерЭлектрооборуд = "false";
            }
            else
            {
                this.N502BТумблерЭлектрооборуд.BackgroundImage = ControlElementImages.tumblerVerticalType2Up;
                N502BParameters.N502BТумблерЭлектрооборуд = "true";
            }
        }

        private void N502BТумблерВыпрямитель27В_Click(object sender, System.EventArgs e)
        {
            if (N502BParameters.N502BТумблерВыпрямитель27В == "true")
            {
                this.N502BТумблерВыпрямитель27В.BackgroundImage = ControlElementImages.tumblerVerticalType2Down;
                N502BParameters.N502BТумблерВыпрямитель27В = "false";
            }
            else
            {
                this.N502BТумблерВыпрямитель27В.BackgroundImage = ControlElementImages.tumblerVerticalType2Up;
                N502BParameters.N502BТумблерВыпрямитель27В = "true";
            }
        }

        private void N502BТумблерОсвещение_Click(object sender, System.EventArgs e)
        {
            if (N502BParameters.N502BТумблерОсвещение == "true")
            {
                this.N502BТумблерОсвещение.BackgroundImage = ControlElementImages.tumblerVerticalType2Down;
                N502BParameters.N502BТумблерОсвещение = "false";
            }
            else
            {
                this.N502BТумблерОсвещение.BackgroundImage = ControlElementImages.tumblerVerticalType2Up;
                N502BParameters.N502BТумблерОсвещение = "true";
            }
        }

        private void N502BТумблерН13_1_Click(object sender, System.EventArgs e)
        {
            if (N502BParameters.N502BТумблерН13_1 == "true")
            {
                this.N502BТумблерН13_1.BackgroundImage = ControlElementImages.tumblerVerticalType2Down;
                N502BParameters.N502BТумблерН13_1 = "false";
            }
            else
            {
                this.N502BТумблерН13_1.BackgroundImage = ControlElementImages.tumblerVerticalType2Up;
                N502BParameters.N502BТумблерН13_1 = "true";
            }
        }

        private void N502BТумблерН13_2_Click(object sender, System.EventArgs e)
        {
            if (N502BParameters.N502BТумблерН13_2 == "true")
            {
                this.N502BТумблерН13_2.BackgroundImage = ControlElementImages.tumblerVerticalType2Down;
                N502BParameters.N502BТумблерН13_2 = "false";
            }
            else
            {
                this.N502BТумблерН13_2.BackgroundImage = ControlElementImages.tumblerVerticalType2Up;
                N502BParameters.N502BТумблерН13_2 = "true";
            }
        }

        private void N502BТумблерН15_Click(object sender, System.EventArgs e)
        {
            if (N502BParameters.N502BТумблерН15 == "true")
            {
                this.N502BТумблерН15.BackgroundImage = ControlElementImages.tumblerVerticalType2Down;
                N502BParameters.N502BТумблерН15 = "false";
            }
            else
            {
                this.N502BТумблерН15.BackgroundImage = ControlElementImages.tumblerVerticalType2Up;
                N502BParameters.N502BТумблерН15 = "true";
            }
        }

        private void N502BТумблерОсвещение1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (N502BParameters.N502BТумблерОсвещение1 == "полное")
                {
                    this.N502BТумблерОсвещение1.BackgroundImage = ControlElementImages.tumblerVerticalType4Middle;
                    N502BParameters.N502BТумблерОсвещение1 = "откл";
                }
                else
                    if (N502BParameters.N502BТумблерОсвещение1 == "откл")
                    {
                        this.N502BТумблерОсвещение1.BackgroundImage = ControlElementImages.tumblerVerticalType4Down;
                        N502BParameters.N502BТумблерОсвещение1 = "дежурное";
                    }
            }
            else
                if (e.Button == MouseButtons.Right)
                {
                    if (N502BParameters.N502BТумблерОсвещение1 == "дежурное")
                    {
                        this.N502BТумблерОсвещение1.BackgroundImage = ControlElementImages.tumblerVerticalType4Middle;
                        N502BParameters.N502BТумблерОсвещение1 = "откл";
                    }
                    else
                        if (N502BParameters.N502BТумблерОсвещение1 == "откл")
                        {
                            this.N502BТумблерОсвещение1.BackgroundImage = ControlElementImages.tumblerVerticalType4Up;
                            N502BParameters.N502BТумблерОсвещение1 = "полное";
                        }
                }
        }

        private void N502BТумблерОсвещение2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (N502BParameters.N502BТумблерОсвещение2 == "полное")
                {
                    this.N502BТумблерОсвещение2.BackgroundImage = ControlElementImages.tumblerVerticalType4Middle;
                    N502BParameters.N502BТумблерОсвещение2 = "откл";
                }
                else
                    if (N502BParameters.N502BТумблерОсвещение2 == "откл")
                    {
                        this.N502BТумблерОсвещение2.BackgroundImage = ControlElementImages.tumblerVerticalType4Down;
                        N502BParameters.N502BТумблерОсвещение2 = "частичное";
                    }
            }
            else
                if (e.Button == MouseButtons.Right)
                {
                    if (N502BParameters.N502BТумблерОсвещение2 == "частичное")
                    {
                        this.N502BТумблерОсвещение2.BackgroundImage = ControlElementImages.tumblerVerticalType4Middle;
                        N502BParameters.N502BТумблерОсвещение2 = "откл";
                    }
                    else
                        if (N502BParameters.N502BТумблерОсвещение2 == "откл")
                        {
                            this.N502BТумблерОсвещение2.BackgroundImage = ControlElementImages.tumblerVerticalType4Up;
                            N502BParameters.N502BТумблерОсвещение2 = "полное";
                        }
                }
        }
        #endregion

        #region Кнопки
        private void N502BКнопкаРБПСброс_MouseUp(object sender, MouseEventArgs e)
        {
                this.N502BКнопкаРБПСброс.BackgroundImage = ControlElementImages.buttonRoundSmall;
                if (N502BParameters.N502BКнопкаРБПСброс == "true")
                    N502BParameters.N502BКнопкаРБПСброс = "false";
                else
                    N502BParameters.N502BКнопкаРБПСброс = "true";
        }

        private void N502BКнопкаРБПСброс_MouseDown(object sender, MouseEventArgs e)
        {
            this.N502BКнопкаРБПСброс.BackgroundImage = null;
        }

        private void N502BКнопкаРБППроверка_MouseUp(object sender, MouseEventArgs e)
        {
            this.N502BКнопкаРБППроверка.BackgroundImage = ControlElementImages.buttonRoundSmall;
            if (N502BParameters.N502BКнопкаРБППроверка == "true")
                N502BParameters.N502BКнопкаРБППроверка = "false";
            else
                N502BParameters.N502BКнопкаРБППроверка = "true";
        }

        private void N502BКнопкаРБППроверка_MouseDown(object sender, MouseEventArgs e)
        {
            this.N502BКнопкаРБППроверка.BackgroundImage = null;
        }

        private void N502BКнопкаВклНагрузки_MouseUp(object sender, MouseEventArgs e)
        {
            this.N502BКнопкаВклНагрузки.BackgroundImage = ControlElementImages.buttonRoundSmall;
            if (N502BParameters.N502BКнопкаВклНагрузки == "true")
                N502BParameters.N502BКнопкаВклНагрузки = "false";
            else
                N502BParameters.N502BКнопкаВклНагрузки = "true";
        }

        private void N502BКнопкаВклНагрузки_MouseDown(object sender, MouseEventArgs e)
        {
            this.N502BКнопкаВклНагрузки.BackgroundImage = null;
        }
        #endregion

        private void N502BПереключательСеть_Click(object sender, System.EventArgs e)
        {
            if (N502BParameters.N502BПереключательСеть == "true")
            {
                this.N502BПереключательСеть.BackgroundImage = ControlElementImages.tumblerSideVerticalType2Down;
                N502BParameters.N502BПереключательСеть = "false";
            }
            else
            {
                this.N502BПереключательСеть.BackgroundImage = ControlElementImages.tumblerSideVerticalType2Up;
                N502BParameters.N502BПереключательСеть = "true";
            }
        }
    }
}