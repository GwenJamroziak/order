using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Order.Domain;
using Microsoft.AspNetCore.Mvc;
using Order.Services;
using Order.Dto;

namespace Order.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<List<CustomerDTO>> Get()
        {
            CustomerService customerService = new CustomerService();
            MapperService mapperService = new MapperService();
            var customerList = customerService.GetAllCustomersFromCustomerDb();
            return mapperService.CustomerListToDTO(customerList);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] CustomerDTO customerDto)
        {
            CustomerService customerService = new CustomerService();
            MapperService mapperService = new MapperService();
            var customer = mapperService.CustomerDtoToCustomer(customerDto);
            customerService.SaveCustomerInCustomerDb(customer);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
