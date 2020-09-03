using System;

namespace MicroRabbit.Domain.Core.Events
{
    public abstract class Event
    {
        public DateTime TimeStemp { get; protected set; }
        public Event()
        {
            this.TimeStemp = DateTime.Now;
        }

    }
}
