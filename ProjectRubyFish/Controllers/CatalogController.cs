using Microsoft.AspNetCore.Mvc;
using ModelsLibrary;
using Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectRubyFish.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IProductService _productService;

        public CatalogController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Rolls()
        {
            var rolls = await _productService.GetAllRollAsync();
            return View(rolls);
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

