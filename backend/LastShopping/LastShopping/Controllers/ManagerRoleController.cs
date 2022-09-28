using Microsoft.AspNetCore.Mvc;

namespace LastShopping.Controllers
{
    public class ManagerRoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
