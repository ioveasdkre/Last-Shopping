using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LastShopping.Database.UserAppModels
{
    /// <summary>管理者登入紀錄表</summary>
    [Index(nameof(Id))]
    [Index(nameof(ManagerMainId))]
    public class ManagerLoginLog
    {
        /// <summary>管理者登入紀錄表Id</summary>
        [Display(Name = "管理者登入紀錄表Id")]
        [Comment("管理者登入紀錄表Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>管理者登入時間</summary>
        [Display(Name = "登入時間")]
        [Comment("管理者登入時間")]
        [Required]
        public DateTime LoginTime { get; set; }
        /// <summary>管理者登入成功失敗</summary>
        [Display(Name = "登入成功失敗")]
        [Comment("管理者登入成功失敗")]
        [Required]
        public bool Flag { get; set; }

        /// <summary>管理者Id</summary>
        [Display(Name = "管理者Id")]
        [Comment("管理者Id")]
        [Required]
        public int ManagerMainId { get; set; }
        [ForeignKey("ManagerMainId")]
        public ManagerMain ManagerMain { get; set; } = null!;
    }
}
