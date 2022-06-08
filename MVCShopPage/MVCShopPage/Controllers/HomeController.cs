using Microsoft.AspNetCore.Mvc;
using MVCShopPage.Models;

namespace MVCShopPage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product { Name = "Macbook", Price = 10000, SalePrice = 9500 });
            products.Add(new Product { Name = "Dell", Price = 8000, SalePrice = 7800 });
            products.Add(new Product { Name = "Asus", Price = 8500, SalePrice = 8200 });
            products.Add(new Product { Name = "Msi", Price = 9000, SalePrice = 8800 });
            products.Add(new Product { Name = "Acer", Price = 7000, SalePrice = 6800 });
            products.Add(new Product { Name = "Monster", Price = 8500, SalePrice = 8100 });
            products.Add(new Product { Name = "Fujitsu", Price = 7800, SalePrice = 7500 });
            products.Add(new Product { Name = "Paşa Döner", Price = 30, SalePrice = 29.90m });


            return View(products);
        }

  

    }
}
