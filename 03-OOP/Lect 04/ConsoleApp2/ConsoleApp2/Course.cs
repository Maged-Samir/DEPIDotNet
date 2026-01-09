using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Hours { get; set; }

        public Course(int Id,string Name,int Hours)
        {
            this.Id = Id;
            this.Name = Name;
            this.Hours = Hours;
        }

        public virtual void Display()
        {
            Console.WriteLine($"CourseId : {Id} , Name : {Name} , Hours : {Hours}");
        }
    }
}
