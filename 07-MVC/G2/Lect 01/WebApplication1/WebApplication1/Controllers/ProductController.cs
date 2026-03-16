using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        //Product/GetAll
        public IActionResult GetAll()
        {
            var prds = Context.Products.ToList();
            return View("GetAll", prds);
        }

        //Product/Details/101
        public IActionResult Details(int id)
        {
           var product = Context.Products.FirstOrDefault(p => p.Id == id);
           return View("Details", product);
        }
    }
}
