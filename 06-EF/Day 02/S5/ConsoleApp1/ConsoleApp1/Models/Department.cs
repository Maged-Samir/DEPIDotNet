using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApp1.Models
{
    //Data Annotations
    public class Department
    {
        public int Id { get; set; }
        [MaxLength(10,ErrorMessage ="Your Field Must be less than 10 char")]
        [MinLength(2,ErrorMessage = "Your Field Must be more than 2 char")]
        [AllowNull]
        public string Name { get; set; }
        public int? Capacity { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual List<Student>? Students { get; set; } = new List<Student>();
        public virtual List<TeacherDepartments>? Teacher { get; set; } = new List<TeacherDepartments>();

    }
}
