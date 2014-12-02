//-----------------------------------------------------------------------
// <copyright file="A403_1Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

namespace R440O.R440OForms.A403_1
{
    using System.Windows.Forms;
    using Parameters;
    using ThirdParty;

    /// <summary>
    /// Форма блока А403-1
    /// </summary>
    public partial class A403_1Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="A403_1Form"/>.
        /// </summary>
        public A403_1Form()
        {
            this.InitializeComponent();
            this.InitializeTumblersPosition();
            this.InitializeTogglesPosition();
        }

        #region Тумблеры
        private void A403_1ТумблерСеть_Click(object sender, System.EventArgs e)
        {
            if (A403_1Parameters.A403_1ТумблерСеть == "сеть")
            {
                this.A403_1ТумблерСеть.BackgroundImage = ControlElementImages.tumblerType6Down;
                A403_1Parameters.A403_1ТумблерСеть = "откл";
            }
            else
            {
                this.A403_1ТумблерСеть.BackgroundImage = ControlElementImages.tumblerType6Up;
                A403_1Parameters.A403_1ТумблерСеть = "сеть";
            }
        }

        private void A403_1ТумблерКомплект_Click(object sender, System.EventArgs e)
        {
            if (A403_1Parameters.A403_1ТумблерКомплект == "1")
            {
                this.A403_1ТумблерКомплект.BackgroundImage = ControlElementImages.tumblerType2Right;
                A403_1Parameters.A403_1ТумблерКомплект = "2";
            }
            else
            {
                this.A403_1ТумблерКомплект.BackgroundImage = ControlElementImages.tumblerType2Left;
                A403_1Parameters.A403_1ТумблерКомплект = "1";
            }
        }

        private void A403_1ТумблерГотов_Click(object sender, System.EventArgs e)
        {
            if (A403_1Parameters.A403_1ТумблерГотов == "готов")
            {
                this.A403_1ТумблерГотов.BackgroundImage = ControlElementImages.tumblerType4Down;
                A403_1Parameters.A403_1ТумблерГотов = "откл";
            }
            else
            {
                this.A403_1ТумблерГотов.BackgroundImage = ControlElementImages.tumblerType4Up;
                A403_1Parameters.A403_1ТумблерГотов = "готов";
            }
        }

        private void A403_1ТумблерГруппа_Click(object sender, System.EventArgs e)
        {
            if (A403_1Parameters.A403_1ТумблерГруппа == "1группа")
            {
                this.A403_1ТумблерГруппа.BackgroundImage = ControlElementImages.tumblerType4Down;
                A403_1Parameters.A403_1ТумблерГруппа = "2группа";
            }
            else
            {
                this.A403_1ТумблерГруппа.BackgroundImage = ControlElementImages.tumblerType4Up;
                A403_1Parameters.A403_1ТумблерГруппа = "1группа";
            }
        }

        private void A403_1ТумблерАвтКоррекция_Click(object sender, System.EventArgs e)
        {
            if (A403_1Parameters.A403_1ТумблерАвтКоррекция == "автКоррекция")
            {
                this.A403_1ТумблерАвтКоррекция.BackgroundImage = ControlElementImages.tumblerType4Down;
                A403_1Parameters.A403_1ТумблерАвтКоррекция = "откл";
            }
            else
            {
                this.A403_1ТумблерАвтКоррекция.BackgroundImage = ControlElementImages.tumblerType4Up;
                A403_1Parameters.A403_1ТумблерАвтКоррекция = "автКоррекция";
            }
        }
        #endregion

        #region Кнопки
        private void A403_1Кнопка1_MouseDown(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка1.BackgroundImage = null;
            this.A403_1Кнопка1.Text = string.Empty;
        }

        private void A403_1Кнопка1_MouseUp(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка1.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.A403_1Кнопка1.Text = "1";
        }

        private void A403_1Кнопка2_MouseDown(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка2.BackgroundImage = null;
            this.A403_1Кнопка2.Text = string.Empty;
        }

