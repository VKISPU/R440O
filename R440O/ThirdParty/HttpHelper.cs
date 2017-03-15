using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using ShareTypes.SignalTypes;
using ShareTypes.OrderScheme;

namespace R440O.ThirdParty
{
    public static class HttpHelper
    {
        private static string ServerUrl = "http://localhost:8080/";
        private static string SignalUrl = "signal";
        private static string OrdeSchemeUrl = "orderscheme";

        public static async Task<BroadcastSignal> ПослатьИПолучитьСигнал(SendSignalDTO signalDTO)
        {
            var body = new StringContent(JsonConvert.SerializeObject(signalDTO), Encoding.UTF8, "application/json");
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.PostAsync(ServerUrl + SignalUrl, body))
            using (HttpContent content = response.Content)
            {
                string result = await content.ReadAsStringAsync();
                if (result != null)
                {
                    try
                    {
                        return JsonConvert.DeserializeObject<BroadcastSignal>(result);
                    }
                    catch
                    {
                        return null;
                    }
                }
                return null;
            }
        }

        public static async Task<OrderSchemeClass> ПолучитьСхемуПриказ()
        {
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(ServerUrl + OrdeSchemeUrl))
            using (HttpContent content = response.Content)
            {
                string result = await content.ReadAsStringAsync();
                if (result != null)
                {
                    try
                    {
                        return JsonConvert.DeserializeObject<OrderSchemeClass>(result);
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
