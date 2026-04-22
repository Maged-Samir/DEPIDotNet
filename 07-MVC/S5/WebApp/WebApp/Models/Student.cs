using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Student Name is required")]
        [MaxLength(30,ErrorMessage ="This filed Must be Less than 30 Char")]
        [MinLength(2,ErrorMessage = "This filed Must be More than 1 Char")]
        public string? Name { get; set; }
        public string? Address { get; set; }
        [Required(ErrorMessage = "Grade is required")]
        public string Grade { get; set; }
        [Required(ErrorMessage = "Division is required")]
        public string Division { get; set; }

        public int? DepartmentId { get; set; }
        public virtual Department? Department { get; set; }

    }
}
