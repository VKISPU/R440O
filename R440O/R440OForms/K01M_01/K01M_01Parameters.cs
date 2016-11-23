using R440O.BaseClasses;
using R440O.R440OForms.K05M_01;
using R440O.R440OForms.PU_K1_1;

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
                    if (K05M_01Parameters.ПереключательПередачаКонтроль != 0)
                        return K05M_01Parameters.Сигнал;
                }
                return null;
            }
        }
    }
}
