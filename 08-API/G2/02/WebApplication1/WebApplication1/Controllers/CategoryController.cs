using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        PointOfSaleContext _context ; //= new PointOfSaleContext();

        public CategoryController(PointOfSaleContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Category>> GetAll()
        {
            return _context.Categories.Include(c=>c.Products).ToList();
        }
        [HttpPost]
        public ActionResult CreateNewCategory([FromBody]Category category)
        {
           _context.Categories.Add(category);
           _context.SaveChanges();
            return Created();
        }


    }
}
