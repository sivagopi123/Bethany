using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Normal()
        {
            return View("MyView");
        }
    }
}