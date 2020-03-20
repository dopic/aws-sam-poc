using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AWSSAMFramework.Services;
using AWSSAMFramework.Services.DTO;

namespace AWSSAMFramework.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService) => _customerService = customerService;


        // GET api/customers/5
        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            var customer = _customerService.GetCustomer(id);
            if (customer is null) return NotFound();

            return Ok(customer);
        }

        // POST api/customers
        [HttpPost]
        public ActionResult Post([FromBody]Customer customer)
        {
            _customerService.AddCustomer(customer);
            return Created(new Uri($"api/customers/{customer.Id}", UriKind.Relative), customer);
        }
    }
}
