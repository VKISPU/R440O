using System.Collections.Generic;
namespace SignalTypes
{
    /// <summary>
    /// Одиночный элемент сигнала, содержит номер потока, группы и список каналов.
    /// </summary>
    public class SignalElement
    {
        public SignalElement(int flow, int group, double[] chanels)
        {
            Flow = flow;
            Group = group;
            Chanels = new List<Chanel>();

            foreach (var chanel in chanels)
            {
                Chanels.Add(new Chanel(chanel));
            }
        }

        public SignalElement(int flow, int group, Chanel[] chanels)
        {
            Flow = flow;
            Group = group;
            Chanels = new List<Chanel>();

            foreach (var chanel in chanels)
            {
                Chanels.Add(chanel);
            }
        }

        public SignalElement(double[] chanels)
        {
            Flow = 9;
            Group = 9;

            Chanels = new List<Chanel>();

            foreach (var chanel in chanels)
            {
                Chanels.Add(new Chanel(chanel));
            }
        }
        
        /// <summary>
        /// Информационный поток в котором передаётся сигнал.
        /// </summary>
        public int Flow { get; private set; }

        /// <summary>
        /// Информационная группа в которой передаётся сигнал.
        /// </summary>
        public int Group { get; private set; }

        /// <summary>
        /// Каналы с определённой скоростью передачи информации.
        /// </summary>
        public List<Chanel> Chanels { get; private set; }

        public void SetInformationInChanelByNumber(int numberOfChanel, Chanel signal)
        {
            var speed = Chanels[numberOfChanel].Speed;
            Chanels[numberOfChanel] = new Chanel(speed, signal.InformationString);
        }
    }
}