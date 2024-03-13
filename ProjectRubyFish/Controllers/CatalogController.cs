using Microsoft.AspNetCore.Mvc;
using ModelsLibrary;
using Services;

namespace ProjectRubyFish.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IProductService productService;
        public CatalogController(IProductService product) 
        {
            productService = product;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Rolls()
        {
            List<Product> Rolls = new List<Product>();

            Rolls = await productService.GetAllRollAsync();

            return View(Rolls);
        }
        public IActionResult Pizza()
        {
            return View();
        }
        public IActionResult Set()
        {
            return View();
        }
        public IActionResult Combo()
        {
            return View();
        }
        public IActionResult Desserts()
        {
            return View();
        }
        public IActionResult Drinks()
        {
            return View();
        }
        public async Task<IActionResult> ProductQuantityIncrement(Guid productId)
        {
                var updatedProduct = await productService.ProductQuantityIncrementAsync(productId);
                return Json(new { success = true, quantity = updatedProduct });
        }
        public async Task<IActionResult> ProductQuantityDecrement(Guid productId)
        {
                var updatedProduct = await productService.ProductQuantityDecrementAsync(productId);
                return Json(new { success = true, quantity = updatedProduct });
        }
    }
}

