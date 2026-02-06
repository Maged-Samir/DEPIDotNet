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
        public int Age { get; set; }
        public DateTime RegisterationDate { get; set; }

        public Student()
        {
            this.Id = 0;
            this.Name = "New Student";
            this.Age = 0;
        }
        public Student(int Id)
        {
            this.Id = Id;
        }
        public Student(int Id, string Name) : this(Id)
        {
            this.Name = Name;
        }
        public Student(int Id, string Name, int Age) : this(Id, Name)
        {
            this.Age = Age;
        }
        public Student(int Id, string Name, int Age, DateTime RegisterationDate) : this(Id, Name, Age)
        {
            this.RegisterationDate = RegisterationDate;
        }

        public void Display()
        {
            Console.WriteLine($"Student Info -  {Id} - {Name} - {Age}");
        }
    }



    class Parent
    {
        public int x { get; set; }

        public Parent()
        {
            x = 0;
        }

        public Parent(int x)
        {
            this.x = x; 
        }


        public virtual void Show()
        {
            Console.WriteLine($"Value Of X = {x}");
        }
    }
    class Child : Parent 
    {
        public int y { get; set; }

        public Child() : base()
        {
            y = 0;
        }
        public Child(int x,int y) : base(x)
        {
            this.y = y;
        }

        //Override (Hide)
        //Extend Behavior
        public override void Show()
        {
            Console.WriteLine($"Value Of X = {x} , Value Of Y = {y}");

            //base.Show();
            //Console.WriteLine($"Value Of Y = {y}");
        }
    }
    class SubChild : Child
    {
        public int z { get; set; }

        public SubChild():base()
        {
            z = 0;
        }
        public SubChild(int x ,int y, int z):base(x,y)
        {
           this.z = z; 
        }

        public override void Show()
        {
            Console.WriteLine($"Value Of X = {x} , Value Of Y = {y} , Value Of Z = {z}");
        }
    }


    class Operation
    {
       public void DoSomething(Parent p)
        {
            p.Show();
        }
    }





    internal class Program
    {
        static void Main(string[] args)
        {
            #region this Keyword
            //    Student s1 = new Student(101, "Ahmed", 22);
            //    s1.Display();

            //this Keyword
            /*
             * 1- Current Instance
             * 2- Ctor Chaining 
             * 3- C# Indexer
             * 4- Extention Methods
             */
            #endregion

            #region Inheritance
            //Child c = new Child();
            //c.x = 5;
            //c.y = 10;
            //c.Show();

            //Child c1 = new Child(5,9);
            //c1.Show(); 
            #endregion

            #region   Ref from Parent => obj from Child

            // Child C = new Parent (); XXXXXXXXX
            // Ref from Parent => obj from Child
            //Parent p = new Child(40,50);
            //p.Show();


            //SubChild sub = new SubChild(4, 5, 8);
            //sub.Show();

            //Parent p = new SubChild(70,80,90);
            //p.Show();


            //Operation o = new Operation();
            //o.DoSomething(new Parent());
            //o.DoSomething(new Child(4,6));
            //o.DoSomething(new SubChild(4, 6, 8));

            #endregion    


        }
    }
}
