using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLibrary;

namespace Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllRollAsync();
        Task<List<Product>> GetAllSetAsync();
        Task<List<Product>> GetAllPizzaAsync();
        Task<List<Product>> GetAllDrinksAsync();
        Task<List<Product>> GetAllDessertsAsync();
        Task<List<Product>> GetAllComboAsync();

        Task<int?> ProductQuantityIncrementAsync(Guid productId);
        Task<int?> ProductQuantityDecrementAsync(Guid productId);
    }
}
