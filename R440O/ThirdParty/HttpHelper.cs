using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using ShareTypes.SignalTypes;
using ShareTypes.OrderScheme;
using ShareTypes;
using System.Text.RegularExpressions;
using R440O.R440OForms.OrderScheme;
using R440O.R440OForms.A205M_1;

namespace R440O.ThirdParty
{
    public static class HttpHelper
    {
        private static string ServerUrl = String.Empty;
        private static string SignalUrl = "signal";
        private static string OrdeSchemeUrl = "orderscheme";
        private static string CheckServerUrl = "checkserver";

        private static List<string> списокАдресовСети = ПолучитьСписокАдресовСети();
        
        private static int количествоНезавершенныЗапросов = 0;
        public static bool ПоискИдет { get { return количествоНезавершенныЗапросов != 0; } }

        private static bool _серверНайден = false;
        public static bool СерверНайден
        {
            get { return _серверНайден; }
            private set 
            {
                _серверНайден = value;
            }
        }

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

        public static async void ПроверитьАдресс(string serverUrl)
        {
            if (!СерверНайден)
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    using (HttpResponseMessage response = await client.GetAsync(serverUrl + CheckServerUrl))
                    {
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            using (HttpContent content = response.Content)
                            {
                                string result = await content.ReadAsStringAsync();
                                try
                                {
                                    var checkString = JsonConvert.DeserializeObject<string>(result);
                                    if (checkString == Constants.ServerCheckString)
                                    {
                                        ServerUrl = serverUrl;
                                        СерверНайден = true;  
                                    }
                                }
                                catch (JsonException e)
                                {

                                }
                            }
                                                      
                        }
                    }
                }
                catch (System.UriFormatException e)
                {
                    //т.к. иногда присутствуют ipv6 адресса
                }
                catch (System.Net.Http.HttpRequestException e)
                {
                    //т.к. не все подключения активны (например, если установлен virtualbox)
                }
            }
            количествоНезавершенныЗапросов--;            
        }

        public static void ПоискСервера()
        {
            количествоНезавершенныЗапросов = списокАдресовСети.Count;
            foreach (var addr in списокАдресовСети)
            {
                var _serverUrl = "http://" + addr + ":8080/";
                ПроверитьАдресс(_serverUrl);
            }
        }

        public static List<string> ПолучитьСписокАдресовСети()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c arp -a";
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            List<string> addresses = new List<string>();
            Regex ipRegex = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");
            while (!process.StandardOutput.EndOfStream)
            {
                string line = process.StandardOutput.ReadLine();
                MatchCollection result = ipRegex.Matches(line);
                if (result.Count != 0 && result[0] != null)
                {
                    addresses.Add(result[0].ToString());
                }                
            }
            process.WaitForExit();
            process.Close();
            return addresses;
        }

    }
}
