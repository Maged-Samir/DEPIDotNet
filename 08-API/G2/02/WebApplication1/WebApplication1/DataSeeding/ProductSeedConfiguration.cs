using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.DataSeeding
{
    public class ProductSeedConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                 new Product() { Id = 1, Name = "Lap LOQ", Price = 2000, Qty = 3, CategoryId = 2, Description = "New Device" },

                new Product() { Id = 2, Name = "HP", Price = 2500, Qty = 5, CategoryId = 2, Description = "New Device" },

                new Product() { Id = 3, Name = "Richo", Price = 500, Qty = 20, CategoryId = 1, Description = "Used Device" }
                );
        }
    }
}
