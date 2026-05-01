using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApp.Context;
using WebApp.Managers;
using WebApp.Models;
using WebApp.Repos;

namespace WebApp.Controllers
{
    [Authorize(Roles ="Admin")]
    public class DepartmentController : Controller
    {
        //SchoolDbContext context = new SchoolDbContext();

        /*DepartmentRepository departmentRepository;*/ //= new DepartmentRepository();

        IDepartmentManager departmentRepository;
        public DepartmentController(IDepartmentManager departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }
        public IActionResult Index()
        {
            List<string> Locations = new List<string>()
            { "Cairo" , "Giza" ,"Menofia" ,"Mansoura" };
            ViewData["data"] = Locations;
            ViewBag.data2 = Locations;
            var departments = departmentRepository.GetAll();
            return View(departments);
        }
        public IActionResult Details(int id)
        {
            var department = departmentRepository.GetById(id);
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
                departmentRepository.Insert(department);
                return RedirectToAction("Index");
            }
            return View("New");
        }
        public IActionResult Edit(int id)
        {
            var department = departmentRepository.GetById(id);
            return View(department);
        }
        public IActionResult SaveEdit(int id, Department department)
        {
            if (id != null)
            {
                departmentRepository.Update(id, department);
                return RedirectToAction("Index");
            }
            return View("Edit", department);
        }
        public IActionResult Delete(int id)
        {
            if (id != null)
            {
                departmentRepository.Delete(id);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
