using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace LastShopping.Database.UserAppModels
{
    /// <summary>使用者Token紀錄表</summary>
    [Index(nameof(UserId))]
    public class UserRefreshTokenLog
    {
        /// <summary>使用者Token紀錄</summary>
        [Display(Name = "Token紀錄")]
        [Key]
        public string RefreshToken { get; set; } = null!;
        /// <summary>建立時間</summary>
        [Display(Name = "建立時間")]
        [Required]
        public DateTime CreateDate { get; set; }
        /// <summary>Token有效時間</summary>
        [Display(Name = "Token有效時間")]
        [Required]
        public DateTime ExpirationDate { get; set; }

        /// <summary>使用者Id</summary>
        [Display(Name = "使用者Id")]
        [Required]
        public int UserId { get; set; }
        public UserMain UserMain { get; set; } = null!;
    }
}
