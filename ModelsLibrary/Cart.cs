﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLibrary
{
    public class Cart
    {
        public int Id { get; set; }
        public List<Product>? Products { get; set; }
        public uint? Ammount { get; set; }
    }
}