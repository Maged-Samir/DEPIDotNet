using ConsoleApp1.Models;
using ConsoleApp1.ModelsConfiguartions;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Context
{
    internal class SchoolDbContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TeacherDepartments> TeacherDepartments { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=SchoolDB;Integrated Security =True;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent Api
            //modelBuilder.Entity<Teacher>(builder => {
            //    builder.HasKey(t => t.Id);
            //    builder.Property(t=>t.Name).HasMaxLength(50);
            //    builder.Property(t => t.Salary).HasColumnType("Money");
            //    });

            modelBuilder.ApplyConfiguration(new TeacherConfiguartion());

            modelBuilder.Entity<TeacherDepartments>().HasKey(td => new { td.TeacherId, td.DepartmentId });

        }

    }
}
