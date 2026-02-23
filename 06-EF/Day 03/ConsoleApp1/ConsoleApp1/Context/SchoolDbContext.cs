using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace ConsoleApp1.Context
{
    internal class SchoolDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=SchoolDB;Integrated Security =True;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent Api
            modelBuilder.Entity<Teacher>(builder =>
            {
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Name).HasMaxLength(100);
                builder.Property(x => x.Salary).HasColumnType("money");
            });

            modelBuilder.Entity<TeacherDepartment>().HasKey(td => new { td.TeacherId, td.DepartmentId });
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<TeacherDepartment> TeacherDepartments { get; set; }

    }
}
