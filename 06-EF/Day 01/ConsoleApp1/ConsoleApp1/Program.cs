using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            SchoolDbContext context = new SchoolDbContext();
            context.Database.EnsureCreated();

            //CRUD 

            //Create
            //Student s1 = new Student() {  Name = "amira", Age = 18 }; //Memory
            //context.Student.Add(s1);   //Local
            //context.SaveChanges();    //Commit changes on database


            //Student s1 = new Student() { Name = "asmaa", Age = 20 };
            //Student s2 = new Student() { Name = "amir", Age = 19 };
            //context.Student.AddRange(s1, s2);
            //context.SaveChanges();


            //Read       
            //var result = context.Student.ToList();
            //var result = context.Student.Where(s => s.Age > 19);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //Update
            //var result = context.Student.Where(s => s.Id == 4).First();
            //var result = context.Student.FirstOrDefault(s => s.Id == 4);
            //if (result != null)
            //    result.Name = "sameh";
            //context.Student.Update(result);
            //context.SaveChanges();


            //Delete
            //var result = context.Student.FirstOrDefault(s => s.Id == 1);
            //if (result != null)
            //    context.Student.Remove(result);  // local
            //context.SaveChanges();


        }
    }
}
