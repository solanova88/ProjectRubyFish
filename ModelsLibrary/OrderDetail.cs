using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLibrary
{
    public class OrderDetail
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; } // Внешний ключ к заказу
        public Guid ProductId { get; set; } // Внешний ключ к продукту
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
    }
}
