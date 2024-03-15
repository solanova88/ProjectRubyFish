using Microsoft.AspNetCore.Mvc;
using ModelsLibrary;
using Services;

namespace ProjectRubyFish.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductService _productService;
        public CartController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> Index()
        {
            List<Product> Products = new List<Product>();

            Products = await _productService.GetAllCartProductsAsync();

            return View(Products);
        }
    }
}
