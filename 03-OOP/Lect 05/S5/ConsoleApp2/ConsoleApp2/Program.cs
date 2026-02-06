using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public static int Counter { get; set; }

        static Employee()
        {
            Counter = 50;
        }
        public Employee()
        {
            Name = "New Employee";
            Counter++;
        }
        public Employee(int Id) : this()
        {
            this.Id = Id;
        }
        public Employee(int Id, string Name) : this(Id)
        {
            this.Name = Name;
        }
        public Employee(int Id, string Name, int Age) : this(Id, Name)
        {
            this.Age = Age;
        }
        public Employee(int Id, string Name, int Age, int Salary) : this(Id, Name, Age)
        {
            this.Salary = Salary;
        }

        public void PrintEmployee()
        {
            Console.WriteLine($"Employee Data => {Id} - {Name}");
        }

        public static void ShowEmployeeNumber()
        {
            Console.WriteLine($"Number Of Employees => {Counter}");
        }

        public static bool operator == ( Employee left, Employee right )
        {
            return left.Salary == right.Salary;
        }
        public static bool operator !=(Employee left, Employee right)
        {
            return left.Salary != right.Salary;
        }

    }
    static class Colors
    {
        public static int Red { get; }
        public static int Green { get; }
        public static int Blue { get; }

        static Colors()
        {
            Red = 100;
            Green = 10;
            Blue = 90;
        }

        public static void GenerateNewColor(int red, int green, int blue)
        {
            Console.WriteLine($"{red * green * blue}");
        }

        //public abstract void Display(); XXXXXXXXXXX

    }
    abstract class Person
    {
        public static void Show()
        {
            Console.WriteLine($"I'm a person");
        }

        public abstract void Display();
    }


    //Complex Number
    // 2+3i
    class Complex
    {
        public int Real { get; set; }
        public int Img { get; set; }

        public Complex() { }
        public Complex(int Real,int Img)
        {
           this.Real = Real;
           this.Img = Img;
        }

        public void Print()
        {
            Console.WriteLine($"{Real}+{Img}i");
        }

        public static Complex operator +(Complex x,Complex y)
        {
            Complex cResult = new Complex();
            cResult.Real = x.Real + y.Real;
            cResult.Img = x.Img + y.Img;
            return cResult;
        }
        public static Complex operator -(Complex x, Complex y)
        {
            Complex cResult = new Complex();
            cResult.Real = x.Real - y.Real;
            cResult.Img = x.Img - y.Img;
            return cResult;
        }
        public static bool operator ==(Complex x, Complex y)
        {
            return x.Real == y.Real && x.Img == y.Img;
        }
        public static bool operator !=(Complex x, Complex y)
        {
            return x.Real != y.Real || x.Img != y.Img;
        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {

            #region Static Keyword
            //Static Keyword 
            //Static Member
            //Static Ctor
            //Static Method
            //Static Class
            //Operator Overloading


            //Employee e1 = new Employee(101, "Ahmed", 30, 900);
            //e1.PrintEmployee();
            ////Console.WriteLine(e1.Counter);
            //Console.WriteLine(Employee.Counter);


            //Employee e2 = new Employee(102, "Amany", 29, 800);
            //e2.PrintEmployee();
            ////Console.WriteLine(e2.Counter);
            //Console.WriteLine(Employee.Counter);


            //Employee.ShowEmployeeNumber();


            // Colors c = new Colors(); XXXXX can't Create Instance from Static Class
            // Can't inherite from abstract Class


            //Colors.GenerateNewColor(100, 50, 40); 
            #endregion

            #region Operator Overloading
            //Operator Overloading

            //Complex c1 = new Complex(2, 3);
            //c1.Print();

            //Complex c2 = new Complex(2, 3);
            //c2.Print();

            //Complex c3 = new Complex(0, 0);
            ////c3 = c1 + c2;
            //c3 = c1 - c2;
            //c3.Print();

            //if (c1 == c2)
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
