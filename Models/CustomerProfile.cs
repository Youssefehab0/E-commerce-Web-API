using System.ComponentModel.DataAnnotations;

namespace E_commerce_Api.Models
{
    public class CustomerProfile
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public string ?Address { get; set; }
        public DateOnly ?Dateofbirth { get; set; }
        public int ? CustomerId { get; set; }
        public Customer ?Customer { get; set; }
    }
}
