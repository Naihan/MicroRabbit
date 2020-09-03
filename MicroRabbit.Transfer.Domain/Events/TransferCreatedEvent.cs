using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Transfer.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public int From { get; protected set; }
        public int To { get; protected set; }
        public decimal Ammount { get; protected set; }

        public TransferCreatedEvent(int from, int to, decimal ammount)
        {
            this.From = from;
            this.To = to;
            this.Ammount = ammount;
        }
    }
}
