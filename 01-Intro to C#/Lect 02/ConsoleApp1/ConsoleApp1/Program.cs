using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
       public int id;
       public string name;
       public int age;


        public void PrintInfo(int id,string name,int age)
        {
            Console.WriteLine($"{id}-Your Name is {name} and his age {age}");
        }
        public int SumTwoNumber(int a, int b)
        {
            return a + b;
        }

        public void PrintPattern()
        {
            Console.WriteLine("--------------------------------------");
        }

    }
    struct Employee
    {
        public int id;
        public string name;                                                      
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region User Defined DataTypes
            //Student => Id,Name,Age

            //int id = 1;
            //string name = "Ahemd";
            //int age = 30;

            //int id1 = 1;
            //string name1 = "Ahemd";
            //int age1 = 30;

            //User Defined DataTypes
            //Class
            //Struct

            //Enum
            //Record
            //Interface

            //Student s = new Student();
            //s.id = 1;
            //s.name = "Mohamed";
            //s.age = 12;

            //Console.WriteLine($"{s.id} Student Name is {s.name} and his age{s.age}");

            //Student s2 = new Student();
            //s2.id = 2;
            //s2.name = "ahmed";
            //s2.age = 13;

            //Console.WriteLine($"{s2.id} Student Name is {s2.name} and his age{s2.age}"); 
            #endregion

            #region Value Vs Ref Types
            // Value Type Vs Refrence Type

            // Value Types => int , float, double, decimal ,struct ,enum ...
            //int x = 5;

            // Ref Type => Class , interface ,string ,array ,delegate ...
            //Student s = new Student();

            //Employee e = new Employee();
            //int num = new int();
            //string txt = "zdmcnmxn"; 
            #endregion

            #region Methods
            //Student s = new Student();
            //int result = s.SumTwoNumber(5, 6);
            //Console.WriteLine(result);



            //Student s = new Student();
            //s.id = 1;
            //s.name = "Mohamed";
            //s.age = 12;
            //s.PrintInfo(s.id,s.name,s.age);
            //s.PrintPattern(); 
            #endregion

            #region One-Array
            // Array
            // Same DataType
            // Fixed Size
            // Index

            //int[] grads = new int[5];
            //int[] g = new int[5] { 1, 20, 50, 60, 10 };
            //int[] h = new int[] { 40, 40, 60, 80 };
            //int[] t = { 40, 40, 60, 80 };

            //grads[0] = 1;
            //grads[1] = 2;
            //grads[2] = 50;
            //grads[3] = 60;
            //grads[4] = 10;
            //Console.WriteLine(grads[2]);


            //Console.WriteLine("Enter Number Of Names");
            //int size = int.Parse(Console.ReadLine());

            //string[] names = new string[size];

            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"Enter Name No {i+1}");
            //    names[i] = Console.ReadLine();
            //}

            //Console.WriteLine("-----------------------------");

            //for (int i = 0;i < size; i++)
            //{
            //    Console.WriteLine(names[i]);
            //} 
            #endregion

            #region Debugging
            //Student s = new Student();
            //int result = s.SumTwoNumber(1,2);
            //Console.WriteLine(result); 
            #endregion  
        }

    }
}
