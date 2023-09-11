using System.ComponentModel.DataAnnotations;

namespace WebAPI.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public int ProductCost { get; set; }
        public int ProductStock { get; set; }
    }
}