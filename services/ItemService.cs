using System;
using System.Collections.Generic;
using System.Text;
using Order.Domain;
using Order.Database;

namespace Order.Services
{
    public class ItemService
    {

        public void SaveItemInItemDb(Item item)
        {
            ItemDb.Items.Add(item);
        }

        public List<Item> GetAllItemsFromItemDb()
        {
            return ItemDb.Items;
        }
    }
}
