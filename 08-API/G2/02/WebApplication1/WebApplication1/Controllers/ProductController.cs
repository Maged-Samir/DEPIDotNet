using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.Dtos;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        PointOfSaleContext _context;

        public ProductController(PointOfSaleContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = "CoolAuthentication")]
        public ActionResult<List<ProductDto>> GetAll()
        {
            var products = _context.Products.Include(p=>p.Category).ToList();

            var productsDto = products.Select(p => new  ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Qty = p.Qty,
                CategoryName = p.Category.Name
            }).ToList();

            return productsDto;
        }

        [HttpGet("{id}")]
        public ActionResult<ProductDto> GetById(int id)
        {
           var product = _context.Products.Include(p => p.Category).FirstOrDefault(p=>p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            var productDto = new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Qty = product.Qty,
                CategoryName = product.Category.Name
            };

            return productDto;
        }

        [HttpPost]
        public ActionResult CreateProduct([FromBody] ProductCreateDto product)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newProduct = new Product
            {
                Name = product.Name,
                Description = product.Description,
                Qty = product.Qty,
                Price = product.Price,
                CategoryId = product.CategoryId
            };

            _context.Products.Add(newProduct);
            _context.SaveChanges();
            return Created();
        }

        [HttpPut]
        public ActionResult UpdateProduct(int id, [FromBody] ProductUpdateDto product)
        {
           var existingProduct = _context.Products.FirstOrDefault(p => p.Id == id);

            if(existingProduct == null)
            {
                return NotFound();
            }

            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;
            existingProduct.Qty = product.Qty;
            existingProduct.CategoryId = product.CategoryId;

            _context.Products.Update(existingProduct);
            _context.SaveChanges();

            return Ok();

        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            if (product == null) return NotFound();

            _context.Products.Remove(product);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
