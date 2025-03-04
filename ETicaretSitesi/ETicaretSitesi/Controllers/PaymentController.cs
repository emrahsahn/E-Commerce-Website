//using Microsoft.AspNetCore.Mvc;
//using ETicaretSitesi.Models;
//using ETicaretSitesi.Business.Services;
//using Iyzipay.Model;
//using Iyzipay.Request;
//// using Iyzipay.Model; satırı yerine aşağıdaki gibi tam nitelikli adla referans edin
//using IyzicoPayment = Iyzipay.Model.Payment;

//// ETicaretSitesi.Models.Payment için:
//using ECommercePayment = ETicaretSitesi.Models.Payment;

//namespace ETicaretSitesi.Controllers
//{

//    public class PaymentController : Controller
//    {
//        private readonly PaymentService _paymentService;

//        public PaymentController()
//        {
//            _paymentService = new PaymentService();
//        }

//        [HttpGet]
//        public IActionResult Index()
//        {
//            var totalAmount = TempData["TotalAmount"] != null ? TempData["TotalAmount"].ToString() : "0";
//            ViewBag.TotalAmount = totalAmount;
//            return View(new Payment { Price = decimal.Parse(totalAmount) });
//        }

//        [HttpPost]
//        public IActionResult ProcessPayment(Payment model)
//        {
//            if (!ModelState.IsValid)
//            {
//                return View("Index", model);
//            }

//            // Ödeme talebi oluştur
//            var paymentRequest = new CreatePaymentRequest
//            {
//                Locale = Locale.TR.ToString(),
//                ConversationId = Guid.NewGuid().ToString(),
//                Price = model.Price.ToString("F"),
//                PaidPrice = model.Price.ToString("F"),
//                Currency = Currency.TRY.ToString(),
//                Installment = 1,
//                PaymentCard = new PaymentCard
//                {
//                    CardHolderName = model.CardHolderName,
//                    CardNumber = model.CardNumber,
//                    ExpireMonth = model.ExpireMonth,
//                    ExpireYear = model.ExpireYear,
//                    Cvc = model.Cvc,
//                    RegisterCard = 0
//                },
//                Buyer = new Buyer
//                {
//                    Id = Guid.NewGuid().ToString(),
//                    Name = model.BuyerName,
//                    Surname = model.BuyerSurname,
//                    Email = model.Email,
//                    RegistrationAddress = model.BuyerAddress,
//                    Ip = Request.HttpContext.Connection.RemoteIpAddress?.ToString(),
//                    City = "Istanbul",
//                    Country = "Turkey"
//                },
//                BasketItems = new List<BasketItem>
//                {
//                    new BasketItem
//                    {
//                        Id = "1",
//                        Name = "Sepet Ürünü",
//                        Category1 = "Genel",
//                        Price = model.Price.ToString("F"),
//                        ItemType = BasketItemType.PHYSICAL.ToString()
//                    }
//                }
//            };

//            // Ödeme yap
//            var response = _paymentService.MakePayment(paymentRequest);

//            if (response.Status != "success")
//            {
//                ViewBag.Message = "Ödeme Başarısız: " + response.ErrorMessage;
//                return View("Error");
//            }
//            else
//            {
//                ViewBag.Message = "Ödeme Başarılı!";
//                return View("Success");
//            }

//        }
//        [HttpPost]
//        public IActionResult Checkout()
//        {
//            var totalAmount = carts.Sum(c => c.Quantity * c.Product.Price);
//            TempData["TotalAmount"] = totalAmount;
//            return RedirectToAction("Index", "Payment");
//        }

//    }
//}
