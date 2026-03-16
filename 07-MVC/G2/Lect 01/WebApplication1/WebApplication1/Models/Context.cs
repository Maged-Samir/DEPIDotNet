namespace WebApplication1.Models
{
    public class Context
    {
        public static List<Product> Products = new List<Product>()
        {
          new Product(101,"Laptop",2000),
          new Product(102,"Mobile",1000),
          new Product(103,"Printer",1500),
        };
    }
}
