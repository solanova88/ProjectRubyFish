using ModelsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbContextLibrary;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            var result = await _context.Products.ToListAsync();
            return result;
        }

        public async Task ProductQuantityIncrementAsync(Product product)
        {
            try
            {
                await Task.Delay(150);
                product.Quantity++;
                await _context.SaveChangesAsync();
            }
            catch
            {
                await Task.Delay(250);
                product.Quantity++;
                await _context.SaveChangesAsync();
            }
        }
        public async Task ProductQuantityDecrementAsync(Product product)
        {
            try
            {
                await Task.Delay(150);
                if (product.Quantity > 0)
                {
                    product.Quantity--;
                    await _context.SaveChangesAsync();
                }
            }
            catch
            {
                await Task.Delay(250);
                if (product.Quantity > 0)
                {
                    product.Quantity--;
                    await _context.SaveChangesAsync();
                }
            }

        }


    }
}
