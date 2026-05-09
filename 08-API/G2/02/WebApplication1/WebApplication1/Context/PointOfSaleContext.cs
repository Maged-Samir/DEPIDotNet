using Microsoft.EntityFrameworkCore;
using WebApplication1.DataSeeding;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class PointOfSaleContext : DbContext
    {
        public PointOfSaleContext() { }
        public PointOfSaleContext(DbContextOptions options) :base(options) { }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CategorySeedConfiguration());
            modelBuilder.ApplyConfiguration(new ProductSeedConfiguration());

            //modelBuilder.Entity<Category>().HasData(
            //    new Category() { Id = 1,Name = "Printer"},
            //    new Category() { Id = 2, Name = "Laptop" }
            //    );

            //modelBuilder.Entity<Product>().HasData(
            //    new Product() { Id = 1,Name ="Lap LOQ",Price=2000,Qty =3,CategoryId = 2,Description ="New Device" },

            //    new Product() { Id = 2, Name = "HP", Price = 2500, Qty = 5, CategoryId = 2, Description = "New Device" },

            //    new Product() { Id = 3, Name = "Richo", Price = 500, Qty = 20, CategoryId = 1, Description = "Used Device" }
            //    );
        }

    }
}
