using Microsoft.AspNetCore.Mvc;
using ETicaretSitesi.Models;
using System.Threading.Tasks;

namespace ETicaretSitesi.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Login
        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                // Kimlik doğrulama işlemleri burada yapılır
                // Eğer doğrulama başarılıysa:
                return RedirectToLocal(returnUrl);
            }

            // Hata durumunda tekrar Login sayfasını döndür
            return View(model);
        }

        // GET: /Account/Register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Kullanıcı kaydı işlemleri burada yapılır
                // Örneğin, kullanıcı bilgilerini veritabanına kaydedin
                return RedirectToAction("Login");
            }

            // Hata durumunda tekrar Register sayfasını döndür
            return View(model);
        }

        // GET: /Account/ForgotPassword
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        // POST: /Account/ForgotPassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Şifre sıfırlama işlemleri burada yapılır
                // Kullanıcıya sıfırlama bağlantısı gönderilir
                ViewBag.Message = "Şifre sıfırlama bağlantısı e-posta adresinize gönderildi.";
            }

            return View(model);
        }

        // GET: /Account/ResetPassword
        [HttpGet]
        public IActionResult ResetPassword(string code = null)
        {
            if (code == null)
            {
                return BadRequest("Şifre sıfırlama kodu gerekli.");
            }

            var model = new ResetPasswordViewModel { Code = code };
            return View(model);
        }

        // POST: /Account/ResetPassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ResetPassword(ResetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Şifre sıfırlama işlemleri burada yapılır
                ViewBag.Message = "Şifreniz başarıyla sıfırlandı.";
                return RedirectToAction("Login");
            }

            return View(model);
        }

        // Yardımcı Metot: Kullanıcıyı geri döndürülecek URL'ye yönlendirme
        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
