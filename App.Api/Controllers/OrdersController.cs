using App.Api.Mappers;
using App.Api.Models;
using App.BL.Interfaces;
using App.BL.Mappers;
using App.DAL.Entities;
using App.DTO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private IOrderService _orderService;
        public OrdersController(IOrderService ordersService)
        {
            _orderService = ordersService;
        }
        [HttpGet("{id}")]

        public List<OrderDTO> GetOrdersById(Guid id)
        {
            return _orderService.GetOrdersById(id);
        }

        [HttpPost]
        public Guid CreateOrder(OrderRequest order)
        {
            return _orderService.CreateOrder(OrderMapper.Map(order));
        }

    }
}
