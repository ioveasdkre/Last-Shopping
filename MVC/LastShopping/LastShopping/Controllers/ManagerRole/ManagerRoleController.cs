using LastShopping.Interface.Shared;
using LastShopping.Models.ManagerRole;
using LastShopping.VModels.ManagerRole;
using Microsoft.AspNetCore.Mvc;

namespace LastShopping.Controllers.ManagerRole
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
        public async Task<IActionResult> Create([Bind("Name")] ManagerRoleModel request)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _managerRoleHelper.CreateAsync(request);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return Problem("發生錯誤");
            }
            return View(request);
        }

        [HttpPut]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(int id)
        {
            try
            {

                await _managerRoleHelper.DeleteAsync(id);
            }
            catch
            {
                return Problem("發生錯誤");
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
