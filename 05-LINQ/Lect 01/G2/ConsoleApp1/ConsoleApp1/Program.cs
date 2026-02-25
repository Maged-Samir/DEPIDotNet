//using System.Collections;

//Console.WriteLine("Top Level Statements");
#region Class & Struct
//Student s = new Student(101, "Hossam", 20);
//Console.WriteLine(s.ToString()); 
#endregion

#region Interface
//((ITest)s).Sum();
//ITest s = new Student(101, "Hossam", 20);
//s.Sum(); 
#endregion

#region Object Intializer
//Object Intializer 
//Student s1 = new Student() { Id = 101, Name = "Mohamed" };
//Console.WriteLine(s1.ToString());

//Student s1 = new Student();
//Student s2 = new Student(Id:100,Name:"Mahmoud");
//Student s3 = new Student(Name:"Mohammed",Id:100);

//List<string> names = new List<string>()
//{
//   "sss",
//    "sss",
//    "ssss"
//};


#endregion

#region Extention Methods
//string txt = "Ahmed Mohamed Helmy";
//Console.WriteLine(txt.Count());
//Console.WriteLine(Operation.CountWords(txt));
//Console.WriteLine(txt.CountWords()); 
#endregion

#region Implicitly Type Local Variables
//Implicitly Type Local Variables
//var x = 50;

//dynamic x = 10;
//x = "Ahmed";
//dynamic y = null;

#endregion

#region Anonymous Object
////Anonymous Object
//var car = new { Model = 2010, Motor = "Tesla" };

////car.Model = 2011;

//Console.WriteLine(car.ToString());
//Console.WriteLine(car.Motor);
//Console.WriteLine(car.Model);


//Car c1 = new Car(2010, "Tesla");
////c1.Model = 2022;
//Console.WriteLine(c1.ToString());

#endregion    


//LINQ
//EF => EntityFramework

Console.WriteLine("Main");



class Student : ITest
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Student()
    {
        
    }
    public Student(int Id=0, string Name=null, int Age=0)
    {
        this.Id = Id;
        this.Name = Name;
        this.Age = Age;
    }

    public override string ToString()
    {
        return $"{Id} - {Name}";
    }

}
struct Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Employee()
    {

    }
    public Employee(int Id, string Name)
    {
        this.Id = Id;
        this.Name = Name;
    }

    public override string ToString()
    {
        return $"{Id} - {Name}";
    }
}
interface ITest
{
    int Sum()
    {
        return 0;
    }

}
interface Ishape
{
    int Sum()
    { 
        return 0;
    }
}
static class Operation
{
   public static int CountWords(this string word)
    {
        string[] arr =  word.Split(' ');
        return arr.Length;
    }
}
class Car
{
    public int Model { get; init; }
    public string Motor { get; init; }

    public Car(int Model,string Motor)
    {
      this.Model = Model;
      this.Motor = Motor;
    }

    public override string ToString()
    {
        return $"{Model} - {Motor}";
    }
}

