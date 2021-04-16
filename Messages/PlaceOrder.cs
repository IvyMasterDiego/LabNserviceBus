﻿using NServiceBus;
using System;

namespace Messages
{
    public class PlaceOrder :
        ICommand
    {
        public string OrderId { get; set; }
        public DateTime date = DateTime.Now;
    }
}