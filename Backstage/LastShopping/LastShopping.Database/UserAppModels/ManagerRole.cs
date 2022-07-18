using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LastShopping.Database.UserAppModels
{
    /// <summary>管理者身分表</summary>
    public class ManagerRole
    {
        /// <summary>管理者身分Id</summary>
        [Display(Name = "管理平台身分Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ManagerRoleId { get; set; }
        /// <summary>管理者身分名稱</summary>
        [Display(Name = "身分名稱")]
        [Required]
        [StringLength(20)]
        public string ManagerRoleName { get; set; }
        /// <summary>建立時間</summary>
        [Display(Name = "建立時間")]
        [Required]
        public DateTime CreateDate { get; set; }
        /// <summary>修改時間</summary>
        [Display(Name = "修改時間")]
        public DateTime? ModifyDate { get; set; }

        public ICollection<ManagerMain> ManagerMains { get; set; }
        public ICollection<ManagerRoleAuth> ManagerRoleAuths { get; set; }
    }
}
