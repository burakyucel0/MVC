using Microsoft.AspNetCore.Mvc;

namespace RestaurantProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
