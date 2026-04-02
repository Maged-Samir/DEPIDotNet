using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    {
        //Product/GetAll
        public IActionResult GetAll()
        {
            var products = Context.Products.ToList();
            return View("GetAll", products);
        }
        //Product/Details/id
        public IActionResult GetDetails(int id)
        {
            var product = Context.Products.SingleOrDefault(p => p.Id == id);
            return View("GetDetails", product);
        }
    }
}
