using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LastShopping.Database.UserAppModels
{
    /// <summary>管理者Token紀錄表</summary>
    [Index(nameof(ManagerMainId))]
    public class ManagerRefreshTokenLog
    {
        /// <summary>管理者Token紀錄</summary>
        [Display(Name = "Token紀錄")]
        [Comment("Token紀錄")]
        [Key]
        public string RefreshToken { get; set; } = string.Empty;
        /// <summary>建立時間</summary>
        [Display(Name = "建立時間")]
        [Comment("建立時間")]
        [Required]
        public DateTime CreateDate { get; set; }
        /// <summary>Token有效時間</summary>
        [Display(Name = "Token有效時間")]
        [Comment("Token有效時間")]
        [Required]
        public DateTime ExpirationDate { get; set; }

        /// <summary>管理者Id</summary>
        [Display(Name = "管理者Id")]
        [Comment("管理者Id")]
        [Required]
        public int ManagerMainId { get; set; }
        [ForeignKey("ManagerMainId")]
        public ManagerMain ManagerMain { get; set; } = null!;
    }
}
