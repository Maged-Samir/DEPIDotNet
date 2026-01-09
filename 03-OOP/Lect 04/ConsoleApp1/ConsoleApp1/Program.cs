using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class parent
    {
        public int x { get; set; }

        public parent()
        {

        }
        public parent(int x)
        {
            this.x = x;
        }
        public virtual void show()
        {
            Console.WriteLine($"x={x}");
        }
    }
    class child : parent
    {
        public int y { get; set; }

        public child() : base(0)
        {

        }
        public child(int x, int y) : base(x)
        {
            this.y = y;
        }

        public override void show()
        {
            Console.WriteLine($"x= {x} ,y={y}");
        }
    }
    class subChild : child
    {
        public int z { get; set; }

        public subChild(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }

        public override void show()
        {
            Console.WriteLine($"x= {x} ,y={y} ,z={z}");
        }
    }
    class Operation
    {
        public void CreateNewObj(parent p)
        {
            p.show();
        }
    }

    abstract class Person 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public abstract void Display();
        //abstract method 
        // cannot have body

        public void ShowInfo()
        {
            Console.WriteLine($"Id={Id}, Name={Name}");
        }

    }
    class Doctor : Person
    {
        public string Specialization { get; set; }

        public override void Display()
        {
            Console.WriteLine($"Id={Id}, Name={Name}, Specialization={Specialization}");
        }

    }
    class Engineer : Person
    {
        public string Field { get; set; }

        public override void Display()
        {
            Console.WriteLine($"Id={Id}, Name={Name}, Field={Field}");
        }
    }

    sealed class Configuration
    {
        public int Version { get; set; }
        public string Name { get; set; }

        public void ShowConfig()
        {
            Console.WriteLine($"Name={Name}, Version={Version}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Inheritance
            //child c = new child();
            ////c.x = 10;
            //c.y = 20;
            //c.show();


            //subChild sc = new subChild();
            //sc.x = 10;
            //sc.y = 20;
            //sc.z = 30;
            //sc.show();

            //parent p = new parent();
            //child c = new child();
            //subChild sc = new subChild();



            //child c1 = new parent(); //XXXXXX
            // c1.x = 100;
            //c1.y = 200;


            // Refrance of parent type can hold the object of child type

            //parent p1 = new child(10, 20);
            //p1.show();

            //child c1 = new subChild(10, 20, 30);
            //c1.show();

            //parent p2 = new subChild(10, 20, 30);
            //p2.show();


            //parent p3 = new parent(100);

            //Operation op = new Operation();
            //op.CreateNewObj(new parent(100));
            //op.CreateNewObj(new child(10, 20));
            //op.CreateNewObj(new subChild(10, 20, 30)); 
            #endregion

            #region Abstarct Class
            //Abstract class cannot be instantiated

            ////Person p1 = new Person(); XXXXXXXX

            //Doctor d1 = new Doctor();
            //d1.Id = 1;
            //d1.Name = "Dr. Smith";
            //d1.Specialization = "Card iology";
            //d1.Display();

            //Engineer e1 = new Engineer();
            //e1.Id = 2;
            //e1.Name = "Eng. Johnson";
            //e1.Field = "Software";
            //e1.Display(); 
            #endregion

            #region Sealed Class
            //Sealed class cannot be inherited 

            //Configuration config = new Configuration();
            //config.Name = "Release";
            //config.Version = 1;
            //config.ShowConfig();
            #endregion  



        }
    }
}
