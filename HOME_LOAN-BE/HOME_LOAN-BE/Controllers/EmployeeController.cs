using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HOME_LOAN_BE.Controllers
{
    [Route("api/Employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IDataRepository<Employee_Details> _context;

        public EmployeeController(IDataRepository<Employee_Details> context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<Employee_Details> employees = _context.GetAll();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Employee_Details employees = _context.Get(id);
            return Ok(employees);
        }


        [HttpPost]
        public IActionResult Post(Employee_Details employee)
        {
            if (employee == null)
            {
                return BadRequest("employee is null.");
            }

            _context.Add(employee);
            //return NoContent();
            return Ok(employee);
        }



        // PUT: api/employee/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Employee_Details employee)
        {
            Employee_Details employeeToUpdate = _context.Get(id);
            if (employeeToUpdate == null)
            {
                return NotFound("The employee record couldn't be found.");
            }

            _context.Update(employeeToUpdate, employee);
            return Ok(employeeToUpdate);
            //return NoContent();
        }

        // DELETE: api/employee/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Employee_Details employee = _context.Get(id);
            if (employee == null)
            {
                return NotFound("The employee record couldn't be found.");
            }

            _context.Delete(employee.Emp_ID);
            return NoContent();
        }
    }
}
