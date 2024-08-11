using App.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BL.Interfaces
{
    public interface IOrderService
    {
        public List<OrderDTO> GetOrdersById(Guid id);
        public Guid CreateOrder(OrderDTO order);

    }
}
