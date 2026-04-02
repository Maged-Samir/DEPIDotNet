using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        //Product/GetAll
        public IActionResult GetAll()
        {
            var products = Context.Products.ToList();
            return View("GetAll", products);
        }
        //Product/GetDeatils/id
        public IActionResult GetDetails(int id)
        {
            var product = Context.Products.FirstOrDefault(p => p.Id == id);
            return View("GetDetails", product);
        }
    }
}
