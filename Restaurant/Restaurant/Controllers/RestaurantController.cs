using Microsoft.AspNetCore.Mvc;
using Restaurant.Models.ORM;

namespace Restaurant.Controllers
{
    public class RestaurantController : Controller
    {
        ResContext resContext = new ResContext();

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Restaurant1 restaurant)
        {
            resContext.Add(restaurant);
            resContext.SaveChanges();

            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult List()
        {
            var resList = resContext.Restaurants.ToList();

            return View(resList);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var resDel = resContext.Restaurants.FirstOrDefault(q => q.Id == id);

            return View(resDel);
        }
        [HttpPost]
        public IActionResult Update(Restaurant1 restaurant)
        {
            resContext.Update(restaurant);
            resContext.SaveChanges();

            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var resdel = resContext.Restaurants.FirstOrDefault(q => q.Id == id);
            resContext.Remove(resdel);
            resContext.SaveChanges();

            return RedirectToAction("List");
        }
     


    }
}
