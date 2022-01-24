using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HOME_LOAN_BE.Controllers
{

  [Route("api/Customer")]
    [ApiController]
    public class Customer : ControllerBase
    {
        private readonly IDataRepository<Customer_Details> _context;

        public Customer(IDataRepository<Customer_Details> context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<Customer_Details> customers = _context.GetAll();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Customer_Details customers = _context.Get(id);
            return Ok(customers);
        }


        [HttpPost]
        public IActionResult Post(Customer_Details customer)
        {
            if (customer == null)
            {
                return BadRequest("customer is null.");
            }

            _context.Add(customer);
            //return NoContent();
            return Ok(customer);
        }



        // PUT: api/customer/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Customer_Details customer)
        {
            Customer_Details customerToUpdate = _context.Get(id);
            if (customerToUpdate == null)
            {
                return NotFound("The customer record couldn't be found.");
            }

            _context.Update(customerToUpdate, customer);
            return Ok(customerToUpdate);
            //return NoContent();
        }

        // DELETE: api/customer/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Customer_Details customer = _context.Get(id);
            if (customer == null)
            {
                return NotFound("The customer record couldn't be found.");
            }

            _context.Delete(customer.Customer_id);
            return NoContent();
        }
    }
}
