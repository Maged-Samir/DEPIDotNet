using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GroupId { get; set; }

        // Constructors
        // A constructor is a special method that is called when an object is instantiated.
        // It has the same name as the class and does not have a return type.
        // Overloading Constructors

        public Student()
        {
            Id = 101;
            Name = "New Student";
        }
        public Student(int id)
        {
            Id = id;
        }
        public Student(string name)
        {
            Name = name;
        }
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
            GroupId = "SWD5";
        }


        // Operations
        // Method Overloading
        public string PrintDetails()
        {
            return $"Id: {Id}, Name: {Name} - GroupId = {GroupId}";
        }
        public string PrintDetails(int Identifier)
        {
            return $"Id: {Id}, Name: {Name} - {Identifier}";
        }

        //Destructor
        //No Overloading for Destructor
        //Cannot Accept Access Modifiers
        //Cannot Accept Parameters

        // GC (Garbage Collector) will call the destructor automatically
        ~Student()
        {
            Console.WriteLine("Student Object Cleared ...");
        }

    }
    class Car
    {
        public int Model { get; set; }


        public Car()
        {
            Model = 0;
        }
        public Car(int model)
        {
            Model = model;
        }
    }
    struct Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        //public Employee()       XXXXXXXXX
        //{
        //    Id = 101;
        //    Name = "No Name";
        //}

        public Employee(int id)
        {
            Id = id;
            Name = "New Employee";
            Age = 0;
        }
        public Employee(string name)
        {
            Name = name;
            Id = 0;
            Age = 0;
        }
        public Employee(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        //Operations
        public string PrintDetails()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}";
        }
                         
        //~Employee()      
        //{
        //    Console.WriteLine("Employee Struct Cleared ...");
        //}
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class
            //Student s = new Student();
            //Console.WriteLine(s.PrintDetails());

            //Student s1 = new Student(2);


            //Student s2 = new Student();
            //s2.Id = 10;
            //s2.Name = "Smith";
            //Console.WriteLine(s2.PrintDetails());

            //Student s3 = new Student(10, "Ahmed");
            //Console.WriteLine(s3.PrintDetails());


            //Car c = new Car();
            //c.Model = 2020;

            //Car c2 = new Car(2022); 
            #endregion

            #region Struct
            //Employee e = new Employee();
            //e.Id = 1;
            //e.Name = "John";
            //Console.WriteLine(e.PrintDetails());

            //Employee e1 = new Employee(1, "Smith", 30);
            //e1.PrintDetails(); 
            #endregion

            #region Array Of Struct
            //Store multiple employees

            //Console.WriteLine("Enter Number Of Your Employees");
            //int num = int.Parse(Console.ReadLine());
            //Employee[] emps = new Employee[num];

            //for(int i= 0; i < num ; i++)
            //{
            //    Console.WriteLine($"Enter Id for Employee {i + 1}");
            //    emps[i].Id = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Enter Name for Employee {i + 1}");
            //    emps[i].Name = Console.ReadLine();
            //    Console.WriteLine($"Enter Age for Employee {i + 1}");
            //    emps[i].Age = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Your Employees Details:");

            //for (int i = 0; i < num; i++)
            //{
            //    Console.WriteLine(emps[i].PrintDetails());
            //}

            #endregion

        }
    }
}
