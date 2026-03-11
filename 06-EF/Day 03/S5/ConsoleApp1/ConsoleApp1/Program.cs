using ConsoleApp1.Context;
using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EF");

            SchoolDBContext context = new SchoolDBContext();
            #region Add Departments

            //Department d1 = new Department() { Name = ".Net", Location = "Cairo", Capacity = 20 };
            //Department d2 = new Department() { Name = "Testing", Location = "Giza", Capacity = 15 };

            //context.Departments.AddRange(d1,d2);
            //context.SaveChanges(); 
            #endregion
            #region Add Students
            //Student s1 = new Student() { Name = "Ahmed Mohamed", Age = 15, Address = "Menofia", DepartmentId = 1 };

            //Student s2 = new Student() { Name = "Omar Samy", Age = 22, Address = "Cairo", DepartmentId = 1 };

            //Student s3 = new Student() { Name = "Mostafa Mahmoud", Age = 21, Address = "Giza", DepartmentId = 1 };

            //Student s4 = new Student() { Name = "Esraa Ahmed", Age = 20, Address = "Menofia", DepartmentId = 2 };

            //context.Students.AddRange(s1,s2, s3,s4);
            //context.SaveChanges(); 
            #endregion
            #region Loading Related Data
            //Lazy Loading   => No Navigation Properity Come
            //var students = context.Students.ToList();
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}

            //Egger Loading
            //var students = context.Students.Include(s=>s.Department).ToList();
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //} 
            #endregion


        }
    }
}
