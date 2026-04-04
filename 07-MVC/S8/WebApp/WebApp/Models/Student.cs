namespace WebApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? Division { get; set; }
        public string? Grade { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department? Department { get; set; }
    }
}
