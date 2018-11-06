using Order.Database;
using Order.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Services.Tests
{
    public class OrderService
    {

        public void CreateNewOrder(List<Item> items)
        {
            foreach (var item in items)
            {
                if (item.Amount > 0)
                {
                   // item.ShippingDate = DateTime.Today.AddDays(1);
                }
                else
                {
                  //  item.ShippingDate = DateTime.Today.AddDays(7);
                }

               // OrderDb.orders.Add(item);
            }

        }

    }
}
