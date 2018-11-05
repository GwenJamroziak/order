using Order.Database;
using Order.Domain;
using System;
using System.Collections.Generic;

namespace services
{
    public class CustomerService
    {

        public void SaveCustomerInCustomerDb(Customer customer)
        {
            CustomerDb.Customers.Add(customer);
        }

        public List<Customer> GetAllCustomersFromCustomerDb()
        {
            return CustomerDb.Customers;
        }
    }
}
