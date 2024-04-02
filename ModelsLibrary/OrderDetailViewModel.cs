using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLibrary
{
    public class OrderDetailViewModel
    {
        public Guid ProductId { get; set; }
        public int ProductPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
    }
}
