using ModelsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLibrary
{
    public class OrderFormViewModel
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string Apartment { get; set; }
        public string? Entrance { get; set; }
        public string? Floor { get; set; }
        public string? Doorphone { get; set; }
        public string? Comment { get; set; }
    }
}
