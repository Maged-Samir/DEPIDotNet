using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public Course[] Courses;

        private int count = 0;

        //public Track(int id, string name, int duration, Course[] courses)
        //{
        //    Id = id;
        //    Name = name;
        //    Duration = duration;
        //    Courses = courses;
        //}

        public Track(int id, string name, int duration, int maxCourses)
        {
            Id = id;
            Name = name;
            Duration = duration;
            Courses = new Course[maxCourses];
        }

        public void AddCourse(Course course)
        {
            if(count < Courses.Length)
            Courses[count++] = course;
        }


        public Course this[string CourseName]
        {
            get
            {
               for(int i = 0; i < Courses.Length; i++)
                {
                    if(Courses[i].Name == CourseName)
                    {
                        return Courses[i];
                    }
                }
                return null;
            }
        }
        public void DisplayTrackInfo()
        {
            Console.WriteLine($"Track ID: {Id}, Name: {Name}, Duration: {Duration} hours");
            Console.WriteLine("Courses in this track:");
            for(int i = 0; i < Courses.Length; i++)
            {
                Courses[i].Display();
            }
        }
    }
}
