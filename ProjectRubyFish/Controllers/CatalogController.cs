using Microsoft.AspNetCore.Mvc;
using ModelsLibrary;
using Services;

namespace ProjectRubyFish.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Rolls([FromServices] IProductService product)
        {
            List<Product> Rolls = new List<Product>();

            Rolls = await product.GetAllRollAsync();
     
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
    }
}
