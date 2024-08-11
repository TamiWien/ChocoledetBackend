using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DTO.Models
{
    public class OrderDTO
    {
        public Guid OrderId { get; set; }

        public Guid UserId { get; set; }

        public DateTime OrderDate { get; set; }

        public double TotalAmount { get; set; }

        public bool PaymentStatus { get; set; }

        public virtual ICollection<OrderItemDTO> OrderItems { get; set; } = new List<OrderItemDTO>();

        public virtual UserDTO User { get; set; } = null!;
    }
}
