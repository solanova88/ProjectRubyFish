﻿using ModelsLibrary;
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

        public async Task<List<Product>> GetAllRollAsync()
        {
            return await _context.Products.Where(p => p.Type == "Roll").ToListAsync();
        }
        public async Task<List<Product>> GetAllSetAsync()
        {
            return await _context.Products.Where(p => p.Type == "Set").ToListAsync();
        }
        public async Task<List<Product>> GetAllPizzaAsync()
        {
            return await _context.Products.Where(p => p.Type == "Pizza").ToListAsync();
        }
        public async Task<List<Product>> GetAllDrinksAsync()
        {
            return await _context.Products.Where(p => p.Type == "Drink").ToListAsync();
        }
        public async Task<List<Product>> GetAllDessertsAsync()
        {
            return await _context.Products.Where(p => p.Type == "Dessert").ToListAsync();
        }
        public async Task<List<Product>> GetAllComboAsync()
        {
            return await _context.Products.Where(p => p.Type == "Combo").ToListAsync();
        }

        public async Task<int?> ProductQuantityIncrementAsync(Guid productId)
        {
            var productToUpdate = await _context.Products.FindAsync(productId);

            if (productToUpdate != null)
            {
                productToUpdate.Quantity++;
                await _context.SaveChangesAsync();
                return productToUpdate.Quantity;
            }
            return null;
        }
        public async Task<int?> ProductQuantityDecrementAsync(Guid productId)
        {
            var productToUpdate = await _context.Products.FindAsync(productId);

            if (productToUpdate != null && productToUpdate.Quantity > 0)
            {
                productToUpdate.Quantity--;
                await _context.SaveChangesAsync();
                return productToUpdate.Quantity;
            }
            return 0;
        }
    }
}
