using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString()
        {
            return $"{Id} - {Name}";  
        }

        public void AswerExam(Exam ex)
        {
            Console.WriteLine($"{Name} Start Answer {ex.Subject} Exam ");
            Console.WriteLine(ex.ToString());
        }
    }
}
