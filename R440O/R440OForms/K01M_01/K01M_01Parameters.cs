using SignalTypes;
using R440O.R440OForms.K05M_01;
using R440O.R440OForms.K03M_01;
using R440O.R440OForms.PU_K1_1;
using R440O.R440OForms.N18_M_AngleSwitch;
using R440O.R440OForms.C300M_1;
using R440O.R440OForms.C300M_2;

namespace R440O.R440OForms.K01M_01
{
    static class K01M_01Parameters
    {
        public static KulonSignal Сигнал
        {
            get
            {
                if (PU_K1_1Parameters.Включен)
                {
                    KulonSignal сигнал = null;
                    if (K05M_01Parameters.ПереключательПередачаКонтроль != 0)
                        сигнал = K05M_01Parameters.Сигнал;
                    else
                    {

                        if (N18_M_AngleSwitchParameters.ГнездоПРМ1 == 1 && C300M_1Parameters.ВходящийСигнал != null
                            && C300M_1Parameters.ВходящийСигнал.Count != 0)
                        {
                            сигнал = C300M_1Parameters.ВходящийСигнал[0].KulonSignal;
                        }
                        else if (N18_M_AngleSwitchParameters.ГнездоПРМ2 == 1 && C300M_2Parameters.ВходящийСигнал != null
                             && C300M_2Parameters.ВходящийСигнал.Count != 0)
                        {
                            сигнал = C300M_2Parameters.ВходящийСигнал[0].KulonSignal;
                        }
                    }
                    return сигнал;
                }
                return null;
            }
        }

        public static void ResetParameters()
        {
            if (K05M_01Parameters.ПереключательПередачаКонтроль != 1)
                K03M_01Parameters.ОбновитьСигнал();
        }
    }
}
