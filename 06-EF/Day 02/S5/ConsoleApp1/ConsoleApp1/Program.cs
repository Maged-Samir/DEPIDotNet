using ConsoleApp1.Context;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entity Framework");
            SchoolDbContext context = new SchoolDbContext();

            //CRUD Operations
            //Create
            //Student S1 = new Student() { Name = "Mohamed",Age = 20 }; //Memory 
            //Student S2 = new Student() { Name = "Esraa", Age = 19 }; //Memory 
            //Student S3 = new Student() { Name = "Ali", Age = 22 }; //Memory 
            //context.Students.AddRange(S1,S2,S3);  //Local
            //context.SaveChanges();   //DB

            //Read
            //var result = context.Students.Where(s => s.Age == 19);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Update
            //var result = context.Students.FirstOrDefault(s=>s.Id == 4);
            //result.Age = 18;
            //result.Name = "Samy";
            //context.Students.Update(result);
            //context.SaveChanges();

            //Delete
            //var result = context.Students.FirstOrDefault(s=>s.Id == 2);
            //context.Students.Remove(result);
            //context.SaveChanges();


        }
    }
}
