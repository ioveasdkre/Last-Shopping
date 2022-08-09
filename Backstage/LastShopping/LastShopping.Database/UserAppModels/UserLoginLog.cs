using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LastShopping.Database.UserAppModels
{
    /// <summary>使用者登入紀錄表</summary>
    [Index(nameof(Id))]
    [Index(nameof(UserMainId))]
    public class UserLoginLog
    {
        /// <summary>使用者登入紀錄Id</summary>
        [Display(Name = "使用者登入紀錄Id")]
        [Comment("使用者登入紀錄Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>使用者登入時間</summary>
        [Display(Name = "登入時間")]
        [Comment("登入時間")]
        [Required]
        public DateTime LoginTime { get; set; }
        /// <summary>使用者登入成功失敗</summary>
        [Display(Name = "登入成功失敗")]
        [Comment("登入成功失敗")]
        [Required]
        public bool Flag { get; set; }

        /// <summary>使用者Id</summary>
        [Display(Name = "使用者Id")]
        [Comment("使用者Id")]
        [Required]
        public int UserMainId { get; set; }
        [ForeignKey("UserMainId")]
        public UserMain UserMain { get; set; } = null!;
    }
}
