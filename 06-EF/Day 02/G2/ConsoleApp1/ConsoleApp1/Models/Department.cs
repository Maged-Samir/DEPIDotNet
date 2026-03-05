using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApp1.Models
{
    //Data Annotations
    //[Table(name:"Dept")]
    internal class Department
    {
        [Key]
        public int Did { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(10, ErrorMessage = "Name Must be less than 10 char")]
        [MinLength(2, ErrorMessage = "Name Must be More than 2 char")]
        public string Name { get; set; } = string.Empty;
        //[Required,MaxLength(20),MinLength(2)]
        public string? Location { get; set; }
        public int Capacity { get; set; }

    }
}
