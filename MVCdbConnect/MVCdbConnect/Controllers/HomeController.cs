using Microsoft.AspNetCore.Mvc;
using MVCdbConnect.Models.ORM;

namespace MVCdbConnect.Controllers
{
    public class HomeController : Controller
    {
        SiemensContext siemensContext = new SiemensContext();
        [HttpGet]
        public IActionResult Index()

        {
            List<Suppliers> suppliersList = siemensContext.Suppliers.ToList();
            return View(suppliersList);
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var idSup = siemensContext.Suppliers.FirstOrDefault(q => q.Id == id);

            return View(idSup);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add( Suppliers suppliers)
        {

            siemensContext.Add(suppliers);
            siemensContext.SaveChanges();

            return View();
        }
    }
}
