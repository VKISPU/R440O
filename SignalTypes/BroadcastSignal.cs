using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SignalTypes
{
    public class BroadcastSignal
    {
        public List<Signal> Signals { get; set; }

        public BroadcastSignal()
        {
            Signals = new List<Signal>();
        }
    }
}
