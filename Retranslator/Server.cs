using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using SignalTypes;

namespace Retranslator
{
    public class Server
    {
        HttpListener httpListener = new HttpListener();

        public Server(string url)
        {
            if (!HttpListener.IsSupported)
                return;
            httpListener.Prefixes.Add(url);
            httpListener.Start();
            Listening();
        }

        private void Listening()
        {
            while (true)
            {
                HttpListenerContext context = httpListener.GetContext();
                HttpListenerRequest request = context.Request;
                HttpListenerResponse response = context.Response;
                if (request.HttpMethod == "POST")
                    Post(request, response);
                else
                {
                    Error(response);
                }
            }
        }

        private void Error(HttpListenerResponse response)
        {
            response.StatusCode = (int)HttpStatusCode.OK;
            string responseString = "Helow, World!";
            var buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
            response.ContentLength64 = buffer.Length;
            using (Stream stream = response.OutputStream)
            {
                stream.Write(buffer, 0, buffer.Length);

            }
        }

        private void Post(HttpListenerRequest request, HttpListenerResponse response)
        {
            string str;
            using (var reader = new StreamReader(request.InputStream,
                                     request.ContentEncoding))
            {
                str = reader.ReadToEnd();
            }
            try
            {
                var signal = JsonConvert.DeserializeObject<Signal>(str);
                List<Signal> signals = new List<Signal>();
                signals.Add(signal);
                var responseString = JsonConvert.SerializeObject(signals);
                var buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                response.ContentLength64 = buffer.Length;
                using (Stream stream = response.OutputStream)
                {
                    stream.Write(buffer, 0, buffer.Length);
                }
            }
            catch
            {

            }
        }
    }
}
