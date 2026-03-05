using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ModelsConfiguartions
{
    //Configuration MOdels
    internal class TeacherConfiguartion : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> modelBuilder)
        {
            modelBuilder.HasKey(t => t.Id);
            modelBuilder.Property(t => t.Name).HasMaxLength(50);
            modelBuilder.Property(t => t.Salary).HasColumnType("Money");
        }
    }
}
