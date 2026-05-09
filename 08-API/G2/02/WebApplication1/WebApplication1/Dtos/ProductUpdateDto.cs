namespace WebApplication1.Dtos
{
    public class ProductUpdateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
    }
}
