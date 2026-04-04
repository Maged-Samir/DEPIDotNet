using Microsoft.AspNetCore.Mvc;
using WebApp.Context;
using WebApp.Models;

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
            var dept = context.Departments.FirstOrDefault(d => d.Id == id);
            return View(dept);
        }
        //New Department
        public IActionResult New()
        {
            return View();
        }
        public IActionResult SaveNew(Department dept)
        {
            if (dept.Name != null)
            {
                context.Departments.Add(dept);
                context.SaveChanges();
                //return View("Index");
                return RedirectToAction("Index");
            }
            return View("New");
        }
        //Update Department
        public IActionResult Edit(int id)
        {
            var dept = context.Departments.FirstOrDefault(d => d.Id == id);
            return View(dept);
        }
        public IActionResult SaveEdit(Department dept)
        {
            var oldDepartment = context.Departments.FirstOrDefault(d => d.Id == dept.Id);

            if (oldDepartment != null)
            {
                oldDepartment.Name = dept.Name;
                context.Departments.Update(oldDepartment);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Edit");
        }
        //Delete
        public IActionResult Delete(int id)
        {
            var dept = context.Departments.FirstOrDefault(de => de.Id == id);
            if (dept != null)
            {
                context.Departments.Remove(dept);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
