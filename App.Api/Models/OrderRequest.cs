using App.Api.Models;
using App.DAL.Entities;

public class OrderRequest
{
    public Guid UserId { get; set; }
    public bool PaymentStatus { get; set; }
    public virtual ICollection<OrderItemRequest> OrderItems { get; set; } = new List<OrderItemRequest>();

}
