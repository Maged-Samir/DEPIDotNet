using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        //Storage (Member Variables)
        //int id;
        //string name;
        int age;
        //Validation

        #region Setter&Getter
        //public void set_id(int Id)
        // {
        //     id = Id;
        // }
        // public int get_id()
        // {
        //     return id;
        // }

        //public void set_name(string Name)
        //{
        //    name = Name;
        //}
        //public string get_name()
        //{
        //    return name;
        //}

        //public void set_age(int Age)
        //{
        //    if (Age > 18)
        //        age = Age;
        //}
        //public int get_age()
        //{
        //    return age;
        //} 
        #endregion


        #region Properties
        //Properties
        //public int Id
        //{
        //    set { id = value; }
        //    get { return id; }
        //}

        //public string Name
        //{
        //    set { name = value; }
        //    get { return name; }
        //}

        public int Age
        {
            set
            {
                if (value > 18)
                    age = value;
            }
            get { return age; }

        }
        #endregion


        #region Dynamic Properity
        // dynamic properties => Member Variable + Property
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion



        //Opertaions
        public void PrintInfo()
        {
            Console.WriteLine($"Student Id = {Id} - Student Name = {Name} - Student Age = {Age}");
        }

    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public void PrintInfo()
        {
            Console.WriteLine($"Employee Id = {Id} - Employee Name = {Name}");
        }

    }

    class Operation
    {
        ////Overloading   => ploymorphism ( many forms )
        //Overloading => same function name with different signature (different parameters)
        //Signature => number of parameters or type of parameters or order of parameters
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public float Sum(float a, float b)
        {
            return a + b ;
        }
        public int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region Revision
            //variables
            //Data types
            //Casting
            //Operators
            //Control Structures
            //Functions
            //Debugging
            //Error Types
            //Arrays
            //User Defined Types
            //Value vs Reference Types
            //Value Types => Structs, Enums,int, double, char, bool, float, byte, decimal, long, short
            //Reference Types => Classes, Arrays, Strings,interfaces, Delegates

            #endregion
            #region OOP

            //OOP => Object Oriented Programming ( concepts & principles )
            //Programming Paradigms 
            //Concepts => Classes & Objects
            //Principles => Abstraction, Encapsulation, Inheritance, Polymorphism(Overloading)
            //Benefits of OOP => Modularity, Reusability,Extensibility,Maintainability 
            #endregion


            #region Setter & Getter 
            //Student s1 = new Student(); 

            //if(age > 18)
            //s1.age = 22;
            //s1.set_id(1);
            //s1.set_name("Mohamed");
            //s1.set_age(22);
            //s1.PrintInfo();



            //Console.WriteLine(s1.age); XXXXX
            //Console.WriteLine(s1.get_age());



            //Student s2 = new Student();
            //s2.id = 2;
            //s2.name = "Ahmed";
            //if(age > 18)
            //s2.age = 22;
            //s2.set_id(2);
            //s2.Id = 20;
            //s2.set_name("Ahmed");
            //s2.set_age(12);
            //s2.PrintInfo(); 
            #endregion
            #region Properity 

            //Student s1 = new Student();
            //s1.Id = 1;
            //s1.Name = "Mohamed";
            //s1.Age = 22;
            //s1.PrintInfo();

            //Student s2 = new Student();
            //s2.Id = 2;
            //s2.Name = "Ahmed";
            //s2.Age = 12;
            //s2.PrintInfo();

            #endregion
            #region Dynamic Properties
            //Employee e1 = new Employee();
            //e1.Id = 101;
            //e1.Name = "Ali";
            //e1.PrintInfo(); 
            #endregion
            #region Overloading
            //Operation op = new Operation();

            //int result = op.Sum(10, 20);
            //int result2 = op.Sum(50, 80, 40);
            //float result3 = op.Sum(5.6f, 8.2f);



            //Console.WriteLine(result);
            //Console.WriteLine(result2); 
            #endregion

        }
    }
}
