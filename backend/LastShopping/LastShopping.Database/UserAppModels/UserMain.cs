using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LastShopping.Database.UserAppModels
{
    /// <summary>使用者資料表</summary>
    [Index(nameof(Account))]
    public class UserMain
    {
        /// <summary>使用者Id</summary>
        [Display(Name = "使用者Id")]
        [Comment("使用者Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>使用者姓名</summary>
        [Display(Name = "姓名")]
        [Comment("姓名")]
        [Required]
        [MaxLength(20)]
        public string Name { get; set; } = string.Empty;
        /// <summary>使用者帳號</summary>
        [Display(Name = "帳號")]
        [Comment("帳號")]
        [Required]
        [MaxLength(20)]
        public string Account { get; set; } = string.Empty;
        /// <summary>使用者密碼</summary>
        [Display(Name = "密碼")]
        [Comment("密碼")]
        [Required]
        [MaxLength(250)]
        public string Password { get; set; } = string.Empty;
        /// <summary>使用者電子信箱</summary>
        [Display(Name = "電子信箱")]
        [Comment("電子信箱")]
        [Required]
        [MaxLength(250)]
        public string Email { get; set; } = string.Empty;
        /// <summary>使用者地址</summary>
        [Display(Name = "地址")]
        [Comment("地址")]
        [MaxLength(250)]
        public string? Address { get; set; }
        /// <summary>使用者出生年月日</summary>
        [Display(Name = "出生年月日")]
        [Comment("出生年月日")]
        [Required]
        [Column(TypeName = "Date")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        /// <summary>使用者帳號是否開啟</summary>
        [Display(Name = "帳號是否開啟")]
        [Comment("帳號是否開啟")]
        [Required]
        public bool Flag { get; set; }
        /// <summary>電報功能</summary>
        [Display(Name = "電報功能")]
        [Comment("電報功能")]
        [Required]
        public bool Cable { get; set; }
        /// <summary>隱私權</summary>
        [Display(Name = "隱私權")]
        [Comment("隱私權")]
        [Required]
        public bool Privacy { get; set; }
        /// <summary>帳號建立時間</summary>
        [Display(Name = "建立時間")]
        [Comment("建立時間")]
        [Required]
        public DateTime CreatedDate { get; set; }
        /// <summary>帳號修改時間</summary>
        [Display(Name = "修改時間")]
        [Comment("修改時間")]
        public DateTime? ModifyDate { get; set; }

        public ICollection<UserLoginLog> UserLoginLogs { get; set; } = null!;
        public ICollection<UserRefreshTokenLog> UserRefreshTokenLogs { get; set; } = null!;
    }
}