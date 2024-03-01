﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLibrary;

namespace Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductsAsync();
        Task ProductQuantityIncrementAsync(Product product);
        Task ProductQuantityDecrementAsync(Product product);
    }
}
