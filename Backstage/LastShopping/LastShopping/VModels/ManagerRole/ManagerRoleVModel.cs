using System.ComponentModel.DataAnnotations;

namespace LastShopping.VModels.ManagerRole
{
    public class ManagerRoleVModel
    {
        /// <summary>管理者身分Id</summary>
        [Display(Name = "管理平台身分Id")]
        [Key]
        public int ManagerRoleId { get; set; }
        /// <summary>管理者身分名稱</summary>
        [Display(Name = "身分名稱")]
        [Required]
        [StringLength(20)]
        public string ManagerRoleName { get; set; } = string.Empty;
        /// <summary>建立時間</summary>
        [Display(Name = "建立時間")]
        [Required]
        public DateTime CreateDate { get; set; }
        /// <summary>修改時間</summary>
        [Display(Name = "修改時間")]
        public DateTime? ModifyDate { get; set; }
    }
}
