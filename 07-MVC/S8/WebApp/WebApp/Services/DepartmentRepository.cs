using WebApp.Context;
using WebApp.Managers;
using WebApp.Models;

namespace WebApp.Services
{
    public class DepartmentRepository : IDepartmentManager
    {
        SchoolDbContext context; //= new SchoolDbContext();

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
            return context.Departments.FirstOrDefault(d => d.Id == id);
        }
        public int Insert(Department department)
        {
            context.Departments.Add(department);
            return context.SaveChanges();
        }
        public int Update(Department department)
        {
            var oldDept = GetById(department.Id);

            oldDept.Name = department.Name;
            oldDept.Location = department.Location;

            context.Departments.Update(oldDept);
            return context.SaveChanges();
        }
        public void Delete(int id)
        {
            var department = GetById(id);
            context.Remove(department);
            context.SaveChanges();
        }
    }
}
