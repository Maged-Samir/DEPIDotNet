using ConsoleApp1.Context;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EF");

            SchoolDbContext context = new SchoolDbContext();

            //var stds = context.Students.Select(x => x).ToList();   //LazyLoading

            //foreach(var item in stds)
            //{
            //    Console.WriteLine(item);
            //}

            //var stds = context.Students.Include(x=>x.Department).Select(x => x).ToList();   //EggerLoading

            //foreach (var item in stds)
            //{
            //    Console.WriteLine(item);
            //}




        }
    }
}
