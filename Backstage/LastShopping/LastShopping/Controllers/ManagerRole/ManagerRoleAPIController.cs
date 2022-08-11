using Charlotte.Enum;
using LastShopping.Interface.Shared;
using LastShopping.Models;
using LastShopping.Models.ManagerRole;
using LastShopping.Services;
using LastShopping.VModels.ManagerRole;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace LastShopping.Controllers.ManagerRole
{
    [ApiController]
    [Route("[controller]")]
    public class ManagerRoleAPIController : Controller
    {
        private readonly ICRUDAsyncHelper<List<ManagerRoleVModel>, ManagerRoleVModel, ManagerRoleModel, ManagerRoleModel> _managerRoleHelper;

        public ManagerRoleAPIController(ICRUDAsyncHelper<List<ManagerRoleVModel>, ManagerRoleVModel, ManagerRoleModel, ManagerRoleModel> helper)
        {
            _managerRoleHelper = helper;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = new ResultModel();

            try
            {
                await _managerRoleHelper.DeleteAsync(id);
                result.Code = HttpStatusCode.OK;
                result.Message = EnumUtils.GetDescription(EnumResult.DeleteSuccess);
            }
            catch (Exception ex)
            {
                result.Code = HttpStatusCode.BadRequest;
                result.Message = EnumUtils.GetDescription(EnumResult.DeleteFail);
                LoggerUtils.Error(ex);
            }
            return View();
        }
    }
}
