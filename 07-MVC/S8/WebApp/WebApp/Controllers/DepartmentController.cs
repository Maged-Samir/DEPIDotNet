using Microsoft.AspNetCore.Mvc;
using WebApp.Context;

namespace WebApp.Controllers
{
    public class DepartmentController : Controller
    {
        SchoolDbContext context = new SchoolDbContext();
        //Department/Index
        public IActionResult Index()
        {
            var deprtments = context.Departments.ToList();
            return View(deprtments);

            //return View("Index", deprtments);
            //return View("Index");
            //return View();
        }

        public IActionResult Details(int id)
        {
            List<string> Locations = new List<string>() { "Cairo", "Giza", "Menofia", "Mansoura" };

            ViewData["data"] = Locations;
            ViewBag.data1 = Locations;


            var department = context.Departments.SingleOrDefault(d => d.Id == id);
            return View("Details", department);
        }
    }
}
