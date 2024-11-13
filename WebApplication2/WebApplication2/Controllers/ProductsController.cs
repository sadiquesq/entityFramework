using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace WebApplication2.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static readonly List<string> products = new List<string>
        {
            "Laptop", "Smartphone", "Tablet"
        };
        private static readonly List<int> numbers = new List<int>
            {
                100,200,300
            };

        [HttpGet("list2")]
        public ActionResult GetNumber()
        {
            return Ok(numbers);
        }


        [HttpGet]
        public ActionResult<IEnumerable<string>> GetProducts()
        {
            return Ok(products);
        }

        [HttpGet("idghg")]
        public ActionResult<string> GetProduct(int id)
        {
            if (id >= 0 && id < products.Count)
                return Ok(products[id]);
            return NotFound("Product not found.");
        }

        [HttpPost]
        public ActionResult AddProduct([FromBody] string product)
        {
            products.Add(product);
            return Ok(products);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateProduct(int id, string product)
        {


            products[id] = product;
            return Ok(product);
        }

        [HttpDelete]
        public ActionResult RemoveProduct([FromBody] string product)
        {
            products.Remove(product);
            return Ok(products);
        }

    }

}