        private void A403_1Кнопка2_MouseUp(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка2.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.A403_1Кнопка2.Text = "2";
        }

        private void A403_1Кнопка3_MouseDown(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка3.BackgroundImage = null;
            this.A403_1Кнопка3.Text = string.Empty;
        }

        private void A403_1Кнопка3_MouseUp(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка3.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.A403_1Кнопка3.Text = "3";
        }

        private void A403_1Кнопка4_MouseDown(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка4.BackgroundImage = null;
            this.A403_1Кнопка4.Text = string.Empty;
        }

        private void A403_1Кнопка4_MouseUp(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка4.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.A403_1Кнопка4.Text = "4";
        }

        private void A403_1Кнопка5_MouseDown(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка5.BackgroundImage = null;
            this.A403_1Кнопка5.Text = string.Empty;
        }

        private void A403_1Кнопка5_MouseUp(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка5.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.A403_1Кнопка5.Text = "5";
        }

        private void A403_1Кнопка6_MouseDown(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка6.BackgroundImage = null;
            this.A403_1Кнопка6.Text = string.Empty;
        }

        private void A403_1Кнопка6_MouseUp(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка6.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.A403_1Кнопка6.Text = "6";
        }

        private void A403_1Кнопка7_MouseDown(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка7.BackgroundImage = null;
            this.A403_1Кнопка7.Text = string.Empty;
        }

        private void A403_1Кнопка7_MouseUp(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка7.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.A403_1Кнопка7.Text = "7";
        }

        private void A403_1Кнопка8_MouseDown(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка8.BackgroundImage = null;
            this.A403_1Кнопка8.Text = string.Empty;
        }

        private void A403_1Кнопка8_MouseUp(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка8.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.A403_1Кнопка8.Text = "8";
        }

        private void A403_1Кнопка9_MouseDown(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка9.BackgroundImage = null;
            this.A403_1Кнопка9.Text = string.Empty;
        }

        private void A403_1Кнопка9_MouseUp(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка9.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.A403_1Кнопка9.Text = "9";
        }

        private void A403_1Кнопка0_MouseDown(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка0.BackgroundImage = null;
            this.A403_1Кнопка0.Text = string.Empty;
        }

        private void A403_1Кнопка0_MouseUp(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка0.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.A403_1Кнопка0.Text = "0";
        }

        private void A403_1КнопкаМинус_MouseDown(object sender, MouseEventArgs e)
        {
            this.A403_1КнопкаМинус.BackgroundImage = null;
            this.A403_1КнопкаМинус.Text = string.Empty;
        }

        private void A403_1КнопкаМинус_MouseUp(object sender, MouseEventArgs e)
        {
            this.A403_1КнопкаМинус.BackgroundImage = ControlElementImages.buttonSquareWhite;
            this.A403_1КнопкаМинус.Text = "–";
        }

        private void A403_1КнопкаАlpha_Lambda_Click(object sender, System.EventArgs e)
        {
            this.A403_1КнопкаАlpha_Lambda.Visible = false;
            switch (A403_1Parameters.A403_1ТумблерГруппа)
            {
                case "1группа": A403_1Parameters.A403_1КнопкаАlpha_Lambda = "alpha";
                    break;
                case "2группа": A403_1Parameters.A403_1КнопкаАlpha_Lambda = "lambda";
                    break;
                default: A403_1Parameters.A403_1КнопкаАlpha_Lambda = "false";
                    break;
            }

            this.A403_1КнопкаEpsilon_Phi.Visible = true;
            A403_1Parameters.A403_1КнопкаEpsilon_Phi = "false";
            this.A403_1КнопкаI_H.Visible = true;
            A403_1Parameters.A403_1КнопкаI_H = "false";
            this.A403_1КнопкаOmega_N.Visible = true;
            A403_1Parameters.A403_1КнопкаOmega_N = "false";
            this.A403_1КнопкаLambda0_f.Visible = true;
            A403_1Parameters.A403_1КнопкаLambda0_f = "false";
            this.A403_1Кнопкаt0_K.Visible = true;
            A403_1Parameters.A403_1Кнопкаt0_K = "false";
            this.A403_1КнопкаT_Kbeta.Visible = true;
            A403_1Parameters.A403_1КнопкаT_Kbeta = "false";
            this.A403_1Кнопкаtсв_Yalpha.Visible = true;
            A403_1Parameters.A403_1Кнопкаtсв_Yalpha = "false";
            this.A403_1Кнопкаtуст_Ybeta.Visible = true;
            A403_1Parameters.A403_1Кнопкаtуст_Ybeta = "false";
        }

