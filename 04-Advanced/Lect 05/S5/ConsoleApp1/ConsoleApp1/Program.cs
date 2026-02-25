using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //public delegate int mydele(int a, int b);
    internal class Program
    {
        public static int Sum(int x, int y)
        {
            Console.WriteLine($"Sum ={x+y}");
            return x + y;
        }
        public static int Mul(int x,int y)
        {
            Console.WriteLine($"Mul ={x * y}");
            return x * y;
        }
        public static void Calc(int num1,int num2,Func<int,int,int> d)
        {
            int result = d(num1, num2);
            Console.WriteLine($"Result = {result}");
        }
        public static void DisplayNumber(int num)
        {
            Console.WriteLine($"Your Number Is {num}");
        }
        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }


        static void Main(string[] args)
        {
            #region Delegates
            //Delegate  => Pointer to Function - Ref Type
            //Sorting(5,7,4,8,2,1,algo())
            //Calc(5,6,5,Sum())

            //1- Pointer to Function  (Pass Fun as a paramter to another Fun)
            //2- Call More than one Fun in the same time

            //Student s = new Student();

            /*
             * Define Class       Class Student {   }
             * Def Ref Stack      Student S ;
             * Create Object      new Student();
             * Assign Obj to Ref  S = new Student();
             * Calling Behavior   S.ToString();   
             */

            /*
             * Define Delegate  =>  with the signature of Fun
             * Def Ref Stack
             * Create Fun
             * Assign Fun to Ref
             * Calling Behavior 
             */


            //int result = Program.Sum(5, 6);
            //Console.WriteLine(result);


            //1- Pointer to Function 
            //mydele d;
            //d = Program.Sum;
            //int result = d(5, 6);
            //Console.WriteLine(result);


            //1.1-Pass Fun as a paramter to another Fun)
            //mydele d = Program.Sum;
            //Calc(10, 5, Sum);
            //Calc(10, 5, Mul);



            //2- Call More than one Fun in the same time
            //mydele d = Program.Sum;
            //d += Program.Mul;
            //int result1 = d(2, 3);
            //Console.WriteLine(result1); 
            #endregion

            #region Built-in Delegates
            //Func
            //Func<int, int, int> f = Program.Sum;
            //int result1 = f(2, 3);
            //Console.WriteLine(result1);

            //Action
            //Action<int> a = Program.DisplayNumber;
            //a(999);

            //Predicate
            //Predicate<int> p = Program.IsEven;
            //Console.WriteLine(p(11)); 
            #endregion

        }
    }
}
