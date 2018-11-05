using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain
{
    public class Item
    {
        public string Name {get; set;}
        public string Description {get; set;}
        public decimal Price {get; set;}
        public int Amount {get; set;}

        public Item(string name, string description, decimal price, int amount)
        {
            Name = name;
            Description = description;
            Price = price;
            Amount = amount;
        }
    }
}
