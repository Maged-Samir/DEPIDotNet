using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    internal class Student
    {
        public int Id { get; set; }   //Id or ModelId => PK & Identity
        public string? Name { get; set; }
        public int? Age { get; set; }

        public Student()
        {
            Id = 0;
            Name = string.Empty;
            Age = 0;
        }
        public Student(int Id, string Name, int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Age}";
        }
    }
}
