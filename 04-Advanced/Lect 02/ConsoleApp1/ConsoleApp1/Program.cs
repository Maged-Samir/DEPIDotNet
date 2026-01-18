using System;
//using Microsoft.Bcl.HashCode;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student  
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        //public Student()
        //{
        //    Id = 0;
        //    Name = string.Empty;
        //    Age = 0;
        //}
        public Student(int Id = 0, string Name = " ", int Age = 0)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
        }

        //public string PrintInfo()
        //{
        //    return $"Student No :{Id} - Student Name :{Name}";
        //}

        public override string ToString()
        {
            return $"Student No :{Id} - Student Name :{Name} - Student Age :{Age}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }

        public override bool Equals(object obj)
        {
            //Student s = (Student)obj;
            //return s.Id == this.Id && s.Name == this.Name; 

            // is return Boolean
            //if (obj is Student)
            //{
            //    Student s = (Student)obj;
            //    return s.Id == this.Id && s.Name == this.Name;
            //} 
            //else
            //{
            //    return false;
            //}

            // as return specific type or Null

            Student s = obj as Student;
            if(s == null) return false;
            else
            return s.Id == this.Id && s.Name == this.Name;

        }
    }

   static class Operation
    {
        public static int SumGroupOfNums(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
               sum += nums[i];
            }
            return sum;
        }

        public static int Sum (int a,int b,out int x)
        {
            x = a - b;
            return a + b; 
        }

        //Optional Paramters
        public static void PrintPattern(int count=10, string pattern="*")
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(pattern);
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Object
            //Student s1 = new Student();
            //s1.Id = 1;

            //Parent p = new Child();

            //system.object
            //object o = new object();     //ref type
            //o = 100;
            //o = "Ahmed";
            //o = new Student();

            //int[] arr = new int[10];

            //object[] arr = new object[10];
            //arr[0] = 10;
            //arr[1] = 20;
            //arr[2] = 30;
            //arr[4] = "Ahmed";
            //arr[5] = new Student();


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //Operations XXXXX
            //Casting

            //Implicit
            //Explicit

            ////Boxing  value => Ref
            //int x = 20;
            //object o = x;

            ////UnBoxing  Ref => value
            //object o2 = 50;
            //int y = (int)o2; 
            #endregion

            #region System.Object Uses
            //Student s1 = new Student(101, "Ahmed Samy", 19);
            //Console.WriteLine(s1.PrintInfo());
            //Console.WriteLine(s1.ToString());

            //Student s2 = new Student(102, "Ahmed Samy", 19);
            //Console.WriteLine(s1.GetHashCode());
            //Console.WriteLine(s2.GetHashCode());

            //Console.WriteLine(s1.GetType().Name);


            //Student s1 = new Student(1, "Mohamed", 20);
            //Student s2 = new Student(1, "Mohamed", 20);

            //if (s1.Equals(s2))
            //{
            //    Console.WriteLine("Equals");
            //}
            //else
            //{
            //    Console.WriteLine("Not Equals");
            //} 
            #endregion

            #region Params
            //Params
            //Console.WriteLine(Operation.SumGroupOfNums(new int[] { 10, 20, 30 }));
            //Console.WriteLine(Operation.SumGroupOfNums(10, 20, 30)); 
            #endregion

            #region Optional Paramter & Named Paramter
            //Optional Paramters
            //Operation.PrintPattern(20, "*");
            //Operation.PrintPattern(30, "-");
            //Operation.PrintPattern(20);
            //Operation.PrintPattern(20,"+");
            //Operation.PrintPattern(pattern: ">>");  //Named Paramter

            //Student s1 = new Student();
            //Student s2 = new Student(20);
            //Student s3 = new Student(30,"Ahmed");
            //Student s4 = new Student(20,"Mona",16);
            //Student s5 = new Student(Name: "Yousef"); 
            #endregion

            #region Out Paramter
            //int result = 0;
            //Console.WriteLine(Operation.Sum(50, 30, out result));
            //Console.WriteLine(result); 
            #endregion                    
        }
    }
}
