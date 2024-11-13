using DemoDI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class StudentsController : ControllerBase
    {

        //private readonly Iservices _iservices;

        //public StudentsController(Iservices iservices)
        //{
        //    _iservices = iservices;
        //}
        StudentServices _services = new StudentServices();
        [HttpGet]

        public ActionResult GetStudents()
        {
            return Ok(_services.GetStudents());
        }

        [HttpGet("{id}")]

        public ActionResult GetStudentById(int id)
        {
            var del = _services.GetStudentById(id);
            if (del != null)
            {
                return Ok(del);
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteStudentById(int id) 
        {
           var del = _services.GetStudentById(id);
            if(del == null)
            {
                return NotFound();
            }
             _services.DeleteStudent(id);
            return NoContent();

        }
    }
}
