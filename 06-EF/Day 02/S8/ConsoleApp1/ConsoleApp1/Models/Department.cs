using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp1.Models
{
    //Data Annotations
    internal class Department
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(10)]
        [MinLength(2)]
        public string? Name { get; set; }
        public int? Capacity { get; set; }
        public string? Location { get; set; }

        public virtual List<Student>? Students { get; set; } = new List<Student>();
        //public virtual List<Teacher>? Teachers { get; set; } = new List<Teacher>();

        public virtual List<TeacherDepartments>? TeacherDepartments { get; set; } = new List<TeacherDepartments>();
    }
}
