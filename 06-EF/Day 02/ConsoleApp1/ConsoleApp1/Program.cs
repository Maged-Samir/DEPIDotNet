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

            //Student s1 = new Student() { Name = "Ahmed", Age = 15 };
            //Student s2 = new Student() { Name = "Ali", Age = 17 };
            //Student s3 = new Student() { Name = "Mona", Age = 16 };

            //context.Student.AddRange(s1, s2, s3);
            //context.SaveChanges();


            //var stds = context.Student.ToList();
            //var std = context.Student.Where(s => s.Id == 3).First();
            //Console.WriteLine(std);

            //foreach( var  item in stds)
            //{
            //    Console.WriteLine(item);
            //}



        }
    }
}
