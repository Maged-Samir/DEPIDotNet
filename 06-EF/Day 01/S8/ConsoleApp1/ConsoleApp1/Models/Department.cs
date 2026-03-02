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
        public int Did { get; set; }
        [MaxLength(15,ErrorMessage ="Your Filed Must Be Less than 15 char")]
        [MinLength(2,ErrorMessage = "Your Filed Must Be More than 2 char")]
        [Required]
        public string Name { get; set; }
        //[AllowNull]
        //[MaxLength(15, ErrorMessage = "Your Filed Must Be Less than 15 char")]
        //[MinLength(2, ErrorMessage = "Your Filed Must Be More than 2 char")]
        [AllowNull,MaxLength(20,ErrorMessage ="ssss"),MinLength(2)]
        public string Location { get; set; }



    }
}
