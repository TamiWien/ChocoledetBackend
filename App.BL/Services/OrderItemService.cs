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
    public class OrderItemService: IOrderItemService
    {
        public IOrdersItemsRepository ordersItem;
        public OrderItemService(IOrdersItemsRepository ordersItemsRepository)
        {
            ordersItem = ordersItemsRepository;
        }
        public List<OrderItemDTO> GetOrderItemsById(Guid id)
        {
            List <OrderItem> orderItemList= ordersItem.GetOrderItemsById(id);
            return orderItemList.Select(u => OrderItemMapper.Map(u)).ToList();
        }
    }
}
