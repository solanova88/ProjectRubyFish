using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLibrary
{
    public class OrderViewModel
    {
        public OrderFormViewModel FormData { get; set; }
        public List<OrderDetailViewModel> Products { get; set; }

    }
}
