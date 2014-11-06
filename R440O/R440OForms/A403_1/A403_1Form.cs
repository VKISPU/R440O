//-----------------------------------------------------------------------
// <copyright file="A403_1Form.cs" company="VKISPU">
//      R440O station.
// </copyright>
//-----------------------------------------------------------------------

using R440O.Parameters;

namespace R440O.R440OForms.A403_1
{
    using System.Windows.Forms;

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
            A403_1Parameters.A403_1ТумблерСеть = "откл";
            A403_1Parameters.A403_1ТумблерСеть = "1";
            A403_1Parameters.A403_1ТумблерГотов = "откл";
            A403_1Parameters.A403_1ТумблерГруппа = "2группа";
            A403_1Parameters.A403_1ТумблерАвтКоррекция = "откл";
        }

        #region Тумблеры
        private void A403_1ТумблерСеть_Click(object sender, System.EventArgs e)
        {
            if (A403_1Parameters.A403_1ТумблерСеть == "сеть")
            {
                this.A403_1ТумблерСеть.BackgroundImage = ControlElementImages.tumblerVerticalType3Down;
                A403_1Parameters.A403_1ТумблерСеть = "откл";
            }
            else
            {
                this.A403_1ТумблерСеть.BackgroundImage = ControlElementImages.tumblerVerticalType3Up;
                A403_1Parameters.A403_1ТумблерСеть = "сеть";
            }
        }

        private void A403_1ТумблерКомплект_Click(object sender, System.EventArgs e)
        {
            if (A403_1Parameters.A403_1ТумблерКомплект == "1")
            {
                this.A403_1ТумблерКомплект.BackgroundImage = ControlElementImages.tumblerHorizontalType2Right;
                A403_1Parameters.A403_1ТумблерКомплект = "2";
            }
            else
            {
                this.A403_1ТумблерКомплект.BackgroundImage = ControlElementImages.tumblerHorizontalType2Left;
                A403_1Parameters.A403_1ТумблерКомплект = "1";
            }
        }

        private void A403_1ТумблерГотов_Click(object sender, System.EventArgs e)
        {
            if (A403_1Parameters.A403_1ТумблерГотов == "готов")
            {
                this.A403_1ТумблерГотов.BackgroundImage = ControlElementImages.tumblerVerticalType1Down;
                A403_1Parameters.A403_1ТумблерГотов = "откл";
            }
            else
            {
                this.A403_1ТумблерГотов.BackgroundImage = ControlElementImages.tumblerVerticalType1Up;
                A403_1Parameters.A403_1ТумблерГотов = "готов";
            }
        }

        private void A403_1ТумблерГруппа_Click(object sender, System.EventArgs e)
        {
            if (A403_1Parameters.A403_1ТумблерГруппа == "1группа")
            {
                this.A403_1ТумблерГруппа.BackgroundImage = ControlElementImages.tumblerVerticalType1Down;
                A403_1Parameters.A403_1ТумблерГруппа = "2группа";
            }
            else
            {
                this.A403_1ТумблерГруппа.BackgroundImage = ControlElementImages.tumblerVerticalType1Up;
                A403_1Parameters.A403_1ТумблерГруппа = "1группа";
            }
        }

        private void A403_1ТумблерАвтКоррекция_Click(object sender, System.EventArgs e)
        {
            if (A403_1Parameters.A403_1ТумблерАвтКоррекция == "автКоррекция")
            {
                this.A403_1ТумблерАвтКоррекция.BackgroundImage = ControlElementImages.tumblerVerticalType1Down;
                A403_1Parameters.A403_1ТумблерАвтКоррекция = "откл";
            }
            else
            {
                this.A403_1ТумблерАвтКоррекция.BackgroundImage = ControlElementImages.tumblerVerticalType1Up;
                A403_1Parameters.A403_1ТумблерАвтКоррекция = "автКоррекция";
            }
        }
        #endregion

        #region Кнопки
        private void A403_1Кнопка1_MouseDown(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка1.BackgroundImage = null;
            this.A403_1Кнопка1.Text = "";
        }

        private void A403_1Кнопка1_MouseUp(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка1.BackgroundImage = ControlElementImages.buttonSquareType1UpWhite;
            this.A403_1Кнопка1.Text = "1";
        }

        private void A403_1Кнопка2_MouseDown(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка2.BackgroundImage = null;
            this.A403_1Кнопка2.Text = "";
        }

        private void A403_1Кнопка2_MouseUp(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка2.BackgroundImage = ControlElementImages.buttonSquareType1UpWhite;
            this.A403_1Кнопка2.Text = "2";
        }

        private void A403_1Кнопка3_MouseDown(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка3.BackgroundImage = null;
            this.A403_1Кнопка3.Text = "";
        }

        private void A403_1Кнопка3_MouseUp(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка3.BackgroundImage = ControlElementImages.buttonSquareType1UpWhite;
            this.A403_1Кнопка3.Text = "3";
        }

        private void A403_1Кнопка4_MouseDown(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка4.BackgroundImage = null;
            this.A403_1Кнопка4.Text = "";
        }

        private void A403_1Кнопка4_MouseUp(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка4.BackgroundImage = ControlElementImages.buttonSquareType1UpWhite;
            this.A403_1Кнопка4.Text = "4";
        }

        private void A403_1Кнопка5_MouseDown(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка5.BackgroundImage = null;
            this.A403_1Кнопка5.Text = "";
        }

        private void A403_1Кнопка5_MouseUp(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка5.BackgroundImage = ControlElementImages.buttonSquareType1UpWhite;
            this.A403_1Кнопка5.Text = "5";
        }

        private void A403_1Кнопка6_MouseDown(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка6.BackgroundImage = null;
            this.A403_1Кнопка6.Text = "";
        }

        private void A403_1Кнопка6_MouseUp(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка6.BackgroundImage = ControlElementImages.buttonSquareType1UpWhite;
            this.A403_1Кнопка6.Text = "6";
        }

        private void A403_1Кнопка7_MouseDown(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка7.BackgroundImage = null;
            this.A403_1Кнопка7.Text = "";
        }

        private void A403_1Кнопка7_MouseUp(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка7.BackgroundImage = ControlElementImages.buttonSquareType1UpWhite;
            this.A403_1Кнопка7.Text = "7";
        }

        private void A403_1Кнопка8_MouseDown(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка8.BackgroundImage = null;
            this.A403_1Кнопка8.Text = "";
        }

        private void A403_1Кнопка8_MouseUp(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка8.BackgroundImage = ControlElementImages.buttonSquareType1UpWhite;
            this.A403_1Кнопка8.Text = "8";
        }

        private void A403_1Кнопка9_MouseDown(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка9.BackgroundImage = null;
            this.A403_1Кнопка9.Text = "";
        }

        private void A403_1Кнопка9_MouseUp(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка9.BackgroundImage = ControlElementImages.buttonSquareType1UpWhite;
            this.A403_1Кнопка9.Text = "9";
        }

        private void A403_1Кнопка0_MouseDown(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка0.BackgroundImage = null;
            this.A403_1Кнопка0.Text = "";
        }

        private void A403_1Кнопка0_MouseUp(object sender, MouseEventArgs e)
        {
            this.A403_1Кнопка0.BackgroundImage = ControlElementImages.buttonSquareType1UpWhite;
            this.A403_1Кнопка0.Text = "0";
        }

        private void A403_1КнопкаМинус_MouseDown(object sender, MouseEventArgs e)
        {
            this.A403_1КнопкаМинус.BackgroundImage = null;
            this.A403_1КнопкаМинус.Text = "";
        }

        private void A403_1КнопкаМинус_MouseUp(object sender, MouseEventArgs e)
        {
            this.A403_1КнопкаМинус.BackgroundImage = ControlElementImages.buttonSquareType1UpWhite;
            this.A403_1КнопкаМинус.Text = "–";
        }

        private void A403_1КнопкаАlpha_Lambda_Click(object sender, System.EventArgs e)
        {
            this.A403_1КнопкаАlpha_Lambda.Visible = false;
            if (A403_1Parameters.A403_1ТумблерГруппа == "1группа")
                A403_1Parameters.A403_1КнопкаАlpha_Lambda = "alpha";
            else
                if (A403_1Parameters.A403_1ТумблерГруппа == "2группа")
                A403_1Parameters.A403_1КнопкаАlpha_Lambda = "lambda";
                else
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

        private void A403_1КнопкаEpsilon_Phi_Click(object sender, System.EventArgs e)
        {
            this.A403_1КнопкаАlpha_Lambda.Visible = true;
            A403_1Parameters.A403_1КнопкаАlpha_Lambda = "false";

            this.A403_1КнопкаEpsilon_Phi.Visible = false;
            if (A403_1Parameters.A403_1ТумблерГруппа == "1группа")
                A403_1Parameters.A403_1КнопкаEpsilon_Phi = "epsilon";
            else
                if (A403_1Parameters.A403_1ТумблерГруппа == "2группа")
                    A403_1Parameters.A403_1КнопкаEpsilon_Phi = "phi";
                else
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

        private void A403_1КнопкаI_H_Click(object sender, System.EventArgs e)
        {
            this.A403_1КнопкаАlpha_Lambda.Visible = true;
            A403_1Parameters.A403_1КнопкаАlpha_Lambda = "false";
            this.A403_1КнопкаEpsilon_Phi.Visible = true;
            A403_1Parameters.A403_1КнопкаEpsilon_Phi = "false";

            this.A403_1КнопкаI_H.Visible = false;
            if (A403_1Parameters.A403_1ТумблерГруппа == "1группа")
                A403_1Parameters.A403_1КнопкаI_H = "i";
            else
                if (A403_1Parameters.A403_1ТумблерГруппа == "2группа")
                    A403_1Parameters.A403_1КнопкаI_H = "H";
                else
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

        private void A403_1КнопкаOmega_N_Click(object sender, System.EventArgs e)
        {
            this.A403_1КнопкаАlpha_Lambda.Visible = true;
            A403_1Parameters.A403_1КнопкаАlpha_Lambda = "false";
            this.A403_1КнопкаEpsilon_Phi.Visible = true;
            A403_1Parameters.A403_1КнопкаEpsilon_Phi = "false";
            this.A403_1КнопкаI_H.Visible = true;
            A403_1Parameters.A403_1КнопкаI_H = "false";

            this.A403_1КнопкаOmega_N.Visible = false;
            if (A403_1Parameters.A403_1ТумблерГруппа == "1группа")
                A403_1Parameters.A403_1КнопкаOmega_N = "omega";
            else
                if (A403_1Parameters.A403_1ТумблерГруппа == "2группа")
                    A403_1Parameters.A403_1КнопкаOmega_N = "N";
                else
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
            if (A403_1Parameters.A403_1ТумблерГруппа == "1группа")
                A403_1Parameters.A403_1КнопкаLambda0_f = "lambda0";
            else
                if (A403_1Parameters.A403_1ТумблерГруппа == "2группа")
                    A403_1Parameters.A403_1КнопкаLambda0_f = "f";
                else
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
            if (A403_1Parameters.A403_1ТумблерГруппа == "1группа")
                A403_1Parameters.A403_1Кнопкаt0_K = "t0";
            else
                if (A403_1Parameters.A403_1ТумблерГруппа == "2группа")
                    A403_1Parameters.A403_1Кнопкаt0_K = "K";
                else
                    A403_1Parameters.A403_1Кнопкаt0_K = "false";

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
            if (A403_1Parameters.A403_1ТумблерГруппа == "1группа")
                A403_1Parameters.A403_1КнопкаT_Kbeta = "T";
            else
                if (A403_1Parameters.A403_1ТумблерГруппа == "2группа")
                    A403_1Parameters.A403_1КнопкаT_Kbeta = "Kbeta";
                else
                    A403_1Parameters.A403_1КнопкаT_Kbeta = "false";

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
            if (A403_1Parameters.A403_1ТумблерГруппа == "1группа")
                A403_1Parameters.A403_1Кнопкаtсв_Yalpha = "tсв";
            else
                if (A403_1Parameters.A403_1ТумблерГруппа == "2группа")
                    A403_1Parameters.A403_1Кнопкаtсв_Yalpha = "Yalpha";
                else
                    A403_1Parameters.A403_1Кнопкаtсв_Yalpha = "false";

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
            if (A403_1Parameters.A403_1ТумблерГруппа == "1группа")
                A403_1Parameters.A403_1Кнопкаtуст_Ybeta = "tуст";
            else
                if (A403_1Parameters.A403_1ТумблерГруппа == "2группа")
                    A403_1Parameters.A403_1Кнопкаtуст_Ybeta = "Ybeta";
                else
                    A403_1Parameters.A403_1Кнопкаtуст_Ybeta = "false";
        }

        private void A403_1КнопкаСброс_MouseDown(object sender, MouseEventArgs e)
        {
            this.A403_1КнопкаСброс.BackgroundImage = null;
        }

        private void A403_1КнопкаСброс_MouseUp(object sender, MouseEventArgs e)
        {
            this.A403_1КнопкаСброс.BackgroundImage = ControlElementImages.ButtonBlueUp;
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

        #endregion

    }
}