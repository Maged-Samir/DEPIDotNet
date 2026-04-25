using WebApp.Context;
using WebApp.Managers;
using WebApp.Models;

namespace WebApp.Services
{
    public class DepartmentRepository : IDepartmentManager
    {

        SchoolDbContext context;

        public DepartmentRepository(SchoolDbContext context)
        {
            this.context = context;
        }

        public List<Department> GetAll()
        {
            return context.Departments.ToList();
        }
        public Department GetById(int id)
        {
            return context.Departments.FirstOrDefault(s => s.Id == id);
        }
        public int Insert(Department dept)
        {
            context.Departments.Add(dept);
            return context.SaveChanges();
        }
        public int Update(int id, Department dept)
        {
            var oldDept = GetById(dept.Id);
            oldDept.Name = dept.Name;
            return context.SaveChanges();
        }
        public int Delete(int id)
        {
            var oldDept = GetById(id);
            context.Departments.Remove(oldDept);
            return context.SaveChanges();

        }
    }
}
