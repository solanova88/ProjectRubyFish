using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLibrary
{
    public enum ProductType
    {
        Roll,
        Pizza,
        Set,
        Combo,
        Dessert,
        Drink
    }
    public class Product
    {
        public Guid Id { get; set; }
        public ProductType Type { get; set; }
        public string? Title { get; set; }
        public int? Quantity { get; set; }
        public int? Price { get; set; }
        public string? Description { get; set; }
    }
}
