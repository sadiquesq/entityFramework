using entity_framework.models;
using entity_framework.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using System.Data.Entity;

namespace entity_framework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]

        public async Task<ActionResult<List<student>>> GetStudent()
        {
            var students = await _studentService.GetStudent();
            return Ok(students);
        }



        [HttpPost]
        public async Task<IActionResult> InsertStudent(student student)
        {
            await _studentService.AddStudent(student);
            return Ok();

            //var addedStudent = await _studentService.AddStudent(student);
            //return CreatedAtAction(nameof(GetStudent), new { id = addedStudent.StudentId}, addedStudent);
        }



        [HttpDelete]

        public async Task<IActionResult> DeleteStudent(int id)
        {
            var n =await _studentService.DeleteStudent(id);
            if(!n)
            {
                return NotFound();
            }
            return NoContent();
        }


        [HttpPut]

        public async Task<IActionResult> UpdateStudent(int id, [FromBody] student student1)
        {
            var student = await _studentService.UpdateStudent(id, student1);
            if (student==null) 
            {
                return NotFound();
            }

            return Ok(student);
        }

    }
}
