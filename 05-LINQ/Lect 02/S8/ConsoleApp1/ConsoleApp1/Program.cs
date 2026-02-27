using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }

        public Student() { }
        public Student(int id, string firstName, string lastName, int age, string department)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Department = department;
        }

        public override string ToString()
        {
            return $"{Id} - {FirstName} {LastName} - {Age} ";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ
            //Console.WriteLine("LINQ");
            //Linq => Local - Remote

            //List<int> ints = new List<int>() { 4, 8, 7, 9, 2, 5 };

            //Using Enumerable
            //var result =  Enumerable.Where(ints, i => i > 2);

            //Fluent Syntax
            //var result =  ints.Where(i => i > 2);

            //Query Syntax
            //var result = from i in ints
            //             where i > 2
            //             select i;

            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            List<Student> stds = new List<Student>()
            {
                new Student(3,"Ali","Mohamed",19,"HR"),
                new Student(4,"Ahmed","Amir",21,"SWE"),
                new Student(2,"Ali","Ahmed",20,"SWE"),
                new Student(5,"Sally","Samir",22,"HR"),
                new Student(1,"Mona","Ibrahem",19, "SWE"),
            };

            //Filteration
            //var result = stds.Where(s=>s.Id == 3);
            //var result = stds.Where(s => s.FirstName == "Ali");
            //var result = stds.Where(s => s.FirstName.Contains("Mo"));
            //var result = stds.Where(s => s.FirstName.Contains("Mo") && s.Id ==1);
            //var result = stds.Where(s => s.Age > 19);


            //Projection
            //var result = stds.ToList();
            //var result = stds.Select(s => s.FirstName);
            //var result = stds.Select(s => s.LastName);
            //var result = stds.Select(s => new { FullName = s.FirstName + ' '+s.LastName });
            //var result = stds.Where(s=>s.Age > 19).Select(s => s.FirstName);
            //var result = stds.Select(s => s);

            //Ordering
            //var result = stds.Select(s => s.FirstName).Order();
            //var result = stds.Select(s => s).OrderBy(s=>s.FirstName);
            //var result = stds.Select(s => s).OrderBy(s => s.Id).Reverse();
            //var result = stds.Select(s => s).OrderBy(s=>s.FirstName).ThenBy(s=>s.LastName);


            //Aggregate Functions
            //var result = stds.Max(s=>s.Age);
            //var result = stds.Min(s => s.Age);
            //var result = stds.Average(s => s.Age);
            //Console.WriteLine(result); 


            //Slicing 
            //List<int> grads = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //var result = grads.Take(4);
            //var result = grads.TakeLast(4);
            //var result = grads.TakeWhile(i => i < 4);

            //var result = grads.Skip(4);
            //var result = grads.SkipLast(4);
            //var result = grads.SkipWhile(i=> i < 3);


            //var result = stds.First();
            //var result = stds.FirstOrDefault();

            //var result = stds.Last();
            //var result = stds.LastOrDefault();

            //var result = stds.Single(s => s.Id == 3);
            //var result = stds.SingleOrDefault(s => s.Id == 3);


            //check if all students > 18
            //var result = stds.All(s => s.Age > 18);

            //check if any student called Nada
            //var result = stds.Any(s => s.FirstName == "Nada");
            //Console.WriteLine(result);

            //Set Operators
            //List<int> lst1 = new List<int>() { 1, 2, 3, 4 };
            //List<int> lst2 = new List<int>() { 3, 4,5,6 };

            //var u = lst1.Union(lst2);        // 1,2,3,4,5,6
            //var u = lst1.Intersect(lst2);    // 3,4
            //var u = lst1.Except(lst2);       // 1,2

            //foreach (var item in u)
            //{
            //    Console.WriteLine(item);
            //}


            //var result = stds.GroupBy(s => s.Department);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var student in item)
            //    {
            //        Console.WriteLine(student);
            //    }
            //}



            //Immediate Execution
            //Deffered Execution

            List<int> grads = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            grads.Add(9);

            var result = grads.Select(s => s);

            grads.Add(10);


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }









        }
    }
}
