using HOME_LOAN_BE.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HOME_LOAN_BE.Controllers
{
    [Route("api/UserLogin")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {
        private readonly IUserLogin<Customer_Details> _context;

        public UserLoginController(IUserLogin<Customer_Details> context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult IDataUser(Customer_Details model)
        {
            var currentAdmin = _context.ValidateUser(model);
            if (currentAdmin == null)
                return NotFound("User Not Found");
            return Ok(currentAdmin);

        }
    }
}
