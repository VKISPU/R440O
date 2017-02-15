using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShareTypes.SignalTypes;
using System.Threading.Tasks;
using R440O.R440OForms.N15;
using R440O.ThirdParty;
using R440O.R440OForms.A205M_1;

namespace R440O.InternalBlocks
{
    static class Antenna
    {
        private static IDisposable timer;

        public static BroadcastSignal ВыходнойСигнал
        {
            get
            {
                return ВходнойСигнал != null ? ВходнойСигнал.Clone() : null;
            }
        }

        private static BroadcastSignal ВходнойСигнал { get; set; }

        public static void ResetParameters()
        {
            if (timer != null)
                timer.Dispose();
            if (N15Parameters.ЛампочкаАнт)
            {
                timer = EasyTimer.SetInterval(async () =>
                {
                    if (A205M_1Parameters.ВыходнойСигнал != null)
                    {
                        ВходнойСигнал = await HttpHelper.ПослатьИПолучитьСигнал(A205M_1Parameters.ВыходнойСигнал);
                        //MSHUParameters.ResetParameters();
                    }
                }, 1000);
            }
            MSHUParameters.ResetParameters();
        }


    }
}
