using Order.Database;
using Order.Domain;
using Order.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Order.Services.Tests
{
    public class ItemTests
    {
        [Fact]
        public void GivenItemDbAndNewItem_WhenCreateNewItem_ThenItemDbPlusOne()
        {
            //given
            Item itemToAdd = new Item("Corky Cup", "Coated with real eco-friendly cork", 5.95M, 1);
            int ItemCountBeforeAdding = ItemDb.Items.Count;

            //when
            ItemService itemService = new ItemService();
            itemService.SaveItemInItemDb(itemToAdd);

            //then
            int ItemCountAfterAdding = ItemDb.Items.Count;
            Assert.Equal((ItemCountBeforeAdding + 1), ItemCountAfterAdding);

        }

    }
}
