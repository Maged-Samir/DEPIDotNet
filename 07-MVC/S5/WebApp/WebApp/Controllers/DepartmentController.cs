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
        public IActionResult New()
        {
            return View();
        }
        public IActionResult SaveNew(Department department)
        {
            if (department.Name != null) //Validation
            {
                //Save on Database
                context.Departments.Add(department);
                context.SaveChanges();
                //return View("Index");  //Error => need list of Departments
                return RedirectToAction("Index");
            }
            return View("New");
        }
        public IActionResult Edit(int id)
        {
            var department = context.Departments.FirstOrDefault(d => d.Id == id);
            return View(department);
        }
        public IActionResult SaveEdit(int id, Department department)
        {
            var oldDepartment = context.Departments.FirstOrDefault(d => d.Id == id);
            if (oldDepartment != null)
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
            var depratment = context.Departments.FirstOrDefault(d => d.Id == id);

            if (depratment != null)
            {
                //Delete From Database
                context.Departments.Remove(depratment);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

    }
}
