using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Context;
using WebApp.Managers;
using WebApp.Models;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class StudentController : Controller
    {
        //StudentRepository studentManger;
        //DepartmentRepository departmentManger;
        //public StudentController()
        //{
        //    studentManger = new StudentRepository();
        //    departmentManger = new DepartmentRepository();
        //}

        IStudentManager studentManger;
        IDepartmentManager departmentManger;

        public StudentController(IStudentManager studentManager, IDepartmentManager departmentManager)
        {
            this.studentManger = studentManager;
            this.departmentManger = departmentManager;
        }

        public IActionResult Details(int id)
        {
            var student = studentManger.GetById(id);

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
            var deprtments = studentManger.GetAll();
            return View(deprtments);
        }
        public IActionResult New(Student? student = null)
        {
            var departments = departmentManger.GetAll();
            ViewData["data"] = departments;
            return View(student);
        }
        public IActionResult SaveNew(Student student)
        {
            if (student.Name != null)
            {
                studentManger.Insert(student);
                return RedirectToAction("Index");
            }
            ViewData["data"] = departmentManger.GetAll();
            return View("New", student);
        }
        public IActionResult Edit(int id)
        {
            var student = studentManger.GetById(id);
            ViewData["data"] = departmentManger.GetAll();
            return View("EditV2", student);
        }
        public IActionResult SaveEdit(Student student)
        {
            if (ModelState.IsValid) //validation
            {
                studentManger.Update(student);
                return RedirectToAction("Index");
            }
            ViewData["data"] = departmentManger.GetAll();
            return View("EditV2", student);
        }
        public IActionResult Delete(int id)
        {
            if (id != null)
            {
                studentManger.Delete(id);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        public IActionResult TestHelpers()
        {
            return View();
        }
    }
}
