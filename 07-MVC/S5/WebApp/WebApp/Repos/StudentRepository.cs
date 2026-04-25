using Microsoft.EntityFrameworkCore;
using WebApp.Context;
using WebApp.Managers;
using WebApp.Models;

namespace WebApp.Repos
{
    public class StudentRepository : IStudentmManager
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
            oldStd.Division = student.Division;
            oldStd.Grade = student.Grade;
            oldStd.Department.Id = student.Department.Id;

            context.Students.Update(oldStd);
            return context.SaveChanges();
        }
        public int Delete(int id)
        {
            var oldstd = GetById(id);
            context.Students.Remove(oldstd);
            return context.SaveChanges();
        }

    }
}
