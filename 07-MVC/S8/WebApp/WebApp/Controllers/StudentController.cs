using AspNetCoreGeneratedDocument;
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
            var student = context.Students.Include(s => s.Department).SingleOrDefault(x => x.Id == id);

            //Mapping 
            StudentDepartmentViewModel studentDepartmentVM = new StudentDepartmentViewModel();

            studentDepartmentVM.Name = student.Name;
            studentDepartmentVM.Division = student.Division;
            studentDepartmentVM.Grade = student.Grade;
            studentDepartmentVM.DepartmentName = student.Department.Name;

            if (student.Division == "American")
            {
                studentDepartmentVM.Color = "Red";
            }
            else if (student.Division == "Britich")
            {
                studentDepartmentVM.Color = "Blue";
            }
            else if (student.Division == "German")
            {
                studentDepartmentVM.Color = "Orange";
            }


            return View(studentDepartmentVM);
        }
        public IActionResult Index()
        {
            var deprtments = context.Students.Include(s => s.Department).ToList();
            return View(deprtments);
        }
        public IActionResult New(Student? student = null)
        {
            var departments = context.Departments.ToList();
            ViewData["data"] = departments;
            return View(student);
        }
        public IActionResult SaveNew(Student student)
        {
            if (student.Name != null)
            {
                context.Students.Add(student);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["data"] = context.Departments.ToList();
            return View("New", student);
        }
        public IActionResult Edit(int id)
        {
            var student = context.Students.FirstOrDefault(s => s.Id == id);
            ViewData["data"] = context.Departments.ToList();
            return View(student);
        }
        public IActionResult SaveEdit(Student student)
        {
            var oldStudent = context.Students.FirstOrDefault(s => s.Id == student.Id);
            if (student.Name != null)
            {
                oldStudent.Name = student.Name;
                oldStudent.Age = student.Age;
                oldStudent.Division = student.Division;
                oldStudent.Grade = student.Grade;
                oldStudent.DepartmentId = student.DepartmentId;

                context.Students.Update(oldStudent);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["data"] = context.Departments.ToList();
            return View("Edit", student);
        }
        public IActionResult Delete(int id)
        {
            var Student = context.Students.SingleOrDefault(d => d.Id == id);
            if (Student != null)
            {
                context.Students.Remove(Student);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
