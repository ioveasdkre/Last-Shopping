using Dapper;
using LastShopping.Database.DbContextModel;
using LastShopping.Database.UserAppModels;
using LastShopping.Enum;
using LastShopping.Interface.Shared;
using LastShopping.Models.ManagerRole;
using LastShopping.Services;
using LastShopping.VModels.ManagerRole;
using Microsoft.EntityFrameworkCore;
using NPOI.POIFS.Crypt.Dsig;
using System.Data.SqlClient;

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
            string sqlConStr = AppSettingsUtils.GetConnectionString(EnumUtils.GetDescription(EnumDataBase.UserAppDb));
            using (SqlConnection con = new(sqlConStr))
            {
                await con.OpenAsync();
                string sqlStr = @"SELECT Id, Name, convert(varchar, CreateDate, 23) as CreateDate, convert(varchar, ModifyDate, 23) as ModifyDate
                                FROM ManagerRole";
                var result = await con.QueryAsync<ManagerRoleVModel>(sqlStr);
                return result.ToList();
            }
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
            ManagerRole managerRole = new()
            {
                Name = request.Name,
                CreateDate = DateTime.Now
            };

            _userAppDb.Add(managerRole); // 新增
            await _userAppDb.SaveChangesAsync(); // 以非同步方式將此內容中所做的所有變更儲存至基礎資料庫
        }

        public async Task DeleteAsync(int id)
        {
            ManagerRole data = await _userAppDb.ManagerRole.SingleAsync(a => a.Id == id);
            _userAppDb.ManagerRole.Remove(data);
            await _userAppDb.SaveChangesAsync(); // 以非同步方式將此內容中所做的所有變更儲存至基礎資料庫

        }

        public async Task BatchDeleteAsync(List<int> idList)
        {
            throw new NotImplementedException();
        }

        public Task ModifyAsync(int id, ManagerRoleModel request)
        {
            throw new NotImplementedException();
        }
    }
}
