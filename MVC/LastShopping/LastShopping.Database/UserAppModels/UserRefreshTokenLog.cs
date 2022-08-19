using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LastShopping.Database.UserAppModels
{
    /// <summary>使用者Token紀錄表</summary>
    [Index(nameof(UserMainId))]
    public class UserRefreshTokenLog
    {
        /// <summary>使用者Token紀錄</summary>
        [Display(Name = "Token紀錄")]
        [Comment("使用者Token紀錄")]
        [Key]
        public string RefreshToken { get; set; } = null!;
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

        /// <summary>使用者Id</summary>
        [Display(Name = "使用者Id")]
        [Comment("使用者Id")]
        [Required]
        public int UserMainId { get; set; }
        [ForeignKey("UserMainId")]
        public UserMain UserMain { get; set; } = null!;
    }
}
