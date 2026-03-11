using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Context
{
    internal class SchoolDBContext  : DbContext
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
            modelBuilder.Entity<Teacher>(builder =>
            {
                builder.HasKey(t => t.Id);
                builder.Property(t => t.Name).HasMaxLength(60);
                builder.Property(t => t.Salary).HasColumnType("money");
            });

            modelBuilder.Entity<TeacherDepartments>().HasKey(td => new { td.TeacherId, td.DepartmentId });


        }

    }
}
