using Order.Domain;
using Order.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Services
{
    public class MapperService
    {
        public List<CustomerDTO> CustomerListToDTO(List<Customer> customers)
        {
            List<CustomerDTO> DTOcustomers = new List<CustomerDTO>();
            foreach (Customer customer in customers)
            {
                DTOcustomers.Add(CustomerToDTO(customer));
            }
            return DTOcustomers;
        }

        public CustomerDTO CustomerToDTO(Customer customer)
        {
            return new CustomerDTO(
                       customer.FirstName,
                       customer.LastName,
                       customer.EmailAddress,
                       customer.Address,
                       customer.PhoneNumber);
        }

        public List<Customer> DTOcustomersToCustomers(List<CustomerDTO> DTOcustomers)
        {
            List<Customer> customers = new List<Customer>();

            foreach(CustomerDTO DTOcustomer in DTOcustomers)
            {
                customers.Add(CustomerDtoToCustomer(DTOcustomer));
            }

            return customers;
        }

        public Customer CustomerDtoToCustomer(CustomerDTO DTOcustomer)
        {
            return new Customer(
                        DTOcustomer.Id,
                        DTOcustomer.FirstName,
                        DTOcustomer.LastName,
                        DTOcustomer.EmailAddress,
                        DTOcustomer.Address,
                        DTOcustomer.PhoneNumber);
        }
    }
}
