using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Comments
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello World!");

            /**
             * 
             */
            #endregion

            #region Variables & DataTypes
            // Variables 

            // 5+2 = 7
            // 5+x =

            //DataType VariableName ;

            //short s = 5;  // 2 bytes
            //int x = 20;   // 4 bytes
            //long l = 30;  // 8 bytes
            //Console.WriteLine(x);

            //float f = 5.5f;    // 4 bytes
            //double d = 2.5;    // 8 bytes
            //decimal m = 3.2m;  // 16 bytes

            //char c = 'A';  // 2 bytes
            //string str = "Hello World"; // 2 bytes per character

            //bool u = true;  // 1 byte

            /*
             * 1-Storage
             * 2-Operations
             * 3-Validation
             */
            #endregion

            #region Casting
            //// Implicit Casting 
            //int Num = 30;
            //long Num2 = Num; 

            //// Explicit Casting
            //long Num2 = 5000;
            //int Num = (int)Num2;   

            //Console.WriteLine(short.MaxValue); 
            #endregion

            #region Read & Write
            //Console.WriteLine("Enter Your Name");
            //string name  =  Console.ReadLine();
            //Console.WriteLine("Enter Your Age");
            ////int age = Console.ReadLine(); // Error
            //int age = int.Parse(Console.ReadLine());
            ////int age = Convert.ToInt32(Console.ReadLine());

            ////Console.WriteLine(name);
            ////Console.WriteLine(age);

            //Console.WriteLine("Your Name is {0} and your age is {1}",name,age);// String Formatting
            //Console.WriteLine("Your Name is " + name + " and your age is " + age); // String Concatenation
            //Console.WriteLine($"Your Name is {name} and Your Age is {age}"); // String Interpolation 
            #endregion

        }
    }
}
