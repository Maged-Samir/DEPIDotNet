using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
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

            #region Operators
            /*
                 * Operators
                 * 1-Arithmetic Operators  + * - / %
                 *   - Binary Operators    
                 *   - Unary Operators
                 *     -Prefix        ++x;
                 *     -Postfix       x++;
                 *      int x = 5;
                 *      Console.WriteLine(++x);
                 *      Console.WriteLine(x);
                 *      
                 * 2-Assignment Operators   =  +=  -=  *=  /=     
                 *      int x = 5;
                 *      x += 3; // x = x + 3;
                 *      
                 * 3-Comparison Operators   ==  !=  >  <  >=  <=      
                 *    x==y   
                 *    
                 * 4-Logical Operators      &&  || 
                 * (x>5 && y<10)
                 * (x>5 || y<10)
                 * 
                 * 5-Conditional (ternary) Operator   ? :
                 * 6-Null Coalescing Operator  ?? ??=
                 * 7-bitwise Operators    &  |  ^  ~  <<  >>
                 */
            #endregion

            #region Control Statment
            //Control Statements
            //Conditional Statements

            //Console.WriteLine("Enter Number");
            //int number = int.Parse(Console.ReadLine());

            //if (number > 0)
            //{
            //    Console.WriteLine("Positive Number");
            //}
            //else
            //{
            //    Console.WriteLine("Non-Positive Number");
            //}


            //Console.WriteLine("Enter Your Salary");
            //decimal sal =decimal.Parse(Console.ReadLine());

            // if(sal == 1000)
            // {
            //     Console.WriteLine("Level One");
            // }
            // else if(sal== 1100)
            // {
            //     Console.WriteLine("Level Two");
            // }
            // else
            // {
            //     Console.WriteLine("Not Valid");
            // }



            //Console.WriteLine("Enter Your Salary");
            //decimal sal = decimal.Parse(Console.ReadLine());
            //switch(sal)
            //{
            //    case 1000:
            //    case 1050:
            //        Console.WriteLine("Level One");
            //        break;
            //    case 1100:
            //        Console.WriteLine("Level Two");
            //        break;
            //    default:
            //        Console.WriteLine("Not Valid");
            //        break;
            //}


            //Loops

            //for(int i=0;i<5;i++)
            //{
            //    Console.WriteLine($"{i+1}-Test");
            //}

            //int i = 0;
            //while(i < 5)
            //{
            //    Console.WriteLine($"{i + 1}-Test");
            //    i++;
            //}


            //int i = 0;
            //do
            //{
            //    Console.WriteLine($"{i + 1}-Test");
            //    i++;
            //} while (i < 5); 
            #endregion

            #region Error Types
            //int a = int.Parse(Console.ReadLine()); 
            //int result = 5 / a;

            //Console.WriteLine(result);

            //Error Types
            /*
             * 1-Syntax Errors
             * 2-Logical Errors
             * 3-Runtime Errors
             * 4-Warning
             */ 
            #endregion


        }
    }
}
