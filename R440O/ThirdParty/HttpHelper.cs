using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using ShareTypes.SignalTypes;
using ShareTypes.OrderScheme;
using System.Net.NetworkInformation;
using R440O.R440OForms.OrderScheme;
using R440O.R440OForms.A205M_1;

namespace R440O.ThirdParty
{
    public static class HttpHelper
    {
        private static string ServerUrl = String.Empty;
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

        public static async void FindServer()
        {
            foreach (NetworkInterface netInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                IPInterfaceProperties ipProps = netInterface.GetIPProperties();
                foreach (UnicastIPAddressInformation addr in ipProps.UnicastAddresses)
                {
                    ServerUrl = "http://" + addr.Address.ToString() + ":8080/";
                    try
                    {
                        BroadcastSignal ВходнойСигнал = await ПослатьИПолучитьСигнал(new SendSignalDTO());
                        if (ВходнойСигнал != null)
                        {
                            return;
                        }
                    }
                    catch (System.UriFormatException e)
                    {
                        //т.к. иногда присутствуют ipv6 адресса
                    }
                    catch(System.Net.Http.HttpRequestException e)
                    {
                        //т.к. не все подключения активны (например, если установлен virtualbox)
                    }

                }
            }
        }

    }
}
