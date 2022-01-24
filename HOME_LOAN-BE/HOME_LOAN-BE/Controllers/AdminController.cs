using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HOME_LOAN_BE.Controllers
{
    [Route("api/Admin")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IDataAdmin<Admin_Details> _context;

        public AdminController(IDataAdmin<Admin_Details> context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult VerifyAdmin(Admin_Details model)
        {
            var currentAdmin = _context.ValidateAdmin(model);
            if (currentAdmin == null)
                return NotFound("User Not Found");
            return Ok(currentAdmin);

        }

    }
}
