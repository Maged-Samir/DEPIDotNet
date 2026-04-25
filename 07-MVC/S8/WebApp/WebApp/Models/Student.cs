using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is Required Filed")]
        [MaxLength(30,ErrorMessage ="Name Must be less than 30 char")]
        [MinLength(2, ErrorMessage = "Name Must be more than 2 char")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Age is Required Filed")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Division is Required Filed")]
        public string Division { get; set; }
        [Required(ErrorMessage = "Grade is Required Filed")]
        public string Grade { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department? Department { get; set; }
    }
}
