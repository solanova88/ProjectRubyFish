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
        public DateTime OrderDateTime { get; set; }
        public OrderStatus Status { get; set; }
        public string DeliveryAddress { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
