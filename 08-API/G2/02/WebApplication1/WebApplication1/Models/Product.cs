using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }

        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
    }
}
