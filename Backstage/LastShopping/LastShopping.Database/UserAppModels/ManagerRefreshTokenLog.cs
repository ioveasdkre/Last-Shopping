using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace LastShopping.Database.UserAppModels
{
    /// <summary>管理者Token紀錄表</summary>
    [Index(nameof(ManagerId))]
    public class ManagerRefreshTokenLog
    {
        /// <summary>管理者Token紀錄</summary>
        [Display(Name = "Token紀錄")]
        [Key]
        public string RefreshToken { get; set; }
        /// <summary>建立時間</summary>
        [Display(Name = "建立時間")]
        [Required]
        public DateTime CreateDate { get; set; }
        /// <summary>Token有效時間</summary>
        [Display(Name = "Token有效時間")]
        [Required]
        public DateTime ExpirationDate { get; set; }

        /// <summary>管理者Id</summary>
        [Display(Name = "管理者Id")]
        [Required]
        public int ManagerId { get; set; }
        public ManagerMain ManagerMain { get; set; }
    }
}
