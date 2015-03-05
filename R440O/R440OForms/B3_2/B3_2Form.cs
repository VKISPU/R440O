//-----------------------------------------------------------------------
// <copyright file="B3_2Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------
using System.Reflection;
using System.Windows.Forms;

namespace R440O.R440OForms.B3_2
{
    using System;
    using Parameters;

    /// <summary>
    /// Форма блока Б3-1
    /// </summary>
    public partial class B3_2Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="B3_2Form"/>
        /// </summary>
        public B3_2Form()
        {
            InitializeComponent();
            InitializeButtonsPosition();
            InitializeTumblersPosition();
        }

        #region Колодки УКК1 и УКК2
        private void B3_2КолодкаУКК_Click(object sender, EventArgs e)
        {
            var button = sender as Button;

            var numberOfButton = (int)Char.GetNumericValue(button.Name[16]);
            var numberOfComplect = button.Name[14];

            PropertyInfo Property = typeof(B3_2Parameters).GetProperty("B3_2КолодкаУКК" + numberOfComplect);

            int value = (int)Property.GetValue(null);

            if (value != 0)
            {
                var oldButton = B3_2Panel.Controls.Find("B3_2КолодкаУКК" + numberOfComplect + "_" + value, true)[0] as Button;
                oldButton.BackgroundImage = null;
            }

            if (numberOfButton == value)
            {
                Property.SetValue(null, 0);
                button.BackgroundImage = null;
            }
            else
            {
                Property.SetValue(null, numberOfButton);
                button.BackgroundImage = ControlElementImages.jumperType2;
            }
        }
        #endregion

        #region Колодки КРПР
        private void B3_2КолодкаКРПР_Click(object sender, EventArgs e)
        {
            var button = sender as Button;

            var numberOfButton = (int)Char.GetNumericValue(button.Name[16]);

            PropertyInfo Property = typeof(B3_2Parameters).GetProperty("B3_2КолодкаКРПР");

            var value = (int)Property.GetValue(null);

            if (value != 0)
            {
                var oldButton = B3_2Panel.Controls.Find("B3_2КолодкаКРПР_" + value, true)[0] as Button;
                oldButton.BackgroundImage = null;
            }

            if (numberOfButton == value)
            {
                Property.SetValue(null, 0);
                button.BackgroundImage = null;
            }
            else
            {
                Property.SetValue(null, numberOfButton);
                button.BackgroundImage = ControlElementImages.jumperType2;
            }
        }
        #endregion

