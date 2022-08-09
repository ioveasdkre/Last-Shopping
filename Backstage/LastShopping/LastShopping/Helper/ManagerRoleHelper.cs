using LastShopping.Database.DbContextModel;
using LastShopping.Interface.Shared;
using LastShopping.Models.ManagerRole;
using LastShopping.VModels.ManagerRole;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace LastShopping.Helper
{
    public class ManagerRoleHelper : ICRUDAsyncHelper<List<ManagerRoleVModel>, ManagerRoleVModel, ManagerRoleModel, ManagerRoleModel>
    {
        private readonly UserAppDbContext _userAppDb;


        public ManagerRoleHelper(UserAppDbContext userAppDb)
        {
            _userAppDb = userAppDb;
        }

        public async Task<List<ManagerRoleVModel>> GetAllAsync()
        {
            string sqlStr = @"SELECT Id, Name,  convert(varchar, CreateDate, 23) as CreateDate, convert(varchar, ModifyDate, 23) as ModifyDate
                                FROM ManagerRole";
            var test = await _userAppDb.ManagerRole.FromSqlRaw(sqlStr).ToListAsync();
            return test.Adapt<List<ManagerRoleVModel>>();
        }

        public Task<List<ManagerRoleVModel>> GetAllAsync(int? limit, int? offset, string? orderBy, string? orderDescription, string? filterStr)
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
                Name = request.Name,
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
