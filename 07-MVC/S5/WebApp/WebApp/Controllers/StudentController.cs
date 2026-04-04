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
            var student = context.Students.Include(s=>s.Department).FirstOrDefault(s => s.Id == id);

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
    }
}
