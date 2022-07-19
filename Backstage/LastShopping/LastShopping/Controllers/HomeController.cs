using LastShopping.Models;
using LastShopping.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LastShopping.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var test = EncryptUtils.AESEncrypt("我需要加密我需要加密我需要加密我需要加密我需要加密", "我跟你說你不要跟別人說，你若跟別人說，不要跟別人說是我叫你不要跟別人說", "gwgwg156116dg548964adga");
            var test2 = EncryptUtils.SHA256Encrypt("fwfwfwf");
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