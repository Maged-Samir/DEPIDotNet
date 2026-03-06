using ConsoleApp1.Models;
using ConsoleApp1.MoldesConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Context
{
    internal class SchoolDbContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TeacherDepartments> TeacherDepartments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=SchoolDB;Integrated Security =True;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent Api
            //modelBuilder.Entity<Teacher>(builder =>
            //{
            //    builder.HasKey(t => t.Id);
            //    builder.Property(t => t.Name).IsRequired();
            //    builder.Property(t => t.Salary).HasColumnType("money");
            //});

            modelBuilder.ApplyConfiguration(new TeacherConfiguartion());

            modelBuilder.Entity<TeacherDepartments>().HasKey(td => new { td.Teacher,td.DepartmentId });
        }

    }
}
