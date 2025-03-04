//using Iyzipay;
//using Iyzipay.Model;
//using Iyzipay.Request;

//namespace ETicaretSitesi.Business.Services
//{
//    public class PaymentService
//    {
//        private readonly Options _options;

//        public PaymentService()
//        {
//            _options = new Options
//            {
//                ApiKey = "API_KEY",       // İyzico'dan aldığınız API Key
//                SecretKey = "SECRET_KEY", // İyzico'dan aldığınız Secret Key
//                BaseUrl = "https://sandbox-api.iyzipay.com" // Test ortamı için kullanılır
//            };
//        }

//        public async Task<Iyzipay.Model.Payment> MakePayment(CreatePaymentRequest request)
//        {
//            return await Iyzipay.Model.Payment.CreateAsync(request, _options);
//        }

//    }
//}
