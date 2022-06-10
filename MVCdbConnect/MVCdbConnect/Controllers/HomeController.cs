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
        public IActionResult Add(Suppliers suppliers)
        {

            siemensContext.Add(suppliers);
            siemensContext.SaveChanges();

            return View();
        }


        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {

            siemensContext.Add(product);
            siemensContext.SaveChanges();

            return View();
        }

        public IActionResult Products()
        {
            var products = siemensContext.Products.ToList();

            return View(products);
        }
    }
}
