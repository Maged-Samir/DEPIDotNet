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
        //https://localhost:7246/api/Product
        [HttpGet]
        public ActionResult<List<Product>> GetAllProducts()
        {
            var products = Context.Products.ToList();
            return Ok(products);
        }

        //api/Product/2
        //https://localhost:7246/api/Product/1
        [HttpGet("{id}")]
        public ActionResult<Product> GetProductById(int id)
        {
            var product = Context.Products.SingleOrDefault(p => p.Id == id);
            return Ok(product);
        }

        //api/Product/Mobile
        [HttpGet("name/{name}")]
        //[Route("name/{name}")]
        public Product GetProductByName(string name)
        {
            var product = Context.Products.SingleOrDefault(p => p.Name.Contains(name));
            return product;
        }

        //[HttpPost]
        //public HttpResponseMessage CreateProduct([FromBody] Product product)
        //{
        //    Context.Products.Add(product);
        //    return new HttpResponseMessage(System.Net.HttpStatusCode.Created);
        //}

        [HttpPost]
        public ActionResult CreateProduct([FromBody] Product product)
        {
            Context.Products.Add(product);
            return Created();
        }



        [HttpPut("{id}")]
        public ActionResult UpdateProduct(int id, [FromBody] Product product)
        {
            var existingProduct = Context.Products.SingleOrDefault(p => p.Id == id);
            if(existingProduct == null)
            {
                return NotFound();
            }

            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;

            return NoContent();

        }

        [HttpDelete("{id}")]
        public void DeleteProduct(int id)
        {
            var existingProduct = Context.Products.SingleOrDefault(p => p.Id == id);
            Context.Products.Remove(existingProduct);
        }


    }
}
