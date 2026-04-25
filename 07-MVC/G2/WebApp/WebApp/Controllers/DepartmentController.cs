using Microsoft.AspNetCore.Mvc;
using WebApp.Managers;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class DepartmentController : Controller
    {
        //DepartmentRepository departmentRepository = new DepartmentRepository();

        IDepartmentManager departmentRepository;
        public DepartmentController(IDepartmentManager _departmentRepository)
        {
            departmentRepository = _departmentRepository;
        }

        public IActionResult Index()
        {
            var departments = departmentRepository.GetAll();
            List<string> Locations = new List<string>();
            Locations.Add("Cairo");
            Locations.Add("Giza");
            Locations.Add("Alex");
            ViewData["data"] = Locations;
            ViewBag.data2 = Locations;
            return View(departments);
        }
        public IActionResult Details(int id)
        {
            var dept = departmentRepository.GetById(id);
            return View(dept);
        }
        public IActionResult New()
        {
            return View();
        }
        public IActionResult SaveNew(Department dept)
        {
            if (dept.Name != null)
            {
                departmentRepository.Insert(dept);
                return RedirectToAction("Index");
            }
            return View("New");
        }
        public IActionResult Edit(int id)
        {
            var dept = departmentRepository.GetById(id);
            return View(dept);
        }
        public IActionResult SaveEdit(Department dept)
        {
            if (dept.Name != null)
            {
                departmentRepository.Update(dept.Id, dept);
                return RedirectToAction("Index");
            }
            return View("Edit");
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
