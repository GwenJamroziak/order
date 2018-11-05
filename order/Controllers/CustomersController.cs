using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Order.Domain;
using Microsoft.AspNetCore.Mvc;
using services;

namespace order.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<List<Customer>> Get()
        {
            CustomerService customerService = new CustomerService();
            return customerService.GetAllCustomersFromCustomerDb();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Customer customer)
        {
            CustomerService customerService = new CustomerService();
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