        private void A403_1КнопкаEpsilon_Phi_Click(object sender, System.EventArgs e)
        {
            this.A403_1КнопкаАlpha_Lambda.Visible = true;
            A403_1Parameters.A403_1КнопкаАlpha_Lambda = "false";

            this.A403_1КнопкаEpsilon_Phi.Visible = false;
            switch (A403_1Parameters.A403_1ТумблерГруппа)
            {
                case "1группа": A403_1Parameters.A403_1КнопкаEpsilon_Phi = "epsilon";
                    break;
                case "2группа": A403_1Parameters.A403_1КнопкаEpsilon_Phi = "phi";
                    break;
                default: A403_1Parameters.A403_1КнопкаEpsilon_Phi = "false";
                    break;
            }
            
            this.A403_1КнопкаI_H.Visible = true;
            A403_1Parameters.A403_1КнопкаI_H = "false";
            this.A403_1КнопкаOmega_N.Visible = true;
            A403_1Parameters.A403_1КнопкаOmega_N = "false";
            this.A403_1КнопкаLambda0_f.Visible = true;
            A403_1Parameters.A403_1КнопкаLambda0_f = "false";
            this.A403_1Кнопкаt0_K.Visible = true;
            A403_1Parameters.A403_1Кнопкаt0_K = "false";
            this.A403_1КнопкаT_Kbeta.Visible = true;
            A403_1Parameters.A403_1КнопкаT_Kbeta = "false";
            this.A403_1Кнопкаtсв_Yalpha.Visible = true;
            A403_1Parameters.A403_1Кнопкаtсв_Yalpha = "false";
            this.A403_1Кнопкаtуст_Ybeta.Visible = true;
            A403_1Parameters.A403_1Кнопкаtуст_Ybeta = "false";
        }

        private void A403_1КнопкаI_H_Click(object sender, System.EventArgs e)
        {
            this.A403_1КнопкаАlpha_Lambda.Visible = true;
            A403_1Parameters.A403_1КнопкаАlpha_Lambda = "false";
            this.A403_1КнопкаEpsilon_Phi.Visible = true;
            A403_1Parameters.A403_1КнопкаEpsilon_Phi = "false";

            this.A403_1КнопкаI_H.Visible = false;
            switch (A403_1Parameters.A403_1ТумблерГруппа)
            {
                case "1группа": A403_1Parameters.A403_1КнопкаI_H = "i";
                    break;
                case "2группа": A403_1Parameters.A403_1КнопкаI_H = "H";
                    break;
                default: A403_1Parameters.A403_1КнопкаI_H = "false";
                    break;
            }

            this.A403_1КнопкаOmega_N.Visible = true;
            A403_1Parameters.A403_1КнопкаOmega_N = "false";
            this.A403_1КнопкаLambda0_f.Visible = true;
            A403_1Parameters.A403_1КнопкаLambda0_f = "false";
            this.A403_1Кнопкаt0_K.Visible = true;
            A403_1Parameters.A403_1Кнопкаt0_K = "false";
            this.A403_1КнопкаT_Kbeta.Visible = true;
            A403_1Parameters.A403_1КнопкаT_Kbeta = "false";
            this.A403_1Кнопкаtсв_Yalpha.Visible = true;
            A403_1Parameters.A403_1Кнопкаtсв_Yalpha = "false";
            this.A403_1Кнопкаtуст_Ybeta.Visible = true;
            A403_1Parameters.A403_1Кнопкаtуст_Ybeta = "false";
        }

