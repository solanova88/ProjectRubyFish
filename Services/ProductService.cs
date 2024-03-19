using ModelsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbContextLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.CodeAnalysis;

namespace Services
{
    public class ProductService : IProductService
    {

        private readonly DataContext _context;


        public ProductService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Product>> GetAllProductAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<List<Product>> GetAllRollAsync()
        {
            return await _context.Products.Where(p => p.Type == ProductType.Roll).ToListAsync();
        }
        public async Task<List<Product>> GetAllSetAsync()
        {
            return await _context.Products.Where(p => p.Type == ProductType.Set).ToListAsync();
        }
        public async Task<List<Product>> GetAllPizzaAsync()
        {
            return await _context.Products.Where(p => p.Type == ProductType.Pizza).ToListAsync();
        }
        public async Task<List<Product>> GetAllDrinksAsync()
        {
            return await _context.Products.Where(p => p.Type == ProductType.Drink).ToListAsync();
        }
        public async Task<List<Product>> GetAllDessertsAsync()
        {
            return await _context.Products.Where(p => p.Type == ProductType.Dessert).ToListAsync();
        }
        public async Task<List<Product>> GetAllComboAsync()
        {
            return await _context.Products.Where(p => p.Type == ProductType.Combo).ToListAsync();
        }
    }
}
