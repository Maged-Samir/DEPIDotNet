namespace WebApplication1.Models
{
    public class Context
    {
        public static List<Product> Products = new List<Product>()
        {
             new Product(101,"Laptop",12,3000),
             new Product(102,"TV",10,2500),
             new Product(103,"Mobile",100,1500),
             new Product(104,"Tablet",50,1700)
        };
    }
}
