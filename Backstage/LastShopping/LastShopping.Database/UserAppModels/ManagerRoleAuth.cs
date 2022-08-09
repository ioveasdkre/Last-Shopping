using LastShopping.Database.LastShoppingModels;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LastShopping.Database.UserAppModels
{
    /// <summary>管理者身分權限表</summary>
    [Index(nameof(ManagerRoleId))]
    [Index(nameof(ManagerRouterId))]
    public class ManagerRoleAuth
    {
        /// <summary>管理者身分Id</summary>
        [Display(Name = "管理平台身分Id")]
        [Comment("管理平台身分Id")]
        [Required]
        public int ManagerRoleId { get; set; }
        [ForeignKey("ManagerRoleId")]
        public ManagerRole ManagerRole { get; set; } = null!;
        /// <summary>路由ID</summary>
        [Display(Name = "路由ID")]
        [Comment("路由ID")]
        [Required]
        public int ManagerRouterId { get; set; }
        [ForeignKey("ManagerRouterId")]
        public ManagerRouter ManagerRouter { get; set; } = null!;

        /// <summary>瀏覽權限</summary>
        [Display(Name = "瀏覽權限")]
        [Comment("瀏覽權限")]
        [Required]
        public bool ViewAuth { get; set; }
        /// <summary>新增權限</summary>
        [Display(Name = "新增權限")]
        [Comment("新增權限")]
        [Required]
        public bool CreateAuth { get; set; }
        /// <summary>修改權限</summary>
        [Display(Name = "修改權限")]
        [Comment("修改權限")]
        [Required]
        public bool ModifyAuth { get; set; }
        /// <summary>刪除權限</summary>
        [Display(Name = "刪除權限")]
        [Comment("刪除權限")]
        [Required]
        public bool DeleteAuth { get; set; }
        /// <summary>檔案權限</summary>
        [Display(Name = "檔案權限")]
        [Comment("檔案權限")]
        [Required]
        public bool ExportAuth { get; set; }
        /// <summary>建立時間</summary>
        [Display(Name = "建立時間")]
        [Comment("建立時間")]
        [Required]
        public DateTime CreateDate { get; set; }
        /// <summary>修改時間</summary>
        [Display(Name = "修改時間")]
        [Comment("修改時間")]
        public DateTime? ModifyDate { get; set; }
    }
}
