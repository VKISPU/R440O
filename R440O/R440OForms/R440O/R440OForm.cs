using System;
using System.Linq;
using System.Windows.Forms;
using R440O.R440OForms.A205M_1;
using R440O.R440OForms.A205M_2;
using R440O.R440OForms.A1;
using R440O.R440OForms.A304;
using R440O.R440OForms.A306;
using R440O.R440OForms.A403_1;
using R440O.R440OForms.A403_3;
using R440O.R440OForms.Astra;
using R440O.R440OForms.B1_1;
using R440O.R440OForms.BMA_M_1;
using R440O.R440OForms.C1_67;
using R440O.R440OForms.C300M_1;
using R440O.R440OForms.C300M_2;
using R440O.R440OForms.C300M_3;
using R440O.R440OForms.C300M_4;
using R440O.R440OForms.C300PM_2;
using R440O.R440OForms.C300PM_3;
using R440O.R440OForms.DAB_5;
using R440O.R440OForms.Kontur_P3;
using R440O.R440OForms.N12S;
using R440O.R440OForms.N13_1;
using R440O.R440OForms.N13_2;
using R440O.R440OForms.N15;
using R440O.R440OForms.N16;
using R440O.R440OForms.N18_M;
using R440O.R440OForms.NKN_1;
using R440O.R440OForms.NKN_2;
using R440O.R440OForms.N502B;
using R440O.R440OForms.P220_27G_2;
using R440O.R440OForms.P220_27G_3;
using R440O.R440OForms.PowerCabel;
using R440O.R440OForms.PowerShield;
using R440O.R440OForms.PU_K1_1;
using R440O.R440OForms.PU_K1_2;
using R440O.R440OForms.Rubin_N;
using R440O.R440OForms.VoltageStabilizer;
using R440O.R440OForms.Wattmeter;
using R440O.R440OForms.С300PM_1;

namespace R440O.R440OForms.R440O
{
    public partial class R440OForm : Form
    {
        public R440OForm()
        {
            InitializeComponent();
        }
        
