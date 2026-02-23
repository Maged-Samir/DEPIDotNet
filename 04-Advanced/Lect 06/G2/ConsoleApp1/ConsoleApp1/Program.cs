using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //public delegate int myDelegate(int a, int b);

    internal class Program
    {
        public static int Sum(int x, int y)
        {
            //Console.WriteLine($"Sum={x+y}");
            return x + y;
        }
        public static int Mul(int s, int d)
        {
            //Console.WriteLine($"Mul={s * d}");
            return s * d;
        }
        public static void Calc(int x,int y , Func<int,int,int> d)
        {
            int result = d(x,y);
            Console.WriteLine($"Result = {result}");
        }
        public static void DisplayNumber(int num)
        {
            Console.WriteLine($"Your Number is {num}");
        }
        public static bool IsEven(int num)
        {
            return num % 2 == 0; 
        }

        static void Main(string[] args)
        {
            #region Delegates
            //Delegates - Refrence Type
            //Pointer to Function
            //Sorting(50,20,40,30,50,Method2)
            //Method1
            //Method2
            //Method3
            //Calc(50,20,Sum)
            //Sum
            //Mul

            //1.Passing Function as a paramter to another function
            //2.Call more than one Function

            /*
             * Define Class  Class Student {  }
             * Def Ref Stack Student S ;
             * Create Object new Student;
             * Assign Obj to Ref   S = new Student(10,"Ahmed");
             * Calling Behavior   S.toString();
             */

            /*
             * Define Delegate   with the same signature of our Method
             * Define Ref Stack
             * Create Method
             * Assign Method to Ref
             * Calling Behavior
             */


            //int result = Program.Sum(5, 6);
            //Console.WriteLine(result);


            //myDelegate d;        //Def Ref
            //d = Program.Sum;     //Assign Method to Delegate 

            //myDelegate d = Program.Sum;
            //int result = d(5, 6);
            //Console.WriteLine(result);

            //myDelegate d = Program.Sum;
            //d += Program.Mul;

            //Console.WriteLine(d(5, 6));


            //myDelegate d = Program.Sum;

            //Program.Calc(5, 6, d);
            //Program.Calc(5, 6,Mul); 
            #endregion

            #region Built-In Delegates
            //Func<int, int, int> f = Program.Sum;
            //int result = f(6, 6);
            //Console.WriteLine(result);

            //Func<int> f = Program.DisplayNumber; XXXXXXXXXXXXX

            //Action<int> a = Program.DisplayNumber;
            //a(50);

            //Predicate<int> p = Program.IsEven;
            //bool result = p(11);
            //Console.WriteLine(result);


            //Program.Calc(6, 6, Mul); 
            #endregion


        }
    }
}
