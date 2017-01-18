using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using SignalTypes;
using System.Threading.Tasks;

namespace R440O
{
    class HttpHelper
    {
        static async Task<List<Signal>> SendSignal(Signal signal)
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
                        var signals = JsonConvert.DeserializeObject<List<Signal>>(result);
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
