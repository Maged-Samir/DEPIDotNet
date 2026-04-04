using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Context;
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
    }
}
