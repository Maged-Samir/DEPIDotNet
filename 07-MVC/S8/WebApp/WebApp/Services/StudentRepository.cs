using Microsoft.EntityFrameworkCore;
using WebApp.Context;
using WebApp.Managers;
using WebApp.Models;

namespace WebApp.Services
{
    public class StudentRepository  :IStudentManager
    {
        SchoolDbContext context;  //= new SchoolDbContext();

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
            return context.Students.Include(s => s.Department).FirstOrDefault(d => d.Id == id);
        }
        public int Insert(Student std)
        {
            context.Students.Add(std);
            return context.SaveChanges();
        }
        public int Update(Student std)
        {
            var oldStd = GetById(std.Id);

            oldStd.Name = std.Name;
            oldStd.Age = std.Age;
            oldStd.Division = std.Division;
            oldStd.Grade = std.Grade;
            oldStd.DepartmentId = std.DepartmentId;

            context.Students.Update(oldStd);
            return context.SaveChanges();
        }
        public void Delete(int id)
        {
            var std = GetById(id);
            context.Remove(std);
            context.SaveChanges();
        }
        public Student GetByName(string name)
        {
            return context.Students.SingleOrDefault(x => x.Name == name);
        }
    }
}
