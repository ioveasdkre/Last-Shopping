using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace LastShopping.VModels.ManagerRole
{
    public class ManagerRoleVModel
    {
        /// <summary>管理者身分Id</summary>
        [Display(Name = "Id")]
        public int Id { get; set; }
        /// <summary>管理者身分名稱</summary>
        [Display(Name = "身分名稱")]
        public string Name { get; set; } = string.Empty;
        /// <summary>建立時間</summary>
        [Display(Name = "建立時間")]
        public string CreateDate { get; set; } = string.Empty;
        /// <summary>修改時間</summary>
        [Display(Name = "修改時間")]
        public string? ModifyDate { get; set; }
    }
}
