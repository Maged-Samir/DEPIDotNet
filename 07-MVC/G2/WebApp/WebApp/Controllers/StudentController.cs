using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Context;
using WebApp.Managers;
using WebApp.Models;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    [Authorize(Roles ="Studnet")]
    public class StudentController : Controller
    {
        //StudentRepository studentRepository = new StudentRepository();
        //DepartmentRepository departmentRepository = new DepartmentRepository();

        IStudentManager studentRepository;
        IDepartmentManager departmentRepository;

        public StudentController(IStudentManager studentRepository, IDepartmentManager departmentRepository)
        {
            this.studentRepository = studentRepository;
            this.departmentRepository = departmentRepository;
        }

        public IActionResult Details(int id)
        {
            var student = studentRepository.GetById(id);
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
            var stds = studentRepository.GetAll();
            return View(stds);
        }
        public IActionResult New(Student? std = null)
        {
            var depts = departmentRepository.GetAll();
            ViewData["data"] = depts;
            return View(std);
        }
        public IActionResult SaveNew(Student student)
        {
            if (student.Name != null) //Validation
            {
                studentRepository.Insert(student);
                return RedirectToAction("Index");
            }
            var depts = departmentRepository.GetAll();
            ViewData["data"] = depts;
            return View("New", student);
        }
        public IActionResult Edit(int id)
        {
            var std = studentRepository.GetById(id);
            ViewData["data"] = departmentRepository.GetAll();
            return View("EditV2", std);
        }
        public IActionResult SaveEdit(Student student)
        {

            if (ModelState.IsValid)   //Validation
            {
                studentRepository.Update(student.Id, student);
                return RedirectToAction("Index");
            }
            ViewData["data"] = departmentRepository.GetAll();
            return View("EditV2", student);
        }
        public IActionResult Delete(int id)
        {
            if (id != null)
            {
                studentRepository.Delete(id);
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
