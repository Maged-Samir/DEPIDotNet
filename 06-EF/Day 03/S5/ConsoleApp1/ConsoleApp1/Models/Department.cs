using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApp1.Models
{
    //Data Annotations
    internal class Department
    {
        [Key]
        public int Id { get; set; }
        [AllowNull]
        [MaxLength(20)]
        [MinLength(2)]
        public string Name { get; set; }
        [AllowNull]
        public int Capacity { get; set; }
        [AllowNull]
        [MaxLength(20)]
        [MinLength(2)]
        public string Location { get; set; }


        public virtual List<Student> Students { get; set; } = new List<Student>();
        public virtual List<TeacherDepartments> TeacherDepartments { get; set; } = new List<TeacherDepartments>();
    }
}
