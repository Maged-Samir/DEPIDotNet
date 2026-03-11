using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    //EF Convension
    internal class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? Address { get; set; }

        public int? DepartmentId { get; set; }
        public virtual Department? Department { get; set; }


        public override string ToString()
        {
            return $" Student Id :{Id} - Name : {Name} - Address : {Address} - Department Name {Department.Name}";
        }
    }
}
