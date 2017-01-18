using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

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

                switch (request.HttpMethod)
                {
                    case "GET":
                        break;
                    case "POST":
                        Post(request.RawUrl, response);
                        break;
                }
            }
        }

        private void Post(string url, HttpListenerResponse response)
        {
            switch (url)
            {
                case "signal/":
                    response.StatusCode = (int)HttpStatusCode.OK;
                    string responseString = "Helow, World!";
                    var buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                    response.ContentLength64 = buffer.Length;
                    using (Stream stream = response.OutputStream) 
                    {
                        stream.Write(buffer, 0, buffer.Length);
 
                    }
                    break;
            }
        }
    }
}
