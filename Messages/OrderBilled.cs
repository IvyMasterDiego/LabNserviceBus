using NServiceBus;
using System;

namespace Messages
{
    public class OrderBilled : IEvent
    {
        public string OrderId { get; set; }
        public DateTime date = DateTime.Now;
    }
}