namespace WebApplication1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Qty { get; set; }
        public int? Price { get; set; }

        public Product(int Id, string Name, int Qty, int Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Qty = Qty;
            this.Price = Price;
        }
    }
}
