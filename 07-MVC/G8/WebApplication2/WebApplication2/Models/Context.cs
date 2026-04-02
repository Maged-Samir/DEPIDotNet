namespace WebApplication2.Models
{
    public class Context
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() {Id = 101,Name = "Mobile",Qty = 20,Price=1500,Description = "New Device"},
            new Product() {Id = 102,Name = "Screen",Qty = 15,Price=1800,Description = "Used Device"},
            new Product() {Id = 103,Name = "Laptop",Qty = 30,Price=15000,Description = "Used Device"},
            new Product() {Id = 104,Name = "Printer",Qty = 50,Price=4000,Description = "New Device"}
        };
    }
}
