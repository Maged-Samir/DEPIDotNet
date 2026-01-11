using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public static int Count { get; set; }

         static Employee()
        {
            Count = 50;
        }

        public Employee()
        {
            this.Id = 0;
            this.Name = "Unknown";
        }

        public Employee(int Id, string Name, int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            Count++;
        }

        public static void PrintEmployeeCount()
        {
            Console.WriteLine($"Total Employees: {Count}" );
        }

        public void Print()
        {
            Console.WriteLine($"Employee Info => Id: {Id}, Name: {Name}, Age: {Age}");
        }

    }
    static class Operation
    {
        public static void Sum(int a, int b)
        {
            Console.WriteLine($"Sum: {a + b}");
        }
    }
    class Complex
    {
        public  int  Real { get; set; }
        public  int Imag { get; set; }

        public Complex()
        {
            
        }
        public Complex(int r, int i)
        {
            Real = r;
            Imag = i;
        }

        public void Display()
        {
            Console.WriteLine($"{Real} + {Imag}i");
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex result = new Complex();
            result.Real = c1.Real + c2.Real;
            result.Imag = c1.Imag + c2.Imag;
            return result;
        }

        public static bool operator ==(Complex c1, Complex c2)
        {
            return (c1.Real == c2.Real) && (c1.Imag == c2.Imag);
        }

        public static bool operator !=(Complex c1, Complex c2)
        {
            return (c1.Real != c2.Real) || (c1.Imag != c2.Imag);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Static Keyword
            //Employee e1 = new Employee(101, "Ahmed", 20);
            //e1.Print();
            //Console.WriteLine(Employee.Count);

            //Employee.Count = 100;

            //Employee e2 = new Employee(102, "Mona", 19);
            //e2.Print();
            //Console.WriteLine(Employee.Count);

            //Employee.PrintEmployeeCount();

            //Operation.Sum(10, 20);


            //Complex numbers
            //4 + 5i 
            #endregion

            #region Operator Overloading
            //operator overloading
            //complex c1 = new complex(4, 5);
            //complex c2 = new complex(3, 7);
            //complex c3 = c1 + c2;
            //c3.Display();


            //complex c1 = new complex(4, 5);
            //complex c2 = new complex(4, 5);
            //if ( c1 == c2)
            //{
            //    Console.WriteLine("Equals"); 
            //}
            //else
            //{
            //    Console.WriteLine("Not Equals");
            //} 
            #endregion


        }
    }
}
