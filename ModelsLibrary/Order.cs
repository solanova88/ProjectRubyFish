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
        public List<OrderDetail> OrderDetails { get; set; } // Детали заказа

        public Order()
        {
            Id = Guid.NewGuid();
            OrderDateTime = DateTime.Now;
            Status = OrderStatus.Pending; // По умолчанию статус заказа - ожидает обработки
            OrderDetails = new List<OrderDetail>();
        }
    }

    public enum OrderStatus
    {
        Pending,
        Processing,
        InTransit,
        Delivered,
        Cancelled
    }
}
