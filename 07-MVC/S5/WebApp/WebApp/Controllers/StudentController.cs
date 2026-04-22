using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Context;
using WebApp.Models;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class StudentController : Controller
    {
        SchoolDbContext context = new SchoolDbContext();
        public IActionResult Index()
        {
            var students = context.Students.Include(s => s.Department).ToList();
            return View(students);
        }
        public IActionResult Details(int id)
        {
            var student = context.Students.Include(s => s.Department).FirstOrDefault(s => s.Id == id);

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
            var depts = context.Departments.ToList();
            ViewData["data"] = depts;
            return View(std);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveNew(Student std)
        {
            if (std.Name != null)
            {
                //Save on DB
                context.Students.Add(std);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            var depts = context.Departments.ToList();
            ViewData["data"] = depts;
            return View("New", std);
        }
        public IActionResult Edit(int id)
        {
            var student = context.Students.SingleOrDefault(s => s.Id == id);
            ViewData["data"] = context.Departments.ToList();
            return View("EditV2",student);
        }
        public IActionResult SaveEdit(Student student)
        {
            var oldStudent = context.Students.SingleOrDefault(s => s.Id == student.Id);
            if (ModelState.IsValid) //Validation
            {
                oldStudent.Name = student.Name;
                oldStudent.Address = student.Address;
                oldStudent.Grade = student.Grade;
                oldStudent.Division = student.Division;
                oldStudent.DepartmentId = student.DepartmentId;

                context.Students.Update(oldStudent);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["data"] = context.Departments.ToList();
            return View("EditV2", student);
        }
        public ActionResult Delete(int id)
        {
            var student = context.Students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");

        }

        public IActionResult TestHelpers(Department? dept=null)
        {
            return View(dept);
        }
    }
}
