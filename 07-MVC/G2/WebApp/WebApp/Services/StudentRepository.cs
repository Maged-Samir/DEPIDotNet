using Microsoft.EntityFrameworkCore;
using WebApp.Context;
using WebApp.Managers;
using WebApp.Models;

namespace WebApp.Services
{
    public class StudentRepository : IStudentManager
    {
        SchoolDbContext context; //= new SchoolDbContext();

        public StudentRepository(SchoolDbContext context)
        {
            this.context = context;
        }

        public List<Student> GetAll()
        {
            return context.Students.Include(s => s.Department).ToList();
        }
        public Student GetById(int id)
        {
            return context.Students.Include(s => s.Department).FirstOrDefault(s => s.Id == id);
        }
        public int Insert(Student student)
        {
            context.Students.Add(student);
            return context.SaveChanges();
        }
        public int Update(int id, Student student)
        {
            var oldStd = GetById(id);

            oldStd.Name = student.Name;
            oldStd.Address = student.Address;
            oldStd.Department.Id = student.Department.Id;

            return context.SaveChanges();
        }
        public int Delete(int id)
        {
            var oldStd = GetById(id);
            context.Students.Remove(oldStd);
            return context.SaveChanges();

        }
    }
}
