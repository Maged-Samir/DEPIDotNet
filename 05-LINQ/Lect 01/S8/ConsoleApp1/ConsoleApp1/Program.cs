
//Console.WriteLine("Test .Net Core");
#region Class Vs Struct
//Student s = new Student(101, "Ahmed");
//Console.WriteLine(s.ToString());
//Color c = new Color(100,120);
//Console.WriteLine(c.ToString());

//Student s = new Student();
//((ITest)s).Sum(); 
#endregion

#region Extention Method
//string txt = "Ahmed Mohamed Samy";
//Console.WriteLine(txt.Count());
//Console.WriteLine(Operation.CountWords(txt));
//Console.WriteLine(txt.CountWords()); 
#endregion

#region Implicitly Type Local Variable
//Implicitly Type Local Variable 
//var x = 50;
//dynamic y = null; 
#endregion

#region Object Intializer 
//Object Intializer 
//Student s = new Student() { Name = "Nada" };
//List<string> names = new List<string>() { "Ahmed", "Mona", "Ali" }; 
#endregion

#region Anonymous Object
//Anonymous Object  ==> Immutable Type
//var car = new { Model = 2020, Motor = "Nissan" };

/*car.Model = 2025;*/ //XXXXXX

//Console.WriteLine(car.ToString());
//Console.WriteLine(car.Model);
//Console.WriteLine(car.Motor); 
#endregion

#region Immutable Types
//string txt = "Ahmed";
//txt = "Mohamed";
//txt = "Yousef";



//Immutable
//string txt = "Yousef";
//for(int i = 0;i< 10;i++)
//{
//    txt += "Ahmed";
//}


//using System.Text;
//StringBuilder sb = new StringBuilder("Yousef");  //Mutable
//for (int i = 0; i < 10; i++)
//{
//    sb.Append("Ahmed");
//}

#endregion

#region Anonymous Method
/*
* Anonymous Method
* 
*   public int Sum(int x,int y )
*   {
*      return x+y;
*   }
*   
*   (int x,int y ) { return x+y; }
*   (x,y) { return x+y; }
*   (x,y) return x+y;
*   (x,y) => x+y;
*   
*   i => i+1 ;
*   
*/
#endregion








//Entity Framework
//LINQ    => (Language Independat Queries)
//Set Of Queries (Local - Remote)

List<int> lst = new List<int>() { 7, 8, 2, 1, 6, 4, 2 };

//Using Enumerable
//var result = Enumerable.Where(lst, i => i > 2);

//Fluent Syntax
var result = lst.Where(i => i > 2);

//Query Syntax
//var result = from i in lst
//             where i > 2
//             select i;


foreach (var item in result)
{
    Console.WriteLine(item);
}























static class Operation
{
    public static int CountWords(this string word)
    {
        string[] arr = word.Split(' ');
        return arr.Length;
    }
}
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Student() { }
    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override string ToString()
    {
        return $"{Id} - {Name}";
    }
}
struct Color
{
    public int Red { get; set; }
    public int Green { get; set; }
    public int Blue { get; set; }

    public Color()
    {
        Red = 100;
        Green = 200;
        Blue = 255;
    }
    public Color(int Red, int Green)
    {
        this.Red = Red;
        this.Green = Green;
    }

    public override string ToString()
    {
        return $"{Red}-{Green}-{Blue}";
    }

}
interface ITest
{
    public int Sum()
    {
        return 0;
    }
}



