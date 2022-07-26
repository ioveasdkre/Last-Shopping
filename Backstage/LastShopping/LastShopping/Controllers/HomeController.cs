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
            var test = EncryptUtils.SHA256Encrypt("tgewgsdg", true);
            Guid guid = Guid.NewGuid();
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