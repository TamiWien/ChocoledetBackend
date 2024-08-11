using App.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BL.Interfaces
{
    public interface IOrderItemService
    {
        public List<OrderItemDTO> GetOrderItemsById(Guid id);

    }
}
