
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp1.Models
{
    //EF Convention
    internal class Student
    {
        public int Id { get; set; }  //PK & Identity(1,1)
        public string? Name { get; set; }
        public int? Age { get; set; }

        public int? DepartmentId { get; set; }    //FK
        public virtual Department? Department { get; set; }

        public int? TeacherId { get; set; }       //FK
        public virtual Teacher? Teacher { get; set; }

        public override string ToString()
        {
            return $"Student {Id} {Name}";
        }
    }
}
