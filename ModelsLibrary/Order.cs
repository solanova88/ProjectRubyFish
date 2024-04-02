using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLibrary
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public OrderStatus Status { get; set; }
        public Guid UserId { get; set; }
        public DeliveryAddress DeliveryAddress { get; set; }
        public string? Comment { get; set; }
        public List<OrderDetail> Details { get; set; }
    }
}
