using Microsoft.AspNetCore.Mvc;
using WebApp.Context;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class DepartmentController : Controller
    {
        SchoolDbContext context = new SchoolDbContext();
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
        public IActionResult New()
        {
            return View();
        }
        public IActionResult SaveNew(Department department)
        {
            if (department.Name != null)  //Validation
            {
                //Save on DB
                context.Departments.Add(department);
                context.SaveChanges();
                //return View("Index");  //XXXXXXX
                return RedirectToAction("Index");
            }
            return View("New");
        }
        public IActionResult Edit(int id)
        {
            var department = context.Departments.SingleOrDefault(d => d.Id == id);
            return View(department);
        }
        public IActionResult SaveEdit(Department department)
        {
            var oldDepartment = context.Departments.SingleOrDefault(d => d.Id == department.Id);

            if (department.Name != null)
            {
                oldDepartment.Name = department.Name;
                oldDepartment.Location = department.Location;

                context.Departments.Update(oldDepartment);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Edit", department);
        }
        public IActionResult Delete(int id)
        {
            var department = context.Departments.SingleOrDefault(d => d.Id == id);
            if(department != null)
            {
                context.Departments.Remove(department);
                context.SaveChanges() ;
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

    }
}
