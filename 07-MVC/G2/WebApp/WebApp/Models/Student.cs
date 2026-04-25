using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace WebApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is Required")]
        [MaxLength(20,ErrorMessage ="this field must be less than 30 char")]
        [MinLength(2, ErrorMessage = "this field must be more than 2 char")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Address is Required")]
        public string Address { get; set; }

        public int? DepartmentId { get; set; }
        public virtual Department? Department { get; set; }
    }
}
