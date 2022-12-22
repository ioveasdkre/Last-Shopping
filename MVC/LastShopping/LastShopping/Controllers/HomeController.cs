using LastShopping.Models;
using LastShopping.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static LastShopping.Services.Enums.EnumEncrypt;

namespace LastShopping.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public static readonly string AesKeyIV = AppSettingsUtils.GetAppSettingsValue("AES", "KeyIV");
        public static readonly string AesMixedSalt = AppSettingsUtils.GetAppSettingsValue("AES", "MixedSalt");


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }   

        public IActionResult Index()
        {
            var data = "Hello Benson 你好!!@@gwgwgdsgwg";
            var test = EncryptUtils.AESEncrypt(data, AesKeyIV, AesMixedSalt);
            var test2 = EncryptUtils.AESDecrypt(test, AesKeyIV);
            Guid guid = Guid.NewGuid();
            var tttt = CiphertextType.Base64;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}