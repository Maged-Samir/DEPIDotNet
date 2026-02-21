using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //public delegate int myDele(int a, int b);

    enum Gender
    {
       Male,
       Female
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
                                  
        public Student(int id, string name, int age,Gender gender)
        {
            Id = id;
            Name = name;
            Age = age;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Age} - {Gender}";
        }

    }


    internal class Program
    {
        public static int Sum(int x, int y)
        {
            Console.WriteLine($"Sum = {x+y}");
            return x + y; 
        }

        public static int Mul(int c,int d)
        {
            Console.WriteLine($"Mul = {c*d}");
            return c * d;  
        }

        public static void Calc(int a,int b,Func<int,int,int> d)
        {
            Console.WriteLine(d(a, b));
        }

        public static void DisplayNumber(int value)
        {
            Console.WriteLine($"{value}");
        }

        public static bool IsEven(int num)
        { 
            return num % 2 == 0; 
        }


        static void Main(string[] args)
        {
            #region Delegates
            //Delegates => Pointer to Function -  Referance Type
            //Calc(50,10,Sum)
            //Sorting(40,20,50,80,70,Algo)

            //1-Pointer to Function
            //2-Call more than one Function

            /*
             * Define Class       Class Student { }
             * Def Ref Stack      Student S ;
             * Create Obj         new Student() ;
             * Assign Obj to Ref  S = new Student();
             * Calling Behavior   S.tostring();
             */

            /*
             * Define Delegate     with the same signature of Our Function
             * Define Ref Stack
             * Create Function
             * Assign Fun to Ref
             * Calling Behavior
             */

            //int result =  Program.Sum(50, 60);
            //Console.WriteLine(result);

            //myDele d;  //def Ref
            //d = Sum;   //Assign Fun to Ref
            //int result = d(5, 6);
            //Console.WriteLine(result);

            //Program.Calc(10, 20, Program.Sum);
            //Calc(10, 20, Sum);
            //Calc(20, 30, Mul);



            //2-Call more than one Function
            //myDele d = Sum;
            //d += Mul;
            //d(50, 30); 
            #endregion

            #region Func
            //Func<int, int, int> d = Program.Sum;
            //int result = d(5, 6);
            //Console.WriteLine(result);


            //Func<int> f = Program.PrintValue;  XXXXXXXXX
            //Console.WriteLine(f(50)); 
            #endregion

            #region Action
            ////Action<int> a = DisplayNumber;
            ////a(999); 
            #endregion

            #region Predicate
            ////Predicate
            //Predicate<int> p = IsEven;
            //Console.WriteLine(p(11)); 
            #endregion

            #region Enum

            //Gender g = Gender.Male;
            //Console.WriteLine(g);

            //Student s1 = new Student(101, "Mona", 15, Gender.Female);
            //Console.WriteLine(s1.ToString());

            //Student s2 = new Student(102, "Ali", 15, Gender.Male);
            //Console.WriteLine(s2.ToString()); 
            #endregion

        }
    }
}