        private void A403_1КнопкаOmega_N_Click(object sender, System.EventArgs e)
        {
            this.A403_1КнопкаАlpha_Lambda.Visible = true;
            A403_1Parameters.A403_1КнопкаАlpha_Lambda = "false";
            this.A403_1КнопкаEpsilon_Phi.Visible = true;
            A403_1Parameters.A403_1КнопкаEpsilon_Phi = "false";
            this.A403_1КнопкаI_H.Visible = true;
            A403_1Parameters.A403_1КнопкаI_H = "false";

            this.A403_1КнопкаOmega_N.Visible = false;
            switch (A403_1Parameters.A403_1ТумблерГруппа)
            {
                case "1группа": A403_1Parameters.A403_1КнопкаOmega_N = "omega";
                    break;
                case "2группа": A403_1Parameters.A403_1КнопкаOmega_N = "N";
                    break;
                default: A403_1Parameters.A403_1КнопкаOmega_N = "false";
                    break;
            }

            this.A403_1КнопкаLambda0_f.Visible = true;
            A403_1Parameters.A403_1КнопкаLambda0_f = "false";
            this.A403_1Кнопкаt0_K.Visible = true;
            A403_1Parameters.A403_1Кнопкаt0_K = "false";
            this.A403_1КнопкаT_Kbeta.Visible = true;
            A403_1Parameters.A403_1КнопкаT_Kbeta = "false";
            this.A403_1Кнопкаtсв_Yalpha.Visible = true;
            A403_1Parameters.A403_1Кнопкаtсв_Yalpha = "false";
            this.A403_1Кнопкаtуст_Ybeta.Visible = true;
            A403_1Parameters.A403_1Кнопкаtуст_Ybeta = "false";
        }

        private void A403_1КнопкаLambda0_f_Click(object sender, System.EventArgs e)
        {
            this.A403_1КнопкаАlpha_Lambda.Visible = true;
            A403_1Parameters.A403_1КнопкаАlpha_Lambda = "false";
            this.A403_1КнопкаEpsilon_Phi.Visible = true;
            A403_1Parameters.A403_1КнопкаEpsilon_Phi = "false";
            this.A403_1КнопкаI_H.Visible = true;
            A403_1Parameters.A403_1КнопкаI_H = "false";
            this.A403_1КнопкаOmega_N.Visible = true;
            A403_1Parameters.A403_1КнопкаOmega_N = "false";

            this.A403_1КнопкаLambda0_f.Visible = false;
            switch (A403_1Parameters.A403_1ТумблерГруппа)
            {
                case "1группа": A403_1Parameters.A403_1КнопкаLambda0_f = "lambda0";
                    break;
                case "2группа": A403_1Parameters.A403_1КнопкаLambda0_f = "f";
                    break;
                default: A403_1Parameters.A403_1КнопкаLambda0_f = "false";
                    break;
            }

            this.A403_1Кнопкаt0_K.Visible = true;
            A403_1Parameters.A403_1Кнопкаt0_K = "false";
            this.A403_1КнопкаT_Kbeta.Visible = true;
            A403_1Parameters.A403_1КнопкаT_Kbeta = "false";
            this.A403_1Кнопкаtсв_Yalpha.Visible = true;
            A403_1Parameters.A403_1Кнопкаtсв_Yalpha = "false";
            this.A403_1Кнопкаtуст_Ybeta.Visible = true;
            A403_1Parameters.A403_1Кнопкаtуст_Ybeta = "false";
        }

