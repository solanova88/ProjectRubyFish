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
        public Guid OrderId { get; set; } 
        public Guid ProductId { get; set; } 
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
    }
}
