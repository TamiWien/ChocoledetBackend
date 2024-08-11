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
    public class OrdersItemsRepository: IOrdersItemsRepository
    {
        public ChocoledetContext dbContext;
        public OrdersItemsRepository(ChocoledetContext chocoledetContext)
        {
            dbContext = chocoledetContext;
        }
        public List<OrderItem> GetOrderItemsById(Guid id)
        {
            List<OrderItem> orderItems = dbContext.OrderItems.Where(u => u.OrderId == id).ToList();
            return orderItems;
        }
    }
}