        private void A403_1Кнопкаt0_K_Click(object sender, System.EventArgs e)
        {
            this.A403_1КнопкаАlpha_Lambda.Visible = true;
            A403_1Parameters.A403_1КнопкаАlpha_Lambda = "false";
            this.A403_1КнопкаEpsilon_Phi.Visible = true;
            A403_1Parameters.A403_1КнопкаEpsilon_Phi = "false";
            this.A403_1КнопкаI_H.Visible = true;
            A403_1Parameters.A403_1КнопкаI_H = "false";
            this.A403_1КнопкаOmega_N.Visible = true;
            A403_1Parameters.A403_1КнопкаOmega_N = "false";
            this.A403_1КнопкаLambda0_f.Visible = true;
            A403_1Parameters.A403_1КнопкаLambda0_f = "false";

            this.A403_1Кнопкаt0_K.Visible = false;
            switch (A403_1Parameters.A403_1ТумблерГруппа)
            {
                case "1группа": A403_1Parameters.A403_1Кнопкаt0_K = "t0";
                    break;
                case "2группа": A403_1Parameters.A403_1Кнопкаt0_K = "K";
                    break;
                default: A403_1Parameters.A403_1Кнопкаt0_K = "false";
                    break;
            }

            this.A403_1КнопкаT_Kbeta.Visible = true;
            A403_1Parameters.A403_1КнопкаT_Kbeta = "false";
            this.A403_1Кнопкаtсв_Yalpha.Visible = true;
            A403_1Parameters.A403_1Кнопкаtсв_Yalpha = "false";
            this.A403_1Кнопкаtуст_Ybeta.Visible = true;
            A403_1Parameters.A403_1Кнопкаtуст_Ybeta = "false";
        }

        private void A403_1КнопкаT_Kbeta_Click(object sender, System.EventArgs e)
        {
            this.A403_1КнопкаАlpha_Lambda.Visible = true;
            A403_1Parameters.A403_1КнопкаАlpha_Lambda = "false";
            this.A403_1КнопкаEpsilon_Phi.Visible = true;
            A403_1Parameters.A403_1КнопкаEpsilon_Phi = "false";
            this.A403_1КнопкаI_H.Visible = true;
            A403_1Parameters.A403_1КнопкаI_H = "false";
            this.A403_1КнопкаOmega_N.Visible = true;
            A403_1Parameters.A403_1КнопкаOmega_N = "false";
            this.A403_1КнопкаLambda0_f.Visible = true;
            A403_1Parameters.A403_1КнопкаLambda0_f = "false";
            this.A403_1Кнопкаt0_K.Visible = true;
            A403_1Parameters.A403_1Кнопкаt0_K = "false";

            this.A403_1КнопкаT_Kbeta.Visible = false;
            switch (A403_1Parameters.A403_1ТумблерГруппа)
            {
                case "1группа": A403_1Parameters.A403_1КнопкаT_Kbeta = "T";
                    break;
                case "2группа": A403_1Parameters.A403_1КнопкаT_Kbeta = "Kbeta";
                    break;
                default: A403_1Parameters.A403_1КнопкаT_Kbeta = "false";
                    break;
            }

            this.A403_1Кнопкаtсв_Yalpha.Visible = true;
            A403_1Parameters.A403_1Кнопкаtсв_Yalpha = "false";
            this.A403_1Кнопкаtуст_Ybeta.Visible = true;
            A403_1Parameters.A403_1Кнопкаtуст_Ybeta = "false";
        }

