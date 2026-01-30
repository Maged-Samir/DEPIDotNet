using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        //Storage (Member Variables)
         //int id;
         //string name;
        //Validation
        #region Setter & Getter
        //public void Set_id(int _id)
        //{
        //    id = _id;
        //}
        //public int Get_Id()
        //{
        //    return id;
        //}
        //public void Set_name(string _name)
        //{
        //    name = _name;
        //}
        //public string Get_name()
        //{
        //    return name;
        //}
        //public void Set_age(int _age)
        //{
        //    if (_age > 0)
        //        age = _age;
        //}
        //public int Get_age()
        //{
        //    return age;
        //} 
        #endregion 

        //Properity => Encaspulate (Getter & Setter)
        //public int Id
        //{
        //    set { id = value; }
        //    get { return id; }
        //}

        //public string Name
        //{
        //   set { name = value; }
        //   get { return name; }
        //}

        int age;
        public int Age
        {
            set 
            {
                if (value > 0)
                    age = value;
            }
            get { return age; } 
        }



        //dynamic Properity => Properity + Member Variable
        public int Id { get; set; }
        public string Name { get; set; }



        //Operations
        public void PrintDetails()
        {
            Console.WriteLine($"Student Info : {Id} - {Name} - {Age}");
        }
        public void PrintDetails(string pattern)
        {
            Console.WriteLine($"Student Info : {Id} ${pattern} {Name} ${pattern} {Age}");
        }
    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Id} - {Name} - {Salary}");
        }

    }

    class Calc
    {
        // overloading
        public int Sum(int x,int y)
        {
            return x + y; 
        }
        public double Sum(double x, double y)
        {
            return x + y;
        }
        public int Sum(int x, int y,int z)
        {
            return x + y + z;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Revision
            /*  - Intro to Programming using C# 
             *  - Database
             *  - OOP
             */
            #endregion

            //OOP => Object Orianted Programming (Concepts & Principles)
            //Programming Paradims 
            //Concepts => Class & Object
            //Principles => Abstraction ,Encapsulation , Inheritance ,Polymorphism (Overloading)
            //Benefits Of OOP => Modularity , Reusability ,EXtensibility , Maintainability

            //Student s1 = new Student();

            //s1.id = 1;
            //s1.name = "Ahmed";
            ////s1.age = -12;
            //s1.Set_age(19);

            //s1.PrintDetails();

            //Console.WriteLine($"Student Id {s1.id} his Name {s1.name} and his age is {s1.Get_age()}");


            //Student s2 = new Student();
            //s2.Set_id(1);
            //s2.Set_name("Yousef");
            //s2.Set_age(10);

            //s2.PrintDetails();


            //Student s3 = new Student();
            //s3.Id = 2;
            //s3.Name = "Reham";
            //s3.Age = 21;
            //s3.PrintDetails();


            //Console.WriteLine($"Student Info {s3.Name}");



            //Calc c = new Calc();
            //c.Sum(2, 3);

        }
    }
}
