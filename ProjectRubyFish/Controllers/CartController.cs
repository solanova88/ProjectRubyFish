using Microsoft.AspNetCore.Mvc;

namespace ProjectRubyFish.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
