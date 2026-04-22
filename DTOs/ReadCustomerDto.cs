namespace E_commerce_Api.DTOs
{
    public class ReadCustomerDto
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        // public CustomerProfileDto? Profile { get; set; }
        // public List<OrderDto>? Orders { get; set; }
    }
}
