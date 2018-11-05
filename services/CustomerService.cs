using databases;
using domain;
using System;

namespace services
{
    public class CustomerService
    {

        public void SaveCustomerInCustomerDb(Customer customer)
        {
            CustomerDb.Customers.Add(customer);
        }

    }
}
