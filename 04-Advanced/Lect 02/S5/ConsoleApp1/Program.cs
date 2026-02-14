using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
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


        //public string Display()
        //{
        //    return $"{Id} - {Name}";
        //}

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }

        public static bool operator ==(Student a, Student b)
        {
            return a.Id == b.Id && a.Name == b.Name;
        }
        public static bool operator !=(Student a, Student b)
        {
            return a.Id != b.Id || a.Name != b.Name;
        }

        public override bool Equals(object obj)
        {
            //Student s = (Student)obj;
            //return Id == s.Id && Name == Name;

            //Check Operator
            // is => return Boolean
            //if (obj is Student)
            //{
            //    Student s = (Student)obj;
            //    return Id == s.Id && Name == Name;
            //}
            //else
            //{
            //   return false;
            //}

            // as => return Specific Type Or Null
            Student s = obj as Student;
            if (s != null)
                return Id == s.Id && Name == Name;
            else
                return false;
        }

    }
    class Employee
    {
        public int Id
        {
            get; set;
        }
    }
    static class Operation
    {
        public static int SumGroupOfNumbers(params int[] num)
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            return sum;
        }

        //Out Paramter 
        public static int Sum(int x, int y, out int z)
        {
            z = x * y;
            return x + y;
        }

        //Required Paramter
        //Default Value For Paramters  => Optional Paramters
        public static void PrintPattern(string pattern = "*", int Count = 10)
        {
            for (int i = 0; i < Count; i++)
            {
                Console.Write(pattern);
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region System.Object
            //Student s1 = new Student();
            //s1.Id = 1;
            //s1.Name = "Test";
            //Employee e1 = new Employee();
            //  e1.Id = 2;

            //parent p = new child();
            //object o = new object();
            //  o = 100;
            //  o = 200;
            //  o = "Ahmed";
            //  o = new Student();

            //int[] grads = new int[10];
            //object[] data = new object[10];
            //data[0] = 100;
            //data[1] = 200;
            //data[2] = "Ahmed";
            //data[3] = new Student(101,"Ahmed");

            //for (int i = 0; i < data.Length; i++)
            //{
            //    Console.WriteLine(data[i]);
            //}

            //Operations
            //Boxing&UnBoxing

            //Boxing   value => Ref
            //int x = 12;
            //object y = x;

            //UnBoxing   Ref => Value
            //object o = 100;
            //int x = (int)o;

            #endregion

            #region Using Object
            //Student s1 = new Student(101, "Ali");
            //Console.WriteLine(s1.ToString());
            //Console.WriteLine(s1.Display());


            //Student s1 = new Student(101,"Mohamed");
            //Console.WriteLine(s1.GetHashCode());
            //Student s2 = new Student(102, "Mohamed");
            //Console.WriteLine(s2.GetHashCode());

            //Student S1 = new Student(101,"Ali");
            //Console.WriteLine(S1.GetType().IsClass);


            Student s1 = new Student(101, "Mohamed");
            //Student s2 = new Student(101, "Mohamed");
            Employee e1 = new Employee();
            if (s1.Equals(e1))
            {
                Console.WriteLine("Equals");
            }
            else
            {
                Console.WriteLine("Not Equals");
            }
            #endregion

            #region Params
            //int result = Operation.SumGroupOfNumbers(new int [] { 1, 2, 3 });
            //int result = Operation.SumGroupOfNumbers(1, 2, 3 ); 
            //Console.WriteLine(result);        s
            #endregion

            #region Out
            //int mul = 0;
            //int result = Operation.Sum(10, 5, out mul);
            //Console.WriteLine($"sum={result} , Mul = {mul}"); 
            #endregion

            #region Optional & Named Paramters
            //Operation.PrintPattern();
            //Operation.PrintPattern("-");
            ////Named Paramters
            //Operation.PrintPattern(Count:30);
            //Operation.PrintPattern(pattern:"*",Count:30); 
            #endregion
        }
    }
}