        #region ОКпр1 Колодки
        private void B3_2КолодкаОКпр1_син_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаОКпр1_син)
            {
                this.B3_2КолодкаОКпр1_син.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаОКпр1_син = false;
            }
            else
            {
                this.B3_2КолодкаОКпр1_син.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаОКпр1_син = true;
                this.B3_2КолодкаОКпр1_ас.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаОКпр1_ас = false;
            }
        }

        private void B3_2КолодкаОКпр1_ас_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаОКпр1_ас)
            {
                this.B3_2КолодкаОКпр1_ас.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаОКпр1_ас = false;
            }
            else
            {
                this.B3_2КолодкаОКпр1_ас.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаОКпр1_ас = true;
                this.B3_2КолодкаОКпр1_син.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаОКпр1_син = false;
            }
        }
        #endregion

        #region ОКпр2 Колодки
        private void B3_2КолодкаОКпр2_син_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаОКпр2_син)
            {
                B3_2КолодкаОКпр2_син.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаОКпр2_син = false;
            }
            else
            {
                B3_2КолодкаОКпр2_син.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаОКпр2_син = true;
                B3_2КолодкаОКпр2_ас.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаОКпр2_ас = false;
            }
        }

        private void B3_2КолодкаОКпр2_ас_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаОКпр2_ас)
            {
                B3_2КолодкаОКпр2_ас.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаОКпр2_ас = false;
            }
            else
            {
                B3_2КолодкаОКпр2_ас.BackgroundImage = ControlElementImages.jumperType2;
                B3_2Parameters.B3_2КолодкаОКпр2_ас = true;
                B3_2КолодкаОКпр2_син.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаОКпр2_син = false;
            }
        }
        #endregion


        #region ТЛГпр1 Колодки
        private void B3_2КолодкаТЛГпр1_1_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаТЛГпр1_1)
            {
                this.B3_2КолодкаТЛГпр1_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаТЛГпр1_1 = false;
                this.B3_2КолодкаТЛГпр1_2.Visible = true;
            }
            else
            {
                this.B3_2КолодкаТЛГпр1_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B3_2КолодкаТЛГпр1_2.Visible = false;
                B3_2Parameters.B3_2КолодкаТЛГпр1_1 = true;
                this.B3_2КолодкаТЛГпр1_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаТЛГпр1_2 = false;
            }
        }

        private void B3_2КолодкаТЛГпр1_2_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаТЛГпр1_2)
            {
                this.B3_2КолодкаТЛГпр1_1.Visible = true;
                this.B3_2КолодкаТЛГпр1_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаТЛГпр1_2 = false;
            }
            else
            {
                this.B3_2КолодкаТЛГпр1_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B3_2КолодкаТЛГпр1_1.Visible = false;
                B3_2Parameters.B3_2КолодкаТЛГпр1_2 = true;
                this.B3_2КолодкаТЛГпр1_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаТЛГпр1_1 = false;
            }
        }
        #endregion

        #region ТЛГпр2 Колодки
        private void B3_2КолодкаТЛГпр2_1_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаТЛГпр2_1)
            {
                this.B3_2КолодкаТЛГпр2_2.Visible = true;
                this.B3_2КолодкаТЛГпр2_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаТЛГпр2_1 = false;
            }
            else
            {
                this.B3_2КолодкаТЛГпр2_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B3_2КолодкаТЛГпр2_2.Visible = false;
                B3_2Parameters.B3_2КолодкаТЛГпр2_1 = true;
                this.B3_2КолодкаТЛГпр2_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаТЛГпр2_2 = false;
            }
        }
        private void B3_2КолодкаТЛГпр2_2_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаТЛГпр2_2)
            {
                this.B3_2КолодкаТЛГпр2_1.Visible = true;
                this.B3_2КолодкаТЛГпр2_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаТЛГпр2_2 = false;
            }
            else
            {
                this.B3_2КолодкаТЛГпр2_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B3_2КолодкаТЛГпр2_1.Visible = false;
                B3_2Parameters.B3_2КолодкаТЛГпр2_2 = true;
                this.B3_2КолодкаТЛГпр2_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаТЛГпр2_1 = false;
            }
        }
        #endregion

        #region ТЛГпр3 Колодки
        private void B3_2КолодкаТЛГпр3_1_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаТЛГпр3_1)
            {
                this.B3_2КолодкаТЛГпр3_2.Visible = true;
                this.B3_2КолодкаТЛГпр3_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаТЛГпр3_1 = false;
            }
            else
            {
                this.B3_2КолодкаТЛГпр3_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B3_2КолодкаТЛГпр3_2.Visible = false;
                B3_2Parameters.B3_2КолодкаТЛГпр3_1 = true;
                this.B3_2КолодкаТЛГпр3_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаТЛГпр3_2 = false;
            }
        }

        private void B3_2КолодкаТЛГпр3_2_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2КолодкаТЛГпр3_2)
            {
                this.B3_2КолодкаТЛГпр3_1.Visible = true;
                this.B3_2КолодкаТЛГпр3_2.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаТЛГпр3_2 = false;
            }
            else
            {
                this.B3_2КолодкаТЛГпр3_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B3_2КолодкаТЛГпр3_1.Visible = false;
                B3_2Parameters.B3_2КолодкаТЛГпр3_2 = true;
                this.B3_2КолодкаТЛГпр3_1.BackgroundImage = null;
                B3_2Parameters.B3_2КолодкаТЛГпр3_1 = false;
            }
        }
        #endregion

        private void B3_2ТумблерМуДу_Click(object sender, System.EventArgs e)
        {
            if (B3_2Parameters.B3_2ТумблерМуДу == "Му")
            {
                this.B3_2ТумблерМуДу.BackgroundImage = ControlElementImages.tumblerType4Down;
                B3_2Parameters.B3_2ТумблерМуДу = "Ду";
            }
            else
            {
                this.B3_2ТумблерМуДу.BackgroundImage = ControlElementImages.tumblerType4Up;
                B3_2Parameters.B3_2ТумблерМуДу = "Му";
            }
        }

        private void InitializeButtonsPosition()
        {
            foreach (Control item in B3_2Panel.Controls)
            {
                if (item.Name.Contains("B3_2КолодкаУКК1"))
                    item.BackgroundImage = (item.Name.Contains("B3_2КолодкаУКК1_" + B3_2Parameters.B3_2КолодкаУКК1))
                    ? ControlElementImages.jumperType2
                    : null;

                if (item.Name.Contains("B3_2КолодкаУКК2"))
                    item.BackgroundImage = (item.Name.Contains("B3_2КолодкаУКК2_" + B3_2Parameters.B3_2КолодкаУКК2))
                    ? ControlElementImages.jumperType2
                    : null;

                if (item.Name.Contains("B3_2КолодкаКРПР"))
                    item.BackgroundImage = (item.Name.Contains("B3_2КолодкаКРПР_" + B3_2Parameters.B3_2КолодкаКРПР))
                    ? ControlElementImages.jumperType2
                    : null;
            }

            if (B3_2Parameters.B3_2КолодкаОКпр1_син)
                B3_2КолодкаОКпр1_син.BackgroundImage = ControlElementImages.jumperType2;
            else if (B3_2Parameters.B3_2КолодкаОКпр1_ас)
                B3_2КолодкаОКпр1_син.BackgroundImage = ControlElementImages.jumperType2;

            if (B3_2Parameters.B3_2КолодкаОКпр2_син)
                B3_2КолодкаОКпр2_син.BackgroundImage = ControlElementImages.jumperType2;
            else if (B3_2Parameters.B3_2КолодкаОКпр2_ас)
                B3_2КолодкаОКпр2_син.BackgroundImage = ControlElementImages.jumperType2;


            if (B3_2Parameters.B3_2КолодкаТЛГпр1_1)
            {
                this.B3_2КолодкаТЛГпр1_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B3_2КолодкаТЛГпр1_2.Visible = false;
            }
            else if (B3_2Parameters.B3_2КолодкаТЛГпр1_2)
            {
                this.B3_2КолодкаТЛГпр1_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B3_2КолодкаТЛГпр1_1.Visible = false;
            }

            if (B3_2Parameters.B3_2КолодкаТЛГпр2_1)
            {
                this.B3_2КолодкаТЛГпр2_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B3_2КолодкаТЛГпр2_2.Visible = false;
            }
            else if (B3_2Parameters.B3_2КолодкаТЛГпр2_2)
            {
                this.B3_2КолодкаТЛГпр2_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B3_2КолодкаТЛГпр2_1.Visible = false;
            }

            if (B3_2Parameters.B3_2КолодкаТЛГпр3_1)
            {
                this.B3_2КолодкаТЛГпр3_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B3_2КолодкаТЛГпр3_2.Visible = false;
            }
            else if (B3_2Parameters.B3_2КолодкаТЛГпр3_2)
            {
                this.B3_2КолодкаТЛГпр3_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B3_2КолодкаТЛГпр3_1.Visible = false;
            }
        }

        private void InitializeTumblersPosition()
        {
            this.B3_2ТумблерМуДу.BackgroundImage = B3_2Parameters.B3_2ТумблерМуДу == "Ду"
                ? ControlElementImages.tumblerType4Down
                : ControlElementImages.tumblerType4Up;
        }

    }
}