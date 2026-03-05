using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    internal class Teacher
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public int? Salary { get; set; }

        //public virtual List<Department>? Departments { get; set; } = new List<Department>();

        public virtual List<TeacherDepartments>? TeacherDepartments { get; set; } = new List<TeacherDepartments>();

        public virtual Student Student { get; set; }
    }
}
