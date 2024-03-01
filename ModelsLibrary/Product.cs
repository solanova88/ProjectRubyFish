using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLibrary
{
    public class Product
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public string? Title { get; set; }
        public uint Quantity { get; set; } = 0;
        public uint? Price { get; set; }
        public string? Description { get; set; }
    }
}
