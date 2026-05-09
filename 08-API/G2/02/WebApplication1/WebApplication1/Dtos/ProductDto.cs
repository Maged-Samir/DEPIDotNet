using WebApplication1.Models;

namespace WebApplication1.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }
        public string CategoryName { get; set; }

    }
}
