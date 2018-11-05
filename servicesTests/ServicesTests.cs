using databases;
using domain;
using System;
using Xunit;

namespace servicesTests
{
    public class ServicesTests
    {
        [Fact]
        public void GivenCustomerDbAndNewCustomer_WhenAddCustomerToCustomerDb_ThenCustomerDbCountPlusOne()
        {
            //Given
            Customer customerToAdd = new Customer("Gwen", "Jamroziak", "gwen.jamroziak@gmail.com", "Notenlaan 6, Schaffen", "0472697959");
            int customerCountBeforeAdding = CustomerDb.Customers.Count;

            //When
            CustomerDb.Customers.Add(customerToAdd);

            //Then
            int customerCountAfterAdding = CustomerDb.Customers.Count;
            Assert.Equal((customerCountBeforeAdding + 1), customerCountAfterAdding);

        }
    }
}
