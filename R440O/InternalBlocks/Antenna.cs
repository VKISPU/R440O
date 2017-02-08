using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using SignalTypes;
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
                        ВходнойСигнал = await ПослатьИПолучитьСигнал(A205M_1Parameters.ВыходнойСигнал);
                        //MSHUParameters.ResetParameters();
                    }
                }, 1000);
            }
            MSHUParameters.ResetParameters();
        }

        static async Task<BroadcastSignal> ПослатьИПолучитьСигнал(Signal signal)
        {
            string url = "http://localhost:8080/";
            var body = new StringContent(JsonConvert.SerializeObject(signal), Encoding.UTF8, "application/json");
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.PostAsync(url, body))
            using (HttpContent content = response.Content)
            {                
                string result = await content.ReadAsStringAsync();
                if (result != null)
                {
                    try
                    {
                        var signals = JsonConvert.DeserializeObject<BroadcastSignal>(result);
                        return signals;
                    }
                    catch
                    {
                        return null;
                    }
                }
                return null;
            }
        }
    }
}
