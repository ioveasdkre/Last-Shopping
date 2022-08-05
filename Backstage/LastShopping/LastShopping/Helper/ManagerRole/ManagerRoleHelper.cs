using LastShopping.Database.DbContextModel;
using LastShopping.Interface.Shared;
using LastShopping.Models.ManagerRole;
using LastShopping.VModels.ManagerRole;

namespace LastShopping.Helper.ManagerRole
{
    public class ManagerRoleHelper : ICRUDAsyncHelper<ManagerRoleVModel, ManagerRoleVModel, ManagerRoleModel, ManagerRoleModel>
    {
        public UserAppDbContext _userAppDb { get; }


        public ManagerRoleHelper(UserAppDbContext userAppDb)
        {
            _userAppDb = userAppDb;
        }

        public Task<ManagerRoleVModel> GetAllAsync(int? limit, int? offset, string? orderBy, string? orderDescription, string? filterStr)
        {
            throw new NotImplementedException();
        }

        public Task<ManagerRoleVModel> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task CreateAsync(ManagerRoleModel request)
        {
            Database.UserAppModels.ManagerRole managerRole = new()
            {
                ManagerRoleName = request.ManagerRoleName,
                CreateDate = DateTime.Now
            };

            _userAppDb.Add(managerRole); // 新增
            await _userAppDb.SaveChangesAsync(); // 以非同步方式將此內容中所做的所有變更儲存至基礎資料庫
        }

        public Task BatchDeleteAsync(List<int> idList)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task ModifyAsync(int id, ManagerRoleModel request)
        {
            throw new NotImplementedException();
        }
    }
}
