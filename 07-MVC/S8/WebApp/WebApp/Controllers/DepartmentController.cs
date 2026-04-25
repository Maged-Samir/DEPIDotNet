using Microsoft.AspNetCore.Mvc;
using WebApp.Context;
using WebApp.Managers;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class DepartmentController : Controller
    {
        //DepartmentRepository departmentManager;
        //public DepartmentController()
        //{
        //  departmentManager = new DepartmentRepository();  
        //}

        IDepartmentManager departmentManager;

        public DepartmentController(IDepartmentManager departmentManager)
        {
            this.departmentManager = departmentManager;
        }

        public IActionResult Index()
        {
            var deprtments = departmentManager.GetAll();
            return View(deprtments);
        }
        public IActionResult Details(int id)
        {
            List<string> Locations = new List<string>() { "Cairo", "Giza", "Menofia", "Mansoura" };
            ViewData["data"] = Locations;
            ViewBag.data1 = Locations;
            var department = departmentManager.GetById(id);
            return View("Details", department);
        }
        public IActionResult New()
        {
            return View();
        }
        public IActionResult SaveNew(Department department)
        {
            if (department.Name != null)
            {
                departmentManager.Insert(department);
                return RedirectToAction("Index");
            }
            return View("New");
        }
        public IActionResult Edit(int id)
        {
            var department = departmentManager.GetById(id);
            return View(department);
        }
        public IActionResult SaveEdit(Department department)
        {
            if (department.Name != null)
            {
                departmentManager.Update(department);
                return RedirectToAction("Index");
            }
            return View("Edit", department);
        }
        public IActionResult Delete(int id)
        {
            if (id != null)
            {
                departmentManager.Delete(id);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
