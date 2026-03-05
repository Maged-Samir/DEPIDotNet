using Azure.Core;
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
            //Student S1 = new Student() {  Name = "Ehab", Age = 21 };
            //Student S2 = new Student() { Name = "Ahmed", Age = 19 };
            ////context.Students.Add(S1);
            //context.Students.AddRange(S1, S2);
            //context.SaveChanges();


            //Read
            //var result = context.Students.Where(s => s.Age > 19);

            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Update
            //var result = context.Students.Where(s => s.Id == 3).First();
            //var result = context.Students.FirstOrDefault(s=>s.Id == 3);
            //result.Name = "Omnia";
            //result.Age = 18;
            //context.Students.Update(result);
            //context.SaveChanges();


            //Delete 
            //var result = context.Students.FirstOrDefault(s => s.Id == 2);
            //context.Students.Remove(result);
            //context.SaveChanges();

        }
    }
}
