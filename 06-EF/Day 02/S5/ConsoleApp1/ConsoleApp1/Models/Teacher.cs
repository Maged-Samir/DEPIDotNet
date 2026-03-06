using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }  
        public int Salary { get; set; } //Money

        public virtual List<TeacherDepartments>? TeacherDepartments { get; set; } = new List<TeacherDepartments>();
    }
}
