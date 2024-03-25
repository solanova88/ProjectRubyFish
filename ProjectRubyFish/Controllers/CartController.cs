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
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> GetProducts()
        {
            var products = await _productService.GetAllProductAsync();
            return Json(products);
        }
    }
}
