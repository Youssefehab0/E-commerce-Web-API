using System.ComponentModel.DataAnnotations;

namespace E_commerce_Api.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int? Amount { get; set; }
        public int ?CategoryId { get; set; }
        public Category ?Category { get; set; }
        public List<Order> ?orders { get; set; }
    }
}
