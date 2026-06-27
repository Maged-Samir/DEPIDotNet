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
        //https://localhost:7025/api/Product
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

        //api/Product/id
        //https://localhost:7025/api/Product/2
        [HttpGet("{id}")]
        public Product GetById(int id)
        {
            var product = Context.Products.SingleOrDefault(p => p.Id == id);
            return product;
        }

        [HttpGet("name/{name}")]
        public Product GetByName(string name)
        {
            var prod = Context.Products.SingleOrDefault(p => p.Name.Contains(name));
            return prod;
        }

        //[HttpPost]
        //public void CreateProduct([FromBody] Product product)
        //{
        //    Context.Products.Add(product);
        //}

        [HttpPost]
        public ActionResult CreateProduct([FromBody] Product product)
        {
            Context.Products.Add(product);
            return Created();
        }


        //[HttpPut("{id}")]
        //public void UpdateProduct(int id , [FromBody] Product product)
        //{
        //   var existingProduct = Context.Products.SingleOrDefault(p=> p.Id == id);

        //    existingProduct.Name = product.Name;
        //    existingProduct.Price = product.Price;
        //    existingProduct.Description = product.Description;
        //}

        [HttpPut("{id}")]
        public ActionResult UpdateProduct(int id, [FromBody] Product product)
        {
            var existingProduct = Context.Products.SingleOrDefault(p => p.Id == id);

            if(existingProduct == null) 
            {
                return NotFound();
            }

            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            existingProduct.Description = product.Description;
            return NotFound();
        }


        [HttpDelete("{id}")]
        public void DeleteProduct(int id)
        {
            var existingProduct = Context.Products.SingleOrDefault(p => p.Id == id);
            Context.Products.Remove(existingProduct);
        }

    }
}