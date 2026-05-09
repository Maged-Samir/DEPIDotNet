using System.ComponentModel.DataAnnotations;
using WebApplication1.Models;

namespace WebApplication1.Dtos
{
    public class ProductCreateDto
    {
        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Description is Required")]
        public string Description { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
       
    }
}
