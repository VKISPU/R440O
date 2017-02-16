using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using ShareTypes.SignalTypes;
using System.Threading.Tasks;
using ShareTypes.OrderScheme;

namespace Retranslator
{
    public class Server
    {
        HttpListener httpListener = new HttpListener();

        List<string> ipList = new List<string>();

        public Server(string url)
        {
            if (!HttpListener.IsSupported)
                throw new NotImplementedException();
            httpListener.Prefixes.Add(url);
            httpListener.Start();
            Task.Run(() => { Listening(); });
        }

        private void Listening()
        {
            while (true)
            {
                HttpListenerContext context = httpListener.GetContext();
                HttpListenerRequest request = context.Request;
                HttpListenerResponse response = context.Response;
                if (request.HttpMethod == "POST")
                {
                    if (request.Url.AbsolutePath == "/signal")
                        SendSignal(request, response);
                }
                else if (request.HttpMethod == "GET")
                {
                    if (request.Url.AbsolutePath == "/orderscheme")
                        SendOrderScheme(request, response);
                }
                else
                {
                    Error(response);
                }
            }
        }

        private void Error(HttpListenerResponse response)
        {
            response.StatusCode = (int)HttpStatusCode.OK;
            string responseString = "Some Error :( !";
            var buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
            response.ContentLength64 = buffer.Length;
            using (Stream stream = response.OutputStream)
            {
                stream.Write(buffer, 0, buffer.Length);

            }
        }

        private void SendOrderScheme(HttpListenerRequest request, HttpListenerResponse response)
        {
            try
            {
                var orderScheme = OrderSchemeFactory.CreateOrderScheme(false);
                var responseString = JsonConvert.SerializeObject(orderScheme);
                var buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                response.ContentLength64 = buffer.Length;
                using (Stream stream = response.OutputStream)
                {
                    stream.Write(buffer, 0, buffer.Length);
                }
            }
            catch (Exception e)
            {

            }
        }

        private void SendSignal(HttpListenerRequest request, HttpListenerResponse response)
        {
            string str;
            using (var reader = new StreamReader(request.InputStream,
                                     request.ContentEncoding))
            {
                str = reader.ReadToEnd();
            }
            try
            {
                updateIpList(request.UserHostAddress);
                int WaveShift = 1500;
                int FrequencyShift = 2325000;
                var signal = JsonConvert.DeserializeObject<Signal>(str);
                signal.Wave -= WaveShift;
                signal.Frequency -= FrequencyShift;
                var broadcast = new BroadcastSignal { Signals = new List<Signal> { signal } };
                var responseString = JsonConvert.SerializeObject(broadcast);
                var buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                response.ContentLength64 = buffer.Length;
                using (Stream stream = response.OutputStream)
                {
                    stream.Write(buffer, 0, buffer.Length);
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void updateIpList(string UserHostAddress)
        {
            //check if exist in ram, if not, when write to ram and file
            if (!ipList.Contains(UserHostAddress))
            {
                ipList.Add(UserHostAddress);
                File.WriteAllText(@"ip-list.json", JsonConvert.SerializeObject(UserHostAddress));
                using (StreamWriter file = File.CreateText(@"ip-list.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, UserHostAddress);
                }
            }

        }

    }
}
