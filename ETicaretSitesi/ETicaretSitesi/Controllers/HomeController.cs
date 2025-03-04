using Microsoft.AspNetCore.Mvc;
using ETicaretSitesi.Models;
using System.Collections.Generic;

namespace ETicaretSitesi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductsController _productsController;

        public HomeController()
        {
            _productsController = new ProductsController();
        }

        public IActionResult Index()
        {
            // Kategorilere g�re �r�nleri al
            var menProducts = _productsController.GetProductsByCategory(1); // Men's CategoryId = 1
            var womenProducts = _productsController.GetProductsByCategory(2); // Women's CategoryId = 2
            var kidsProducts = _productsController.GetProductsByCategory(3); // Kid's CategoryId = 3

            // ViewBag ile verileri View'e ta��
            ViewBag.MenProducts = menProducts;
            ViewBag.WomenProducts = womenProducts;
            ViewBag.KidsProducts = kidsProducts;

            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