        private void R440OButtonA205M_1_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<A205M_1Form>().Any())
            {
                this.OwnedForms.OfType<A205M_1Form>().First().Activate();
            }
            else
            {
                Form thisForm = new A205M_1Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonA205M_2_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<A205M_2Form>().Any())
            {
                this.OwnedForms.OfType<A205M_2Form>().First().Activate();
            }
            else
            {
                Form thisForm = new A205M_2Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonA1_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<A1Form>().Any())
            {
                this.OwnedForms.OfType<A1Form>().First().Activate();
            }
            else
            {
                Form thisForm = new A1Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonA304_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<A304Form>().Any())
            {
                this.OwnedForms.OfType<A304Form>().First().Activate();
            }
            else
            {
                Form thisForm = new A304Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonB1_1_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<B1_1Form>().Any())
            {
                this.OwnedForms.OfType<B1_1Form>().First().Activate();
            }
            else
            {
                Form thisForm = new B1_1Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonWattmeter_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<WattmeterForm>().Any())
            {
                this.OwnedForms.OfType<WattmeterForm>().First().Activate();
            }
            else
            {
                Form thisForm = new WattmeterForm();
                thisForm.Show(this);
            }

        }

        private void R440OButtonN502B_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<N502BForm>().Any())
            {
                this.OwnedForms.OfType<N502BForm>().First().Activate();
            }
            else
            {
                Form thisForm = new N502BForm();
                thisForm.Show(this);
            }

        }

        private void R440OButtonN15_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<N15Form>().Any())
            {
                this.OwnedForms.OfType<N15Form>().First().Activate();
            }
            else
            {
                Form thisForm = new N15Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonN12S_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<N12SForm>().Any())
            {
                this.OwnedForms.OfType<N12SForm>().First().Activate();
            }
            else
            {
                Form thisForm = new N12SForm();
                thisForm.Show(this);
            }
        }

        private void R440OButtonPowerCabel_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<PowerCabelForm>().Any())
            {
                this.OwnedForms.OfType<PowerCabelForm>().First().Activate();
            }
            else
            {
                Form thisForm = new PowerCabelForm();
                thisForm.Show(this);
            }
        }

        private void R440OButtonDAB_5_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<DAB_5Form>().Any())
            {
                this.OwnedForms.OfType<DAB_5Form>().First().Activate();
            }
            else
            {
                Form thisForm = new DAB_5Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonA306_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<A306Form>().Any())
            {
                this.OwnedForms.OfType<A306Form>().First().Activate();
            }
            else
            {
                Form thisForm = new A306Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonKontur_P3_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<Kontur_P3Form>().Any())
            {
                this.OwnedForms.OfType<Kontur_P3Form>().First().Activate();
            }
            else
            {
                Form thisForm = new Kontur_P3Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonC300M_1_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<C300M_1Form>().Any())
            {
                this.OwnedForms.OfType<C300M_1Form>().First().Activate();
            }
            else
            {
                Form thisForm = new C300M_1Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonC300M_2_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<C300M_2Form>().Any())
            {
                this.OwnedForms.OfType<C300M_2Form>().First().Activate();
            }
            else
            {
                Form thisForm = new C300M_2Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonC300M_3_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<C300M_3Form>().Any())
            {
                this.OwnedForms.OfType<C300M_3Form>().First().Activate();
            }
            else
            {
                Form thisForm = new C300M_3Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonC300M_4_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<C300M_4Form>().Any())
            {
                this.OwnedForms.OfType<C300M_4Form>().First().Activate();
            }
            else
            {
                Form thisForm = new C300M_4Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonC300PM_1_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<C300PM_1Form>().Any())
            {
                this.OwnedForms.OfType<C300PM_1Form>().First().Activate();
            }
            else
            {
                Form thisForm = new C300PM_1Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonAstra_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<AstraForm>().Any())
            {
                this.OwnedForms.OfType<AstraForm>().First().Activate();
            }
            else
            {
                Form thisForm = new AstraForm();
                thisForm.Show(this);
            }
        }

        private void R440OButtonBMA_M_1_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<BMA_M_1Form>().Any())
            {
                this.OwnedForms.OfType<BMA_M_1Form>().First().Activate();
            }
            else
            {
                Form thisForm = new BMA_M_1Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonBMA_M_2_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<BMA_M_2Form>().Any())
            {
                this.OwnedForms.OfType<BMA_M_2Form>().First().Activate();
            }
            else
            {
                Form thisForm = new BMA_M_2Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonBMB_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<BMBForm>().Any())
            {
                this.OwnedForms.OfType<BMBForm>().First().Activate();
            }
            else
            {
                Form thisForm = new BMBForm();
                thisForm.Show(this);
            }
        }

        private void R440ButtonP220_27G_2_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<P220_27G_2Form>().Any())
            {
                this.OwnedForms.OfType<P220_27G_2Form>().First().Activate();
            }
            else
            {
                Form thisForm = new P220_27G_2Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonP220_27G_3_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<P220_27G_3Form>().Any())
            {
                this.OwnedForms.OfType<P220_27G_3Form>().First().Activate();
            }
            else
            {
                Form thisForm = new P220_27G_3Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonVoltageStabilizer_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<VoltageStabilizerForm>().Any())
            {
                this.OwnedForms.OfType<VoltageStabilizerForm>().First().Activate();
            }
            else
            {
                Form thisForm = new VoltageStabilizerForm();
                thisForm.Show(this);
            }
        }

        private void R440OButtonRubin_N_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<Rubin_NForm>().Any())
            {
                this.OwnedForms.OfType<Rubin_NForm>().First().Activate();
            }
            else
            {
                Form thisForm = new Rubin_NForm();
                thisForm.Show(this);
            }
        }

        private void R440OButtonPU_K1_1_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<PU_K1_1Form>().Any())
            {
                this.OwnedForms.OfType<PU_K1_1Form>().First().Activate();
            }
            else
            {
                Form thisForm = new PU_K1_1Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonPU_K1_2_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<PU_K1_2Form>().Any())
            {
                this.OwnedForms.OfType<PU_K1_2Form>().First().Activate();
            }
            else
            {
                Form thisForm = new PU_K1_2Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonC300PM_2_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<C300PM_2Form>().Any())
            {
                this.OwnedForms.OfType<C300PM_2Form>().First().Activate();
            }
            else
            {
                Form thisForm = new C300PM_2Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonC300PM_3_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<C300PM_3Form>().Any())
            {
                this.OwnedForms.OfType<C300PM_3Form>().First().Activate();
            }
            else
            {
                Form thisForm = new C300PM_3Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonC1_67_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<C1_67Form>().Any())
            {
                this.OwnedForms.OfType<C1_67Form>().First().Activate();
            }
            else
            {
                Form thisForm = new C1_67Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonA403_1_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<A403_1Form>().Any())
            {
                this.OwnedForms.OfType<A403_1Form>().First().Activate();
            }
            else
            {
                Form thisForm = new A403_1Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonA403_3_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<A403_3Form>().Any())
            {
                this.OwnedForms.OfType<A403_3Form>().First().Activate();
            }
            else
            {
                Form thisForm = new A403_3Form();
                thisForm.Show(this);
            }
        }

        private void R440ButtonN13_1_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<N13_1Form>().Any())
            {
                this.OwnedForms.OfType<N13_1Form>().First().Activate();
            }
            else
            {
                Form thisForm = new N13_1Form();
                thisForm.Show(this);
            }
        }

        private void R440ButtonN13_2_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<N13_2Form>().Any())
            {
                this.OwnedForms.OfType<N13_2Form>().First().Activate();
            }
            else
            {
                Form thisForm = new N13_2Form();
                thisForm.Show(this);
            }
        }

        private void R440OButtonN16_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<N16Form>().Any())
            {
                this.OwnedForms.OfType<N16Form>().First().Activate();
            }
            else
            {
                Form thisForm = new N16Form();
                thisForm.Show(this);
            }
        }

        private void R440ButtonN18_M_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<N18_MForm>().Any())
            {
                this.OwnedForms.OfType<N18_MForm>().First().Activate();
            }
            else
            {
                Form thisForm = new N18_MForm();
                thisForm.Show(this);
            }
        }

        private void R440ButtonNKN_1_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<NKN_1Form>().Any())
            {
                this.OwnedForms.OfType<NKN_1Form>().First().Activate();
            }
            else
            {
                Form thisForm = new NKN_1Form();
                thisForm.Show(this);
            }
        }

        private void R440ButtonNKN_2_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<NKN_2Form>().Any())
            {
                this.OwnedForms.OfType<NKN_2Form>().First().Activate();
            }
            else
            {
                Form thisForm = new NKN_2Form();
                thisForm.Show(this);
            }
        }

        private void R440ButtonPowerShield_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.OfType<PowerShieldForm>().Any())
            {
                this.OwnedForms.OfType<PowerShieldForm>().First().Activate();
            }
            else
            {
                Form thisForm = new PowerShieldForm();
                thisForm.Show(this);
            }
        }
    }
}
