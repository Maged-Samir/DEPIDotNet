#region Class Vs Struct
//Console.WriteLine("Hello, World!");
//Student s = new Student(101, "Tawfik");
//Console.WriteLine(s.ToString());
//Employee e1 = new Employee(102, "Mohamed");
//Console.WriteLine(e1.ToString()); 
#endregion

#region Interface
//Student s = new Student(102, "Mohamed");
////((ITest)s).Sum();
//Console.WriteLine(s.ToString()); 
#endregion

#region Extention Methods
//string txt = "Ahmed Mohamed Ali";
//Console.WriteLine(txt.Count());
//Console.WriteLine(txt.CountWords());

// Console.WriteLine(Operation.CountWords(txt));

////Extention Methods
//static class Operation
//{
//   public static int CountWords(this string txt)
//    {
//      string [] arr =  txt.Split(' ');
//        return arr.Length;
//    }
//} 
#endregion

#region Implicitly Type Local Variable
//Implicitly Type Local Variable
//var y = "Ahmed";

//dynamic y ;
//y = "Ahmed"; 
#endregion

#region Object Intializer
//Object Intializer 
//Student s = new Student() { Id = 100,Name = "Ahmed" };
//Console.WriteLine(s.ToString()); 
#endregion

#region Anonymous Object
//Anonymous Object
//var car = new { Model = 2022,Motor = "Nissan"};
////car.Motor = "Tesla";   XXXXXXXX
//Console.WriteLine(car.ToString()); 
#endregion

#region Immutable Vs Muttable
//Car c = new Car(2024, "Nissan");
//c.Model = 2026;  XXXXXXXXX

//String is Immutable  Type
//string txt = "Ahmed";
////txt = "Mohamed";
////txt = "Ali";

//for (int i = 0; i < 10; i++)
//{
//    txt += "No";
//}


//StringBuilder
//StringBuilder stringBuilder = new StringBuilder("ssss");

//for (int i = 0; i < 10; i++)
//{
//    stringBuilder.Append("No");
//} 
#endregion

#region Anonymous Method
/*
* Anonymous Method
* public int sum(int x,int y)
* {
*     return x+y;
* }
* 
*  (int x,int y)  { return x+y;}
*     (x,y) return x+y;
*     (x,y) => x+y ;
*     i => i+1      (Lamda Expression)
*/
#endregion

#region Nullable
//int? salary = null;
//string? txt = null; 
#endregion


class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Student()
    {
        
    }
    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override string ToString()
    {
        return $"{Id}-{Name}";
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
    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override string ToString()
    {
        return $"{Id}-{Name}";
    }
}
interface ITest
{
    //void Dislay();
   public int Sum()
    {
        return 0; 
    }
}
class Car
{
    public int Model { get; init; }
    public string Motor { get; init; }
    public Car(int model, string motor)
    {
        Model = model;
        Motor = motor;
    }
}