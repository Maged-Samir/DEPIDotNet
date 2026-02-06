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
        public int  Hours { get; set; }

        public Course(int id, string name, int hours)
        {
            Id = id;
            Name = name;
            Hours = hours;
        }

        public abstract void Display();

    }
    class ProgrammingCourse : Course
    {
        public string Level { get; set; }
        public string Language { get; set; }

        public ProgrammingCourse(int id, string name, int hours, string level = null, string language = null) : base(id, name, hours)
        {
            Level = level;
            Language = language;
        }

      
        public override void Display()
        {
            Console.WriteLine($"ProgrammingCourse => {Name}");
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
            Console.WriteLine($"DesignCourse => {Name}");
        }
    }

    class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
        public Course[] Courses;
        private int count = 0;

        public Track(int id, string name, string duration, Course[] courses)
        {
            Id = id;
            Name = name;
            Duration = duration;
            Courses = courses;
        }

        public Track(int id, string name, string duration,int numberOfCources)
        {
            Id = id;
            Name = name;
            Duration = duration;
            Courses = new Course[numberOfCources];
        }


        public void AddCourse(Course course)
        {
            Courses[count++] = course;
        }

        public Course this[string courseName]
        {
            get
            {
                for(int i = 0; i < Courses.Length; i++)
                {
                    if (Courses[i].Name == courseName)
                    {
                        return Courses[i];
                    }
                }
                return null;
            }
        }

        public void DisplayTrack()
        {
            Console.WriteLine($"Track No {Id}  - {Name}");
            for(int i = 0;i < Courses.Length;i++)
            {
                Courses[i].Display();
            }
        }

    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Course c1 = new ProgrammingCourse(101, "C#", 20);
            Course c2 = new DesignCourse(102, "Database", 15,"dd","dd");

            Course[] crs = new Course[] { c1, c2 };

            Track t1 = new Track(1111, ".Net", "102", crs);

            t1.DisplayTrack();


        }
    }
}
