using DbContextLibrary;
using Microsoft.EntityFrameworkCore;
using ModelsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CartService : ICartService
    {
        private readonly DataContext _context;

        public CartService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Cart>> GetAllCartAsync()
        {
            var result = await _context.ProductsList.ToListAsync();
            return result;
        }

    }
}
