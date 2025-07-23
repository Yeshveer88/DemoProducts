using Microsoft.AspNetCore.Mvc;
using ProductsDemoApi.Data;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductsDemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
       Utility utility = new Utility();
        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return utility.getProducts();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            var product = utility.getProducts().FirstOrDefault(p=>p.Id == id);
            return product ?? new Product();
        }

        // POST api/<ProductsController>
        //[HttpPost]
        //public void Post([FromBody] Product product)
        //{
        //}

        // PUT api/<ProductsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public IEnumerable<Product> Delete(int id)
        {
            return utility.getProducts().Where(p => p.Id != id);
        }
    }
}
