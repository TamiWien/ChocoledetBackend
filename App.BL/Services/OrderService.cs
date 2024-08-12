using App.BL.Interfaces;
using App.BL.Mappers;
using App.DAL.DataContext;
using App.DAL.Entities;
using App.DAL.Interfaces;
using App.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BL.Services
{
    public class OrderService: IOrderService
    {
        public IOrdersRepository orders;
        public IOrdersItemsRepository ordersItems;
        public OrderService(IOrdersRepository ordersRepository)
        {
            orders = ordersRepository;
        }
        public List<OrderDTO> GetOrdersById(Guid id)
        {
            List<Order> orderList = orders.GetOrdersById(id);
            return orderList.Select(u => OrderMapper.Map(u)).ToList();
        }
        public Guid CreateOrder(OrderDTO order)
        {
            return orders.CreateOrder(OrderMapper.Map(order));
        }
    }
}
