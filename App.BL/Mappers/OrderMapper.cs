using App.DAL.Entities;
using App.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BL.Mappers
{
    internal static class OrderMapper
    {
        internal static Order Map(OrderDTO order)
        {
            return new Order
            {
                OrderId = order.OrderId,
                UserId = order.UserId,
                OrderDate = order.OrderDate,
                TotalAmount=order.TotalAmount,
                PaymentStatus = order.PaymentStatus,
                OrderItems = order.OrderItems.Select(item => new OrderItem
                {
                    OrderItemId = item.OrderItemId,
                    ProductId = item.ProductId,
                    OrderId = item.OrderId,
                    Quantity = item.Quantity
                }).ToList()
            };
        }
        internal static OrderDTO Map(Order order)
        {
            return new OrderDTO
            {
                OrderId = order.OrderId,
                UserId = order.UserId,
                OrderDate = order.OrderDate,
                TotalAmount = order.TotalAmount,
                PaymentStatus = order.PaymentStatus,
            };
        }
    }
}
