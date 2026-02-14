Console.WriteLine("LINQ");

#region Intro to LINQ
//Implicity Type Local Variavble (Var)
//Extention Methods
//Anonymous Object var emp = new { id = 20, name = "Ali"};
//Anonymous Method
/*
 * public int Sum (int x ,int Y)
 * {
 *   return x+y;
 * }
 * 
 *  (int x,int y) { return x+y; }
 *  (x,y) return x+y;
 *  (x,y) =>  x+y;
 *  i => i + 1; 
 * 
 */
#endregion

#region LINQ
//LINQ => Language Independant Queries
//Local   => Object - DataSet - XML 
//Remote  => SQL - EF

//List<int> lst = new List<int>() { 9, 8, 1, 2, 3, 4 };


//Using Enumerable 
//var result = Enumerable.Where(lst, i => i > 2);

//Fluent Syntax
//var result = lst.Where(i => i > 2);

//Query Syntax
//var result =  from i in lst
//              where i> 2
//              select i;


//foreach (var i in result)
//{
//    Console.WriteLine(i);
//} 
#endregion          

List<Student> list = new List<Student>()
{
   new Student(3,"Mohamed","Ali",20,"IT"),
   new Student(1,"Gamal","Ahmed",18,"HR"),
   new Student(4,"Yousef","Ibrahem",17,"HR"),
   new Student(5,"Mona","Kamal",18,"HR"),
   new Student(3,"ALi","Hossam",19, "IT")
};

//Filteration
//var result = list.Where(s => s.Id == 4);
//var result = list.Where(s => s.FirstName.Contains("Mo"));
//var result = list.Where(s => s.FirstName.Contains("Mo") && s.Id == 5);
//var result = list.Where(s => s.Age > 18);

//Projection
//var result = list.Select(s => s.FirstName);
//var result = list.Where(s => s.Age > 18).Select(s => s.FirstName);
//var result = list.Select(s => new { FullName = s.FirstName + ' ' + s.LastName , Age = s.Age});

//Ordering
//var result = list.Select(s => s.FirstName).Order();
//var result = list.Select(s => s).OrderBy(s => s.Age);
//var result = list.Select(s => s).OrderBy(s=>s.Age).ThenBy(s=>s.FirstName);
//var result = list.Select(s => s).OrderBy(s => s.Id).Reverse();


//Aggregate Functions
//var result = list.Max(x => x.Age);
//var result = list.Min(x => x.Age);
//var result = list.Average(x => x.Age);
//Console.WriteLine(result);

//Slicing 
//List<int> grads = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//var result = grads.Take(3);
//var result = grads.TakeLast(3);
//var result = grads.TakeWhile(i => i < 3);

//var result = grads.Skip(3);
//var result = grads.SkipLast(4);
//var result = grads.SkipWhile(i=> i < 3);

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


//var result = list.First(s => s.Id == 3);
//var result = list.FirstOrDefault(s => s.Id == 3);
//var result = list.Last();
//var result = list.FirstOrDefault(s => s.Id == 3);
//var result = list.Single(s => s.Id == 3);
//var result = list.SingleOrDefault(s => s.Id == 3);
//Console.WriteLine(result);

//var result = list.All(s => s.Age > 12);
//Console.WriteLine(result);

//var result = list.Any(s => s.FirstName == "ALi");
//Console.WriteLine(result);

//Set Operators
//List<int> lst1 = new List<int>() { 1, 2, 3, 4 };
//List<int> lst2 = new List<int>() { 3, 4,5,6 };

//var test = lst1.Union(lst2);
//var test = lst1.Intersect(lst2);
//var test = lst1.Except(lst2);

//foreach (var item in test)
//{
//    Console.WriteLine(item);
//}

//Grouping
//var result = list.GroupBy(s => s.Department);
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
//List<int> grads = new List<int>() { 1, 2, 3, 4, 5 };

//var result = grads.Select(s => s);

//grads.Add(20);

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

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
        return $"{Id} - {FirstName} {LastName} - {Age}";
    }
}
