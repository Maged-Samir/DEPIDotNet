namespace WebApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }

        public int? DepartmentId { get; set; }
        public virtual Department? Department { get; set; }
    }
}
