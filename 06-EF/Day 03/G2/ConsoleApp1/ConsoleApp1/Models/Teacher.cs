using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;

namespace ConsoleApp1.Models
{
    internal class Teacher
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Salary { get; set; }

        //public virtual List<Department> Departments { get; set; } = new List<Department>();

        public virtual List<TeacherDepartment> Departments { get; set; } = new List<TeacherDepartment>();

        public virtual Student? Student { get; set; }
    }
}
