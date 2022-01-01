using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Banking.Domain.Events
{
    public class TransferCreatedEvent: Event
    {
        public int From { get; set; }
        public int To { get; set; }
        public float Amount { get; set; }
        public TransferCreatedEvent(int from, int to, float amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
