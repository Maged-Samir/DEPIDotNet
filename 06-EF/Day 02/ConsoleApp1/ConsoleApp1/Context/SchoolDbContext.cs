using ConsoleApp1.Models;
using ConsoleApp1.ModelsConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Context
{
    internal class SchoolDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=SchoolDbV2;Integrated Security =True;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent Api
            //modelBuilder.Entity<Teacher>(
            //    builder =>
            //    {
            //        builder.HasKey(t => t.Id);
            //        builder.Property(t => t.Name).HasMaxLength(50);
            //        builder.Property(t => t.Name).IsRequired();
            //    });

            modelBuilder.ApplyConfiguration(new TeacherConfiguartion());
        }

        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
    }
}
