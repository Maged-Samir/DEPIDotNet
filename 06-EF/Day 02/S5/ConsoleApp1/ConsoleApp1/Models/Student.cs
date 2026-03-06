using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp1.Models
{
    //EF Convension
    public class Student
    {
        public int Id { get; set; } //PK & Identity(1,1)  => Id or ModelId 
        public string? Name { get; set; }     
        public int? Age { get; set; }

        public int? DepartmentId { get; set; }      //FK
        public virtual Department?  Department { get; set; }

        public override string ToString()
        {
            return  $"Student {Id} {Name}";
        }
    }
}
