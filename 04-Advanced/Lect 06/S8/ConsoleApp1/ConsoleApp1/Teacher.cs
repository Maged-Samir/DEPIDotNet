using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Teacher(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString()
        {
            return $"{Id} - {Name}";
        }

        public void MonitorExam(Exam ex)
        {
            Console.WriteLine($"{Name} Start Montor Exam No {ex.Id}");
        }
    }
}
