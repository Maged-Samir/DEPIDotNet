using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    //EF Conveintion
    internal class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? Stage { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Age}";
        }
    }
}
