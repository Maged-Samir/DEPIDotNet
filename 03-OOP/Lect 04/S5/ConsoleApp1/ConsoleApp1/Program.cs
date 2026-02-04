using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    partial class Parent
    {
        public int X { get; set; }

        public Parent()
        {
            X = 0;
        }
        public Parent(int X)
        {
            this.X = X;
        }

        public virtual void Show()
        {
            Console.WriteLine($"value of X = {X}");
        }
    }
    class Child : Parent
    {
        public int Y { get; set; }

        public Child() : base()
        {
            Y = 0;
        }
        public Child(int X, int Y) : base(X)
        {
            this.Y = Y;
        }


        //Hide Method (Override)
        //Extend Behavior
        public override void Show()
        {
            Console.WriteLine($"value of X = {X} , value of Y = {Y}");

            //base.Show();
            //Console.WriteLine($"value of Y = {Y}");
        }

    }
    class SubChild : Child
    {
        public int Z { get; set; }

        public SubChild() : base()
        {
            Z = 0;
        }
        public SubChild(int X, int Y, int Z) : base(X, Y)
        {
            this.Z = Z;
        }

        public override void Show()
        {
            Console.WriteLine($"value of X = {X} , value of Y = {Y} , value of Z = {Z}");
        }
    }

    abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public abstract void DisplayInfo();

        public void Display()
        {
            Console.WriteLine($"Wellcome {Name}");
        }

    }
    class Student : Person
    {
        public string Track { get; set; }

        public Student(int Id, string Name, int Age, string Track) : base(Id, Name, Age)
        {
            this.Track = Track;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{Id} - {Name} - {Age} - {Track}");
        }
    }
    class Teacher : Person
    {
        public int Salary { get; set; }
        public DateTime HiringDate { get; set; }

        public Teacher(int Id, string Name, int Age, int Salary, DateTime HiringDate) : base(Id, Name, Age)
        {
            this.Salary = Salary;
            this.HiringDate = HiringDate;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{Id} - {Name} - {Age} - {Salary} - {HiringDate}");
        }
    }

    sealed class Configuration
    {
        public string ServerName { get; set; }
        public string AppName { get; set; }
        public int AppVersion { get; set; }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            #region Inheritance
            //Parent p = new Parent();
            //p.X = 60;
            //p.Show();

            //Child c = new Child();
            // c.X = 50;
            // c.Y = 70;
            // c.Show();


            //Child c = new Child();
            //c.Y = 10;
            //c.Show(); 
            #endregion

            #region Chaining Between Ctors Child and Parent
            //Child C1 = new Child(5, 6);
            //C1.Show(); 
            #endregion

            #region Ref from Parent => new object Of Child
            /*Child c = new Parent();*/ //XXXXXXXXX

            //Parent p = new Child(2, 3);
            //p.Show();

            //SubChild Sb = new SubChild(5, 6, 7);
            //Sb.Show();

            //Parent p = new SubChild(5,8,10);
            //p.Show();
            //

            //Person p = new Person();    
            //Person p1 = new Student();
            //Person p2 = new Teacher();

            //Opeartion op = new Opeartion();
            //op.DisplayData(p1);
            #endregion

            #region Abstract Class & Abstract Method
            //Person p1 = new Person();  //XXXXXXXX Abstract Class


            //Student s1 = new Student(101, "Ahmed", 15, "SD");
            //s1.Display();
            //s1.DisplayInfo();

            //Teacher t1 = new Teacher(102, "Mohamed", 60, 1000, DateTime.Now);
            //t1.Display();
            //t1.DisplayInfo();

            #endregion

            #region Sealed Class
            //Configuration cong = new Configuration(); 
            #endregion

            #region Partial Class
            //Parent p = new Parent();
            //p.X = 50;
            //p.Show();
            //p.TestPartials(); 
            #endregion
        }
    }
}
