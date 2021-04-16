using NServiceBus;
using System;

namespace Messages
{
    #region OrderPlaced

    public class OrderPlaced :
        IEvent
    {
        public string OrderId { get; set; }
        public DateTime date = DateTime.Now;
    }

    #endregion
}