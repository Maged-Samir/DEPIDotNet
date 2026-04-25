using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Context
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext() { }
        public SchoolDbContext(DbContextOptions options):base(options) { }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=SchoolV4;Integrated Security = True ;Encrypt =False");
        //}

    }
}
