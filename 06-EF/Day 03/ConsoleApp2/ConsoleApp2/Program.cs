using ConsoleApp2.Models;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            SchoolDBContext schoolDBContext = new SchoolDBContext();

            var stds = schoolDBContext.Students.ToList();

            foreach (var student in stds)
            {
                Console.WriteLine(student);
            }

        }
    }
}
