using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp1.Models
{
    //EF Convienstion
    internal class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? Address { get; set; }

        public virtual Department? Department { get; set; }

        //public int TeacherId { get; set; }
        //public virtual Teacher? Teacher { get; set; } 

        public override string ToString()
        {
            return $"{Id} - {Name} - {Age} - {Address} - {Department.Name}";
        }

    }
}
