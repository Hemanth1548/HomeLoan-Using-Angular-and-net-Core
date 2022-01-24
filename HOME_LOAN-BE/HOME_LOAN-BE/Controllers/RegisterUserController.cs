using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HOME_LOAN_BE.Controllers
{
    [Route("api/RegisterUser")]
    [ApiController]
    public class RegisterUserController : ControllerBase
    {
        private readonly IDataAdmin<Admin_Details> _context;

        public RegisterUserController(IDataAdmin<Admin_Details> context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Post(Admin_Details admin)
        {
            if (admin == null)
            {
                return BadRequest("User ID is null.");
            }

            _context.Add(admin);
            //return NoContent();
            return Ok(admin);
        }
    }
}
