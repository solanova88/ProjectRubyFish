using Microsoft.AspNetCore.Mvc;
using Services;
using ModelsLibrary;

namespace ProjectRubyFish.Controllers
{
    public class CartController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;
        public CartController(IOrderService orderService, IUserService userService)
        {
            _orderService = orderService;
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Order()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] OrderViewModel model)
        {
            var isUserExists = await _userService.CheckUserTask(model.FormData.Phone);

            if (!isUserExists)
            {
                await _userService.CreateUserAsync(model.FormData.Name, model.FormData.Email, model.FormData.Phone);
            }
            var currentUserId = await _userService.GetUserIdByPhoneNumberAsync(model.FormData.Phone);
           

            await _orderService.AddOrderAsync(currentUserId, model);


            return RedirectToAction("Order");
        }
    }
}
