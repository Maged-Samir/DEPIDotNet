namespace WebApplication1.Models
{
    public class Context
    {
        public static List<Product> Products = new List<Product>()
        {
           new Product { Id=1,Name = "Laptop",Price = 2000,Description ="New Device" },
           new Product { Id=2,Name = "Printer",Price = 600,Description ="Used Device" },
           new Product { Id=3,Name = "Mobile",Price = 1000,Description ="New Device" }
        };
     
    }
}
