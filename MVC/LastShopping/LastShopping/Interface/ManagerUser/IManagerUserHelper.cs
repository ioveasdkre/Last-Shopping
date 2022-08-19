using LastShopping.Interface.Shared;
using LastShopping.Models.ManagerMain;
using LastShopping.VModels.ManagerMain;

namespace LastShopping.Interface.ManagerUser
{
    public interface IManagerUserHelper : ICRUDAsyncHelper<ManagerMainsVModel, ManagerMainVModel, CreateManagerMainModel, ModifyManagerMainModel>
    {
    }
}