        private void A403_1Кнопкаtсв_Yalpha_Click(object sender, System.EventArgs e)
        {
            this.A403_1КнопкаАlpha_Lambda.Visible = true;
            A403_1Parameters.A403_1КнопкаАlpha_Lambda = "false";
            this.A403_1КнопкаEpsilon_Phi.Visible = true;
            A403_1Parameters.A403_1КнопкаEpsilon_Phi = "false";
            this.A403_1КнопкаI_H.Visible = true;
            A403_1Parameters.A403_1КнопкаI_H = "false";
            this.A403_1КнопкаOmega_N.Visible = true;
            A403_1Parameters.A403_1КнопкаOmega_N = "false";
            this.A403_1КнопкаLambda0_f.Visible = true;
            A403_1Parameters.A403_1КнопкаLambda0_f = "false";
            this.A403_1Кнопкаt0_K.Visible = true;
            A403_1Parameters.A403_1Кнопкаt0_K = "false";
            this.A403_1КнопкаT_Kbeta.Visible = true;
            A403_1Parameters.A403_1КнопкаT_Kbeta = "false";

            this.A403_1Кнопкаtсв_Yalpha.Visible = false;
            switch (A403_1Parameters.A403_1ТумблерГруппа)
            {
                case "1группа": A403_1Parameters.A403_1Кнопкаtсв_Yalpha = "tсв";
                    break;
                case "2группа": A403_1Parameters.A403_1Кнопкаtсв_Yalpha = "Yalpha";
                    break;
                default: A403_1Parameters.A403_1Кнопкаtсв_Yalpha = "false";
                    break;
            }

            this.A403_1Кнопкаtуст_Ybeta.Visible = true;
            A403_1Parameters.A403_1Кнопкаtуст_Ybeta = "false";
        }

        private void A403_1Кнопкаtуст_Ybeta_Click(object sender, System.EventArgs e)
        {
            this.A403_1КнопкаАlpha_Lambda.Visible = true;
            A403_1Parameters.A403_1КнопкаАlpha_Lambda = "false";
            this.A403_1КнопкаEpsilon_Phi.Visible = true;
            A403_1Parameters.A403_1КнопкаEpsilon_Phi = "false";
            this.A403_1КнопкаI_H.Visible = true;
            A403_1Parameters.A403_1КнопкаI_H = "false";
            this.A403_1КнопкаOmega_N.Visible = true;
            A403_1Parameters.A403_1КнопкаOmega_N = "false";
            this.A403_1КнопкаLambda0_f.Visible = true;
            A403_1Parameters.A403_1КнопкаLambda0_f = "false";
            this.A403_1Кнопкаt0_K.Visible = true;
            A403_1Parameters.A403_1Кнопкаt0_K = "false";
            this.A403_1КнопкаT_Kbeta.Visible = true;
            A403_1Parameters.A403_1КнопкаT_Kbeta = "false";
            this.A403_1Кнопкаtсв_Yalpha.Visible = true;
            A403_1Parameters.A403_1Кнопкаtсв_Yalpha = "false";

            this.A403_1Кнопкаtуст_Ybeta.Visible = false;
            switch (A403_1Parameters.A403_1ТумблерГруппа)
            {
                case "1группа": A403_1Parameters.A403_1Кнопкаtуст_Ybeta = "tуст";
                    break;
                case "2группа": A403_1Parameters.A403_1Кнопкаtуст_Ybeta = "Ybeta";
                    break;
                default: A403_1Parameters.A403_1Кнопкаtуст_Ybeta = "false";
                    break;
            }
        }

        private void A403_1КнопкаСброс_MouseDown(object sender, MouseEventArgs e)
        {
            this.A403_1КнопкаСброс.BackgroundImage = null;
        }

        private void A403_1КнопкаСброс_MouseUp(object sender, MouseEventArgs e)
        {
            this.A403_1КнопкаСброс.BackgroundImage = ControlElementImages.buttonSquareLightBlue;
            N15Parameters.Н15КнопкаСброс = "true";

            this.A403_1КнопкаАlpha_Lambda.Visible = true;
            A403_1Parameters.A403_1КнопкаАlpha_Lambda = "false";
            this.A403_1КнопкаEpsilon_Phi.Visible = true;
            A403_1Parameters.A403_1КнопкаEpsilon_Phi = "false";
            this.A403_1КнопкаI_H.Visible = true;
            A403_1Parameters.A403_1КнопкаI_H = "false";
            this.A403_1КнопкаOmega_N.Visible = true;
            A403_1Parameters.A403_1КнопкаOmega_N = "false";
            this.A403_1КнопкаLambda0_f.Visible = true;
            A403_1Parameters.A403_1КнопкаLambda0_f = "false";
            this.A403_1Кнопкаt0_K.Visible = true;
            A403_1Parameters.A403_1Кнопкаt0_K = "false";
            this.A403_1КнопкаT_Kbeta.Visible = true;
            A403_1Parameters.A403_1КнопкаT_Kbeta = "false";
            this.A403_1Кнопкаtсв_Yalpha.Visible = true;
            A403_1Parameters.A403_1Кнопкаtсв_Yalpha = "false";
            this.A403_1Кнопкаtуст_Ybeta.Visible = true;
            A403_1Parameters.A403_1Кнопкаtуст_Ybeta = "false";

        }

