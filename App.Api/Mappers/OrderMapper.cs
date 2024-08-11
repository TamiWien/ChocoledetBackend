using App.Api.Models;
using App.DAL.Entities;
using App.DTO.Models;

namespace App.Api.Mappers
{
    internal static class OrderMapper
    {
        internal static OrderDTO Map(OrderRequest order)
        {
            return new OrderDTO
            {
                OrderId = Guid.NewGuid(),
                UserId = order.UserId,
                OrderDate = DateTime.Now,            
                PaymentStatus=order.PaymentStatus,
            };
        }
    }
}
