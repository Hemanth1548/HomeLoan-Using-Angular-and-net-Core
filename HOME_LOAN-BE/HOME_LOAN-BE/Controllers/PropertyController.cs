using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HOME_LOAN_BE.Controllers
{
    [Route("api/Property")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly IDataRepository<Property_Details> _context;

        public PropertyController(IDataRepository<Property_Details> context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<Property_Details> Property_Details = _context.GetAll();
            return Ok(Property_Details);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Property_Details Property_Details = _context.Get(id);
            return Ok(Property_Details);
        }


        [HttpPost]
        public IActionResult Post(Property_Details propertyDetail)
        {
            if (propertyDetail == null)
            {
                return BadRequest("propertyDetail is null.");
            }

            _context.Add(propertyDetail);
            //return NoContent();
            return Ok(propertyDetail);
        }



        // PUT: api/propertyDetail/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Property_Details propertyDetail)
        {
            Property_Details propertyDetailToUpdate = _context.Get(id);
            if (propertyDetailToUpdate == null)
            {
                return NotFound("The propertyDetail record couldn't be found.");
            }

            _context.Update(propertyDetailToUpdate, propertyDetail);
            return Ok(propertyDetailToUpdate);
            //return NoContent();
        }

        // DELETE: api/propertyDetail/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Property_Details propertyDetail = _context.Get(id);
            if (propertyDetail == null)
            {
                return NotFound("The propertyDetail record couldn't be found.");
            }

            _context.Delete(propertyDetail.Propertyid);
            return NoContent();
        }
    }
}
