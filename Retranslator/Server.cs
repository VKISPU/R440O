using System;
using System.Collections.Generic;
using System.Linq;
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
        List<OrderSchemePair> OrderSchemePairs = new List<OrderSchemePair>();
        Random Randomizer = new Random();

        public event Action<List<OrderSchemePair>> StationListUpdateEvent;       

        public Server(string url)
        {
            if (!HttpListener.IsSupported)
                throw new NotImplementedException();
            httpListener.Prefixes.Add(url);
            httpListener.Start();
            Task.Run(() => { 
                Listening(); 
            });
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
                var orderScheme = GetOrderSheme();
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
                var signalDTO = JsonConvert.DeserializeObject<SendSignalDTO>(str);
                ClearStantionList();
                UpdateSignal(signalDTO);
                var broadcast = GetBroadcastSignal();
                StationListUpdateEvent(this.OrderSchemePairs);

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


        private OrderSchemeClass GetOrderSheme()
        {
            var stantion = new Stantion();
            var freePair = this.OrderSchemePairs.FirstOrDefault(s => s.IsFree);
            if (freePair == null)
            {
                var wave1 = GetRandomWave(0);
                var wave2 = GetRandomWave(wave1);
                freePair = new OrderSchemePair(wave1, wave2);
                this.OrderSchemePairs.Add(freePair);
            }
            freePair.AddStation(stantion);
            return freePair.GetOrderSchemeByStation(stantion);
        }

        private int GetRandomWave(int fisrtWave)
        {
            for (int i = 0; i < 10000; i++)
            {
                var wave = this.Randomizer.Next(1500, 51499);
                if (Math.Abs(fisrtWave - wave) < 100 || !this.OrderSchemePairs.Any(pair =>
                    Math.Abs(pair.RandomWave1 - wave) < 100 || Math.Abs(pair.RandomWave2 - wave) < 100))
                {
                    return wave;
                }
            }
            return -1;
        }

        private void ClearStantionList()
        {
            foreach (var pair in this.OrderSchemePairs)
            {
                if (pair.Station1 != null && pair.Station1.IsExpired)
                {
                    pair.Station1 = null;
                }
                if (pair.Station2 != null && pair.Station2.IsExpired)
                {
                    pair.Station2 = null;
                }
            }
            this.OrderSchemePairs = this.OrderSchemePairs.Where(pair => !pair.IsEmpty).ToList();
        }

        private void UpdateSignal(SendSignalDTO signalDTO)
        {
            int WaveShift = 1500;
            int FrequencyShift = 2325000;
            
            var id = signalDTO.Id;
            var signal = signalDTO.Signal;
            if (signal != null)
            {
                signal.Wave -= WaveShift;
                signal.Frequency -= FrequencyShift;                           
            }
            var stantion = this.OrderSchemePairs.SelectMany(pair => new[] { pair.Station1, pair.Station2 })
                   .FirstOrDefault(s => s.Id == id);    
            stantion.UpdateSignal(signal);
        }

        private BroadcastSignal GetBroadcastSignal()
        {
            var signals = this.OrderSchemePairs.SelectMany(pair => new[] { 
                pair.Station1 == null ? null : pair.Station1.Signal, 
                 pair.Station2 == null ? null : pair.Station2.Signal })
                 .Where(s => s != null)
                 .ToList();
            return new BroadcastSignal(signals);
        }

    }
}
