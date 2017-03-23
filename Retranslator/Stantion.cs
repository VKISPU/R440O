using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareTypes.SignalTypes;

namespace Retranslator
{
    public class Stantion
    {
        const long ExpireTime = 2;

        public string Id;
        public Signal Signal;
        public DateTime LastUpdate;

        public Stantion()
        {
            Signal = null;
            LastUpdate = DateTime.Now;
            Id = Guid.NewGuid().ToString();
        }

        public void UpdateSignal(Signal signal)
        {
            this.Signal = signal;
            LastUpdate = DateTime.Now;
        }

        public bool IsExpired
        {
            get
            {
                return (DateTime.Now - LastUpdate).TotalSeconds > ExpireTime;
            }
        }
    }
}
