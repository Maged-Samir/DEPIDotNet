using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        //api/Product
        //https://localhost:7216/api/Product
        //[HttpGet]
        //public List<Product> GetAll()
        //{
        //    var products = Context.Products.ToList();
        //    return products;
        //}

        [HttpGet]
        public ActionResult<List<Product>> GetAll()
        {
            var products = Context.Products.ToList();
            return Ok(products);
        }

        //api/Product/2
        //https://localhost:7216/api/Product/4
        //[HttpGet("{id}")]
        //public Product GetById(int id)
        //{
        //   return Context.Products.SingleOrDefault(p => p.Id == id);
        //}

        [HttpGet("{id}")]
        public ActionResult<Product> GetById(int id)
        {
            var product = Context.Products.SingleOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            else
                return Ok(product);

        }

        ////https://localhost:7216/api/Product/name/Printer
        //[HttpGet("name/{name}")]
        //public Product GetByName(string name)
        //{
        //    return Context.Products.SingleOrDefault(p => p.Name == name);
        //}

        [HttpPost]
        public ActionResult<Product> AddNewProduct([FromBody] Product product)
        {
            Context.Products.Add(product);
            return Created();
        }

        [HttpPut("{id}")]
        public ActionResult<Product> UpdateProduct(int id, [FromBody] Product product)
        {
            var existingProduct = Context.Products.SingleOrDefault(p => p.Id == id);

            if (existingProduct == null)
            {
                return NotFound();
            }

            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            existingProduct.Description = product.Description;

            return NoContent();

        }

        [HttpDelete]
        public ActionResult<Product> DeleteById(int id)
        {
            var existingProduct = Context.Products.SingleOrDefault(p => p.Id == id);

            Context.Products.Remove(existingProduct);

            return existingProduct;
        }

    }
}
