using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LastShopping.Database.UserAppModels
{
    /// <summary>路由控制表</summary>
    [Index(nameof(Id))]
    public class ManagerRouter
    {
        /// <summary>路由Id</summary>
        [Display(Name = "路由Id")]
        [Comment("路由Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>路由名稱</summary>
        [Display(Name = "路由名稱")]
        [Comment("路由名稱")]
        [Required]
        [StringLength(256)]
        public string Name { get; set; } = string.Empty;
        /// <summary>網頁連結</summary>
        [Display(Name = "網頁連結")]
        [Comment("網頁連結")]
        [Required]
        [StringLength(256)]
        public string Link { get; set; } = string.Empty;
        /// <summary>圖標</summary>
        [Display(Name = "圖標")]
        [Comment("圖標")]
        [StringLength(256)]
        public string? Icon { get; set; }
        /// <summary>路由身分</summary>
        [Display(Name = "路由身分")]
        [Comment("路由身分")]
        [Required]
        public int GroupId { get; set; }
        /// <summary>路由使用權限</summary>
        [Display(Name = "路由使用權限")]
        [Comment("路由使用權限")]
        [Required]
        public bool Flag { get; set; }

        public ICollection<ManagerRoleAuth> ManagerRoleAuths { get; set; } = null!;
    }
}
