using System.ComponentModel.DataAnnotations;

namespace LastShopping.Models.ManagerRole
{
    public class ManagerRoleModel
    {
        /// <summary>管理者身分名稱</summary>
        [Display(Name = "身分名稱")]
        public string ManagerRoleName { get; set; } = string.Empty;
    }
}