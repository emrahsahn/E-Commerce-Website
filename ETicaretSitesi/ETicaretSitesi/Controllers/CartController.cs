using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ETicaretSitesi.Models;
using Newtonsoft.Json;

namespace ETicaretSitesi.Controllers
{
    public class CartController : Controller
    {
        private static List<Cart> carts = new List<Cart>(); // Bellekte sepet listesi

        private readonly ProductsController productsController = new ProductsController(); // Ürünlere erişim için

        // Sepet Sayfası
        public IActionResult Index()
        {
            ViewBag.PreviousProductId = TempData["PreviousProductId"];
            return View(carts); // Sepeti döndür
        }

        // Sepete Ürün Ekle
        public IActionResult AddToCart(int productId, int quantity)
        {
            var product = productsController.GetProductById(productId); // Ürünü getir

            if (product != null)
            {
                var cartItem = carts.FirstOrDefault(c => c.ProductID == productId);

                if (cartItem != null)
                {
                    cartItem.Quantity += quantity; // Ürün sepetteyse miktarı artır
                }
                else
                {
                    carts.Add(new Cart
                    {
                        CartID = carts.Count + 1,
                        ProductID = productId,
                        Quantity = quantity,
                        Product = product,
                        UserId = 1, // Sabit bir kullanıcı
                        CreatedDate = System.DateTime.Now
                    });
                }
            }

            return RedirectToAction("Index");
        }

        // Sepetten Ürün Çıkar
        public IActionResult RemoveFromCart(int id)
        {
            var cartItem = carts.FirstOrDefault(c => c.CartID == id);
            if (cartItem != null)
            {
                carts.Remove(cartItem);
            }

            return RedirectToAction("Index");
        }

        // Sepetteki Ürünün Miktarını Güncelle
        [HttpPost]
        public IActionResult UpdateQuantity(int cartId, int quantity)
        {
            var cartItem = carts.FirstOrDefault(c => c.CartID == cartId);
            if (cartItem != null && quantity > 0)
            {
                cartItem.Quantity = quantity; // Miktarı güncelle
            }
            return Json(new { success = true });
        }
        public void SaveCartToSession(List<Cart> carts)
        {
            HttpContext.Session.SetString("CartData", JsonConvert.SerializeObject(carts));
        }

        public List<Cart> GetCartFromSession()
        {
            var cartData = HttpContext.Session.GetString("CartData");
            return cartData != null ? JsonConvert.DeserializeObject<List<Cart>>(cartData) : new List<Cart>();
        }

    }
}
 