namespace WebApplication1.Models
{
    public class Context
    {
        public static List<Product> Products = new List<Product>()
        {
          new Product() {Id = 1,Name ="Mobile", Price = 500 ,Description = "New Device"},
          new Product() {Id =2,Name ="Laptop", Price = 1500 ,Description = "New Device"},
          new Product() {Id = 3,Name ="Smart TV", Price = 1200 ,Description = "Used Device"},
          new Product() {Id = 4,Name ="Printer", Price = 600 ,Description = "New Device"}
        };
    }
}
