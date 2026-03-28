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
            var departments = context.Departments.ToList();

            List<string> Locations = new List<string>();
            Locations.Add("Cairo");
            Locations.Add("Giza");
            Locations.Add("Alex");

            ViewData["data"] = Locations;
            ViewBag.data2 = Locations;


            return View(departments);
            //return View("Index", departments);
            //return View("Index");
            //return View();
        }

        //Department/Details/2
        public IActionResult Details(int id)
        {
          var dept = context.Departments.FirstOrDefault(d=>d.Id == id);
            return View(dept);
        }
    }
}
