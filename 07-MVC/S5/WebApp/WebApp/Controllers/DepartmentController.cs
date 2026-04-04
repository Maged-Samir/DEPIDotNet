using Microsoft.AspNetCore.Mvc;
using WebApp.Context;

namespace WebApp.Controllers
{
    public class DepartmentController : Controller
    {
        SchoolDbContext context = new SchoolDbContext();
        // Department/Index
        public IActionResult Index()
        {
            List<string> Locations = new List<string>()
            { "Cairo" , "Giza" ,"Menofia" ,"Mansoura" };

            ViewData["data"] = Locations;
            ViewBag.data2 = Locations;

            var departments = context.Departments.ToList();
            return View(departments);
            //return View("Index", departments);
            //return View("Index");
            //return View();
        }

        public IActionResult Details(int id)
        {
           var department = context.Departments.FirstOrDefault(x => x.Id == id);
           return View(department);
        }
    }
}
