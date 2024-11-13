using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RelationShip.DTO;
using RelationShip.models;
using RelationShip.services;

namespace RelationShip.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMainServices _mainServices;


        public EmployeeController(IMainServices mainServices)
        {
            _mainServices = mainServices;
        }


        [HttpPost]


        public async Task<IActionResult> Post(Employee employee)
        {
            {
                await _mainServices.insertIntoEmployee(employee);
                return Ok(employee);

            }
        }
    }
}
