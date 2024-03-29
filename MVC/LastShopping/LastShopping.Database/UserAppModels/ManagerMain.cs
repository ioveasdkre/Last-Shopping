﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LastShopping.Database.UserAppModels
{
    /// <summary>管理者資料表</summary>
    [Index(nameof(Account))]
    [Index(nameof(ManagerRoleId))]
    public class ManagerMain
    {
        /// <summary>管理者ID</summary>
        [Display(Name = "管理者ID")]
        [Comment("管理者ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>管理者姓名</summary>
        [Display(Name = "姓名")]
        [Comment("姓名")]
        [Required]
        [MaxLength(20)]
        public string UserName { get; set; } = string.Empty;
        /// <summary>管理者帳號</summary>
        [Display(Name = "帳號")]
        [Comment("帳號")]
        [Required]
        [MaxLength(20)]
        public string Account { get; set; } = string.Empty;
        /// <summary>管理者密碼</summary>
        [Display(Name = "密碼")]
        [Comment("密碼")]
        [Required]
        [MaxLength(250)]
        public string Password { get; set; } = string.Empty;
        /// <summary>管理者電子信箱</summary>
        [Display(Name = "電子信箱")]
        [Comment("電子信箱")]
        [Required]
        [MaxLength(250)]
        public string Email { get; set; } = string.Empty;
        /// <summary>管理者地址</summary>
        [Display(Name = "地址")]
        [Comment("地址")]
        [Required]
        [MaxLength(250)]
        public string? Address { get; set; }
        /// <summary>管理者出生年月日</summary>
        [Display(Name = "出生年月日")]
        [Comment("管理者登入紀錄表Id")]
        [Required]
        [Column(TypeName = "Date")]
        public DateTime Birthday { get; set; }
        /// <summary>管理者帳號是否開啟</summary>
        [Display(Name = "帳號是否開啟")]
        [Comment("帳號是否開啟")]
        [Required]
        public bool Flag { get; set; }
        /// <summary>帳號建立時間</summary>
        [Display(Name = "建立時間")]
        [Comment("建立時間")]
        [Required]
        public DateTime CreatedDate { get; set; }
        /// <summary>帳號修改時間</summary>
        [Display(Name = "修改時間")]
        [Comment("修改時間")]
        public DateTime? ModifyDate { get; set; }

        /// <summary>管理者身分Id</summary>
        [Display(Name = "管理者身分Id")]
        [Comment("管理者身分Id")]
        [Required]
        public int ManagerRoleId { get; set; }
        [ForeignKey("ManagerRoleId")]
        public ManagerRole ManagerRole { get; set; } = null!;
        public ICollection<ManagerLoginLog> ManagerLoginLogs { get; set; } = null!;
        public ICollection<ManagerRefreshTokenLog> ManagerRefreshTokenLogs { get; set; } = null!;
    }
}
