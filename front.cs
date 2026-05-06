using Microsoft.AspNetCore.Mvc;

namespace FoodWebsite.Controllers
{
    public class HomeController : Controller
    {
        // Show menu
        public IActionResult Index()
        {
            return View();
        }

        // Handle order
        [HttpPost]
        public IActionResult Order(string food, int quantity)
        {
            ViewBag.Food = food;
            ViewBag.Quantity = quantity;
            return View("Result");
        }
    }
}
