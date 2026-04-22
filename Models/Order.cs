namespace E_commerce_Api.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Guid orderid { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Orderdate { get; set; } = DateTime.Now.AddDays(14);
        public List<Product>? Products { get; set; }
        public int ?CustemorId { get; set; }
        public Customer? Customer { get; set; }
    }
}
