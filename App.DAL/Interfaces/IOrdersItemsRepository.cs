﻿using App.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL.Interfaces
{
    public interface IOrdersItemsRepository
    {
        public List<OrderItem> GetOrderItemsById(Guid id);
    }
}
