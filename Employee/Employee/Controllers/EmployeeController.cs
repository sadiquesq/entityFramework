using Employee.models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;



namespace Employee.Controllers 
{

    [ApiController]
    [Route("api/[Controller]")]
    public class EmployeeControllers : ControllerBase
    {
        static public List<Employees> employees = new List<Employees>
        {
            new Employees{Id=2,Name="ramu",Position="tester",Age=21,Department="test"}
        };



        [HttpGet("get_request")]

        public ActionResult Getemployee()
        {
            return Ok(employees);
        }

        [HttpPost("{id}")]
        public ActionResult AddEmployee(int id,[FromBody] Employees newemployee)
        {
            //newemployee.Id = employees.Count + 1;
            var del = employees.FirstOrDefault(x => x.Id ==id);
            if(del != null)
            {
                return BadRequest("id already in the list");
            }
            employees.Add(newemployee);
            return Ok(employees);
        }

        [HttpPut("{id}")]

        public ActionResult UpdateEmployee(int id, Employees newemployees)
        {
            var emp = employees.FirstOrDefault(x => x.Id == id);
            if (emp == null)
            {
                return NotFound();
            }

            emp.Name = newemployees.Name;
            emp.Position = newemployees.Position;
            emp.Age = newemployees.Age;
            emp.Department = newemployees.Department;
            return Ok(newemployees);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteEmployee(int id)
        {
            var del = employees.FirstOrDefault(x => x.Id == id);
            if(del == null)
            {
                return NotFound();
            }
            else
            {
                employees.Remove(del);
                return Ok(del);
            }
            
        }

    }



}
