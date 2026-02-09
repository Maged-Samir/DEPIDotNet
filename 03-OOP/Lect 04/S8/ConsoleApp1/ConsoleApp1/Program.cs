using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    abstract class Course 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Hours { get; set; }
        public static int Count { get; set; }

        static Course()
        {   
            Count = 50;
        }
        public Course()
        {
            Count++; 
        }
        public Course(int id, string name, int hours):this()
        {
            Id = id;
            Name = name;
            Hours = hours;
        }

        public abstract void Display();

        public static void DisplayCourseNum()
        {
            Console.WriteLine($"{Count}");
        }

    }
    static class Operation
    {
        public static int MyProperty { get; set; }

        static Operation()
        {
            
        }
        public static int Sum(int x,int y)
        {
            return x + y; 
        }
    }

    class ProgrammingCourse : Course
    {
        public string Language { get; set; }
        public string Level { get; set; }

        public ProgrammingCourse(int id, string name, int hours, string language, string level) : base(id, name, hours)
        {
            Language = language;
            Level = level;
        }

        public override void Display()
        {
            Console.WriteLine($"ProgrammingCourse =>{Id} - {Name}");
        }
    }
    class DesignCourse : Course
    {
        public string Tools { get; set; }
        public string Specialization { get; set; }
        public DesignCourse(int id, string name, int hours, string tools, string specialization) : base(id, name, hours)
        {
            Tools = tools;
            Specialization = specialization;
        }

        public override void Display()
        {
            Console.WriteLine($"DesignCourse =>{Id} - {Name}");
        }
    }
    class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Hours { get; set; }
        private Course[] Courses;
        private int count = 0;

        public Track(int id, string name, int hours, int numberOfCources)
        {
            Id = id;
            Name = name;
            Hours = hours;
            Courses = new Course[numberOfCources];
        }

        public void AddCourse(Course course)
        {
            if (count < Courses.Length)
                Courses[count++] = course;
        }


        public void Display()
        {
            Console.WriteLine($"Track Info {Id} - {Name}");
            Console.WriteLine("Cources in Our Track ");
            for (int i = 0; i < Courses.Length; i++)
            {
                Courses[i].Display();
            }
        }

        //t1["courseName"]= 1

        public int this[string courseName]
        {
            get
            {
                for (int i = 0; i < Courses.Length; i++)
                {
                    if (Courses[i].Name == courseName)
                        return Courses[i].Hours;
                }
                return 0;
            }
            set
            {
                for (int i = 0; i < Courses.Length; i++)
                {
                    if (Courses[i].Name == courseName)
                        Courses[i].Hours = value;
                }
            }

        }

    } 

    abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public abstract void Display();

        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public void Register()
        {
            Console.WriteLine("Show...");
        }

    }
    class Student : Person
    {
        public int Result { get; set; }

        public override void Display()
        {
            Console.WriteLine($"{Id} - {Name} - {Result}");
        }
    }
    class Teacher : Person
    {
        public int Salary { get; set; }

        public override void Display()
        {
            Console.WriteLine($"{Id} - {Name} - {Salary}");
        }
    }
    class Configuration 
    {
   
    }
    class Test
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public void Register()
        {
            Console.WriteLine("Show...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Indexer
            //Track t1 = new Track(101, ".Net", 100, 2);
            //t1.AddCourse(new ProgrammingCourse(1, "C#", 10, null, null));
            //t1.AddCourse(new DesignCourse(2, "SQL", 20, null, null));

            //t1.Display();

            //t1["C#"].Display();


            //t1["C#"] = 100;

            //t1.Display();

            //Console.WriteLine(); 
            #endregion
            #region Abstract 
            //Person person = new Person(); XXXXXXXXXXXX

            //Student s1 = new Student();
            //s1.Register();
            //s1.Display();

            //Configuration conf = new Configuration(); 
            #endregion

            //Course c1 = new Course();
            //Console.WriteLine(Course.Count);


            //Course c2 = new Course();
            //Console.WriteLine(Course.Count);

            //Course c3 = new Course();
            //Console.WriteLine(Course.Count);


            //Operation op = new Operation();
            //op.Sum(5, 6);


            Operation.Sum(8, 6);

            //Operation op = new Operation();      XXXXXXXXX


        }
    }
}
