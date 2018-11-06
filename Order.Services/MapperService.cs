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
                DTOcustomers.Add(
                    new CustomerDTO(
                       customer.FirstName,
                       customer.LastName,
                       customer.EmailAddress,
                       customer.Address,
                       customer.PhoneNumber));
            }
            return DTOcustomers;
        }

    }
}
