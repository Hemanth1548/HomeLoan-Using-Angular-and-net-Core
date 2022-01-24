using HOME_LOAN_BE.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HOME_LOAN_BE.Controllers
{
    [Route("api/Status")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly IDataRepository<Status_details> _context;

        public StatusController(IDataRepository<Status_details> context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<Status_details> statuss = _context.GetAll();
            return Ok(statuss);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Status_details statuss = _context.Get(id);
            return Ok(statuss);
        }


        [HttpPost]
        public IActionResult Post(Status_details status)
        {
            if (status == null)
            {
                return BadRequest("status is null.");
            }

            _context.Add(status);
            //return NoContent();
            return Ok(status);
        }



        // PUT: api/status/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Status_details status)
        {
            Status_details statusToUpdate = _context.Get(id);
            if (statusToUpdate == null)
            {
                return NotFound("The status record couldn't be found.");
            }

            _context.Update(statusToUpdate, status);
            return Ok(statusToUpdate);
            //return NoContent();
        }

        // DELETE: api/status/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Status_details status = _context.Get(id);
            if (status == null)
            {
                return NotFound("The status record couldn't be found.");
            }

            _context.Delete(status.statusid);
            return NoContent();
        }
    }
}
