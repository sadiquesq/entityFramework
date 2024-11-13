using items.models;
using Microsoft.AspNetCore.Mvc;

namespace items.Controllers
{


    [ApiController]
    [Route("api/[Controller]")]
    public class Itemcontroller : ControllerBase
    {


        static public List<Items> _items = new List<Items>
        {
            new Items {Id=1,Name="candy",prices=10},
            new Items {Id=2,Name="soup",prices=30}
        };

        [HttpGet]

        public IActionResult GetItems()
        {
            return Ok(_items);
        }

        [HttpGet("{id}")]

        public IActionResult GetItemById(int id)
        {
            try
            {
                var tel = _items.FirstOrDefault(x => x.Id == id);
                if(tel == null)
                {
                    return NotFound("the id is not found");
                }
                return Ok(tel); 
            }
            catch
            {
                return StatusCode(500, "internal servies error");
               
            }
        }





        [HttpPost("{id}")]

        public IActionResult AddItem(int id, [FromBody] Items newitem)
        {
            var del = _items.FirstOrDefault(x => x.Id == id);
            if (del != null)
            {
                return BadRequest("id already in the list");
            }
            _items.Add(newitem);
            return Ok(_items);
        }





    }


}

