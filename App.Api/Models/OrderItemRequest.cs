namespace App.Api.Models
{
    public class OrderItemRequest
    {
        public Guid ProductId { get; set; }
        public Guid OrderId { get; set; }
        public int Quantity { get; set; }
    }
}