        private void A403_1КнопкаУстВремени_Click(object sender, System.EventArgs e)
        {
            if (A403_1Parameters.A403_1КнопкаУстВремени == "false")
            {
                this.A403_1КнопкаУстВремени.BackgroundImage = null;
                A403_1Parameters.A403_1КнопкаУстВремени = "true";
            }
            else
            {
                this.A403_1КнопкаУстВремени.BackgroundImage = ControlElementImages.buttonSquareLightBlue;
                A403_1Parameters.A403_1КнопкаУстВремени = "false";
            }
        }
        #endregion

        #region Переключатели
        private void A403_1ПереключательРежимРаботы_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A403_1Parameters.A403_1ПереключательРежимРаботы += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A403_1Parameters.A403_1ПереключательРежимРаботы -= 1;
            }

            var angle = A403_1Parameters.A403_1ПереключательРежимРаботы * 34 - 165;
            A403_1ПереключательРежимРаботы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }

        private void A403_1ПереключательПроверка_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                A403_1Parameters.A403_1ПереключательПроверка += 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                A403_1Parameters.A403_1ПереключательПроверка -= 1;
            }

            var angle = A403_1Parameters.A403_1ПереключательПроверка * 32 - 185;
            ////Смещение т.к форма не хорошо нарисована
            if (A403_1Parameters.A403_1ПереключательПроверка <= 6)
            {
                angle -= 6;
            }

            if (A403_1Parameters.A403_1ПереключательПроверка == 4 || A403_1Parameters.A403_1ПереключательПроверка == 5)
            {
                angle -= 6;
            }

            A403_1ПереключательПроверка.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }
        #endregion

        #region Инициализация
        private void InitializeTumblersPosition()
        {
            this.A403_1ТумблерСеть.BackgroundImage = A403_1Parameters.A403_1ТумблерСеть == "откл"
                ? ControlElementImages.tumblerType6Down : ControlElementImages.tumblerType6Up;

            this.A403_1ТумблерГотов.BackgroundImage = A403_1Parameters.A403_1ТумблерГотов == "откл"
                ? ControlElementImages.tumblerType4Down : ControlElementImages.tumblerType4Up;

            this.A403_1ТумблерКомплект.BackgroundImage = A403_1Parameters.A403_1ТумблерКомплект == "1"
                ? ControlElementImages.tumblerType2Left : ControlElementImages.tumblerType2Right;

            this.A403_1ТумблерГруппа.BackgroundImage = A403_1Parameters.A403_1ТумблерГруппа == "2группа"
                ? ControlElementImages.tumblerType4Down : ControlElementImages.tumblerType4Up;

            this.A403_1ТумблерАвтКоррекция.BackgroundImage = A403_1Parameters.A403_1ТумблерАвтКоррекция == "откл"
                ? ControlElementImages.tumblerType4Down : ControlElementImages.tumblerType4Up;
        }

        private void InitializeTogglesPosition()
        {
            var angle = A403_1Parameters.A403_1ПереключательРежимРаботы * 34 - 165;
            A403_1ПереключательРежимРаботы.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);

            angle = A403_1Parameters.A403_1ПереключательПроверка * 32 - 185;
            A403_1ПереключательПроверка.BackgroundImage =
                TransformImageHelper.RotateImageByAngle(ControlElementImages.toggleType2, angle);
        }
        #endregion
    }
}