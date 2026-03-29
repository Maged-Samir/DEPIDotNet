using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Context;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class StudentController : Controller
    {
        SchoolDbContext context = new SchoolDbContext();

        //Student/Details/1
        public IActionResult Details(int id)
        {
            //var student = context.Students.FirstOrDefault(s=>s.Id == id);
            var student = context.Students.Include(s=>s.Department).FirstOrDefault(s => s.Id == id);


            StudentDepartmentViewModel studentDeptViewModel = new StudentDepartmentViewModel();

            studentDeptViewModel.Id = student.Id;
            studentDeptViewModel.Name = student.Name;
            studentDeptViewModel.Address = student.Address;
            studentDeptViewModel.DepartmentName = student.Department.Name;

            if(studentDeptViewModel.DepartmentName == "Testing")
            {
                studentDeptViewModel.Color = "Red";
            }
            else
            {
                studentDeptViewModel.Color = "Orange";
            }


            return View(studentDeptViewModel);
        }
    }
}
