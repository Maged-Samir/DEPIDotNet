using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApp.Context;
using WebApp.Managers;
using WebApp.Models;
using WebApp.Repos;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    [Authorize(Roles ="User")]
    public class StudentController : Controller
    {
        //SchoolDbContext context = new SchoolDbContext();

        //StudentRepository studentRepository = new StudentRepository();
        //DepartmentRepository departmentRepository = new DepartmentRepository();

        IStudentmManager studentRepository;
        IDepartmentManager departmentRepository;

        public StudentController(IStudentmManager studentRepository, IDepartmentManager departmentRepository)
        {
            this.studentRepository = studentRepository;
            this.departmentRepository = departmentRepository;
        }

        public IActionResult Index()
        {
            var students = studentRepository.GetAll();
            return View(students);
        }
        public IActionResult Details(int id)
        {
            var student = studentRepository.GetById(id);

            //Mapping
            StudentDepartmentViewModel stdDeptVM = new StudentDepartmentViewModel();
            stdDeptVM.Id = student.Id;
            stdDeptVM.StudentName = student.Name;
            stdDeptVM.Division = student.Division;
            stdDeptVM.DepartmentName = student.Department.Name;

            if (student.Division == "American")
            {
                stdDeptVM.Color = "Red";
            }
            else if (student.Division == "Britich")
            {
                stdDeptVM.Color = "Blue";
            }
            else
            {
                stdDeptVM.Color = "Orange";
            }

            return View(stdDeptVM);
        }
        public IActionResult New(Student? std = null)
        {
            var depts = departmentRepository.GetAll();
            ViewData["data"] = depts;
            return View(std);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveNew(Student std)
        {
            if (std.Name != null)
            {
                studentRepository.Insert(std);
                return RedirectToAction("Index");
            }
            var depts = departmentRepository.GetAll();
            ViewData["data"] = depts;
            return View("New", std);
        }
        public IActionResult Edit(int id)
        {
            var student = studentRepository.GetById(id);
            ViewData["data"] = departmentRepository.GetAll();
            return View("EditV2", student);
        }
        public IActionResult SaveEdit(Student student)
        {
            if (ModelState.IsValid) //Validation
            {
                studentRepository.Update(student.Id, student);
                return RedirectToAction("Index");
            }
            ViewData["data"] = departmentRepository.GetAll();
            return View("EditV2", student);
        }
        public ActionResult Delete(int id)
        {
            if (id != null)
            {
                studentRepository.Delete(id);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        public IActionResult TestHelpers(Department? dept = null)
        {
            return View(dept);
        }
    }
}
