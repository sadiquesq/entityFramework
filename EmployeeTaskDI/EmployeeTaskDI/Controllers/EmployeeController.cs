using EmployeeTaskDI.models;
using EmployeeTaskDI.servies;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeTaskDI.Controllers
{

    [ApiController]
    [Route("api / [Controller]")]
    public class EmployeeController :ControllerBase
    {
        private readonly IMyservies _myservies;

        public EmployeeController(IMyservies myservies)
        {
            _myservies = myservies;
        }

        [HttpGet]
        public IActionResult Getemployees()
        {
            try
            {
                return Ok(_myservies.Getemployee());
            }
            catch
            {
                return StatusCode(500, "internal seriver error");
            }
        }

        [HttpPost]

        public IActionResult AddEmployee([FromBody] Employee newemployee)
        {
            try
            {
                _myservies.AddEmployee(newemployee);
                return CreatedAtAction(nameof(Getemployees), new { id = newemployee.Id }, newemployee);

            }
            catch 
            {
                return StatusCode(500, "internal seriver error");
            }

        }

        [HttpPut]

        public IActionResult UpdateEmployee(int id,[FromBody]Employee newemployee)
        {
            if (newemployee.Id != id) 
            {
                return BadRequest();
            }
            var emp = _myservies.GetEmployeeById(id);
            if (emp == null)
            {
                return NotFound();
            }
            _myservies.UpdateEmployee(newemployee);
            return NoContent();

        }

        [HttpDelete]

        public IActionResult DeleteEmployee(int id)
        {
            var del = _myservies.GetEmployeeById(id);
            if (del == null)
            {
                return NotFound();
            }
            _myservies.DeleteEmployee(id);
            return NoContent();
        }
    }
}
