using System.ComponentModel.DataAnnotations;

namespace E_commerce_Api.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string ?Email { get; set; }
        [MaxLength(20)]
        [MinLength(7)]
        public required string Password {  get; set; }
        public CustomerProfile? profile { get; set; }
        public List<Order> ?orders { get; set; }
    }
}
