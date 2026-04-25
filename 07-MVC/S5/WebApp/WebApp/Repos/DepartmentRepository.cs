using WebApp.Context;
using WebApp.Managers;
using WebApp.Models;

namespace WebApp.Repos
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
            return context.Departments.FirstOrDefault(s => s.Id == id);
        }
        public int Insert(Department department)
        {
            context.Departments.Add(department);
            return context.SaveChanges();
        }
        public int Update(int id, Department department)
        {
            var oldDept = GetById(id);

            oldDept.Name = department.Name;
            oldDept.Location = department.Location;

            context.Departments.Update(oldDept);
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
