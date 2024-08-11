﻿using System;
using System.Collections.Generic;

namespace App.DAL.Entities;

public partial class OrderItem
{
    public Guid OrderItemId { get; set; }

    public Guid OrderId { get; set; }

    public Guid ProductId { get; set; }

    public int Quantity { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
