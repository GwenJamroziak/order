using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain
{
    public class Order
    {
        public List<Item> Items { get; set; }
            public int Amount { get; set; }
            public DateTime ShippingDate { get; set; }

        public Order(List<Item> items, int amount, DateTime shippingDate)
        {
            Items = items;
            Amount = amount;
            ShippingDate = shippingDate;
        }
    }
}
