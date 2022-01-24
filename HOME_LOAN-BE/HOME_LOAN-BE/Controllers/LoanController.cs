using HOME_LOAN_BE.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HOME_LOAN_BE.Controllers
{
    [Route("api/Loan")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly ILoanRepository<Loan> _context;

        public LoanController(ILoanRepository<Loan> context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<Loan> loans = _context.GetAll();
            return Ok(loans);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Loan loans = _context.Get(id);
            return Ok(loans);
        }


        [HttpPost]
        public IActionResult Post(Loan loan1)
        {
            if (loan1 == null)
            {
                return BadRequest("loan is null.");
            }

            _context.Add(loan1);
            //return NoContent();
            return Ok(loan1);
        }



        // PUT: api/loan1/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Loan loan1)
        {
            Loan loan1ToUpdate = _context.Get(id);
            if (loan1ToUpdate == null)
            {
                return NotFound("The loan record couldn't be found.");
            }

            _context.Update(loan1ToUpdate, loan1);
            return Ok(loan1ToUpdate);
            //return NoContent();
        }

        // DELETE: api/loan1/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Loan loan1 = _context.Get(id);
            if (loan1 == null)
            {
                return NotFound("The loan record couldn't be found.");
            }

            _context.Delete(loan1.Loan_id);
            return NoContent();
        }
    }
}
