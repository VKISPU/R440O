//-----------------------------------------------------------------------
// <copyright file="B1_2Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.B1_2
{
    using System.Windows.Forms;
    using Parameters;

    /// <summary>
    /// Форма блока Б1-1
    /// </summary>
    public partial class B1_2Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="B1_2Form"/>.
        /// </summary>
        public B1_2Form()
        {
            this.InitializeComponent();
            this.InitializeTumblersPosition();
            this.InitializeButtonsPosition();
        }

        #region Кнопки
        /// <summary>
        /// Переключение кнопки скорость В ГР
        /// </summary>
        private void B1_2КнопкаСкоростьГР_Click(object sender, System.EventArgs e)
        {
            if (B1_2Parameters.B1_2КнопкаСкоростьГР)
            {
                this.B1_2КнопкаСкоростьГР.BackgroundImage = ControlElementImages.buttonRectType1;
                B1_2Parameters.B1_2КнопкаСкоростьГР = false;
            }
            else
            {
                this.B1_2КнопкаСкоростьГР.BackgroundImage = null;
                B1_2Parameters.B1_2КнопкаСкоростьГР = true;
            }
        }

        /// <summary>
        /// Переключение кнопки скорость В АБ 1ТЛФК
        /// </summary>
        private void B1_2КнопкаСкоростьАБ_1ТЛФ_К_Click(object sender, System.EventArgs e)
        {
            if (B1_2Parameters.B1_2КнопкаСкоростьАБ_1ТЛФ_К)
            {
                this.B1_2КнопкаСкоростьАБ_1ТЛФ_К.BackgroundImage = ControlElementImages.buttonRectType1;
                B1_2Parameters.B1_2КнопкаСкоростьАБ_1ТЛФ_К = false;
            }
            else
            {
                this.B1_2КнопкаСкоростьАБ_1ТЛФ_К.BackgroundImage = null;
                B1_2Parameters.B1_2КнопкаСкоростьАБ_1ТЛФ_К = true;
            }
        }
        #endregion

        #region ТЛГпр1 Колодки
        private void B1_2КолодкаТЛГпр1_1_Click(object sender, System.EventArgs e)
        {
            if (B1_2Parameters.B1_2КолодкаТЛГпр1_1)
            {
                this.B1_2КолодкаТЛГпр1_1.BackgroundImage = null;
                B1_2Parameters.B1_2КолодкаТЛГпр1_1 = false;
                this.B1_2КолодкаТЛГпр1_2.Visible = true;
            }
            else
            {
                this.B1_2КолодкаТЛГпр1_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B1_2КолодкаТЛГпр1_2.Visible = false;
                B1_2Parameters.B1_2КолодкаТЛГпр1_1 = true;
                this.B1_2КолодкаТЛГпр1_2.BackgroundImage = null;
                B1_2Parameters.B1_2КолодкаТЛГпр1_2 = false;
            }
        }

        private void B1_2КолодкаТЛГпр1_2_Click(object sender, System.EventArgs e)
        {
            if (B1_2Parameters.B1_2КолодкаТЛГпр1_2)
            {
                this.B1_2КолодкаТЛГпр1_1.Visible = true;
                this.B1_2КолодкаТЛГпр1_2.BackgroundImage = null;
                B1_2Parameters.B1_2КолодкаТЛГпр1_2 = false;
            }
            else
            {
                this.B1_2КолодкаТЛГпр1_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B1_2КолодкаТЛГпр1_1.Visible = false;
                B1_2Parameters.B1_2КолодкаТЛГпр1_2 = true;
                this.B1_2КолодкаТЛГпр1_1.BackgroundImage = null;
                B1_2Parameters.B1_2КолодкаТЛГпр1_1 = false;
            }
        }
        #endregion

        #region ТЛГпр2 Колодки
        private void B1_2КолодкаТЛГпр2_1_Click(object sender, System.EventArgs e)
        {
            if (B1_2Parameters.B1_2КолодкаТЛГпр2_1)
            {
                this.B1_2КолодкаТЛГпр2_2.Visible = true;
                this.B1_2КолодкаТЛГпр2_1.BackgroundImage = null;
                B1_2Parameters.B1_2КолодкаТЛГпр2_1 = false;
            }
            else
            {
                this.B1_2КолодкаТЛГпр2_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B1_2КолодкаТЛГпр2_2.Visible = false;
                B1_2Parameters.B1_2КолодкаТЛГпр2_1 = true;
                this.B1_2КолодкаТЛГпр2_2.BackgroundImage = null;
                B1_2Parameters.B1_2КолодкаТЛГпр2_2 = false;
            }
        }
        private void B1_2КолодкаТЛГпр2_2_Click(object sender, System.EventArgs e)
        {
            if (B1_2Parameters.B1_2КолодкаТЛГпр2_2)
            {
                this.B1_2КолодкаТЛГпр2_1.Visible = true;
                this.B1_2КолодкаТЛГпр2_2.BackgroundImage = null;
                B1_2Parameters.B1_2КолодкаТЛГпр2_2 = false;
            }
            else
            {
                this.B1_2КолодкаТЛГпр2_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B1_2КолодкаТЛГпр2_1.Visible = false;
                B1_2Parameters.B1_2КолодкаТЛГпр2_2 = true;
                this.B1_2КолодкаТЛГпр2_1.BackgroundImage = null;
                B1_2Parameters.B1_2КолодкаТЛГпр2_1 = false;
            }
        }
        #endregion

        #region ТЛГпр3 Колодки
        private void B1_2КолодкаТЛГпр3_1_Click(object sender, System.EventArgs e)
        {
            if (B1_2Parameters.B1_2КолодкаТЛГпр3_1)
            {
                this.B1_2КолодкаТЛГпр3_2.Visible = true;
                this.B1_2КолодкаТЛГпр3_1.BackgroundImage = null;
                B1_2Parameters.B1_2КолодкаТЛГпр3_1 = false;
            }
            else
            {
                this.B1_2КолодкаТЛГпр3_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B1_2КолодкаТЛГпр3_2.Visible = false;
                B1_2Parameters.B1_2КолодкаТЛГпр3_1 = true;
                this.B1_2КолодкаТЛГпр3_2.BackgroundImage = null;
                B1_2Parameters.B1_2КолодкаТЛГпр3_2 = false;
            }
        }

        private void B1_2КолодкаТЛГпр3_2_Click(object sender, System.EventArgs e)
        {
            if (B1_2Parameters.B1_2КолодкаТЛГпр3_2)
            {
                this.B1_2КолодкаТЛГпр3_1.Visible = true;
                this.B1_2КолодкаТЛГпр3_2.BackgroundImage = null;
                B1_2Parameters.B1_2КолодкаТЛГпр3_2 = false;
            }
            else
            {
                this.B1_2КолодкаТЛГпр3_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B1_2КолодкаТЛГпр3_1.Visible = false;
                B1_2Parameters.B1_2КолодкаТЛГпр3_2 = true;
                this.B1_2КолодкаТЛГпр3_1.BackgroundImage = null;
                B1_2Parameters.B1_2КолодкаТЛГпр3_1 = false;
            }
        }
        #endregion

        /// <summary>
        /// Переключение тумблера управления питанием блока
        /// </summary>
        private void B1_2ТумблерМуДу_Click(object sender, System.EventArgs e)
        {
            if (B1_2Parameters.B1_2ТумблерМуДу == "Му")
            {
                this.B1_2ТумблерМуДу.BackgroundImage = ControlElementImages.tumblerType4Down;
                B1_2Parameters.B1_2ТумблерМуДу = "Ду";
            }
            else
            {
                this.B1_2ТумблерМуДу.BackgroundImage = ControlElementImages.tumblerType4Up;
                B1_2Parameters.B1_2ТумблерМуДу = "Му";
            }
        }

        private void InitializeTumblersPosition()
        {
            this.B1_2ТумблерМуДу.BackgroundImage = B1_2Parameters.B1_2ТумблерМуДу == "Ду"
                ? ControlElementImages.tumblerType4Down
                : ControlElementImages.tumblerType4Up;
        }
        private void InitializeButtonsPosition()
        {
            this.B1_2КнопкаСкоростьГР.BackgroundImage = B1_2Parameters.B1_2КнопкаСкоростьГР
                ? null
                : ControlElementImages.buttonRectType1;

            this.B1_2КнопкаСкоростьАБ_1ТЛФ_К.BackgroundImage = B1_2Parameters.B1_2КнопкаСкоростьАБ_1ТЛФ_К
                ? null
                : ControlElementImages.buttonRectType1;

            if (B1_2Parameters.B1_2КолодкаТЛГпр1_1)
            {
                this.B1_2КолодкаТЛГпр1_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B1_2КолодкаТЛГпр1_2.Visible = false;
                this.B1_2КолодкаТЛГпр1_2.BackgroundImage = null;
            }
            else if (B1_2Parameters.B1_2КолодкаТЛГпр1_2)
            {
                this.B1_2КолодкаТЛГпр1_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B1_2КолодкаТЛГпр1_1.Visible = false;
                this.B1_2КолодкаТЛГпр1_1.BackgroundImage = null;
            }

            if (B1_2Parameters.B1_2КолодкаТЛГпр2_1)
            {
                this.B1_2КолодкаТЛГпр2_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B1_2КолодкаТЛГпр2_2.Visible = false;
                this.B1_2КолодкаТЛГпр2_2.BackgroundImage = null;
            }
            else if (B1_2Parameters.B1_2КолодкаТЛГпр2_2)
            {
                this.B1_2КолодкаТЛГпр2_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B1_2КолодкаТЛГпр2_1.Visible = false;
                this.B1_2КолодкаТЛГпр2_1.BackgroundImage = null;
            }

            if (B1_2Parameters.B1_2КолодкаТЛГпр3_1)
            {
                this.B1_2КолодкаТЛГпр3_1.BackgroundImage = ControlElementImages.jumperType1;
                this.B1_2КолодкаТЛГпр3_2.Visible = false;
                this.B1_2КолодкаТЛГпр3_2.BackgroundImage = null;
            }
            else if (B1_2Parameters.B1_2КолодкаТЛГпр3_2)
            {
                this.B1_2КолодкаТЛГпр3_2.BackgroundImage = ControlElementImages.jumperType1;
                this.B1_2КолодкаТЛГпр3_1.Visible = false;
                this.B1_2КолодкаТЛГпр3_1.BackgroundImage = null;
            }
        }
    }
}