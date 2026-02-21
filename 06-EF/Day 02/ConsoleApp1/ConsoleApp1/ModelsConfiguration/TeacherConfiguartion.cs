using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ModelsConfiguration
{
    internal class TeacherConfiguartion : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(t=>t.Id);
            builder.Property(t => t.Name).HasMaxLength(20);
        }
    }
}
