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
        public IActionResult Details(int id)
        {
            //var student = context.Students.FirstOrDefault(s=>s.Id == id);
            var student = context.Students.Include(s => s.Department).FirstOrDefault(s => s.Id == id);


            StudentDepartmentViewModel studentDeptViewModel = new StudentDepartmentViewModel();

            studentDeptViewModel.Id = student.Id;
            studentDeptViewModel.Name = student.Name;
            studentDeptViewModel.Address = student.Address;
            studentDeptViewModel.DepartmentName = student.Department.Name;

            if (studentDeptViewModel.DepartmentName == "Testing")
            {
                studentDeptViewModel.Color = "Red";
            }
            else
            {
                studentDeptViewModel.Color = "Orange";
            }


            return View(studentDeptViewModel);
        }
        public IActionResult Index()
        {
            var stds = context.Students.Include(s => s.Department).ToList();
            return View(stds);
        }
        public IActionResult New(Student? std = null)
        {
            var depts = context.Departments.ToList();
            ViewData["data"] = depts;
            return View(std);
        }
        public IActionResult SaveNew(Student student)
        {
            if (student.Name != null) //Validation
            {
                //Save on DB
                context.Students.Add(student);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            var depts = context.Departments.ToList();
            ViewData["data"] = depts;
            return View("New", student);
        }
        public IActionResult Edit(int id)
        {
            var std = context.Students.FirstOrDefault(std => std.Id == id);
            ViewData["data"] = context.Departments.ToList();
            return View("EditV2",std);
        }
        public IActionResult SaveEdit(Student student)
        {

            var std = context.Students.Include(s => s.Department).FirstOrDefault(s => s.Id == student.Id);
            if (std != null)
            {
                std.Name = student.Name;
                std.Address = student.Address;
                //std.Department = context.Departments.SingleOrDefault(s=>s.Id==student.Department.Id);
                std.DepartmentId = student.DepartmentId;

                context.Students.Update(std);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Edit", student);
        }
        public IActionResult Delete(int id)
        {
            var std = context.Students.FirstOrDefault(s => s.Id == id);
            if (std != null)
            {
                context.Students.Remove(std);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        public IActionResult TestHelpers(Department dept)
        {
            return View(dept);
        }
    }
}
