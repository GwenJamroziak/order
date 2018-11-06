using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain
{
    public class OrderClass
    {
        public List<Item> Items { get; set; }
            public int Amount { get; set; }
            public DateTime ShippingDate { get; set; }

        public OrderClass(List<Item> items, int amount, DateTime shippingDate)
        {
            Items = items;
            Amount = amount;
            ShippingDate = shippingDate;
        }
    }
}
