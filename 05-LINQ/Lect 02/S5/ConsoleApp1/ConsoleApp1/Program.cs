namespace ConsoleApp1
{
    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }


        public Student()
        {

        }

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
            return $"{Id} - {FirstName} {LastName} - {Age}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ");

            #region LINQ
            //List<int> grads = new List<int>() { 4, 5, 8, 9, 2, 6, 40 };

            //Using Enumerable
            //var result = Enumerable.Where(grads, i => i > 5);

            //Fluent Syntax
            //var result = grads.Where(i => i > 5);

            //Query Stntax
            //var result = from i in grads
            //             where i > 5
            //             select i;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion     

            List<Student> stds = new List<Student>()
            {
              new Student(3,"Ahmed","Samy",19,"HR"),
              new Student(4,"Mahmaoud","Ibrahem",20,"SWE"),
              new Student(2,"Rana","Yousef",18,"SWE"),
              new Student(1,"Mohamed","Tarik",22, "SWE"),
              new Student(5,"Ahmed","Akram",21, "HR")
            };

            #region LINQ Queries

            //Filteration
            //var result = stds.Where(s => s.Age > 19);
            //var result = stds.Where(s => s.Id == 3);
            //var result = stds.Where(s => s.FirstName.Contains("ed"));
            //var result = stds.Where(s => s.FirstName.Contains("ed") && s.Id == 1 );

            //Projection
            //var result = stds.Select(i => i.FirstName);
            //var result = stds.Select(i => i.LastName);
            //var result = stds.Where(i=> i.Age > 20).Select(i => i.FirstName);
            //var result = stds.Select(i => new {FullName = i.FirstName + ' '+i.LastName  });

            //Ordering
            //var result = stds.Select(i => i.FirstName).Order();
            //var result = stds.Select(i => i).OrderBy(i=>i.Age);
            //var result = stds.Select(i => i).OrderBy(i => i.Id).Reverse();
            //var result = stds.Select(i => i).OrderBy(i => i.FirstName).ThenBy(i=>i.LastName);


            //Aggregate Functions
            //var result = stds.Max(x => x.Age);
            //var result = stds.Min(x => x.Age);
            //var result = stds.Average(x => x.Age);
            //Console.WriteLine(result);


            //Slicing
            //List<int> lst = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            //var result = lst.Take(4);
            //var result = lst.TakeLast(4);
            //var result = lst.TakeWhile(i => i < 3);

            //var result = lst.Skip(4);
            //var result = lst.SkipLast(4);
            //var result = lst.SkipWhile(i => i < 3);


            //var result = stds.First(s => s.Id == 3);
            //var result = stds.FirstOrDefault(s => s.Id == 3);

            //var result = stds.Last();
            //var result = stds.LastOrDefault();

            //var result = stds.Single(s => s.Id == 3);
            //var result = stds.SingleOrDefault(s => s.Id == 3);


            //Check if All Students > 15  and return Boolean
            //var result = stds.All(s => s.Age > 15);

            //Check if any student > 15 and return Boolean
            //var result = stds.Any(s => s.Age > 20);
            //Console.WriteLine(result);

            ////Set Opertors 
            //List<int> lst1 = new List<int>() { 1, 2, 3, 4 };
            //List<int> lst2 = new List<int>() { 3, 4, 5, 6 };

            ////var result = lst1.Union(lst2);   //1, 2, 3, 4 ,5 ,6
            ///*var result = lst1.Intersect(lst2);*/ // 3, 4
            //var result = lst1.Except(lst2);


            //var result = stds.GroupBy(s => s.Department);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var student in item)
            //    {
            //        Console.WriteLine(student);
            //    }
            //} 
            #endregion

            #region Immediate Vs Deffered
            //Immediate Execution
            //Deffered Execution
            //List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            //var result = ints.Select(i => i);               //Deffered Execution
            ////var result = ints.Select(i => i).ToList();    //Immediate Execution
            ////var result = ints.Max(i => i);                //Immediate Execution


            //ints.Add(9);
            //ints.Add(10);
            //ints.Add(11);
            //ints.Add(12);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


        }
    }
}
