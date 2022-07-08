using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backstage.Models
{
    /// <summary>消費者資料表</summary>
    [Index(nameof(Account))]
    public class UserMain
    {
        /// <summary>消費者Id</summary>
        [Display(Name = "消費者Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        /// <summary>消費者姓名</summary>
        [Display(Name = "姓名")]
        [Required]
        [MaxLength(20)]
        public string UserName { get; set; }
        /// <summary>消費者帳號</summary>
        [Display(Name = "帳號")]
        [Required]
        [MaxLength(20)]
        public string Account { get; set; }
        /// <summary>消費者密碼</summary>
        [Display(Name = "密碼")]
        [Required]
        [MaxLength(250)]
        public string Password { get; set; }
        /// <summary>消費者電子信箱</summary>
        [Display(Name = "電子信箱")]
        [Required]
        [MaxLength(250)]
        public string Email { get; set; }
        /// <summary>消費者地址</summary>
        [Display(Name = "地址")]
        [MaxLength(250)]
        public string? Address { get; set; }
        /// <summary>消費者出生年月日</summary>
        [Display(Name = "出生年月日")]
        [Required]
        [Column(TypeName = "Date")]
        public DateTime Birthday { get; set; }
        /// <summary>消費者帳號是否開啟</summary>
        [Display(Name = "帳號是否開啟")]
        [Required]
        public bool Flag { get; set; }
        /// <summary>電報功能</summary>
        [Display(Name = "電報功能")]
        [Required]
        public bool Cable { get; set; }
        /// <summary>隱私權</summary>
        [Display(Name = "隱私權")]
        [Required]
        public bool Privacy { get; set; }
        /// <summary>帳號建立時間</summary>
        [Display(Name = "建立時間")]
        [Required]
        public DateTime CreatedDate { get; set; }
        /// <summary>帳號修改時間</summary>
        [Display(Name = "修改時間")]
        public DateTime? ModifyDate { get; set; }

        public ICollection<UserLoginLog> UserLoginLogs { get; set; }
        public ICollection<UserRefreshTokenLog> UserRefreshTokenLogs { get; set; }
        public ICollection<SalesOrder> SalesOrders { get; set; }
    }
}