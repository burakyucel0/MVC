using Microsoft.AspNetCore.Mvc;

namespace MVCBusinessCasual.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult Store()
        {
            return View();
        }
    }
}
