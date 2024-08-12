using App.DAL.DataContext;
using App.DAL.Entities;
using App.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL.Repositories
{
    public class OrdersRepository: IOrdersRepository
    {
        public ChocoledetContext dbContext;
        public OrdersRepository(ChocoledetContext chocoledetContext)
        {
            dbContext = chocoledetContext;
        }
        public List<Order> GetOrdersById(Guid id)
        {
            List<Order> orders = dbContext.Orders.Where(u => u.UserId == id).ToList();
            return orders;
        }
        public Guid CreateOrder(Order order)
        {
            dbContext.Orders.Add(order);
            foreach (var item in order.OrderItems)
              dbContext.OrderItems.Add(item);
            dbContext.SaveChanges();
            return order.OrderId;
        }

    }
}
