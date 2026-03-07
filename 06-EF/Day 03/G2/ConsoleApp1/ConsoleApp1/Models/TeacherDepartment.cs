using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp1.Models
{
    internal class TeacherDepartment
    {
        public int TeacherId { get; set; }
        public int DepartmentId { get; set; }
        public int WorkingHours { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual Department Department { get; set; }


    }
}
