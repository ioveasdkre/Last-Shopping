using LastShopping.Interface.Shared;
using LastShopping.Models.ManagerRole;
using LastShopping.VModels.ManagerRole;
using Microsoft.AspNetCore.Mvc;

namespace LastShopping.Controllers
{
    public class ManagerRoleController : Controller
    {
        private readonly ICRUDAsyncHelper<List<ManagerRoleVModel>, ManagerRoleVModel, ManagerRoleModel, ManagerRoleModel> _managerRoleHelper;

        public ManagerRoleController(ICRUDAsyncHelper<List<ManagerRoleVModel>, ManagerRoleVModel, ManagerRoleModel, ManagerRoleModel> helper)
        {
            _managerRoleHelper = helper;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _managerRoleHelper.GetAllAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ManagerRoleName")] ManagerRoleModel request)
        {
            if (ModelState.IsValid)
            {
                await _managerRoleHelper.CreateAsync(request);
                return RedirectToAction(nameof(Index));
            }
            return View(request);
        }
    }
}
