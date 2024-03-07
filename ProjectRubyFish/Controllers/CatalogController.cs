using Microsoft.AspNetCore.Mvc;
using Services;

namespace ProjectRubyFish.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Rolls()
        {
            return View();
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
